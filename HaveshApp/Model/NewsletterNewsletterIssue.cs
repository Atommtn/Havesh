using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NewsletterNewsletterIssue
    {
        public NewsletterNewsletterIssue()
        {
            InverseIssueVariantOfIssue = new HashSet<NewsletterNewsletterIssue>();
            NewsletterAbtestTestWinnerIssues = new HashSet<NewsletterAbtest>();
            NewsletterEmails = new HashSet<NewsletterEmail>();
            NewsletterLinks = new HashSet<NewsletterLink>();
            NewsletterOpenedEmails = new HashSet<NewsletterOpenedEmail>();
            NewsletterUnsubscriptions = new HashSet<NewsletterUnsubscription>();
        }

        public int IssueId { get; set; }
        public string IssueSubject { get; set; } = null!;
        public string IssueText { get; set; } = null!;
        public int IssueUnsubscribed { get; set; }
        public int IssueNewsletterId { get; set; }
        public int? IssueTemplateId { get; set; }
        public int IssueSentEmails { get; set; }
        public DateTime? IssueMailoutTime { get; set; }
        public Guid IssueGuid { get; set; }
        public DateTime IssueLastModified { get; set; }
        public int IssueSiteId { get; set; }
        public int? IssueOpenedEmails { get; set; }
        public int? IssueBounces { get; set; }
        public int? IssueStatus { get; set; }
        public bool? IssueIsAbtest { get; set; }
        public int? IssueVariantOfIssueId { get; set; }
        public string? IssueVariantName { get; set; }
        public string? IssueSenderName { get; set; }
        public string? IssueSenderEmail { get; set; }
        public int? IssueScheduledTaskId { get; set; }
        public string? IssueUtmsource { get; set; }
        public bool IssueUseUtm { get; set; }
        public string? IssueUtmcampaign { get; set; }
        public string IssueDisplayName { get; set; } = null!;
        public string? IssueWidgets { get; set; }
        public string? IssuePreheader { get; set; }
        public string? IssuePlainText { get; set; }

        public virtual NewsletterNewsletter IssueNewsletter { get; set; } = null!;
        public virtual CmsSite IssueSite { get; set; } = null!;
        public virtual NewsletterEmailTemplate? IssueTemplate { get; set; }
        public virtual NewsletterNewsletterIssue? IssueVariantOfIssue { get; set; }
        public virtual NewsletterAbtest? NewsletterAbtestTestIssue { get; set; }
        public virtual ICollection<NewsletterNewsletterIssue> InverseIssueVariantOfIssue { get; set; }
        public virtual ICollection<NewsletterAbtest> NewsletterAbtestTestWinnerIssues { get; set; }
        public virtual ICollection<NewsletterEmail> NewsletterEmails { get; set; }
        public virtual ICollection<NewsletterLink> NewsletterLinks { get; set; }
        public virtual ICollection<NewsletterOpenedEmail> NewsletterOpenedEmails { get; set; }
        public virtual ICollection<NewsletterUnsubscription> NewsletterUnsubscriptions { get; set; }
    }
}
