using System.Reflection;
using Havesh.Model.Data;
using Havesh.Model.Data.Dashboard;
using Havesh.Model.Filter;
using Havesh.Model.Model;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static Havesh.Model.Model.MyDbContext;

namespace Havesh.Model.Model;

public partial class MyDbContext : DbContext
{
    public User? Actor { get; set; }

    public DbSet<EntityChange> EntityChanges { get; set; }

    public event Action<EntityEntry>? EntityAdded;
    public event Action<EntityEntry>? EntityChanged;
    public event Action<EntityEntry>? EntityDeleted;
    public event Func<EntityEntry, Task?>? EntityTouched;

    protected virtual void OnEntityAdded(EntityEntry entry)
    {
	    EntityAdded?.Invoke(entry);
	    OnEntityTouched(entry);
    }

	protected virtual void OnEntityChanged(EntityEntry entry)
    {
	    EntityChanged?.Invoke(entry);
	    OnEntityTouched(entry);
    }

	protected virtual void OnEntityDeleted(EntityEntry entry)
    {
	    EntityDeleted?.Invoke(entry);
	    OnEntityTouched(entry);
    }

	protected virtual async Task? OnEntityTouched(EntityEntry entry)
    {
	    await EntityTouched?.Invoke(entry)!;
    }

	public override int SaveChanges()
    {
	    // Hook into the change tracker events
	    //ChangeTracker.StateChanged += OnStateChanged;

		var entityChanges = CaptureEntityChanges();

        foreach (var entry in ChangeTracker.Entries())
        {
	        var entityType = entry.Entity.GetType(); //== typeof(EntityChange);
	        var isValid = entry.CurrentValues.Properties.Any(x => x.Name == "Id");
	        if (!isValid) continue;
            
	        switch (entry.State)
	        {
		        case EntityState.Added:
			        OnEntityAdded(entry);
			        break;
		        case EntityState.Modified:
			        OnEntityChanged(entry);
			        break;
		        case EntityState.Deleted:
			        OnEntityDeleted(entry);
			        break;
	        }
        }



		// Save changes to the database
		//var result = base.SaveChanges();

        // Save the entity changes to a separate table or storage
        if (entityChanges == null)
        {
	        //ChangeTracker.StateChanged -= OnStateChanged;
	        return base.SaveChanges();
        }

        EntityChanges.AddRange(entityChanges);
        return base.SaveChanges();
        //ChangeTracker.StateChanged -= OnStateChanged;

    }

	private void OnStateChanged(object sender, EntityStateChangedEventArgs e)
	{
		// Check if the entity is added or modified
		if (e.NewState is not (EntityState.Added or EntityState.Modified)) return;
		
		var entity = e.Entry.Entity;

		// Handle the entity change or addition here
		Console.WriteLine($"Entity {entity.GetType().Name} with key {e.Entry.OriginalValues.Properties[0]} is {e.NewState}.");
	}

	private List<EntityChange>? CaptureEntityChanges()
    {

        List<EntityChange>? entityChanges = null;

        foreach (var entry in ChangeTracker.Entries())
        {
            if (entry.State == EntityState.Unchanged) continue;

	        var hasId = entry.CurrentValues.Properties.Any(x => x.Name == "Id");
	        if (!hasId || entry.Entity.GetType() == typeof(EntityChange))
		        continue;

	        entityChanges ??= new List<EntityChange>();

	        var idValue = entry.CurrentValues["Id"];
	        var entityName = entry.Entity.GetType().Name;
	        switch (entry.State)
			{
				case EntityState.Added:
					entityChanges.Add(new EntityChange
					{
						EntityName = entityName,
						EntityKey = idValue?.ToString(),
						Action = "Added",
						NewValue = JsonConvert.SerializeObject(entry.CurrentValues.ToObject()),
						ActionByFk = Actor?.Id,
						ActionWhen = DateTime.Now
					});
					break;
				case EntityState.Modified:
				{
					var oldValues = entry.OriginalValues;
					var newValues = entry.CurrentValues;

					var propertiesChanged = entry.OriginalValues.Properties
						.Where(p => !Equals(oldValues[p], newValues[p]))
						.Select(p => p);

					foreach (var property in propertiesChanged)
					{
						entityChanges.Add(new EntityChange
						{
							EntityName = entityName,
							EntityKey = idValue?.ToString(),
							Action = "Modified",
							Field = property.Name,
							OldValue = JsonConvert.SerializeObject(oldValues[property]),
							NewValue = JsonConvert.SerializeObject(newValues[property]),
							ActionByFk = Actor?.Id,
							ActionWhen = DateTime.Now
						});
					}

					break;
				}
				case EntityState.Deleted:
					entityChanges.Add(new EntityChange
					{
						EntityName = entityName,
						EntityKey = idValue?.ToString(),
						Action = "Deleted",
						OldValue = JsonConvert.SerializeObject(entry.OriginalValues.ToObject()),
						ActionByFk = Actor?.Id,
						ActionWhen = DateTime.Now
					});
					break;
			}
        }

        return entityChanges;
    }

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
        FollowUp.Setup(modelBuilder);
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

        //modelBuilder.Entity<BaseModel>().HasQueryFilter(e => !e.IsDeleted);

        /*
        var softDeleteEntities = typeof(ICanBeSoftDeleted).Assembly.GetTypes()
            .Where(type => typeof(ICanBeSoftDeleted)
                               .IsAssignableFrom(type)
                           && type is { IsClass: true, IsAbstract: false });

        var filter = new GlobalQueryFilter();
        foreach (var softDeleteEntity in softDeleteEntities)
        {
            modelBuilder.Entity(softDeleteEntity)
                .HasQueryFilter(
                    filter.GenerateQueryFilterLambdaExpression(softDeleteEntity)
                );

        }
    */
    }

}