using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ChatOnlineUser
    {
        public int ChatOnlineUserId { get; set; }
        public int ChatOnlineUserSiteId { get; set; }
        public DateTime? ChatOnlineUserLastChecking { get; set; }
        public int ChatOnlineUserChatUserId { get; set; }
        public DateTime? ChatOnlineUserJoinTime { get; set; }
        public DateTime? ChatOnlineUserLeaveTime { get; set; }
        public string? ChatOnlineUserToken { get; set; }
        public bool ChatOnlineUserIsHidden { get; set; }

        public virtual ChatUser ChatOnlineUserChatUser { get; set; } = null!;
        public virtual CmsSite ChatOnlineUserSite { get; set; } = null!;
    }
}
