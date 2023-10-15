using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NewsletterOpenedEmail
    {
        public int OpenedEmailId { get; set; }
        public string OpenedEmailEmail { get; set; } = null!;
        public Guid OpenedEmailGuid { get; set; }
        public DateTime? OpenedEmailTime { get; set; }
        public int OpenedEmailIssueId { get; set; }

        public virtual NewsletterNewsletterIssue OpenedEmailIssue { get; set; } = null!;
    }
}
