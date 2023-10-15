using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CommunityGroup
    {
        public CommunityGroup()
        {
            BoardBoards = new HashSet<BoardBoard>();
            CmsRoles = new HashSet<CmsRole>();
            CmsTrees = new HashSet<CmsTree>();
            CommunityGroupMembers = new HashSet<CommunityGroupMember>();
            CommunityGroupRolePermissions = new HashSet<CommunityGroupRolePermission>();
            CommunityInvitations = new HashSet<CommunityInvitation>();
            ForumsForumGroups = new HashSet<ForumsForumGroup>();
            ForumsForums = new HashSet<ForumsForum>();
            MediaLibraries = new HashSet<MediaLibrary>();
            PollsPolls = new HashSet<PollsPoll>();
        }

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

        public virtual CmsUser? GroupApprovedByUser { get; set; }
        public virtual CmsAvatar? GroupAvatar { get; set; }
        public virtual CmsUser? GroupCreatedByUser { get; set; }
        public virtual CmsSite GroupSite { get; set; } = null!;
        public virtual ICollection<BoardBoard> BoardBoards { get; set; }
        public virtual ICollection<CmsRole> CmsRoles { get; set; }
        public virtual ICollection<CmsTree> CmsTrees { get; set; }
        public virtual ICollection<CommunityGroupMember> CommunityGroupMembers { get; set; }
        public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermissions { get; set; }
        public virtual ICollection<CommunityInvitation> CommunityInvitations { get; set; }
        public virtual ICollection<ForumsForumGroup> ForumsForumGroups { get; set; }
        public virtual ICollection<ForumsForum> ForumsForums { get; set; }
        public virtual ICollection<MediaLibrary> MediaLibraries { get; set; }
        public virtual ICollection<PollsPoll> PollsPolls { get; set; }
    }
}
