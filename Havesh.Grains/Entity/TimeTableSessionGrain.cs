using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;
using Orleans.Streams;
using static System.Collections.Specialized.BitVector32;

namespace Havesh.Grains.Entity;

[Serializable]
[GenerateSerializer]
public class TimeTableSessionGrainState
{
	[Id(0)]
	public List<StudentSessionActivity> Activities { get; set; } = new();

	[Id(1)]
	public TimeTableSession TimeTableSession { get; set; }
}


public class TimeTableSessionGrain : 
	HaveshGrain<TimeTableSessionGrainState>
	, ITimeTableSessionGrain
	, IAsyncObserver<StudentSessionActivity>
{
	private StreamSubscriptionHandle<StudentSessionActivity> _subscription;
	public TimeTableSessionGrain(
		[PersistentState(nameof(TimeTableSessionGrain) , HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<TimeTableSessionGrainState>> persistentState,
		IGrainContext grainContext,
		DataProviderService dataProviderService,
		ILogger<HaveshGrain<TimeTableSessionGrainState>> logger)
			: base(persistentState, grainContext, dataProviderService, logger)
	{

	}

	public override async Task OnActivateAsync(CancellationToken cancellationToken)
	{
		await SubscribeToStream();
		await base.OnActivateAsync(cancellationToken);
	}
	async Task SubscribeToStream()
	{
		var streamProvider = this.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
		var streamId = StreamId.Create(HaveshConstants.StudentSessionActivityStreamNamespace, HaveshConstants.GeneralKey);
		var stream = streamProvider.GetStream<StudentSessionActivity>(streamId);
		_subscription = await stream.SubscribeAsync(this);

	}
	public async Task OnNextAsync(StudentSessionActivity item, StreamSequenceToken? token = null)
	{
		if (item.TimeTableSessionFk == GrainKey)
		{
			Logger.LogInformation($"Received Student Activity to {nameof(TimeTableSessionGrain)} {GrainKey}: {item.ActivityValue}");
			Console.Beep();
			await ActivityPerformed(item);
		}
	}

	public Task OnCompletedAsync()
	{
		return Task.CompletedTask;
	}

	public Task OnErrorAsync(Exception ex)
	{
		return Task.CompletedTask;
	}

	public override async Task OnDeactivateAsync(DeactivationReason reason, CancellationToken cancellationToken)
	{
		await _subscription.UnsubscribeAsync();
		await base.OnDeactivateAsync(reason, cancellationToken);
	}

	private string Result(int activityId)
	{
		var activities = PersistentState.State.Item?
			.Activities
			.Where(x => x.ActivityFk == activityId)
			.GroupBy(x => x.ActivityValue)
			.Select(group => $"[{group.Key}] : {group.Count()}");
		var result = string.Join(",", activities);
		return result;
	}

	protected override TimeTableSessionGrainState? GetEntity(int id)
	{
		var ttSesion = DataProviderService.GetTimeTableSessionById(id , q=>
			q
				.Include(x => x.Teacher)

				.Include(x => x.TimeTable)
				.ThenInclude(x => x.Teacher)

				.Include(x=>x.TimeTable)
				.ThenInclude(x=>x.ClassRoom)
				
				.Include(x=>x.TimeTable)
				.ThenInclude(x=>x.Level)
				
				)
			;

		var activities = DataProviderService.GetStudentSessionActivityPerformed(ttSesion);
		return new TimeTableSessionGrainState
		{
			TimeTableSession = ttSesion,
			Activities = activities
		};
	}

	protected override void UpdateEntity(TimeTableSessionGrainState entity)
	{
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<StudentSessionActivity>?> GetStudentSessionActivities()
	{
		
		var sessionSesionActivities = CacheManager.GetOrSet("StudentSessionActivities-" + GrainKey,
			() =>
			{
				EnusureState();
				return PersistentState.State.Item?.TimeTableSession is null
					? null
					: DataProviderService.GetStudentSessionActivityPerformed(PersistentState.State.Item.TimeTableSession,
						q => q
							.Include(x => x.ActivityValueOption)
							.Include(x => x.Activity)
							//.Include(x => x.TimeTableSession)
							);
			}, TimeSpan.FromHours(1));
		
		return sessionSesionActivities;
	}

	public Task ActivityPerformed(StudentSessionActivity activity)
	{
		EnusureState();
		PersistentState.State.Item?.Activities.Add(activity);
		return Task.CompletedTask;
	}

	public async Task<IEnumerable<SessionActivity>?> GetActivities()
	{
		EnusureState();
		var activities = PersistentState.State.Item?.Activities.Select(x=>x.Activity);
		return activities;
	}



}

public interface ITimeTableSessionGrain : IGrainWithIntegerKey
{
	Task<IEnumerable<StudentSessionActivity>?> GetStudentSessionActivities();
	Task<IEnumerable<SessionActivity>?> GetActivities();

	Task ActivityPerformed(StudentSessionActivity activity);
}