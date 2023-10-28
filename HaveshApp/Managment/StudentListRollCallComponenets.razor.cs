using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;
using HaveshApp.Admin;
using HaveshApp.Admin.Authentication;
using HaveshApp.Admin.Student;
using HaveshApp.Managment.Session.Activity;
using HaveshApp.Services;
using static HaveshApp.Admin.Planning.CompleteTimeTablePage;

namespace HaveshApp.Managment;

public partial class StudentListRollCallComponenets
{

	bool? CheckBox2 { get; set; } = null;

	[Inject] public StudentService StudentService { get; set; }

	MudTable<ShokouhPardisStudentClass>? table;

	[Parameter] public TimeTableSession TimeTableSession { get; set; }

	[Parameter] public bool RowStyle { get; set; }
	[Parameter] public int RowsPerPage { get; set; } = 15;
	[Parameter] public SessionActivity SessionActivity{ get; set; } 
        
	[Inject] IDialogService DialogService { get; set; }

	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object> AdditionalAttributes { get; set; }

	async Task<TableData<ShokouhPardisStudentClass>> ServerReload(TableState state)
	{
		return new TableData<ShokouhPardisStudentClass>
		{
			TotalItems = StudentService.GetStudentsInTimeTable(TimeTableSession.TimeTable).Count,
			Items = StudentService.GetStudentsInTimeTable(TimeTableSession.TimeTable)
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

	private void Exec((ShokouhPardisStudentClass, SessionActivity, SessionActivityValueOption) obj)
	{
		var studentSessionActivity = new StudentSessionActivity
		{
			StudentSessionActivityLastModified = DateTime.Now,
			StudentSessionActivityGuid = Guid.NewGuid(),
			ActivityDateTime = DateTime.Now,
			TimeTableSessionFk = TimeTableSession!.ID,
			StudentFk = obj.Item1.StudentClassId,
			ActivityFk = obj.Item2.SessionActivityID,
			ActivityValue = obj.Item3.Value
		};
		_dataProvider.SaveStudentActivity(studentSessionActivity);
		UpdateDict();
	}

	private void CancelStudentSessionActivity(StudentSessionActivity sac)
	{
		_dataProvider.SetActivityDeleteTime(sac);
	}
}