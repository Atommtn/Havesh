using System.ComponentModel;
using System.Globalization;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Olive;
using HaveshApp.Classes;
using Havesh.Model.Model;
using MudBlazor;


/*
using Havesh.Model.Model.MyDbContext;
*/

namespace Havesh.Domain.Services;

public class DataProviderService
{
    public MyDbContext DbContext { get; }


    public DataProviderService(MyDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public List<ShokouhPardisYearClass> GetYears()
    {
        return DbContext.ShokouhPardisYearClasses.Include(x => x.Terms).ToList();
    }

    public List<ShokouhPardisTermClass> GetTerms(ShokouhPardisYearClass year)
    {
        return DbContext.ShokouhPardisTermClasses.Where(x => x.YearId == year.Id).ToList();
    }


    public List<ShokouhPardisSchedule> GetSchedules(ShokouhPardisTermClass term)
    {
        var schedule = DbContext.ShokouhPardisSchedules
            .Include(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.Interval)

            .Include(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.WeekDay)

            .Where(x => x.TermFk == term.Id)
            .ToList();
        return schedule;
    }

    public List<ShokouhPardisTeacherClass> GetTeacherByAny(string search,
        ShokouhPardisTermClass? term)
    {
        var relatedTeachers = DbContext
            .ShokouhPardisTeacherTermClasses
            .Include(x => x.Teacher)
            .Where(x => (term != null && x.TermFk == term.Id) &&
                        (x.Teacher.TeacherName.Contains(search) || x.Teacher.TeacherFamily.Contains(search))
            )
            .Select(x => x.Teacher)
            .ToList();

        return relatedTeachers;
    }

    public List<ShokouhPardisTeacherClass> GetTeacher()
    {
        List<ShokouhPardisTeacherClass> Teachers;
        Teachers = DbContext.ShokouhPardisTeacherClasses.ToList();
        return Teachers;
    }

    public bool SaveTeacherTimeTable(ShokouhPardisTimeTable teacherTimesheet)
    {
        var title =
            $"{teacherTimesheet.Teacher} -> {teacherTimesheet.Term.Year.YearName} -> {teacherTimesheet.Term.TermName} -> {teacherTimesheet.Schedule.Title}";
        teacherTimesheet.Title = title;
        var isDuplicate = teacherTimesheet.Id == 0 && TimeTableDuplicate(teacherTimesheet);
        if (isDuplicate)
            return isDuplicate;

        DbContext.ShokouhPardisTimeTables.Update(teacherTimesheet);
        DbContext.SaveChanges();
        return isDuplicate;
    }

    bool TimeTableDuplicate(ShokouhPardisTimeTable teacherTimesheet)
    {
        var result = DbContext.ShokouhPardisTimeTables.Any(x =>
            x.TermId == teacherTimesheet.Term.Id &&
            x.ScheduleId == teacherTimesheet.Schedule.Id &&
            x.TeacherId == teacherTimesheet.Teacher.Id);
        return result;
    }


    public bool SaveEditTeacher(ShokouhPardisTeacherClass teacher)
    {
        bool isDuplicate = TeacherDuplicate(teacher);
        if (isDuplicate)
        {
        }
        else
        {
            DbContext.ShokouhPardisTeacherClasses.Update(teacher);
            DbContext.SaveChanges();
        }

        return isDuplicate;
    }

    bool TeacherDuplicate(ShokouhPardisTeacherClass teacher)
    {
        var result = DbContext.ShokouhPardisTeacherClasses.Any(x =>
            x.TeacherName == teacher.TeacherName &&
            x.TeacherFamily == teacher.TeacherFamily);
        return result;
    }

    public void DeleteTimesheet(ShokouhPardisTimeTable context)
    {
        var students = DbContext.ShokouhPardisTimeTableStudents.Where(x => x.TimeTableId == context.Id);
        DbContext.RemoveRange(students);

        DbContext.ShokouhPardisTimeTables.Remove(context);
        DbContext.SaveChanges();
    }


    public List<ShokouhPardisWeekDay> GetWeekDays()
    {
        var shokouhPardisWeekDays = DbContext.ShokouhPardisWeekDays.ToList();
        return shokouhPardisWeekDays;
    }

    public List<ShokouhPardisInterval> GetIntervals(ShokouhPardisTermClass? term)
    {
        if (term == null)
            return
                new List<ShokouhPardisInterval>();

        var shokouhPardisIntervals = DbContext.ShokouhPardisIntervals
            .Where(x => x.TermId == term.Id)
            .ToList();
        return shokouhPardisIntervals;
    }

    public void SaveTeacherTimeSheet(ShokouhPardisTeacherTimeSheet timeSheet, bool isDefer = false)
    {
        DbContext.Update(timeSheet);
        if (!isDefer) DbContext.SaveChanges();
    }

    public void SaveAll()
    {
        DbContext.SaveChanges();
    }

    public ShokouhPardisTeacherTimeSheet GetTermTeacherTimeSheet(int termId, int teacherId, int weekdayId,
        int intervalId)
    {
        var shokouhPardisTeacherTimeSheet = DbContext.ShokouhPardisTeacherTimeSheets
                .FirstOrDefault(x =>
                    x.TermId == termId &&
                    x.TeacherId == teacherId &&
                    x.WeekDayId == weekdayId &&
                    x.IntervalId == intervalId)
            ;
        return shokouhPardisTeacherTimeSheet;
    }

    public List<ShokouhPardisTeacherTimeSheet> GetTermTeacherTimeSheets(int termId, int teacherId)
    {
        var shokouhPardisTeacherTimeSheet = DbContext.ShokouhPardisTeacherTimeSheets
            .Include(x => x.Teacher)
            .Include(x => x.Interval)
            .Include(x => x.WeekDay)
            .Include(x => x.Term)
            .ThenInclude(x => x.Year)
            .Where(x => x.TermId == termId && x.TeacherId == teacherId)
            .ToList();
        return shokouhPardisTeacherTimeSheet;
    }

    public void SaveTeacherTimeSheets(IEnumerable<ShokouhPardisTeacherTimeSheet> teacherTimeSheets,
        IEnumerable<ShokouhPardisTeacherTimeSheet> delItems)
    {
        DbContext.ShokouhPardisTeacherTimeSheets.RemoveRange(delItems);
        DbContext.ShokouhPardisTeacherTimeSheets.UpdateRange(teacherTimeSheets);
        DbContext.SaveChanges();
    }

    public bool AnyTeacherTimeSheet(ShokouhPardisTermClass term, ShokouhPardisTeacherClass teacher)
    {
        var any = DbContext.ShokouhPardisTeacherTimeSheets.Any(x =>
            x.TermId == term.Id && x.TeacherId == teacher.Id);
        return any;
    }

    public IEnumerable<ShokouhPardisLevelClass> GetLevels()
    {
        var shokouhPardisLevelClasses = DbContext.ShokouhPardisLevelClasses.ToList();
        return shokouhPardisLevelClasses;
    }

    public List<ShokouhPardisClassRoom> GetClassRooms()
    {
        var classRooms = DbContext.ShokouhPardisClassRooms.OrderBy(x => x.ClassRoomName).ToList();
        return classRooms;
    }

    public List<ShokouhPardisTimeTable> GetTimeTables(ShokouhPardisInterval interval , ShokouhPardisWeekDay weekDay)
    {
	    var timeTables = DbContext.ShokouhPardisTimeTables
		    .Include(x=>x.Teacher)
		    .Include(x=>x.ClassRoom)
		    .Include(x=>x.Schedule)
		    .ThenInclude(x=>x.Programs)
		    .ThenInclude(x=>x.DaySession)
		    .Include(x=>x.Sessions)
		    .OrderBy(x=>x.ClassRoom.ClassRoomName)
		    .Where(x=>x.Schedule.Programs.Any(z=>z.DaySession.IntervalId == interval.Id && 
		                                         z.DaySession.WeekdayId == weekDay.Id))
		    .ToList();
	    return timeTables;
    }

    public void AddStudentsToTeacherTimeSheet(ShokouhPardisTimeTable timeTable,
        List<ShokouhPardisStudentClass> selectedStudents)
    {
        foreach (var student in selectedStudents)
        {
            DbContext.ShokouhPardisTimeTableStudents.Add(new ShokouhPardisTimeTableStudent()
            {
                Student = student,
                TimeTable = timeTable,
                TimeTableStudentsGuid = Guid.NewGuid(),
                TimeTableStudentsLastModified = DateTime.Now
            });

        }

        DbContext.SaveChanges();

    }

    public bool IsStudentInOtherClassesInTheTerm(ShokouhPardisTimeTable timeTable, ShokouhPardisStudentClass student)
    {
        var any = DbContext.ShokouhPardisTimeTableStudents
            .Any(x =>
                x.StudentId == student.Id &&
                x.TimeTable.TermId == timeTable.TermId
            );
        return any;
    }

    public ShokouhPardisTimeTable? GetTimeTable(int timeTableId)
    {
        var timeTable = DbContext.ShokouhPardisTimeTables
            .Include(x => x.Sessions)

            .Include(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)

            .Include(x => x.Level)
            .Include(x => x.Teacher)
            .Include(x => x.ClassRoom)

            .FirstOrDefault(x => x.Id == timeTableId);
        return timeTable;
    }

    public ShokouhPardisTimeTable? GetTimeTable(Guid timeTableId)
    {
        var timeTable = DbContext.ShokouhPardisTimeTables.FirstOrDefault(x => x.TimeTableGuid == timeTableId);
        return timeTable;
    }

    public List<ShokouhPardisTimeTable> GetTimeTableByTermSchedule(ShokouhPardisTermClass selectedTerm,
        ShokouhPardisSchedule schedules)
    {
        var timeTable = DbContext.ShokouhPardisTimeTables
            .Include(x => x.Level)
            .Include(x => x.Teacher)
            .Include(x => x.ClassRoom)
            .Where(
                x => x.TermId == selectedTerm.Id &&
                     x.ScheduleId == schedules.Id).ToList();
        return timeTable;
    }

    public void deleteStudentFromClassPlan(ShokouhPardisStudentClass student, ShokouhPardisTimeTable timeTableItem)
    {
        var timeTableStudent = DbContext.ShokouhPardisTimeTableStudents
            .First(x => x.TimeTableId == timeTableItem.Id &&
                        x.StudentId == student.Id);
        DbContext.ShokouhPardisTimeTableStudents.Remove(timeTableStudent);

        DbContext.SaveChanges();
    }

    public List<ShokouhPardisStudentClassOnlineForm> GetOnlineFormStudentsList(Guid? uniqueKey)
    {
        var list = DbContext.ShokouhPardisStudentClassOnlineForms.Where(x => x.UniqueKey == uniqueKey).ToList();
        return list;
    }

    public void SaveOnlineFormStudent(ShokouhPardisStudentClassOnlineForm student)
    {
        if (student.Id == 0)
        {
            student.RecordVersion = 1;
            student.CreatedAt = DateTime.Now;

        }
        else
        {
            student.RecordVersion++;
            student.StudentClassLastModified = DateTime.Now;
        }

        DbContext.ShokouhPardisStudentClassOnlineForms.Update(student);
        DbContext.SaveChanges();
    }

    public void DirectUpdateStudentProfileUrlField(ShokouhPardisStudentClassOnlineForm student)
    {

        DbContext.Database.ExecuteSqlRaw(
            $"UPDATE [ShoukouhPardis12DBAdmin].[ShokouhPardis_StudentClass_OnlineForm] SET [ProfilePicture]='{student.ProfilePicture}' WHERE [StudentClassId] = {student.Id}");
    }

    public ShokouhPardisLevelBookPrice? GetLevelBookPrice(ShokouhPardisTimeTable timeTable)
    {
        return DbContext.ShokouhPardisLevelBookPrices
            .FirstOrDefault(x =>
                //x.YearId == timeTable.Term.Year.YearClassId &&
                x.TermId == timeTable.Term.Id &&
                x.LevelId == timeTable.Level.Id);
    }

    public ShokouhPardisLevelBookPrice? GetLevelBookPrice(int termId, int levelId)
    {
        return DbContext.ShokouhPardisLevelBookPrices
            .FirstOrDefault(x =>
                x.TermId == termId &&
                x.LevelId == levelId);
    }

    public List<ShokouhPardisLevelBookPrice> GetAllLevelBookPriceByTerm(ShokouhPardisTermClass term)
    {
        return DbContext.ShokouhPardisLevelBookPrices
            .Include(x => x.Level)
            .Where(x =>
                x.TermId == term.Id)
            .OrderBy(x => x.Level.LevelName)
            .ToList();
    }


    public void SaveDailyJV(ShokouhPardisDailyJv dailyJv)
    {
        //_financialService.ApplyDailyJv(dailyJv);
        SaveEditDailyJV(dailyJv);
        DbContext.SaveChanges();
    }

    public int GenerateBillNoDailyJv(ShokouhPardisDailyJv dailyJv)
    {
        var queryable = DbContext.ShokouhPardisDailyJvs

            .AsQueryable();
        int? _id = null;
        queryable = queryable.Where(x => x.CurrentDate.Value.Year == dailyJv.CurrentDate.Value.Year &&
                                         x.CurrentDate.Value.Month == dailyJv.CurrentDate.Value.Month &&
                                         x.CurrentDate.Value.Day == dailyJv.CurrentDate.Value.Day);
        if (queryable.Any())
        {
            _id = queryable.Select(t => t.Id)
                .OrderByDescending(t => t)
                .FirstOrDefault();
        }

        if (_id == null)
        {

        }
        else
        {

        }

        return 1;
    }

    public ShokouhPardisDailyJv GetDailyJv(int dailyJvid)
    {
        var jv = DbContext.ShokouhPardisDailyJvs
            .Include(x => x.Student)
            .Include(x => x.Term)
            .Include(x => x.TimeTable)
            .Include(x => x.TimeTable.Level)
            .FirstOrDefault(x => x.Id == dailyJvid);
        return jv;
    }

    public ShokouhPardisTimeTable? GetStudetnLevel(ShokouhPardisStudentClass student, ShokouhPardisTermClass term)
    {
        var tts = DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)
            .Include(x => x.Student)
            .FirstOrDefault(
                x => x.TimeTable.TermId == term.Id &&
                     x.Student.Id == student.Id);
        if (tts != null) return tts.TimeTable;
        return null;
    }



    public ShokouhPardisYearClass GetYearsInRange()
    {
        var pc = new PersianCalendar();
        var shamsiYear = pc.GetYear(DateTime.Today);

        var year = DbContext.ShokouhPardisYearClasses.AsQueryable();
        return year.First(x => x.YearName == shamsiYear.ToString());
    }


    public ShokouhPardisTermClass? GetTermsInRangeToday(DateTime? defDate = null)
    {
        //dateToCheck >= startDate && dateToCheck < endDate;
        var dt = defDate ?? DateTime.Today;

        var term = DbContext.ShokouhPardisTermClasses.AsQueryable();
        var termClass = term.FirstOrDefault(x => x.StartDate <= dt &&
                                                              x.EndDate >= dt);
        return termClass;
    }

    public Dictionary<int, int> GetTimeTableStudentsCount(ShokouhPardisTermClass term)
    {
        var xx = DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .Where(x => x.TimeTable.TermId == term.Id)
            .GroupBy(x => ((int)x.TimeTableId)!)
            .Select(group => new
            {
                g = group.Key,
                Count = group.Count()
            })
            .ToDictionary(k => k.g, x => x.Count!);
        return xx;
    }

    public List<ShokouhPardisDailyJv> GetDailyJvs()
    {
        return DbContext.ShokouhPardisDailyJvs.ToList();
    }

    public List<ShokouhPardisTimeTableStudent> GetTimeTableStudent(ShokouhPardisTimeTable timeTable)
    {

        var xx = DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.Student)
            .Where(x => x.TimeTable.Id == timeTable.Id).ToList();
        return xx;
    }
    public ShokouhPardisTimeTableStudent? GetTimeTableStudent(ShokouhPardisStudentClass student, ShokouhPardisTermClass term)
    {
        var tableStudent = DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Term)
            .FirstOrDefault(x => x.TimeTable.TermId == term.Id
                                 && x.StudentId == student.Id);
        return tableStudent;
    }
    public List<ShokouhPardisTimeTableStudent> GetTimeTableStudents(IEnumerable<ShokouhPardisTimeTable> timeTables)
    {
        var ids = timeTables.Select(z => z.Id).ToArray();

        var xx = DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.Student)
            // .Include(x => x.DailyJvs.Where(z => z.TermId == x.TimeTable.TermId && 
            //                                   z.StudentId == x.Student.StudentClassId))
            .Where(x => ids.Contains(x.TimeTableId))
            //.Select(x => x.Student)

            .ToList();
        return xx;
    }

    public List<ShokouhPardisStudentClass>? GetTimeTableStudents(ShokouhPardisTimeTable? timeTable)
    {
        if (timeTable == null) return null;
        var xx = DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.Student)
            .Where(x => x.TimeTableId == timeTable.Id)
            .Select(x => x.Student)

            .ToList();
        return xx;
    }

    public int GetTotalTimeTablesCount(int termTermClassId, string? searchText = null, bool? isPrivate = false)
    {
        var dbConntextShokouhPardisTimeTables = DbContext.ShokouhPardisTimeTables.AsQueryable();
        if (!string.IsNullOrEmpty(searchText))
            dbConntextShokouhPardisTimeTables = dbConntextShokouhPardisTimeTables.Where(x => x.Title.Contains(searchText));
        if (isPrivate is true)
            dbConntextShokouhPardisTimeTables = dbConntextShokouhPardisTimeTables.Where(x => x.IsPrivate == true);

        var count = dbConntextShokouhPardisTimeTables.Count(x => x.TermId == termTermClassId);
        return count;
    }

    public List<ShokouhPardisTimeTable> GetTimeTables(ShokouhPardisTermClass fromTerm, string? searchText = null,
        int? page = null, int? pageSize = null)
    {
        var shokouhPardisTimeTables = ShokouhPardisTimeTablesQuery(fromTerm);
        if (!string.IsNullOrEmpty(searchText))
        {
            shokouhPardisTimeTables = shokouhPardisTimeTables.Where(x => x.Title.Contains(searchText));
        }

        if (page != null && pageSize != null)
        {
            shokouhPardisTimeTables = shokouhPardisTimeTables.Skip((int)(page * pageSize)).Take((int)pageSize);
        }

        return shokouhPardisTimeTables
            .OrderBy(x => x.Schedule.Title)
            .ToList();
    }

    IQueryable<ShokouhPardisTimeTable> ShokouhPardisTimeTablesQuery(ShokouhPardisTermClass fromTerm)
    {
        var shokouhPardisTimeTables = DbContext
            .ShokouhPardisTimeTables
            .Include(x => x.Schedule)
            .Include(x => x.ClassRoom)
            .Include(x => x.Level)
            .Include(x => x.Teacher)
            .Where(x => x.TermId == fromTerm.Id);
        return shokouhPardisTimeTables;
    }

    public IEnumerable<ShokouhPardisTimeTable>
        GetTimeTables(int page, int pageSize, string? searchText,
            ShokouhPardisTermClass term, bool isPrivate)
    {
        var queryable = DbContext
                .ShokouhPardisTimeTables

                .Include(x => x.Term)
                .ThenInclude(x => x.Year)
                .ThenInclude(x => x.Terms)

                .Include(x => x.Schedule)
                .ThenInclude(x => x.Programs)
                .ThenInclude(x => x.DaySession)
                .ThenInclude(x => x.Interval)

                .Include(x => x.Schedule)
                .ThenInclude(x => x.Programs)
                .ThenInclude(x => x.DaySession)
                .ThenInclude(x => x.WeekDay)

                .Include(x => x.Level)

                .Include(x => x.ClassRoom)

                .Include(x => x.Teacher)
                //.AsQueryable()
                .Where(x => x.TermId == term.Id && x.IsPrivate == isPrivate)
            ;

        if (!string.IsNullOrEmpty(searchText))
        {
            queryable = queryable.Where(x =>
                x.Teacher.TeacherName.Contains(searchText) ||
                x.Teacher.TeacherFamily.Contains(searchText) ||
                (x.Term.TermName != null && x.Term.TermName.Contains(searchText)) ||
                (x.Description != null && x.Description.Contains(searchText)) ||
                x.Schedule.Title.Contains(searchText) ||
                x.Level.LevelName.Contains(searchText)
            );
        }

        var shokouhPardisTimeTables = queryable
            .OrderBy(x => x.ScheduleId)
            .Skip(page * pageSize)
            .Take(pageSize)
            .ToList();
        return shokouhPardisTimeTables;
    }


    public List<ShokouhPardisDailyJv> GetDaliyJv(DateTime dailyJvCurrentDate)
    {
        var JvIds = DbContext.ShokouhPardisDailyJvs.AsQueryable()
            .Where(x => x.CurrentDate == dailyJvCurrentDate)
            .ToList();
        return JvIds;
    }

    public int GetTotalDailyJv(DateTime? selectedDate)
    {
        if (selectedDate is null) return 0;
        var iQ = DbContext.ShokouhPardisDailyJvs
            .Where(x => x.CurrentDate >= selectedDate.Value.Date &&
                                            x.CurrentDate < selectedDate.Value.Date.AddDays(1)
            )
            .AsQueryable();
        return iQ.Count();
    }

    public int GetTotalDailyJv(int studentId, int selectedTermId)
    {
        var iQ = DbContext.ShokouhPardisDailyJvs
            .Where(x =>
                        x.StudentId == studentId &&
                        x.TermId == selectedTermId)
            .AsQueryable();
        return iQ.Count();
    }

    public List<ShokouhPardisDailyJv> GetPagedJvs(int page, int size, DateTime? selDate, string? searchText)
    {
        var queryable = DbContext.ShokouhPardisDailyJvs
            .Include(x => x.Student)
            .Where(x => selDate != null
                        && x.CurrentDate >= selDate.Value.Date
                        && x.CurrentDate < selDate.Value.Date.AddDays(1))
            .AsQueryable();
        if (searchText is not null)
        {
            var parts = searchText.Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                queryable = queryable.Where(x => x.Student != null && (x.Student.StudentName.Contains(part) ||
                                                                       x.Student.StudentFamily.Contains(part) ||
                                                                       (x.PaymentType != null && x.PaymentType.Contains(part)) ||
                                                                       (x.BillNo != null && x.BillNo.ToString()!.Contains(part)) ||
                                                                       x.Fee.ToString().Contains(part) ||
                                                                       (x.FeeFor != null && x.FeeFor.Contains(part)) ||
                                                                       x.Id.ToString().Contains(part) ||
                                                                       (x.Description != null && x.Description.Contains(part))));
                if (int.TryParse(part, out var code))
                {
                    queryable = queryable.Where(x =>
                        !string.IsNullOrEmpty(part) && x.PosCode != null && x.PosCode == code);
                }
            }

        }

        var list = queryable.Skip(page * size).Take(size).ToList();
        return list;
    }

    public List<ShokouhPardisDailyJv> GetPagedJvs(int page, int size, int studentId, int selectedTermId,
        string? searchText)
    {
        var queryable = DbContext.ShokouhPardisDailyJvs
            .Include(x => x.Student)
            .Where(x => x.StudentId == studentId &&
                        x.TermId == selectedTermId)
            .AsQueryable();
        if (searchText is not null)
        {
            var parts = searchText.Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                queryable = queryable.Where(x => x.Student != null && (x.Student.StudentName.Contains(part) ||
                                                                       x.Student.StudentFamily.Contains(part) ||
                                                                       (x.PaymentType != null && x.PaymentType.Contains(part)) ||
                                                                       (x.BillNo != null && x.BillNo.ToString()!.Contains(part)) ||
                                                                       x.Fee.ToString().Contains(part) ||
                                                                       (x.FeeFor != null && x.FeeFor.Contains(part)) ||
                                                                       x.Id.ToString().Contains(part) ||
                                                                       (x.Description != null && x.Description.Contains(part))));
                if (int.TryParse(part, out var code))
                {
                    queryable = queryable.Where(x =>
                        !string.IsNullOrEmpty(part) &&
                        x.PosCode != null &&
                        x.PosCode == code);
                }

            }

        }


        var list = queryable.Skip(page * size).Take(size).ToList();
        return list;
    }

    public ShokouhPardisStudentClassOnlineForm? GetOnlineStudentByGuid(Guid studentGuid)
    {
        var student =
            DbContext.ShokouhPardisStudentClassOnlineForms.FirstOrDefault(x => x.StudentClassGuid == studentGuid);
        return student;
    }

    public ShokouhPardisFileAttachment SaveAttachment(byte[] bytes, Guid attachmentGuid, string folder,
        string fileName, string contentType)
    {
        var extension = Path.GetExtension(fileName);
        var base64String = Convert.ToBase64String(bytes);
        var imageDataURL = $"data:image/{extension.Replace(".", null)};base64,{base64String}";

        var attachment = new ShokouhPardisFileAttachment
        {
            Folder = folder,
            Guid = attachmentGuid,
            FileContent = bytes,
            FileName = fileName,
            ContentType = contentType,
            DataUrl = imageDataURL,
            LastModified = DateTime.Now
        };

        var entityEntry = DbContext.ShokouhPardisFileAttachments.Add(attachment);
        DbContext.SaveChanges();
        return attachment;
    }

    public bool DeleteAttachment(ShokouhPardisFileAttachment? attachment)
    {
        if (attachment is null)
            return false;

        DbContext.ShokouhPardisFileAttachments.Remove(attachment);
        DbContext.SaveChanges();

        return true;
    }

    public void SaveJvfromSite(ShokouhPardisJvfromSite jvfromSite)
    {
        DbContext.ShokouhPardisJvfromSites.Update(jvfromSite);
        DbContext.SaveChanges();
    }

    public ShokouhPardisJvfromSite? GetSiteJvByGuid(string? sguid)
    {
        if (Guid.TryParse(sguid, out var guid))
        {
            var jvFromSite = DbContext.ShokouhPardisJvfromSites
                .Include(x => x.FileAttachment)
                .FirstOrDefault(x => x.DailyJvguid == guid);
            return jvFromSite;
        }

        return null;
    }

    public ShokouhPardisStudentClassOnlineForm? StudentExistInOnlineForm(string? stuNationalId)
    {
        var student =
            DbContext.ShokouhPardisStudentClassOnlineForms.FirstOrDefault(x => x.StudentIdno == stuNationalId);
        return student;
    }

    public ShokouhPardisStudentClass? GetStudentClassByGuid(Guid? studentGuid)
    {
        var studentClass =
            DbContext.ShokouhPardisStudentClasses.FirstOrDefault(x => x.StudentClassGuid == studentGuid);
        return studentClass;
    }

    public ShokouhPardisTimeTable? GetStudentTermClass(int stuId, int termId)
    {
        var tts = DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .FirstOrDefault(x => x.StudentId == stuId && x.TimeTable.TermId == termId);
        if (tts == null) return null;
        var timeTable = DbContext.ShokouhPardisTimeTables
            .Include(x => x.Term)
            .Include(x => x.ClassRoom)
            .Include(x => x.Level)
            .Include(x => x.Schedule)
            .Include(x => x.Teacher)
            .First(x => x.Id == tts.TimeTableId);
        return timeTable;
    }


    IQueryable<ShokouhPardisJvfromSite> GetAllSiteJvQuery(string? search)
    {
        var data = DbContext.ShokouhPardisJvfromSites.AsQueryable();
        if (!search.IsEmpty())
            data = data.Where(x => x.StudentName.Contains(search) ||
                                   x.StudentFamil.Contains(search) ||
                                   x.StudentIdNumber.Contains(search) ||
                                   x.CardPostfix.Contains(search) ||
                                   x.PhoneNumber.Contains(search));
        return data.OrderBy(x => x.Id);
    }

    public List<ShokouhPardisJvfromSite> GetAllSiteJv(string? search)
    {
        var data = GetAllSiteJvQuery(search);
        return data.ToList();
    }

    public int GetAllSiteJvCount(string? search)
    {
        var data = GetAllSiteJvQuery(search);
        return data.Count();
    }

    public List<ShokouhPardisJvfromSite> GetPagedAllSiteJv(string? search, int page, int pageSize)
    {
        var data = GetAllSiteJvQuery(search);
        return data.Skip(page * pageSize).Take(pageSize).ToList();
    }


    public List<ShokouhPardisJvfromSite> GetApprovedSiteJv(string? search)
    {
        var data = GetAllSiteJvQuery(search);
        data = data.Where(x => x.IsApproved == true);
        return data.ToList();
    }

    public int GetApprovedSiteJvCount(string? search)
    {
        var data = GetAllSiteJvQuery(search);
        data = data.Where(x => x.IsApproved == true);
        return data.Count();
    }

    public List<ShokouhPardisJvfromSite> GetPagedApprovedSiteJv(string? search, int page, int pageSize)
    {
        var data = GetAllSiteJvQuery(search);
        data = data.Where(x => x.IsApproved == true);
        return data.Skip(page * pageSize).Take(pageSize).ToList();
    }

    public List<ShokouhPardisJvfromSite> GetPendingToApproveSiteJv(string? search)
    {
        var data = GetAllSiteJvQuery(search);
        data = data.Where(x => x.IsApproved == null || x.IsApproved == false);
        return data.ToList();
    }

    public int GetPendingToApproveSiteJvCount(string? search)
    {
        var data = GetAllSiteJvQuery(search);
        data = data.Where(x => x.IsApproved == null || x.IsApproved == false);
        return data.Count();
    }

    public List<ShokouhPardisJvfromSite> GetPagedPendingToApproveSiteJv(string? search, int page, int pageSize)
    {
        var data = GetAllSiteJvQuery(search);
        data = data.Where(x => x.IsApproved == null || x.IsApproved == false);
        return data.Skip(page * pageSize).Take(pageSize).ToList();
    }

    public List<ShokouhPardisJvfromSite> GetRequireInvestigateSiteJv(string? search)
    {
        var data = GetAllSiteJvQuery(search);
        data = data.Where(x => x.IsRequiredInvestigation == true);
        return data.ToList();
    }

    public int GetRequireInvestigateSiteJvCount(string? search)
    {
        var data = GetAllSiteJvQuery(search);
        data = data.Where(x => x.IsRequiredInvestigation == true);
        return data.Count();
    }

    public List<ShokouhPardisJvfromSite> GetPagedRequireInvestigateSiteJv(string? search, int page, int pageSize)
    {
        var data = GetAllSiteJvQuery(search);
        data = data.Where(x => x.IsRequiredInvestigation == true);
        return data.Skip(page * pageSize).Take(pageSize).ToList();
    }


    public ShokouhPardisJvfromSite? GetAllSiteJvNext(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;
        var rec = DbContext.ShokouhPardisJvfromSites
            .OrderBy(x => x.Id)
            .FirstOrDefault(x => x.Id > jvfromSite.Id);
        return rec;
    }

    public ShokouhPardisJvfromSite? GetAllSiteJvPrev(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;
        var rec = DbContext.ShokouhPardisJvfromSites
            .OrderBy(x => x.Id)
            .FirstOrDefault(x => x.Id < jvfromSite.Id);
        return rec;
    }

    public ShokouhPardisJvfromSite? GetApprovedSiteJvNext(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbContext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.Id)

                .FirstOrDefault(x => x.IsApproved == true && x.Id > jvfromSite.Id)
            ;
        return rec;
    }

    public ShokouhPardisJvfromSite? GetApprovedSiteJvPrev(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbContext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.Id)

                .FirstOrDefault(x => x.IsApproved == true && x.Id < jvfromSite.Id)
            ;
        return rec;
    }

    public ShokouhPardisJvfromSite? GetPendingToApproveSiteJvNext(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbContext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.Id)

                .FirstOrDefault(x => x.IsApproved == null && x.Id > jvfromSite.Id)
            ;
        return rec;
    }

    public ShokouhPardisJvfromSite? GetPendingToApproveSiteJvPrev(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbContext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.Id)

                .FirstOrDefault(x => x.IsApproved == null && x.Id < jvfromSite.Id)
            ;
        return rec;
    }

    public ShokouhPardisJvfromSite? GetRequireInvestigateSiteJvNext(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbContext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.Id)

                .FirstOrDefault(x => x.IsRequiredInvestigation == true && x.Id > jvfromSite.Id)
            ;
        return rec;

    }

    public ShokouhPardisJvfromSite? GetRequireInvestigateSiteJvPrev(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbContext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.Id)

                .FirstOrDefault(x => x.IsRequiredInvestigation == true && x.Id < jvfromSite.Id)
            ;
        return rec;

    }

    public List<ShokouhPardisTeacherClass> GetTeachers()
    {
        return DbContext.ShokouhPardisTeacherClasses.ToList();
    }

    public HashSet<ShokouhPardisTeacherClass> GetTeachersInTerm(ShokouhPardisTermClass term)
    {
        var set = DbContext.ShokouhPardisTeacherTermClasses
            .Include(x => x.Teacher)
            .Where(x => x.TermFk == term.Id)
            .Select(x => x.Teacher)
            .ToHashSet();
        return set;
    }

    public bool IsAnyTeachersInTerm(ShokouhPardisTermClass term)
    {
        var set = DbContext.ShokouhPardisTeacherTermClasses
                //.Include(x => x.Teacher)
                .Any(x => x.TermFk == term.Id)
            ;
        return set;
    }

    public void RemoveTeacherFromTerm(List<ShokouhPardisTeacherClass> removed,
        ShokouhPardisTermClass term)
    {
        var ids = removed.Select(x => x.Id).ToArray();
        DbContext.RemoveRange(DbContext.ShokouhPardisTeacherTermClasses.Where(x => x.TermFk == term.Id &&
            ids.Contains(x.TeacherFk)));
        DbContext.SaveChanges();
    }

    public IEnumerable<ShokouhPardisTeacherTermClass> AddTeacherToTerm(IEnumerable<ShokouhPardisTeacherClass> added,
        ShokouhPardisTermClass term)
    {
        var ttc = added.Select(teacher => new ShokouhPardisTeacherTermClass
        {
            TeacherFk = teacher.Id,
            TermFk = term.Id,
            Guid = Guid.NewGuid(),
            LastModified = DateTime.Now,
        });
        DbContext.ShokouhPardisTeacherTermClasses.AddRange(ttc);

        DbContext.SaveChanges();
        return ttc;
    }

    public List<ShokouhPardisTimeTable> GetTimeTableSchedule(int termId, bool isPm, bool isPrivate = false)
    {
        var records = DbContext.ShokouhPardisTimeTables
            .Include(x => x.Level)
            .Include(x => x.Teacher)
            .Include(x => x.ClassRoom)

            .Include(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.Interval)

            .Include(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.WeekDay)
            .Where(x => x.TermId == termId
                        && x.IsPrivate == isPrivate);

        records = isPm
            ? records.Where(x => x.Schedule.Programs.Any(p =>
                p.DaySession.Interval.StartTime != null && p.DaySession.Interval.StartTime.Value.Hours > 12))
            : records.Where(x => x.Schedule.Programs.Any(p =>
                p.DaySession.Interval.StartTime != null && p.DaySession.Interval.StartTime.Value.Hours < 12));
        var recs = records.ToList();
        //.Where(x=> 
        //    x.Schedule.Programs.Any(p=>p.DaySession.WeekDay.Title=="شنبه"));

        return recs;
    }

    public IQueryable<ShokouhPardisTimeTable> GetAllTimeTableSchedulesByTermId(int termId)
    {
        var records = DbContext.ShokouhPardisTimeTables
            .Include(x => x.Sessions)

            .Include(x => x.Level)
            .Include(x => x.Teacher)
            .Include(x => x.ClassRoom)

            .Include(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.Interval)

            .Include(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.WeekDay)
            .Where(x => x.TermId == termId);


        return records;
    }

    public Dictionary<int, List<ShokouhPardisTimeTableStudent>>? GetStudentsInTimeTables(ShokouhPardisTermClass? term)
    {
        if (term == null) return null;
        return DbContext.ShokouhPardisTimeTableStudents.Include(x => x.Student)
            .Include(x => x.TimeTable)
            .Where(x => x.TimeTable.TermId == term.Id)
            //.Select(x=>x.Student)
            .ToList()
            .GroupBy(x => x.TimeTableId!)
            .ToDictionary(students => students.Key, students => students.ToList());
    }

    public void SaveData(IEnumerable<object> data)
    {
        foreach (var record in data)
        {
            var entityEntry = DbContext.Add(record);
            DbContext.SaveChanges();

        }
        //DbConntext.AddRange(data);
        //SaveAll();
    }

    public bool IsAnyIntervalsInTerm(ShokouhPardisTermClass toTerm)
    {
        return DbContext.ShokouhPardisIntervals.Any(x => x.TermId == toTerm.Id);
    }

    public bool IsAnyScheduleInTerm(ShokouhPardisTermClass toTerm)
    {
        return DbContext.ShokouhPardisSchedules.Any(x => x.TermFk == toTerm.Id);
    }

    public bool IsAnyDaySessionInTerm(ShokouhPardisTermClass toTerm)
    {
        return DbContext.ShokouhPardisDaySessions.Any(x => x.TermFk == toTerm.Id);
    }

    public List<ShokouhPardisDaySession> GetDaySessions(ShokouhPardisTermClass fromTerm)
    {
        return DbContext.ShokouhPardisDaySessions.Where(x => x.TermFk == fromTerm.Id)
            .Include(w => w.WeekDay)
            .Include(i => i.Interval)
            .ToList();
    }

    public List<ShokouhPardisProgram> GetProgramsForSchedules(List<int> scheduleIds)
    {
        return DbContext.ShokouhPardisPrograms
            .Where(x => scheduleIds.Contains(x.ScheduleId))
            .ToList();
    }

    public bool IsAnyTimeTableInTerm(ShokouhPardisTermClass toTerm)
    {
        return DbContext.ShokouhPardisTimeTables.Any(x => x.TermId == toTerm.Id);
    }

    public List<ShokouhPardisLevelBookPrice> GetTermLevelPrices(ShokouhPardisTermClass term)
    {
        return DbContext.ShokouhPardisLevelBookPrices
            .Include(x => x.Level)
            .Where(x => x.TermId == term.Id)
            .ToList();

    }

    public void AddIntervals(IEnumerable<ShokouhPardisInterval> clonedInterval)
    {
        DbContext.ShokouhPardisIntervals.AddRange(clonedInterval);
        SaveAll();
    }

    public void AddPrograms(IEnumerable<ShokouhPardisProgram> clonedPrograms)
    {
        DbContext.ShokouhPardisPrograms.AddRange(clonedPrograms);
        SaveAll();
    }

    public void SaveSchedules(IEnumerable<ShokouhPardisSchedule> clonedSchedule)
    {
        DbContext.ShokouhPardisSchedules.AddRange(clonedSchedule);
        SaveAll();
    }

    public void SaveDaySessions(IEnumerable<ShokouhPardisDaySession> clonedDaySessions)
    {
        DbContext.ShokouhPardisDaySessions.AddRange(clonedDaySessions);
        SaveAll();
    }

    public void SaveTimeTables(IEnumerable<ShokouhPardisTimeTable> cloneTimeTable)
    {
        DbContext.ShokouhPardisTimeTables.AddRange(cloneTimeTable);
        SaveAll();
    }

    public void SaveStudentsTableTable(IEnumerable<ShokouhPardisTimeTableStudent> timeTableStudents)
    {
        DbContext.ShokouhPardisTimeTableStudents.AddRange(timeTableStudents);
        SaveAll();
    }

    public List<ShokouhPardisLevelBookPrice> GetTermBookPrices(ShokouhPardisTermClass fromTerm)
    {
        return DbContext.ShokouhPardisLevelBookPrices
            .Where(x => x.TermId == fromTerm.Id)
            .ToList();
    }

    public void AddBookPrices(List<ShokouhPardisLevelBookPrice> list)
    {
        DbContext.ShokouhPardisLevelBookPrices.AddRange(list);
        SaveAll();
    }

    public bool SaveEditInterval(ShokouhPardisInterval interval)
    {
        bool isDuplicate = IntervalDuplicate(interval);
        if (isDuplicate)
        {
        }
        else
        {
            DbContext.ShokouhPardisIntervals.Update(interval);
            DbContext.SaveChanges();
        }

        return isDuplicate;
    }

    bool IntervalDuplicate(ShokouhPardisInterval interval)
    {
        var result = DbContext.ShokouhPardisIntervals.Any(x =>
            x.Title == interval.Title &&
            x.TimeInterval == interval.TimeInterval &&
            x.TermId == interval.TermId);
        return result;
    }

    public bool SaveEditDaySession(ShokouhPardisDaySession daySesseion)
    {
        bool isDuplicate = DaySessionDuplicate(daySesseion);
        if (isDuplicate)
        {
        }
        else
        {
            DbContext.ShokouhPardisDaySessions.Update(daySesseion);
            DbContext.SaveChanges();
        }

        return isDuplicate;
    }

    bool DaySessionDuplicate(ShokouhPardisDaySession daySesseion)
    {
        var result = DbContext.ShokouhPardisDaySessions.Any(x =>
            x.WeekDay.Title == daySesseion.WeekDay.Title &&
            x.Interval.Title == daySesseion.Interval.Title &&
            x.TermFk == daySesseion.TermFk);
        return result;
    }


    private List<ShokouhPardisWeekDay>? _weekdays;

    private List<ShokouhPardisWeekDay> Weekdays()
    {
        return _weekdays ??= DbContext.ShokouhPardisWeekDays.ToList();
    }

    public ShokouhPardisWeekDay GetFirstWeekDays()
    {
        return Weekdays().First();
    }

    public ShokouhPardisInterval GetFirstIntervalByTerm(ShokouhPardisTermClass selectedTerm)
    {
        return DbContext.ShokouhPardisIntervals.First(x => x.TermId == selectedTerm.Id);
    }

    public bool SaveEditSchedule(ShokouhPardisSchedule schedule)
    {
        bool isDuplicate = ScheduleDuplicate(schedule);
        if (isDuplicate)
        {
        }
        else
        {
            DbContext.ShokouhPardisSchedules.Update(schedule);
            DbContext.SaveChanges();
        }

        return isDuplicate;
    }

    bool ScheduleDuplicate(ShokouhPardisSchedule schedule)
    {
        var result = DbContext.ShokouhPardisSchedules.Any(x =>
            x.Title == schedule.Title &&
            x.TermFk == schedule.TermFk);

        return result;
    }

    public bool SaveProgram(ShokouhPardisProgram program)
    {
        var isDuplicate = IsProgramDuplicate(program);
        if (isDuplicate)
            return isDuplicate;

        DbContext.ShokouhPardisPrograms.Update(program);
        DbContext.SaveChanges();
        return isDuplicate;
    }

    bool IsProgramDuplicate(ShokouhPardisProgram program)
    {
        var result = DbContext.ShokouhPardisPrograms.Any(x =>
            x.DaySession == program.DaySession);

        return result;
    }

    public void DeleteProgram(ShokouhPardisProgram prog)
    {
        DbContext.ShokouhPardisPrograms.Remove(prog);
        DbContext.SaveChanges();
    }

    public void UpdateEditLevelBookPrice(ShokouhPardisLevelBookPrice levelBookPrice,
        ShokouhPardisTermClass selectedTerm)
    {
        DbContext.ShokouhPardisLevelBookPrices.Update(levelBookPrice);
        DbContext.SaveChanges();
    }

    public bool SaveEditLevelBookPrice(ShokouhPardisLevelBookPrice levelBookPrice,
        ShokouhPardisTermClass selectedTerm)
    {
        var isDuplicate = IsLevelBookPriceDuplicate(levelBookPrice, selectedTerm);
        if (isDuplicate)
            return isDuplicate;

        DbContext.ShokouhPardisLevelBookPrices.Update(levelBookPrice);
        DbContext.SaveChanges();
        return isDuplicate;
    }

    bool IsLevelBookPriceDuplicate(ShokouhPardisLevelBookPrice levelBookPrice,
        ShokouhPardisTermClass selectedTerm)
    {
        var result = DbContext.ShokouhPardisLevelBookPrices.Any(x =>
            x.LevelId == levelBookPrice.LevelId &&
            x.TermId == selectedTerm.Id);

        return result;
    }

    public Dictionary<ShokouhPardisLevelClass, int> GetTimeTableLevelChartData(ShokouhPardisTermClass selectedTerm)
    {
        return DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)
            //.Include(x=>x.Student)
            .Where(x => x.TimeTable.TermId == selectedTerm.Id)
            .ToList()
            .GroupBy(x => x.TimeTable.Level)
            .Select(group => new
            {
                g = group.Key,
                studentsEnumerator = group.Count()
            })

            .ToDictionary(k => k.g, x => x.studentsEnumerator);

        ;
    }

    public void SaveEditDailyJV(ShokouhPardisDailyJv dailyJv)
    {
        if (dailyJv.Id == 0)
        {
            bool isDuplicate = DailyJVDuplicate(dailyJv);
            if (isDuplicate)
            {
                throw new Exception("Duplicated daily JV record");
            }
        }

        DbContext.ShokouhPardisDailyJvs.Update(dailyJv);
        DbContext.SaveChanges();
    }

    bool DailyJVDuplicate(ShokouhPardisDailyJv dailyJv)
    {
        var result = DbContext.ShokouhPardisDailyJvs.Any(x =>
            x.Fee == dailyJv.Fee &&
            x.StudentId == dailyJv.StudentId &&
            x.FeeFor == dailyJv.FeeFor &&
            x.PaymentType == dailyJv.PaymentType &&
            x.TermId == dailyJv.TermId &&
            x.BillNo == dailyJv.BillNo);
        return result;
    }




    public IQueryable<ShokouhPardisTimeTableStudent> GetStudentByTerm(int termId)
    {
        //var studentList = new List<ShokouhPardisStudentClass>();
        var students = DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .Include(x => x.Student)

            .Where(x =>
                x.TimeTable.TermId == termId);

        return students;
    }

    public List<ShokouhPardisDailyJv> GetDailyJvBy(int termId, int studentId)
    {
        var dailyJvs = DbContext.ShokouhPardisDailyJvs
            .Where(x => x.TermId == termId &&
                        x.StudentId == studentId)
            .ToList();
        return dailyJvs;
    }


    public bool DeleteDailyJV(ShokouhPardisDailyJv dailyJv)
    {
        var pr = DbContext.PreRegistrations.FirstOrDefault(
            x => x.DailyJVFk == dailyJv.Id);

        if (pr is null)
        {

            DbContext.ShokouhPardisDailyJvs.Remove(dailyJv);
            DbContext.SaveChanges();
            return false;
        }
        else
        {
            DbContext.PreRegistrations.Remove(pr);
            DbContext.ShokouhPardisDailyJvs.Remove(dailyJv);
            DbContext.SaveChanges();
            return true;
        }

    }

    public List<ShokouhPardisDailyJv> GetDailyJvsByTerm(int termId)
    {
        return DbContext.ShokouhPardisDailyJvs.Where(x => x.TermId == termId).ToList();
    }

    public List<ShokouhPardisDailyJv> GetDailyJvsByTimeTable(ShokouhPardisTimeTable timeTable,
        ShokouhPardisStudentClass student)
    {
        return DbContext.ShokouhPardisDailyJvs.Where(x => x.TermId == timeTable.TermId
                                                           && x.TimeTableFk == timeTable.Id
                                                           && x.StudentId == student.Id).ToList();
    }


    public List<User> GetUsers()
    {
        return DbContext.Users.Include(x => x.Roles).ToList();
    }

    public void SaveUser(User user)
    {
        DbContext.Users.Update(user);
        DbContext.SaveChanges();
    }

    public List<Role> GetRoles()
    {
        return DbContext.Roles
            .Include(x => x.Permissions)
            .ToList();
    }

    public void SaveRole(Role role)
    {
        DbContext.Roles.Update(role);
        DbContext.SaveChanges();
    }

    public List<Permission> GetPermissions()
    {
        var permissions = DbContext.Permissions.Include(x => x.Roles).ToList();
        return permissions;
    }

    public void SavePermission(Permission permission)
    {
        DbContext.Permissions.Update(permission);
        DbContext.SaveChanges();
    }

    public User? GetUserByUserName(string? userName)
    {
        if (userName.IsEmpty()) return null;
        return DbContext
            .Users
            .Include(x => x.Roles)
            .FirstOrDefault(x => x.UserName == userName);
    }

    public User GetUserByUseId(int userId)
    {
        return DbContext.Users.First(x => x.Id == userId);
    }
    public List<User> GetUsersInRole(Role? role = null)
    {
        if (role is null)
            return DbContext.Users.ToList();

        return DbContext.Users
            .Include(x => x.Roles)
            .Where(x => x.Roles.Contains(role))
            .ToList();
    }

    public Role? GetRoleByName(string roleName)
    {
        var firstOrDefault = DbContext.Roles.FirstOrDefault(x => x.Name == roleName);
        return firstOrDefault;
    }


    public User? CheckUserLogin(string userName, string password)
    {
        // Log.Information("THIS IS SAMPLE of CHECKING USER LOG");
        var firstOrDefault = DbContext.Users
            .Include(x => x.Roles)
            .FirstOrDefault(x => x.UserName == userName && x.Password == password);
        return firstOrDefault;
    }

    public List<TimeTableSession> GetTimeTableSessions(ShokouhPardisTimeTable timeTable)
    {
        var sessions = DbContext.TimeTableSessions
            .Include(x => x.ClassRoom)
            .Include(x => x.Teacher)
            .Include(x => x.TimeTable)
            .Include(x => x.ReplacementSession)
            .Where(x => x.TimeTableFk == timeTable.Id)
            .OrderBy(x => x.SessionDate)
            .ToList();
        return sessions;
    }

    public int GetTimeTableSessionsCount(ShokouhPardisTimeTable timeTable)
    {
        var sessions = DbContext.TimeTableSessions
            .Count(x => x.TimeTableFk == timeTable.Id && x.SessionNumber > 0);
        return sessions;
    }

    public Dictionary<int, int> GetTimeTableSessionsCountByTermId(int termId)
    {
        var sessions = DbContext.TimeTableSessions
            .Include(x => x.TimeTable)
            .Where(x => x.SessionNumber > 0 && x.TimeTable.TermId == termId)
            .GroupBy(g => g.TimeTableFk)
            .Select(x => new
            {
                TimetableFk = x.Key,
                Count = x.Count()
            })
            .ToDictionary(x => x.TimetableFk, y => y.Count);
        return sessions;
    }

    public List<TermSessionTemplate> GetTermTemplates(ShokouhPardisTermClass term)
    {
        return DbContext.TermSessionTemplates
            .Include(x => x.Term)
            .Where(x => x.TermFk == term.Id)
            .ToList();
    }

    public void SaveTermSessionTemplate(TermSessionTemplate tst)
    {
        if (tst.Id == 0)
            DbContext.TermSessionTemplates.Add(tst);
        else
            DbContext.TermSessionTemplates.Update(tst);

        DbContext.SaveChanges();
    }

    public List<TermSessionTemplateDate> GetTermSessionTemplateDates(TermSessionTemplate tst)
    {
        return DbContext.TermSessionTemplateDates
            .Where(x => x.TermSessionTemplateFk == tst.Id)
            .ToList();
    }

    public int GetTermSessionTemplateDateCount(TermSessionTemplate tst)
    {
        return DbContext.TermSessionTemplateDates
            .Count(x => x.TermSessionTemplateFk == tst.Id);

    }

    public void SaveTermSessionTemplateDate(TermSessionTemplateDate tstd)
    {

        DbContext.TermSessionTemplateDates.Update(tstd);
        DbContext.SaveChanges();
    }

    public void DeleteTermSessionTemplateDate(TermSessionTemplateDate context)
    {
        DbContext.TermSessionTemplateDates.Remove(context);
        DbContext.SaveChanges();
    }

    public void DeleteTermSessionTemplate(TermSessionTemplate context)
    {
        DbContext.TermSessionTemplates.Remove(context);
        DbContext.SaveChanges();

    }

    public void DeleteTermSessionTemplateDates(TermSessionTemplate context)
    {
        var dates = DbContext.TermSessionTemplateDates.Where(x =>
            x.TermSessionTemplateFk == context.Id);
        DbContext.RemoveRange(dates);
        DbContext.SaveChanges();
    }

    public LessonPlan? GetLessonPlan(int sessionNumber, int levelId)
    {
        return DbContext.LessonPlans.
            Include(x => x.Sections)
            .ThenInclude(x => x.Items)
            .Include(x => x.Sections)
            .ThenInclude(x => x.SectionType)
            .FirstOrDefault(x => x.SessionNumber == sessionNumber && x.LevelFk == levelId);
    }
    public List<LessonPlan> GetLessonPlan(int levelID)
    {
        return DbContext.LessonPlans
            .Where(x => x.LevelFk == levelID)
            .ToList();
    }

    public TimeTableSession SaveTimeTableSession(TimeTableSession timeTableSession)
    {
        var entityEntry = DbContext.TimeTableSessions.Update(timeTableSession);

        DbContext.SaveChanges();

        return entityEntry.Entity;
    }

    public void UpdateTimeTableSessions(IOrderedEnumerable<TimeTableSession> allSessions)
    {
        DbContext.UpdateRange(allSessions);
        DbContext.SaveChanges();
    }

    public TermSessionTemplate? GetTermTemplateByWeekdayIds(ShokouhPardisTermClass? term,
        string weekdayIds)
    {
        var termSessionTemplates = DbContext.TermSessionTemplates
            .SingleOrDefault(x => x.TermFk == term.Id && x.WeekdayIds == weekdayIds);
        return termSessionTemplates;
    }

    public List<SessionActivity> GetSessionActivities()
    {
        var sessionActivities = DbContext.SessionActivities
            .Include(x => x.ValueOptions)
            .ToList();
        return sessionActivities;
    }

    public void SaveSessionActivity(SessionActivity sessionActivity)
    {
        var entityEntry = DbContext.SessionActivities.Update(sessionActivity);
        DbContext.SaveChanges();
    }

    public ShokouhPardisInterval? GetInterval(ShokouhPardisTermClass term, TimeSpan time, TimeSpan offset)
    {
        //throw new NotImplementedException();
        var interval = DbContext.ShokouhPardisIntervals.FirstOrDefault(x =>
            x.TermId == term.Id && time >= x.StartTime && time <= x.EndTime);
        return interval;
    }

    public ShokouhPardisTeacherClass? GetTeacherByUserId(int? userId)
    {
        var teacher = DbContext.ShokouhPardisTeacherClasses.SingleOrDefault(x => x.UserId == userId);
        return teacher;
    }

    public ShokouhPardisWeekDay GetTodayWeekday(int? test_dayofweek = null)
    {
        var dayOfWeek = (int)DateTime.Today.DayOfWeek;
        if (test_dayofweek is not null)
        {
            dayOfWeek = test_dayofweek.Value;
        }
        var pwdId = (dayOfWeek + 1) % 7 + 1;

        var weekDay = Weekdays().First(x => x.Id == pwdId);
        return weekDay;
    }

    public ShokouhPardisTimeTable? GetTeacherTimeTable(int termId,
	    int teacherId,
	    int weekdayId,
	    int intervalId)
    {
	    var tt = DbContext
		    .ShokouhPardisTimeTables
		    .Include(x => x.Schedule)
		    .ThenInclude(x => x.Programs)
		    .ThenInclude(x => x.DaySession)
		    .ThenInclude(x => x.Interval)
		    .FirstOrDefault(x =>
			    x.TermId == termId &&
			    x.TeacherId == teacherId &&
			    x.Schedule.Programs.Any(p => p.DaySession.IntervalId == intervalId &&
			                                 p.DaySession.WeekdayId == weekdayId));
	    return tt;

	}

	public ShokouhPardisTimeTable? GetTeacherTimeTable(ShokouhPardisTermClass term,
        ShokouhPardisTeacherClass teacher,
        ShokouhPardisWeekDay weekday,
        ShokouhPardisInterval interval)
    {
        return GetTeacherTimeTable(term.Id, teacher.Id, weekday.Id, interval.Id);

	}

    public TimeTableSession GetTimeTableSession(int sessionId)
    {
        var timeTableSession = DbContext.TimeTableSessions
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Teacher)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.ClassRoom)
            .FirstOrDefault(x => x.Id == sessionId);
        return timeTableSession!;
    }

    public TimeTableSession? GetTimeTableSession(ShokouhPardisTimeTable? timetable, DateTime dateTime)
    {
        if (timetable == null) return null;

        var session = DbContext.TimeTableSessions
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Teacher)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.ClassRoom)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Schedule)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Sessions)

            .FirstOrDefault(x =>
                x.TimeTableFk == timetable.Id && x.SessionDate == dateTime);
        return session;
    }

    public List<SessionActivity> GetSessionActivities(TimeTableSession session)
    {
        var sessionActivitiesQuery = DbContext
            .SessionActivities
            .Include(x => x.ValueOptions)
            .Where(x =>

                (x.SessionNo == null && x.Levels == null && x.LevelGroups == null) ||


                // TODO: It should be joined criteria

                (x.SessionNo != null && x.SessionNo == session.SessionNumber) ||
                (x.Levels != null && x.Levels.Contains(session.TimeTable.Level.LevelName)) ||
                (x.LevelGroups != null && x.LevelGroups.Contains(session.TimeTable.Level.Grouping!))

            );

        return sessionActivitiesQuery.ToList();

    }

    public void SaveStudentActivity(StudentSessionActivity activity)
    {
        DbContext.StudentSessionActivities.Update(activity);
        DbContext.SaveChanges();
    }

    public Dictionary<int, List<StudentSessionActivity>> GetStudentsSessionActivities(TimeTableSession session)
    {
        var activities = DbContext
                .StudentSessionActivities
                .Where(x => x.TimeTableSessionFk == session.Id)
                .ToList()
                .GroupBy(g => g.StudentFk)
                .ToDictionary(x => x.Key, y => y.ToList())
            ;
        return activities;
    }

    public void SaveValueOption(SessionActivityValueOption valueOption)
    {
        DbContext.SessionActivityValueOptions.Update(valueOption);
        DbContext.SaveChanges();
    }

    public SessionActivity GetSessionActivity(int sessionActivityId)
    {
        var sessionActivity = DbContext.SessionActivities
            .Include(x => x.ValueOptions)
            .First(x => x.Id == sessionActivityId);
        return sessionActivity;
    }

    public void DeleteSessionActivityValueOption(SessionActivityValueOption vo)
    {
        var sessionActivity = DbContext.SessionActivityValueOptions.Remove(vo);
        DbContext.SaveChanges();


    }

    public ShokouhPardisTimeTable FindStudentLastTimeTable(ShokouhPardisStudentClass student)
    {
        var tts = DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Term)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Teacher)
            .Include(x => x.Student)
            .OrderByDescending(x => x.Id)
            .FirstOrDefault(x => x.Student.Id == student.Id);
        if (tts != null) return tts.TimeTable;
        return null;


    }

    public ShokouhPardisLevelClass FindNextLevel(ShokouhPardisTimeTable findStudentLastTimeTable)
    {
        var FindLevel =
            DbContext.ShokouhPardisLevelClasses.First(x =>
                x.Id == findStudentLastTimeTable.Level.Id);

        return DbContext.ShokouhPardisLevelClasses.First(x => x.Id == FindLevel.NextLevelFk);

    }

    public ShokouhPardisTermClass? GetNextTerm()
    {
        IQueryable<ShokouhPardisTermClass?> term = DbContext.ShokouhPardisTermClasses.AsQueryable();
        var currentTerm = term.FirstOrDefault(x => x.StartDate <= DateTime.Today &&
                                                   x.EndDate >= DateTime.Today);
        return term.FirstOrDefault(x => currentTerm != null && x.StartDate >= currentTerm.EndDate);
    }

    public bool SavePreRegistration(PreRegistration preRegistration)
    {
        var isDuplicate = PreRegistrationDuplicate(preRegistration);
        if (isDuplicate)
            return isDuplicate;
        DbContext.PreRegistrations.Update(preRegistration);
        DbContext.SaveChanges();
        return isDuplicate;
    }

    bool PreRegistrationDuplicate(PreRegistration preRegistration)
    {

        var result = DbContext.PreRegistrations.Any(x =>
            x.LevelFk == preRegistration.LevelFk &&
            x.DailyJVFk == preRegistration.DailyJVFk &&
            x.StudentFk == preRegistration.StudentFk &&
            x.TermFk == preRegistration.TermFk);
        return result;
    }

    public PreRegistration GetPreRegistrationByJv(int dalyJvid)
    {
        var registration = DbContext.PreRegistrations
            .Include(x => x.Term)
            .Include(x => x.Level)
            .FirstOrDefault(x => x.DailyJVFk == dalyJvid);
        return registration;
    }

    public bool SaveEditlessonPlan(LessonPlan lessonPlan)
    {
        bool isDuplicate = LessonPlanDuplicate(lessonPlan);
        if (isDuplicate)
        {
        }
        else
        {
            DbContext.LessonPlans.Update(lessonPlan);
            DbContext.SaveChanges();
        }

        return isDuplicate;
    }

    bool LessonPlanDuplicate(LessonPlan lessonPlan)
    {
        var result = DbContext.LessonPlans.Any(x =>
            x.LevelFk == lessonPlan.LevelFk &&
            x.SessionNumber == lessonPlan.SessionNumber);
        return result;
    }

    public int GetLessonPlanSessionNo(ShokouhPardisLevelClass level)
    {
        var lastSessionNumberLessonPlan = DbContext.LessonPlans
            .Where(x => x.LevelFk == level.Id)
            .OrderByDescending(x => x.SessionNumber).FirstOrDefault();
        if (lastSessionNumberLessonPlan is null)
        {
            return 1;
        }
        else
        {
            var sessionNumber = (int)lastSessionNumberLessonPlan.SessionNumber;
            return sessionNumber + 1;
        }


    }

    public void ArchivePreRegister(List<ShokouhPardisStudentClass> selectedStudents)
    {
        var studentIds = selectedStudents.Select(x => x.Id).ToArray();

        var registrations = DbContext.PreRegistrations
            .Where(x => studentIds.Contains(x.StudentFk)).ToList();
        registrations.ForEach(x => x.IsArchive = true);
        DbContext.PreRegistrations.UpdateRange(registrations);
        DbContext.SaveChanges();

    }

    public void DailyJvAssignToTimeTable(ShokouhPardisTimeTable tt, List<ShokouhPardisStudentClass> selectedStudents)
    {
        var studentsIds = selectedStudents.Select(x => x.Id).ToArray();
        var preRegistrations = DbContext.PreRegistrations.Where(x => studentsIds.Contains(x.StudentFk)).ToList();
        var dailyJvIds = preRegistrations.Select(x => x.DailyJVFk).ToArray();
        var shokouhPardisDailyJvs = DbContext.ShokouhPardisDailyJvs.Where(x => dailyJvIds.Contains(x.Id)).ToArray();
        foreach (var x in shokouhPardisDailyJvs)
        {
            x.TimeTableFk = tt.Id;
        }
        DbContext.UpdateRange(shokouhPardisDailyJvs);
        DbContext.SaveChanges();
    }

    public void SetActivityDeleteTime(StudentSessionActivity sac)
    {
        sac.ActivityDeletedDateTime = DateTime.Now;
        DbContext.Update(sac);
        DbContext.SaveChanges();
    }

    public List<LessonPlanSection>? GetLessonPlanSection(LessonPlan lessonPlan)
    {
        if (lessonPlan is null)
            return null;
        return DbContext.LessonPlanSections
            .Include(x => x.SectionType)
            .Where(
            x => x.LessonPlanFk == lessonPlan.Id).ToList();
    }

    public List<LessonPlanSectionItem> GetLessonPlanSectionItems(LessonPlanSection section)
    {
        return DbContext.LessonPlanSectionItems.Where(
            x => x.LessonPlanSectionFk == section.Id)
            .OrderBy(x => x.Order)
            .ToList();
    }

    public void SaveSectionItem(LessonPlanSectionItem lessonPlanSectionItem)
    {
        DbContext.LessonPlanSectionItems.Update(lessonPlanSectionItem);
        DbContext.SaveChanges();
    }

    public ShokouhPardisTermClass GetTermsbyTermId(int i)
    {
        return DbContext.ShokouhPardisTermClasses
            .FirstOrDefault(x => x.Id == i);
    }

    public List<ShokouhPardisLevelClass> GetlevelBookNOPriceList(ShokouhPardisTermClass term)
    {
        return DbContext.ShokouhPardisLevelClasses
            .Where(level => !DbContext.ShokouhPardisLevelBookPrices.Any(price => price.LevelId == level.Id & price.TermId == term.Id))
            .ToList();

    }

    public List<ChartSeries> GetDailyJvSeriesPaymentType(DateTime dateFrom, DateTime dateTo)
    {

        var paymentSummaries = DbContext.ShokouhPardisDailyJvs
        .Where(p => p.CurrentDate >= dateFrom && p.CurrentDate <= dateTo)
        .GroupBy(p => new { p.CurrentDate, p.PaymentType })
        .Select(g => new PaymentSummary
        {
            Day = g.Key.CurrentDate,
            PaymentType = g.Key.PaymentType,
            TotalFee = g.Sum(p => p.Fee)
        })
        .ToList();

        var uniquePaymentTypes = paymentSummaries.Select(p => p.PaymentType).Distinct().ToList();

        var chartSeriesList = new List<ChartSeries>();

        foreach (var paymentType in uniquePaymentTypes)
        {
            var chartSeries = new ChartSeries
            {
                Name = paymentType,
                Data = new double[] { }
            };

            var paymentTypeData = paymentSummaries
                .Where(p => p.PaymentType == paymentType)
                .OrderBy(p => p.Day)
                .ToList();
            var x = new List<double>();
            foreach (var date in Enumerable.Range(0, (dateTo - dateFrom).Days + 1).Select(d => dateFrom.AddDays(d)))
            {
                var totalFee = paymentTypeData.FirstOrDefault(p => p.Day == date)?.TotalFee ?? 0;
                x.Add(totalFee);
            }
            chartSeries.Data = x.ToArray();

            chartSeriesList.Add(chartSeries);
        }

        return chartSeriesList;
    }
    public List<ChartSeries> GetDailyJvSeriesFeeFor(DateTime dateFrom, DateTime dateTo)
    {

        List<PaymentSummary> paymentSummaries = DbContext.ShokouhPardisDailyJvs
            .Where(p => p.CurrentDate >= dateFrom && p.CurrentDate <= dateTo)
            .GroupBy(p => new { p.CurrentDate, p.FeeFor })
            .Select(g => new PaymentSummary
            {
                Day = g.Key.CurrentDate,
                FeeFor = g.Key.FeeFor,
                TotalFee = g.Sum(p => p.Fee)
            })
            .ToList();
        List<string> uniqueFeeForTypes = paymentSummaries.Select(p => p.FeeFor).Distinct().ToList();

        var chartSeriesList = new List<ChartSeries>();

        foreach (var feeForType in uniqueFeeForTypes)
        {
            var chartSeries = new ChartSeries
            {
                Name = feeForType,
                Data = new double[] { }
            };

            var paymentTypeData = paymentSummaries
                .Where(p => p.FeeFor == feeForType)
                .OrderBy(p => p.Day)
                .ToList();
            var x = new List<double>();
            foreach (var date in Enumerable.Range(0, (dateTo - dateFrom).Days + 1).Select(d => dateFrom.AddDays(d)))
            {
                var totalFee = paymentTypeData.FirstOrDefault(p => p.Day == date)?.TotalFee ?? 0;
                x.Add(totalFee);
            }
            chartSeries.Data = x.ToArray();

            chartSeriesList.Add(chartSeries);
        }

        return chartSeriesList;
    }

    public List<ShokouhPardisTimeTable> GetStudentHistory(ShokouhPardisStudentClass student)
    {
        return DbContext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Term)
            .ThenInclude(x => x.Year)
            .ThenInclude(x => x.Terms)

            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.Interval)

            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.WeekDay)

            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)

            .Include(x => x.TimeTable)
            .ThenInclude(x => x.ClassRoom)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Teacher)

            .Where(x => x.StudentId == student.Id)
            .Select(x => x.TimeTable).ToList();
    }

    public void StudentMove(ShokouhPardisTimeTable timeTableOrig, ShokouhPardisTimeTable TimeTabelNew, ShokouhPardisStudentClass student)
    {
        //add New
        var FindTimeTableStudent = DbContext.ShokouhPardisTimeTableStudents.FirstOrDefault(x => x.TimeTableId == timeTableOrig.Id &&
            x.StudentId == student.Id);
        if (FindTimeTableStudent != null)
        {
            FindTimeTableStudent.TimeTableId = TimeTabelNew.Id;
            DbContext.Update(FindTimeTableStudent);
            DbContext.SaveChanges();
        }

    }

    public void RegisterAdvanceUser(AdvanceRegistration advanceRegistration)
    {

        DbContext.AdvanceRegistrations.Add(advanceRegistration);
        DbContext.SaveChanges();

    }

    public void InactiveUser(string userName)
    {
        var user = DbContext.Users.FirstOrDefault(x => x.UserName == userName);
        if (user is null) return;

        user.IsActive = false;
        DbContext.SaveChanges();
    }

    public TimeTableSession GetSession(int sessionId)
    {
        return DbContext.TimeTableSessions
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Term)
            .ThenInclude(x => x.Year)
            .ThenInclude(x => x.Terms)

            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.Interval)

            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.WeekDay)

            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)

            .Include(x => x.TimeTable)
            .ThenInclude(x => x.ClassRoom)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Teacher)

            .FirstOrDefault(x => x.Id == sessionId);
    }

    public IEnumerable<ShokouhPardisTeacherClass> GetTeachersInInterval(int termId,int wdId, int intervalId)
    {
	    var list = DbContext.ShokouhPardisTeacherTimeSheets
		    .Include(x=>x.Teacher)
		    .Where(x => 
			    x.TermId == termId &&
			    x.WeekDayId == wdId &&
			    x.IntervalId == intervalId)
		    .Select(x=>x.Teacher)
		    .ToList();

	    return list;
    }
}

