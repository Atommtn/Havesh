using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewReportingCategoryReportJoined
    {
        public int ObjectId { get; set; }
        public string CodeName { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public int? ParentId { get; set; }
        public Guid Guid { get; set; }
        public DateTime LastModified { get; set; }
        public string? CategoryImagePath { get; set; }
        public string? ObjectPath { get; set; }
        public int? ObjectLevel { get; set; }
        public int? CategoryChildCount { get; set; }
        public int? CategoryReportChildCount { get; set; }
        public int? CompleteChildCount { get; set; }
        public string? ReportLayout { get; set; }
        public string? ReportParameters { get; set; }
        public int? ReportAccess { get; set; }
        public string ObjectType { get; set; } = null!;
    }
}
