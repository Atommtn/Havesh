using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Entity;
using Havesh.GrainInterfaces.Manager;
using Havesh.GrainInterfaces.System;
using Havesh.Grains.Entity;
using Havesh.Grains.Manager;
using Havesh.Model.Model;
using HaveshApp.Admin.Authentication;
using Microsoft.EntityFrameworkCore;
using Olive;

namespace HaveshApp.Admin.Dashboard.Widgets;

public class WidgetServiceBase
{
	protected readonly IClusterClient ClusterClient;
	protected readonly UserSessionService UserSession;
	private readonly DataProviderService _dataProviderService;

	protected WidgetServiceBase(
		IClusterClient clusterClient,
		UserSessionService userSession ,
		DataProviderService dataProviderService)
	{
		ClusterClient = clusterClient;
		UserSession = userSession;
		_dataProviderService = dataProviderService;
	}
//	protected DateTime _date;

	protected async Task<ShokouhPardisTermClass?> GetTerm()
	{
		var termManager = ClusterClient.GetGrain<ITermGrainManager>(Guid.Empty);
		var settingsGrain = ClusterClient.GetGrain<ISettingsGrain>(UserSession.UserName);
		var _date = await settingsGrain.Date();
		var term = await termManager.GetTermsInRangeToday(_date) 
		           ?? 
		           await termManager.GetLatestTerm();

		return term ?? null;
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
		var settingsGrain = ClusterClient.GetGrain<ISettingsGrain>(UserSession.UserName);
		var _date = await settingsGrain.Date();
		var timeTableSession = await timeTableGrain.GetTodaySession(_date);
		if (timeTableSession == null) return null;

		var activities = await GetTimeTableSessionActivities(timeTableSession.Id);
		return activities;
	}

	public TimeTableSession? GetTimeTableSessionById(int sessionId,bool? reloadFromDb = null)
	{
		//var sessionGrain = ClusterClient.GetGrain<IHaveshGrain<TimeTableSessionGrainState>>(sessionId);
		//var session = await sessionGrain.Get();
		var session = _dataProviderService.GetTimeTableSessionById(sessionId,
				q =>
					q
						//.AsNoTracking()

						.Include(x => x.Teacher)
						//.AsNoTracking()

						.Include(x => x.TimeTable)
						.ThenInclude(x => x.Teacher)
						//.AsNoTrackingWithIdentityResolution()

						.Include(x => x.TimeTable)
						.ThenInclude(x => x.ClassRoom)
						//.AsNoTracking()

						.Include(x => x.TimeTable)
						.ThenInclude(x => x.Level)
				//.AsNoTracking()
			);
		return session;
	}

	public List<StudentSessionActivity> GetStudentSessionActivityPerformed(int timeTableSessionId)
	{
		var activities = _dataProviderService
			.GetStudentSessionActivityPerformed(timeTableSessionId,

				q => q
					//.AsNoTracking()

					.Include(x => x.Activity)
					//.AsNoTracking()

					.Include(x => x.ActivityValueOption)
					//.AsNoTracking()

					.Include(x => x.Student)
					//.AsNoTracking()

					.Include(x => x.TimeTableSession)
					.ThenInclude(x => x.Teacher)
					//.AsNoTracking()

					.Include(x => x.TimeTableSession)
					.ThenInclude(x => x.TimeTable)
					.ThenInclude(x => x.Teacher)

				//.AsNoTracking()
			);
		return activities;
	}

	public SessionActivity? GetTimeTableSessionActivityById(int activityId)
	{
		/*
		var sessionActivityGrain = ClusterClient.GetGrain<IHaveshGrain<SessionActivity>>(activityId);
		var activity = await sessionActivityGrain.Get();
		*/
		var activity = _dataProviderService.GetSessionActivity(activityId);
		return activity;
	}

	protected async Task<TimeTableSession?> GetTimeTableSession(ShokouhPardisTimeTable? timeTable)
	{
		if (timeTable == null)
			return null;

		var settingsGrain = ClusterClient.GetGrain<ISettingsGrain>(UserSession.UserName);
		var _date = await settingsGrain.Date();


		var timeTableGrain = ClusterClient.GetGrain<ITimeTableGrain>(timeTable.Id);
		var timeTableSession = await timeTableGrain.GetTodaySession(_date);
		return timeTableSession;
	}

	protected async Task<ShokouhPardisWeekDay> GetWeekday()
	{
		var weekdayManagerGrain = ClusterClient.GetGrain<IWeekdayManagerGrain>(Guid.Empty);
		var settingsGrain = ClusterClient.GetGrain<ISettingsGrain>(UserSession.UserName);
		var _date = await settingsGrain.Date();
		var weekday = await weekdayManagerGrain.GetTodayWeekDay((int)_date.DayOfWeek);
		return weekday;
	}

	public async Task<ShokouhPardisInterval?> GetInterval(ShokouhPardisTermClass? term = null)
	{
		// _TODO: Should be remark ->
		//var startTime = TimeSpan.Parse("14:00");// DateTime.Now;
		var settingsGrain = ClusterClient.GetGrain<ISettingsGrain>(UserSession.UserName);
		var startTime = await settingsGrain.Time();
		// var startTime = UserSession.Debug?.time ?? DateTime.Now.TimeOfDay;

		term ??= await GetTerm();
		var termGrain = ClusterClient.GetGrain<ITermGrain>(term.Id);
		var fromMinutes = TimeSpan.FromMinutes(3);
		return await termGrain.GetIntervalByStartTime(startTime, fromMinutes);
	}

}