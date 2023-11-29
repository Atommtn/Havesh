using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Entity;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

public class UserGrain : HaveshGrain<User> , IUserGrain
{
	public UserGrain(
		[PersistentState(nameof(UserGrain),HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<User>> persistentState, 
		IGrainContext grainContext,
		DataProviderService dataProviderService, 
		ILogger<HaveshGrain<User>> logger) 
			: base(persistentState, grainContext, dataProviderService, logger)
	{
	}

	protected override User? GetEntity(int id) => DataProviderService.GetUserByUseId(id);

	protected override void UpdateEntity(User user) => DataProviderService.SaveUser(user);
}