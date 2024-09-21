using Havesh.Application.Services;
using Havesh.Domain.Infrastructure;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace Havesh.Domain.Services;

public class MessageDataProviderService : DataProviderService
{
	public MessageDataProviderService(
		MyDbContextFactory dbContextFactory,
		GrainEntityDependency grainEntityDependency, IClusterClient clusterClient)
		: base(dbContextFactory, grainEntityDependency, clusterClient)
	{

	}
	public async Task<List<Message>> GetMessagesAsync()
	{
		return await DbContext.Messages
			.Include(m => m.From)
			.Include(m => m.To)
			.Include(m => m.Attachments)
			.Include(m => m.Actions)
			.ToListAsync();
	}

	public async Task<Message?> GetMessageByIdAsync(int messageId)
	{
		return await DbContext.Messages
			.Include(m => m.From)
			.Include(m => m.To)
			.Include(m => m.Attachments)
			.Include(m => m.Actions)
			.FirstOrDefaultAsync(m => m.Id == messageId);
	}

	public async Task<List<Message>?> GetMessagesForUserAsync(int? userId)
	{
		if (userId == null) return null;
		return await DbContext.Messages
			.Where(m => m.To.Id == userId)
			.Include(m => m.From)
			.Include(m => m.To)
			.Include(m => m.Attachments)
			.Include(m => m.Actions)
			.ToListAsync();
	}

	public async Task SendMessageAsync(Message message)
	{
		DbContext.Messages.Add(message);
		await DbContext.SaveChangesAsync();
	}
}