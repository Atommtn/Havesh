using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ReportingReportTable
    {
        public ReportingReportTable()
        {
            ReportingReportSubscriptions = new HashSet<ReportingReportSubscription>();
        }

        public int TableId { get; set; }
        public string TableName { get; set; } = null!;
        public string TableDisplayName { get; set; } = null!;
        public string TableQuery { get; set; } = null!;
        public bool TableQueryIsStoredProcedure { get; set; }
        public int TableReportId { get; set; }
        public string? TableSettings { get; set; }
        public Guid TableGuid { get; set; }
        public DateTime TableLastModified { get; set; }
        public string? TableConnectionString { get; set; }

        public virtual ReportingReport TableReport { get; set; } = null!;
        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscriptions { get; set; }
    }
}
