using DNTPersianUtils.Core;
using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Havesh.Domain.Services;
using HaveshApp.Classes;
using HaveshApp.Managment.Session;

namespace HaveshApp.Admin.Planning;

public partial class PrivateTimesTableDialog
{

	[CascadingParameter]
	MudDialogInstance DialogInstance { get; set; }

	[Parameter]
	public ShokouhPardisTimeTable? TimeTableItem { get; set; }

	[Inject] DataProviderService DataProvider { get; set; }
	[Parameter]
	public ShokouhPardisTermClass TermPram { get; set; }

	[Inject]
	public ISnackbar Snackbar { get; set; }
	[Parameter]
	public EventCallback<ShokouhPardisTermClass> TermPramChanged { get; set; }

	List<ShokouhPardisTeacherTimeSheet>? _teacherTimeSheet;
    [Inject] public IDialogService DialogService { get; set; }

	ShokouhPardisLevelBookPrice? _bookPrice;
	private ShokouhPardisClassRoom _classRoom;
	private List<ShokouhPardisSchedule> _scheduleList;

    Dictionary<int, bool> Days { get; set; } = new Dictionary<int, bool>();
    protected override void OnAfterRender(bool firstRender)
	{

		if (firstRender)
		{
			TimeTableItem.Term = TermPram;
			_teacherTimeSheet = GetTimeSheet(TimeTableItem);
			_bookPrice = GetBookPrice(TimeTableItem);
            Days = GetDaysOfSessions(TimeTableItem);
			StateHasChanged();
		}
		base.OnAfterRender(firstRender);
	}

    private Dictionary<int, bool> GetDaysOfSessions(ShokouhPardisTimeTable timeTableItem)
    {
        var days = timeTableItem.Sessions.Select(x => x.SessionDate.GetPersianWeekDayNumber());
            
        Dictionary<int, bool> bools = new();
        for (var i = 0; i < 7; i++) bools.Add(i + 1, false);
        foreach (var x in days)
        {
            bools[(int)x] = true;
        }
        return bools;
        
    }

    private void CloseDialogClick()
	{
		DialogInstance.Cancel();
	}



	private async Task SaveDialogClick()
	{
		await _form.Validate();
		if (!_form.IsValid)
		{
			// if (TimeTableItem?.ClassRoom == null)
			// {
			//     _form.Errors.ForEach(x => Snackbar.Add(x , Severity.Info));
			//     //Snackbar.Add("کلاس باید انتخاب شود.", Severity.Error);
			// }

			return;
		}
		foreach (var timeTableSession in TimeTableItem?.Sessions)
        {
            timeTableSession.ClassRoom = TimeTableItem.ClassRoom;
            timeTableSession.Teacher= TimeTableItem.Teacher;
            timeTableSession.TimeTable = TimeTableItem;
            timeTableSession.SessionStatus = SessionStatuses.Pending;
        }
		DialogInstance.Close(DialogResult.Ok(TimeTableItem));
	}

    //void SaveTemplate()
    //{
    //    var x = string.Join(',', Days.Where(x => x.Value == true).Select(x => x.Key));
    //    TermSessionTemplate.WeekdayIds = x;
    //    _dataProvider.SaveTermSessionTemplate(TermSessionTemplate);
    //    Log.Warning("User {UserName} Save TermSessionTemplate {TermSessionTemplateId}", _userSession.Payload.UserName, TermSessionTemplate.Id);
    //    _templates = DataProviderService.GetTermTemplates(Term);
    //    TermSessionTemplate = new TermSessionTemplate();
    //    StateHasChanged();

    //}

    ShokouhPardisClassRoom ClassRoom
	{
		get => _classRoom;
		set
		{
			_classRoom = value;
		}
	}

	ShokouhPardisLevelClass Level
	{
		get
		{
			return TimeTableItem.Level;

		}
		set
		{
			TimeTableItem.Level = value;
			_bookPrice = GetBookPrice(TimeTableItem);
		}
	}

	public List<ShokouhPardisSchedule> ScheduleList
	{
		get
		{
			_scheduleList = DataProvider.GetSchedules(TermPram);
			return _scheduleList;
		}
		set => _scheduleList = value;
	}


	List<ShokouhPardisTeacherTimeSheet>? GetTimeSheet(ShokouhPardisTimeTable? timeTable)
	{
		if (timeTable is { Term: { }, Teacher: { } })
		{
			return DataProvider.GetTermTeacherTimeSheets(
				timeTable.Term.Id,
				timeTable.Teacher.Id);
		}
		return null;
	}

	private ShokouhPardisLevelBookPrice? GetBookPrice(ShokouhPardisTimeTable? timeTable)
	{
		if (timeTable.Level is { })
		{
			return DataProvider.GetLevelBookPrice(timeTable);

		}
		return null;
	}
    public TermSessionTemplate TermSessionTemplate { get; set; } 
    private MudForm _form;
    private async Task DateChoiceClick()
    {
        var x = string.Join(',', Days.Where(x => x.Value == true).Select(x => x.Key));
        
            TimeTableItem.Sessions ??= new List<TimeTableSession>();
            TermSessionTemplate = new TermSessionTemplate()
            {
                Term = TermPram,
                TermFk = TermPram.Id,
                WeekdayIds = x
            };
        
        
    await DialogService.ShowAsync<PrivateTimeTableDatesDialog>("Dates", new DialogParameters()
        {
            ["TermSessionTemplate"] = TermSessionTemplate,
		    ["Sessions"] = TimeTableItem.Sessions
    });

    }
}