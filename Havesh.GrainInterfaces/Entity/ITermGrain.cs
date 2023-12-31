using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface ITermGrain : IGrainWithIntegerKey
{
	Task<IEnumerable<ShokouhPardisClassRoom>> GetClassRooms();

	Task<IEnumerable<ShokouhPardisInterval>> GetIntervals(int TermId);

	Task<ShokouhPardisInterval?> GetIntervalByStartTime(TimeSpan startTime, TimeSpan fromMinutes);

}