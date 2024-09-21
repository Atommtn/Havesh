using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface IIntervallGrain  : IGrainWithIntegerCompoundKey
{
	Task<IEnumerable<ShokouhPardisTimeTable>?> GetIntervalTimeTables(int weekdayId);
}