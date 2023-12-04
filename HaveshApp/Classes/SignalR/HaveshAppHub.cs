
using Havesh.Domain.Services;
using Havesh.OrleansClient;
using Microsoft.AspNetCore.SignalR;

//using Hub = Microsoft.AspNetCore.SignalR.Hub;

namespace HaveshApp.Classes.SignalR;

public class HaveshAppHub : Hub
{
	private readonly SignalrGrainClientService _signalrGrainClientService;

	public HaveshAppHub(SignalrGrainClientService signalrGrainClientService)
	{
		_signalrGrainClientService = signalrGrainClientService;
	}

	public override async Task OnConnectedAsync()
	{
		var userId = Convert.ToInt32(Context.GetHttpContext()?.Request.Query["UserId"]);
        var ip = Context.GetHttpContext()?.Connection.RemoteIpAddress?.ToString();
        await _signalrGrainClientService.RegisterUser(userId,ip, Context.ConnectionId);

		await base.OnConnectedAsync();
	}

	public override async Task OnDisconnectedAsync(Exception? exception)
	{
		var userId = Convert.ToInt32(Context.GetHttpContext()?.Request.Query["UserId"]);
		await _signalrGrainClientService.UnregisterUser(userId, Context.ConnectionId);

		await base.OnDisconnectedAsync(exception);
	}

}