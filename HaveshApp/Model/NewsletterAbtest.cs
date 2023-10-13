using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class NewsletterAbtest
    {
        public int TestId { get; set; }
        public int TestIssueId { get; set; }
        public int TestWinnerOption { get; set; }
        public int? TestSelectWinnerAfter { get; set; }
        public int? TestWinnerIssueId { get; set; }
        public DateTime? TestWinnerSelected { get; set; }
        public DateTime TestLastModified { get; set; }
        public Guid TestGuid { get; set; }
        public int? TestWinnerScheduledTaskId { get; set; }
        public int TestSizePercentage { get; set; }
        public int? TestNumberPerVariantEmails { get; set; }

        public virtual NewsletterNewsletterIssue TestIssue { get; set; } = null!;
        public virtual NewsletterNewsletterIssue? TestWinnerIssue { get; set; }
        public virtual CmsScheduledTask? TestWinnerScheduledTask { get; set; }
    }
}
