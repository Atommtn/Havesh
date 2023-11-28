using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Entity;
using Havesh.GrainInterfaces.Manager;
using Havesh.Grains;
using Havesh.Grains.Common;
using Havesh.Grains.Entity;
using Havesh.Grains.Manager;
using Havesh.Model.Model;
using Havesh.OrleansClient;
using HaveshApp.Admin.Authentication;
using HaveshApp.Classes.Auth;
using Microsoft.AspNetCore.Http;
using MudBlazor;
using Olive;
using Orleans.Runtime;

namespace HaveshApp.Admin.Dashboard.Widgets.Teacher;

public class SupervisorWidgetsService : WidgetServiceBase
{
	private readonly ILogger<SupervisorWidgetsService> _logger;
	private HaveshStreamConsumer<StudentSessionActivity> _consumer;
	public SupervisorWidgetsService(
		IClusterClient clusterClient,
		UserSessionService userSession,
		ILogger<SupervisorWidgetsService> logger)
		: base(clusterClient, userSession)
	{
		_logger = logger;
		var streamProvider = clusterClient.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
		var stream1 = streamProvider.GetStream<StudentSessionActivity>(StreamId.Create(HaveshConstants.StudentSessionActivityStreamNamespace, HaveshConstants.GeneralKey));
		_consumer = new HaveshStreamConsumer<StudentSessionActivity>(OnStudentSessionActivityPerform);
		stream1.SubscribeAsync(_consumer);

		// var stream2 = streamProvider.GetStream<StudentSessionActivity>(StreamId.Create(HaveshConstants.StudentSessionActivityToRoleStreamNamespace, "Supervisor"));
		// _consumer2 = new HaveshStreamConsumer(OnStudentSessionActivityPerform);
		// stream1.SubscribeAsync(_consumer2);

	}

	private void OnStudentSessionActivityPerform(StudentSessionActivity arg)
	{

		_logger.Info($"Received Student Activity Performed by Student Id : {arg.StudentFk} Value: {arg.ActivityValue}");
		OnStudentActivityPerformed?.Invoke(arg);
	}

	public event Func<StudentSessionActivity, Task>? OnStudentActivityPerformed;


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
		var timeTableSessions = await managerGrain.GetTimeTableSessions(interval.StartTime.Value, _dateTime);
		return timeTableSessions;
	}
}