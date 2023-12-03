using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Manager;

public interface ITimeTableManagerGrain : IGrainWithGuidKey
{
	Task<ShokouhPardisTimeTable?> GetTeacherTimeTable(int termId, int teacherId, int weekdayId, int intervalId);
	Task<IEnumerable<ShokouhPardisTimeTable>?> GetTermTimeTablesIncludeSeaaions(int termId, string? search = null);
}