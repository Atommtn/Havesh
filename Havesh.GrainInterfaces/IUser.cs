using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Model.Model;

namespace Havesh.GrainInterfaces;

public interface IUser : IGrainWithIntegerKey
{
	ValueTask<User> GetUser();
	ValueTask<User> SaveUser();

}