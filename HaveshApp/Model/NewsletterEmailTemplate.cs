using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class NewsletterEmailTemplate
    {
        public NewsletterEmailTemplate()
        {
            NewsletterEmailWidgetTemplates = new HashSet<NewsletterEmailWidgetTemplate>();
            NewsletterNewsletterIssues = new HashSet<NewsletterNewsletterIssue>();
            NewsletterNewsletterNewsletterOptInTemplates = new HashSet<NewsletterNewsletter>();
            NewsletterNewsletterNewsletterUnsubscriptionTemplates = new HashSet<NewsletterNewsletter>();
            Newsletters = new HashSet<NewsletterNewsletter>();
        }

        public int TemplateId { get; set; }
        public string TemplateDisplayName { get; set; } = null!;
        public string TemplateName { get; set; } = null!;
        public int TemplateSiteId { get; set; }
        public string TemplateType { get; set; } = null!;
        public Guid TemplateGuid { get; set; }
        public DateTime TemplateLastModified { get; set; }
        public string? TemplateSubject { get; set; }
        public Guid? TemplateThumbnailGuid { get; set; }
        public string? TemplateDescription { get; set; }
        public string? TemplateIconClass { get; set; }
        public string? TemplateCode { get; set; }
        public bool TemplateInlineCss { get; set; }

        public virtual CmsSite TemplateSite { get; set; } = null!;
        public virtual ICollection<NewsletterEmailWidgetTemplate> NewsletterEmailWidgetTemplates { get; set; }
        public virtual ICollection<NewsletterNewsletterIssue> NewsletterNewsletterIssues { get; set; }
        public virtual ICollection<NewsletterNewsletter> NewsletterNewsletterNewsletterOptInTemplates { get; set; }
        public virtual ICollection<NewsletterNewsletter> NewsletterNewsletterNewsletterUnsubscriptionTemplates { get; set; }

        public virtual ICollection<NewsletterNewsletter> Newsletters { get; set; }
    }
}
