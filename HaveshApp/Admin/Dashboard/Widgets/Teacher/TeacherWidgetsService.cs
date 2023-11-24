using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Entity;
using Havesh.GrainInterfaces.Manager;
using Havesh.Grains;
using Havesh.Grains.Common;
using Havesh.Grains.Entity;
using Havesh.Grains.Manager;
using Havesh.Model.Model;
using HaveshApp.Admin.Authentication;
using HaveshApp.Classes.Auth;
using Microsoft.AspNetCore.Http;
using MudBlazor;
using System.Xml;

namespace HaveshApp.Admin.Dashboard.Widgets.Teacher
{
	public class TeacherWidgetsService : WidgetServiceBase
	{

		public TeacherWidgetsService(
			IClusterClient clusterClient,
			UserSessionService userSession) 
				: base(clusterClient, userSession)
		{
		}

		public async Task<ShokouhPardisTeacherClass?> GetTeacher()
		{
			if (UserSession.User == null)
				return null;

			var teacherManagerGrain = ClusterClient.GetGrain<ITeacherManagerGrain>(Guid.Empty);
			var userGrain = ClusterClient.GetGrain<IHaveshGrain<User>>(UserSession.User.Id);
			var user = await userGrain.Get();
			var teacher = await teacherManagerGrain.GetTeacherByUserId(user?.Id);

			return teacher;

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
			return await GetTimeTableSessionActivities(timeTable);
		}


		public async Task<TimeTableSession?> GetTimeTableSession()
		{
			ShokouhPardisTimeTable? timeTable = await GetTeacherTimeTable();
			return await GetTimeTableSession(timeTable);
		}




	}

}
