using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface IIntervallGrain  : IGrainWithIntegerKey
{
	Task<IEnumerable<ShokouhPardisTimeTable>?> GetIntervalTimeTables(int weekdayId);
}