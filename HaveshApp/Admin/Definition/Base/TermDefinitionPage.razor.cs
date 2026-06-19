using DNTPersianUtils.Core;
using Havesh.Application.Services;
using Havesh.Model.Model;
using HaveshApp.Admin.Definition.ClassRoom;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;
using System.Globalization;



namespace HaveshApp.Admin.Definition.Base
{
    public partial class TermDefinitionPage
    {

        [Inject] DataProviderService DataProvider { get; set; }
        [Inject] IDialogService DialogService { get; set; }
        [Inject] ISnackbar Snackbar { get; set; }

        public ShokouhPardisYearClass yearSelect
        {
            get => _yearSelect;
            set
            {
                if (_yearSelect == value) return;
                _yearSelect = value;
                RefreshData();
            }
        }

        

        List<ShokouhPardisTermClass>? Term = null;
        MudTable<ShokouhPardisTermClass>? table;
        private ShokouhPardisYearClass _yearSelect;

    protected override void OnInitialized()
        {
            RefreshData();
            base.OnInitialized();
        }

        void RefreshData()
        {
            if (yearSelect is null)
            {
                DateTime today = DateTime.Today;
                PersianCalendar persianCalendar = new PersianCalendar();
                int persianYear = persianCalendar.GetYear(today);
                yearSelect = DataProvider.GetYearInRang(persianYear);
            }
            Term = DataProvider.GetTerms(yearSelect);

        }

       

        async Task NewTermClick()
        {
            ShokouhPardisTermClass term = ShokouhPardisTermClass.CreateTermClass();
            term.YearId = yearSelect.Id;

            await EditButtonClick(term);
        }

        async Task EditButtonClick(ShokouhPardisTermClass term)
        {
            var ts = TimeSpan.Zero;
            term.StartDate+= ts;
            term.EndDate+= ts;
            await OpenNewClassRoomDialog(term);
        }

        async Task OpenNewClassRoomDialog(ShokouhPardisTermClass term)
        {
            var dialogReference = DialogService.Show<TermDefinitionDialog>(
                (term.Id > 0 ? "ویرایش " : "جدید ") + "ترم ",
                new DialogParameters
                {
                    ["Term"] = term
                },
                new DialogOptions()
                {
                    CloseButton = true,
                    MaxWidth = MaxWidth.Large
                });
            var dialogResult = await dialogReference.Result;
            if (dialogResult.Cancelled == false)
            {
                var retData = (ShokouhPardisTermClass)dialogResult.Data;
                var result = DataProvider.SaveEditTerm(retData);
                if (result)
                {
                    var parameters = new DialogParameters();

                    bool? result1 = await DialogService.ShowMessageBox(
                        "خطا",
                        (MarkupString)
                        @$"ترم با این نام قبلا ذخیره شده است!
                        <br/>{retData.TermName}",
                        yesText: "متوجه شدم!");
                }
                else
                {
                    Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
                    Log.Warning("User {UserName} Save-Update Term {TermId}", _userSession.Payload.UserName, retData.Id);
                }

                RefreshData();
                StateHasChanged();
            }
        }
        CultureInfo GetPersianCulture()
        {
            var culture = new CultureInfo("fa-IR");
            return culture;
        }

        private string GetTermName(int? termId)
        {
            if (termId is not null)
            {
                return _dataProvider.GetTerm((int)termId).TermName;
            }
            else
            {
                return "مشخص نشده";
            }
        }
    }
}
