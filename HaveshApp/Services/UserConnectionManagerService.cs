namespace HaveshApp.Services;

public class UserConnectionManagerService
{
	private readonly Dictionary<int, HashSet<string>> _userConnections = new();

	public void AddConnection(int userId, string connectionId)
	{
		lock (_userConnections)
		{
			if (!_userConnections.ContainsKey(userId))
			{
				_userConnections[userId] = new HashSet<string>();
			}

			_userConnections[userId].Add(connectionId);
		}
	}

	public void RemoveConnection(int userId, string connectionId)
	{
		lock (_userConnections)
		{
			if (!_userConnections.ContainsKey(userId)) 
				return;
				
			_userConnections[userId].Remove(connectionId);

			if (_userConnections[userId].Count == 0)
			{
				_userConnections.Remove(userId);
			}
		}
	}
	public bool IsOnline(int userId)
	{
		lock (_userConnections)
		{
			return _userConnections.ContainsKey(userId) && _userConnections[userId].Count > 0;
		}
	}
	public HashSet<string> GetOnlineUserConnections(int userId)
	{
		lock (_userConnections)
		{
			return _userConnections.TryGetValue(userId, out var connections) 
				?  connections 
				:  new HashSet<string>();
		}
	}

	public IEnumerable<string> GetConnections(int userId)
	{
		lock (_userConnections)
		{
			if (_userConnections.TryGetValue(userId, out var connections))
			{
				return connections;
			}
		}

		return Enumerable.Empty<string>();
	}
}