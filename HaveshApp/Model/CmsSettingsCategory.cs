using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsSettingsCategory
    {
        public CmsSettingsCategory()
        {
            CmsSettingsKeys = new HashSet<CmsSettingsKey>();
            InverseCategoryParent = new HashSet<CmsSettingsCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; } = null!;
        public int? CategoryOrder { get; set; }
        public string? CategoryName { get; set; }
        public int? CategoryParentId { get; set; }
        public string? CategoryIdpath { get; set; }
        public int? CategoryLevel { get; set; }
        public int? CategoryChildCount { get; set; }
        public string? CategoryIconPath { get; set; }
        public bool? CategoryIsGroup { get; set; }
        public bool? CategoryIsCustom { get; set; }
        public int? CategoryResourceId { get; set; }

        public virtual CmsSettingsCategory? CategoryParent { get; set; }
        public virtual CmsResource? CategoryResource { get; set; }
        public virtual ICollection<CmsSettingsKey> CmsSettingsKeys { get; set; }
        public virtual ICollection<CmsSettingsCategory> InverseCategoryParent { get; set; }
    }
}
