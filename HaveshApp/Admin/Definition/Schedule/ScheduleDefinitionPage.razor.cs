using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;
using HaveshApp.Admin.Components;
using HaveshApp.Admin.Definition.DaySession;
using HaveshApp.Model;
using HaveshApp.Services;

namespace HaveshApp.Admin.Definition.Schedule
{
    public partial class ScheduleDefinitionPage
    {
        [Inject] DataProviderService DataProvider { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] ISnackbar Snackbar { get; set; }

        List<ShokouhPardisSchedule>? Schedules = null;
        MudTable<ShokouhPardisSchedule>? table;
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
            Schedules = DataProvider.GetSchedules(SelectedTerm);

        }
        async Task NewScheduleClick()
        {
            ShokouhPardisSchedule schedule = ShokouhPardisSchedule.CreateSchedule();
            schedule.TermFk = SelectedTerm.TermClassId;
            await EditScheduleClick(schedule);
        }

        async Task EditScheduleClick(ShokouhPardisSchedule schedule)
        {
            await OpenNewEditScheduleDialog(schedule);
        }

        async Task OpenNewEditScheduleDialog(ShokouhPardisSchedule schedule)
        {
            var dialogReference = DialogService.Show<ScheduleDefinitionDialog>(
                (schedule.ScheduleId > 0 ? "ویرایش " : "جدید ") + "زمانبندی ",
                new DialogParameters
                {
                    ["Schedule"] = schedule

                },
                new DialogOptions()
                {
                    CloseButton = true,
                    MaxWidth = MaxWidth.Large
                });
            var dialogResult = await dialogReference.Result;
            if (dialogResult.Cancelled == false)
            {
                var retData = (ShokouhPardisSchedule)dialogResult.Data;
                var result = DataProvider.SaveEditSchedule(retData);
                if (result)
                {
                    var parameters = new DialogParameters();

                    bool? result1 = await DialogService.ShowMessageBox(
                        "خطا",
                        (MarkupString)
                            @$" زمانبندی با این مشخصات قبلا ذخیره شده است!
                        <br/>{retData.Title}",
                        yesText: "متوجه شدم!");
                }
                else
                {
                    Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
                    Log.Warning("User {UserName} Save-Update Schedule {ScheduleId}", _userSession.Payload.UserName, retData.ScheduleId);
                }

                RefreshData();
                StateHasChanged();
            }
        }

        async void AddProgramClick(ShokouhPardisSchedule schedule)
        {

            var daySession = ShokouhPardisDaySession.CreateDaySession(SelectedTerm.TermClassId);
            await OpenNewDaySessionDialog(daySession, schedule);
        }


        async Task OpenNewDaySessionDialog(ShokouhPardisDaySession daySession,
            ShokouhPardisSchedule schedule)
        {
            var dialogReference = DialogService.Show<DaySesseionDefinitionDialog>(
                (daySession.DaySessionId > 0 ? "ویرایش " : "جدید ") + "زمانبندی ",
                new DialogParameters
                {
                    ["DaySession"] = daySession,
                    ["SelectedTerm"] = SelectedTerm
                },
                new DialogOptions()
                {
                    CloseButton = true,
                    FullWidth = true,
                    MaxWidth = MaxWidth.Medium
                });

            var dialogResult = await dialogReference.Result;
            if (dialogResult.Cancelled == false)
            {
                daySession = (ShokouhPardisDaySession)dialogResult.Data;
                var program = ShokouhPardisProgram.CreateProgram(daySession, schedule);

                var isDuplicated = DataProvider.SaveProgram(program);
                if (isDuplicated)
                {
                    var result1 = await DialogService.ShowMessageBox(
                        "خطا",
                        (MarkupString)
                        @$" برنامه با این مشخصات قبلا ذخیره شده است!
                        <br/>{program.DaySession.WeekDay.Title}
                        <br/>{program.DaySession.Interval.Title}",
                        yesText: "متوجه شدم!");
                }
                else
                {
                    Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
                }

                RefreshData();
                StateHasChanged();
            }
        }

        private async Task DeleteProg(ShokouhPardisProgram prog)
        {
            var result = await DeleteProgAlertDialog(prog.DaySession, prog.Schedule);
            if (result != null && result == true)
            {
                DataProvider.DeleteProgram(prog);
            }
        }
        private async Task<bool?> DeleteProgAlertDialog(ShokouhPardisDaySession daySession,
            ShokouhPardisSchedule schedule)
        {
         
            bool? result = await DialogService.ShowMessageBox(
                "خطا",
                (MarkupString)
                @$"
                آیا از حذف این برنامه با مشخصات زیر!
                <br/>
                
                {daySession.WeekDay.Title}---{daySession.Interval.Title}
                <br/>
                از زمانبندی
                <br/>
                {schedule.Title}
                <br/>       
                !موافقید 
                    ",
                yesText: "حذف شود");
            return result;
        }
    }
}

