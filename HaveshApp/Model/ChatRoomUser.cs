using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ChatRoomUser
    {
        public int ChatRoomUserId { get; set; }
        public int ChatRoomUserRoomId { get; set; }
        public int ChatRoomUserChatUserId { get; set; }
        public DateTime? ChatRoomUserLastChecking { get; set; }
        public DateTime? ChatRoomUserKickExpiration { get; set; }
        public DateTime? ChatRoomUserJoinTime { get; set; }
        public DateTime? ChatRoomUserLeaveTime { get; set; }
        public int ChatRoomUserAdminLevel { get; set; }
        public DateTime ChatRoomUserLastModification { get; set; }

        public virtual ChatUser ChatRoomUserChatUser { get; set; } = null!;
        public virtual ChatRoom ChatRoomUserRoom { get; set; } = null!;
    }
}
