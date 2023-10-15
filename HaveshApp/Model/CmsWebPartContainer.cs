using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsWebPartContainer
    {
        public CmsWebPartContainer()
        {
            Sites = new HashSet<CmsSite>();
        }

        public int ContainerId { get; set; }
        public string ContainerDisplayName { get; set; } = null!;
        public string ContainerName { get; set; } = null!;
        public string? ContainerTextBefore { get; set; }
        public string? ContainerTextAfter { get; set; }
        public Guid ContainerGuid { get; set; }
        public DateTime ContainerLastModified { get; set; }
        public string? ContainerCss { get; set; }

        public virtual ICollection<CmsSite> Sites { get; set; }
    }
}
