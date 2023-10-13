using FluentValidation;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using ShokouhApp.Admin.CompleteForm;
using ShokouhApp.Classes;
using ShokouhApp.Model;
using ShokouhApp.Services;
using System.Globalization;

namespace ShokouhApp.Pages.SiteTransaction
{
    public partial class SiteJv
    {

        bool _disbaleSave = false;
        public ShokouhPardisFileAttachment? Attachment { get; set; }
        //string? SelectedFeeFor;

        readonly string[] _options = {
        "شهریه",
        "کتاب",
        "شهریه و کتاب",
        "کلاس خصوصی",
    };

        TimeSpan? _ts;
        string? _guid;

        [Inject] DataProviderService DataProvider { get; set; }
        [Inject] ISnackbar Snackbar { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }



        [Parameter]
        public string? guid
        {
            get => _guid;
            set
            {
                _guid = value;
                if (_guid is { })
                {
                    JvfromSite = DataProvider.GetSiteJvByGuid(_guid);
                    Attachment = JvfromSite?.FileAttachment;
                }
            }
        }

        [Parameter]
        public string? Cat { get; set; }

        [Parameter]
        public ShokouhPardisJvfromSite? JvfromSite { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                JvfromSite ??= new ShokouhPardisJvfromSite()
                {
                    DailyJvguid = Guid.NewGuid(),
                    CreateDate = DateTime.Now
                };
                StateHasChanged();
            }

            base.OnAfterRender(firstRender);
        }

        public TimeSpan? Ts
        {
            get => _ts;
            set
            {
                _ts = value;
                JvfromSite.DateOfSettle += _ts;
            }
        }

        CultureInfo GetPersianCulture()
        {
            var culture = new CultureInfo("fa-IR");
            return culture;
        }


        SiteJvValidation JvValidation = new SiteJvValidation();

        List<string> _errors = new List<string>();

        [Inject]
        Navigation Navigation { get; set; }

        [Inject]
        TokenProviderService TokenProviderService { get; set; }

        [Inject]
        BrowserService BrowserService { get; set; }

        async Task SaveClick(bool? navigate = false)
        {

            JvfromSite.AttachmentFk = Attachment?.Id;
            var validationResult = await JvValidation.ValidateAsync(JvfromSite);
            if (validationResult.Errors.Any())
            {
                _errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
                return;
            }
            _errors.Clear();

            DataProvider.SaveJvfromSite(JvfromSite);
            Snackbar.Add("اطلاعات واریز وجه شما با موفقیت ثبت گردید");

            var stu = DataProvider.StudentExistInOnlineForm(JvfromSite.StudentIdNumber);
            if (stu is null)
            {
                var t = await TokenProviderService.TryGetUniqueKey(BrowserService);
                stu = new ShokouhPardisStudentClassOnlineForm
                {
                    StudentName = JvfromSite.StudentName,
                    StudentFamily = JvfromSite.StudentFamil,
                    StudentIdno = JvfromSite.StudentIdNumber,
                    CreatedAt = DateTime.Now,
                    FatherPhone = JvfromSite.PhoneNumber,
                    StudentClassGuid = Guid.NewGuid(),
                    UniqueKey = t.Item1
                };

                DataProvider.SaveOnlineFormStudent(stu);
            }

            if (navigate is true)
            {
                var validator = new StudentFormValidator();
                var validateResult = await validator.ValidateAsync(stu);
                NavigationManager.NavigateTo(validateResult.IsValid
                    ? "/main"
                    : $"/SiteJvRequireFillForm/{stu.StudentClassGuid:N}");
            }
        }


        void UploadStarted()
        {
            _disbaleSave = true;
            StateHasChanged();
        }

        void UploadComplete(int obj)
        {
            _disbaleSave = false;
            StateHasChanged();
        }

        string Version { get { return "?v=" + DateTime.Now.Ticks.ToString(); } }
        [Inject] IJSRuntime JsRuntime { get; set; }


        async Task TestFileUploadClick()
        {
            var jsObjectReference = await JsRuntime.InvokeAsync<IJSObjectReference>("Optimize");
            var blob = await jsObjectReference.InvokeAsync<IJSObjectReference>("handleImageUpload", "frz");
        }

        [Inject] public IDialogService DialogService { get; set; }

        async Task NextClick()
        {
            //All,
            //Approved,
            //PendingToApprive,
            //Invesigate
            ShokouhPardisJvfromSite? rec = null;
            switch (Cat)
            {
                case "All":
                     rec = DataProvider.GetAllSiteJvNext(JvfromSite);

                    break;  
                case "Approved":
                    rec = DataProvider.GetApprovedSiteJvNext(JvfromSite);
                    break; 
                case "PendingToApprive":
                    rec = DataProvider.GetPendingToApproveSiteJvNext(JvfromSite);
                    break;       
                case "Invesigate":
                    rec = DataProvider.GetRequireInvestigateSiteJvNext(JvfromSite);
                    break;
            }

            if (rec == null)
            {
                await DialogService.ShowMessageBox("No Next record found", "There is not next record");
                return;
            }
            Navigation.NavigateTo($"/sitejv/{rec.DailyJvguid:N}/{Cat}");
        }

        async Task PreviuseClick()
        {
            //All,
            //Approved,
            //PendingToApprive,
            //Invesigate
            ShokouhPardisJvfromSite? rec = null;
            switch (Cat)
            {
                case "All":
                    rec = DataProvider.GetAllSiteJvPrev(JvfromSite);

                    break;
                case "Approved":
                    rec = DataProvider.GetApprovedSiteJvPrev(JvfromSite);
                    break;
                case "PendingToApprive":
                    rec = DataProvider.GetPendingToApproveSiteJvPrev(JvfromSite);
                    break;
                case "Invesigate":
                    rec = DataProvider.GetRequireInvestigateSiteJvPrev(JvfromSite);
                    break;
            }

            if (rec == null)
            {
                await DialogService.ShowMessageBox("No Previuse record found", "There is not previuse record");
                return;
            }
            Navigation.NavigateTo($"/sitejv/{rec.DailyJvguid:N}/{Cat}");
        }

        async Task SaveAdminStatusClick()
        {
            await SaveClick();
        }
    }
}
