using Havesh.Application.Services;
using Havesh.GrainInterfaces.Common;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Model.Model;
using Olive;

namespace Havesh.Grains.Manager;

public class SessionActivityOptionManagerGrain : HaveshManagerGrainBase , ISessionActivityOptionManagerGrain
{
    private readonly ILogger<SessionActivityOptionManagerGrain> _logger;

    public SessionActivityOptionManagerGrain(
        DataProviderService dataProviderService,
        ILogger<SessionActivityOptionManagerGrain> logger)
    {
        DataProviderService = dataProviderService;
        _logger = logger;
    }


    public async Task<List<SessionActivityValueOption>> GetSessionActivityOptions(int sessionActivityId)
    {
        _logger.LogInformation(nameof(GetSessionActivityOptions) + " request data from cache.");
	    return CacheManager.GetOrSet($"SessionActivityValueOptions-{sessionActivityId}" , () =>
	    {
            _logger.LogTrace("Data fetch from DB In :" + nameof(GetSessionActivityOptions));
		    var sessionActivityValueOptions = DataProviderService!.GetSessionActivityValueOptions(sessionActivityId);
		    return sessionActivityValueOptions;

	    }, CacheExpireTime);
    }
}