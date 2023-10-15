using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ChatUser
    {
        public ChatUser()
        {
            ChatInitiatedChatRequests = new HashSet<ChatInitiatedChatRequest>();
            ChatMessageChatMessageRecipients = new HashSet<ChatMessage>();
            ChatMessageChatMessageUsers = new HashSet<ChatMessage>();
            ChatNotificationChatNotificationReceivers = new HashSet<ChatNotification>();
            ChatNotificationChatNotificationSenders = new HashSet<ChatNotification>();
            ChatOnlineSupports = new HashSet<ChatOnlineSupport>();
            ChatOnlineUsers = new HashSet<ChatOnlineUser>();
            ChatRoomUsers = new HashSet<ChatRoomUser>();
            ChatRooms = new HashSet<ChatRoom>();
            ChatSupportCannedResponses = new HashSet<ChatSupportCannedResponse>();
            ChatSupportTakenRooms = new HashSet<ChatSupportTakenRoom>();
        }

        public int ChatUserId { get; set; }
        public int? ChatUserUserId { get; set; }
        public string ChatUserNickname { get; set; } = null!;
        public DateTime ChatUserLastModification { get; set; }

        public virtual CmsUser? ChatUserUser { get; set; }
        public virtual ICollection<ChatInitiatedChatRequest> ChatInitiatedChatRequests { get; set; }
        public virtual ICollection<ChatMessage> ChatMessageChatMessageRecipients { get; set; }
        public virtual ICollection<ChatMessage> ChatMessageChatMessageUsers { get; set; }
        public virtual ICollection<ChatNotification> ChatNotificationChatNotificationReceivers { get; set; }
        public virtual ICollection<ChatNotification> ChatNotificationChatNotificationSenders { get; set; }
        public virtual ICollection<ChatOnlineSupport> ChatOnlineSupports { get; set; }
        public virtual ICollection<ChatOnlineUser> ChatOnlineUsers { get; set; }
        public virtual ICollection<ChatRoomUser> ChatRoomUsers { get; set; }
        public virtual ICollection<ChatRoom> ChatRooms { get; set; }
        public virtual ICollection<ChatSupportCannedResponse> ChatSupportCannedResponses { get; set; }
        public virtual ICollection<ChatSupportTakenRoom> ChatSupportTakenRooms { get; set; }
    }
}
