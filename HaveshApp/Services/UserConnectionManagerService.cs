using Havesh.Domain.Services;
using Havesh.Model.Model;
using Olive;

namespace HaveshApp.Services;

public class UserConnectionManagerService
{

	private readonly Dictionary<User, HashSet<string>> _userConnections = new();

	public void AddConnection(User user, string connectionId)
	{
		lock (_userConnections)
		{
			if (!_userConnections.Any(x=>Equals(x.Key, user)))
			{
				_userConnections[user] = new HashSet<string>();
			}

			_userConnections[user].Add(connectionId);
		}
	}

	public void RemoveConnection(User user, string connectionId)
	{
		lock (_userConnections)
		{
			if (!_userConnections.Any(x => Equals(x.Key, user)))
				return;
				
			_userConnections[user].Remove(connectionId);

			if (_userConnections[user].Count == 0)
			{
				_userConnections.Remove(user);
			}
		}
	}
	public bool IsOnline(User user)
	{
		lock (_userConnections)
		{
			var userConnections = _userConnections.FirstOrDefault(x => Equals(x.Key, user)).Value;
			return userConnections.Count > 0;
		}
	}

	public HashSet<string> GetOnlineUserConnections(User user)
	{
		lock (_userConnections)
		{
			var userConnections = _userConnections.FirstOrDefault(x => Equals(x.Key, user)).Value;

			return userConnections;
		}
	}
	public HashSet<string> GetOnlineConnectionsUserInRole(string[] roles)
	{
		lock (_userConnections)
		{
			var usersInRole = _userConnections.Keys.Where(x=>x.Roles.Select(y=>y.Name).Any(roles.Contains));
			var x = new HashSet<string>();
			foreach (var user in usersInRole)
			{
				if (_userConnections.TryGetValue(user, out var connections))
				{
					x.AddRange(connections);
				}
			}
			return x;
		}
	}

	public IEnumerable<string> GetConnections(User user)
	{
		lock (_userConnections)
		{
			if (_userConnections.TryGetValue(user, out var connections))
			{
				return connections;
			}
		}

		return Enumerable.Empty<string>();
	}
}