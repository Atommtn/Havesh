using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace Havesh.Model.Model;

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
    public ShokouhPardisSchedule Schedule { get; set; }

    [ForeignKey(nameof(Model.ShokouhPardisProgram.DaysessionId))]
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
    ShokouhPardisTermClass _term;
    ShokouhPardisSchedule _schedule;
    ShokouhPardisTeacherClass _teacher;
    ShokouhPardisLevelClass _level;
    ShokouhPardisClassRoom _classRoom;

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

    public ShokouhPardisTermClass Term
    {
        get => _term;
        set
        {
            _term = value;
            TermId = _term.TermClassId;
        }
    }

    public ShokouhPardisSchedule Schedule
    {
        get => _schedule;
        set
        {
            _schedule = value;
            ScheduleId = _schedule.ScheduleId;
        }
    }

    public ShokouhPardisTeacherClass Teacher
    {
        get => _teacher;
        set
        {
            _teacher = value;
            TeacherId = _teacher.TeacherClassId;
        }
    }

    public ShokouhPardisLevelClass Level
    {
        get => _level;
        set
        {
            _level = value;
            LevelId = _level.LevelClassId;
        }
    }
    [Required]
    public ShokouhPardisClassRoom ClassRoom
    {
        get => _classRoom;
        set
        {
            _classRoom = value;
            ClassRoomId = _classRoom.ClassRoomId;
        }
    }

    [NotMapped]
    public int StudentsCount { get; set; }

    [NotMapped]
    public int SourceId { get; set; }

    [NotMapped]
    public bool Selected { get; set; }

    [ForeignKey("TimeTableFk")]
    public List<TimeTableSession> Sessions { get; set; }

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

