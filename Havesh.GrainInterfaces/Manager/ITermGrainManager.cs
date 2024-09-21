using Havesh.GrainInterfaces.Common;
using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Manager;

public interface ITermGrainManager : IGrainWithGuidCompoundKey
{
	public Task<ShokouhPardisTermClass?> GetTermsInRangeToday(DateTime? date = null);
	public Task<ShokouhPardisTermClass?> GetLatestTerm();
}