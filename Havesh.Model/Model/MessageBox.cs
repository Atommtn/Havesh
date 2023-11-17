using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;
using MudBlazor;

namespace Havesh.Model.Model;

public class MessageBox :BranchBaseModel
{
	public User Owner { get; set; }
	public List<Message> Messages { get; set; }
}

public class Message : BranchBaseModel
{
	public User From { get; set; }
	public User To { get; set; }
	public string? Title { get; set; }
	public string? Body { get; set; }
	public Severity Severity { get; set; }
	public DateTime CreateDateTime { get; set; }
	public DateTime? SentDateTime { get; set; }
	public DateTime? DeliveredDateTime { get; set; }
	public DateTime? ReadDateTime { get; set; }
	public List<ShokouhPardisMediaAttachment>? Attachments { get; set; }
	public MessageTypeEnum Type { get; set; }
	public string? Command { get; set; }
	public string? CommandArg { get; set; }
	public List<MessageAction>? Actions { get; set; }
	public int? ReplyToMessageId { get; set; }
		
	[ForeignKey(nameof(ReplyToMessageId))]
	public Message? ReplyToMessage { get; set; }
	public string? ReplyOriginalMessage { get; set; }
}

public class MessageAction : BranchBaseModel
{
	public string ActionType { get; set; }
	public List<MessageActionOption> Options { get; set; }
}

public class MessageActionOption : BranchBaseModel
{
	public string Title { get; set; }
	public string? Value { get; set; }
	public string? Color { get; set; }
	public string? Icon { get; set; }
	public string? ActionUrl { get; set; }
}