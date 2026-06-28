// نسخه‌ی کامل و نهایی — هم‌خوان با الگوی واقعی کدبیس که با ShokouhPardisProgram/ShokouhPardisDaySession
// تأیید شد:
//   - [Serializable] + [GenerateSerializer] باید روی خود کلاس هم باشه (ارث‌بری نمی‌شه، حتی با وجودش روی BranchBaseModel/BaseModel)
//   - [Id(n)] فقط روی navigation propertyها گذاشته می‌شه (نه روی فیلدهای اسکالر مثل Guid/DateTime/int) —
//     دقیقاً مثل ShokouhPardisProgram که ProgramGuid/ScheduleId/DaysessionId هیچ [Id] ندارن ولی
//     Schedule/DaySession (نوع‌های navigation) [Id(0)]/[Id(1)] دارن
//   - رابطه‌ها (HasOne) به‌جای نوشتن مستقیم تو OnModelCreating، در یک متد static Setup(ModelBuilder)
//     داخل خود کلاس مدل تعریف می‌شن (الگوی ShokouhPardisProgram.Setup / ShokouhPardisDaySession.Setup)
//   - بدون .WithMany() چون Student/Term هیچ کالکشن navigation به FollowUps ندارن (دقیقاً مثل
//     ShokouhPardisDaySession.Setup که .HasOne(x => x.WeekDay) رو بدون WithMany صدا می‌زند)

using Havesh.Model.Data;
using Microsoft.EntityFrameworkCore;
using Orleans;
using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public enum FollowUpTypeEnum
{
    Churn = 1,            // ریزش / عدم ثبت‌نام
    Educational = 2,       // پیگیری آموزشی معمول
    TeacherRequested = 3   // درخواست معلم از طریق حضور و غیاب
}

[Serializable]
[GenerateSerializer]
public partial class FollowUp : BranchBaseModel
{
    public int StudentId { get; set; }
    public int TermId { get; set; }
    public FollowUpTypeEnum Type { get; set; }
    public bool IsResolved { get; set; }

    public DateTime RequestDate { get; set; }
    public string? RequestedByUserName { get; set; }   // خالی = منشی خودش دستی ثبت کرده (نه از یه درخواست بیرونی)

    public DateTime? FollowDate { get; set; }
    public string? HandledByUserName { get; set; }      // کسی که عملاً پیگیری/تماس رو انجام داد

    public string? ReasonFollow { get; set; }
    public string? ResultFollow { get; set; }

    public Guid FollowUpGuid { get; set; }
    public DateTime FollowUpLastModified { get; set; }
}

public partial class FollowUp
{
    public static void Setup(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FollowUp>().HasOne(x => x.Student);
        modelBuilder.Entity<FollowUp>().HasOne(x => x.Term);
    }

    [Id(0)]
    [ForeignKey(nameof(Model.FollowUp.StudentId))]
    public ShokouhPardisStudentClass? Student { get; set; }

    [Id(1)]
    [ForeignKey(nameof(Model.FollowUp.TermId))]
    public ShokouhPardisTermClass? Term { get; set; }

    public static FollowUp CreateNew(int studentId, int termId, FollowUpTypeEnum type) => new()
    {
        FollowUpGuid = Guid.NewGuid(),
        FollowUpLastModified = DateTime.Now,
        StudentId = studentId,
        TermId = termId,
        Type = type,
        RequestDate = DateTime.Now,
        IsResolved = false
    };
}
