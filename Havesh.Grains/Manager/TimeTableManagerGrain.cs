using System.Collections.Concurrent;
using Havesh.Application.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Manager;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Olive;

namespace Havesh.Grains.Manager;

public class TimeTableManagerGrain : HaveshManagerGrainBase, ITimeTableManagerGrain
{
	public TimeTableManagerGrain(DataProviderService dataProviderService)
	{
		DataProviderService = dataProviderService;
	}

	public Task<ShokouhPardisTimeTable?> GetTeacherTimeTable(int termId, int teacherId, int weekdayId, int intervalId)
	{
		var key = $"{termId}-{teacherId}-{weekdayId}-{intervalId}";
		return CacheManager.GetOrSet(key, async () =>
		{
			var timeTable = DataProviderService!.GetTeacherTimeTable(termId, teacherId, weekdayId, intervalId);
			if (timeTable == null)
				return timeTable;

			var timeTableGrain = GrainFactory.GetGrain<IHaveshGrain<ShokouhPardisTimeTable>>(timeTable.Id, GrainBranchKey);
			await timeTableGrain.Set(timeTable);
			return timeTable;
		}, CacheExpireTime);

	}

	// جلسات جبرانی (compensatory/makeup) ممکن است در روزی غیر از روز هفتگی تعریف‌شده‌ی کلاس برگزار شوند؛
	// این متد به‌جای تطبیق با روز هفته‌ی برنامه‌ی ثابت، مستقیماً بر اساس تاریخ واقعی جلسه (TimeTableSession.SessionDate) جستجو می‌کند.
	public Task<ShokouhPardisTimeTable?> GetTeacherTimeTableByDate(int teacherId, DateTime date)
	{
		var key = $"TeacherTimeTableByDate-{teacherId}-{date:yyyyMMdd}";
		return CacheManager.GetOrSet(key, async () =>
		{
			var timeTable = DataProviderService!.GetTeacherTimeTableByDate(teacherId, date);
			if (timeTable == null)
				return timeTable;

			var timeTableGrain = GrainFactory.GetGrain<IHaveshGrain<ShokouhPardisTimeTable>>(timeTable.Id, GrainBranchKey);
			await timeTableGrain.Set(timeTable);
			return timeTable;
		}, TimeSpan.FromMinutes(2));
	}

	public async Task<IEnumerable<ShokouhPardisTimeTable>?> GetTermTimeTablesIncludeSeaaions(int termId, string? search = null)
	{
		return CacheManager.GetOrSet($"TimeTablesInTerm-{search}-" + termId, () =>
		{
			var timeTables =
				DataProviderService!.GetTimeTables(termId, search, null, null, timeTables =>
			{
				return timeTables.Include(x => x.Sessions);
			});
			return timeTables;

		}, search.IsEmpty() ? CacheExpireTime : TimeSpan.FromMinutes(2));
	}

	public Task<IEnumerable<ShokouhPardisTimeTable>> GetTermTimeTables(int termId, int[] weekdayIds, string? search = null)
	{
		return CacheManager.GetOrSet($"TimeTables-Term{termId}-weekdays{string.Join(',', weekdayIds)}-{search}", () =>
		{
			var timeTables = DataProviderService!.GetTermTimeTablesInWeekdays(termId, weekdayIds, search ,
				q=>q
					.Include(x=>x.Schedule)
					.ThenInclude(x=>x.Programs)
					.ThenInclude(x=>x.DaySession)
					.ThenInclude(x=>x.Interval)
					.Include(x=>x.Level)
					.Include(x=>x.Teacher)
				);
			//Console.Beep();
			return Task.FromResult(timeTables);

		}, search.IsEmpty() ? CacheExpireTime : TimeSpan.FromMinutes(1));
	}

	public async Task<IDictionary<string, List<ShokouhPardisTimeTable>>?> GetTermTimeTablesGroupBySchedule(int termId, int[] weekdayIds, string? search = null)
	{
		return CacheManager.GetOrSet($"TimeTables-GroupbySchedule-Term{termId}-weekdays{string.Join(',',weekdayIds)}-{search}", () =>
		{
			var timeTables = DataProviderService!.GetTermTimeTablesGroupBySchedule(termId, weekdayIds, search);
			return timeTables;

		}, search.IsEmpty() ? CacheExpireTime : TimeSpan.FromMinutes(1));
	}

}