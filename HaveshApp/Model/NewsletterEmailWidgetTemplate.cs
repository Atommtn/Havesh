using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class NewsletterEmailWidgetTemplate
    {
        public int EmailWidgetTemplateId { get; set; }
        public int EmailWidgetId { get; set; }
        public int TemplateId { get; set; }

        public virtual NewsletterEmailWidget EmailWidget { get; set; } = null!;
        public virtual NewsletterEmailTemplate Template { get; set; } = null!;
    }
}
