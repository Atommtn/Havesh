using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Havesh.Domain.Services;
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
		shokouhPardisStudentClasses.ForEach(x=>x.OrderNumber = shokouhPardisStudentClasses.IndexOf(x) + 1);
		return new TableData<ShokouhPardisStudentClass>
		{
			TotalItems = shokouhPardisStudentClasses.Count(),
			Items = shokouhPardisStudentClasses
		};

	}

	private Dictionary<int, List<StudentSessionActivity>>? _stuActiv;
	protected override void OnInitialized()
	{
		UpdateDict();
		base.OnInitialized();
	}

	private void UpdateDict()
	{
		_stuActiv = _dataProvider.GetStudentsSessionActivities(TimeTableSession);
	}

	async Task ReloadData()
	{
		if (table != null)
			await table.ReloadServerData();

	}

	private string RowStyleFunc(ShokouhPardisStudentClass student, int index)
	{
		return "";
	}

	private void Callback(SessionActivity activity, string value)
	{
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
			ActivityFk = obj.Item2.Id,
			ActivityValue = obj.Item3.Value
		};

		var manager = ClusterClient.GetGrain<IStudentSessionActivityManagerGrain>(Guid.NewGuid());
		await manager.CreateStudentSessionActivity(studentSessionActivity);

		var studentGrain = ClusterClient.GetGrain<IStudentGrain>(studentSessionActivity.StudentFk);
		await studentGrain.SessionActivityPerformed(studentSessionActivity);
		UpdateDict();
	}

	private void CancelStudentSessionActivity(StudentSessionActivity sac)
	{
		_dataProvider.SetActivityDeleteTime(sac);
	}
}