using System.Data;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Havesh.Domain.Services;

public class CloneProviderService
{
    readonly DataProviderService _dataService;

    public CloneProviderService(DataProviderService dataService)
    {
        _dataService = dataService;
    }

    IDbContextTransaction? _transaction;
    public void CreateTransaction()
    {

        _transaction ??= _dataService.DbContext.Database.BeginTransaction();
    }

    public void CommitTransaction()
    {
        _transaction?.Commit();
        _transaction?.Dispose();
        _transaction = null;
    }

    public void RollBackTransaction()
    {
        _transaction?.Rollback();
        _transaction?.Dispose();
        _transaction = null;
    }

    public List<ShokouhPardisLevelBookPrice> CloneBookPrices(ShokouhPardisTermClass fromTerm,
        ShokouhPardisTermClass toTerm)
    {
        CreateTransaction();
        try
        {
            var termBookPrices = _dataService.GetTermBookPrices(fromTerm);
            var list = termBookPrices
                    .Select(price => new ShokouhPardisLevelBookPrice
                    {
                        BookPrice = price.BookPrice,
                        TermId = toTerm.Id,
                        LevelId = price.LevelId,
                        TuitionAmount = price.TuitionAmount,

                        LevelBookPriceGuid = Guid.NewGuid(),
                        LevelBookPriceLastModified = DateTime.Now
                    })
                    .ToList();
            _dataService.AddBookPrices(list);
            return list;
        }
        catch (Exception e)
        {
            RollBackTransaction();
            throw;
        }

    }

    public IEnumerable<ShokouhPardisTeacherTermClass> CloneTeachers(ShokouhPardisTermClass fromTerm, ShokouhPardisTermClass toTerm)
    {
        if (_dataService.IsAnyTeachersInTerm(toTerm))
        {
            throw new DuplicateNameException();
        }

        CreateTransaction();
        try
        {
            var teachersInSource = _dataService.GetTeachersInTerm(fromTerm);
            var clonedTeacher = _dataService.AddTeacherToTerm(teachersInSource.ToList(), toTerm);
            return clonedTeacher;
        }
        catch (Exception e)
        {
            RollBackTransaction();
            throw;
        }

    }

    public List<ShokouhPardisInterval> CloneIntervals(ShokouhPardisTermClass fromTerm, ShokouhPardisTermClass toTerm)
    {
        if (_dataService.IsAnyIntervalsInTerm(toTerm))
        {
            throw new DuplicateNameException();
        }

        CreateTransaction();
        try
        {
            var intervals = _dataService.GetIntervals(fromTerm);
            var clonedInterval = intervals.Select(x =>
                new ShokouhPardisInterval
                {
                    SourceId = x.Id,

                    Title = x.Title,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime,
                    TimeInterval = x.TimeInterval,
                    TermId = toTerm.Id,
                    
                    IntervalGuid = Guid.NewGuid(),
                    IntervalLastModified = DateTime.Now
                })
                .ToList();
            _dataService.AddIntervals(clonedInterval);
            return clonedInterval;
        }
        catch (Exception e)
        {
            RollBackTransaction();
            throw;
        }

    }

    public List<ShokouhPardisProgram> ClonePrograms(ShokouhPardisTermClass fromTerm, ShokouhPardisTermClass toTerm,
        List<ShokouhPardisSchedule> clonedSchedule, List<ShokouhPardisDaySession> clonedDaySession)
    {
        CreateTransaction();
        try
        {
            var ids = clonedSchedule
                //.DistinctBy(x => x.SourceId)
                .Select(x => x.SourceId)
                .ToList();
            //clonedSchedule.
            var programs = _dataService.GetProgramsForSchedules(ids);
            var clonedPrograms = programs.Select(x =>
                new ShokouhPardisProgram()
                {
                    ScheduleId = clonedSchedule.First(s => s.SourceId == x.ScheduleId).Id,
                    DaysessionId = clonedDaySession.First(d => d.SourceId == x.DaysessionId).Id,

                    ProgramGuid = Guid.NewGuid(),
                    ProgramLastModified = DateTime.Now
                })
                .ToList();
            _dataService.AddPrograms(clonedPrograms);
            return clonedPrograms;
        }
        catch (Exception e)
        {
            RollBackTransaction();
            throw;
        }

    }

    public List<ShokouhPardisSchedule> CloneSchedules(ShokouhPardisTermClass fromTerm, ShokouhPardisTermClass toTerm)
    {
        if (_dataService.IsAnyScheduleInTerm(toTerm))
        {
            throw new DuplicateNameException();
        }

        CreateTransaction();
        try
        {
            var schedules = _dataService.GetSchedules(fromTerm);
            var clonedSchedule = schedules.Select(x =>
                new ShokouhPardisSchedule()
                {
                    SourceId = x.Id,

                    Title = x.Title,
                    TermFk = toTerm.Id,
                    ScheduleGuid = Guid.NewGuid(),
                    ScheduleLastModified = DateTime.Now
                })
                .ToList();
            _dataService.SaveSchedules(clonedSchedule);
            return clonedSchedule;
        }
        catch (Exception e)
        {
            RollBackTransaction();
            throw;
        }

    }

    public List<ShokouhPardisDaySession> CloneDaySessions(ShokouhPardisTermClass fromTerm,
        ShokouhPardisTermClass toTerm, List<ShokouhPardisInterval> clonedIntervals)
    {
        if (_dataService.IsAnyDaySessionInTerm(toTerm))
        {
            throw new DuplicateNameException();
        }

        CreateTransaction();
        try
        {
            var daySessions = _dataService.GetDaySessions(fromTerm);
            var clonedDaySessions = daySessions.Select(x =>
                new ShokouhPardisDaySession()
                {
                    SourceId = x.Id,

                    TermFk = toTerm.Id,
                    WeekdayId = x.WeekdayId,

                    IntervalId = clonedIntervals.First(i => i.SourceId == x.IntervalId).Id,

                    DaySessionGuid = Guid.NewGuid(),
                    DaySessionLastModified = DateTime.Now
                })
                .ToList();
            _dataService.SaveDaySessions(clonedDaySessions);
            return clonedDaySessions;
        }
        catch (Exception e)
        {
            RollBackTransaction();
            throw;
        }

    }

    public List<ShokouhPardisTimeTable> CloneTimeTable(ShokouhPardisTermClass fromTerm, ShokouhPardisTermClass toTerm,
        List<ShokouhPardisSchedule> clonedSchedule)
    {
        if (_dataService.IsAnyTimeTableInTerm(toTerm))
        {
            throw new DuplicateNameException();
        }

        CreateTransaction();
        var teachers = _dataService.GetTeachers();
        var levels = _dataService.GetLevels();
        try
        {
            var timeTables = _dataService.GetTimeTables(fromTerm);
            var cloneTimeTable = timeTables.Select(x =>
            {
                var teacherName = teachers.First(t => t.Id == x.TeacherId).FullName;
                var year = fromTerm.Year.YearName;
                var termName = toTerm.TermName;
                var schedule = clonedSchedule.First(s => s.SourceId == x.ScheduleId);
                var scheduleName = schedule.Title;
                var title = string.Join("<-", teacherName, year, termName, scheduleName);
                var levelClass = levels.First(l => l.Id == x.LevelId);
                return new ShokouhPardisTimeTable()
                {
                    SourceId = x.Id,

                    TermId = toTerm.Id,
                    TeacherId = x.TeacherId,

                    ScheduleId = schedule.Id,

                    Title = title,
                    //Description = "",
                    LevelId = levelClass.NextLevelFk ?? 1,
                    ClassRoomId = x.ClassRoomId,
                    TimeTableGuid = Guid.NewGuid(),
                    TimeTableLastModified = DateTime.Now
                };
            })
                .ToList();
            _dataService.SaveTimeTables(cloneTimeTable);
            return cloneTimeTable;
        }
        catch (Exception e)
        {
            RollBackTransaction();
            throw;
        }

    }

    public List<ShokouhPardisTimeTableStudent> CloneTimeTableStudents(ShokouhPardisTermClass fromTerm,
        List<ShokouhPardisTimeTable> clonedTimeTable)
    {
        var studentsInTimeTables = _dataService.GetStudentsInTimeTables(fromTerm);
        if (studentsInTimeTables == null)
            return new List<ShokouhPardisTimeTableStudent>();

        var tableStudents = studentsInTimeTables.SelectMany(pair =>
            pair.Value.Select(x =>
            {
                var timeTable = clonedTimeTable
                    .First(t => t.SourceId == x.TimeTableId);

                return new ShokouhPardisTimeTableStudent
                {
                    //TimeTable = timeTable,
                    TimeTableId = timeTable.Id,
                    StudentId = x.StudentId,

                    StudentPercentDiscount = x.StudentPercentDiscount,
                    StudentAmountDiscount = x.StudentAmountDiscount,

                    TimeTableStudentsGuid = Guid.NewGuid(),
                    TimeTableStudentsLastModified = DateTime.Now
                };
            }))
            .ToList();
        _dataService.SaveStudentsTableTable(tableStudents);

        return tableStudents;

    }
}