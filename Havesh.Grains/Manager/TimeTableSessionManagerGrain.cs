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
		return CacheManager.GetOrSet("Sessions-"+timeTableId, () =>
		{
			var timeTableSessions = DataProviderService.GetTimeTableSessions(timeTableId);
			return timeTableSessions;
		}, TimeSpan.FromHours(1));

	}

	
	public Task<TimeTableSession?> GetSessionByDate(int timeTableId, DateTime? datetime = null)
	{
		datetime ??= DateTime.Today;
		var sessionByDate = CacheManager.GetOrSet($"{timeTableId}-{datetime?.ToShortDateString()}",
			() => GetTimeTableSessions(timeTableId)
				.FirstOrDefault(x => x.SessionDate == datetime)
			, TimeSpan.FromHours(1));

		return sessionByDate;
	}

	public async Task<IEnumerable<TimeTableSession>?> GetTimeTableSessions(TimeSpan sessionStartTime, DateTime? dateTime = null)
	{
		dateTime ??= DateTime.Today;
		return CacheManager.GetOrSet("TTS_" + dateTime?.ToShortDateString(),
			() => DataProviderService.GetTimeTableSessions(sessionStartTime , dateTime),
			TimeSpan.FromHours(1));
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