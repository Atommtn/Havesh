using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewCmsRoleResourcePermissionJoined
    {
        public int RoleId { get; set; }
        public string ResourceName { get; set; } = null!;
        public string PermissionName { get; set; } = null!;
        public int PermissionId { get; set; }
    }
}
