using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NewsletterNewsletter
    {
        public NewsletterNewsletter()
        {
            NewsletterNewsletterIssues = new HashSet<NewsletterNewsletterIssue>();
            NewsletterSubscriberNewsletters = new HashSet<NewsletterSubscriberNewsletter>();
            NewsletterUnsubscriptions = new HashSet<NewsletterUnsubscription>();
            Templates = new HashSet<NewsletterEmailTemplate>();
        }

        public int NewsletterId { get; set; }
        public string NewsletterDisplayName { get; set; } = null!;
        public string NewsletterName { get; set; } = null!;
        public int? NewsletterSubscriptionTemplateId { get; set; }
        public int NewsletterUnsubscriptionTemplateId { get; set; }
        public string NewsletterSenderName { get; set; } = null!;
        public string NewsletterSenderEmail { get; set; } = null!;
        public string? NewsletterDynamicSubject { get; set; }
        public string? NewsletterDynamicUrl { get; set; }
        public int? NewsletterDynamicScheduledTaskId { get; set; }
        public int NewsletterSiteId { get; set; }
        public Guid NewsletterGuid { get; set; }
        public string? NewsletterUnsubscribeUrl { get; set; }
        public string? NewsletterBaseUrl { get; set; }
        public DateTime NewsletterLastModified { get; set; }
        public bool? NewsletterEnableOptIn { get; set; }
        public int? NewsletterOptInTemplateId { get; set; }
        public bool? NewsletterSendOptInConfirmation { get; set; }
        public string? NewsletterOptInApprovalUrl { get; set; }
        public bool? NewsletterTrackOpenEmails { get; set; }
        public bool? NewsletterTrackClickedLinks { get; set; }
        public string? NewsletterDraftEmails { get; set; }
        public bool? NewsletterLogActivity { get; set; }
        public string NewsletterSource { get; set; } = null!;
        public int NewsletterType { get; set; }

        public virtual CmsScheduledTask? NewsletterDynamicScheduledTask { get; set; }
        public virtual NewsletterEmailTemplate? NewsletterOptInTemplate { get; set; }
        public virtual CmsSite NewsletterSite { get; set; } = null!;
        public virtual NewsletterEmailTemplate NewsletterUnsubscriptionTemplate { get; set; } = null!;
        public virtual ICollection<NewsletterNewsletterIssue> NewsletterNewsletterIssues { get; set; }
        public virtual ICollection<NewsletterSubscriberNewsletter> NewsletterSubscriberNewsletters { get; set; }
        public virtual ICollection<NewsletterUnsubscription> NewsletterUnsubscriptions { get; set; }

        public virtual ICollection<NewsletterEmailTemplate> Templates { get; set; }
    }
}
