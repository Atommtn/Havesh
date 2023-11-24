using Havesh.Common;
using Havesh.GrainInterfaces.Manager;
using Havesh.GrainInterfaces.Type;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Olive;
using Orleans.Runtime;
using static MudBlazor.CategoryTypes;

namespace Havesh.OrleansClient;

public class SignalrGrainClientService : IDisposable
{
	private readonly IClusterClient _client;
	private readonly ILogger<SignalrGrainClientService> _logger;
	public event Func<User[],Task>? OnlineUserChanged;
	ISignalRRegisterUserGrain connectedUsersGrain;
	private OnlineUsersStreamConsumer _consumer;

	public SignalrGrainClientService(IClusterClient client,ILogger<SignalrGrainClientService> logger)
	{
		_client = client;
		_logger = logger;
		connectedUsersGrain = _client.GetGrain<ISignalRRegisterUserGrain>(Guid.Empty);
		var streamProvider = _client.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
		var stream = streamProvider.GetStream<User[]>(StreamId.Create(HaveshConstants.OnlineUsersStreamNamespace, 0));
		_consumer = new OnlineUsersStreamConsumer(OnOnlineUserChanged);
		stream.SubscribeAsync(_consumer);
	}

	private void OnOnlineUserChanged(User[] items)
	{
		_logger.Info("Received online users on client: " + string.Join(", ", items.Select(x => x.UserName)));
		OnlineUserChanged?.Invoke(items);
	}

	public async Task RegisterUser(int userId, string? ip, string connectionId)
	{
		await connectedUsersGrain.RegisterUser(userId,ip, connectionId);
	}

	public async Task UnregisterUser(int userId , string connectionId)
	{
		await connectedUsersGrain.UnregisterUser(userId, connectionId);
	}

	public Task<User[]> GetOnlineUsers()
	{
		return connectedUsersGrain.GetOnlineUsers();
	}

	public Task<Dictionary<User, List<Connection>>> GetOnlineUsersConnections()
	{
		return connectedUsersGrain.GetRegisteredUsersConnections();

	}

	public void Dispose()
	{
			
	}

    public async Task<IEnumerable<string>?> GetOnlineUserConnections(User user)
    {
        var connections = await connectedUsersGrain.GetUserConnections(user);
        return connections;
    }

    public async Task<IEnumerable<Connection>?> GetOnlineConnectionsUserInRole(string[] roles)
    {
        var userConnections = await connectedUsersGrain.GetUserConnectionsInRoles(roles);
        var connections = userConnections.SelectMany(x=>x.Value);
		return connections;
    }
}