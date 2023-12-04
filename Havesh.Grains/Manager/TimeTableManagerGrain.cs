using System.Collections.Concurrent;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Manager;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Olive;

namespace Havesh.Grains.Manager;

public class TimeTableManagerGrain : HaveshManagerGrain, ITimeTableManagerGrain
{
	DataProviderService DataProviderService { get; }

	public TimeTableManagerGrain(DataProviderService dataProviderService)
	{
		DataProviderService = dataProviderService;
	}

	public Task<ShokouhPardisTimeTable?> GetTeacherTimeTable(int termId, int teacherId, int weekdayId, int intervalId)
	{
		var key = $"{termId}-{teacherId}-{weekdayId}-{intervalId}";
		return CacheManager.GetOrSet(key, async () =>
		{
			var timeTable = DataProviderService.GetTeacherTimeTable(termId, teacherId, weekdayId, intervalId);
			if (timeTable == null) 
				return timeTable;

			var timeTableGrain = GrainFactory.GetGrain<IHaveshGrain<ShokouhPardisTimeTable>>(timeTable.Id);
			await timeTableGrain.Set(timeTable);
			return timeTable;
		}, CacheExpireTime );
		
	}

	public async Task<IEnumerable<ShokouhPardisTimeTable>?> GetTermTimeTablesIncludeSeaaions(int termId,string? search = null)
	{
		return CacheManager.GetOrSet($"TimeTablesInTerm-{search}-" + termId, () =>
		{
			var timeTables = 
				DataProviderService.GetTimeTables(termId , search,null,null, timeTables =>
			{
				return timeTables.Include(x => x.Sessions);
			});
			return timeTables;

		}, search.IsEmpty() ? CacheExpireTime : TimeSpan.FromMinutes(3));
	}
}