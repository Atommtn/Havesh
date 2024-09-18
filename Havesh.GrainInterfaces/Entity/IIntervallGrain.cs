using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface IIntervallGrain  : IGrainWithStringKey
{
	Task<IEnumerable<ShokouhPardisTimeTable>?> GetIntervalTimeTables(int weekdayId);
}