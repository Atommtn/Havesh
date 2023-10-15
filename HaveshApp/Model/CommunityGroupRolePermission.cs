using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CommunityGroupRolePermission
    {
        public int GroupId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual CommunityGroup Group { get; set; } = null!;
        public virtual CmsPermission Permission { get; set; } = null!;
        public virtual CmsRole Role { get; set; } = null!;
    }
}
