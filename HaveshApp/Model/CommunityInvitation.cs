using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CommunityInvitation
    {
        public int InvitationId { get; set; }
        public int? InvitedUserId { get; set; }
        public int InvitedByUserId { get; set; }
        public int? InvitationGroupId { get; set; }
        public DateTime? InvitationCreated { get; set; }
        public DateTime? InvitationValidTo { get; set; }
        public string? InvitationComment { get; set; }
        public Guid InvitationGuid { get; set; }
        public DateTime InvitationLastModified { get; set; }
        public string? InvitationUserEmail { get; set; }

        public virtual CommunityGroup? InvitationGroup { get; set; }
        public virtual CmsUser InvitedByUser { get; set; } = null!;
        public virtual CmsUser? InvitedUser { get; set; }
    }
}
