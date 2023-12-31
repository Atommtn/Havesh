using Havesh.Common;
using Havesh.Application.Services;
using Havesh.GrainInterfaces.Entity;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

public class IntervalGrain : HaveshGrain<ShokouhPardisInterval> , IIntervallGrain
{
	public IntervalGrain(
		[PersistentState(nameof(IntervalGrain) , HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<ShokouhPardisInterval>> persistentState,
		IGrainContext grainContext,
		DataProviderService dataProviderService,
		ILogger<HaveshGrain<ShokouhPardisInterval>> logger) 
		: base(persistentState, grainContext, dataProviderService, logger)
	{
	}

	protected override ShokouhPardisInterval? GetEntity(int id)
	{
		return DataProviderService.GetIntervalById(id);
	}

	protected override void UpdateEntity(ShokouhPardisInterval entity)
	{

	}

	public async Task<IEnumerable<ShokouhPardisTimeTable>?> GetIntervalTimeTables(int weekdayId)
	{
		return CacheManager.GetOrSet("TT_" + weekdayId, 
			() => DataProviderService.GetTimeTables(GrainKey, weekdayId)
			, TimeSpan.FromHours(1));
		
	}

}