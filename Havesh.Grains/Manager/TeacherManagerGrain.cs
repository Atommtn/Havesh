using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.Grains.Common;
using Havesh.Model.Model;
using Olive;

namespace Havesh.Grains.Manager;

public class TeacherManagerGrain : HaveshManagerGrain , ITeacherManagerGrain
{
	private readonly ConcurrentDictionary<int, IHaveshGrain<ShokouhPardisTeacherClass>> _userTeacherDictionary = new();
	DataProviderService DataProviderService { get; }

	public TeacherManagerGrain(DataProviderService dataProviderService)
	{
		DataProviderService = dataProviderService;
	}

	public async Task<ShokouhPardisTeacherClass?> GetTeacherByUserId(int? userId)
	{
		if (userId == null)
			return null;

		if (_userTeacherDictionary.TryGetValue((int)userId , out var currentTeacherGrain))
		{
			return await currentTeacherGrain.Get();
		}

		var userGrain = GrainFactory.GetGrain<IHaveshGrain<User>>((long)userId);
		if (userGrain == null) return null;

		var user = await userGrain.Get()!;
		if (user != null && !user.Roles.Select(x => x.Name).Contains("Teacher"))
			throw new Exception("This user is not in Teachers Role");

		var teacher = DataProviderService.GetTeacherByUserId(user?.Id);
		if (teacher != null)
		{
			
			var teacherGrain = GrainFactory.GetGrain<IHaveshGrain<ShokouhPardisTeacherClass>>(teacher.Id);
			await teacherGrain.Set(teacher);
			_userTeacherDictionary.TryAdd((int)userId, teacherGrain);

			return teacher;
		}

		throw new Exception("There is not any Teacher assign to this User");
	}

	public Task<ShokouhPardisTeacherClass?> GetTeacherByUser(IHaveshGrain<User> user)
	{
		throw new NotImplementedException();
	}
}