using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havesh.GrainInterfaces.Common;

public interface IResetSupportGrain : IGrainWithIntegerCompoundKey
{
	Task DeactivateGrainAsync();

	Task ResetGrainCacheAsync();
}

public interface IResetSupportManagerGrain : IGrainWithGuidKey
{
	Task DeactivateGrainAsync();

	Task ResetGrainCacheAsync();
}
