using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

[Serializable]
[GenerateSerializer]
public class TimeTableSessionGrainState
{
	[Id(0)]
	public List<StudentSessionActivity> Activities { get; set; } = new List<StudentSessionActivity>();

	[Id(1)]
	public TimeTableSession TimeTableSession { get; set; }
}

public class TimeTableSessionGrain : HaveshGrain<TimeTableSessionGrainState>, ITimeTableSessionGrain
{

	public TimeTableSessionGrain(
		[PersistentState(nameof(TimeTableSessionGrain) , HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<TimeTableSessionGrainState>> persistentState,
		IGrainContext grainContext,
		DataProviderService dataProviderService,
		ILogger<HaveshGrain<TimeTableSessionGrainState>> logger)
			: base(persistentState, grainContext, dataProviderService, logger)
	{

	}

	public async Task<string> ActivityPerformed(StudentSessionActivity activity)
	{
		PersistentState.State.Item ??= GetEntity(GrainKey);
		PersistentState.State.Item?.Activities.Add(activity);
		return Result(activity.ActivityFk);
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
		var ttSesion = DataProviderService.GetTimeTableSessionById(id);
		var activities = DataProviderService.GetSessionActivityPerformed(ttSesion);
		return new TimeTableSessionGrainState()
		{
			TimeTableSession = ttSesion,
			Activities = activities
		};
	}

	protected override void UpdateEntity(TimeTableSessionGrainState entity)
	{
		throw new NotImplementedException();
	}
}

public interface ITimeTableSessionGrain : IGrainWithIntegerKey
{
	Task<string> ActivityPerformed(StudentSessionActivity activity);
}