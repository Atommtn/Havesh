using Havesh.Domain.Services;
using Havesh.Model.Model;
using HaveshApp.Admin.Authentication;
using HaveshApp.Classes.Auth;
using MudBlazor;

namespace HaveshApp.Admin.Dashboard.Widgets.Supervisor;

public class SupervisorWidgetsService : WidgetServiceBase
{
	private readonly DataProviderService _dataProvider;
	private readonly ISnackbar _snackBar;
	private readonly UserSessionService _userSession;
	private List<ShokouhPardisTimeTable> _timeTables;

	private IEnumerable<ShokouhPardisTeacherClass>? _teachers;
	private ShokouhPardisTermClass? _term;
	private ShokouhPardisWeekDay? _weekday;
	private ShokouhPardisInterval? _interval;

	List<TimeTableSession> _timeTableSessions;
	public List<TimeTableSession> TimeTableSessions => _timeTableSessions;

	List<SessionActivity> _sessionActivities;
	public List<SessionActivity> SessionActivities => _sessionActivities;
	
	public SupervisorWidgetsService(
		DataProviderService dataProvider,
		ISnackbar snackBar,
		UserSessionService userSession)
	{
		_dataProvider = dataProvider;
		_snackBar = snackBar;
		_userSession = userSession;


		ReloadData();
	}

	//readonly DateTime _dateTime = DateTime.Today;
	readonly DateTime _dateTime = DateTime.Today.AddDays(0);

	public List<ShokouhPardisTimeTable> IntervalTimeTables => _timeTables;
	public List<ShokouhPardisClassRoom> IntervalClassrooms => _timeTables.Select(x=>x.ClassRoom).ToList();

	private void ReloadData()
	{
		_term = GetCurrentTerm();

		_weekday = GetWeekday();

		if (_term is null || _weekday == null )
		{
			_snackBar.Add("There is Lack of Infromation !");
			return;
		}
		_interval = GetCurrentInterval(_term);

		if (_interval == null)
		{
			_snackBar.Add("There is Lack of Infromation In Interval !");
			return;
		}

		_teachers = GetTeachers(_term.Id, _weekday.Id, _interval.Id);

		if (_interval is null || _teachers is null)
			return;
		
		_timeTables = _dataProvider.GetTimeTables(_interval,_weekday);

		_timeTableSessions = _dataProvider.GetTimeTableSessions(_timeTables);
		_sessionActivities = _dataProvider.GetSessionActivities();


		/*
		_students = _dataProvider.GetTimeTableStudents(_timeTable);

		if (_students != null && _timeTable != null)
			_timeTable.StudentsCount = _students.Count();

	*/
	}

	public ShokouhPardisTermClass? GetCurrentTerm()
	{
		var term = _dataProvider.GetTermsInRangeToday(_dateTime);
		return term;
	}

	public IEnumerable<ShokouhPardisTeacherClass> GetTeachers(int termId, int weekdayId, int intervalId)
	{
		var teachers = _dataProvider.GetTeachersInInterval(termId, weekdayId, intervalId);
		return teachers;
	}

	public ShokouhPardisTimeTable? GetTeacherTimeTable(int teacherId)
	{
		_term ??= _dataProvider.GetTermsInRangeToday();
		_weekday ??= GetWeekday();
		if (_term == null) return null;

		_interval ??= GetCurrentInterval(_term);
		if (_interval == null) return null;

		_teachers ??= GetTeachers(_term.Id, _weekday.Id, _interval.Id);
		return _dataProvider.GetTeacherTimeTable(_term.Id, teacherId, _weekday.Id, _interval.Id);
	}

	public ShokouhPardisWeekDay GetWeekday()
	{
#if DEBUG
		var weekday = Environment.GetEnvironmentVariable("FRZ_TEST") == "true" 
				? _dataProvider.GetTodayWeekday(0)
				: _dataProvider.GetTodayWeekday();
#else
		var weekday = _dataProvider.GetTodayWeekday();

#endif
		return weekday;
	}

	public ShokouhPardisInterval? CurrentInterval => GetCurrentInterval();

	public ShokouhPardisInterval? GetCurrentInterval(ShokouhPardisTermClass? term = null)
	{
		term ??= GetCurrentTerm();
		// _TODO: Should be remark ->
#if DEBUG
		var startTime = // DateTime.Now;
			Environment.GetEnvironmentVariable("FRZ_TEST") == "true" 
			? TimeSpan.Parse("14:00") 
			: DateTime.Now.TimeOfDay;
#else
		var startTime = DateTime.Now.TimeOfDay;
#endif


		var offset = TimeSpan.FromMinutes(3);
		var interval = _dataProvider.GetInterval(term, startTime, offset);
		return interval;
	}

	public ShokouhPardisInterval? GetNextInterval(ShokouhPardisTermClass term)
	{
		// _TODO: Should be remark ->
		//var startTime = TimeSpan.Parse("14:00");// DateTime.Now;
		var startTime = DateTime.Now.TimeOfDay;
		var minStep = 15;
		var offset = TimeSpan.FromMinutes(minStep);

		ShokouhPardisInterval? interval;
		while (true)
		{
			offset = offset.Add(TimeSpan.FromMinutes(minStep));
			interval = _dataProvider.GetInterval(term, startTime, offset);

			if (interval != null)
				break;

		}
		return interval;
	}



}