using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

public class SessionActivityGrain : HaveshGrain<SessionActivity> , ISessionActivityGrain
{
	public SessionActivityGrain(
		[PersistentState(nameof(SessionActivityGrain), HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<SessionActivity>> persistentState, 
		IGrainContext grainContext,
		DataProviderService dataProviderService, 
		ILogger<HaveshGrain<SessionActivity>> logger) 
			: base(persistentState,grainContext, dataProviderService, logger)
	{
	}

	protected override SessionActivity? GetEntity(int id)
	{
		return DataProviderService.GetSessionActivity(id);
	}

	protected override void UpdateEntity(SessionActivity entity)
	{
		DataProviderService.SaveSessionActivity(entity);
	}
}

public interface ISessionActivityGrain : IGrainWithIntegerKey
{

}