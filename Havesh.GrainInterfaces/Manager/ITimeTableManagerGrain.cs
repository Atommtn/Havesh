using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Manager;

public interface ITimeTableManagerGrain : IGrainWithGuidCompoundKey
{
	Task<ShokouhPardisTimeTable?> GetTeacherTimeTable(int termId, int teacherId, int weekdayId, int intervalId);
	Task<ShokouhPardisTimeTable?> GetTeacherTimeTableByDate(int teacherId, DateTime date);
	Task<IEnumerable<ShokouhPardisTimeTable>?> GetTermTimeTablesIncludeSeaaions(int termId, string? search = null);
	Task<IEnumerable<ShokouhPardisTimeTable>> GetTermTimeTables(int termId, int[] weekdayIds, string? search = null);
	Task<IDictionary<string, List<ShokouhPardisTimeTable>>?> GetTermTimeTablesGroupBySchedule(int termId, int[] weekdayIds, string? search = null);
}