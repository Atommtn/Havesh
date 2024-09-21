using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface ISessionActivityGrain : IGrainWithIntegerCompoundKey
{
	Task<SessionActivityValueOption?> GetSessionActivityValueOptionByValueAsync(string value);

}