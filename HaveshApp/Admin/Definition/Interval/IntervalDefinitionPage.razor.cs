using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;
using ShokouhApp.Model;
using ShokouhApp.Services;

namespace ShokouhApp.Admin.Definition.Interval
{
    public partial class IntervalDefinitionPage
    {
        [Inject] DataProviderService DataProvider { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] ISnackbar Snackbar { get; set; }

        List<ShokouhPardisInterval>? Interval = null;
        MudTable<ShokouhPardisInterval>? table;
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
            Interval = DataProvider.GetIntervals(SelectedTerm);

        }




        async Task NewIntervalClick()
        {
            ShokouhPardisInterval interval = ShokouhPardisInterval.CreateInterval();
            interval.TermId = SelectedTerm.TermClassId;

            await EditButtonClick(interval);
        }

        async Task EditButtonClick(ShokouhPardisInterval interval)
        {
            await OpenNewIntervalDialog(interval);
        }

        async Task OpenNewIntervalDialog(ShokouhPardisInterval interval)
        {
            var dialogReference = DialogService.Show<IntervalDefinitionDialog>(
                (interval.IntervalId > 0 ? "ویرایش " : "جدید ") + "سانس ",
                new DialogParameters
                {
                    ["Interval"] = interval
                },
                new DialogOptions()
                {
                    CloseButton = true,
                    MaxWidth = MaxWidth.Large
                });
            var dialogResult = await dialogReference.Result;
            if (dialogResult.Cancelled == false)
            {
                var retData = (ShokouhPardisInterval)dialogResult.Data;
                var result = DataProvider.SaveEditInterval(retData);
                if (result)
                {
                    var parameters = new DialogParameters();

                    bool? result1 = await DialogService.ShowMessageBox(
                        "خطا",
                        (MarkupString)
                            @$"سانسی با این مشخصات قبلا ذخیره شده است!
                        <br/>{retData.Title}
                        <br/>{retData.TimeInterval}",
                        yesText: "متوجه شدم!");
                }
                else
                {
                    Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
                    Log.Warning("User {UserName} Save-Update TimeInterval {TimeIntervalId}", _userSession.Payload.UserName, retData.IntervalId);
                }

                RefreshData();
                StateHasChanged();
            }
        }
    }
}
