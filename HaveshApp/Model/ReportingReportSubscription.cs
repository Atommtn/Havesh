using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ReportingReportSubscription
    {
        public int ReportSubscriptionId { get; set; }
        public int ReportSubscriptionReportId { get; set; }
        public string ReportSubscriptionInterval { get; set; } = null!;
        public string? ReportSubscriptionCondition { get; set; }
        public bool? ReportSubscriptionEnabled { get; set; }
        public string? ReportSubscriptionParameters { get; set; }
        public Guid ReportSubscriptionGuid { get; set; }
        public DateTime ReportSubscriptionLastModified { get; set; }
        public string? ReportSubscriptionSubject { get; set; }
        public int? ReportSubscriptionGraphId { get; set; }
        public int? ReportSubscriptionTableId { get; set; }
        public int? ReportSubscriptionValueId { get; set; }
        public int ReportSubscriptionUserId { get; set; }
        public string ReportSubscriptionEmail { get; set; } = null!;
        public bool? ReportSubscriptionOnlyNonEmpty { get; set; }
        public DateTime? ReportSubscriptionLastPostDate { get; set; }
        public DateTime? ReportSubscriptionNextPostDate { get; set; }
        public int ReportSubscriptionSiteId { get; set; }
        public string? ReportSubscriptionSettings { get; set; }

        public virtual ReportingReportGraph? ReportSubscriptionGraph { get; set; }
        public virtual ReportingReport ReportSubscriptionReport { get; set; } = null!;
        public virtual CmsSite ReportSubscriptionSite { get; set; } = null!;
        public virtual ReportingReportTable? ReportSubscriptionTable { get; set; }
        public virtual CmsUser ReportSubscriptionUser { get; set; } = null!;
        public virtual ReportingReportValue? ReportSubscriptionValue { get; set; }
    }
}
