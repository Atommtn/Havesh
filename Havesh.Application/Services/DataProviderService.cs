using System.Globalization;
using Havesh.Domain;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Olive;
using MudBlazor;
using Havesh.Domain.Infrastructure;
using Havesh.Model.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.IdentityModel.Tokens;
using static Dapper.SqlMapper;

namespace Havesh.Application.Services;

public class DataProviderService : IAsyncDisposable , IDisposable
{
	private readonly GrainEntityDependency _grainEntityDependency;
	private readonly IClusterClient _clusterClient;
	private MyDbContext? _dbContext=null;
	public MyDbContext DbContext => _dbContext ??= GetDbContextForBranch(BranchName);
	private string? _branchName;
	
	/// Init the BranchName IMMEDIATELY Before First Use of Injected DataProviderService
	/// Specially for use inside GRAINS !
	/// Default Value IS the BranchName from Environment Variable so it Sould have [BranchName]__DataSource and [BranchName]__InitialCatalog , ...
	public string BranchName
	{
		get => _branchName ??= Environment.GetEnvironmentVariable("BranchName")!.Trim().TrimEnd("_");
		set => _branchName = value;
	}

	private readonly MyDbContextFactory _dbContextFactory;
	MyDbContext GetDbContextForBranch(string branchName)
	{
		// Create DbContext with the appropriate connection string
		var dbContextForBranch = _dbContextFactory.CreateDbContextForBranch(branchName);
		dbContextForBranch.EntityTouched += DbContextOnEntityTouched;
		//dbContext.ChangeTracker.AutoDetectChangesEnabled = false;
		return dbContextForBranch;
	}

	public void SaveAll()
	{
		DbContext.SaveChanges();
	}

	public DataProviderService(
		//MyDbContext dbContext,
		MyDbContextFactory dbContextFactory,
		GrainEntityDependency grainEntityDependency,
		IClusterClient clusterClient
		)
	{
		_dbContextFactory = dbContextFactory;
		_grainEntityDependency = grainEntityDependency;
		_clusterClient = clusterClient;
		//DbContext = dbContext;

	}
	public async ValueTask DisposeAsync()
	{
		DbContext.EntityTouched -= DbContextOnEntityTouched;
		await DbContext.DisposeAsync();
	}
	public void Dispose()
	{
		DbContext.EntityTouched -= DbContextOnEntityTouched;
		DbContext.Dispose();
	}

	private async Task DbContextOnEntityTouched(EntityEntry entry)
	{
		Console.WriteLine(entry.Entity.ToString() + " - " + entry.State);
		if (entry.Entity is BaseModel entity)
			await _grainEntityDependency.ResetGrainsDependsOn(entity,_clusterClient);

	}

	public List<ShokouhPardisYearClass> GetYears()
	{
		return DbContext
			.ShokouhPardisYearClasses
			.Include(x => x.Terms)
			.ToList();
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
			(x.Teacher.TeacherName.Contains(search) || x.Teacher.TeacherFamily.Contains(search)))
			.Select(x => x.Teacher)
			.ToList();

		return relatedTeachers;
	}


	public bool SaveTeacherTimeTable(ShokouhPardisTimeTable timeTable)
	{

		var title = $"{timeTable.Teacher} -> {timeTable.Term.Year.YearName} -> {timeTable.Term.TermName} -> {timeTable.Schedule.Title}";
		if (timeTable.IsPrivate)
			title += "خصوصی ";

		else if (timeTable.Id == 0 && TimeTableDuplicate(timeTable))
			return true;
		timeTable.Title = title;


		CheckAndChangeSession(timeTable);
		DbContext.ShokouhPardisTimeTables.Update(timeTable);
		SaveAll();
		return false;
	}

    private void CheckAndChangeSession(ShokouhPardisTimeTable timeTable)
    {
        var timeTableSessions = DbContext.TimeTableSessions.Where(x => x.TimeTableFk == timeTable.Id).ToList();
        if (timeTableSessions.Any())
            foreach (var timeTableSession in timeTableSessions)
                timeTableSession.TeacherFk = timeTable.TeacherId;
        //DbContext.TimeTableSessions.UpdateRange(timeTableSessions);

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
			SaveAll();
		}

		return isDuplicate;
	}

	bool TeacherDuplicate(ShokouhPardisTeacherClass teacher)
	{
		var result = DbContext.ShokouhPardisTeacherClasses.Any(x =>
			x.TeacherName == teacher.TeacherName &&
			x.TeacherFamily == teacher.TeacherFamily &&
			x.Id != teacher.Id);
		return result;
	}

	public void DeleteTimesheet(ShokouhPardisTimeTable context)
	{
		var students = DbContext.ShokouhPardisTimeTableStudents.Where(x => x.TimeTableId == context.Id);
		DbContext.RemoveRange(students);

		DbContext.ShokouhPardisTimeTables.Remove(context);
		SaveAll();
	}


	public List<ShokouhPardisWeekDay> GetWeekDays()
	{
		var shokouhPardisWeekDays = DbContext.ShokouhPardisWeekDays.ToList();
		return shokouhPardisWeekDays;
	}

	public List<ShokouhPardisInterval>? GetIntervals(int termId)
	{
		var shokouhPardisIntervals = DbContext.ShokouhPardisIntervals
			.Where(x => x.TermId == termId)
			.ToList();
		return shokouhPardisIntervals;

	}
	public List<ShokouhPardisInterval>? GetIntervals(ShokouhPardisTermClass? term)
	{
		return term == null
			? new List<ShokouhPardisInterval>()
			: GetIntervals(term.Id);
	}

	public void SaveTeacherTimeSheet(ShokouhPardisTeacherTimeSheet timeSheet, bool isDefer = false)
	{
		DbContext.Update(timeSheet);
		if (!isDefer) SaveAll();
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
		SaveAll();
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
		var classRooms = DbContext
			.ShokouhPardisClassRooms
			.OrderBy(x => x.ClassRoomName)
			.ToList();
		return classRooms;
	}

	public List<ShokouhPardisTimeTable> GetTimeTables(int intervalId, int weekDayId)
	{
		var timeTables = DbContext.ShokouhPardisTimeTables
			.Include(x => x.Teacher)

			.Include(x => x.ClassRoom)

			.Include(x => x.Schedule)
			.ThenInclude(x => x.Programs)

			.ThenInclude(x => x.DaySession)
			.Include(x => x.Sessions)

			.OrderBy(x => x.ClassRoom.ClassRoomName)
			.Where(x => x.Schedule.Programs.Any(z => z.DaySession.IntervalId == intervalId &&
													 z.DaySession.WeekdayId == weekDayId))
			.ToList();
		return timeTables;

	}
	public List<TimeTableSession> GetTimeTableSessions(TimeSpan sessionStartTime, DateTime? dateTime = null)
	{
		dateTime ??= DateTime.Today;
		var timeTables = DbContext.TimeTableSessions
			.Include(x => x.Teacher)

			.Include(x => x.ClassRoom)

			.Include(x => x.TimeTable)
			.ThenInclude(x => x.Teacher)

			.Include(x => x.TimeTable)
			.ThenInclude(x => x.Level)
			// .ThenInclude(x => x.Schedule)
			// .ThenInclude(x => x.Programs)
			// .ThenInclude(x => x.DaySession)
			//.AsNoTracking()

			.Where(x => x.SessionTime == sessionStartTime &&
										x.SessionDate == dateTime &&
									  x.SessionStatus != SessionStatuses.Canceled)

			.OrderBy(x => x.ClassRoom.ClassRoomName)

			.ToList();
		return timeTables;

	}
	public List<ShokouhPardisTimeTable> GetTimeTables(ShokouhPardisInterval interval, ShokouhPardisWeekDay weekDay)
	{
		return GetTimeTables(interval.Id, weekDay.Id);

	}

	public void AddStudentsToTeacherTimeSheet(ShokouhPardisTimeTable timeTable,
		List<ShokouhPardisStudentClass> selectedStudents)
	{
		try
		{
			foreach (var student in selectedStudents)
			{
				var shokouhPardisTimeTableStudent = new ShokouhPardisTimeTableStudent()
				{
					StudentId = student.Id,
					TimeTableId = timeTable.Id,
					TimeTableStudentsGuid = Guid.NewGuid(),
					TimeTableStudentsLastModified = DateTime.Now
				};
			
				DbContext.ShokouhPardisTimeTableStudents.Add(
					shokouhPardisTimeTableStudent);
				SaveAll();
			}

		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			throw;
		}


	}

	public bool IsStudentInOtherClassesInTheTerm(ShokouhPardisTimeTable timeTable, ShokouhPardisStudentClass student)
	{
		var any = DbContext.ShokouhPardisTimeTableStudents
			.Any(x =>
				x.StudentId == student.Id &&
				x.TimeTable.TermId == timeTable.TermId &&
				x.TimeTable.Id != 3466
			);
		return any;
	}

	public ShokouhPardisTimeTable? GetTimeTable(int timeTableId, Func<IQueryable<ShokouhPardisTimeTable>, IQueryable<ShokouhPardisTimeTable>>? includeQuery = null)
	{
		var dbContextShokouhPardisTimeTables = DbContext.ShokouhPardisTimeTables.AsQueryable();

		IQueryable<ShokouhPardisTimeTable> timeTableQ;
		if (includeQuery is null)
			timeTableQ = dbContextShokouhPardisTimeTables
				.Include(x => x.Sessions)

				.Include(x => x.Schedule)
				.ThenInclude(x => x.Programs)
				.ThenInclude(x => x.DaySession)

				.Include(x => x.Level)
				.Include(x => x.Teacher)
				.Include(x => x.ClassRoom);
		else
			timeTableQ = includeQuery.Invoke(dbContextShokouhPardisTimeTables);

		return timeTableQ.FirstOrDefault(x => x.Id == timeTableId);
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
        var dailyJvs = DbContext.ShokouhPardisDailyJvs.Where(x => x.StudentId == student.Id &&
                                                                  x.TimeTableFk == timeTableItem.Id).ToList();
            if (dailyJvs.Any())
            {
                dailyJvs.ForEach(x => x.TimeTableFk = null);
                dailyJvs.ForEach(x => x.IsPreRegister = true);
            }
            

        DbContext.ShokouhPardisTimeTableStudents.Remove(timeTableStudent);

		SaveAll();
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
		SaveAll();
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
		////SaveAll();
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
            //.AsNoTracking()
			.Include(x => x.Student)
            //.AsNoTracking()
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


	public ShokouhPardisTermClass? GetTermsInRangeToday(DateTime? defDate = null, Func<IQueryable<ShokouhPardisTermClass>, IQueryable<ShokouhPardisTermClass>>? customInclude = null)
	{
		//dateToCheck >= startDate && dateToCheck < endDate;
		var dt = defDate ?? DateTime.Today;

		var query = DbContext.ShokouhPardisTermClasses.AsQueryable();

		if (customInclude is not null)
			query = customInclude(query);

		var termClass = query.FirstOrDefault(x => x.StartDate <= dt && x.EndDate >= dt);
		return termClass;
	}
    public ShokouhPardisYearClass GetYearInRang(int persianYear)
    {
       var query = DbContext.ShokouhPardisYearClasses.AsQueryable();

      var year = query.FirstOrDefault(x => x.YearName  == persianYear.ToString());
        return year;
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

	public int GetTimeTableStudentCount(int timeTableId)
	{
		var xx = DbContext.ShokouhPardisTimeTableStudents
			.Count(x => x.TimeTableId == timeTableId);
		return xx;

	}
	public List<ShokouhPardisStudentClass>? GetTimeTableStudents(int timeTableId)
	{
		var xx = DbContext.ShokouhPardisTimeTableStudents
			.Include(x => x.Student)
			.Where(x => x.TimeTableId == timeTableId)
			.Select(x => x.Student)

			.ToList();
		return xx;

	}
	public List<ShokouhPardisStudentClass>? GetTimeTableStudents(ShokouhPardisTimeTable? timeTable)
	{
		return timeTable == null
			? null
			: GetTimeTableStudents(timeTable.Id);
	}

	public int GetTotalTimeTablesCount(int termTermClassId, string? searchText = null, bool isPrivate = false)
	{
		var dbConntextShokouhPardisTimeTables = DbContext.ShokouhPardisTimeTables
			.Where(x => x.IsPrivate == isPrivate)
			.AsQueryable();
		if (!string.IsNullOrEmpty(searchText))
			dbConntextShokouhPardisTimeTables = dbConntextShokouhPardisTimeTables.Where(x => x.Title.Contains(searchText));


		var count = dbConntextShokouhPardisTimeTables.Count(x => x.TermId == termTermClassId);
		return count;
	}

	public List<ShokouhPardisTimeTable> GetTimeTables(int fromTermId, string? searchText = null,
		int? page = null, int? pageSize = null, Func<IQueryable<ShokouhPardisTimeTable>, IQueryable<ShokouhPardisTimeTable>>? include = null)
	{
		var shokouhPardisTimeTables = ShokouhPardisTimeTablesQuery(fromTermId);

		if (include != null)
			shokouhPardisTimeTables = include(shokouhPardisTimeTables);

		if (!string.IsNullOrEmpty(searchText))
		{
			shokouhPardisTimeTables = shokouhPardisTimeTables.Where(x => x.Title != null && x.Title.Contains(searchText));
		}

		if (page != null && pageSize != null)
		{
			shokouhPardisTimeTables = shokouhPardisTimeTables.Skip((int)(page * pageSize)).Take((int)pageSize);
		}

		return shokouhPardisTimeTables
			.OrderBy(x => x.Schedule.Title)
			.ToList();

	}
	public List<ShokouhPardisTimeTable> GetTimeTables(ShokouhPardisTermClass fromTerm, string? searchText = null,
		int? page = null, int? pageSize = null)
	{
		return GetTimeTables(fromTerm.Id, searchText, page, pageSize);
	}

	IQueryable<ShokouhPardisTimeTable> ShokouhPardisTimeTablesQuery(int fromTermId)
	{
		var shokouhPardisTimeTables = DbContext
			.ShokouhPardisTimeTables
			.Include(x => x.Schedule)
			.Include(x => x.ClassRoom)
			.Include(x => x.Level)
			.Include(x => x.Teacher)
			.Where(x => x.TermId == fromTermId);
		return shokouhPardisTimeTables;

	}
	IQueryable<ShokouhPardisTimeTable> ShokouhPardisTimeTablesQuery(ShokouhPardisTermClass fromTerm)
	{
		return ShokouhPardisTimeTablesQuery(fromTerm.Id);
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
				.Include(x => x.Sessions)
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
				x.Level.LevelName.Contains(searchText) ||
				x.Id.ToString() == searchText
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
            //.AsNoTracking()
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
            //.AsNoTracking()
			.Include(x => x.Student)
            //.AsNoTracking()
			.OrderBy(x => x.Id)
			.Where(x => selDate != null
						&& x.CurrentDate >= selDate.Value.Date
						&& x.CurrentDate < selDate.Value.Date.AddDays(1))
			.AsQueryable();
		if (searchText is not null)
		{
			bool checkPosCodeDone = false;
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
				if (int.TryParse(part, out var code) && !checkPosCodeDone)
				{
					queryable = queryable.Union(queryable.Where(x =>
						(x.PosCode != null && x.PosCode == code)));
					checkPosCodeDone = true;
				}
			}

		}

		var list = queryable.Skip(page * size).Take(size).ToList();
		return list;
	}

	public List<ShokouhPardisDailyJv> GetPagedJvs(int page, int size, int studentId, int selectedTermId,
		string? searchText)
	{
		var baseQuery = DbContext.ShokouhPardisDailyJvs
            //.AsNoTracking()
			.Include(x => x.Student)
            //.AsNoTracking()
			.OrderBy(x => x.PosCode);

		var queryable = baseQuery
			.Where(x => x.StudentId == studentId &&
						x.TermId == selectedTermId)
			.AsQueryable();
		if (searchText is not null)
		{
			bool checkPosCodeDone = false;
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
				if (int.TryParse(part, out var code) && !checkPosCodeDone)
				{
					var Xqueryable = baseQuery
						.Where(x =>
							(x.PosCode != null && x.PosCode == code));
					queryable = queryable.Union(Xqueryable);
					checkPosCodeDone = true;
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
		SaveAll();
		return attachment;
	}

	public bool DeleteAttachment(ShokouhPardisFileAttachment? attachment)
	{
		if (attachment is null)
			return false;

		DbContext.ShokouhPardisFileAttachments.Remove(attachment);
		SaveAll();

		return true;
	}

	public void SaveJvfromSite(ShokouhPardisJvfromSite jvfromSite)
	{
		DbContext.ShokouhPardisJvfromSites.Update(jvfromSite);
		SaveAll();
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
		if (!search.IsNullOrEmpty())
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
		SaveAll();
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

		SaveAll();
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
			SaveAll();

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

	public void SaveTimeTable(ShokouhPardisTimeTable timeTable)
	{
		DbContext.ShokouhPardisTimeTables.Update(timeTable);
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
			SaveAll();
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
			SaveAll();
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
			SaveAll();
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
		SaveAll();
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
		SaveAll();
	}

	public void UpdateEditLevelBookPrice(ShokouhPardisLevelBookPrice levelBookPrice,
		ShokouhPardisTermClass selectedTerm)
	{
		DbContext.ShokouhPardisLevelBookPrices.Update(levelBookPrice);
		SaveAll();
	}

	public bool SaveEditLevelBookPrice(ShokouhPardisLevelBookPrice levelBookPrice,
		ShokouhPardisTermClass selectedTerm)
	{
		var isDuplicate = IsLevelBookPriceDuplicate(levelBookPrice, selectedTerm);
		if (isDuplicate)
			return isDuplicate;

		DbContext.ShokouhPardisLevelBookPrices.Update(levelBookPrice);
		SaveAll();
		return isDuplicate;
	}

	bool IsLevelBookPriceDuplicate(ShokouhPardisLevelBookPrice levelBookPrice,
		ShokouhPardisTermClass selectedTerm)
	{
		var result = DbContext.ShokouhPardisLevelBookPrices.Any(x =>
			x.LevelId == levelBookPrice.LevelId &&
			x.TermId == selectedTerm.Id &&
			x.Id != levelBookPrice.Id);

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

        //var x = dailyJv.Student;
        //var existingEntity = context.Entry(shokouhPardisStudentClass);
        //if (existingEntity != null)
        //{
        //    context.Entry(shokouhPardisStudentClass).State = EntityState.Detached;
        //}

        DbContext.ChangeTracker.Clear();
		DbContext.ShokouhPardisDailyJvs.Update(dailyJv);
		SaveAll();
       // dailyJv.Student = x;
    }

	bool DailyJVDuplicate(ShokouhPardisDailyJv dailyJv)
	{
        
        var result = DbContext.ShokouhPardisDailyJvs
	        .Any(x =>
			x.Fee == dailyJv.Fee &&
			x.StudentId == dailyJv.StudentId &&
			x.FeeFor == dailyJv.FeeFor &&
			x.PaymentType == dailyJv.PaymentType &&
			x.TermId == dailyJv.TermId &&
			x.BillNo == dailyJv.BillNo &&
			x.Id != dailyJv.Id);
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
			SaveAll();
			return false;
		}
		else
		{
			DbContext.PreRegistrations.Remove(pr);
			DbContext.ShokouhPardisDailyJvs.Remove(dailyJv);
			SaveAll();
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
		SaveAll();
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
		SaveAll();
	}

	public List<Permission> GetPermissions()
	{
		var permissions = DbContext.Permissions.Include(x => x.Roles).ToList();
		return permissions;
	}

	public void SavePermission(Permission permission)
	{
		DbContext.Permissions.Update(permission);
		SaveAll();
	}

	public User? GetUserByUserName(string? userName)
	{
		if (userName.IsNullOrEmpty()) return null;
		return DbContext
			.Users
			.Include(x => x.Roles)
			.FirstOrDefault(x => x.UserName == userName);
	}

	public User? GetUserByUseId(int userId)
	{
		return DbContext.Users
			.Include(x => x.Roles)
			.FirstOrDefault(x => x.Id == userId);
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

	public List<TimeTableSession>? GetTimeTableSessions(int timeTableId)
	{
		var sessions = DbContext.TimeTableSessions
			.Include(x => x.ClassRoom)
			.Include(x => x.Teacher)
			.Include(x => x.TimeTable)
			.Include(x => x.ReplacementSession)
			.Where(x => x.TimeTableFk == timeTableId)
			.OrderBy(x => x.SessionDate)
			.ToList();
		return sessions;

	}

	public List<TimeTableSession>? GetTimeTableSessions(ShokouhPardisTimeTable timeTable)
	{
		return GetTimeTableSessions(timeTable.Id);
	}

	public List<TimeTableSession>? GetTimeTableSessionActivitySummary(int timeTableId)
	{
		var sessions = DbContext.TimeTableSessions
			.Include(x => x.ClassRoom)
			.Include(x => x.Teacher)
			.Include(x => x.TimeTable)
			.Include(x => x.ReplacementSession)
			.Where(x => x.TimeTableFk == timeTableId)
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

	public List<TermSessionTemplate> GetTermTemplates(int termId)
	{
		return DbContext.TermSessionTemplates
			.Include(x => x.Term)
			.Where(x => x.TermFk == termId)
			.ToList();
	}

	public void SaveTermSessionTemplate(TermSessionTemplate tst)
	{
		if (tst.Id == 0)
			DbContext.TermSessionTemplates.Add(tst);
		else
			DbContext.TermSessionTemplates.Update(tst);

		SaveAll();
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
		SaveAll();
	}

	public void DeleteTermSessionTemplateDate(TermSessionTemplateDate context)
	{
		DbContext.TermSessionTemplateDates.Remove(context);
		SaveAll();
	}

	public void DeleteTermSessionTemplate(TermSessionTemplate context)
	{
		DbContext.TermSessionTemplates.Remove(context);
		SaveAll();

	}

	public void DeleteTermSessionTemplateDates(TermSessionTemplate context)
	{
		var dates = DbContext.TermSessionTemplateDates.Where(x =>
			x.TermSessionTemplateFk == context.Id);
		DbContext.RemoveRange(dates);
		SaveAll();
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

		SaveAll();

		return entityEntry.Entity;
	}

	public void UpdateTimeTableSession(TimeTableSession session)
	{
		DbContext.TimeTableSessions.Update(session);
		SaveAll();
	}
	public void UpdateTimeTableSessions(IOrderedEnumerable<TimeTableSession> allSessions)
	{
		DbContext.UpdateRange(allSessions);
		SaveAll();
	}

	public TermSessionTemplate? GetTermTemplateByWeekdayIds(ShokouhPardisTermClass? term,
		string weekdayIds)
	{
		var termSessionTemplates = DbContext.TermSessionTemplates
			.SingleOrDefault(x => x.TermFk == term.Id && x.WeekdayIds == weekdayIds);
		return termSessionTemplates;
	}

	public List<SessionActivity> GetGeneralSessionActivities()
	{
		var sessionActivities = DbContext.SessionActivities
			.Where(x =>
					x.Levels == null &&
					x.LevelGroups == null &&
					x.SessionNo == null
				)
			.Include(x => x.ValueOptions)
			.ToList();
		return sessionActivities;
	}

	public void SaveSessionActivity(SessionActivity sessionActivity)
	{
		var entityEntry = DbContext.SessionActivities.Update(sessionActivity);
		SaveAll();
	}

	public ShokouhPardisInterval? GetIntervalById(int intervalId)
	{
		var shokouhPardisInterval = DbContext.ShokouhPardisIntervals.Find(intervalId);
		return shokouhPardisInterval;

	}

	public ShokouhPardisInterval? GetInterval(int termId, TimeSpan time, TimeSpan offset)
	{
		//throw new NotImplementedException();
		var interval = DbContext.ShokouhPardisIntervals.FirstOrDefault(x =>
			x.TermId == termId && time.Subtract(offset) >= x.StartTime && time.Add(offset) <= x.EndTime);
		return interval;
	}

	public ShokouhPardisInterval? GetInterval(ShokouhPardisTermClass term, TimeSpan time, TimeSpan offset)
	{
		return GetInterval(term.Id, time, offset);
	}

	public ShokouhPardisTeacherClass? GetTeacherByUserId(int? userId)
	{
		var teacher = DbContext.ShokouhPardisTeacherClasses
			.SingleOrDefault(x => x.UserId == userId);
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

	public ShokouhPardisTimeTable? GetTeacherTimeTable(int termId, int teacherId, int weekdayId, int intervalId)
	{
		var tt = DbContext
			.ShokouhPardisTimeTables
			.Include(x => x.ClassRoom)
			.Include(x => x.Level)
			.Include(x => x.Sessions)
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

	public TimeTableSession GetTimeTableSessionById(int sessionId, Func<IQueryable<TimeTableSession>, IQueryable<TimeTableSession>>? customInclude = null)
	{
		var query = DbContext.TimeTableSessions.AsQueryable();
		if (customInclude != null)
			query = customInclude(query);
		var timeTableSession = query.FirstOrDefault(x => x.Id == sessionId);
		return timeTableSession!;
	}

	public TimeTableSession? GetTimeTableSession(int timetableId, DateTime dateTime, Func<IQueryable<TimeTableSession>, IQueryable<TimeTableSession>>? customInclude = null)
	{
		var session = DbContext.TimeTableSessions
			.AsQueryable();

		if (customInclude != null)
			session = customInclude(session);

		var result = session.FirstOrDefault(x =>
				x.TimeTableFk == timetableId
				&& x.SessionDate == dateTime);

		return result;

	}


	public TimeTableSession? GetTimeTableSession(ShokouhPardisTimeTable? timetable, DateTime dateTime)
	{
		if (timetable == null) return null;

		return GetTimeTableSession(timetable.Id, dateTime
			// , query => {
			// return query
			// 	.Include(x => x.TimeTable)
			// 	.ThenInclude(x => x.Level)
			// 	.Include(x => x.TimeTable)
			// 	.ThenInclude(x => x.Teacher)
			// 	.Include(x => x.TimeTable)
			// 	.ThenInclude(x => x.ClassRoom)
			// 	.Include(x => x.TimeTable)
			// 	.ThenInclude(x => x.Schedule)
			// 	.Include(x => x.TimeTable)
			// 	.ThenInclude(x => x.Sessions);
			// }
			);
	}

	public List<SessionActivity> GetGeneralSessionActivities(TimeTableSession? session)
	{
		if (session is null) return null;

		var sessionActivitiesQuery = DbContext
			.SessionActivities
			//.AsNoTrackingWithIdentityResolution()
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

	public StudentSessionActivity? GetStudentSessionActivity(int ssaId)
	{
		var studentSessionActivity = DbContext.StudentSessionActivities.Find(ssaId);
		return studentSessionActivity;

	}
	public void SaveStudentSessionActivity(StudentSessionActivity activity)
	{
		DbContext.StudentSessionActivities.Update(activity);
		SaveAll();

		//DbContext.Entry(activity).Reload();
	}

	public List<StudentSessionActivity> GetStudentSessionActivityPerformed(int ttSessionid, Func<IQueryable<StudentSessionActivity>, IQueryable<StudentSessionActivity>>? include = null)
	{
		var activities = DbContext.StudentSessionActivities.AsQueryable();
		if (include != null)
			activities = include(activities);

		var list = activities.Where(x => x.ActivityDeletedDateTime == null &&
															x.TimeTableSessionFk == ttSessionid)
			.ToList();
		return list;
	}

	public List<StudentSessionActivity> GetTimetableStudentsSessionActivities(int timetableId)
	{
		var result =
			DbContext
				.StudentSessionActivities
				.Include(x => x.TimeTableSession)
				.Include(x => x.Activity)
				.ThenInclude(x => x.ValueOptions)
				.Where(x => x.ActivityDeletedDateTime == null && x.TimeTableFk == timetableId)
				.ToList();
		return result;
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
		SaveAll();
	}

	public SessionActivity? GetDefaultSessionActivity()
	{
		var sessionActivity = DbContext.SessionActivities
			//.AsNoTrackingWithIdentityResolution()
			.Include(x => x.ValueOptions)
			.FirstOrDefault(x => x.IsDefault == true) ??
							  DbContext.SessionActivities
							 //.AsNoTrackingWithIdentityResolution()
							 .Include(x => x.ValueOptions)
							 .OrderBy(x => x.Id)
							 .FirstOrDefault();
		return sessionActivity;
	}
	public SessionActivity? GetSessionActivity(int sessionActivityId)
	{
		var sessionActivity = DbContext.SessionActivities

			.Include(x => x.ValueOptions)
			//.AsNoTracking()

			.First(x => x.Id == sessionActivityId);
		return sessionActivity;
	}

	public void DeleteSessionActivityValueOption(SessionActivityValueOption vo)
	{
		var sessionActivity = DbContext.SessionActivityValueOptions.Remove(vo);
		SaveAll();


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
		SaveAll();
		return isDuplicate;
	}

	bool PreRegistrationDuplicate(PreRegistration preRegistration)
	{

		var result = DbContext.PreRegistrations.Any(x =>
			x.LevelFk == preRegistration.LevelFk &&
			x.DailyJVFk == preRegistration.DailyJVFk &&
			x.StudentFk == preRegistration.StudentFk &&
			x.TermFk == preRegistration.TermFk &&
			x.Id != preRegistration.Id);
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
			SaveAll();
		}

		return isDuplicate;
	}

	bool LessonPlanDuplicate(LessonPlan lessonPlan)
	{
		var result = DbContext.LessonPlans.Any(x =>
			x.LevelFk == lessonPlan.LevelFk &&
			x.SessionNumber == lessonPlan.SessionNumber &&
			x.Id != lessonPlan.Id);
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
		SaveAll();

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
            x.IsPreRegister = false;
        }
		DbContext.UpdateRange(shokouhPardisDailyJvs);
		SaveAll();
	}

	public void SetActivityDeleteTime(StudentSessionActivity sac)
	{
		sac.ActivityDeletedDateTime = DateTime.Now;


		DbContext.StudentSessionActivities.Update(sac);
		SaveAll();

		try
		{

		}
		catch (Exception e)
		{
			Console.WriteLine(e);
		}
	}

	public List<LessonPlanSection>? GetLessonPlanSection(LessonPlan lessonPlan)
	{
		if (lessonPlan is null)
			return null;
		return DbContext.LessonPlanSections
			.Include(x => x.SectionType)
			.Where(x => x.LessonPlanFk == lessonPlan.Id).ToList();
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
		SaveAll();
	}

	public ShokouhPardisTermClass? GetTerm(int i)
	{
		return DbContext.ShokouhPardisTermClasses
			.FirstOrDefault(x => x.Id == i);
	}
    public int? GetTermId(ShokouhPardisTermClass nextTerm)
    {
        return DbContext.ShokouhPardisTermClasses
            .FirstOrDefault(x => x.Id == nextTerm.Id)
            ?.Id;
    }
    public ShokouhPardisTermClass? GetLatestTerm()
	{
		return DbContext
			.ShokouhPardisTermClasses
			.OrderBy(x => x.EndDate)
			.LastOrDefault();
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
    public List<ChartSeries> GetStudentCountsByGenderAndDate(DateTime dateFrom, DateTime dateTo)
    {
        var students = DbContext.ShokouhPardisStudentClasses
            .Where(s => s.CreatedWhen >= dateFrom && s.CreatedWhen <= dateTo)
            .GroupBy(s => new { s.CreatedWhen.Date, s.Gender })
            .Select(g => new
            {
                Date = g.Key.Date,
                Gender = g.Key.Gender,
                Count = g.Count()
            })
            .ToList();

        var dates = Enumerable.Range(0, (dateTo - dateFrom).Days + 1)
            .Select(offset => dateFrom.AddDays(offset))
            .ToList();

        var boysData = dates.Select(d => students.FirstOrDefault(s => s.Date == d && s.Gender == true)?.Count ?? 0).ToList();
        var girlsData = dates.Select(d => students.FirstOrDefault(s => s.Date == d && s.Gender == false)?.Count ?? 0).ToList();
        var unknownData = dates.Select(d => students.FirstOrDefault(s => s.Date == d && s.Gender == null)?.Count ?? 0).ToList();

        var chartSeries = new List<ChartSeries>
        {
            new ChartSeries { Name = "Boys", Data = boysData.Select(count => (double)count).ToArray() },
            new ChartSeries { Name = "Girls", Data = girlsData.Select(count => (double)count).ToArray() },
            new ChartSeries { Name = "Unknown", Data = unknownData.Select(count => (double)count).ToArray() }
        };

        return chartSeries;
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

	public void StudentMove(ShokouhPardisTimeTable sourceTT,
							ShokouhPardisTimeTable destinationTT,
							ShokouhPardisStudentClass student)
	{
		//add New
		var currentRecord = DbContext.ShokouhPardisTimeTableStudents.FirstOrDefault
		(x => x.TimeTableId == sourceTT.Id &&
			x.StudentId == student.Id);
		var dailyJvs = DbContext.ShokouhPardisDailyJvs.Where(x => x.StudentId == student.Id &&
																			 x.TimeTableFk == sourceTT.Id).ToList();

		if (currentRecord != null)
		{
			if (dailyJvs.Any())
			{
				dailyJvs.ForEach(x => x.TimeTableFk = destinationTT.Id);
			}
			currentRecord.TimeTableId = destinationTT.Id;

			//DbContext.Update(currentRecord);
			SaveAll();
		}

	}

	public void RegisterAdvanceUser(AdvanceRegistration advanceRegistration)
	{

		DbContext.AdvanceRegistrations.Add(advanceRegistration);
		SaveAll();

	}

	public void InactiveUser(string userName)
	{
		var user = DbContext.Users.FirstOrDefault(x => x.UserName == userName);
		if (user is null) return;

		user.IsActive = false;
		SaveAll();
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

	public IEnumerable<ShokouhPardisTeacherClass> GetTeachersInInterval(int termId, int wdId, int intervalId)
	{
		var list = DbContext.ShokouhPardisTeacherTimeSheets
			.Include(x => x.Teacher)
			.Where(x =>
				x.TermId == termId &&
				x.WeekDayId == wdId &&
				x.IntervalId == intervalId)
			.Select(x => x.Teacher)
			.ToList();

		return list;
	}

	public List<TimeTableSession> GetTimeTableSessions(List<ShokouhPardisTimeTable> timeTables)
	{
		var list = timeTables.Select(z => z.Id).ToList();

		var timeTableSessions = DbContext
			.TimeTableSessions
			.Where(x => list.Contains(x.Id))
			.ToList();
		return timeTableSessions;

	}

	public void UpdateTerm(ShokouhPardisTermClass term)
	{
		DbContext.ShokouhPardisTermClasses.Update(term);
		SaveAll();
	}

	public ShokouhPardisStudentClass? GetStudent(int id)
	{
		var student = DbContext.ShokouhPardisStudentClasses.FirstOrDefault(x => x.Id == id);
		return student;
	}

	public void UpdateStudent(ShokouhPardisStudentClass student)
	{
		DbContext.ShokouhPardisStudentClasses.Update(student);
		SaveAll();

	}

	public ShokouhPardisTeacherClass? GetTeacher(int id)
	{
		return DbContext.ShokouhPardisTeacherClasses.Find(id);
	}

	public SessionActivityValueOption? GetSessionActivityValueOption(int id)
	{
		var sessionActivityValueOption = DbContext.SessionActivityValueOptions.Find(id);
		return sessionActivityValueOption;
	}

	public List<LessonPlanSectionType> GetSectionType()
	{
		return DbContext.LessonPlanSectionTypes.ToList();
	}

	public bool SaveEditlessonPlanSection(LessonPlanSection section)
	{
		bool isDuplicate = LessonPlanSectionDuplicate(section);
		if (isDuplicate)
		{

		}
		else
		{
			DbContext.LessonPlanSections.Update(section);
			SaveAll();
		}

		return isDuplicate;
	}

	bool LessonPlanSectionDuplicate(LessonPlanSection section)
	{
		var result = DbContext.LessonPlanSections.Any(x =>
			x.LessonPlanFk == section.LessonPlanFk &&
			x.SectionTypeFk == section.SectionTypeFk &&
			x.Id != section.Id);

		return result;
	}

	public void SaveSectionType(LessonPlanSectionType sectionType)
	{
		DbContext.LessonPlanSectionTypes.Update(sectionType);
		SaveAll();
	}

	public SessionActivityValueOption? GetSessionActivityValueOptionByValue(int sessionActivityid, string value)
	{
		var sessionActivityValueOption =
			DbContext.SessionActivityValueOptions.FirstOrDefault(x =>
				x.SessionActivityFk == sessionActivityid && x.Value == value);
		return sessionActivityValueOption;
	}

	public Dictionary<string, List<ShokouhPardisTimeTable>> GetTermTimeTablesGroupBySchedule(int termId, IEnumerable<int> weekdayIds, string? search)
	{
		var query = DbContext
			.ShokouhPardisTimeTables
			.Include(x => x.Schedule)
			.Where(x => x.TermId == termId &&
						x.Schedule.Programs.Any(p => weekdayIds.Contains(p.DaySession.WeekdayId)));
		if (!search.IsNullOrEmpty())
		{
			query = query.Where(x => search != null && x.Schedule.Title.Contains(search));
		}
		var groupBy = query.GroupBy(x => x.Schedule.Title)
		.ToDictionary(x => x.Key, y => y.ToList())
		;
		return groupBy;
	}

	public IEnumerable<ShokouhPardisTimeTable> GetTermTimeTablesInWeekdays(int termId,
		IEnumerable<int> weekdayIds,
		string? search,
		Func<IQueryable<ShokouhPardisTimeTable>, IQueryable<ShokouhPardisTimeTable>>? includeQuery = null)
	{
		var query = DbContext
				.ShokouhPardisTimeTables
				.Where(x => x.TermId == termId
												&& x.Schedule.Programs.All(p => weekdayIds.Contains(p.DaySession.WeekdayId))
												);

		if (!search.IsNullOrEmpty())
			query = query.Where(x => search != null && x.Schedule.Title.Contains(search));

		if (includeQuery is not null)
			query = includeQuery(query);


		return query.ToArray();
	}

	public void DeleteSessionActivity(SessionActivity context)
	{
		var activity = DbContext.SessionActivities.FirstOrDefault(x => x.Id == context.Id);
		if (activity != null)
		{
			DbContext.SessionActivities.Remove(activity);

			SaveAll();
		}


	}

	public List<SessionActivityValueOption> GetSessionActivityValueOptions(int sessionActivityId)
	{
		return DbContext.SessionActivityValueOptions
			.Where(x => x.SessionActivityFk == sessionActivityId)
			.ToList();
	}

    public bool GetPreRegisterStudentByTerm(int termId, int studentId)
    {
        var result = DbContext.PreRegistrations.Any(x =>
        x.TermFk == termId &&
            x.StudentFk == studentId);
        return result;
    }

    public ShokouhPardisLevelClass GetPreRegistrationLevel(int studentId, int termId)
    {
        var result = DbContext.PreRegistrations.First(x =>
            x.TermFk == termId &&
            x.StudentFk == studentId).Level;
        return result;

    }

    public bool SaveEditClassRoom(ShokouhPardisClassRoom classRoom)
    {
        bool isDuplicate = ClassRoomDuplicate(classRoom);
        if (isDuplicate)
        {
            
        }
        else
        {
            DbContext.ShokouhPardisClassRooms.Update(classRoom);
            SaveAll();
        }

        return isDuplicate;
    }

    bool ClassRoomDuplicate(ShokouhPardisClassRoom classRoom)
    {
        var result = DbContext.ShokouhPardisClassRooms.Any(x =>
            x.ClassRoomName == classRoom.ClassRoomName &&
			x.Id <= 0
            );
        return result;
    }

   

    public ShokouhPardisTimeTable? GetTimeTableByTermId(int? lastTermId, int studentId)
    {
	    var TTS= DbContext.ShokouhPardisTimeTableStudents.FirstOrDefault(
		    x => x.TimeTable.TermId == lastTermId
		         && x.StudentId == studentId);
        if (TTS is null)
        {
            return null;
        }
	    return DbContext.ShokouhPardisTimeTables
		    .Include(x=>x.Level)
            .Include(x=>x.Term)
		    .FirstOrDefault(x => x.Id == TTS.TimeTableId);
    }

    public bool SaveEditTerm(ShokouhPardisTermClass Term)
    {
        bool isDuplicate = TermDuplicate(Term);
        if (isDuplicate)
        {

        }
        else
        {
            DbContext.ShokouhPardisTermClasses.Update(Term);
            SaveAll();
        }

        return isDuplicate;
    }

    bool TermDuplicate(ShokouhPardisTermClass Term)
    {
        var result = DbContext.ShokouhPardisTermClasses.Any(x =>
            x.TermName == Term.TermName &&
            x.Id <= 0
        );
        return result;
    }


    public void ChangeTimeTableIdAndDailyJVTimeTableId(int studentId, int termId)
    {
        try
        {
            var sql = "Update TimeTableStudent Set ";
            var timeTableStudent = DbContext.ShokouhPardisTimeTableStudents
                .First(x => x.StudentId == studentId &&
                            x.TimeTable.TermId == termId);
            timeTableStudent.TimeTableId = 3466;
            DbContext.ShokouhPardisTimeTableStudents.Update(timeTableStudent);
            var dailyJvs = DbContext.ShokouhPardisDailyJvs
                .Where(x => x.StudentId == studentId && x.TermId == termId).ToList();
            foreach (var dJv in dailyJvs)
            {
                dJv.TimeTableFk = 3466;
            }
            DbContext.ShokouhPardisDailyJvs.UpdateRange(dailyJvs);
            SaveAll();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }
    IDbContextTransaction? _transaction;

	public void CreateTransaction()
    {

	    _transaction ??= DbContext.Database.BeginTransaction();
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


}

