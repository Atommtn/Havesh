using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsMembership
    {
        public CmsMembership()
        {
            CmsMembershipUsers = new HashSet<CmsMembershipUser>();
            Roles = new HashSet<CmsRole>();
        }

        public int MembershipId { get; set; }
        public string MembershipName { get; set; } = null!;
        public string MembershipDisplayName { get; set; } = null!;
        public string? MembershipDescription { get; set; }
        public DateTime MembershipLastModified { get; set; }
        public Guid MembershipGuid { get; set; }
        public int? MembershipSiteId { get; set; }

        public virtual CmsSite? MembershipSite { get; set; }
        public virtual ICollection<CmsMembershipUser> CmsMembershipUsers { get; set; }

        public virtual ICollection<CmsRole> Roles { get; set; }
    }
}
