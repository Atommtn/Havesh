using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface ISessionActivityOptionManagerGrain : IGrainWithGuidCompoundKey
{
	Task<List<SessionActivityValueOption>> GetSessionActivityOptions(int sessionActivityId);
}