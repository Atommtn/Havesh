using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsBadge
    {
        public CmsBadge()
        {
            CmsUserSettings = new HashSet<CmsUserSetting>();
        }

        public int BadgeId { get; set; }
        public string BadgeName { get; set; } = null!;
        public string BadgeDisplayName { get; set; } = null!;
        public string? BadgeImageUrl { get; set; }
        public bool BadgeIsAutomatic { get; set; }
        public int? BadgeTopLimit { get; set; }
        public Guid BadgeGuid { get; set; }
        public DateTime BadgeLastModified { get; set; }

        public virtual ICollection<CmsUserSetting> CmsUserSettings { get; set; }
    }
}
