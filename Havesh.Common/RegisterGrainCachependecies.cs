using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Domain.Infrastructure;
using Havesh.GrainInterfaces.Entity;
using Havesh.GrainInterfaces.Manager;
using Havesh.GrainInterfaces.System;
using Havesh.Grains.Manager;
using Havesh.Model.Model;

namespace Havesh.Common
{
	public static class RegisterGrainCachependecies
	{
		public static GrainEntityDependency RegisterDependencies()
		{
			var cacheDependency = new GrainEntityDependency();
			// به دلایلی حتما باید نام اینترفیس گرین دیقیا همنام با نام گرین و با یک آی آغازین باشد
			cacheDependency
				.Grain<IUserGrain>()
				.DependsOn<User>(true, GrainActionOnEntityChangeEnum.DeactivateGrain)
				.DependsOn<Role>(GrainActionOnEntityChangeEnum.ResetGrainCache)
				.DependsOn<Permission>(GrainActionOnEntityChangeEnum.ResetGrainCache)

				.Grain<IIntervallGrain>()
				.DependsOn<ShokouhPardisInterval>(true)
				.DependsOn<ShokouhPardisTimeTable>()

				.Grain<ISessionActivityGrain>()
				.DependsOn<SessionActivity>(true)

				.Grain<ISessionActivityValueOptionGrain>()
				.DependsOn<SessionActivityValueOption>(true)

				.Grain<IStudentGrain>()
				.DependsOn<ShokouhPardisStudentClass>(true)

				//.Grain<IStudentSessionActivity>()
				//.DependsOn<StudentSessionActivity>(true)

				.Grain<ITeacherGrain>()
				.DependsOn<ShokouhPardisTeacherClass>(true)
				.DependsOn<ShokouhPardisTimeTable>(true)

				.Grain<ITermGrain>()
				.DependsOn<ShokouhPardisTermClass>(true)
				.DependsOn<ShokouhPardisInterval>()
				.DependsOn<ShokouhPardisClassRoom>()
				.DependsOn<ShokouhPardisYearClass>()

				.Grain<ITimeTableGrain>()
				.DependsOn<ShokouhPardisTimeTable>(true)
				.DependsOn<TimeTableSession>(true)

				.Grain<ITimeTableSessionGrain>()
				.DependsOn<TimeTableSession>(true)
				.DependsOn<ShokouhPardisTimeTable>()

				.ManagerGrain<ISessionActivityOptionManagerGrain>()
				.DependsOn<SessionActivity>()

				.ManagerGrain<ISignalRRegisterUserGrain>()
				.DependsOn<User>()

				.ManagerGrain<IStudentSessionActivityManagerGrain>()
				.DependsOn<SessionActivity>(GrainActionOnEntityChangeEnum.ResetGrainCache)

				.ManagerGrain<ITeacherManagerGrain>()
				.DependsOn<User>()
				.DependsOn<ShokouhPardisTeacherClass>()

				.ManagerGrain<ITermGrainManager>()
				.DependsOn<ShokouhPardisTermClass>()

				.ManagerGrain<ITimeTableManagerGrain>()
				.DependsOn<ShokouhPardisTermClass>()
				.DependsOn<ShokouhPardisTeacherClass>()
				.DependsOn<ShokouhPardisWeekDay>()
				.DependsOn<ShokouhPardisInterval>()
				.DependsOn<TimeTableSession>()

				.ManagerGrain<ITimeTableSessionManagerGrain>()
				.DependsOn<TimeTableSession>()
				.DependsOn<SessionActivityValueOption>()
				
				.ManagerGrain<IWeekdayManagerGrain>()
				.DependsOn<ShokouhPardisWeekDay>()
				;
			return cacheDependency;
		}
	}
}
