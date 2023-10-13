using FluentValidation;
using ShokouhApp.Classes;
using ShokouhApp.Model;

namespace ShokouhApp.Pages.SiteTransaction
{
    public class SiteJvValidation : AbstractValidator<ShokouhPardisJvfromSite>
    {
        public SiteJvValidation()
        {
            RuleFor(x => x.StudentName)
                .NotEmpty()
                .WithMessage("نام زبان آموز را وارد نمایید.")
                .MinimumLength(2)
                .WithMessage("نام زبان آموز را به درستی وارد نمایید.")
                .MaximumLength(128)
                .WithMessage("نام زبان آموز را به درستی وارد نمایید.")
                ;

            RuleFor(x => x.StudentFamil)
                .NotEmpty()
                .WithMessage("نام خانوادگی زبان آموز را واردنمایید.")
                .MinimumLength(3)
                .WithMessage("نام خانوادگی زبان آموز را به درستی وارد نمایید.")
                .MaximumLength(128)
                .WithMessage("نام خانوادگی زبان آموز را به درستی وارد نمایید.")
                ;

            RuleFor(x => x.StudentIdNumber)
                .NotEmpty()
                .WithMessage("کد ملی زبان آموز وارد کنید")
                .Length(10)
                .WithMessage("طول کد ملی باید 10 رقم باشد")
                .Must((y, x) =>
                {
                    y.StudentIdNumber = y.StudentIdNumber?.NormalizeClearNumber().NormalizeFromFarsiNumber();
                    return x.IsValidNationalCode();
                })
                .WithMessage("کد ملی وارد شده معتبر نیست")
                ;

            RuleFor(x => x.PhoneNumber)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("تلفن همراه را وارد کنید")
                .Must((y, x) =>
                {
                    y.PhoneNumber = y.PhoneNumber?.NormalizeClearNumber().NormalizeFromFarsiNumber();
                    return IsValidPhoneNumber(x);
                })
                .WithMessage("شماره تلفن همراه وارد شده معتبر نیست")
                ;

            RuleFor(x => x.CardPostfix)
                .NotEmpty()
                .WithMessage("چهار رقم کارت واریز کننده را وارد نمایید.")
                ;

            RuleFor(x => x.Txcode)
                .NotEmpty()
                .WithMessage("شماره شناسه واریز را وارد نمایید.")
                ;

            RuleFor(x => x.FeeFor)
                .NotEmpty()
                .WithMessage("علت واریز را وارد نمایید.")
                ;

            RuleFor(x => x.Fee)
                .NotEmpty()
                .WithMessage("مبلغ واریز را وارد نمایید.")
                ;

            RuleFor(x => x.DateOfSettle)
                .NotEmpty()
                .WithMessage("تاریخ واریز را وارد نمایید.")
                ;

            RuleFor(x => x.AttachmentFk)
                .NotEmpty()
                .WithMessage("تصویر قبض واریز را آپلود نمایید.")
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
            var result = await ValidateAsync(ValidationContext<ShokouhPardisJvfromSite>.CreateWithOptions((ShokouhPardisJvfromSite)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();

            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
