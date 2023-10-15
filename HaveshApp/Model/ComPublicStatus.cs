using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComPublicStatus
    {
        public ComPublicStatus()
        {
            ComSkus = new HashSet<ComSku>();
        }

        public int PublicStatusId { get; set; }
        public string PublicStatusName { get; set; } = null!;
        public string PublicStatusDisplayName { get; set; } = null!;
        public bool? PublicStatusEnabled { get; set; }
        public Guid? PublicStatusGuid { get; set; }
        public DateTime PublicStatusLastModified { get; set; }
        public int? PublicStatusSiteId { get; set; }

        public virtual CmsSite? PublicStatusSite { get; set; }
        public virtual ICollection<ComSku> ComSkus { get; set; }
    }
}
