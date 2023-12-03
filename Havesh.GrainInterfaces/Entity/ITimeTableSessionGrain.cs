using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface ITimeTableSessionGrain : IGrainWithIntegerKey
{
	Task<IEnumerable<StudentSessionActivity>?> GetStudentSessionActivities();
	Task<IEnumerable<SessionActivity>?> GetSessionActivities();
}