using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class BoardSubscription
    {
        public int SubscriptionId { get; set; }
        public int SubscriptionBoardId { get; set; }
        public int? SubscriptionUserId { get; set; }
        public string SubscriptionEmail { get; set; } = null!;
        public DateTime SubscriptionLastModified { get; set; }
        public Guid SubscriptionGuid { get; set; }
        public bool? SubscriptionApproved { get; set; }
        public string? SubscriptionApprovalHash { get; set; }

        public virtual BoardBoard SubscriptionBoard { get; set; } = null!;
        public virtual CmsUser? SubscriptionUser { get; set; }
    }
}
