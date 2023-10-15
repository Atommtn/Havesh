using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ReportingReportValue
    {
        public ReportingReportValue()
        {
            ReportingReportSubscriptions = new HashSet<ReportingReportSubscription>();
        }

        public int ValueId { get; set; }
        public string ValueName { get; set; } = null!;
        public string ValueDisplayName { get; set; } = null!;
        public string ValueQuery { get; set; } = null!;
        public bool ValueQueryIsStoredProcedure { get; set; }
        public string? ValueFormatString { get; set; }
        public int ValueReportId { get; set; }
        public Guid ValueGuid { get; set; }
        public DateTime ValueLastModified { get; set; }
        public string? ValueSettings { get; set; }
        public string? ValueConnectionString { get; set; }

        public virtual ReportingReport ValueReport { get; set; } = null!;
        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscriptions { get; set; }
    }
}
