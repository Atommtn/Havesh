using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Entity;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

using Orleans.Runtime;
using Orleans.Streams;


namespace Havesh.Grains.Entity;

public class TimeTableSessionGrain :
	HaveshGrain<TimeTableSessionGrainState>
	, ITimeTableSessionGrain
	, IAsyncObserver<StudentSessionActivity>
{
	private StreamSubscriptionHandle<StudentSessionActivity>? _subscription = null;
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
		_subscription = await stream.SubscribeAsync(OnNextAsync);

	}

	public async Task OnNextAsync(StudentSessionActivity item, StreamSequenceToken? token = null)
	{
		if (item.TimeTableSessionFk == GrainKey)
		{
			Logger.LogInformation($"Received Student Activity to {nameof(TimeTableSessionGrain)} {GrainKey}: {item.ActivityValue}");
			//Console.Beep(1000,100);
			await ActivityPerformed(item);
		}
	}

	private async Task ActivityPerformed(StudentSessionActivity activity)
	{
		EnusureState();
		if (activity.ActivityDeletedDateTime is not null)
		{
			var index = PersistentState.State.Item?.StudentsActivities.FindIndex(x => x.Id == activity.Id);
			if (index is >= 0)
			{
				PersistentState.State.Item?.StudentsActivities.RemoveAt((int)index);
				return;
			}
		}
		PersistentState.State.Item?.StudentsActivities.Add(activity);

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
		await _subscription?.UnsubscribeAsync()!;
		await base.OnDeactivateAsync(reason, cancellationToken);
	}

	protected override TimeTableSessionGrainState? GetEntity(int id)
	{
		var ttSesion = DataProviderService.GetTimeTableSessionById(id, q =>
			q
				.AsNoTracking()

				.Include(x => x.Teacher)
				.AsNoTracking()

				.Include(x => x.TimeTable)
				.ThenInclude(x => x.Teacher)
				.AsNoTracking()

				.Include(x => x.TimeTable)
				.ThenInclude(x => x.ClassRoom)
				.AsNoTracking()

				.Include(x => x.TimeTable)
				.ThenInclude(x => x.Level)
				.AsNoTracking()
				)
			;

		var activities = DataProviderService
			.GetStudentSessionActivityPerformed(ttSesion.Id,

			q => q
				.AsNoTrackingWithIdentityResolution()
				
				.Include(x => x.Activity)
				.AsNoTracking()

				.Include(x => x.ActivityValueOption)
				.AsNoTracking()

				.Include(x => x.Student)
				.AsNoTracking()

				.Include(x => x.TimeTableSession)
				.ThenInclude(x => x.Teacher)
				.AsNoTracking()

				.Include(x => x.TimeTableSession)
				.ThenInclude(x => x.TimeTable)
				.ThenInclude(x => x.Teacher)
				
				.AsNoTracking()
			);

		return new TimeTableSessionGrainState
		{
			TimeTableSession = ttSesion,
			StudentsActivities = activities
		};
	}

	protected override void UpdateEntity(TimeTableSessionGrainState entity)
	{
		throw new NotImplementedException();
	}

	public async Task<IEnumerable<StudentSessionActivity>?> GetStudentSessionActivities()
	{
		EnusureState();
		if (PersistentState.State.Item?.StudentsActivities.Any(x => x.ActivityValueOption == null) ?? false)
		{
			EnusureState(true);
		}
		return PersistentState.State.Item?.StudentsActivities;
	}

	public async Task<IEnumerable<SessionActivity>?> GetSessionActivities()
	{
		EnusureState();
		return CacheManager.GetOrSet("SA-" + GrainKey, () => DataProviderService.GetSessionActivities(PersistentState.State.Item?.TimeTableSession), TimeSpan.FromHours(1));
	}
}