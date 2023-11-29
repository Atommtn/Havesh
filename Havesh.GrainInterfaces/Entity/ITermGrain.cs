using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface ITermGrain : IGrainWithIntegerKey
{
	public Task<ShokouhPardisInterval?> GetIntervalByStartTime(TimeSpan startTime, TimeSpan fromMinutes);

}