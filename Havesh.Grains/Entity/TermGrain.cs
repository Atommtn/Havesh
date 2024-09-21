using Havesh.Common;
using Havesh.Application.Services;
using Havesh.GrainInterfaces.Entity;
using Havesh.GrainInterfaces.Manager;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Olive;
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

	public Task<IEnumerable<ShokouhPardisClassRoom>> GetClassRooms()
	{
		return CacheManager.GetOrSet($"Term-ClassRooms",
			() => Task.FromResult(DataProviderService.GetClassRooms().OrEmpty().AsEnumerable()),
			TimeSpan.FromHours(1));
	}


	public Task<IEnumerable<ShokouhPardisInterval>> GetIntervals(int termId)
	{
		return CacheManager.GetOrSet($"Term-Intervals-{this.GrainKey}",
			() => Task.FromResult(DataProviderService.GetIntervals(this.GrainKeyInt).OrEmpty().AsEnumerable())
			, TimeSpan.FromHours(1));
	}

	public async Task<ShokouhPardisInterval?> GetIntervalByStartTime(TimeSpan startTime, TimeSpan fromMinutes)
	{
		return CacheManager.GetOrSet($"Term-Timed-Intervals-{GrainKey}-{startTime:g}" , () =>
		{
			var interval = DataProviderService.GetInterval(GrainKeyInt, startTime, fromMinutes);
			return interval;
		}, TimeSpan.FromHours(1));
	}
}