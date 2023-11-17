using Havesh.Model.Data.Dashboard;
using Havesh.Model.Model;

namespace HaveshApp.Classes.ExtensionMethods;

public static class MessagingExtensionMethods
{
    public static MessageDto Dto(this Message message)
    {
        return new MessageDto
        {
            MessageId = message.Id,
            SentDateTime = message.CreateDateTime,
            MessageType = message.Type,
            Severity = message.Severity,
            FromUserFullName = message.From.ToString(true, true),
            FromUserId = message.From.Id,
            ToUserId = message.To.Id,
            Title = message.Title,
            Body = message.Body,
            Command = message.Command,
            CommandArg = message.CommandArg,
        };
    }
}