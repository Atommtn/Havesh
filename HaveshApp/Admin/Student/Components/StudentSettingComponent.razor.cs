
using System.Globalization;
using Havesh.Model.Model;
using Havesh.Application.Services;
using Havesh.Domain.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HaveshApp.Admin.Student.Components;

public partial class StudentSettingComponent
{
    private ShokouhPardisTimeTableStudent? _timeTableStudent;

    [Parameter]
    public ShokouhPardisTimeTableStudent? TimeTableStudent
    {
        get => _timeTableStudent;
        set
        {
            _timeTableStudent = value;

            if (_timeTableStudent != null)
            {
                Price = _dataProvider.GetLevelBookPrice(_timeTableStudent.TimeTable);

                // اگه قبلاً فقط مبلغ ثبت شده (نه درصد)، چک‌باکس "مبلغ عددی" رو خودکار تیک بزن
                // وگرنه فیلد مبلغ از اول readonly می‌ماند و کاربر فکر می‌کند قفل شده.
                ShowAmountValue = (_timeTableStudent.StudentAmountDiscount ?? 0) > 0
                                  && (_timeTableStudent.StudentPercentDiscount ?? 0) == 0;
            }
        }
    }

    [Parameter]
    public RenderFragment NoContent { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Inject]
    public IDialogService DialogService { get; set; }

    [Inject]
    public ISnackbar Snackbar { get; set; }

    [Inject] public StudentService StudentService { get; set; }

    private ShokouhPardisLevelBookPrice? Price { get; set; }

    public bool ShowAmountValue { get; set; }

    CultureInfo GetPersianCulture()
    {
        var culture = new CultureInfo("fa-IR");
        return culture;
    }

    private void SaveClick()
    {
        if (TimeTableStudent == null) return;

        _dataProvider.SaveTimeTableStudentDiscount(TimeTableStudent);

        Snackbar.Add("تخفیف با موفقیت ذخیره شد.", Severity.Success);
    }

    private void SetAmount()
    {
        if (Price == null || TimeTableStudent == null) return;

        var percent = TimeTableStudent.StudentPercentDiscount ?? 0;
        TimeTableStudent.StudentAmountDiscount = (int)Math.Round(Price.TuitionAmount * percent / 100.0);
    }

    private void SetPercent()
    {
        if (Price == null || TimeTableStudent == null || Price.TuitionAmount == 0) return;

        var amount = TimeTableStudent.StudentAmountDiscount ?? 0;
        TimeTableStudent.StudentPercentDiscount = (int)Math.Round(amount * 100.0 / Price.TuitionAmount);
        StateHasChanged();
    }
}
