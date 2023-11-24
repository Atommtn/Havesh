using Havesh.Model.Model;
using Orleans.Streams;

namespace Havesh.OrleansClient;

public class OnlineUsersStreamConsumer : IOnlineUsersStreamConsumer
{
	private readonly Action<User[]>? _onOnlineUserChanged;

	public OnlineUsersStreamConsumer(Action<User[]>? onOnlineUserChanged)
	{
		_onOnlineUserChanged = onOnlineUserChanged;
	}

	public Task OnNextAsync(User[] items, StreamSequenceToken? token = null)
	{
		_onOnlineUserChanged?.Invoke(items);
		return Task.CompletedTask;
	}

	public Task OnCompletedAsync()
	{
		return Task.CompletedTask;
	}

	public Task OnErrorAsync(Exception ex)
	{
		return Task.CompletedTask;
	}
}