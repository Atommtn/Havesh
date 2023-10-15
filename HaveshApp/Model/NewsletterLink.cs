using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NewsletterLink
    {
        public NewsletterLink()
        {
            NewsletterClickedLinks = new HashSet<NewsletterClickedLink>();
        }

        public int LinkId { get; set; }
        public int LinkIssueId { get; set; }
        public string LinkTarget { get; set; } = null!;
        public string LinkDescription { get; set; } = null!;
        public Guid LinkGuid { get; set; }

        public virtual NewsletterNewsletterIssue LinkIssue { get; set; } = null!;
        public virtual ICollection<NewsletterClickedLink> NewsletterClickedLinks { get; set; }
    }
}
