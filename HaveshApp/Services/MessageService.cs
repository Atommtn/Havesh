using HaveshApp.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HaveshApp.Classes.SignalR;
using HaveshApp.Admin.MemberShip.Model;
using HaveshApp.Classes;
using Microsoft.AspNetCore.SignalR;

namespace HaveshApp.Services
{
	public class MessageService
	{
		private IHubContext<HaveshAppHub> HubContext { get; }

		private readonly MessageDataProviderService _messageDataProvider;
		private readonly UserConnectionManagerService _connectionManagerService;

		public MessageService(MessageDataProviderService messageDataProvider , 
						      IHubContext<HaveshAppHub> hubContext,
						      UserConnectionManagerService connectionManagerService)
		{
			HubContext = hubContext;
			_messageDataProvider = messageDataProvider;
			_connectionManagerService = connectionManagerService;
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
			var connections = _connectionManagerService.GetOnlineUserConnections(message.To.Id);
			foreach (var connection in connections)
			{
				await HubContext.Clients.Client(connection).SendAsync("HandleIncomingMessage", message.Dto());
			}
			
		}

	}

	public class MessageDataProviderService : DataProviderService
	{
		public MessageDataProviderService(MyDbContext dbConntext, 
			FinancialService financialService) 
			: base(dbConntext, financialService)
		{

		}
		public async Task<List<Message>> GetMessagesAsync()
		{
			return await DbConntext.Messages
				.Include(m => m.From)
				.Include(m => m.To)
				.Include(m => m.Attachments)
				.Include(m => m.Actions)
				.ToListAsync();
		}

		public async Task<Message?> GetMessageByIdAsync(int messageId)
		{
			return await DbConntext.Messages
				.Include(m => m.From)
				.Include(m => m.To)
				.Include(m => m.Attachments)
				.Include(m => m.Actions)
				.FirstOrDefaultAsync(m => m.Id == messageId);
		}

		public async Task<List<Message>?> GetMessagesForUserAsync(int? userId)
		{
			if (userId == null) return null;
			return await DbConntext.Messages
				.Where(m => m.To.Id == userId)
				.Include(m => m.From)
				.Include(m => m.To)
				.Include(m => m.Attachments)
				.Include(m => m.Actions)
				.ToListAsync();
		}

		public async Task SendMessageAsync(Message message)
		{
			DbConntext.Messages.Add(message);
			await DbConntext.SaveChangesAsync();
		}
	}
}

