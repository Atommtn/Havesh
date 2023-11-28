using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Entity;
using Havesh.GrainInterfaces.Manager;
using Havesh.Grains.Entity;
using Havesh.Grains.Manager;
using Havesh.Model.Data;
using HaveshApp.Admin.Dashboard.Widgets.Teacher;
using Newtonsoft.Json;
using Olive;

namespace HaveshApp.Managment;

public partial class StudentListRollCallComponenets
{

	[Inject] public StudentService StudentService { get; set; }

	MudTable<ShokouhPardisStudentClass>? table;

	[Parameter] public TimeTableSession TimeTableSession { get; set; }

	[Parameter] public bool RowStyle { get; set; }
	[Parameter] public int RowsPerPage { get; set; } = 15;
	[Parameter] public SessionActivity SessionActivity { get; set; }

	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object> AdditionalAttributes { get; set; }

	async Task<TableData<ShokouhPardisStudentClass>> ServerReload(TableState state)
	{
		var ttGrain = ClusterClient.GetGrain<ITimeTableGrain>(TimeTableSession.TimeTableFk);
		var students = await ttGrain.GetStudents();
		if (students == null)
			return new TableData<ShokouhPardisStudentClass>();


		var shokouhPardisStudentClasses = students.ToList();
		shokouhPardisStudentClasses.ForEach(x => x.OrderNumber = shokouhPardisStudentClasses.IndexOf(x) + 1);
		return new TableData<ShokouhPardisStudentClass>
		{
			TotalItems = shokouhPardisStudentClasses.Count(),
			Items = shokouhPardisStudentClasses
		};

	}

	private List<StudentSessionActivity>? _activities;
	protected override async Task OnInitializedAsync()
	{
		await ReloadActivities();
		await base.OnInitializedAsync();
	}

	private async Task UpdateActivities(StudentSessionActivity? studentSessionActivity)
	{
		if (studentSessionActivity != null) 
			_activities?.Add(studentSessionActivity);

		await InvokeAsync(StateHasChanged);
	}

	private async Task ReloadActivities()
	{
		var ttsGrain = ClusterClient.GetGrain<ITimeTableSessionGrain>(TimeTableSession.Id);
		_activities = (await ttsGrain.GetStudentSessionActivities() ?? Array.Empty<StudentSessionActivity>()).ToList();
	}

	private string RowStyleFunc(ShokouhPardisStudentClass student, int index)
	{
		return "";
	}

	[Inject] IClusterClient ClusterClient { get; set; }

	private async Task Exec((ShokouhPardisStudentClass, SessionActivity, SessionActivityValueOption) obj)
	{

		var studentSessionActivity = new StudentSessionActivity
		{
			StudentSessionActivityLastModified = DateTime.Now,
			StudentSessionActivityGuid = Guid.NewGuid(),
			ActivityDateTime = DateTime.Now,
			TimeTableFk = TimeTableSession.TimeTableFk,
			TimeTableSession = TimeTableSession,
			StudentFk = obj.Item1.Id,
			Student = obj.Item1,
			ActivityFk = obj.Item2.Id,
			Activity = obj.Item2,
			ActivityValueOptionFk = obj.Item3.Id,
			ActivityValueOption = obj.Item3,
			ActivityValue = obj.Item3.Value,
		};

		var manager = ClusterClient.GetGrain<IStudentSessionActivityManagerGrain>(Guid.NewGuid());
		await manager.CreateStudentSessionActivity(studentSessionActivity);

		await UpdateActivities(studentSessionActivity);
	}

	private void CancelStudentSessionActivity(StudentSessionActivity sac)
	{
		_dataProvider.SetActivityDeleteTime(sac);
	}
}