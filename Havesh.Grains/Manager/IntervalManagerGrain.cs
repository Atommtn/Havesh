using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Manager;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Olive;

namespace Havesh.Grains.Manager;

public class IntervalManagerGrain : HaveshManagerGrain , IIntervalManagerGrain
{
	private readonly DataProviderService _dataProviderService;
	private readonly ILogger<IntervalManagerGrain> _logger;

	public IntervalManagerGrain(
		DataProviderService dataProviderService,
		ILogger<IntervalManagerGrain> logger)
	{
		_dataProviderService = dataProviderService;
		_logger = logger;
	}

	public Task<IEnumerable<ShokouhPardisInterval>?> GetIntervals(int termId)
	{
		return CacheManager.GetOrSet($"Intervals-{termId}", 
			() => Task.FromResult(_dataProviderService.GetIntervals(termId).OrEmpty().AsEnumerable()), 
			CacheExpireTime);
	}
	public Task<IEnumerable<ShokouhPardisClassRoom>?> GetClassRooms()
	{
		return CacheManager.GetOrSet($"ClassRooms", 
			() => Task.FromResult(_dataProviderService.GetClassRooms().OrEmpty().AsEnumerable()), 
			CacheExpireTime);
	}
}