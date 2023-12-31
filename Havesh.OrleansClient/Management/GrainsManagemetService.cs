using Orleans.Core.Internal;
using Orleans.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.GrainInterfaces.Common;

namespace Havesh.OrleansClient.Management
{
	public class GrainsManagemetService
	{
		private readonly IClusterClient _clusterClient;

		public GrainsManagemetService(IClusterClient clusterClient)
		{
			_clusterClient = clusterClient;
		}

		public async Task ResetGrains(GrainType grainType)
		{
			var managementGrain = _clusterClient.GetGrain<IManagementGrain>(0);
			var activeGrains = await managementGrain.GetActiveGrains(grainType);
			
			foreach (var grain in activeGrains.Select(activeGrain => _clusterClient.GetGrain<IResetSupportGrain>(activeGrain)))
			{
				await grain.ResetGrainCacheAsync();
			}
		}
	}
}
