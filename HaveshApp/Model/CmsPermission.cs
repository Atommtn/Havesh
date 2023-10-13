using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsPermission
    {
        public CmsPermission()
        {
            CmsWidgetRoles = new HashSet<CmsWidgetRole>();
            CommunityGroupRolePermissions = new HashSet<CommunityGroupRolePermission>();
            ForumsForumRoles = new HashSet<ForumsForumRole>();
            MediaLibraryRolePermissions = new HashSet<MediaLibraryRolePermission>();
            Roles = new HashSet<CmsRole>();
        }

        public int PermissionId { get; set; }
        public string PermissionDisplayName { get; set; } = null!;
        public string PermissionName { get; set; } = null!;
        public int? ClassId { get; set; }
        public int? ResourceId { get; set; }
        public Guid PermissionGuid { get; set; }
        public DateTime PermissionLastModified { get; set; }
        public string? PermissionDescription { get; set; }
        public bool? PermissionDisplayInMatrix { get; set; }
        public int? PermissionOrder { get; set; }
        public bool? PermissionEditableByGlobalAdmin { get; set; }

        public virtual CmsClass? Class { get; set; }
        public virtual CmsResource? Resource { get; set; }
        public virtual ICollection<CmsWidgetRole> CmsWidgetRoles { get; set; }
        public virtual ICollection<CommunityGroupRolePermission> CommunityGroupRolePermissions { get; set; }
        public virtual ICollection<ForumsForumRole> ForumsForumRoles { get; set; }
        public virtual ICollection<MediaLibraryRolePermission> MediaLibraryRolePermissions { get; set; }

        public virtual ICollection<CmsRole> Roles { get; set; }
    }
}
