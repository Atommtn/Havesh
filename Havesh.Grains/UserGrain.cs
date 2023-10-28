using Havesh.GrainInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Model.Model;
using HaveshApp.Services;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains;

public class UserGrain : IGrainBase, IUser
{
	private readonly ILogger _logger;
	private readonly DataProviderService _dataProviderService;



	public IGrainContext GrainContext { get; }

	public Task OnActivateAsync(CancellationToken token)
	{
		throw new NotImplementedException();
	}

	public Task OnDeactivateAsync(DeactivationReason reason, CancellationToken token)
	{
		throw new NotImplementedException();
	}

	public async ValueTask<User> GetUser()
	{

	}

	public ValueTask<User> SaveUser()
	{
		throw new NotImplementedException();
	}
}

