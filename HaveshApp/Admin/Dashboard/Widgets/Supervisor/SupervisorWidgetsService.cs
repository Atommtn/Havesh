using Havesh.GrainInterfaces.Entity;
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
		UserSessionService userSession,
		ILogger<SupervisorWidgetsService> logger)
		: base(clusterClient, userSession)
	{
		_clusterClient = clusterClient;
		_logger = logger;
	}


	public async Task<IEnumerable<ShokouhPardisTimeTable>?> GetIntervalTimeTables()
	{
		var interval = await GetInterval();
		var intervalGrain = ClusterClient.GetGrain<IIntervlalGrain>(interval.Id);
		var weekday = await GetWeekday();
		var timeTables = await intervalGrain.GetIntervalTimeTables(weekday.Id);
		return timeTables;

	}

	public async Task<IEnumerable<TimeTableSession>?> GetTimeTableSessions()
	{
		var interval = await GetInterval();
		if (interval?.StartTime == null) return null;

		var managerGrain = ClusterClient.GetGrain<ITimeTableSessionManagerGrain>(Guid.Empty);
		var timeTableSessions = await managerGrain.GetTimeTableSessions(interval.StartTime.Value, _date);
		return timeTableSessions;
	}

}