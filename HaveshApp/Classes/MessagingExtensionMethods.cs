using Havesh.Model.Data;
using Havesh.Model.Model;
using MudBlazor;

namespace HaveshApp.Classes;

public static class MessagingExtensionMethods
{
	public static MessageDto Dto(this Message message)
	{
		return new MessageDto
		{
			MessageId = message.Id,
			SentDateTime = message.CreateDateTime,
			MessageType = message.Type,
			Severity = message.Severity ,
			FromUserFullName = message.From.ToString(true,true),
			FromUserId = message.From.Id,
			ToUserId = message.To.Id,
			Title = message.Title,
			Body = message.Body,
			Command = message.Command,
		};
	}
}

public class MessageDto
{
	public int MessageId { get; set; }
	public MessageTypeEnum MessageType { get; set; }
	public Severity Severity { get; set; }
	public string FromUserFullName { get; set; }
	public int FromUserId { get; set; }
	public int ToUserId { get; set; }
	public string? Title { get; set; }
	public string? Body { get; set; }
	public DateTime SentDateTime { get; set; }
	public string? Command { get; set; }
		
	public bool Replied { get; set; }
	public string? ReplyText { get; set; }
}