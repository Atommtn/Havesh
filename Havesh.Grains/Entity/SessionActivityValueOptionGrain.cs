using Havesh.Common;
using Havesh.Application.Services;
using Havesh.GrainInterfaces.Entity;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

public class SessionActivityValueOptionGrain : HaveshGrain<SessionActivityValueOption>, ISessionActivityValueOptionGrain
{
	public SessionActivityValueOptionGrain(
		[PersistentState(nameof(SessionActivityValueOptionGrain) , HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<SessionActivityValueOption>> persistentState,
		IGrainContext grainContext,
		DataProviderService dataProviderService,
		ILogger<HaveshGrain<SessionActivityValueOption>> logger)
		: base(persistentState, grainContext, dataProviderService, logger)
	{

	}

	protected override SessionActivityValueOption? GetEntity(int id)
	{
		var option = DataProviderService.GetSessionActivityValueOption(id);
		return option;
	}

	protected override void UpdateEntity(SessionActivityValueOption entity)
	{
		throw new NotImplementedException();
	}


}