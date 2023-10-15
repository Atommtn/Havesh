using FluentValidation;
using HaveshApp.Classes;
using HaveshApp.Model;

namespace HaveshApp.Admin.CompleteForm;

public class StudentFormValidator : AbstractValidator<ShokouhPardisStudentClassOnlineForm>
{
    public StudentFormValidator()
    {
        RuleFor(x=>x.StudentName)
            .NotEmpty()
            .WithMessage("نام زبان آموز را وارد نمایید.")
            .MinimumLength(2)
            .WithMessage("نام زبان آموز را به درستی وارد نمایید.")
            .MaximumLength(128)
            .WithMessage("نام زبان آموز را به درستی وارد نمایید.")
            ;

        RuleFor(x=>x.StudentFamily)
            .NotEmpty()
            .WithMessage("نام خانوادگی زبان آموز را واردنمایید.")
            .MinimumLength(3)
            .WithMessage("نام خانوادگی زبان آموز را به درستی وارد نمایید.")
            .MaximumLength(128)
            .WithMessage("نام خانوادگی زبان آموز را به درستی وارد نمایید.")
            ;

        RuleFor(x => x.StudentIdno)
            .NotEmpty()
            .WithMessage("کد ملی زبان آموز وارد کنید")
            .Length(10)
            .WithMessage("طول کد ملی باید 10 رقم باشد")
            .Must((y, x) =>
            {
                y.StudentIdno = y.StudentIdno?.NormalizeClearNumber().NormalizeFromFarsiNumber();
                return x.IsValidNationalCode();
            })
            .WithMessage("کد ملی وارد شده معتبر نیست")
            ;

        var minAge = 5;
        RuleFor(x => x.StudentBirthDay)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("تاریخ تولد زبان آموز را وارد نمایید.")
            .Must(d => (DateTime.Now - d.Value) >= TimeSpan.FromDays(minAge * 365))
            .WithMessage($"حداقل سن برای شرکت در کلاس ها {minAge} سال می باشد")
            ;

        RuleFor(x => x.StudentFrom)
            .NotEmpty()
            .WithMessage("محل صدور شناسنامه زبان آموز را وارد نمایید.")
            ;

        RuleFor(x => x.StudentFatherName)
            .NotEmpty()
            .WithMessage("نام پدر زبان آموز را وارید کنید")
            ;

        RuleFor(x => x.StudentMotherFullName)
            .NotEmpty()
            .WithMessage("نام و نام خانوادگی مادر زبان آموز را وارد نمایید.")
            ;

        RuleFor(x => x.FatherJob)
            .NotEmpty()
            .WithMessage("شغل پدر زبان آموز را وارد نمایید.")
            ;
        //
        // RuleFor(x => x.MotherJob)
        //     .NotEmpty()
        //     .WithMessage()
        //     ;

        RuleFor(x => x.StudentAddress)
            .NotEmpty()
            .WithMessage("نشانی منزل زبان آموز را وارد نمایید.")
            ;

        RuleFor(x => x.HomePhone)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("شماره ثابت منزل زبان آموز را وارد نمایید.اگر منزلتان شماره ثابت ندارد صفر وارد نمایید")
            .Must((y, x) =>
            {
                y.HomePhone = y.HomePhone?.NormalizeClearNumber().NormalizeFromFarsiNumber();
                var isValidPhoneNumber = IsValidPhoneNumber(x,false);
                Console.WriteLine(isValidPhoneNumber);
                return isValidPhoneNumber;
            })
            .WithMessage("شماره تلفن ثابت وارد شده معتبر نیست")
            ;

        RuleFor(x => x.StudentPhone)
            .Must((y, x) =>
            {
                y.StudentPhone = y.StudentPhone?.NormalizeClearNumber().NormalizeFromFarsiNumber();
                return true;
            })
            ;

        RuleFor(x => x.FatherPhone)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("تلفن همراه پدر زبان آموز را وارد کنید")
            .Must((y,x) =>
            {
                y.FatherPhone = y.FatherPhone?.NormalizeClearNumber().NormalizeFromFarsiNumber();
                return IsValidPhoneNumber(x);
            })
            .WithMessage("شماره تلفن همراه وارد شده معتبر نیست")
            ;

        RuleFor(x => x.MotherPhone)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("تلفن همراه مادر زبان آموز را وارد کنید")
            .Must((y, x) =>
            {
                y.MotherPhone = y.MotherPhone?.NormalizeClearNumber().NormalizeFromFarsiNumber();
                return IsValidPhoneNumber(x);
            })
            .WithMessage("شماره تلفن همراه وارد شده معتبر نیست")
            ;

        RuleFor(x => x.WhatsAppPhone)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("تلفن همراه دارای واتساپ جهت ارتباط زبان آموز را وارد کنید")
            .Must((y, x) =>
            {
                y.WhatsAppPhone = y.WhatsAppPhone?.NormalizeClearNumber().NormalizeFromFarsiNumber();
                return IsValidPhoneNumber(x);
            })
            .WithMessage("شماره تلفن همراه وارد شده معتبر نیست")
            ;

        //RuleFor(x => x.SchoolStartTime)
        //    .Cascade(CascadeMode.Stop)
        //    .NotEmpty()
        //    .WithMessage("زمان آغاز حضور در مدرسه زبان آموز را وارد کنید")
        //    ;

        //RuleFor(x => x.SchoolEndTime)
        //    .Cascade(CascadeMode.Stop)
        //    .NotEmpty()
        //    .WithMessage("زمان خاتمه حضور در مدرسه زبان آموز را وارد کنید")
        //    .Must((x,y)=> x.SchoolStartTime < y)
        //    .WithMessage("زمان خاتمه مدرسه باید بعد از زمان آغاز باشد")
            ;

    }

    public static bool IsValidPhoneNumber(string phone, bool isMobile = true)
    {
        phone = phone.NormalizeClearNumber().NormalizeFromFarsiNumber();
        if (phone.Length == 1 && phone[0] == '0')
            return true;

        if (phone.StartsWith("+98"))
            phone = 0 + phone.Substring(2);

        if (phone.StartsWith("0098"))
            phone = 0 + phone.Substring(3);

        var tel = phone;
        if (isMobile)
        {
            if (phone.StartsWith("9") && phone.Length == 10)
                return true;
            if (tel.Length != 11)
                return false;
            if (!tel.StartsWith("09"))
                return false;
        }
        else
        {
            if (!tel.StartsWith("0") && tel.Length != 8)
                return false;
        }

        return true;
    }

    
    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<ShokouhPardisStudentClassOnlineForm>.CreateWithOptions((ShokouhPardisStudentClassOnlineForm)model, x => x.IncludeProperties(propertyName)));
        
        return result.IsValid ? 
            Array.Empty<string>() : 
            result.Errors.Select(e => e.ErrorMessage);
    };

}