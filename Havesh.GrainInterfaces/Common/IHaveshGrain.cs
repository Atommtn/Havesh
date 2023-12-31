using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Common;

public interface IHaveshGrain<T> : IResetSupportGrain
{
	public Task<T?> Get(bool? forceFromDb = false);
	public Task Set(T? entity);
	public Task Update(T? entityState);
	public Task SafeRemove(T? entityState);
}