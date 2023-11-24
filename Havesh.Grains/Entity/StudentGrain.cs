using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

public class StudentGrain : HaveshGrain<ShokouhPardisStudentClass> , IStudentGrain
{
	public StudentGrain(
		[PersistentState(nameof(StudentGrain),HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<ShokouhPardisStudentClass>> persistentState, IGrainContext grainContext, DataProviderService dataProviderService, ILogger<HaveshGrain<ShokouhPardisStudentClass>> logger) : base(persistentState, grainContext, dataProviderService, logger)
	{
	}

	protected override ShokouhPardisStudentClass? GetEntity(int id)
	{
		var student = DataProviderService.GetStudent(id);
		return student;
	}

	protected override void UpdateEntity(ShokouhPardisStudentClass entity)
	{
		DataProviderService.UpdateStudent(entity);
	}
}

public interface IStudentGrain : IGrainWithIntegerKey
{

}