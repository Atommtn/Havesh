using Microsoft.EntityFrameworkCore;
using ShokouhApp.Admin.MemberShip.Model;
using ShokouhApp.Data;
using ShokouhApp.Managment.Session.Activity;
using ShokouhApp.Services;

namespace ShokouhApp.Model;

public partial class MyDbContext : DbContext
{
    public virtual DbSet<User> Users{ get; set; } = null!;
    public virtual DbSet<Role> Roles{ get; set; } = null!;
    public virtual DbSet<Permission> Permissions{ get; set; } = null!;

    
    public virtual DbSet<ShokouhPardisMediaAttachment> MediaAttachments { get; set; } = null!;
    public virtual DbSet<StudentSessionActivity> StudentSessionActivities{ get; set; } = null!;
    public virtual DbSet<SessionActivity> SessionActivities{ get; set; } = null!;
    public virtual DbSet<SessionActivityValueOption> SessionActivityValueOptions{ get; set; } = null!;
    public virtual DbSet<TimeTableSession> TimeTableSessions{ get; set; } = null!;
    public virtual DbSet<LessonPlan> LessonPlans { get; set; } = null!;
    public virtual DbSet<LessonPlanAttachment> LessonPlanAttachments { get; set; }

	public virtual DbSet<LessonPlanSectionType> LessonPlanSectionTypes { get; set; } = null!;
    public virtual DbSet<LessonPlanSection> LessonPlanSections { get; set; } = null!;
    public virtual DbSet<LessonPlanSectionItem> LessonPlanSecionItems { get; set; } = null!;

    public virtual DbSet<TermSessionTemplateDate> TermSessionTemplateDates { get; set; } = null!;
    public virtual DbSet<TermSessionTemplate> TermSessionTemplates{ get; set; } = null!;
    public virtual DbSet<PreRegistration> PreRegistrations { get; set; } = null!;
    public virtual DbSet<ApplicationSettings> ApplicationSettings { get; set; } = null!;
    public virtual DbSet<ApplicationSettingsCategory> ApplicationSettingsCategory { get; set; } = null!;



    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        ShokouhPardisTermClass.Setup(modelBuilder);
        ShokouhPardisSchedule.Setup(modelBuilder);
        ShokouhPardisProgram.Setup(modelBuilder);
        ShokouhPardisDaySession.Setup(modelBuilder);
        ShokouhPardisTimeTable.Setup(modelBuilder);
        ShokouhPardisTimeTableStudent.Setup(modelBuilder);
        ShokouhPardisLevelBookPrice.Setup(modelBuilder);

        LessonPlanAttachment.Setup(modelBuilder);




	}
}