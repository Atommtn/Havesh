using Havesh.Domain.Services;
using Havesh.Model.Model;
using HaveshApp.Admin.Authentication;
using HaveshApp.Classes.Auth;
using Microsoft.AspNetCore.Http;
using MudBlazor;

namespace HaveshApp.Admin.Dashboard.Widgets.Teacher
{
    public class TeacherWidgetsService
    {
        private readonly DataProviderService _dataProvider;
        private readonly ISnackbar _snackBar;
        private readonly UserSessionService _userSession;

        public ShokouhPardisTimeTable CurrentTeacherTimetable
        {
            get
            {
                _timeTable ??= GetTeacherTimeTable();
                return _timeTable!;
            }
        }

        public TimeTableSession CurrentSession => _session ??= GetTimeTableSession(_timeTable ??= GetTeacherTimeTable());


        private ShokouhPardisTimeTable? _timeTable;
        private TimeTableSession? _session;
        private List<SessionActivity> _activities;
        private ShokouhPardisTeacherClass? _teacher;
        private ShokouhPardisInterval? _interval;
        private ShokouhPardisWeekDay? _weekday;
        private ShokouhPardisTermClass? _term;
        private IEnumerable<ShokouhPardisStudentClass>? _students;
        public IEnumerable<ShokouhPardisStudentClass>? Students => _students;
        public IEnumerable<SessionActivity> SessionActivities => _activities;

        public TeacherWidgetsService(
            DataProviderService dataProvider,
            ISnackbar snackBar,
            UserSessionService userSession)
        {
            _dataProvider = dataProvider;
            _snackBar = snackBar;
            _userSession = userSession;


            ReloadData();
        }

        readonly DateTime _dateTime = DateTime.Today.AddDays(-1);

        private void ReloadData()
        {
            _term = _dataProvider.GetTermsInRangeToday(_dateTime);

            if (_term is null)
            {
                _snackBar.Add("There is not any Term in today range");
                return;
            }

            _teacher = GetTeacher();

            _interval = GetInterval(_term);

            if (_interval is null || _teacher is null)
                return;

            _weekday = GetWeekday();
            _timeTable = GetTeacherTimeTable();
            _students = _dataProvider.GetTimeTableStudents(_timeTable);
            if (_students != null && _timeTable != null)
                _timeTable.StudentsCount = _students.Count();

            _session = GetTimeTableSession(_timeTable);
            if (_session != null)
            {
                _activities = _dataProvider.GetSessionActivities(_session);
            }
        }

        private ShokouhPardisTimeTable? GetTeacherTimeTable()
        {
            _term ??= _dataProvider.GetTermsInRangeToday();
            _teacher ??= GetTeacher();
            _weekday ??= GetWeekday();
            if (_term == null) return null;

            _interval ??= GetInterval(_term);
            return _dataProvider.GetTeacherTimeTable(_term,
                _teacher,
                _weekday,
                _interval);

        }

        private TimeTableSession GetTimeTableSession(ShokouhPardisTimeTable? shokouhPardisTimeTable)
        {
            return _dataProvider.GetTimeTableSession(shokouhPardisTimeTable, _dateTime) ?? new TimeTableSession() { };
        }

        private ShokouhPardisWeekDay GetWeekday()
        {
            //var weekday = _dataProvider.GetTodayWeekday();
            var weekday = _dataProvider.GetTodayWeekday(0);
            return weekday;
        }

        private ShokouhPardisInterval? GetInterval(ShokouhPardisTermClass term)
        {
            // _TODO: Should be remark ->
            var startTime = TimeSpan.Parse("14:00");// DateTime.Now;


            //var startTime = DateTime.Now.TimeOfDay;
            var fromMinutes = TimeSpan.FromMinutes(3);
            var interval = _dataProvider.GetInterval(term, startTime, fromMinutes);
            return interval;
        }

        private ShokouhPardisTeacherClass? GetTeacher()
        {
            //_UserDo = ProviderService.GetLog();
            var payload = _userSession.Payload;
            if (!(payload?.Roles?.Contains(AuthorizeRolesConstant.Teacher) ?? false))
                return null;

            var teacher = _dataProvider.GetTeacherByUserId(_userSession.User?.Id);
            return teacher;
        }
    }

}
