using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface ITimeTableSessionGrain : IGrainWithStringKey
{
	Task<IEnumerable<StudentSessionActivity>?> GetStudentSessionActivities();
	Task<IEnumerable<SessionActivity>?> GetSessionActivities();
}