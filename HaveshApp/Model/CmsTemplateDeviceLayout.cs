using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsTemplateDeviceLayout
    {
        public int TemplateDeviceLayoutId { get; set; }
        public int PageTemplateId { get; set; }
        public int ProfileId { get; set; }
        public int? LayoutId { get; set; }
        public string? LayoutCode { get; set; }
        public string? LayoutType { get; set; }
        public string? LayoutCss { get; set; }
        public DateTime LayoutLastModified { get; set; }
        public Guid LayoutGuid { get; set; }
        public string? LayoutVersionGuid { get; set; }

        public virtual CmsLayout? Layout { get; set; }
        public virtual CmsPageTemplate PageTemplate { get; set; } = null!;
        public virtual CmsDeviceProfile Profile { get; set; } = null!;
    }
}
