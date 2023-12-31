using Havesh.GrainInterfaces.Common;
using Microsoft.Extensions.Caching.Memory;

namespace Havesh.Grains.Manager;

public class HaveshManagerGrainBase : Grain , IResetSupportManagerGrain
{
	protected readonly CacheManager CacheManager;
	protected virtual TimeSpan CacheExpireTime => TimeSpan.FromHours(1);

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