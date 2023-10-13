using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsTimeZone
    {
        public CmsTimeZone()
        {
            CmsUserSettings = new HashSet<CmsUserSetting>();
        }

        public int TimeZoneId { get; set; }
        public string TimeZoneName { get; set; } = null!;
        public string TimeZoneDisplayName { get; set; } = null!;
        public double TimeZoneGmt { get; set; }
        public bool? TimeZoneDaylight { get; set; }
        public DateTime TimeZoneRuleStartIn { get; set; }
        public string TimeZoneRuleStartRule { get; set; } = null!;
        public DateTime TimeZoneRuleEndIn { get; set; }
        public string TimeZoneRuleEndRule { get; set; } = null!;
        public Guid TimeZoneGuid { get; set; }
        public DateTime TimeZoneLastModified { get; set; }

        public virtual ICollection<CmsUserSetting> CmsUserSettings { get; set; }
    }
}
