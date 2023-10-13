using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewCmsUserSettingsRoleJoined
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; } = null!;
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string RoleName { get; set; } = null!;
        public string RoleDisplayName { get; set; } = null!;
        public string? RoleDescription { get; set; }
        public int SiteId { get; set; }
        public string SiteName { get; set; } = null!;
        public bool UserEnabled { get; set; }
    }
}
