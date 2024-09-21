using Havesh.Common;
using Havesh.GrainInterfaces.Manager;
using Havesh.GrainInterfaces.Type;
using Havesh.Model.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Olive;
using Orleans.Runtime;
using Orleans.Streams;

namespace Havesh.OrleansClient;

public class SignalrGrainClientService : IAsyncDisposable
{
	private readonly IClusterClient _clusterClient;
	private readonly ILogger<SignalrGrainClientService> _logger;
	private readonly string _branchName;
	public event Func<User[],Task>? OnlineUserChanged;

    public SignalrGrainClientService(IClusterClient clusterClient,ILogger<SignalrGrainClientService> logger)
	{
		_clusterClient = clusterClient;
		_logger = logger;
		_branchName = Environment.GetEnvironmentVariable("BranchName")!;

	}

    private StreamSubscriptionHandle<User[]>? _handleOnlineUserStreamSubscribtaionAsync;
	
    public async Task InitOnlineUserStreamSubscribtaionAsync()
    {
		    var streamProvider = _clusterClient.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
		    var streamId = StreamId.Create(HaveshConstants.OnlineUsersStreamNamespace,HaveshConstants.GeneralKey);
		    var stream = streamProvider.GetStream<User[]>(streamId);
		    var consumer = new OnlineUsersStreamConsumer(OnOnlineUserChanged);
		    //Console.Beep();
			await stream.SubscribeAsync(consumer);
    }

    private void OnOnlineUserChanged(User[] items)
	{
		_logger.Info("Received online users on clusterClient: " + string.Join(", ", items.Select(x => x.UserName)));
		OnlineUserChanged?.Invoke(items);
	}

	public async Task RegisterUser(int userId, string? ip, string connectionId)
	{
		
        var connectedUsersGrain = _clusterClient.GetGrain<ISignalRRegisterUserGrain>(Guid.Empty, _branchName);
		await connectedUsersGrain.RegisterUser(userId,ip, connectionId);
	}

	public async Task UnregisterUser(int userId , string connectionId)
	{
        var connectedUsersGrain = _clusterClient.GetGrain<ISignalRRegisterUserGrain>(Guid.Empty, _branchName);
		await connectedUsersGrain.UnregisterUser(userId, connectionId);
	}

	public Task<User[]> GetOnlineUsers()
	{
        var connectedUsersGrain = _clusterClient.GetGrain<ISignalRRegisterUserGrain>(Guid.Empty, _branchName);
		return connectedUsersGrain.GetOnlineUsers();
	}

	public Task<Dictionary<User, List<Connection>>> GetOnlineUsersConnections()
	{
        var connectedUsersGrain = _clusterClient.GetGrain<ISignalRRegisterUserGrain>(Guid.Empty, _branchName);
		return connectedUsersGrain.GetRegisteredUsersConnections();

	}

    public async Task<IEnumerable<string>?> GetOnlineUserConnections(User user)
    {
        var connectedUsersGrain = _clusterClient.GetGrain<ISignalRRegisterUserGrain>(Guid.Empty, _branchName);
        var connections = await connectedUsersGrain.GetUserConnections(user);
        return connections;
    }

    public async Task<IEnumerable<Connection>?> GetOnlineConnectionsUserInRole(string[] roles)
    {
        var connectedUsersGrain = _clusterClient.GetGrain<ISignalRRegisterUserGrain>(Guid.Empty, _branchName);
        var userConnections = await connectedUsersGrain.GetUserConnectionsInRoles(roles);
        var connections = userConnections.SelectMany(x=>x.Value);
		return connections;
    }

    public async ValueTask DisposeAsync()
    {
		if(_handleOnlineUserStreamSubscribtaionAsync != null)
			await _handleOnlineUserStreamSubscribtaionAsync.UnsubscribeAsync();
    }
}

public class SignalrGrainClientInitializationService : IHostedService
{
	private readonly IServiceProvider _serviceProvider;

	public SignalrGrainClientInitializationService(IServiceProvider serviceProvider)
	{
		_serviceProvider = serviceProvider ?? throw new ArgumentNullException(nameof(serviceProvider));
	}

	public async Task StartAsync(CancellationToken cancellationToken)
	{
		using var scope = _serviceProvider.CreateScope();
		var signalrGrainClientService = scope.ServiceProvider.GetRequiredService<SignalrGrainClientService>();
		await signalrGrainClientService.InitOnlineUserStreamSubscribtaionAsync();
	}

	public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
