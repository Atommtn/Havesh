using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Model.Model;

namespace Havesh.Grains.Manager;

public interface IStudentSessionActivityManagerGrain : IGrainWithGuidCompoundKey
{
	Task CreateStudentSessionActivity(StudentSessionActivity ssa);
	Task<IEnumerable<SessionActivity>?> GetGeneralSesionActivities();
	Task<SessionActivity?> GetDefaultSesionActivity();
	Task NotifySessionActivity(StudentSessionActivity ssa);
}