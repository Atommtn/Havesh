using System.Security.Cryptography.X509Certificates;
using Havesh.Common;
using Havesh.Application.Services;
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

public class TimeTableSessionManagerGrain : HaveshManagerGrainBase, ITimeTableSessionManagerGrain
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

	public async Task<IEnumerable<TimeTableSession>?> GetTimeTableSessionsSummary(int timeTableId)
	{
		return CacheManager.GetOrSet("Sessions-summary-"+timeTableId, () =>
		{
			var timeTableSessions = DataProviderService.GetTimeTableSessionActivitySummary(timeTableId);
			return timeTableSessions;
		}, CacheExpireTime);

	}

	public async Task<IDictionary<TimeTableSession, IEnumerable<IEnumerable<StudentSessionActivity>>>?> GetTimeTableSessionsIncludeActivities(int timeTableId)
	{
		throw new Exception();
/*
//		return CacheManager.GetOrSet("Sessions-withActivities-" + timeTableId, () =>
		//{
			Dictionary<TimeTableSession, IEnumerable<IEnumerable<StudentSessionActivity>>> dictionary = new();
			var timeTableSessions = GetTimeTableSessions(timeTableId);
			var ids = timeTableSessions.Select(x => x.Id);
			var managerGrain = GrainFactory.GetGrain<IStudentSessionActivityManagerGrain>(HaveshConstants.GeneralKey);
			var sessionActivities = await managerGrain.GetGeneralSesionActivities();
			var managerGrain2 = GrainFactory.GetGrain<ISessionActivityOptionManagerGrain>(HaveshConstants.GeneralKey);


			return timeTableSessions;
		//}, CacheExpireTime);

	*/
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
		var branchName = Environment.GetEnvironmentVariable("BranchName");
		var ttsGrain = GrainFactory.GetGrain<ITimeTableSessionGrain>(branchName+timeTableSessionId);
		var activities = await ttsGrain.GetStudentSessionActivities();
		var sessionActivityValueOptions = activities?
			.Select(x => x.ActivityValueOption)
			.ToArray();
		return sessionActivityValueOptions;
	}
	public async Task<IEnumerable<StudentSessionActivity>?> GetSessionStudentActivitiesPerformed(int timeTableSessionId)
	{
		var branchName = Environment.GetEnvironmentVariable("BranchName");

		var ttsGrain = GrainFactory.GetGrain<ITimeTableSessionGrain>(branchName+timeTableSessionId);
		var activities = await ttsGrain.GetStudentSessionActivities();
		
		if (activities == null) 
			throw new ArgumentNullException(nameof(activities));

		return activities;
	}

}