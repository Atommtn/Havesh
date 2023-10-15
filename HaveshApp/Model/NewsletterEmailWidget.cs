using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NewsletterEmailWidget
    {
        public NewsletterEmailWidget()
        {
            NewsletterEmailWidgetTemplates = new HashSet<NewsletterEmailWidgetTemplate>();
        }

        public int EmailWidgetId { get; set; }
        public Guid EmailWidgetGuid { get; set; }
        public DateTime EmailWidgetLastModified { get; set; }
        public string EmailWidgetDisplayName { get; set; } = null!;
        public string EmailWidgetName { get; set; } = null!;
        public string? EmailWidgetDescription { get; set; }
        public string? EmailWidgetCode { get; set; }
        public int EmailWidgetSiteId { get; set; }
        public Guid? EmailWidgetThumbnailGuid { get; set; }
        public string? EmailWidgetIconCssClass { get; set; }
        public string? EmailWidgetProperties { get; set; }

        public virtual CmsSite EmailWidgetSite { get; set; } = null!;
        public virtual ICollection<NewsletterEmailWidgetTemplate> NewsletterEmailWidgetTemplates { get; set; }
    }
}
