using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsLayout
    {
        public CmsLayout()
        {
            CmsDeviceProfileLayoutSourceLayouts = new HashSet<CmsDeviceProfileLayout>();
            CmsDeviceProfileLayoutTargetLayouts = new HashSet<CmsDeviceProfileLayout>();
            CmsPageTemplates = new HashSet<CmsPageTemplate>();
            CmsTemplateDeviceLayouts = new HashSet<CmsTemplateDeviceLayout>();
        }

        public int LayoutId { get; set; }
        public string LayoutCodeName { get; set; } = null!;
        public string LayoutDisplayName { get; set; } = null!;
        public string? LayoutDescription { get; set; }
        public string LayoutCode { get; set; } = null!;
        public string? LayoutVersionGuid { get; set; }
        public Guid LayoutGuid { get; set; }
        public DateTime LayoutLastModified { get; set; }
        public string? LayoutType { get; set; }
        public string? LayoutCss { get; set; }
        public Guid? LayoutThumbnailGuid { get; set; }
        public int? LayoutZoneCount { get; set; }
        public bool? LayoutIsConvertible { get; set; }
        public string? LayoutIconClass { get; set; }

        public virtual ICollection<CmsDeviceProfileLayout> CmsDeviceProfileLayoutSourceLayouts { get; set; }
        public virtual ICollection<CmsDeviceProfileLayout> CmsDeviceProfileLayoutTargetLayouts { get; set; }
        public virtual ICollection<CmsPageTemplate> CmsPageTemplates { get; set; }
        public virtual ICollection<CmsTemplateDeviceLayout> CmsTemplateDeviceLayouts { get; set; }
    }
}
