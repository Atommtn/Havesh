using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsAclitem
    {
        public int AclitemId { get; set; }
        public int Aclid { get; set; }
        public int? UserId { get; set; }
        public int? RoleId { get; set; }
        public int Allowed { get; set; }
        public int Denied { get; set; }
        public DateTime LastModified { get; set; }
        public int? LastModifiedByUserId { get; set; }
        public Guid AclitemGuid { get; set; }

        public virtual CmsAcl Acl { get; set; } = null!;
        public virtual CmsUser? LastModifiedByUser { get; set; }
        public virtual CmsRole? Role { get; set; }
        public virtual CmsUser? User { get; set; }
    }
}
