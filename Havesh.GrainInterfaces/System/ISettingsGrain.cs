namespace Havesh.GrainInterfaces.System;

public interface ISettingsGrain : IGrainWithStringKey
{
	Task SetIsDebug(bool isDebug);
	Task SetDate(DateTime date);
	Task SetTime(TimeSpan time);
	Task<bool> IsDebug();
	Task<DateTime> Date();
	Task<TimeSpan> Time();
}