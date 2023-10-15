using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ReportingReportCategory
    {
        public ReportingReportCategory()
        {
            InverseCategoryParent = new HashSet<ReportingReportCategory>();
            ReportingReports = new HashSet<ReportingReport>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; } = null!;
        public string CategoryCodeName { get; set; } = null!;
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public int? CategoryParentId { get; set; }
        public string? CategoryImagePath { get; set; }
        public string CategoryPath { get; set; } = null!;
        public int? CategoryLevel { get; set; }
        public int? CategoryChildCount { get; set; }
        public int? CategoryReportChildCount { get; set; }

        public virtual ReportingReportCategory? CategoryParent { get; set; }
        public virtual ICollection<ReportingReportCategory> InverseCategoryParent { get; set; }
        public virtual ICollection<ReportingReport> ReportingReports { get; set; }
    }
}
