using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewCmsUserRoleJoined
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime? ValidTo { get; set; }
        public string UserName { get; set; } = null!;
        public string? FullName { get; set; }
        public Guid UserGuid { get; set; }
        public string RoleName { get; set; } = null!;
        public string RoleDisplayName { get; set; } = null!;
        public Guid RoleGuid { get; set; }
        public int? RoleGroupId { get; set; }
        public int? SiteId { get; set; }
        public string? SiteName { get; set; }
        public Guid? SiteGuid { get; set; }
    }
}
