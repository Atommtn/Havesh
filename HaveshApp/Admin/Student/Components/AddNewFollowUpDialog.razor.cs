// جایگزین کامل کد قبلی. کد قبلی اصلاً به FollowUp ربطی نداشت (کپی نصفه‌ی دیالوگ ویرایش دانشجو
// بود: اسم/جنسیت/BCode را عوض می‌کرد و چیزی در جدول FollowUp ذخیره نمی‌کرد).
// این نسخه: فرم واقعی پیگیری (نوع/دلیل/نتیجه/وضعیت) + تاریخچه‌ی پیگیری‌های قبلی دانشجو،
// و واقعاً DataProvider.SaveFollowUp را صدا می‌زند.

using Havesh.Model.Model;
using Havesh.Application.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HaveshApp.Admin.Student.Components;

public partial class AddNewFollowUpDialog
{
    [CascadingParameter] MudDialogInstance DialogInstance { get; set; }

    [Parameter] public ShokouhPardisStudentClass Student { get; set; }
    [Parameter] public int TermId { get; set; }
    [Parameter] public FollowUpTypeEnum Type { get; set; } = FollowUpTypeEnum.Educational;

    [Inject] public ISnackbar Snackbar { get; set; }
    [Inject] public DataProviderService DataProvider { get; set; }
    

    private Havesh.Model.Model.FollowUp _followUp = new();
    private List<Havesh.Model.Model.FollowUp> _history = new();

    protected override void OnInitialized()
    {
        _followUp = Havesh.Model.Model.FollowUp.CreateNew(Student.Id, TermId, Type);
        _history = DataProvider.GetFollowUpsByStudent(Student.Id);
        base.OnInitialized();
    }

    private void SaveDialogClick()
    {
        if (string.IsNullOrWhiteSpace(_followUp.ResultFollow) && _followUp.IsResolved)
        {
            Snackbar.Add("اگر پیگیری را «انجام‌شده» علامت می‌زنید، نتیجه را هم بنویسید.", Severity.Warning);
            return;
        }

        _followUp.FollowDate = DateTime.Now;
        _followUp.HandledByUserName = _userSession.Payload.UserName;
        _followUp.FollowUpLastModified = DateTime.Now;

        DataProvider.SaveFollowUp(_followUp);

        Snackbar.Add("پیگیری با موفقیت ذخیره شد.", Severity.Success);
        DialogInstance.Close(DialogResult.Ok(_followUp));
    }
}