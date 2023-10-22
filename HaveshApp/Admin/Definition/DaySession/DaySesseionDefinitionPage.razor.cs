using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;
using HaveshApp.Services;

namespace HaveshApp.Admin.Definition.DaySession;

public partial class DaySesseionDefinitionPage
{
	[Inject] DataProviderService DataProvider { get; set; }
	[Inject] IDialogService DialogService { get; set; }
	[Inject] ISnackbar Snackbar { get; set; }

	List<ShokouhPardisDaySession>? daySessions = null;
	MudTable<ShokouhPardisDaySession>? table;
	ShokouhPardisTermClass _selectedTerm;
	ShokouhPardisTermClass SelectedTerm
	{
		get => _selectedTerm;
		set
		{
			if (_selectedTerm == value) return;
			_selectedTerm = value;
			RefreshData();
		}
	}
	void RefreshData()
	{
		daySessions = DataProvider.GetDaySessions(SelectedTerm);

	}




	async Task NewDaySessionClick()
	{
		var daySession = ShokouhPardisDaySession.CreateDaySession(SelectedTerm.TermClassId);
		daySession.WeekDay = DataProvider.GetFirstWeekDays();
		daySession.Interval = DataProvider.GetFirstIntervalByTerm(SelectedTerm);

		await EditButtonClick(daySession);
	}

	async Task EditButtonClick(ShokouhPardisDaySession daySession)
	{
		await OpenNewDaySessionDialog(daySession);
	}

	async Task OpenNewDaySessionDialog(ShokouhPardisDaySession daySessions)
	{
		var dialogReference = DialogService.Show<DaySesseionDefinitionDialog>(
			(daySessions.DaySessionId > 0 ? "ویرایش " : "جدید ") + "روز سانس ",
			new DialogParameters
			{
				["DaySession"] = daySessions,
				["SelectedTerm"] = SelectedTerm
			},
			new DialogOptions()
			{
				CloseButton = true,
				MaxWidth = MaxWidth.Large
			});
		var dialogResult = await dialogReference.Result;
		if (dialogResult.Cancelled == false)
		{
			var retData = (ShokouhPardisDaySession)dialogResult.Data;
			var result = DataProvider.SaveEditDaySession(retData);

			if (result)
			{
				var parameters = new DialogParameters();

				bool? result1 = await DialogService.ShowMessageBox(
					"خطا",
					(MarkupString)
					@$"روز-سانس با این مشخصات قبلا ذخیره شده است!
                        <br/>{retData.WeekDay.Title}
                        <br/>{retData.Interval.Title}",
					yesText: "متوجه شدم!");
			}
			else
			{
				Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
				Log.Warning("User {UserName} Save-Update DaySession {DaySessionId}", _userSession.Payload.UserName, retData.DaySessionId);
			}

			RefreshData();
			StateHasChanged();
		}
	}
}