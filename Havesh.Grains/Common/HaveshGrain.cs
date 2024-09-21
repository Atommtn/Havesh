using Havesh.Common;
using Havesh.Application.Services;
using Havesh.GrainInterfaces;
using Havesh.GrainInterfaces.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Data;
using Havesh.Model.Model;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Common;

public abstract class HaveshGrain<T>
    : Grain, IHaveshGrain<T>
    where T : class
{
    protected readonly IPersistentState<HaveshGrainState<T>> PersistentState;
    private readonly IGrainContext _grainContext;
    protected readonly DataProviderService DataProviderService;
    protected ILogger<HaveshGrain<T>> Logger { get; }

    protected readonly CacheManager CacheManager;
    protected string GrainKey => this.GetPrimaryKeyString();
    protected int GrainKeyInt
    {
        get
        {
            var branchName = Environment.GetEnvironmentVariable("BranchName");
            return Convert.ToInt32(this.GetPrimaryKeyString().Replace(branchName, null));
        }
    }

    protected HaveshGrain(
        IPersistentState<HaveshGrainState<T>> persistentState,
        IGrainContext grainContext,
        DataProviderService dataProviderService,
        ILogger<HaveshGrain<T>> logger)
    {
        PersistentState = persistentState;
        _grainContext = grainContext;
        DataProviderService = dataProviderService;
        Logger = logger;
        CacheManager = new CacheManager(new MemoryCache(new MemoryCacheOptions()));
    }

	protected void EnusureState(bool forceDbLoad = false)
	{
		if (forceDbLoad == false && 
		    PersistentState.State.Item != null && 
		    PersistentState.State.IsInitialized) 
			return;

		PersistentState.State.Item = GetEntity(GrainKeyInt);
		PersistentState.State.IsInitialized = true;

	}
	public async Task<T?> Get(bool? forceFromDb = null)
    {

		Logger.LogInformation(typeof(T).Name + " - " + nameof(Get) + " requested by Id: " + GrainKey);

		if (forceFromDb is null or false && PersistentState.State.Item != null)
            return PersistentState.State.Item;

        if (string.IsNullOrEmpty(GrainKey ))
            return default(T);

        PersistentState.State.Item = GetEntity(GrainKeyInt);
        PersistentState.State.IsInitialized = true;

		return PersistentState.State.Item;
    }

    protected abstract T? GetEntity(int id);


    public virtual async Task Set(T? entity)
    {
        PersistentState.State.IsInitialized = true;

        if (entity is null)
        {
            await PersistentState.ClearStateAsync();
            return;
        }

        PersistentState.State.Item = entity;
        Logger.LogTrace($"{this}<{GetType().Name}> State Updated for id[{this.GetPrimaryKeyLong()}]");
    }

    public virtual async Task Update(T? entityState)
    {
        await Set(entityState);

        if (entityState != null)
        {
            UpdateEntity(entityState);
        }
    }

    public virtual async Task SafeRemove(T? entityState)
    {
        await DeleteEntity(entityState);
    }

    protected abstract void UpdateEntity(T entity);

    protected async virtual Task DeleteEntity(T? entity)
    {
        if (entity is not ICanBeSoftDeleted delEntity)
            return;

        delEntity.IsDeleted = true;
        UpdateEntity(entity);
    }

    public Task DeactivateGrainAsync()
    {
        DeactivateOnIdle();
        return Task.CompletedTask;
    }

    public override Task OnDeactivateAsync(DeactivationReason reason, CancellationToken cancellationToken)
    {
	    Logger.LogWarning(" -------------------------------------------Grain has been Deactivated : " + this.IdentityString);
	    return base.OnDeactivateAsync(reason, cancellationToken);
    }

    public Task ResetGrainCacheAsync()
    {
        CacheManager.ClearCache();
	    return PersistentState.ClearStateAsync();
    }
}