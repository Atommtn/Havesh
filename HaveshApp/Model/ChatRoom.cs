using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ChatRoom
    {
        public ChatRoom()
        {
            ChatMessages = new HashSet<ChatMessage>();
            ChatNotifications = new HashSet<ChatNotification>();
            ChatRoomUsers = new HashSet<ChatRoomUser>();
            ChatSupportTakenRooms = new HashSet<ChatSupportTakenRoom>();
        }

        public int ChatRoomId { get; set; }
        public string ChatRoomName { get; set; } = null!;
        public string ChatRoomDisplayName { get; set; } = null!;
        public int? ChatRoomSiteId { get; set; }
        public bool ChatRoomEnabled { get; set; }
        public bool ChatRoomPrivate { get; set; }
        public bool ChatRoomAllowAnonym { get; set; }
        public DateTime ChatRoomCreatedWhen { get; set; }
        public string? ChatRoomPassword { get; set; }
        public int? ChatRoomCreatedByChatUserId { get; set; }
        public bool ChatRoomIsSupport { get; set; }
        public bool ChatRoomIsOneToOne { get; set; }
        public string? ChatRoomDescription { get; set; }
        public DateTime ChatRoomLastModification { get; set; }
        public DateTime? ChatRoomScheduledToDelete { get; set; }
        public DateTime ChatRoomPrivateStateLastModification { get; set; }
        public Guid ChatRoomGuid { get; set; }

        public virtual ChatUser? ChatRoomCreatedByChatUser { get; set; }
        public virtual CmsSite? ChatRoomSite { get; set; }
        public virtual ChatInitiatedChatRequest? ChatInitiatedChatRequest { get; set; }
        public virtual ICollection<ChatMessage> ChatMessages { get; set; }
        public virtual ICollection<ChatNotification> ChatNotifications { get; set; }
        public virtual ICollection<ChatRoomUser> ChatRoomUsers { get; set; }
        public virtual ICollection<ChatSupportTakenRoom> ChatSupportTakenRooms { get; set; }
    }
}
