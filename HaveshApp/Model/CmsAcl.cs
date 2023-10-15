using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsAcl
    {
        public CmsAcl()
        {
            CmsAclitems = new HashSet<CmsAclitem>();
            CmsTrees = new HashSet<CmsTree>();
        }

        public int Aclid { get; set; }
        public string AclinheritedAcls { get; set; } = null!;
        public Guid Aclguid { get; set; }
        public DateTime AcllastModified { get; set; }
        public int? AclsiteId { get; set; }

        public virtual CmsSite? Aclsite { get; set; }
        public virtual ICollection<CmsAclitem> CmsAclitems { get; set; }
        public virtual ICollection<CmsTree> CmsTrees { get; set; }
    }
}
