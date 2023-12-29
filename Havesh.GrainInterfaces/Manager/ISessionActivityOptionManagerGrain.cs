using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface ISessionActivityOptionManagerGrain : IGrainWithGuidKey
{
	Task<List<SessionActivityValueOption>> GetSessionActivityOptions(int sessionActivityId);
}