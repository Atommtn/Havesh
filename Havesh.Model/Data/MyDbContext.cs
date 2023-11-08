using Havesh.Model.Data;
using Havesh.Model.Data.Dashboard;
using Havesh.Model.Model;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Havesh.Model.Model;

public partial class MyDbContext : DbContext
{

    public virtual DbSet<DashboardTemplate> DashboardTemplates { get; set; } = null!;
    public virtual DbSet<Dashboard> Dashboards { get; set; } = null!;
    public virtual DbSet<Widget> Widgets { get; set; } = null!;
    public virtual DbSet<DashboardTemplateWidget> DashboardTemplateWidgets { get; set; }
    public virtual DbSet<DashboardWidgetSetting> DashboardWidgetSettings { get; set; } = null!;
    public virtual DbSet<User> Users { get; set; } = null!;
    public virtual DbSet<AdvanceRegistration> AdvanceRegistrations { get; set; } = null!;
    public virtual DbSet<Role> Roles { get; set; } = null!;
    public virtual DbSet<Permission> Permissions { get; set; } = null!;

    public virtual DbSet<MessageBox> MessageBoxes { get; set; } = null!;
    public virtual DbSet<Message> Messages { get; set; } = null!;
    public virtual DbSet<MessageAction> MessageActions { get; set; } = null!;
    public virtual DbSet<MessageActionOption> MessageActionOptions { get; set; } = null!;




    public virtual DbSet<ShokouhPardisMediaAttachment> MediaAttachments { get; set; } = null!;
    public virtual DbSet<StudentSessionActivity> StudentSessionActivities { get; set; } = null!;
    public virtual DbSet<SessionActivity> SessionActivities { get; set; } = null!;
    public virtual DbSet<SessionActivityValueOption> SessionActivityValueOptions { get; set; } = null!;
    public virtual DbSet<TimeTableSession> TimeTableSessions { get; set; } = null!;
    public virtual DbSet<LessonPlan> LessonPlans { get; set; } = null!;
    public virtual DbSet<LessonPlanAttachment> LessonPlanAttachments { get; set; }

    public virtual DbSet<LessonPlanSectionType> LessonPlanSectionTypes { get; set; } = null!;
    public virtual DbSet<LessonPlanSection> LessonPlanSections { get; set; } = null!;
    public virtual DbSet<LessonPlanSectionItem> LessonPlanSectionItems { get; set; } = null!;

    public virtual DbSet<TermSessionTemplateDate> TermSessionTemplateDates { get; set; } = null!;
    public virtual DbSet<TermSessionTemplate> TermSessionTemplates { get; set; } = null!;
    public virtual DbSet<PreRegistration> PreRegistrations { get; set; } = null!;
    public virtual DbSet<ApplicationSettings> ApplicationSettings { get; set; } = null!;
    public virtual DbSet<ApplicationSettingsCategory> ApplicationSettingsCategory { get; set; } = null!;

    public static bool EnableGlobalFilter { get; set; }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        // Apply the filter condition to all queries for the entity
        /*modelBuilder.Entity<BranchBaseModel>().HasQueryFilter(
		    (e => e.BCode != null && (!EnableGlobalFilter || e.BCode.Contains("01"))));*/
        modelBuilder.Entity<DashboardTemplateWidget>()
            .HasKey(dt => new { dt.DashboardTemplateId, dt.WidgetId });

        modelBuilder.Entity<DashboardTemplateWidget>()
            .HasOne(dt => dt.DashboardTemplate)
            .WithMany(dt => dt.DashboardTemplateWidgets)
            .HasForeignKey(dt => dt.DashboardTemplateId);

        modelBuilder.Entity<DashboardTemplateWidget>()
            .HasOne(dt => dt.Widget)
            .WithMany(dt => dt.DashboardTemplateWidgets)
            .HasForeignKey(dt => dt.WidgetId);
        
        //---------------------------------

        modelBuilder.Entity<DashboardWidgetSetting>()
            .HasKey(dt => new { dt.DashboardId, dt.WidgetId });

        modelBuilder.Entity<DashboardWidgetSetting>()
            .HasOne(dt => dt.Dashboard)
            .WithMany(dt => dt.DashboardWidgets)
            .HasForeignKey(dt => dt.DashboardId);

        modelBuilder.Entity<DashboardWidgetSetting>()
            .HasOne(dt => dt.Widget)
            .WithMany(dt => dt.DashboardWidgets)
            .HasForeignKey(dt => dt.WidgetId);

        ShokouhPardisTermClass.Setup(modelBuilder);
        ShokouhPardisSchedule.Setup(modelBuilder);
        ShokouhPardisProgram.Setup(modelBuilder);
        ShokouhPardisDaySession.Setup(modelBuilder);
        ShokouhPardisTimeTable.Setup(modelBuilder);
        ShokouhPardisTimeTableStudent.Setup(modelBuilder);
        ShokouhPardisLevelBookPrice.Setup(modelBuilder);

        LessonPlanAttachment.Setup(modelBuilder);
        // Apply the global filter for all entities implementing ISoftDeletable
        /*foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
	        //Expression<Func<YourEntity, bool>> filter = e => !EnableGlobalFilter || e.IsDeleted == false;
			if (typeof(BranchBaseModel).IsAssignableFrom(entityType.ClrType))
	        {

		        var parameter = Expression.Parameter(entityType.ClrType, "e");
		        var property = Expression.Property(parameter, "IsDeleted");
		        var predicate = Expression.Lambda(
			        Expression.Equal(property, Expression.Constant(false)),
			        parameter);

		        modelBuilder.Entity(entityType.ClrType).HasQueryFilter(predicate);
	        }
        }*/
    }
}