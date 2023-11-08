
using Havesh.Domain.Services;
using Microsoft.AspNetCore.SignalR;

//using Hub = Microsoft.AspNetCore.SignalR.Hub;

namespace HaveshApp.Classes.SignalR;

public class HaveshAppHub : Hub
{
	private readonly UserConnectionManagerService _userConnectionManager;

	public HaveshAppHub(UserConnectionManagerService userConnectionManager)
	{
		_userConnectionManager = userConnectionManager;
	}

	public override async Task OnConnectedAsync()
	{
		var userId = Convert.ToInt32(Context.GetHttpContext()?.Request.Query["UserId"]);
		_userConnectionManager.AddConnection(userId, Context.ConnectionId);
		await base.OnConnectedAsync();
	}

	public override Task OnDisconnectedAsync(Exception? exception)
	{
		var userId = Convert.ToInt32(Context.GetHttpContext()?.Request.Query["UserId"]);
		_userConnectionManager.RemoveConnection(userId, Context.ConnectionId);
		return base.OnDisconnectedAsync(exception);
	}

}