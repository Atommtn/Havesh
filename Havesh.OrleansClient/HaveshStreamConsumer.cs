using Havesh.Model.Model;
using Orleans.Streams;

namespace Havesh.OrleansClient;

public class HaveshStreamConsumer<T> : IAsyncObserver<T>
{
	private readonly Action<T>? _onStreamPerformed;

	public HaveshStreamConsumer(Action<T>? onStreamPerformed)
	{
		_onStreamPerformed = onStreamPerformed;
	}

	public Task OnNextAsync(T item, StreamSequenceToken? token = null)
	{
		_onStreamPerformed?.Invoke(item);
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