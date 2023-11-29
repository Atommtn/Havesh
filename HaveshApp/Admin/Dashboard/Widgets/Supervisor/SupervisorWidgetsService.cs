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
using Orleans.Streams;

namespace HaveshApp.Admin.Dashboard.Widgets.Teacher;

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

	private StreamSubscriptionHandle<StudentSessionActivity>? _streamSubscriptionHandle;
	public async Task InitSubscribeToStudentActivityPerformAsync()
	{
		if (_streamSubscriptionHandle != null) return;

		var streamProvider = _clusterClient.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
		var stream1 = streamProvider.GetStream<StudentSessionActivity>(
			StreamId.Create(HaveshConstants.StudentSessionActivityStreamNamespace, HaveshConstants.GeneralKey));
		var consumer = new HaveshStreamConsumer<StudentSessionActivity>(OnStudentSessionActivityPerform);
		_streamSubscriptionHandle = await stream1.SubscribeAsync(consumer);
	}

	private Func<StudentSessionActivity, Task>? _onStudentActivityPerformedEvent;
	private readonly object _eventLock = new();
	private Task OnStudentSessionActivityPerform(StudentSessionActivity arg)
	{
		_logger.Info($"Received Student Activity Performed by Student Id : {arg.StudentFk} Value: {arg.ActivityValue}");
		return _onStudentActivityPerformedEvent != null 
			? _onStudentActivityPerformedEvent.Invoke(arg) 
			: Task.CompletedTask;
	}

	private int _onStudentActivityPerformedCount = 0;

	public event Func<StudentSessionActivity, Task>? OnStudentActivityPerformedEvent
	{
		add
		{
			lock (_eventLock)
			{
				_onStudentActivityPerformedEvent += value;
				Console.WriteLine("         ***********************  OnStudentActivityPerformedEvent ****** ADD -> Count : " + ++_onStudentActivityPerformedCount);
			}
		}
		remove
		{
			lock (_eventLock)
			{
				_onStudentActivityPerformedEvent -= value;
				Console.WriteLine("         ========================  OnStudentActivityPerformedEvent ======== REMOVE -> Count : " + --_onStudentActivityPerformedCount);
			}
		}
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
		var timeTableSessions = await managerGrain.GetTimeTableSessions(interval.StartTime.Value, _dateTime);
		return timeTableSessions;
	}

}