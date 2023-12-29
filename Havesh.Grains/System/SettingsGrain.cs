using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Common;
using Havesh.GrainInterfaces.System;
using Havesh.Grains.Entity;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Orleans.Runtime;

namespace Havesh.Grains.System;

[Serializable]
[GenerateSerializer]
public class SettingsState
{
	[Id(0)]
	public bool IsDebug { get; set; }
	
	[Id(1)]
	public DateTime? Date { get; set; }
	
	[Id(2)]
	public TimeSpan? Time { get; set; }
}

public class SettingsGrain : Grain, ISettingsGrain
{
	private readonly IPersistentState<SettingsState> _persistentState;

	public SettingsGrain(
		[PersistentState(nameof(SettingsGrain),HaveshConstants.GrainStorageProviderName)]
		IPersistentState<SettingsState> persistentState
	)
	{
		_persistentState = persistentState;
	}

	public async Task SetIsDebug(bool isDebug)
	{
		if(_persistentState.State.IsDebug == isDebug) return;
		_persistentState.State.IsDebug = isDebug;
		await _persistentState.WriteStateAsync();
	}

	public async Task SetDate(DateTime date)
	{
		if(_persistentState.State.Date == date) return;
		_persistentState.State.Date = date;
		await _persistentState.WriteStateAsync();
	}

	public async Task SetTime(TimeSpan time)
	{
		if(_persistentState.State.Time == time) return;
		_persistentState.State.Time = time;
		await _persistentState.WriteStateAsync();
	}

	public Task<bool> IsDebug() => Task.FromResult(_persistentState.State.IsDebug);

	public Task<DateTime> Date()
	{
		var stateDate = _persistentState.State.Date ?? DateTime.Today;
		if(!_persistentState.State.IsDebug)
			stateDate = DateTime.Today;

		return Task.FromResult(stateDate);
	}

	public Task<TimeSpan> Time()
	{
		var stateTime = _persistentState.State.Time ?? DateTime.Now.TimeOfDay;
		if (!_persistentState.State.IsDebug)
			stateTime = DateTime.Now.TimeOfDay;
		return Task.FromResult(stateTime);
	}
}
