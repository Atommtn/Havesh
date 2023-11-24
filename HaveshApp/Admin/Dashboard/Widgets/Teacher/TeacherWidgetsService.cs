using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Entity;
using Havesh.GrainInterfaces.Manager;
using Havesh.Grains;
using Havesh.Grains.Entity;
using Havesh.Grains.Manager;
using Havesh.Model.Model;
using HaveshApp.Admin.Authentication;
using HaveshApp.Classes.Auth;
using Microsoft.AspNetCore.Http;
using MudBlazor;

namespace HaveshApp.Admin.Dashboard.Widgets.Teacher
{
	public class TeacherWidgetsService : WidgetServiceBase
	{
		IClusterClient ClusterClient { get; }
		private readonly ISnackbar _snackBar;
		private readonly UserSessionService _userSession;

		public TeacherWidgetsService(
			IClusterClient clusterClient,
			ISnackbar snackBar,
			UserSessionService userSession)
		{
			ClusterClient = clusterClient;
			_snackBar = snackBar;
			_userSession = userSession;
		}

#if DEBUG
		readonly DateTime _dateTime = new(2023 , 11 , 26);
#else
		readonly DateTime _dateTime = DateTime.Today;
#endif

		public async Task<ShokouhPardisTermClass?> GetTerm()
		{
			var termManager = ClusterClient.GetGrain<ITermGrainManager>(Guid.Empty);
			var term = await termManager.GetTermsInRangeToday(_dateTime);
			
			if(term == null) 
				_snackBar.Add("There is not any Term in today range");

			return term;
		}

		public async Task<int> GetClassSessionStudentCount()
		{
			var teacherTimeTable = await GetTeacherTimeTable();
			if (teacherTimeTable == null) 
				return 0;

			var timeTableGrain = ClusterClient.GetGrain<ITimeTableGrain>(teacherTimeTable.Id);
			return await timeTableGrain.GetStudentCount();
		}

		public async Task<ShokouhPardisTimeTable?> GetTeacherTimeTable()
		{
			var term = await GetTerm();
			var teacher = await GetTeacher();
			var weekday = await GetWeekday();
			var interval = await GetInterval(term);
			var timeTableManagerGrain = ClusterClient.GetGrain<ITimeTableManagerGrain>(Guid.Empty);
			if (term == null || teacher == null || interval == null) return null;

			var timeTable = await timeTableManagerGrain.GetTeacherTimeTable(term.Id, teacher.Id, weekday.Id, interval.Id);
			return timeTable;
		}
		public async Task<IEnumerable<ShokouhPardisStudentClass>?> GetTimeTableStudents()
		{
			var term = await GetTerm();
			var teacher = await GetTeacher();
			var weekday = await GetWeekday();
			var interval = await GetInterval(term);
			var timeTableManagerGrain = ClusterClient.GetGrain<ITimeTableManagerGrain>(Guid.Empty);
			if (term == null || teacher == null || interval == null) return null;

			var timeTable = await timeTableManagerGrain.GetTeacherTimeTable(term.Id, teacher.Id, weekday.Id, interval.Id);
			if (timeTable == null) return null;

			var timeTableGrain = ClusterClient.GetGrain<ITimeTableGrain>(timeTable.Id);
			var students = await timeTableGrain.GetStudents();
			return students;

		}

		public async Task<IEnumerable<SessionActivity>?> GetTimeTableSessionActivities()
		{
			var timeTable = await GetTeacherTimeTable();
			if (timeTable == null) return null;

			var timeTableGrain = ClusterClient.GetGrain<ITimeTableGrain>(timeTable.Id);
			var timeTableSession = await timeTableGrain.GetTodaySession();
			if (timeTableSession == null) return null;

			var sessionGrain = ClusterClient.GetGrain<ISessionGrain>(timeTableSession.Id);
			var activities = await sessionGrain.GetActivities();
			return activities;

		}

		public async Task<TimeTableSession?> GetTimeTableSession()
		{
			var timeTable = await GetTeacherTimeTable();
			var timeTableGrain = ClusterClient.GetGrain<ITimeTableGrain>(timeTable.Id);
			var timeTableSession = await timeTableGrain.GetTodaySession();
			return timeTableSession;
		}

		public async Task<ShokouhPardisWeekDay> GetWeekday()
		{
#if DEBUG
			var weekdayManagerGrain = ClusterClient.GetGrain<IWeekdayManagerGrain>(Guid.Empty);
			
			var weekday = Environment.GetEnvironmentVariable("FRZ_TEST") == "true"
				? await weekdayManagerGrain.GetTodayWeekDay(0)!
				: await weekdayManagerGrain.GetTodayWeekDay()!;
#else
			var weekday = await weekdayManagerGrain.GetTodayWeekDay()!;
#endif
			return weekday;
		}

		public async Task<ShokouhPardisInterval?> GetInterval(ShokouhPardisTermClass? term = null)
		{
			// _TODO: Should be remark ->
			//var startTime = TimeSpan.Parse("14:00");// DateTime.Now;
#if DEBUG
			var startTime = // DateTime.Now;
				Environment.GetEnvironmentVariable("FRZ_TEST") == "true"
					? TimeSpan.Parse("14:00")
					: DateTime.Now.TimeOfDay;
#else
			var startTime = DateTime.Now.TimeOfDay;
#endif

			term ??= await GetTerm();
			var termGrain = ClusterClient.GetGrain<ITermGrain>(term.Id);
			var fromMinutes = TimeSpan.FromMinutes(3);
			return await termGrain.GetIntervalByStartTime(startTime , fromMinutes);
		}

		public async Task<ShokouhPardisTeacherClass?> GetTeacher()
		{
			if (_userSession.User == null) 
				return null;

			var teacherManagerGrain = ClusterClient.GetGrain<ITeacherManagerGrain>(Guid.Empty);
			var userGrain = ClusterClient.GetGrain<IHaveshGrain<User>>(_userSession.User.Id);
			var user = await userGrain.Get();
			var teacher = await teacherManagerGrain.GetTeacherByUserId(user?.Id);

			return teacher;

		}
	}

}
