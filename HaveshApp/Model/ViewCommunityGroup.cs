using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewCommunityGroup
    {
        public int GroupId { get; set; }
        public Guid GroupGuid { get; set; }
        public DateTime GroupLastModified { get; set; }
        public int GroupSiteId { get; set; }
        public string GroupDisplayName { get; set; } = null!;
        public string GroupName { get; set; } = null!;
        public string GroupDescription { get; set; } = null!;
        public Guid? GroupNodeGuid { get; set; }
        public int GroupApproveMembers { get; set; }
        public int GroupAccess { get; set; }
        public int? GroupCreatedByUserId { get; set; }
        public int? GroupApprovedByUserId { get; set; }
        public int? GroupAvatarId { get; set; }
        public bool? GroupApproved { get; set; }
        public DateTime GroupCreatedWhen { get; set; }
        public bool? GroupSendJoinLeaveNotification { get; set; }
        public bool? GroupSendWaitingForApprovalNotification { get; set; }
        public int? GroupSecurity { get; set; }
        public bool? GroupLogActivity { get; set; }
        public int? AvatarId { get; set; }
        public string? AvatarFileName { get; set; }
        public Guid? AvatarGuid { get; set; }
    }
}
