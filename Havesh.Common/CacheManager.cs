using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havesh.GrainInterfaces.Common;

public class CacheManager
{
	private readonly IMemoryCache _cache;

	public CacheManager(IMemoryCache memoryCache)
	{
		_cache = memoryCache;
	}

	private readonly ImmutableList<object> _keys = ImmutableList<object>.Empty;
	
	public void ClearCache()
	{
		foreach (var key in _keys.ToImmutableArray()) 
			Remove(key);
	}


	public async Task<T> GetOrSet<TK,T>(TK key, Func<Task<T>> getItemCallback, TimeSpan cacheTime)
	{
		if (key != null && _cache.TryGetValue(key, out T? cacheEntry)) 
			return cacheEntry;

		// Item not in cache, so fetch data
		cacheEntry = await getItemCallback();

		// Set cache options
		var cacheEntryOptions = new MemoryCacheEntryOptions
		{
			AbsoluteExpirationRelativeToNow = cacheTime,
			// You can also use options like SlidingExpiration, Priority, etc.
		};

		// Save data in cache
		if (key == null) 
			return cacheEntry;

		_keys.Add(key);
		_cache.Set(key, cacheEntry, cacheEntryOptions);

		return cacheEntry;
	}

	public T GetOrSet<TK,T>(TK key, Func<T> getItemCallback, TimeSpan cacheTime)
	{
		if (key != null && _cache.TryGetValue(key, out T? cacheEntry)) 
			return cacheEntry;

		// Item not in cache, so fetch data
		cacheEntry = getItemCallback();

		// Set cache options
		var cacheEntryOptions = new MemoryCacheEntryOptions
		{
			AbsoluteExpirationRelativeToNow = cacheTime,
			// You can also use options like SlidingExpiration, Priority, etc.
		};

		// Save data in cache
		if (key != null) 
			_cache.Set(key, cacheEntry, cacheEntryOptions);

		return cacheEntry;
	}

	public T? Update<TK,T>(TK key , T value)
	{
		return _cache.Set(key, value);
	}

	public void Remove<TK>(TK key )
	{
		_keys.Remove(key);
		_cache.Remove(key);
	}

}