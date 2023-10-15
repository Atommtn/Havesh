using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsDeviceProfile
    {
        public CmsDeviceProfile()
        {
            CmsDeviceProfileLayouts = new HashSet<CmsDeviceProfileLayout>();
            CmsTemplateDeviceLayouts = new HashSet<CmsTemplateDeviceLayout>();
        }

        public int ProfileId { get; set; }
        public string ProfileName { get; set; } = null!;
        public string ProfileDisplayName { get; set; } = null!;
        public int? ProfileOrder { get; set; }
        public string? ProfileMacro { get; set; }
        public string? ProfileUserAgents { get; set; }
        public bool? ProfileEnabled { get; set; }
        public int? ProfilePreviewWidth { get; set; }
        public int? ProfilePreviewHeight { get; set; }
        public Guid? ProfileGuid { get; set; }
        public DateTime? ProfileLastModified { get; set; }

        public virtual ICollection<CmsDeviceProfileLayout> CmsDeviceProfileLayouts { get; set; }
        public virtual ICollection<CmsTemplateDeviceLayout> CmsTemplateDeviceLayouts { get; set; }
    }
}
