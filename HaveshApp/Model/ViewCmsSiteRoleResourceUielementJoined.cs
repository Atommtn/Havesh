using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewCmsSiteRoleResourceUielementJoined
    {
        public string RoleName { get; set; } = null!;
        public int RoleId { get; set; }
        public string ElementName { get; set; } = null!;
        public string? SiteName { get; set; }
        public string ResourceName { get; set; } = null!;
        public int? RoleSiteId { get; set; }
    }
}
