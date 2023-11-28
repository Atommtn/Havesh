using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.Model.Model;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Manager;

public class StudentSessionActivityManagerGrain : Grain , IStudentSessionActivityManagerGrain
{
	private readonly DataProviderService _dataProviderService;
	private readonly ILogger<StudentSessionActivityManagerGrain> _logger;
	readonly CacheManager _cacheManager = new CacheManager(new MemoryCache(new MemoryCacheOptions()));

	public StudentSessionActivityManagerGrain(
		DataProviderService dataProviderService,
		ILogger<StudentSessionActivityManagerGrain> logger)
	{
		_dataProviderService = dataProviderService;
		_logger = logger;
	}

	public async Task CreateStudentSessionActivity(StudentSessionActivity ssa)
	{
		_dataProviderService.SaveStudentSessionActivity(ssa);
		var sessionActivityGrain = GrainFactory.GetGrain<IHaveshGrain<StudentSessionActivity>>(ssa.Id);
		await sessionActivityGrain.Set(ssa);
		await NotifySessionActivity(ssa);
	}

	public Task<IEnumerable<SessionActivity>?> GetSesionActivities()
	{
		return _cacheManager.GetOrSet("SessionActivities", () =>
		{
			var sessionActivities = _dataProviderService.GetSessionActivities().AsEnumerable();
			return Task.FromResult(sessionActivities);
		} , TimeSpan.FromHours(1));
	}

	public Task<SessionActivity?> GetDefaultSesionActivity()
	{
		return _cacheManager.GetOrSet("SessionActivities", () =>
		{
			var sessionActivities = _dataProviderService.GetDefaultSessionActivity();
			return Task.FromResult(sessionActivities);
		}, TimeSpan.FromHours(1));
	}

	private async Task NotifySessionActivity(StudentSessionActivity ssa)
	{
		// Notify connected clients about StudentSessionActivity
		var streamProvider = this.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
		var streamId = StreamId.Create(HaveshConstants.StudentSessionActivityStreamNamespace, HaveshConstants.GeneralKey);
		var stream = streamProvider.GetStream<StudentSessionActivity>(streamId);
		_logger.LogInformation(nameof(NotifySessionActivity) + "  " + ssa.ActivityValue);
		await stream.OnNextAsync(ssa);
	}
}