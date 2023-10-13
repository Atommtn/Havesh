using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsWidgetCategory
    {
        public CmsWidgetCategory()
        {
            CmsWidgets = new HashSet<CmsWidget>();
            InverseWidgetCategoryParent = new HashSet<CmsWidgetCategory>();
        }

        public int WidgetCategoryId { get; set; }
        public string WidgetCategoryName { get; set; } = null!;
        public string WidgetCategoryDisplayName { get; set; } = null!;
        public int? WidgetCategoryParentId { get; set; }
        public string WidgetCategoryPath { get; set; } = null!;
        public int WidgetCategoryLevel { get; set; }
        public int? WidgetCategoryChildCount { get; set; }
        public int? WidgetCategoryWidgetChildCount { get; set; }
        public string? WidgetCategoryImagePath { get; set; }
        public Guid WidgetCategoryGuid { get; set; }
        public DateTime WidgetCategoryLastModified { get; set; }

        public virtual CmsWidgetCategory? WidgetCategoryParent { get; set; }
        public virtual ICollection<CmsWidget> CmsWidgets { get; set; }
        public virtual ICollection<CmsWidgetCategory> InverseWidgetCategoryParent { get; set; }
    }
}
