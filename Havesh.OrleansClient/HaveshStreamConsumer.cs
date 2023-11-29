using Havesh.Model.Model;
using Orleans.Streams;

namespace Havesh.OrleansClient;

public class HaveshStreamConsumer<T> : IAsyncObserver<T>
{
	private readonly Func<T, Task>? _onStreamPerformed;

	public HaveshStreamConsumer(Func<T,Task>? onStreamPerformed)
	{
		_onStreamPerformed = onStreamPerformed;
	}

	public Task OnNextAsync(T item, StreamSequenceToken? token = null)
	{
		Console.WriteLine(" ---------------> token.EventIndex :" + token?.EventIndex);
		Console.WriteLine(" ---------------> token.SequenceNumber :" + token?.SequenceNumber);
		return _onStreamPerformed == null ? 
			Task.CompletedTask : 
			_onStreamPerformed.Invoke(item);
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