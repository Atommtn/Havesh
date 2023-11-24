using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface ISessionGrain : IGrainWithIntegerKey
{
	Task<IEnumerable<SessionActivity>?> GetActivities();
}