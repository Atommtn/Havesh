using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CommunityGroupMember
    {
        public int MemberId { get; set; }
        public Guid MemberGuid { get; set; }
        public int MemberUserId { get; set; }
        public int MemberGroupId { get; set; }
        public DateTime MemberJoined { get; set; }
        public DateTime? MemberApprovedWhen { get; set; }
        public DateTime? MemberRejectedWhen { get; set; }
        public int? MemberApprovedByUserId { get; set; }
        public string? MemberComment { get; set; }
        public int? MemberInvitedByUserId { get; set; }
        public int? MemberStatus { get; set; }

        public virtual CmsUser? MemberApprovedByUser { get; set; }
        public virtual CommunityGroup MemberGroup { get; set; } = null!;
        public virtual CmsUser? MemberInvitedByUser { get; set; }
        public virtual CmsUser MemberUser { get; set; } = null!;
    }
}
