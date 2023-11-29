using Havesh.GrainInterfaces.Common;
using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface ITeacherManagerGrain : IGrainWithGuidKey
{
	public Task<ShokouhPardisTeacherClass?> GetTeacherByUserId(int? userId);
	public Task<ShokouhPardisTeacherClass?> GetTeacherByUser(IHaveshGrain<User> user);
}