using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewCmsAclitemItemsAndOperator
    {
        public int AclownerNodeId { get; set; }
        public int AclitemId { get; set; }
        public int Allowed { get; set; }
        public int Denied { get; set; }
        public string? Operator { get; set; }
        public string? OperatorName { get; set; }
        public int Aclid { get; set; }
        public string? OperatorFullName { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public int? RoleGroupId { get; set; }
        public int? SiteId { get; set; }
    }
}
