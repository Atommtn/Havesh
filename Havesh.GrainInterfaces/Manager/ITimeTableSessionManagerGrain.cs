using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface ITimeTableSessionManagerGrain : IGrainWithGuidKey
{
	Task<IEnumerable<TimeTableSession>?> GetTimeTableSessions(int timeTableId);
	Task<IDictionary<TimeTableSession,IEnumerable<IEnumerable<StudentSessionActivity>>>?> GetTimeTableSessionsIncludeActivities(int timeTableId);
	Task<TimeTableSession?> GetSessionByDate(int timeTableId, DateTime? today);
	Task<IEnumerable<TimeTableSession>?> GetTimeTableSessions(TimeSpan time, DateTime? dateTime);
	Task<IEnumerable<SessionActivityValueOption>?> GetSessionActivitiesPerformed(int timeTableSessionId);
	Task<IEnumerable<StudentSessionActivity>?> GetSessionStudentActivitiesPerformed(int timeTableSessionId);
}