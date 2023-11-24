using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Entity;
using Havesh.Grains.Common;
using Havesh.Grains.Entity;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Manager;

public class TimeTableGrain : HaveshGrain<ShokouhPardisTimeTable>, ITimeTableGrain
{

	public TimeTableGrain(
		[PersistentState(nameof(TimeTableGrain),HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<ShokouhPardisTimeTable>> persistentState,
		IGrainContext grainContext,
		DataProviderService dataProviderService,
		ILogger<HaveshGrain<ShokouhPardisTimeTable>> logger)
		: base(persistentState, grainContext, dataProviderService, logger)
	{
	}

	protected override ShokouhPardisTimeTable? GetEntity(int id)
	{
		return DataProviderService.GetTimeTable(id);
	}

	protected override void UpdateEntity(ShokouhPardisTimeTable entity)
	{
		DataProviderService.SaveTimeTable(entity);
	}

	public async Task<IEnumerable<ShokouhPardisStudentClass>?> GetStudents()
	{

		return await CacheManager.GetOrSet("TT_Students_" + GrainKey, async () =>
		{
			var students = DataProviderService.GetTimeTableStudents(GrainKey);
			
			if (students == null) return students;

			foreach (var student in students)
			{
				var studentGrain = GrainFactory.GetGrain<IHaveshGrain<ShokouhPardisStudentClass>>(student.Id);
				await studentGrain.Set(student);
			}

			return students;

		}, TimeSpan.FromHours(1));

	}

	public async Task<int> GetStudentCount()
	{

		return CacheManager.GetOrSet("TT_Student_Count_" + GrainKey, 
			() => DataProviderService.GetTimeTableStudentCount(GrainKey), 
			TimeSpan.FromHours(1));

	}

	public async Task<IEnumerable<TimeTableSession>?> GetSessions()
	{
		var sessionManagerGrain = GrainFactory.GetGrain<ITimeTableSessionManagerGrain>(Guid.Empty);
		var timeTableId = (int)this.GetPrimaryKeyLong();
		var tableSessions = await sessionManagerGrain.GetTimeTableSessions(timeTableId);
		return tableSessions;
	}


	public async Task<TimeTableSession?> GetTodaySession(DateTime? dateTime = null)
	{	
		var timeTableId = (int)this.GetPrimaryKeyLong();
		var sessionManagerGrain = GrainFactory.GetGrain<ITimeTableSessionManagerGrain>(Guid.Empty);
		dateTime ??= DateTime.Today;
		var timeTableSession = await sessionManagerGrain.GetSessionByDate(timeTableId, dateTime);
		return timeTableSession;
	}
}