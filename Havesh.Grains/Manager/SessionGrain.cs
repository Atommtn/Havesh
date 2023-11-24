using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Manager;

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
		var timeTableSessionById = DataProviderService.GetTimeTableSessionById(id , 
			q => 
				q.Include(x=>x.TimeTable)
					.ThenInclude(x=>x.Level)
		);

		return timeTableSessionById;
	}

	protected override void UpdateEntity(TimeTableSession entity)
	{
		DataProviderService.UpdateTimeTableSession(entity);
	}

	public async Task<IEnumerable<SessionActivity>?> GetActivities()
	{
		var session = await Get();
		if (session is null) return null;

		var sessionActivities = CacheManager.GetOrSet("SessionActivities-" + GrainKey,  
			() => DataProviderService.GetSessionActivities(session)
			, TimeSpan.FromHours(1));

		return sessionActivities;
	}
}