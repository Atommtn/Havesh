using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsMembershipUser
    {
        public int MembershipUserId { get; set; }
        public int MembershipId { get; set; }
        public int UserId { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool? SendNotification { get; set; }

        public virtual CmsMembership Membership { get; set; } = null!;
        public virtual CmsUser User { get; set; } = null!;
    }
}
