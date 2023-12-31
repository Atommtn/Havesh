using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Havesh.Application.Services;
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
using HaveshApp.Managment.Session.SessionActions;
using Microsoft.EntityFrameworkCore;
using Log = Serilog.Log;

namespace HaveshApp.Managment;

public partial class StudentListRollCallComponenets
{

	[Inject] public StudentService StudentService { get; set; }
	[Parameter] public TimeTableSession TimeTableSession { get; set; }
	[Parameter] public bool RowStyle { get; set; }
	[Parameter] public int RowsPerPage { get; set; } = 15;
	[Parameter] public SessionActivity SessionActivity { get; set; }

	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object> AdditionalAttributes { get; set; }

	[Inject]
	public ILogger<StudentListRollCallComponenets> Logger { get; set; }

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

	private async Task ReloadActivities()
	{
		//StateHasChanged();
		//await Task.Delay(300);
		//var ttsGrain = ClusterClient.GetGrain<ITimeTableSessionGrain>(TimeTableSession.Id);
		//var studentSessionActivities = await ttsGrain.GetStudentSessionActivities();
		_activities =  GetActivities(TimeTableSession.Id);
		//_activities = (studentSessionActivities ?? Array.Empty<StudentSessionActivity>()).ToList();
		//_dataProvider.DbContext.AttachRange(_activities);
		//_activities = GetActivities(TimeTableSession.Id);
		StateHasChanged();
	}

	private List<StudentSessionActivity> GetActivities(int sessionId)
	{
		var activities = _dataProvider
			.GetStudentSessionActivityPerformed(sessionId,

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
			
			TimeTableSessionFk = TimeTableSession.Id,
			StudentFk = obj.Item1.Id,
			//Student = obj.Item1,
			
			ActivityFk = obj.Item2.Id,
			//Activity = obj.Item2,
			
			ActivityValueOptionFk = obj.Item3.Id,
			//ActivityValueOption = obj.Item3,
			
			ActivityValue = obj.Item3.Value,
		};
		

		var manager = ClusterClient.GetGrain<IStudentSessionActivityManagerGrain>(Guid.Empty);

		_dataProvider.SaveStudentSessionActivity(studentSessionActivity);
		await manager.CreateStudentSessionActivity(studentSessionActivity);

        if (obj.Item3.ShowByValue != null)
        {
            var sessionActivityGrain = ClusterClient.GetGrain<ISessionActivityGrain>(studentSessionActivity.ActivityFk);
            var valueOption = await sessionActivityGrain.GetSessionActivityValueOptionByValueAsync(obj.Item3.ShowByValue);
            if (valueOption != null)
            {
                var sessionActivity = _activities.FirstOrDefault(x =>
                    x.TimeTableSessionFk == studentSessionActivity.TimeTableSessionFk &&
                    x.StudentFk == studentSessionActivity.StudentFk &&
                    x.ActivityFk == studentSessionActivity.ActivityFk &&
                    x.ActivityValueOptionFk == valueOption.Id);

                await CancelStudentSessionActivity(sessionActivity , false);
            }
        }

		_activities?.Add(studentSessionActivity);
		await ReloadActivities();
	}

	private async Task CancelStudentSessionActivity(StudentSessionActivity sac, bool reload = true)
	{

		var manager = ClusterClient.GetGrain<IStudentSessionActivityManagerGrain>(Guid.Empty);
		_dataProvider.SetActivityDeleteTime(sac);
		 //await manager.RemoveStudentSessionActivity(sac);
		 await manager.NotifySessionActivity(sac);
		_activities?.Add(sac);
		if(reload)
		    await ReloadActivities();
		StateHasChanged();
	}
}