using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ReportingSavedReport
    {
        public ReportingSavedReport()
        {
            ReportingSavedGraphs = new HashSet<ReportingSavedGraph>();
        }

        public int SavedReportId { get; set; }
        public int SavedReportReportId { get; set; }
        public Guid SavedReportGuid { get; set; }
        public string? SavedReportTitle { get; set; }
        public DateTime SavedReportDate { get; set; }
        public string SavedReportHtml { get; set; } = null!;
        public string SavedReportParameters { get; set; } = null!;
        public int? SavedReportCreatedByUserId { get; set; }
        public DateTime SavedReportLastModified { get; set; }

        public virtual CmsUser? SavedReportCreatedByUser { get; set; }
        public virtual ReportingReport SavedReportReport { get; set; } = null!;
        public virtual ICollection<ReportingSavedGraph> ReportingSavedGraphs { get; set; }
    }
}
