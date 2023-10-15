using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NewsletterSubscriber
    {
        public NewsletterSubscriber()
        {
            NewsletterEmails = new HashSet<NewsletterEmail>();
            NewsletterSubscriberNewsletters = new HashSet<NewsletterSubscriberNewsletter>();
        }

        public int SubscriberId { get; set; }
        public string? SubscriberEmail { get; set; }
        public string? SubscriberFirstName { get; set; }
        public string? SubscriberLastName { get; set; }
        public int SubscriberSiteId { get; set; }
        public Guid SubscriberGuid { get; set; }
        public string? SubscriberCustomData { get; set; }
        public string? SubscriberType { get; set; }
        public int SubscriberRelatedId { get; set; }
        public DateTime SubscriberLastModified { get; set; }
        public string? SubscriberFullName { get; set; }
        public int? SubscriberBounces { get; set; }

        public virtual CmsSite SubscriberSite { get; set; } = null!;
        public virtual ICollection<NewsletterEmail> NewsletterEmails { get; set; }
        public virtual ICollection<NewsletterSubscriberNewsletter> NewsletterSubscriberNewsletters { get; set; }
    }
}
