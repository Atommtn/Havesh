using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsObjectVersionHistory
    {
        public CmsObjectVersionHistory()
        {
            CmsObjectSettingObjectCheckedOutVersionHistories = new HashSet<CmsObjectSetting>();
            CmsObjectSettingObjectPublishedVersionHistories = new HashSet<CmsObjectSetting>();
        }

        public int VersionId { get; set; }
        public int? VersionObjectId { get; set; }
        public string VersionObjectType { get; set; } = null!;
        public int? VersionObjectSiteId { get; set; }
        public string VersionObjectDisplayName { get; set; } = null!;
        public string VersionXml { get; set; } = null!;
        public string? VersionBinaryDataXml { get; set; }
        public int? VersionModifiedByUserId { get; set; }
        public DateTime VersionModifiedWhen { get; set; }
        public int? VersionDeletedByUserId { get; set; }
        public DateTime? VersionDeletedWhen { get; set; }
        public string VersionNumber { get; set; } = null!;
        public string? VersionSiteBindingIds { get; set; }
        public string? VersionComment { get; set; }

        public virtual CmsUser? VersionDeletedByUser { get; set; }
        public virtual CmsUser? VersionModifiedByUser { get; set; }
        public virtual CmsSite? VersionObjectSite { get; set; }
        public virtual ICollection<CmsObjectSetting> CmsObjectSettingObjectCheckedOutVersionHistories { get; set; }
        public virtual ICollection<CmsObjectSetting> CmsObjectSettingObjectPublishedVersionHistories { get; set; }
    }
}
