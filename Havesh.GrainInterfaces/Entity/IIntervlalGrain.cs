using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface IIntervlalGrain  : IGrainWithIntegerKey
{
	Task<IEnumerable<ShokouhPardisTimeTable>?> GetIntervalTimeTables(int weekdayId);
}