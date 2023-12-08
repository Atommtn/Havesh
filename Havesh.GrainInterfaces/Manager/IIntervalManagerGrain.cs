using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Manager;

public interface IIntervalManagerGrain : IGrainWithGuidKey
{
	Task<IEnumerable<ShokouhPardisInterval>?> GetIntervals(int TermId);
	Task<IEnumerable<ShokouhPardisClassRoom>?> GetClassRooms();

}