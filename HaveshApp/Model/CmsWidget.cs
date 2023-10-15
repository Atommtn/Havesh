using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsWidget
    {
        public CmsWidget()
        {
            CmsWidgetRoles = new HashSet<CmsWidgetRole>();
        }

        public int WidgetId { get; set; }
        public int WidgetWebPartId { get; set; }
        public string WidgetDisplayName { get; set; } = null!;
        public string WidgetName { get; set; } = null!;
        public string? WidgetDescription { get; set; }
        public int WidgetCategoryId { get; set; }
        public string? WidgetProperties { get; set; }
        public int WidgetSecurity { get; set; }
        public Guid WidgetGuid { get; set; }
        public DateTime WidgetLastModified { get; set; }
        public bool WidgetIsEnabled { get; set; }
        public bool WidgetForGroup { get; set; }
        public bool WidgetForEditor { get; set; }
        public bool WidgetForUser { get; set; }
        public bool WidgetForDashboard { get; set; }
        public bool WidgetForInline { get; set; }
        public string? WidgetDocumentation { get; set; }
        public string? WidgetDefaultValues { get; set; }
        public int? WidgetLayoutId { get; set; }
        public bool? WidgetSkipInsertProperties { get; set; }
        public Guid? WidgetThumbnailGuid { get; set; }
        public string? WidgetIconClass { get; set; }

        public virtual CmsWidgetCategory WidgetCategory { get; set; } = null!;
        public virtual CmsWebPartLayout? WidgetLayout { get; set; }
        public virtual CmsWebPart WidgetWebPart { get; set; } = null!;
        public virtual ICollection<CmsWidgetRole> CmsWidgetRoles { get; set; }
    }
}
