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

	private IEnumerable<ShokouhPardisTeacherClass>? _teachers;
	private ShokouhPardisTermClass? _term;
	private ShokouhPardisWeekDay? _weekday;
	private ShokouhPardisInterval? _interval;

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
	readonly DateTime _dateTime = DateTime.Today.AddDays(1);



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

		/*
		_timeTable = GetTeacherTimeTable(0);
		_students = _dataProvider.GetTimeTableStudents(_timeTable);

		if (_students != null && _timeTable != null)
			_timeTable.StudentsCount = _students.Count();

		_session = GetCurrentTimeTableSession(_timeTable);
		if (_session != null)
		{
			_activities = _dataProvider.GetSessionActivities(_session);
		}
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

	public TimeTableSession GetCurrentTimeTableSession(ShokouhPardisTimeTable? shokouhPardisTimeTable)
	{
		return _dataProvider.GetTimeTableSession(shokouhPardisTimeTable, _dateTime) 
		       ?? new TimeTableSession() { };
	}

	public ShokouhPardisWeekDay GetWeekday()
	{
		//var weekday = _dataProvider.GetTodayWeekday();
		var weekday = _dataProvider.GetTodayWeekday(0);

		return weekday;
	}

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