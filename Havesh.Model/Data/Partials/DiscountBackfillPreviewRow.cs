using System.Text;
using System.Text.RegularExpressions;
namespace Havesh.Model.Model;

public class DiscountBackfillPreviewRow
{
    public int StudentId { get; set; }
    public string? StudentName { get; set; }
    public string? StudentFamily { get; set; }
    public int TermId { get; set; }
    public int MatchedDailyJvId { get; set; }
    public string? MatchedDescription { get; set; }
    public int ExtractedPercent { get; set; }
    public int AffectedTimeTableStudentCount { get; set; }
    public int AlreadyDiscountedCount { get; set; }

    // برای چک‌باکس انتخاب/رد در صفحه‌ی Admin — پیش‌فرض انتخاب‌شده
    public bool Selected { get; set; } = true;
}