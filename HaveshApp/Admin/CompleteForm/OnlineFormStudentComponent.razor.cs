using Microsoft.AspNetCore.Components;
using MudBlazor;
using ShokouhApp.Model;
using System.Globalization;
using ShokouhApp.Services;
using Severity = MudBlazor.Severity;

namespace ShokouhApp.Admin.CompleteForm
{
    public partial class OnlineFormStudentComponent
    {
        StudentFormValidator StudentFormValidator = new();

        [Parameter]
        public ShokouhPardisStudentClassOnlineForm? Student
        {
            get => _student;
            set
            {
                _student = value;
                form?.ResetValidation();
            }
        }

        [Inject] ISnackbar Snackbar { get; set; }

        readonly MudTheme Theme = new MudTheme();

        string? pictureRequiredError;

        bool success;
        string[] errors = { };
        MudForm? form;
        ShokouhPardisStudentClassOnlineForm? _student;

        [Inject]
        public DataProviderService DataService { get; set; }

        async Task SaveClick()
        {
            await form?.Validate()!;
            //if (Student?.ProfilePicture.IsNullOrEmpty() ?? false)
            //{
            //    pictureRequiredError = "تصویر پروفایل زبان آموز را باید حتما ارسال کنید";
            //    return;
            //}

            if (form.IsValid)
            {
                DataService.SaveOnlineFormStudent(Student);
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.TopRight;
                Snackbar.Add("اطلاعات با موفقیت ذخیره شد", Severity.Success);
                Student = null;
                StateHasChanged();
            }
            else
            {
                Snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;
                Snackbar.Add("لطفا اطلاعات خواسته شده را تکمیل نمایید", Severity.Warning);
            }
        }

        CultureInfo GetPersianCulture()
        {
            var culture = new CultureInfo("fa-IR");
            return culture;
        }

        void RemovePictureClick()
        {

        }

    }
}
