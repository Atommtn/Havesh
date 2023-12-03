using Havesh.Common;
using Havesh.GrainInterfaces;
using Havesh.GrainInterfaces.Common;
using Havesh.GrainInterfaces.Manager;
using Havesh.GrainInterfaces.Type;
using Havesh.Grains.GrainState;
using Havesh.Model.Model;
using Microsoft.Extensions.Logging;
using Olive;
using Orleans.Runtime;
using System.Collections.Concurrent;

namespace Havesh.Grains.Manager;

public class SignalRRegisterUserGrain : Grain, ISignalRRegisterUserGrain
{

    private readonly IPersistentState<ConnectionsState> _persistentState;
    private readonly IGrainFactory _grainFactory;
    private readonly ILogger<SignalRRegisterUserGrain> _logger;

    public SignalRRegisterUserGrain(
        [PersistentState("ConnectedUsers","HaveshGrainStore")]
        IPersistentState<ConnectionsState> persistentState,
        IGrainFactory grainFactory,
        ILogger<SignalRRegisterUserGrain> logger)
    {
        _persistentState = persistentState;
        _grainFactory = grainFactory;
        _logger = logger;
    }

    public async Task RegisterUser(int userId, string? ip, string connectionId)
    {
        var user = await _grainFactory.GetGrain<IHaveshGrain<User>>(userId).Get();
        if (user != null)
        {
            if (_persistentState.State.ConnectedUsers.Any(x => x.Key.Id == userId))
            {
                _persistentState.State.ConnectedUsers[user].Add(new Connection(connectionId , ip));
                await NotifyUsersChanged();
                return;
            }

            _persistentState.State.ConnectedUsers.TryAdd(user, new List<Connection>() { new Connection(connectionId, ip) });
            await NotifyUsersChanged();
        }
    }

    public async Task UnregisterUser(int userId, string connectionId)
    {
        var pair = Enumerable.FirstOrDefault(_persistentState.State.ConnectedUsers, x => x.Key.Id == userId && x.Value.Any(x=>x.ConnectionId ==  connectionId));
        if (pair.Equals(default(KeyValuePair<User, List<Connection>>)))
            return;

        var userGrain = _grainFactory.GetGrain<IHaveshGrain<User>>(userId);
        var user = await userGrain.Get();
        pair.Value.RemoveWhere(x=>x.ConnectionId == connectionId);
        if (pair.Value.Count == 0 && user != null)
            _persistentState.State.ConnectedUsers.TryRemove(user);

        await NotifyUsersChanged();
    }

    public async Task<User[]> GetOnlineUsers()
    {
        return _persistentState.State.ConnectedUsers.Select(x => x.Key).ToArray();
    }

    public Task<Dictionary<User, List<Connection>>> GetRegisteredUsersConnections()
    {

        return Task.FromResult(_persistentState.State.ConnectedUsers.ToDictionary());
    }

    public async Task<string[]?> GetUserConnections(User user)
    {
        return _persistentState.State.ConnectedUsers.TryGetValue(user, out var connections)
            ? connections.Select(x=>x.ConnectionId).ToArray()
            : null;
    }

    public async Task<Dictionary<User, List<Connection>>> GetUserConnectionsInRoles(string[] roles)
    {
        var inRoles = _persistentState.State
            .ConnectedUsers
            .Where(u => u.Key.Roles.Any(r => roles.Any(x => r.Name == x)))
            .Select(x => x)
            .ToDictionary(x => x.Key, y => y.Value)
            ;
        return inRoles;

    }

    private async Task NotifyUsersChanged()
    {

        // Notify connected clients about the change in user list
        var streamProvider = this.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
        var streamId = StreamId.Create(HaveshConstants.OnlineUsersStreamNamespace, HaveshConstants.GeneralKey);
        var stream = streamProvider.GetStream<User[]>(streamId);
        var users = _persistentState.State.ConnectedUsers
            .Select(x => x.Key)
            .ToArray();
        _logger.LogInformation(nameof(NotifyUsersChanged) + " user count: " + users.Length);
        await stream.OnNextAsync(users);
    }

}