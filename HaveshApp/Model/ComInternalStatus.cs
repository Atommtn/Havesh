using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComInternalStatus
    {
        public ComInternalStatus()
        {
            ComSkus = new HashSet<ComSku>();
        }

        public int InternalStatusId { get; set; }
        public string InternalStatusName { get; set; } = null!;
        public string InternalStatusDisplayName { get; set; } = null!;
        public bool? InternalStatusEnabled { get; set; }
        public Guid InternalStatusGuid { get; set; }
        public DateTime InternalStatusLastModified { get; set; }
        public int? InternalStatusSiteId { get; set; }

        public virtual CmsSite? InternalStatusSite { get; set; }
        public virtual ICollection<ComSku> ComSkus { get; set; }
    }
}
