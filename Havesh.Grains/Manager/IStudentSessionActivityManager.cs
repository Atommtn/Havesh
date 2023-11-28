using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface IStudentSessionActivityManagerGrain : IGrainWithGuidKey
{
	Task CreateStudentSessionActivity(StudentSessionActivity ssa);
	Task<IEnumerable<SessionActivity>?> GetSesionActivities();
	Task<SessionActivity?> GetDefaultSesionActivity();
}