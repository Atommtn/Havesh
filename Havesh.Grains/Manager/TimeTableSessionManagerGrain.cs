using System.Security.Cryptography.X509Certificates;
using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Entity;
using Havesh.Grains.Entity;
using Havesh.Model.Model;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Olive;
using Orleans.Runtime;
using Orleans.Streams;

namespace Havesh.Grains.Manager;

public class TimeTableSessionManagerGrain : HaveshManagerGrain, ITimeTableSessionManagerGrain
{
	private DataProviderService DataProviderService { get; }

	public TimeTableSessionManagerGrain(DataProviderService dataProviderService)
	{
		DataProviderService = dataProviderService;
	}

	public async Task<IEnumerable<TimeTableSession>?> GetTimeTableSessions(int timeTableId)
	{
		return CacheManager.GetOrSet("Sessions-"+timeTableId, () =>
		{
			var timeTableSessions = DataProviderService.GetTimeTableSessions(timeTableId);
			return timeTableSessions;
		}, CacheExpireTime);

	}

	
	public Task<TimeTableSession?> GetSessionByDate(int timeTableId, DateTime? datetime = null)
	{
		datetime ??= DateTime.Today;
		var sessionByDate = CacheManager.GetOrSet($"{timeTableId}-{datetime?.ToShortDateString()}",
			() => GetTimeTableSessions(timeTableId)
				.FirstOrDefault(x => x.SessionDate == datetime)
			, CacheExpireTime);

		return sessionByDate;
	}

	public async Task<IEnumerable<TimeTableSession>?> GetTimeTableSessions(TimeSpan sessionStartTime, DateTime? dateTime = null)
	{
		dateTime ??= DateTime.Today;
		return CacheManager.GetOrSet("TTS_" + dateTime?.ToShortDateString(),
			() => DataProviderService.GetTimeTableSessions(sessionStartTime , dateTime),
			CacheExpireTime);
	}

	public async Task<IEnumerable<SessionActivityValueOption>?> GetSessionActivitiesPerformed(int timeTableSessionId)
	{
		var ttsGrain = GrainFactory.GetGrain<ITimeTableSessionGrain>(timeTableSessionId);
		var activities = await ttsGrain.GetStudentSessionActivities();
		var sessionActivityValueOptions = activities?
			.Select(x => x.ActivityValueOption)
			.ToArray();
		return sessionActivityValueOptions;
	}
	public async Task<IEnumerable<StudentSessionActivity>?> GetSessionStudentActivitiesPerformed(int timeTableSessionId)
	{
		var ttsGrain = GrainFactory.GetGrain<ITimeTableSessionGrain>(timeTableSessionId);
		var activities = await ttsGrain.GetStudentSessionActivities();
		
		if (activities == null) 
			throw new ArgumentNullException(nameof(activities));

		return activities;
	}

}