using Havesh.Common;
using Havesh.Application.Services;
using Havesh.GrainInterfaces.Entity;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

public class TeacherGrain : HaveshGrain<ShokouhPardisTeacherClass> , ITeacherGrain
{
	public TeacherGrain(
		[PersistentState(nameof(TeacherGrain),HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<ShokouhPardisTeacherClass>> persistentState, 
		IGrainContext grainContext, 
		DataProviderService dataProviderService, 
		ILogger<HaveshGrain<ShokouhPardisTeacherClass>> logger) 
		: base(persistentState, grainContext, dataProviderService, logger)
	{
	}

	protected override ShokouhPardisTeacherClass? GetEntity(int id)
	{
		return DataProviderService.GetTeacher(id);
	}

	protected override void UpdateEntity(ShokouhPardisTeacherClass entity)
	{
		DataProviderService.SaveEditTeacher(entity);
	}
}