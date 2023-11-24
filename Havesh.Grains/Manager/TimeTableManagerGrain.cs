using System.Collections.Concurrent;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Manager;
using Havesh.Model.Model;
using Microsoft.Extensions.Caching.Memory;

namespace Havesh.Grains.Manager;

public class TimeTableManagerGrain : Grain, ITimeTableManagerGrain
{
	private readonly CacheManager _cacheManager;
	DataProviderService DataProviderService { get; }

	public TimeTableManagerGrain(DataProviderService dataProviderService)
	{
		DataProviderService = dataProviderService;
		_cacheManager = new CacheManager(new MemoryCache(new MemoryCacheOptions()));
	}

	public Task<ShokouhPardisTimeTable?> GetTeacherTimeTable(int termId, int teacherId, int weekdayId, int intervalId)
	{
		var key = $"{termId}-{teacherId}-{weekdayId}-{intervalId}";
		return _cacheManager.GetOrSet(key, async () =>
		{
			var timeTable = DataProviderService.GetTeacherTimeTable(termId, teacherId, weekdayId, intervalId);
			if (timeTable == null) 
				return timeTable;

			var timeTableGrain = GrainFactory.GetGrain<IHaveshGrain<ShokouhPardisTimeTable>>(timeTable.Id);
			await timeTableGrain.Set(timeTable);
			return timeTable;
		}, TimeSpan.FromHours(1));
		
	}
}