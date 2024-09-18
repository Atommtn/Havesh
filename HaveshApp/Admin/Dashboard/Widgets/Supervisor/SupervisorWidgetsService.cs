using Havesh.Application.Services;
using Havesh.GrainInterfaces.Entity;
using Havesh.GrainInterfaces.System;
using Havesh.Grains.Manager;
using Havesh.Model.Model;
using HaveshApp.Admin.Authentication;

namespace HaveshApp.Admin.Dashboard.Widgets.Supervisor;

public class SupervisorWidgetsService : WidgetServiceBase
{
	private readonly IClusterClient _clusterClient;

	private readonly ILogger<SupervisorWidgetsService> _logger;
	//private HaveshStreamConsumer<StudentSessionActivity> _consumer;
	public SupervisorWidgetsService(
		IClusterClient clusterClient,
		ILogger<SupervisorWidgetsService> logger,
		UserSessionService userSession,
		DataProviderService dataProviderService)
		: base(clusterClient, userSession, dataProviderService)
	{
		_clusterClient = clusterClient;
		_logger = logger;
	}


	public async Task<IEnumerable<ShokouhPardisTimeTable>?> GetIntervalTimeTables()
	{
		var interval = await GetInterval();
		var branchName = Environment.GetEnvironmentVariable("BranchName");
		var intervalGrain = ClusterClient.GetGrain<IIntervallGrain>(branchName+interval.Id);
		var weekday = await GetWeekday();
		var timeTables = await intervalGrain.GetIntervalTimeTables(weekday.Id);
		return timeTables;

	}

	public async Task<IEnumerable<TimeTableSession>?> GetTimeTableSessions()
	{
		var interval = await GetInterval();
		if (interval?.StartTime == null) return null;

		var managerGrain = ClusterClient.GetGrain<ITimeTableSessionManagerGrain>(Guid.Empty);
		var settingsGrain = ClusterClient.GetGrain<ISettingsGrain>(UserSession.UserName);
		var _date = await settingsGrain.Date();
		var timeTableSessions = await managerGrain.GetTimeTableSessions(interval.StartTime.Value, _date);
		return timeTableSessions;
	}

}