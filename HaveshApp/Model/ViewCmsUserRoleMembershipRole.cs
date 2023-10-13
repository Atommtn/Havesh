using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewCmsUserRoleMembershipRole
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public int? SiteId { get; set; }
        public int UserId { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}
