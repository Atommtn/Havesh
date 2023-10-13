using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ChatSupportTakenRoom
    {
        public int ChatSupportTakenRoomId { get; set; }
        public int? ChatSupportTakenRoomChatUserId { get; set; }
        public int ChatSupportTakenRoomRoomId { get; set; }
        public DateTime? ChatSupportTakenRoomResolvedDateTime { get; set; }
        public DateTime ChatSupportTakenRoomLastModification { get; set; }

        public virtual ChatUser? ChatSupportTakenRoomChatUser { get; set; }
        public virtual ChatRoom ChatSupportTakenRoomRoom { get; set; } = null!;
    }
}
