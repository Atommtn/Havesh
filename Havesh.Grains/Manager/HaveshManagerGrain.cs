using Havesh.GrainInterfaces.Common;
using Microsoft.Extensions.Caching.Memory;

namespace Havesh.Grains.Manager;

public class HaveshManagerGrain : Grain
{
	protected readonly CacheManager CacheManager;
	protected virtual TimeSpan CacheExpireTime => TimeSpan.FromHours(1);

	protected HaveshManagerGrain()
	{
		CacheManager = new CacheManager(new MemoryCache(new MemoryCacheOptions()));
	}

}