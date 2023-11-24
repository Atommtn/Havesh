using Havesh.Model.Model;
using Orleans.Streams;

namespace Havesh.OrleansClient;

public class StudentSessionActivityStreamConsumer : IStudentSessionActivityStreamConsumer
{
	private readonly Action<StudentSessionActivity>? _onStudentSessionActivityPerformed;

	public StudentSessionActivityStreamConsumer(Action<StudentSessionActivity>? onStudentSessionActivityPerformed)
	{
		_onStudentSessionActivityPerformed = onStudentSessionActivityPerformed;
	}

	public Task OnNextAsync(StudentSessionActivity item, StreamSequenceToken? token = null)
	{
		_onStudentSessionActivityPerformed?.Invoke(item);
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