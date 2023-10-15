using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsWebPartLayout
    {
        public CmsWebPartLayout()
        {
            CmsWidgets = new HashSet<CmsWidget>();
        }

        public int WebPartLayoutId { get; set; }
        public string WebPartLayoutCodeName { get; set; } = null!;
        public string WebPartLayoutDisplayName { get; set; } = null!;
        public string? WebPartLayoutDescription { get; set; }
        public string? WebPartLayoutCode { get; set; }
        public string? WebPartLayoutVersionGuid { get; set; }
        public int WebPartLayoutWebPartId { get; set; }
        public Guid WebPartLayoutGuid { get; set; }
        public DateTime WebPartLayoutLastModified { get; set; }
        public string? WebPartLayoutCss { get; set; }
        public bool? WebPartLayoutIsDefault { get; set; }

        public virtual CmsWebPart WebPartLayoutWebPart { get; set; } = null!;
        public virtual ICollection<CmsWidget> CmsWidgets { get; set; }
    }
}
