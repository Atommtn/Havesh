using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Application.Services;

using Havesh.GrainInterfaces.Manager;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Olive;

namespace Havesh.Grains.Manager;

public class IntervalManagerGrain : HaveshManagerGrainBase , IIntervalManagerGrain
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

}