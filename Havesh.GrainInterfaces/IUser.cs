using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havesh.GrainInterfaces;

internal interface IUser : IGrainWithIntegerKey
{
	ValueTask<string> GetUserById(int userId);
}