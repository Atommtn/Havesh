using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Entity;

public interface ISessionActivityGrain : IGrainWithStringKey
{
	Task<SessionActivityValueOption?> GetSessionActivityValueOptionByValueAsync(string value);

}