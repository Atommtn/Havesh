using Havesh.Model.Model;
using Orleans.Streams;

namespace Havesh.OrleansClient;

public interface IStudentSessionActivityStreamConsumer : IAsyncObserver<StudentSessionActivity>
{

}