using Havesh.Model.Model;
using Orleans.Streams;

namespace Havesh.OrleansClient;

public interface IOnlineUsersStreamConsumer : IAsyncObserver<User[]>
{

}