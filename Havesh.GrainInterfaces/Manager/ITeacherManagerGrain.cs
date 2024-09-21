using Havesh.GrainInterfaces.Common;
using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface ITeacherManagerGrain : IGrainWithGuidCompoundKey
{
	public Task<ShokouhPardisTeacherClass?> GetTeacherByUserId(int? userId);
	public Task<ShokouhPardisTeacherClass?> GetTeacherByUser(User user);
}