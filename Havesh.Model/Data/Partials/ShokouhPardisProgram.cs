using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisProgram
{
    public static void Setup(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShokouhPardisProgram>()
            .HasOne(x => x.Schedule)
            .WithMany(x=>x.Programs);

        modelBuilder.Entity<ShokouhPardisProgram>()
            .HasOne(x => x.DaySession);
        
    }
    
    [ForeignKey(nameof(Model.ShokouhPardisProgram.ScheduleId))]
	[Id(0)]
	public ShokouhPardisSchedule Schedule { get; set; }

    [ForeignKey(nameof(Model.ShokouhPardisProgram.DaysessionId))]
	[Id(1)]
	public ShokouhPardisDaySession DaySession { get; set; }

    public static ShokouhPardisProgram CreateProgram(ShokouhPardisDaySession daySession,
        ShokouhPardisSchedule schedule)
    {
        return new ShokouhPardisProgram()
        {
            DaySession = daySession,
            Schedule = schedule,

            ProgramGuid = Guid.NewGuid(),
            ProgramLastModified = DateTime.Now
        };
    }
}

public partial class ShokouhPardisDaySession
{
    public static void Setup(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShokouhPardisDaySession>()
            .HasOne(x => x.WeekDay);
        
        modelBuilder.Entity<ShokouhPardisDaySession>()
            .HasOne(x => x.Interval);
    }

    [ForeignKey(nameof(Model.ShokouhPardisDaySession.WeekdayId))]
    public ShokouhPardisWeekDay WeekDay { get; set; }

    [ForeignKey(nameof(Model.ShokouhPardisDaySession.IntervalId))]
    public ShokouhPardisInterval Interval { get; set; }

    [NotMapped]
    public int SourceId { get; set; }
}

public partial class ShokouhPardisTimeTable
{
	public static void Setup(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShokouhPardisTimeTable>()
            .HasOne(x => x.Term);

        modelBuilder.Entity<ShokouhPardisTimeTable>()
            .HasOne(x => x.Teacher);

        modelBuilder.Entity<ShokouhPardisTimeTable>()
            .HasOne(x => x.Schedule);

        modelBuilder.Entity<ShokouhPardisTimeTable>()
            .HasOne(x => x.Level);
    }


    [Id(10)]
    [ForeignKey(nameof(TermId))]
    public ShokouhPardisTermClass Term { get; set; }

    [Id(11)]
    [ForeignKey(nameof(ScheduleId))]
    public ShokouhPardisSchedule Schedule { get; set; }

    [Id(12)]
    [ForeignKey(nameof(TeacherId))]
    public ShokouhPardisTeacherClass Teacher { get; set; }

    [Id(13)]
    [ForeignKey(nameof(LevelId))]
    public ShokouhPardisLevelClass Level { get; set; }

    [Id(14)]
    [ForeignKey(nameof(ClassRoomId))]
    public ShokouhPardisClassRoom ClassRoom { get; set; }

	[Id(15)]
	[ForeignKey("TimeTableFk")]
	public List<TimeTableSession> Sessions { get; set; }
    
	[NotMapped]
    public int StudentsCount { get; set; }

    [NotMapped]
    public int SourceId { get; set; }

    [NotMapped]
    public bool Selected { get; set; }

    [NotMapped]
    public string Tag { get; set; }

    public static ShokouhPardisTimeTable CreateTimeTable()
    {
        return new ShokouhPardisTimeTable()
        {
            TimeTableGuid = Guid.NewGuid(),
            TimeTableLastModified = DateTime.Now
            // Level = new ShokouhPardisLevelClass(),
            // Term = new ShokouhPardisTermClass()
            // {
            //     Year = new  ShokouhPardisYearClass()
            // }
        };
    }
}

