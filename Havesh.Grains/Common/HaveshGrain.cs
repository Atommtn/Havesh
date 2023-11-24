using Havesh.Common;
using Havesh.Domain.Services;
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
    private readonly ILogger<HaveshGrain<T>> _logger;

    protected readonly CacheManager CacheManager;
    protected int GrainKey => (int)this.GetPrimaryKeyLong();

	protected HaveshGrain(
        IPersistentState<HaveshGrainState<T>> persistentState,
        IGrainContext grainContext,
        DataProviderService dataProviderService,
        ILogger<HaveshGrain<T>> logger)
    {
        PersistentState = persistentState;
        _grainContext = grainContext;
        DataProviderService = dataProviderService;
        _logger = logger;
        CacheManager = new CacheManager(new MemoryCache(new MemoryCacheOptions()));
    }

	public async Task<T?> Get()
    {
        var primaryKey = (int)this.GetPrimaryKeyLong();
        _logger.LogInformation(nameof(Get) + " requested by Id: " + primaryKey);

		if (PersistentState.State.Item != null)
            return PersistentState.State.Item;

        if (primaryKey == 0)
            return default(T);

        PersistentState.State.Item = GetEntity(primaryKey);
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
        _logger.LogTrace($"{this}<{GetType().Name}> State Updated for id[{this.GetPrimaryKeyLong()}]");
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
}