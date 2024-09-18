using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface ITimeTableGrain : IGrainWithStringKey
{
	Task<int> GetStudentCount();
	Task<IEnumerable<ShokouhPardisStudentClass>?> GetStudents();
	Task<IEnumerable<TimeTableSession>?> GetSessions();
	Task<TimeTableSession?> GetTodaySession(DateTime? dateTime = null);
}