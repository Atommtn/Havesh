using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public class SessionActivityOptionManagerGrain : HaveshManagerGrain , ISessionActivityOptionManagerGrain
{
    private readonly DataProviderService _dataProviderService;
    private readonly ILogger<SessionActivityOptionManagerGrain> _logger;

    public SessionActivityOptionManagerGrain(
        DataProviderService dataProviderService,
        ILogger<SessionActivityOptionManagerGrain> logger)
    {
        _dataProviderService = dataProviderService;
        _logger = logger;
    }


}