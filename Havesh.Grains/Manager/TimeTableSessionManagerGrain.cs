using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Olive;
using Orleans.Runtime;

namespace Havesh.Grains.Manager;

public class TimeTableSessionManagerGrain : Grain, ITimeTableSessionManagerGrain
{
	private CacheManager CacheManager { get; }
	private DataProviderService DataProviderService { get; }

	public TimeTableSessionManagerGrain(DataProviderService dataProviderService)
	{
		DataProviderService = dataProviderService;
		// Create CacheManager instance
		CacheManager = new CacheManager(new MemoryCache(new MemoryCacheOptions()));
	}

	public async Task<IEnumerable<TimeTableSession>?> GetTimeTableSessions(int timeTableId)
	{
		return CacheManager.GetOrSet(timeTableId, () =>
		{
			var timeTableSessions = DataProviderService.GetTimeTableSessions(timeTableId);
			return timeTableSessions;
		}, TimeSpan.FromHours(1));

	}

	public Task<TimeTableSession?> GetSessionByDate(int timeTableId, DateTime datetime)
	{

		return CacheManager.GetOrSet($"{timeTableId}-{datetime.ToShortDateString()}",
			() => GetTimeTableSessions(timeTableId)
								.FirstOrDefault(x => x.SessionDate == datetime)
			, TimeSpan.FromHours(1));
	}
}

public interface ITimeTableSessionManagerGrain : IGrainWithGuidKey
{
	Task<IEnumerable<TimeTableSession>?> GetTimeTableSessions(int timeTableId);
	Task<TimeTableSession?> GetSessionByDate(int timeTableId, DateTime today);
}


public class SessionGrain : HaveshGrain<TimeTableSession> , ISessionGrain
{
	public SessionGrain(
		[PersistentState(nameof(SessionGrain) , HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<TimeTableSession>> persistentState, 
		IGrainContext grainContext, 
		DataProviderService dataProviderService, 
		ILogger<HaveshGrain<TimeTableSession>> logger) 
			: base(persistentState, grainContext, dataProviderService, logger)
	{

	}

	protected override TimeTableSession? GetEntity(int id)
	{
		return DataProviderService.GetTimeTableSessionById(id , 
			q => 
				q.Include(x=>x.TimeTable)
					.ThenInclude(x=>x.Level)
				);
	}

	protected override void UpdateEntity(TimeTableSession entity)
	{
		DataProviderService.UpdateTimeTableSession(entity);
	}

	public async Task<IEnumerable<SessionActivity>?> GetActivities()
	{
		var session = await Get();
		if (session is null) return null;

		return CacheManager.GetOrSet("SessionActivities-" + GrainKey,  
			() => DataProviderService.GetSessionActivities(session).AsEnumerable()
			, TimeSpan.FromHours(1));
	}
}

public interface ISessionGrain : IGrainWithIntegerKey
{
	Task<IEnumerable<SessionActivity>?> GetActivities();
}