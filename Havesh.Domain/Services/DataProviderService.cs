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

namespace HaveshApp.Services;

public class DataProviderService
{
    public MyDbContext DbConntext { get; }


    public DataProviderService(MyDbContext dbConntext)
    {
        DbConntext = dbConntext;
    }

    public List<ShokouhPardisYearClass> GetYears()
    {
        return DbConntext.ShokouhPardisYearClasses.Include(x => x.Terms).ToList();
    }

    public List<ShokouhPardisTermClass> GetTerms(ShokouhPardisYearClass year)
    {
        return DbConntext.ShokouhPardisTermClasses.Where(x => x.YearId == year.YearClassId).ToList();
    }


    public List<ShokouhPardisSchedule> GetSchedules(ShokouhPardisTermClass term)
    {
        var schedule = DbConntext.ShokouhPardisSchedules
            .Include(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.Interval)

            .Include(x => x.Programs)
            .ThenInclude(x => x.DaySession)
            .ThenInclude(x => x.WeekDay)

            .Where(x => x.TermFk == term.TermClassId)
            .ToList();
        return schedule;
    }

    public List<ShokouhPardisTeacherClass> GetTeacherByAny(string search,
        ShokouhPardisTermClass? term)
    {
        var relatedTeachers = DbConntext
            .ShokouhPardisTeacherTermClasses
            .Include(x => x.Teacher)
            .Where(x => (term != null && x.TermFk == term.TermClassId) &&
                        (x.Teacher.TeacherName.Contains(search) || x.Teacher.TeacherFamily.Contains(search))
            )
            .Select(x => x.Teacher)
            .ToList();

        return relatedTeachers;
    }

    public List<ShokouhPardisTeacherClass> GetTeacher()
    {
        List<ShokouhPardisTeacherClass> Teachers;
        Teachers = DbConntext.ShokouhPardisTeacherClasses.ToList();
        return Teachers;
    }

    public bool SaveTeacherTimeTable(ShokouhPardisTimeTable teacherTimesheet)
    {
        var title =
            $"{teacherTimesheet.Teacher} -> {teacherTimesheet.Term.Year.YearName} -> {teacherTimesheet.Term.TermName} -> {teacherTimesheet.Schedule.Title}";
        teacherTimesheet.Title = title;
        var isDuplicate = teacherTimesheet.TimeTableId == 0 && TimeTableDuplicate(teacherTimesheet);
        if (isDuplicate)
            return isDuplicate;

        DbConntext.ShokouhPardisTimeTables.Update(teacherTimesheet);
        DbConntext.SaveChanges();
        return isDuplicate;
    }

    bool TimeTableDuplicate(ShokouhPardisTimeTable teacherTimesheet)
    {
        var result = DbConntext.ShokouhPardisTimeTables.Any(x =>
            x.TermId == teacherTimesheet.Term.TermClassId &&
            x.ScheduleId == teacherTimesheet.Schedule.ScheduleId &&
            x.TeacherId == teacherTimesheet.Teacher.TeacherClassId);
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
            DbConntext.ShokouhPardisTeacherClasses.Update(teacher);
            DbConntext.SaveChanges();
        }

        return isDuplicate;
    }

    bool TeacherDuplicate(ShokouhPardisTeacherClass teacher)
    {
        var result = DbConntext.ShokouhPardisTeacherClasses.Any(x =>
            x.TeacherName == teacher.TeacherName &&
            x.TeacherFamily == teacher.TeacherFamily);
        return result;
    }

    public void DeleteTimesheet(ShokouhPardisTimeTable context)
    {
        var students = DbConntext.ShokouhPardisTimeTableStudents.Where(x => x.TimeTableId == context.TimeTableId);
        DbConntext.RemoveRange(students);

        DbConntext.ShokouhPardisTimeTables.Remove(context);
        DbConntext.SaveChanges();
    }


    public List<ShokouhPardisWeekDay> GetWeekDays()
    {
        var shokouhPardisWeekDays = DbConntext.ShokouhPardisWeekDays.ToList();
        return shokouhPardisWeekDays;
    }

    public List<ShokouhPardisInterval> GetIntervals(ShokouhPardisTermClass? term)
    {
        if (term == null)
            return
                new List<ShokouhPardisInterval>();

        var shokouhPardisIntervals = DbConntext.ShokouhPardisIntervals
            .Where(x => x.TermId == term.TermClassId)
            .ToList();
        return shokouhPardisIntervals;
    }

    public void SaveTeacherTimeSheet(ShokouhPardisTeacherTimeSheet timeSheet, bool isDefer = false)
    {
        DbConntext.Update(timeSheet);
        if (!isDefer) DbConntext.SaveChanges();
    }

    public void SaveAll()
    {
        DbConntext.SaveChanges();
    }

    public ShokouhPardisTeacherTimeSheet GetTermTeacherTimeSheet(int termId, int teacherId, int weekdayId,
        int intervalId)
    {
        var shokouhPardisTeacherTimeSheet = DbConntext.ShokouhPardisTeacherTimeSheets
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
        var shokouhPardisTeacherTimeSheet = DbConntext.ShokouhPardisTeacherTimeSheets
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
        DbConntext.ShokouhPardisTeacherTimeSheets.RemoveRange(delItems);
        DbConntext.ShokouhPardisTeacherTimeSheets.UpdateRange(teacherTimeSheets);
        DbConntext.SaveChanges();
    }

    public bool AnyTeacherTimeSheet(ShokouhPardisTermClass term, ShokouhPardisTeacherClass teacher)
    {
        var any = DbConntext.ShokouhPardisTeacherTimeSheets.Any(x =>
            x.TermId == term.TermClassId && x.TeacherId == teacher.TeacherClassId);
        return any;
    }

    public IEnumerable<ShokouhPardisLevelClass> GetLevels()
    {
        var shokouhPardisLevelClasses = DbConntext.ShokouhPardisLevelClasses.ToList();
        return shokouhPardisLevelClasses;
    }

    public List<ShokouhPardisClassRoom> GetClassRooms()
    {
        var classRooms = DbConntext.ShokouhPardisClassRooms.OrderBy(x => x.ClassRoomName).ToList();
        return classRooms;
    }

    public void AddStudentsToTeacherTimeSheet(ShokouhPardisTimeTable timeTable,
        List<ShokouhPardisStudentClass> selectedStudents)
    {
        foreach (var student in selectedStudents)
        {
            DbConntext.ShokouhPardisTimeTableStudents.Add(new ShokouhPardisTimeTableStudent()
            {
                Student = student,
                TimeTable = timeTable,
                TimeTableStudentsGuid = Guid.NewGuid(),
                TimeTableStudentsLastModified = DateTime.Now
            });

        }

        DbConntext.SaveChanges();

    }

    public bool IsStudentInOtherClassesInTheTerm(ShokouhPardisTimeTable timeTable, ShokouhPardisStudentClass student)
    {
        var any = DbConntext.ShokouhPardisTimeTableStudents
            .Any(x =>
                x.StudentId == student.StudentClassId &&
                x.TimeTable.TermId == timeTable.TermId
            );
        return any;
    }

    public ShokouhPardisTimeTable? GetTimeTable(int timeTableId)
    {
        var timeTable = DbConntext.ShokouhPardisTimeTables
            .Include(x => x.Sessions)

            .Include(x => x.Schedule)
            .ThenInclude(x => x.Programs)
            .ThenInclude(x => x.DaySession)

            .Include(x => x.Level)
            .Include(x => x.Teacher)
            .Include(x => x.ClassRoom)

            .FirstOrDefault(x => x.TimeTableId == timeTableId);
        return timeTable;
    }

    public ShokouhPardisTimeTable? GetTimeTable(Guid timeTableId)
    {
        var timeTable = DbConntext.ShokouhPardisTimeTables.FirstOrDefault(x => x.TimeTableGuid == timeTableId);
        return timeTable;
    }

    public List<ShokouhPardisTimeTable> GetTimeTableByTermSchedule(ShokouhPardisTermClass selectedTerm,
        ShokouhPardisSchedule schedules)
    {
        var timeTable = DbConntext.ShokouhPardisTimeTables
            .Include(x => x.Level)
            .Include(x => x.Teacher)
            .Include(x => x.ClassRoom)
            .Where(
                x => x.TermId == selectedTerm.TermClassId &&
                     x.ScheduleId == schedules.ScheduleId).ToList();
        return timeTable;
    }

    public void deleteStudentFromClassPlan(ShokouhPardisStudentClass student, ShokouhPardisTimeTable timeTableItem)
    {
        var timeTableStudent = DbConntext.ShokouhPardisTimeTableStudents
            .First(x => x.TimeTableId == timeTableItem.TimeTableId &&
                        x.StudentId == student.StudentClassId);
        DbConntext.ShokouhPardisTimeTableStudents.Remove(timeTableStudent);

        DbConntext.SaveChanges();
    }

    public List<ShokouhPardisStudentClassOnlineForm> GetOnlineFormStudentsList(Guid? uniqueKey)
    {
        var list = DbConntext.ShokouhPardisStudentClassOnlineForms.Where(x => x.UniqueKey == uniqueKey).ToList();
        return list;
    }

    public void SaveOnlineFormStudent(ShokouhPardisStudentClassOnlineForm student)
    {
        if (student.StudentClassId == 0)
        {
            student.RecordVersion = 1;
            student.CreatedAt = DateTime.Now;

        }
        else
        {
            student.RecordVersion++;
            student.StudentClassLastModified = DateTime.Now;
        }

        DbConntext.ShokouhPardisStudentClassOnlineForms.Update(student);
        DbConntext.SaveChanges();
    }

    public void DirectUpdateStudentProfileUrlField(ShokouhPardisStudentClassOnlineForm student)
    {

        DbConntext.Database.ExecuteSqlRaw(
            $"UPDATE [ShoukouhPardis12DBAdmin].[ShokouhPardis_StudentClass_OnlineForm] SET [ProfilePicture]='{student.ProfilePicture}' WHERE [StudentClassId] = {student.StudentClassId}");
    }

    public ShokouhPardisLevelBookPrice? GetLevelBookPrice(ShokouhPardisTimeTable timeTable)
    {
        return DbConntext.ShokouhPardisLevelBookPrices
            .FirstOrDefault(x =>
                //x.YearId == timeTable.Term.Year.YearClassId &&
                x.TermId == timeTable.Term.TermClassId &&
                x.LevelId == timeTable.Level.LevelClassId);
    }

    public ShokouhPardisLevelBookPrice? GetLevelBookPrice(int termId, int levelId)
    {
        return DbConntext.ShokouhPardisLevelBookPrices
            .FirstOrDefault(x =>
                x.TermId == termId &&
                x.LevelId == levelId);
    }

    public List<ShokouhPardisLevelBookPrice> GetAllLevelBookPriceByTerm(ShokouhPardisTermClass term)
    {
        return DbConntext.ShokouhPardisLevelBookPrices
            .Include(x => x.Level)
            .Where(x =>
                x.TermId == term.TermClassId)
            .OrderBy(x=>x.Level.LevelName)
            .ToList();
    }

    
    public void SaveDailyJV(ShokouhPardisDailyJv dailyJv)
    {
        //_financialService.ApplyDailyJv(dailyJv);
        SaveEditDailyJV(dailyJv);
        DbConntext.SaveChanges();
    }

    public int GenerateBillNoDailyJv(ShokouhPardisDailyJv dailyJv)
    {
        var queryable = DbConntext.ShokouhPardisDailyJvs

            .AsQueryable();
        int? _id = null;
        queryable = queryable.Where(x => x.CurrentDate.Value.Year == dailyJv.CurrentDate.Value.Year &&
                                         x.CurrentDate.Value.Month == dailyJv.CurrentDate.Value.Month &&
                                         x.CurrentDate.Value.Day == dailyJv.CurrentDate.Value.Day);
        if (queryable.Any())
        {
            _id = queryable.Select(t => t.DailyJvid)
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
        var jv = DbConntext.ShokouhPardisDailyJvs
            .Include(x => x.Student)
            .Include(x => x.Term)
            .Include(x => x.TimeTable)
            .Include(x => x.TimeTable.Level)
            .FirstOrDefault(x => x.DailyJvid == dailyJvid);
        return jv;
    }

    public ShokouhPardisTimeTable? GetStudetnLevel(ShokouhPardisStudentClass student, ShokouhPardisTermClass term)
    {
        var tts = DbConntext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)
            .Include(x => x.Student)
            .FirstOrDefault(
                x => x.TimeTable.TermId == term.TermClassId &&
                     x.Student.StudentClassId == student.StudentClassId);
        if (tts != null) return tts.TimeTable;
        return null;
    }



    public ShokouhPardisYearClass GetYearsInRange()
    {
        var pc = new PersianCalendar();
        var shamsiYear = pc.GetYear(DateTime.Today);

        var year = DbConntext.ShokouhPardisYearClasses.AsQueryable();
        return year.First(x => x.YearName == shamsiYear.ToString());
    }


    public ShokouhPardisTermClass? GetTermsInRangeToday()
    {
        //dateToCheck >= startDate && dateToCheck < endDate;
        var term = DbConntext.ShokouhPardisTermClasses.AsQueryable();
        return term.FirstOrDefault(x => x.StartDate <= DateTime.Today &&
                                        x.EndDate >= DateTime.Today);
    }

    public Dictionary<int, int> GetTimeTableStudentsCount(ShokouhPardisTermClass term)
    {
        var xx = DbConntext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .Where(x => x.TimeTable.TermId == term.TermClassId)
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
        return DbConntext.ShokouhPardisDailyJvs.ToList();
    }

    public List<ShokouhPardisTimeTableStudent> GetTimeTableStudent(ShokouhPardisTimeTable timeTable)
    {

        var xx = DbConntext.ShokouhPardisTimeTableStudents
            .Include(x => x.Student)
            .Where(x => x.TimeTable.TimeTableId == timeTable.TimeTableId).ToList();
        return xx;
    }
    public ShokouhPardisTimeTableStudent? GetTimeTableStudent(ShokouhPardisStudentClass student, ShokouhPardisTermClass term)
    {
        var tableStudent = DbConntext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .ThenInclude(x=>x.Term)
            .FirstOrDefault(x => x.TimeTable.TermId == term.TermClassId
                                 && x.StudentId == student.StudentClassId);
        return tableStudent;
    }
    public List<ShokouhPardisTimeTableStudent> GetTimeTableStudents(IEnumerable<ShokouhPardisTimeTable> timeTables)
    {
        var ids = timeTables.Select(z => z.TimeTableId).ToArray();

        var xx = DbConntext.ShokouhPardisTimeTableStudents
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
        var xx = DbConntext.ShokouhPardisTimeTableStudents
            .Include(x => x.Student)
            .Where(x => x.TimeTableId == timeTable.TimeTableId)
            .Select(x => x.Student)

            .ToList();
        return xx;
    }

    public int GetTotalTimeTablesCount(int termTermClassId, string? searchText = null, bool? isPrivate = false)
    {
        var dbConntextShokouhPardisTimeTables = DbConntext.ShokouhPardisTimeTables.AsQueryable();
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
        var shokouhPardisTimeTables = DbConntext
            .ShokouhPardisTimeTables
            .Include(x => x.Schedule)
            .Include(x => x.ClassRoom)
            .Include(x => x.Level)
            .Include(x => x.Teacher)
            .Where(x => x.TermId == fromTerm.TermClassId);
        return shokouhPardisTimeTables;
    }

    public IEnumerable<ShokouhPardisTimeTable>
        GetTimeTables(int page, int pageSize, string? searchText,
            ShokouhPardisTermClass term, bool isPrivate)
    {
        var queryable = DbConntext
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
                .Where(x => x.TermId == term.TermClassId && x.IsPrivate == isPrivate)
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
        var JvIds = DbConntext.ShokouhPardisDailyJvs.AsQueryable()
            .Where(x => x.CurrentDate == dailyJvCurrentDate)
            .ToList();
        return JvIds;
    }

    public int GetTotalDailyJv(DateTime? selectedDate)
    {
        var iQ = DbConntext.ShokouhPardisDailyJvs
            .Where(x => x.CurrentDate == selectedDate.Value.Date
                        && x.CurrentDate < selectedDate.Value.Date.AddDays(1)
            )
            .AsQueryable();
        return iQ.Count();
    }

    public int GetTotalDailyJv(int studentId, int selectedTermId)
    {
        var iQ = DbConntext.ShokouhPardisDailyJvs
            .Where(x => x.StudentId == studentId &&
                        x.TermId == selectedTermId)
            .AsQueryable();
        return iQ.Count();
    }

    public List<ShokouhPardisDailyJv> GetPagedJvs(int page, int size, DateTime? selDate, string? searchText)
    {
        var queryable = DbConntext.ShokouhPardisDailyJvs
            .Include(x => x.Student)
            .Where(x => x.CurrentDate >= selDate.Value.Date
                        && x.CurrentDate <= selDate.Value.Date.AddDays(1))
            .AsQueryable();
        if (searchText is not null)
        {
            queryable = queryable.Where(x => x.Student.StudentName.Contains(searchText) ||
                                             x.Student.StudentFamily.Contains(searchText) ||
                                             x.PaymentType.Contains(searchText) ||
                                             x.BillNo.ToString().Contains(searchText) ||
                                             x.Fee.ToString().Contains(searchText) ||
                                             x.FeeFor.Contains(searchText) ||
                                             x.DailyJvid.ToString().Contains(searchText) ||
                                             x.Description.Contains(searchText));
        }

        var list = queryable.Skip(page * size).Take(size).ToList();
        return list;
    }

    public List<ShokouhPardisDailyJv> GetPagedJvs(int page, int size, int studentId, int selectedTermId,
        string? searchText)
    {
        var queryable = DbConntext.ShokouhPardisDailyJvs
            .Include(x => x.Student)
            .Where(x => x.StudentId == studentId &&
                        x.TermId == selectedTermId)
            .AsQueryable();
        if (searchText is not null)
        {
            queryable = queryable.Where(x => x.Student.StudentName.Contains(searchText) ||
                                             x.Student.StudentFamily.Contains(searchText) ||
                                             x.PaymentType.Contains(searchText) ||
                                             x.BillNo.ToString().Contains(searchText) ||
                                             x.Fee.ToString().Contains(searchText) ||
                                             x.FeeFor.Contains(searchText) ||
                                             x.DailyJvid.ToString().Contains(searchText) ||
                                             x.Description.Contains(searchText));
        }

        var list = queryable.Skip(page * size).Take(size).ToList();
        return list;
    }

    public ShokouhPardisStudentClassOnlineForm? GetOnlineStudentByGuid(Guid studentGuid)
    {
        var student =
            DbConntext.ShokouhPardisStudentClassOnlineForms.FirstOrDefault(x => x.StudentClassGuid == studentGuid);
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

        var entityEntry = DbConntext.ShokouhPardisFileAttachments.Add(attachment);
        DbConntext.SaveChanges();
        return attachment;
    }

    public bool DeleteAttachment(ShokouhPardisFileAttachment? attachment)
    {
        if (attachment is null)
            return false;

        DbConntext.ShokouhPardisFileAttachments.Remove(attachment);
        DbConntext.SaveChanges();

        return true;
    }

    public void SaveJvfromSite(ShokouhPardisJvfromSite jvfromSite)
    {
        DbConntext.ShokouhPardisJvfromSites.Update(jvfromSite);
        DbConntext.SaveChanges();
    }

    public ShokouhPardisJvfromSite? GetSiteJvByGuid(string? sguid)
    {
        if (Guid.TryParse(sguid, out var guid))
        {
            var jvFromSite = DbConntext.ShokouhPardisJvfromSites
                .Include(x => x.FileAttachment)
                .FirstOrDefault(x => x.DailyJvguid == guid);
            return jvFromSite;
        }

        return null;
    }

    public ShokouhPardisStudentClassOnlineForm? StudentExistInOnlineForm(string? stuNationalId)
    {
        var student =
            DbConntext.ShokouhPardisStudentClassOnlineForms.FirstOrDefault(x => x.StudentIdno == stuNationalId);
        return student;
    }

    public ShokouhPardisStudentClass? GetStudentClassByGuid(Guid? studentGuid)
    {
        var studentClass =
            DbConntext.ShokouhPardisStudentClasses.FirstOrDefault(x => x.StudentClassGuid == studentGuid);
        return studentClass;
    }

    public ShokouhPardisTimeTable? GetStudentTermClass(int stuId, int termId)
    {
        var tts = DbConntext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .FirstOrDefault(x => x.StudentId == stuId && x.TimeTable.TermId == termId);
        if (tts == null) return null;
        var timeTable = DbConntext.ShokouhPardisTimeTables
            .Include(x => x.Term)
            .Include(x => x.ClassRoom)
            .Include(x => x.Level)
            .Include(x => x.Schedule)
            .Include(x => x.Teacher)
            .First(x => x.TimeTableId == tts.TimeTableId);
        return timeTable;
    }


    IQueryable<ShokouhPardisJvfromSite> GetAllSiteJvQuery(string? search)
    {
        var data = DbConntext.ShokouhPardisJvfromSites.AsQueryable();
        if (!search.IsEmpty())
            data = data.Where(x => x.StudentName.Contains(search) ||
                                   x.StudentFamil.Contains(search) ||
                                   x.StudentIdNumber.Contains(search) ||
                                   x.CardPostfix.Contains(search) ||
                                   x.PhoneNumber.Contains(search));
        return data.OrderBy(x => x.DailyJvid);
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
        var rec = DbConntext.ShokouhPardisJvfromSites
            .OrderBy(x => x.DailyJvid)
            .FirstOrDefault(x => x.DailyJvid > jvfromSite.DailyJvid);
        return rec;
    }

    public ShokouhPardisJvfromSite? GetAllSiteJvPrev(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;
        var rec = DbConntext.ShokouhPardisJvfromSites
            .OrderBy(x => x.DailyJvid)
            .FirstOrDefault(x => x.DailyJvid < jvfromSite.DailyJvid);
        return rec;
    }

    public ShokouhPardisJvfromSite? GetApprovedSiteJvNext(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbConntext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.DailyJvid)

                .FirstOrDefault(x => x.IsApproved == true && x.DailyJvid > jvfromSite.DailyJvid)
            ;
        return rec;
    }

    public ShokouhPardisJvfromSite? GetApprovedSiteJvPrev(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbConntext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.DailyJvid)

                .FirstOrDefault(x => x.IsApproved == true && x.DailyJvid < jvfromSite.DailyJvid)
            ;
        return rec;
    }

    public ShokouhPardisJvfromSite? GetPendingToApproveSiteJvNext(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbConntext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.DailyJvid)

                .FirstOrDefault(x => x.IsApproved == null && x.DailyJvid > jvfromSite.DailyJvid)
            ;
        return rec;
    }

    public ShokouhPardisJvfromSite? GetPendingToApproveSiteJvPrev(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbConntext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.DailyJvid)

                .FirstOrDefault(x => x.IsApproved == null && x.DailyJvid < jvfromSite.DailyJvid)
            ;
        return rec;
    }

    public ShokouhPardisJvfromSite? GetRequireInvestigateSiteJvNext(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbConntext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.DailyJvid)

                .FirstOrDefault(x => x.IsRequiredInvestigation == true && x.DailyJvid > jvfromSite.DailyJvid)
            ;
        return rec;

    }

    public ShokouhPardisJvfromSite? GetRequireInvestigateSiteJvPrev(ShokouhPardisJvfromSite? jvfromSite)
    {
        if (jvfromSite == null) return null;

        var rec = DbConntext
                .ShokouhPardisJvfromSites
                .OrderBy(x => x.DailyJvid)

                .FirstOrDefault(x => x.IsRequiredInvestigation == true && x.DailyJvid < jvfromSite.DailyJvid)
            ;
        return rec;

    }

    public List<ShokouhPardisTeacherClass> GetTeachers()
    {
        return DbConntext.ShokouhPardisTeacherClasses.ToList();
    }

    public HashSet<ShokouhPardisTeacherClass> GetTeachersInTerm(ShokouhPardisTermClass term)
    {
        var set = DbConntext.ShokouhPardisTeacherTermClasses
            .Include(x => x.Teacher)
            .Where(x => x.TermFk == term.TermClassId)
            .Select(x => x.Teacher)
            .ToHashSet();
        return set;
    }

    public bool IsAnyTeachersInTerm(ShokouhPardisTermClass term)
    {
        var set = DbConntext.ShokouhPardisTeacherTermClasses
                //.Include(x => x.Teacher)
                .Any(x => x.TermFk == term.TermClassId)
            ;
        return set;
    }

    public void RemoveTeacherFromTerm(List<ShokouhPardisTeacherClass> removed,
        ShokouhPardisTermClass term)
    {
        var ids = removed.Select(x => x.TeacherClassId).ToArray();
        DbConntext.RemoveRange(DbConntext.ShokouhPardisTeacherTermClasses.Where(x => x.TermFk == term.TermClassId &&
            ids.Contains(x.TeacherFk)));
        DbConntext.SaveChanges();
    }

    public IEnumerable<ShokouhPardisTeacherTermClass> AddTeacherToTerm(IEnumerable<ShokouhPardisTeacherClass> added,
        ShokouhPardisTermClass term)
    {
        var ttc = added.Select(teacher => new ShokouhPardisTeacherTermClass
        {
            TeacherFk = teacher.TeacherClassId,
            TermFk = term.TermClassId,
            Guid = Guid.NewGuid(),
            LastModified = DateTime.Now,
        });
        DbConntext.ShokouhPardisTeacherTermClasses.AddRange(ttc);

        DbConntext.SaveChanges();
        return ttc;
    }

    public List<ShokouhPardisTimeTable> GetTimeTableSchedule(int termId, bool isPm, bool isPrivate = false)
    {
        var records = DbConntext.ShokouhPardisTimeTables
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
        var records = DbConntext.ShokouhPardisTimeTables
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
        return DbConntext.ShokouhPardisTimeTableStudents.Include(x => x.Student)
            .Include(x => x.TimeTable)
            .Where(x => x.TimeTable.TermId == term.TermClassId)
            //.Select(x=>x.Student)
            .ToList()
            .GroupBy(x => x.TimeTableId!)
            .ToDictionary(students => students.Key, students => students.ToList());
    }

    public void SaveData(IEnumerable<object> data)
    {
        foreach (var record in data)
        {
            var entityEntry = DbConntext.Add(record);
            DbConntext.SaveChanges();

        }
        //DbConntext.AddRange(data);
        //SaveAll();
    }

    public bool IsAnyIntervalsInTerm(ShokouhPardisTermClass toTerm)
    {
        return DbConntext.ShokouhPardisIntervals.Any(x => x.TermId == toTerm.TermClassId);
    }

    public bool IsAnyScheduleInTerm(ShokouhPardisTermClass toTerm)
    {
        return DbConntext.ShokouhPardisSchedules.Any(x => x.TermFk == toTerm.TermClassId);
    }

    public bool IsAnyDaySessionInTerm(ShokouhPardisTermClass toTerm)
    {
        return DbConntext.ShokouhPardisDaySessions.Any(x => x.TermFk == toTerm.TermClassId);
    }

    public List<ShokouhPardisDaySession> GetDaySessions(ShokouhPardisTermClass fromTerm)
    {
        return DbConntext.ShokouhPardisDaySessions.Where(x => x.TermFk == fromTerm.TermClassId)
            .Include(w => w.WeekDay)
            .Include(i => i.Interval)
            .ToList();
    }

    public List<ShokouhPardisProgram> GetProgramsForSchedules(List<int> scheduleIds)
    {
        return DbConntext.ShokouhPardisPrograms
            .Where(x => scheduleIds.Contains(x.ScheduleId))
            .ToList();
    }

    public bool IsAnyTimeTableInTerm(ShokouhPardisTermClass toTerm)
    {
        return DbConntext.ShokouhPardisTimeTables.Any(x => x.TermId == toTerm.TermClassId);
    }

    public List<ShokouhPardisLevelBookPrice> GetTermLevelPrices(ShokouhPardisTermClass term)
    {
        return DbConntext.ShokouhPardisLevelBookPrices
            .Include(x => x.Level)
            .Where(x => x.TermId == term.TermClassId)
            .ToList();

    }

    public void AddIntervals(IEnumerable<ShokouhPardisInterval> clonedInterval)
    {
        DbConntext.ShokouhPardisIntervals.AddRange(clonedInterval);
        SaveAll();
    }

    public void AddPrograms(IEnumerable<ShokouhPardisProgram> clonedPrograms)
    {
        DbConntext.ShokouhPardisPrograms.AddRange(clonedPrograms);
        SaveAll();
    }

    public void SaveSchedules(IEnumerable<ShokouhPardisSchedule> clonedSchedule)
    {
        DbConntext.ShokouhPardisSchedules.AddRange(clonedSchedule);
        SaveAll();
    }

    public void SaveDaySessions(IEnumerable<ShokouhPardisDaySession> clonedDaySessions)
    {
        DbConntext.ShokouhPardisDaySessions.AddRange(clonedDaySessions);
        SaveAll();
    }

    public void SaveTimeTables(IEnumerable<ShokouhPardisTimeTable> cloneTimeTable)
    {
        DbConntext.ShokouhPardisTimeTables.AddRange(cloneTimeTable);
        SaveAll();
    }

    public void SaveStudentsTableTable(IEnumerable<ShokouhPardisTimeTableStudent> timeTableStudents)
    {
        DbConntext.ShokouhPardisTimeTableStudents.AddRange(timeTableStudents);
        SaveAll();
    }

    public List<ShokouhPardisLevelBookPrice> GetTermBookPrices(ShokouhPardisTermClass fromTerm)
    {
        return DbConntext.ShokouhPardisLevelBookPrices
            .Where(x => x.TermId == fromTerm.TermClassId)
            .ToList();
    }

    public void AddBookPrices(List<ShokouhPardisLevelBookPrice> list)
    {
        DbConntext.ShokouhPardisLevelBookPrices.AddRange(list);
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
            DbConntext.ShokouhPardisIntervals.Update(interval);
            DbConntext.SaveChanges();
        }

        return isDuplicate;
    }

    bool IntervalDuplicate(ShokouhPardisInterval interval)
    {
        var result = DbConntext.ShokouhPardisIntervals.Any(x =>
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
            DbConntext.ShokouhPardisDaySessions.Update(daySesseion);
            DbConntext.SaveChanges();
        }

        return isDuplicate;
    }

    bool DaySessionDuplicate(ShokouhPardisDaySession daySesseion)
    {
        var result = DbConntext.ShokouhPardisDaySessions.Any(x =>
            x.WeekDay.Title == daySesseion.WeekDay.Title &&
            x.Interval.Title == daySesseion.Interval.Title &&
            x.TermFk == daySesseion.TermFk);
        return result;
    }


    private List<ShokouhPardisWeekDay>? _weekdays;

    private List<ShokouhPardisWeekDay> Weekdays()
    {
        return _weekdays ??= DbConntext.ShokouhPardisWeekDays.ToList();
    }

    public ShokouhPardisWeekDay GetFirstWeekDays()
    {
        return Weekdays().First();
    }

    public ShokouhPardisInterval GetFirstIntervalByTerm(ShokouhPardisTermClass selectedTerm)
    {
        return DbConntext.ShokouhPardisIntervals.First(x => x.TermId == selectedTerm.TermClassId);
    }

    public bool SaveEditSchedule(ShokouhPardisSchedule schedule)
    {
        bool isDuplicate = ScheduleDuplicate(schedule);
        if (isDuplicate)
        {
        }
        else
        {
            DbConntext.ShokouhPardisSchedules.Update(schedule);
            DbConntext.SaveChanges();
        }

        return isDuplicate;
    }

    bool ScheduleDuplicate(ShokouhPardisSchedule schedule)
    {
        var result = DbConntext.ShokouhPardisSchedules.Any(x =>
            x.Title == schedule.Title &&
            x.TermFk == schedule.TermFk);

        return result;
    }

    public bool SaveProgram(ShokouhPardisProgram program)
    {
        var isDuplicate = IsProgramDuplicate(program);
        if (isDuplicate)
            return isDuplicate;

        DbConntext.ShokouhPardisPrograms.Update(program);
        DbConntext.SaveChanges();
        return isDuplicate;
    }

    bool IsProgramDuplicate(ShokouhPardisProgram program)
    {
        var result = DbConntext.ShokouhPardisPrograms.Any(x =>
            x.DaySession == program.DaySession);

        return result;
    }

    public void DeleteProgram(ShokouhPardisProgram prog)
    {
        DbConntext.ShokouhPardisPrograms.Remove(prog);
        DbConntext.SaveChanges();
    }

    public void UpdateEditLevelBookPrice(ShokouhPardisLevelBookPrice levelBookPrice,
        ShokouhPardisTermClass selectedTerm)
    {
        DbConntext.ShokouhPardisLevelBookPrices.Update(levelBookPrice);
        DbConntext.SaveChanges();
    }

    public bool SaveEditLevelBookPrice(ShokouhPardisLevelBookPrice levelBookPrice,
        ShokouhPardisTermClass selectedTerm)
    {
        var isDuplicate = IsLevelBookPriceDuplicate(levelBookPrice, selectedTerm);
        if (isDuplicate)
            return isDuplicate;

        DbConntext.ShokouhPardisLevelBookPrices.Update(levelBookPrice);
        DbConntext.SaveChanges();
        return isDuplicate;
    }

    bool IsLevelBookPriceDuplicate(ShokouhPardisLevelBookPrice levelBookPrice,
        ShokouhPardisTermClass selectedTerm)
    {
        var result = DbConntext.ShokouhPardisLevelBookPrices.Any(x =>
            x.LevelId == levelBookPrice.LevelId &&
            x.TermId == selectedTerm.TermClassId);

        return result;
    }

    public Dictionary<ShokouhPardisLevelClass, int> GetTimeTableLevelChartData(ShokouhPardisTermClass selectedTerm)
    {
        return DbConntext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)
            //.Include(x=>x.Student)
            .Where(x => x.TimeTable.TermId == selectedTerm.TermClassId)
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
        if (dailyJv.DailyJvid == 0)
        {
            bool isDuplicate = DailyJVDuplicate(dailyJv);
            if (isDuplicate)
            {
                throw new Exception("Duplicated daily JV record");
            }
        }

        DbConntext.ShokouhPardisDailyJvs.Update(dailyJv);
        DbConntext.SaveChanges();
    }

    bool DailyJVDuplicate(ShokouhPardisDailyJv dailyJv)
    {
        var result = DbConntext.ShokouhPardisDailyJvs.Any(x =>
            x.Fee == dailyJv.Fee &&
            x.StudentId == dailyJv.StudentId &&
            x.FeeFor == dailyJv.FeeFor &&
            x.PaymentType == dailyJv.PaymentType &&
            x.BillNo == dailyJv.BillNo);
        return result;
    }




    public IQueryable<ShokouhPardisTimeTableStudent> GetStudentByTerm(int termId)
    {
        //var studentList = new List<ShokouhPardisStudentClass>();
        var students = DbConntext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .Include(x => x.Student)

            .Where(x =>
                x.TimeTable.TermId == termId);

        return students;
    }

    public List<ShokouhPardisDailyJv> GetDailyJvBy(int termId, int studentId)
    {
        var dailyJvs = DbConntext.ShokouhPardisDailyJvs
            .Where(x => x.TermId == termId &&
                        x.StudentId == studentId)
            .ToList();
        return dailyJvs;
    }


    public bool DeleteDailyJV(ShokouhPardisDailyJv dailyJv)
    {
        var pr = DbConntext.PreRegistrations.FirstOrDefault(
            x => x.DailyJVFk == dailyJv.DailyJvid);

        if (pr is null)
        {

            DbConntext.ShokouhPardisDailyJvs.Remove(dailyJv);
            DbConntext.SaveChanges();
            return false;
        }
        else
        {
            DbConntext.PreRegistrations.Remove(pr);
            DbConntext.ShokouhPardisDailyJvs.Remove(dailyJv);
            DbConntext.SaveChanges();
            return true;
        }

    }

    public List<ShokouhPardisDailyJv> GetDailyJvsByTerm(int termId)
    {
        return DbConntext.ShokouhPardisDailyJvs.Where(x => x.TermId == termId).ToList();
    }

    public List<ShokouhPardisDailyJv> GetDailyJvsByTimeTable(ShokouhPardisTimeTable timeTable,
        ShokouhPardisStudentClass student)
    {
        return DbConntext.ShokouhPardisDailyJvs.Where(x => x.TermId == timeTable.TermId
                                                           && x.TimeTableFk == timeTable.TimeTableId
                                                           && x.StudentId == student.StudentClassId).ToList();
    }


    public List<User> GetUsers()
    {
        return DbConntext.Users.Include(x => x.Roles).ToList();
    }

    public void SaveUser(User user)
    {
        DbConntext.Users.Update(user);
        DbConntext.SaveChanges();
    }

    public List<Role> GetRoles()
    {
        return DbConntext.Roles
            .Include(x => x.Permissions)
            .ToList();
    }

    public void SaveRole(Role role)
    {
        DbConntext.Roles.Update(role);
        DbConntext.SaveChanges();
    }

    public List<Permission> GetPermissions()
    {
        var permissions = DbConntext.Permissions.Include(x => x.Roles).ToList();
        return permissions;
    }

    public void SavePermission(Permission permission)
    {
        DbConntext.Permissions.Update(permission);
        DbConntext.SaveChanges();
    }

    public User? GetUserByUserName(string? userName)
    {
        if (userName.IsEmpty()) return null;
        return DbConntext.Users.FirstOrDefault(x => x.UserName == userName);
    }

    public User GetUserByUseId(int userId)
    {
        return DbConntext.Users.First(x => x.Id == userId);
    }

    public Role? GetRoleByName(string roleName)
    {
        var firstOrDefault = DbConntext.Roles.FirstOrDefault(x => x.Name == roleName);
        return firstOrDefault;
    }

    
    public User? CheckUserLogin(string userName, string password)
    {
        // Log.Information("THIS IS SAMPLE of CHECKING USER LOG");
        var firstOrDefault = DbConntext.Users
            .Include(x => x.Roles)
            .FirstOrDefault(x => x.UserName == userName && x.Password == password);
        return firstOrDefault;
    }

    public List<TimeTableSession> GetTimeTableSessions(ShokouhPardisTimeTable timeTable)
    {
        var sessions = DbConntext.TimeTableSessions
            .Include(x => x.ClassRoom)
            .Include(x => x.Teacher)
            .Include(x => x.TimeTable)
            .Include(x => x.ReplacementSession)
            .Where(x => x.TimeTableFk == timeTable.TimeTableId)
            .OrderBy(x => x.SessionDate)
            .ToList();
        return sessions;
    }

    public int GetTimeTableSessionsCount(ShokouhPardisTimeTable timeTable)
    {
        var sessions = DbConntext.TimeTableSessions
            .Count(x => x.TimeTableFk == timeTable.TimeTableId && x.SessionNumber > 0);
        return sessions;
    }

    public Dictionary<int, int> GetTimeTableSessionsCountByTermId(int termId)
    {
        var sessions = DbConntext.TimeTableSessions
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
        return DbConntext.TermSessionTemplates
            .Include(x => x.Term)
            .Where(x => x.TermFk == term.TermClassId)
            .ToList();
    }

    public void SaveTermSessionTemplate(TermSessionTemplate tst)
    {
        if (tst.TermSessionTemplateID == 0)
            DbConntext.TermSessionTemplates.Add(tst);
        else
            DbConntext.TermSessionTemplates.Update(tst);

        DbConntext.SaveChanges();
    }

    public List<TermSessionTemplateDate> GetTermSessionTemplateDates(TermSessionTemplate tst)
    {
        return DbConntext.TermSessionTemplateDates
            .Where(x => x.TermSessionTemplateFk == tst.TermSessionTemplateID)
            .ToList();
    }

    public int GetTermSessionTemplateDateCount(TermSessionTemplate tst)
    {
        return DbConntext.TermSessionTemplateDates
            .Count(x => x.TermSessionTemplateFk == tst.TermSessionTemplateID);

    }

    public void SaveTermSessionTemplateDate(TermSessionTemplateDate tstd)
    {

        DbConntext.TermSessionTemplateDates.Update(tstd);
        DbConntext.SaveChanges();
    }

    public void DeleteTermSessionTemplateDate(TermSessionTemplateDate context)
    {
        DbConntext.TermSessionTemplateDates.Remove(context);
        DbConntext.SaveChanges();
    }

    public void DeleteTermSessionTemplate(TermSessionTemplate context)
    {
        DbConntext.TermSessionTemplates.Remove(context);
        DbConntext.SaveChanges();

    }

    public void DeleteTermSessionTemplateDates(TermSessionTemplate context)
    {
        var dates = DbConntext.TermSessionTemplateDates.Where(x =>
            x.TermSessionTemplateFk == context.TermSessionTemplateID);
        DbConntext.RemoveRange(dates);
        DbConntext.SaveChanges();
    }

    public LessonPlan? GetLessonPlan(int sessionNumber, int levelId)
    {
        return DbConntext.LessonPlans.
            Include(x=>x.Sections)
            .ThenInclude(x=>x.Items)
            .Include(x=>x.Sections)
            .ThenInclude(x=>x.SectionType)
            .FirstOrDefault(x => x.SessionNumber == sessionNumber && x.LevelFk == levelId);
    }
    public List<LessonPlan> GetLessonPlan( int levelID)
    {
        return DbConntext.LessonPlans
            .Where(x =>x.LevelFk == levelID)
            .ToList();
    }

    public TimeTableSession SaveTimeTableSession(TimeTableSession timeTableSession)
    {
        var entityEntry = DbConntext.TimeTableSessions.Update(timeTableSession);

        DbConntext.SaveChanges();

        return entityEntry.Entity;
    }

    public void UpdateTimeTableSessions(IOrderedEnumerable<TimeTableSession> allSessions)
    {
        DbConntext.UpdateRange(allSessions);
        DbConntext.SaveChanges();
    }

    public TermSessionTemplate? GetTermTemplateByWeekdayIds(ShokouhPardisTermClass? term,
        string weekdayIds)
    {
        var termSessionTemplates = DbConntext.TermSessionTemplates
            .SingleOrDefault(x => x.TermFk == term.TermClassId && x.WeekdayIds == weekdayIds);
        return termSessionTemplates;
    }

    public List<SessionActivity> GetSessionActivities()
    {
        var sessionActivities = DbConntext.SessionActivities
            .Include(x => x.ValueOptions)
            .ToList();
        return sessionActivities;
    }

    public void SaveSessionActivity(SessionActivity sessionActivity)
    {
        var entityEntry = DbConntext.SessionActivities.Update(sessionActivity);
        DbConntext.SaveChanges();
    }

    public ShokouhPardisInterval? GetInterval(ShokouhPardisTermClass term, TimeSpan time,
        TimeSpan offset)
    {
        //throw new NotImplementedException();
        var interval = DbConntext.ShokouhPardisIntervals.FirstOrDefault(x =>
            x.TermId == term.TermClassId && time >= x.StartTime && time <= x.EndTime);
        return interval;
    }

    public ShokouhPardisTeacherClass? GetTeacherByUserId(int? userId)
    {
        var teacher = DbConntext.ShokouhPardisTeacherClasses.SingleOrDefault(x => x.UserId == userId);
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

        var weekDay = Weekdays().First(x => x.WeekDayId == pwdId);
        return weekDay;
    }

    public ShokouhPardisTimeTable? GetTeacherTimeTable(ShokouhPardisTermClass term, ShokouhPardisTeacherClass teacher,
        ShokouhPardisWeekDay weekday, ShokouhPardisInterval interval)
    {
        var tt = DbConntext.ShokouhPardisTimeTables
            // .Include(x=>x.Schedule)
            // .ThenInclude(x=>x.Programs)
            // .ThenInclude(x=>x.DaySession)
            .FirstOrDefault(x =>
                x.TermId == term.TermClassId &&
                x.TeacherId == teacher.TeacherClassId &&
                x.Schedule.Programs.Any(p => p.DaySession.IntervalId == interval.IntervalId &&
                                             p.DaySession.WeekdayId == weekday.WeekDayId));
        return tt;
    }

    public TimeTableSession GetTimeTableSession(int sessionId)
    {
        var timeTableSession = DbConntext.TimeTableSessions
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Teacher)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.ClassRoom)
            .FirstOrDefault(x => x.ID == sessionId);
        return timeTableSession!;
    }

    public TimeTableSession? GetTimeTableSession(ShokouhPardisTimeTable? timetable, DateTime dateTime)
    {
        if (timetable == null) return null;

        var session = DbConntext.TimeTableSessions
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
                x.TimeTableFk == timetable.TimeTableId && x.SessionDate == dateTime);
        return session;
    }

    public List<SessionActivity> GetSessionActivities(TimeTableSession session)
    {
        var sessionActivitiesQuery = DbConntext
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
        DbConntext.StudentSessionActivities.Update(activity);
        DbConntext.SaveChanges();
    }

    public Dictionary<int, List<StudentSessionActivity>> GetStudentsSessionActivities(TimeTableSession session)
    {
        var activities = DbConntext
                .StudentSessionActivities
                .Where(x => x.TimeTableSessionFk == session.ID)
                .ToList()
                .GroupBy(g => g.StudentFk)
                .ToDictionary(x => x.Key, y => y.ToList())
            ;
        return activities;
    }

    public void SaveValueOption(SessionActivityValueOption valueOption)
    {
        DbConntext.SessionActivityValueOptions.Update(valueOption);
        DbConntext.SaveChanges();
    }

    public SessionActivity GetSessionActivity(int sessionActivityId)
    {
        var sessionActivity = DbConntext.SessionActivities
            .Include(x => x.ValueOptions)
            .First(x => x.SessionActivityID == sessionActivityId);
        return sessionActivity;
    }

    public void DeleteSessionActivityValueOption(SessionActivityValueOption vo)
    {
        var sessionActivity = DbConntext.SessionActivityValueOptions.Remove(vo);
        DbConntext.SaveChanges();


    }

    public ShokouhPardisTimeTable FindStudentLastTimeTable(ShokouhPardisStudentClass student)
    {
        var tts = DbConntext.ShokouhPardisTimeTableStudents
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Level)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Term)
            .Include(x => x.TimeTable)
            .ThenInclude(x => x.Teacher)
            .Include(x => x.Student)
            .OrderByDescending(x => x.TimeTableStudentsId)
            .LastOrDefault(x => x.Student.StudentClassId == student.StudentClassId);
        if (tts != null) return tts.TimeTable;
        return null;


    }

    public ShokouhPardisLevelClass FindNextLevel(ShokouhPardisTimeTable findStudentLastTimeTable)
    {
        var FindLevel =
            DbConntext.ShokouhPardisLevelClasses.First(x =>
                x.LevelClassId == findStudentLastTimeTable.Level.LevelClassId);

        return DbConntext.ShokouhPardisLevelClasses.First(x => x.LevelClassId == FindLevel.NextLevelFk);

    }

    public ShokouhPardisTermClass? GetNextTerm()
    {
        IQueryable<ShokouhPardisTermClass?> term = DbConntext.ShokouhPardisTermClasses.AsQueryable();
        var currentTerm = term.FirstOrDefault(x => x.StartDate <= DateTime.Today &&
                                                   x.EndDate >= DateTime.Today);
        return term.FirstOrDefault(x => currentTerm != null && x.StartDate >= currentTerm.EndDate);
    }

    public bool SavePreRegistration(PreRegistration preRegistration)
    {
        var isDuplicate = PreRegistrationDuplicate(preRegistration);
        if (isDuplicate)
            return isDuplicate;
        DbConntext.PreRegistrations.Update(preRegistration);
        DbConntext.SaveChanges();
        return isDuplicate;
    }

    bool PreRegistrationDuplicate(PreRegistration preRegistration)
    {

        var result = DbConntext.PreRegistrations.Any(x =>
            x.LevelFk == preRegistration.LevelFk &&
            x.DailyJVFk == preRegistration.DailyJVFk &&
            x.StudentFk == preRegistration.StudentFk &&
            x.TermFk == preRegistration.TermFk);
        return result;
    }

    public PreRegistration GetPreRegistrationByJv(int dalyJvid)
    {
        var registration = DbConntext.PreRegistrations
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
            DbConntext.LessonPlans.Update(lessonPlan);
            DbConntext.SaveChanges();
        }

        return isDuplicate;
    }

    bool LessonPlanDuplicate(LessonPlan lessonPlan)
    {
        var result = DbConntext.LessonPlans.Any(x =>
            x.LevelFk == lessonPlan.LevelFk &&
            x.SessionNumber == lessonPlan.SessionNumber);
        return result;
    }

    public int GetLessonPlanSessionNo(ShokouhPardisLevelClass level)
    {
        var lastSessionNumberLessonPlan = DbConntext.LessonPlans
            .Where(x => x.LevelFk == level.LevelClassId)
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
        var studentIds = selectedStudents.Select(x=>x.StudentClassId).ToArray();

        var registrations = DbConntext.PreRegistrations
            .Where(x => studentIds.Contains(x.StudentFk)).ToList();
        registrations.ForEach(x => x.IsArchive = true);
        DbConntext.PreRegistrations.UpdateRange(registrations);
        DbConntext.SaveChanges();

    }

    public void DailyJvAssignToTimeTable(ShokouhPardisTimeTable tt, List<ShokouhPardisStudentClass> selectedStudents)
    {
        var studentsIds = selectedStudents.Select(x=>x.StudentClassId).ToArray();
        var preRegistrations = DbConntext.PreRegistrations.Where(x => studentsIds.Contains(x.StudentFk)).ToList();
        var dailyJvIds = preRegistrations.Select(x => x.DailyJVFk).ToArray();
        var shokouhPardisDailyJvs = DbConntext.ShokouhPardisDailyJvs.Where(x=> dailyJvIds.Contains(x.DailyJvid)).ToArray();
        foreach (var x in shokouhPardisDailyJvs)
        {
            x.TimeTableFk = tt.TimeTableId;
        }
        DbConntext.UpdateRange(shokouhPardisDailyJvs);
        DbConntext.SaveChanges();
    }

    public void SetActivityDeleteTime(StudentSessionActivity sac)
    {
	    sac.ActivityDeletedDateTime = DateTime.Now;
	    DbConntext.Update(sac);
	    DbConntext.SaveChanges();
    }

    public List<LessonPlanSection>? GetLessonPlanSection(LessonPlan lessonPlan)
    {
        if (lessonPlan is null)
            return null;
        return DbConntext.LessonPlanSections
            .Include(x=>x.SectionType)
            .Where(
            x => x.LessonPlanFk == lessonPlan.LessonPlanId).ToList();
    }

    public List<LessonPlanSectionItem> GetLessonPlanSectionItems(LessonPlanSection section)
    {
        return DbConntext.LessonPlanSecionItems.Where(
            x => x.LessonPlanSectionFk == section.Id)
            .OrderBy(x=>x.Order)
            .ToList();
    }

    public void SaveSectionItem(LessonPlanSectionItem lessonPlanSectionItem)
    {
        DbConntext.LessonPlanSecionItems.Update(lessonPlanSectionItem);
        DbConntext.SaveChanges();
    }

    public ShokouhPardisTermClass GetTermsbyTermId(int i)
    {
        return DbConntext.ShokouhPardisTermClasses
            .FirstOrDefault(x => x.TermClassId == i);
    }

    public List<ShokouhPardisLevelClass> GetlevelBookNOPriceList(ShokouhPardisTermClass term)
    {
        return DbConntext.ShokouhPardisLevelClasses
            .Where(level => !DbConntext.ShokouhPardisLevelBookPrices.Any(price => price.LevelId == level.LevelClassId & price.TermId == term.TermClassId))
            .ToList();
        
    }
   
    public List<ChartSeries> GetDailyJvSeriesPaymentType(DateTime dateFrom, DateTime dateTo)
    {
       
            var paymentSummaries = DbConntext.ShokouhPardisDailyJvs
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

        List<PaymentSummary> paymentSummaries = DbConntext.ShokouhPardisDailyJvs
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
        return  DbConntext.ShokouhPardisTimeTableStudents
            .Include(x=>x.TimeTable)
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

            .Where(x=>x.StudentId == student.StudentClassId)
            .Select(x=>x.TimeTable).ToList();
    }

    public void StudentMove(ShokouhPardisTimeTable timeTableOrig, ShokouhPardisTimeTable TimeTabelNew, ShokouhPardisStudentClass student)
    {
        //add New
        var FindTimeTableStudent= DbConntext.ShokouhPardisTimeTableStudents.FirstOrDefault(x=>x.TimeTableId == timeTableOrig.TimeTableId &&
            x.StudentId == student.StudentClassId);
        if (FindTimeTableStudent != null)
        {
            FindTimeTableStudent.TimeTableId = TimeTabelNew.TimeTableId;
            DbConntext.Update(FindTimeTableStudent);
            DbConntext.SaveChanges();
        }

    }

    public void RegisterAdvanceUser(AdvanceRegistration advanceRegistration)
    {

	    DbConntext.AdvanceRegistrations.Add(advanceRegistration);
	    DbConntext.SaveChanges();

    }

    public void InactiveUser(string userName)
    {
        var user = DbConntext.Users.FirstOrDefault(x=>x.UserName == userName);
        if (user is null) return;

        user.IsActive = false;
        DbConntext.SaveChanges();
    }

    public TimeTableSession GetSession(int sessionId)
    {
        return DbConntext.TimeTableSessions
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

            .FirstOrDefault(x => x.ID == sessionId);
    }
}

  