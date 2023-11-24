using Havesh.GrainInterfaces.Common;
using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Manager;

public interface ITermGrainManager : IGrainWithGuidKey
{
	public Task<ShokouhPardisTermClass?> GetTermsInRangeToday(DateTime? date = null);
}