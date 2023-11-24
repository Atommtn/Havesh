using System.Text.Json;
using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;
using HaveshApp.Admin;
using HaveshApp.Admin.Authentication;
using HaveshApp.Admin.Student;
using HaveshApp.Managment.Session.Activity;
using Havesh.Domain.Services;
using Havesh.Model.Data;
using static HaveshApp.Admin.Planning.CompleteTimeTablePage;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace HaveshApp.Managment;

public partial class StudentListRollCallComponenets
{

	[Inject] public StudentService StudentService { get; set; }

	MudTable<ShokouhPardisStudentClass>? table;

	[Parameter] public TimeTableSession TimeTableSession { get; set; }

	[Parameter] public bool RowStyle { get; set; }
	[Parameter] public int RowsPerPage { get; set; } = 15;
	[Parameter] public SessionActivity SessionActivity { get; set; }

	[Inject] IDialogService DialogService { get; set; }

	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object> AdditionalAttributes { get; set; }

	async Task<TableData<ShokouhPardisStudentClass>> ServerReload(TableState state)
	{
		var list = StudentService.GetStudentsInTimeTable(TimeTableSession.TimeTableFk);
		list.ForEach(x => x.OrderNumber = list.IndexOf(x) + 1);
		return new TableData<ShokouhPardisStudentClass>
		{
			TotalItems = list.Count,
			Items = list
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

	[Inject]
	private MessageService MessageService { get; set; }

	private async Task Exec((ShokouhPardisStudentClass, SessionActivity, SessionActivityValueOption) obj)
	{
		var studentSessionActivity = new StudentSessionActivity
		{
			StudentSessionActivityLastModified = DateTime.Now,
			StudentSessionActivityGuid = Guid.NewGuid(),
			ActivityDateTime = DateTime.Now,
			TimeTableFk = TimeTableSession!.TimeTableFk,
			TimeTableSessionFk = TimeTableSession!.Id,
			StudentFk = obj.Item1.Id,
			ActivityFk = obj.Item2.Id,
			ActivityValue = obj.Item3.Value
		};


		if (!string.IsNullOrEmpty(obj.Item3.BroadcastToRoles))
		{
			var roles = obj.Item3.BroadcastToRoles.Split(',', StringSplitOptions.RemoveEmptyEntries);
			var serializeObject = JsonConvert.SerializeObject(studentSessionActivity, Formatting.Indented);
			await MessageService.SendMessageToRolesAsync(
				new Message()
				{
					From = _userSession.User!,
					To = _userSession.User!,
					CreateDateTime = DateTime.Now,
					Type = MessageTypeEnum.Broadcast,
					Command = "StudentActivity",
					CommandArg = serializeObject
				}, roles);
		}

		_dataProvider.SaveStudentActivity(studentSessionActivity);
		UpdateDict();
	}

	private void CancelStudentSessionActivity(StudentSessionActivity sac)
	{
		_dataProvider.SetActivityDeleteTime(sac);
	}
}