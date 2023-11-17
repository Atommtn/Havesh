using Havesh.Model.Data.Dashboard;
using HaveshApp.Admin.Authentication;
using HaveshApp.Classes.ExtensionMethods;
using HaveshApp.Classes.SignalR;
using Microsoft.AspNetCore.SignalR;

namespace Havesh.Domain.Services;

public class MessageHandlingService
{
	private readonly IHubContext<HaveshAppHub> _hubContext;
	private readonly UserSessionService _userSessionService;

	public MessageHandlingService(IHubContext<HaveshAppHub> hubContext,UserSessionService userSessionService)
	{
		_hubContext = hubContext;
		_userSessionService = userSessionService;
	}

	public void HandleIncomingMessage(MessageDto messageDto)
	{
		if (messageDto == null) 
			throw new ArgumentNullException(nameof(messageDto));

		_userSessionService.NotifyNewMessageDelivered(messageDto);
	}
}