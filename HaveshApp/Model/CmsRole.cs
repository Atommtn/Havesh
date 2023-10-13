using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsRole
    {
        public CmsRole()
        {
            CmsAclitems = new HashSet<CmsAclitem>();
            CmsUserRoles = new HashSet<CmsUserRole>();
            CmsWidgetRoles = new HashSet<CmsWidgetRole>();
            CmsWorkflowStepRoles = new HashSet<CmsWorkflowStepRole>();
            CommunityGroupRolePermissions = new HashSet<CommunityGroupRolePermission>();
            ForumsForumRoles = new HashSet<ForumsForumRole>();
            MediaLibraryRolePermissions = new HashSet<MediaLibraryRolePermission>();
            Boards = new HashSet<BoardBoard>();
            Elements = new HashSet<CmsUielement>();
            ElementsNavigation = new HashSet<CmsUielement>();
            Forms = new HashSet<CmsForm>();
            Memberships = new HashSet<CmsMembership>();
            Permissions = new HashSet<CmsPermission>();
            Polls = new HashSet<PollsPoll>();
        }

        public int RoleId { get; set; }
        public string RoleDisplayName { get; set; } = null!;
        public string RoleName { get; set; } = null!;
        public string? RoleDescription { get; set; }
        public int? SiteId { get; set; }
        public Guid RoleGuid { get; set; }
        public DateTime RoleLastModified { get; set; }
        public int? RoleGroupId { get; set; }
        public bool? RoleIsGroupAdministrator { get; set; }
        public bool? RoleIsDomain { get; set; }

        public virtual CommunityGroup? RoleGroup { get; set; }
        public virtual CmsSite? Site { get; set; }
        public virtual ICollection<CmsAclitem> CmsAclitems { get; set; }
        public virtual ICollection<CmsUserRole> CmsUserRoles { get; set; }
        public virtual ICollection<CmsWidgetRole> CmsWidgetRoles { get; set; }
        public virtual ICollection<CmsWorkflowStepRole> CmsWorkflowStepRoles { get; set; }
        public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermissions { get; set; }
        public virtual ICollection<ForumsForumRole> ForumsForumRoles { get; set; }
        public virtual ICollection<MediaLibraryRolePermission> MediaLibraryRolePermissions { get; set; }

        public virtual ICollection<BoardBoard> Boards { get; set; }
        public virtual ICollection<CmsUielement> Elements { get; set; }
        public virtual ICollection<CmsUielement> ElementsNavigation { get; set; }
        public virtual ICollection<CmsForm> Forms { get; set; }
        public virtual ICollection<CmsMembership> Memberships { get; set; }
        public virtual ICollection<CmsPermission> Permissions { get; set; }
        public virtual ICollection<PollsPoll> Polls { get; set; }
    }
}
