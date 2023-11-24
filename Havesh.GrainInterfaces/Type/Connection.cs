namespace Havesh.GrainInterfaces.Type;

[GenerateSerializer]
public class Connection
{
	[Id(0)]
	public string ConnectionId { get; set; }
	[Id(1)]
	public string? Ip { get; set; }

	public Connection(string connectionId, string? ip)
	{
		ConnectionId = connectionId;
		Ip = ip;
	}
}