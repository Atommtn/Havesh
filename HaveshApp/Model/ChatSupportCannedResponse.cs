using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ChatSupportCannedResponse
    {
        public int ChatSupportCannedResponseId { get; set; }
        public int? ChatSupportCannedResponseChatUserId { get; set; }
        public string ChatSupportCannedResponseText { get; set; } = null!;
        public string ChatSupportCannedResponseTagName { get; set; } = null!;
        public int? ChatSupportCannedResponseSiteId { get; set; }
        public string ChatSupportCannedResponseName { get; set; } = null!;

        public virtual ChatUser? ChatSupportCannedResponseChatUser { get; set; }
        public virtual CmsSite? ChatSupportCannedResponseSite { get; set; }
    }
}
