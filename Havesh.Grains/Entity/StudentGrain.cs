using Castle.Core.Logging;
using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.Grains.Common;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;

namespace Havesh.Grains.Entity;

public class StudentGrain : HaveshGrain<ShokouhPardisStudentClass>, IStudentGrain
{
	public StudentGrain(
		[PersistentState(nameof(StudentGrain),HaveshConstants.GrainStorageProviderName)]
		IPersistentState<HaveshGrainState<ShokouhPardisStudentClass>> persistentState,
		IGrainContext grainContext,
		DataProviderService dataProviderService,
		ILogger<HaveshGrain<ShokouhPardisStudentClass>> logger)
			: base(persistentState, grainContext, dataProviderService, logger)
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

	public async Task SessionActivityPerformed(StudentSessionActivity studentSessionActivity)
	{
		await NotifyStudentSessionActivityPerformed(studentSessionActivity);
		await NotifyStudentSessionActivityToRoles(studentSessionActivity);
	}

	private async Task NotifyStudentSessionActivityToRoles(StudentSessionActivity studentSessionActivity)
	{
		var optionGrain = GrainFactory.GetGrain<IHaveshGrain<SessionActivityValueOption>>(studentSessionActivity.Id);
		var option = await optionGrain.Get();
		
		if (option == null) 
			return;

		var streamProvider = this.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
		var roles = option.BroadcastToRoles?.Split(',', StringSplitOptions.RemoveEmptyEntries);
		if (roles != null)
			foreach (var role in roles)
			{
				// Notify connected clients about the Student Activity in session
				var streamId =  StreamId.Create(HaveshConstants.StudentSessionActivityToRoleStreamNamespace,role);
				var stream = streamProvider.GetStream<StudentSessionActivity>(streamId);
				Logger.LogInformation(nameof(NotifyStudentSessionActivityToRoles) +
				                      $" To Role {role} for student Id: " + studentSessionActivity.StudentFk);
				await stream.OnNextAsync(studentSessionActivity);
			}
	}

	private async Task NotifyStudentSessionActivityPerformed(StudentSessionActivity studentSessionActivity)
	{
		// Notify connected clients about the change in user list
		var streamProvider = this.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
		var streamId = StreamId.Create(HaveshConstants.StudentSessionActivityStreamNamespace, 0);
		var stream = streamProvider.GetStream<StudentSessionActivity>(streamId);
		Logger.LogInformation(nameof(NotifyStudentSessionActivityPerformed) + " ID: " + studentSessionActivity.StudentFk);
		await stream.OnNextAsync(studentSessionActivity);

	}
}

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

public interface ISessionActivityValueOptionGrain : IGrainWithIntegerKey
{

}

public interface IStudentGrain : IGrainWithIntegerKey
{
	Task SessionActivityPerformed(StudentSessionActivity studentSessionActivity);
}