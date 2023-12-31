using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Application.Services;
using Havesh.GrainInterfaces.Common;
using Havesh.Grains.Common;
using Havesh.Model.Model;
using Olive;

namespace Havesh.Grains.Manager;

public class TeacherManagerGrain : HaveshManagerGrainBase , ITeacherManagerGrain
{
	private readonly ConcurrentDictionary<int, IHaveshGrain<ShokouhPardisTeacherClass>> _userTeacherDictionary = new();
	DataProviderService DataProviderService { get; }

	public TeacherManagerGrain(DataProviderService dataProviderService)
	{
		DataProviderService = dataProviderService;
	}

	public Task<ShokouhPardisTeacherClass?> GetTeacherByUserId(int? userId)
	{
		return CacheManager.GetOrSet($"Teacher-{userId}", async () =>
		{
			if (userId == null) return null;

			var userGrain = GrainFactory.GetGrain<IHaveshGrain<User>>((long)userId);
			if (userGrain == null) return null;

			var user = await userGrain.Get()!;
			if (user != null && !user.Roles.Select(x => x.Name).Contains("Teacher"))
				throw new Exception("This user is not in Teachers Role");

			var teacher = DataProviderService.GetTeacherByUserId(user?.Id);
			if (teacher == null)
				throw new Exception("There is not any Teacher assign to this User");

			var teacherGrain = GrainFactory.GetGrain<IHaveshGrain<ShokouhPardisTeacherClass>>(teacher.Id);
			await teacherGrain.Set(teacher);
			_userTeacherDictionary.TryAdd((int)userId, teacherGrain);

			return teacher;

		}, CacheExpireTime);



	}

	public Task<ShokouhPardisTeacherClass?> GetTeacherByUser(User user)
	{
		return GetTeacherByUserId(user.Id);
	}
}