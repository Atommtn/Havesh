using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Storage;
using MudBlazor;
using Serilog;
using HaveshApp.Admin.Components;
using HaveshApp.Admin.Student;
using HaveshApp.Managment.Session;
using Havesh.Application.Services;
using Havesh.Domain.Services;


namespace HaveshApp.Admin.Planning;

public partial class TimeTablePage
{
	[Inject] ISnackbar Snackbar { get; set; }
	[Inject] DataProviderService DataProvider { get; set; }
	[Inject] DataProviderAsyncService DataProviderAsyncX { get; set; }

	[Inject] IDialogService DialogService { get; set; }
	[Inject] NavigationManager NavigationManager { get; set; }

	bool DataLoading;
	MudTable<ShokouhPardisTimeTable>? table;
	string? SearchText { get; set; }
	ShokouhPardisTermClass? _term;
	private bool _isPrivate;
	public bool isPrivate
	{
		get => _isPrivate;
		set
		{
			_isPrivate = value;
			if (table == null) return;
            InvokeAsync(table.ReloadServerData);

        }
	}

	ShokouhPardisTermClass? Term
	{
		get => _term;
		set
		{
			if(_term == value) return;
			_term = value;

			_timeTableStudentsCount = DataProvider.GetTimeTableStudentsCount(_term);
			if (table == null) return;

			table.ReloadServerData();

		}
	}

	Dictionary<int, int> _timeTableStudentsCount;
	bool initComplete = false;

	void Init()
	{
		if (initComplete)
			return ;
		DataLoading = true;
		StateHasChanged();
		Term = DataProvider.GetTermsInRangeToday();
		initComplete = true;
		isPrivate = false;
		StateHasChanged();
	}


	Task NewTimesheetClick()
	{
		var timeTable = ShokouhPardisTimeTable.CreateTimeTable();

		return EditButtonClick(timeTable);
	}
    Task NewPrivateTimesheetClick()
    {
        var timeTable = ShokouhPardisTimeTable.CreateTimeTable();
        timeTable.IsPrivate = true;
        return PrivateEditButtonClick(timeTable);
    }
    async Task<TableData<ShokouhPardisTimeTable>> ServerReload(TableState state)
	{
		Init();

		DataLoading = true;
		StateHasChanged();

		var total = DataProvider.GetTotalTimeTablesCount(Term.Id ,SearchText , isPrivate);
		var timeTables = DataProvider.GetTimeTables(state.Page, state.PageSize, SearchText, Term , isPrivate).ToList();
		timeTables.ForEach(x =>
		{
			if(_timeTableStudentsCount.TryGetValue(x.Id,out var zz))
				x.StudentsCount = zz;
		});
		DataLoading = false;

		return new TableData<ShokouhPardisTimeTable>
		{
			TotalItems = total,
			Items = timeTables
		};

	}


	Task FilterData()
	{
		return table?.ReloadServerData()!;
	}

	Task EditButtonClick(ShokouhPardisTimeTable timeTable)
    {
        return isPrivate ? OpenPrivateTimesTableDialog(timeTable) : OpenTimesTableDialog(timeTable);
    }
    Task PrivateEditButtonClick(ShokouhPardisTimeTable timeTable)
    {
        return OpenPrivateTimesTableDialog(timeTable);
    }
    async Task OpenTimesTableDialog(ShokouhPardisTimeTable context)
	{
		var dialogReference = DialogService.Show<TimesTableDialog>(
			(context.Id > 0 ? "Edit " : "New ") + "Time-Table " + Term.TermName,
			new DialogParameters
			{
				["TimeTableItem"] = context,
				["TermPram"] = Term,
			},
			new DialogOptions()
			{
				CloseButton = true,
				MaxWidth = MaxWidth.Large
			});
		var dialogResult = await dialogReference.Result;
		if (dialogResult.Cancelled == false)
		{
			var retData = (ShokouhPardisTimeTable)dialogResult.Data;
            retData.TeacherId = retData.Teacher.Id;
			var result = DataProvider.SaveTeacherTimeTable(retData);
			if (result)
			{
				bool? result1 = await DialogService.ShowMessageBox(
					"خطا",
					(MarkupString)
					@$"کلاسی با این مشخصات قبلا ذخیره شده است!
                        <br/>{retData.Teacher.TeacherName}
                        <br/>{retData.Teacher.TeacherFamily}
                        <br/>{retData.Level.LevelName}
                        <br/>{retData.Schedule.Title}",
					yesText: "متوجه شدم!");
			}
			else
			{
				
				Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
				Log.Warning("User {UserName} Save TimeTable {TimeTableId}", _userSession.Payload.UserName, retData.Id);
			}

			await table?.ReloadServerData()!;
			StateHasChanged();
		}
	}
    async Task OpenPrivateTimesTableDialog(ShokouhPardisTimeTable context)
    {
        var dialogReference = await DialogService.ShowAsync<PrivateTimesTableDialog>(
            (context.Id > 0 ? "Edit " : "New ") + "Private " + Term.TermName,
            new DialogParameters
            {
                ["TimeTableItem"] = context,
                ["TermPram"] = Term,
            },
            new DialogOptions()
            {
                CloseButton = true,
                MaxWidth = MaxWidth.Large
            });
        var dialogResult = await dialogReference.Result;
        if (dialogResult.Cancelled == false)
        {
            var retData = (ShokouhPardisTimeTable)dialogResult.Data;
            var result = DataProvider.SaveTeacherTimeTable(retData);
            if (result)
            {
                bool? result1 = await DialogService.ShowMessageBox(
                    "خطا",
                    (MarkupString)
                    @$"کلاسی با این مشخصات قبلا ذخیره شده است!
                        <br/>{retData.Teacher.TeacherName}
                        <br/>{retData.Teacher.TeacherFamily}
                        <br/>{retData.Level.LevelName}
                        <br/>{retData.Schedule.Title}",
                    yesText: "متوجه شدم!");
            }
            else
            {
                Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
                Log.Warning("User {UserName} Save Private TimeTable {TimeTableId}", _userSession.Payload.UserName, retData.Id);
            }

            await table?.ReloadServerData()!;
            StateHasChanged();
        }
    }
    async Task DeleteButtonClick(ShokouhPardisTimeTable context)
	{
		var result = await DialogService.ShowMessageBox("Delete Timesheet Item", "Are you sure to delete this item ?", "Yes", "No");
		if (result is true)
		{
			DataProvider.DeleteTimesheet(context);
			await table?.ReloadServerData()!;
		}
	}


	Task AddStudentToClassClick(ShokouhPardisTimeTable timeTable)
	{
		NavigationManager.NavigateTo($"/timeTable/{timeTable.Id}");
		return Task.CompletedTask;
	}

	readonly TableGroupDefinition<ShokouhPardisTimeTable> _groupDefinition = new()
	{
		GroupName = "مدرس",
		Indentation = false,
		Expandable = true,
		IsInitiallyExpanded = false,
		Selector = (e) => e.Teacher
	};


	async Task ManageSessionClick(ShokouhPardisTimeTable timeTable)
	{
		await DialogService.ShowAsync<TimeTableSessionManagementDialog>("Manage Sessions",new DialogParameters()
			{
				["TimeTable"] = timeTable
			}, 
			new DialogOptions()
			{
				MaxWidth = MaxWidth.Medium,
				FullWidth = true
			});
            
	}

    
}