using Havesh.Application.Services;
using Havesh.GrainInterfaces.Common;
using Microsoft.Extensions.Caching.Memory;

namespace Havesh.Grains.Manager;

public class HaveshManagerGrainBase : Grain , IResetSupportManagerGrain
{
	protected DataProviderService? DataProviderService;

	protected readonly CacheManager CacheManager;
	protected virtual TimeSpan CacheExpireTime => TimeSpan.FromHours(1);
	protected string GrainBranchKey
	{
		get
		{
			_ = this.GetPrimaryKey(out var branch);
			return branch;
		}
	}

	public override Task OnActivateAsync(CancellationToken cancellationToken)
	{
		if(DataProviderService is not null) DataProviderService.BranchName = GrainBranchKey;
		return base.OnActivateAsync(cancellationToken);
	}

	protected HaveshManagerGrainBase()
	{
		CacheManager = new CacheManager(new MemoryCache(new MemoryCacheOptions()));
	}

	public Task DeactivateGrainAsync()
	{
		DeactivateOnIdle();
		return Task.CompletedTask;
	}

	public Task ResetGrainCacheAsync()
	{
		CacheManager.ClearCache();
		return Task.CompletedTask;
	}
}