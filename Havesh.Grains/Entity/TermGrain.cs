using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

public class TermGrain : HaveshGrain<ShokouhPardisTermClass> , ITermGrain
{
	public TermGrain(
		[PersistentState(nameof(TermGrain),HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<ShokouhPardisTermClass>> persistentState, 
		IGrainContext grainContext,
		DataProviderService dataProviderService, 
		ILogger<HaveshGrain<ShokouhPardisTermClass>> logger) 
		: base(persistentState, grainContext, dataProviderService, logger)
	{
		
	}

	public override Task OnActivateAsync(CancellationToken cancellationToken)
	{
		PersistentState.State.IsInitialized = true;
		return base.OnActivateAsync(cancellationToken);
	}

	protected override ShokouhPardisTermClass? GetEntity(int id) => DataProviderService.GetTerm(id);
	protected override void UpdateEntity(ShokouhPardisTermClass user) => DataProviderService.UpdateTerm(user);

	public async Task<ShokouhPardisInterval?> GetIntervalByStartTime(TimeSpan startTime, TimeSpan fromMinutes)
	{
		PersistentState.State.Item ??= GetEntity(GrainKey);

		if (PersistentState.State.Item == null) 
			return null;

		var interval = DataProviderService.GetInterval(PersistentState.State.Item, startTime, fromMinutes);
		return interval;
	}
}

public interface ITermGrain : IGrainWithIntegerKey
{
	public Task<ShokouhPardisInterval?> GetIntervalByStartTime(TimeSpan startTime, TimeSpan fromMinutes);

}

public class IntervalGrain : HaveshGrain<ShokouhPardisInterval> , IIntervlalGrain
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
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<ShokouhPardisTimeTable>?> GetIntervalTimeTables(int weekdayId)
	{
		return CacheManager.GetOrSet("TT_" + weekdayId, 
			() => DataProviderService.GetTimeTables(GrainKey, weekdayId)
			, TimeSpan.FromHours(1));
		
	}

}

public interface IIntervlalGrain  : IGrainWithIntegerKey
{
	Task<IEnumerable<ShokouhPardisTimeTable>?> GetIntervalTimeTables(int weekdayId);
}