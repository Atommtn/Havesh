using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewCmsWidgetCategoryWidgetJoined
    {
        public int ObjectId { get; set; }
        public string CodeName { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public int? ParentId { get; set; }
        public Guid Guid { get; set; }
        public DateTime LastModified { get; set; }
        public string? WidgetCategoryImagePath { get; set; }
        public string? ObjectPath { get; set; }
        public int? ObjectLevel { get; set; }
        public int? WidgetCategoryChildCount { get; set; }
        public int? WidgetCategoryWidgetChildCount { get; set; }
        public int? CompleteChildCount { get; set; }
        public int? WidgetWebPartId { get; set; }
        public int WidgetSecurity { get; set; }
        public bool? WidgetForGroup { get; set; }
        public bool? WidgetForInline { get; set; }
        public bool? WidgetForUser { get; set; }
        public bool? WidgetForEditor { get; set; }
        public bool? WidgetForDashboard { get; set; }
        public Guid? WidgetGuid { get; set; }
        public string ObjectType { get; set; } = null!;
    }
}
