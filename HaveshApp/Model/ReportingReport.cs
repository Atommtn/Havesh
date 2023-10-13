using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ReportingReport
    {
        public ReportingReport()
        {
            ReportingReportGraphs = new HashSet<ReportingReportGraph>();
            ReportingReportSubscriptions = new HashSet<ReportingReportSubscription>();
            ReportingReportTables = new HashSet<ReportingReportTable>();
            ReportingReportValues = new HashSet<ReportingReportValue>();
            ReportingSavedReports = new HashSet<ReportingSavedReport>();
        }

        public int ReportId { get; set; }
        public string ReportName { get; set; } = null!;
        public string ReportDisplayName { get; set; } = null!;
        public string? ReportLayout { get; set; }
        public string? ReportParameters { get; set; }
        public int ReportCategoryId { get; set; }
        public int ReportAccess { get; set; }
        public Guid ReportGuid { get; set; }
        public DateTime ReportLastModified { get; set; }
        public bool? ReportEnableSubscription { get; set; }
        public string? ReportConnectionString { get; set; }

        public virtual ReportingReportCategory ReportCategory { get; set; } = null!;
        public virtual ICollection<ReportingReportGraph> ReportingReportGraphs { get; set; }
        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscriptions { get; set; }
        public virtual ICollection<ReportingReportTable> ReportingReportTables { get; set; }
        public virtual ICollection<ReportingReportValue> ReportingReportValues { get; set; }
        public virtual ICollection<ReportingSavedReport> ReportingSavedReports { get; set; }
    }
}
