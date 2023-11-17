using MudBlazor;

namespace Havesh.Model.Data.Dashboard;

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
	public string? CommandArg { get; set; }

	public bool Replied { get; set; }
	public string? ReplyText { get; set; }
}