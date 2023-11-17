
using Havesh.Domain.Services;
using HaveshApp.Services;
using Microsoft.AspNetCore.SignalR;

//using Hub = Microsoft.AspNetCore.SignalR.Hub;

namespace HaveshApp.Classes.SignalR;

public class HaveshAppHub : Hub
{
	private readonly UserConnectionManagerService _userConnectionManager;
	private readonly DataProviderService _dataProviderService;

	public HaveshAppHub(UserConnectionManagerService userConnectionManager , DataProviderService dataProviderService)
	{
		_userConnectionManager = userConnectionManager;
		_dataProviderService = dataProviderService;
	}

	public override async Task OnConnectedAsync()
	{
		var userId = Convert.ToInt32(Context.GetHttpContext()?.Request.Query["UserId"]);
		var user = _dataProviderService.GetUserByUseId(userId);
		_userConnectionManager.AddConnection(user, Context.ConnectionId);
		await base.OnConnectedAsync();
	}

	public override Task OnDisconnectedAsync(Exception? exception)
	{
		var userId = Convert.ToInt32(Context.GetHttpContext()?.Request.Query["UserId"]);
		var user = _dataProviderService.GetUserByUseId(userId);
		_userConnectionManager.RemoveConnection(user, Context.ConnectionId);
		return base.OnDisconnectedAsync(exception);
	}

}