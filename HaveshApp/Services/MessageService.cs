using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Havesh.Model.Model;
using HaveshApp.Classes.SignalR;
using Microsoft.AspNetCore.SignalR;
using HaveshApp.Classes.ExtensionMethods;
using Havesh.OrleansClient;

namespace Havesh.Domain.Services;

public class MessageService
{
	private IHubContext<HaveshAppHub> HubContext { get; }

	private readonly MessageDataProviderService _messageDataProvider;
    private readonly SignalrGrainClientService _signalrGrainClientService;

	public MessageService(MessageDataProviderService messageDataProvider , 
		IHubContext<HaveshAppHub> hubContext,
        SignalrGrainClientService signalrGrainClientService)
	{
		HubContext = hubContext;
		_messageDataProvider = messageDataProvider;
        _signalrGrainClientService = signalrGrainClientService;
	}

	public async Task<List<Message>> GetMessages()
	{
		return await _messageDataProvider.GetMessagesAsync();
	}

	public async Task<Message?> GetMessageById(int messageId)
	{
		return await _messageDataProvider.GetMessageByIdAsync(messageId);
	}

	public async Task<List<Message>?> GetMessagesForUserAsync(int? userId)
	{
		if (userId == null)
		{
			return null;
		}
		return await _messageDataProvider.GetMessagesForUserAsync(userId);
	}

	public async Task SendMessageAsync(Message message)
	{
		await _messageDataProvider.SendMessageAsync(message);
		var connections = await _signalrGrainClientService.GetOnlineUserConnections(message.To);
        if (connections != null)
            foreach (var connection in connections)
            {
                await HubContext.Clients.Client(connection).SendAsync("HandleIncomingMessage", message.Dto());
            }
    }

	public async Task SendMessageToRolesAsync(Message message , string[] roles)
	{
		await _messageDataProvider.SendMessageAsync(message);
		var connections = await _signalrGrainClientService.GetOnlineConnectionsUserInRole(roles);
        if (connections != null)
            foreach (var connection in connections)
            {
                await HubContext
                    .Clients
                    .Client(connection.ConnectionId)
                    .SendAsync("HandleIncomingMessage", message.Dto());
            }
    }

}