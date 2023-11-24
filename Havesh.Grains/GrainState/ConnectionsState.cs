using Havesh.GrainInterfaces.Manager;
using Havesh.GrainInterfaces.Type;
using Havesh.Model.Model;
using System.Collections.Concurrent;

namespace Havesh.Grains.GrainState;

[GenerateSerializer]
public class ConnectionsState
{
	[Id(0)]
	public ConcurrentDictionary<User, List<Connection>> ConnectedUsers { get; set; } = new();

}