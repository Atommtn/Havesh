using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NewsletterEmail
    {
        public int EmailId { get; set; }
        public int EmailNewsletterIssueId { get; set; }
        public int? EmailSubscriberId { get; set; }
        public int EmailSiteId { get; set; }
        public string? EmailLastSendResult { get; set; }
        public DateTime? EmailLastSendAttempt { get; set; }
        public bool? EmailSending { get; set; }
        public Guid EmailGuid { get; set; }
        public int? EmailContactId { get; set; }
        public string? EmailAddress { get; set; }

        public virtual NewsletterNewsletterIssue EmailNewsletterIssue { get; set; } = null!;
        public virtual CmsSite EmailSite { get; set; } = null!;
        public virtual NewsletterSubscriber? EmailSubscriber { get; set; }
    }
}
