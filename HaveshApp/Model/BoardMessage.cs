using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class BoardMessage
    {
        public int MessageId { get; set; }
        public string MessageUserName { get; set; } = null!;
        public string MessageText { get; set; } = null!;
        public string MessageEmail { get; set; } = null!;
        public string MessageUrl { get; set; } = null!;
        public bool MessageIsSpam { get; set; }
        public int MessageBoardId { get; set; }
        public bool MessageApproved { get; set; }
        public int? MessageApprovedByUserId { get; set; }
        public int? MessageUserId { get; set; }
        public string MessageUserInfo { get; set; } = null!;
        public Guid? MessageAvatarGuid { get; set; }
        public DateTime MessageInserted { get; set; }
        public DateTime MessageLastModified { get; set; }
        public Guid MessageGuid { get; set; }
        public double? MessageRatingValue { get; set; }

        public virtual CmsUser? MessageApprovedByUser { get; set; }
        public virtual BoardBoard MessageBoard { get; set; } = null!;
        public virtual CmsUser? MessageUser { get; set; }
    }
}
