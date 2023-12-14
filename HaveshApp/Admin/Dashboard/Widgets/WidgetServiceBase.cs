using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Entity;
using Havesh.GrainInterfaces.Manager;
using Havesh.Grains.Entity;
using Havesh.Grains.Manager;
using Havesh.Model.Model;
using HaveshApp.Admin.Authentication;
using Olive;

namespace HaveshApp.Admin.Dashboard.Widgets;

public class WidgetServiceBase
{
	protected readonly IClusterClient ClusterClient;
	protected readonly UserSessionService UserSession;

	protected WidgetServiceBase(
		IClusterClient clusterClient,
		UserSessionService userSession)
	{
		ClusterClient = clusterClient;
		UserSession = userSession;
	}
#if DEBUG
	protected readonly DateTime _dateTime = new(2023, 11, 26);
#else
		protected readonly DateTime _dateTime = DateTime.Today;
#endif
	protected async Task<ShokouhPardisTermClass?> GetTerm()
	{
		var termManager = ClusterClient.GetGrain<ITermGrainManager>(Guid.Empty);
		var term = await termManager.GetTermsInRangeToday(_dateTime);

		if (term == null)
			return null;

		return term;
	}

	private async Task<IEnumerable<SessionActivity>?> GetTimeTableSessionActivities(int sessionId)
	{
		var sessionGrain = ClusterClient.GetGrain<ITimeTableSessionGrain>(sessionId);
		var activities = 
			((await sessionGrain.GetSessionActivities())!)
			.ToList(); 
		return activities;

	}

	protected async Task<IEnumerable<SessionActivity>?> GetTimeTableSessionActivities(ShokouhPardisTimeTable? timeTable)
	{

		if (timeTable == null) return null;

		var timeTableGrain = ClusterClient.GetGrain<ITimeTableGrain>(timeTable.Id);
		var timeTableSession = await timeTableGrain.GetTodaySession(_dateTime);
		if (timeTableSession == null) return null;

		var activities = await GetTimeTableSessionActivities(timeTableSession.Id);
		return activities;
	}

	public async Task<TimeTableSession?> GetTimeTableSessionById(int sessionId,bool? reloadFromDb = null)
	{
		var sessionGrain = ClusterClient.GetGrain<IHaveshGrain<TimeTableSessionGrainState>>(sessionId);
		var session = await sessionGrain.Get();
		return session.TimeTableSession;
	}
	public async Task<SessionActivity?> GetTimeTableSessionActivityById(int activityId)
	{
		var sessionActivityGrain = ClusterClient.GetGrain<IHaveshGrain<SessionActivity>>(activityId);
		var activity = await sessionActivityGrain.Get();
		return activity;
	}

	protected async Task<TimeTableSession?> GetTimeTableSession(ShokouhPardisTimeTable? timeTable)
	{
		if (timeTable == null)
			return null;

		var timeTableGrain = ClusterClient.GetGrain<ITimeTableGrain>(timeTable.Id);
		var timeTableSession = await timeTableGrain.GetTodaySession(_dateTime);
		return timeTableSession;
	}

	protected async Task<ShokouhPardisWeekDay> GetWeekday()
	{
		var weekdayManagerGrain = ClusterClient.GetGrain<IWeekdayManagerGrain>(Guid.Empty);
#if DEBUG

		var weekday = Environment.GetEnvironmentVariable("FRZ_TEST") == "true"
			? await weekdayManagerGrain.GetTodayWeekDay(0)!
			: await weekdayManagerGrain.GetTodayWeekDay()!;
#else
		var weekday = await weekdayManagerGrain.GetTodayWeekDay()!;
#endif
		return weekday;
	}

	public async Task<ShokouhPardisInterval?> GetInterval(ShokouhPardisTermClass? term = null)
	{
		// _TODO: Should be remark ->
		//var startTime = TimeSpan.Parse("14:00");// DateTime.Now;
#if DEBUG
		var startTime = // DateTime.Now;
			Environment.GetEnvironmentVariable("FRZ_TEST") == "true"
				? TimeSpan.Parse("14:00")
				: DateTime.Now.TimeOfDay;
#else
			var startTime = DateTime.Now.TimeOfDay;
#endif

		term ??= await GetTerm();
		var termGrain = ClusterClient.GetGrain<ITermGrain>(term.Id);
		var fromMinutes = TimeSpan.FromMinutes(3);
		return await termGrain.GetIntervalByStartTime(startTime, fromMinutes);
	}

}