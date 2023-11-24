using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.GrainInterfaces.Type;
using Havesh.Model.Model;

namespace Havesh.GrainInterfaces.Manager;

public interface ISignalRRegisterUserGrain : IGrainWithGuidKey
{
    Task RegisterUser(int userId, string? ip, string connectionId);
    Task UnregisterUser(int userId, string connectionId);
    Task<User[]> GetOnlineUsers();
    Task<Dictionary<User, List<Connection>>> GetRegisteredUsersConnections();
    Task<string[]?> GetUserConnections(User user);
    Task<Dictionary<User, List<Connection>>> GetUserConnectionsInRoles(string[] roles);
}