using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class NotificationTemplate
    {
        public NotificationTemplate()
        {
            NotificationSubscriptions = new HashSet<NotificationSubscription>();
            NotificationTemplateTexts = new HashSet<NotificationTemplateText>();
        }

        public int TemplateId { get; set; }
        public string TemplateName { get; set; } = null!;
        public string TemplateDisplayName { get; set; } = null!;
        public int? TemplateSiteId { get; set; }
        public DateTime TemplateLastModified { get; set; }
        public Guid TemplateGuid { get; set; }

        public virtual CmsSite? TemplateSite { get; set; }
        public virtual ICollection<NotificationSubscription> NotificationSubscriptions { get; set; }
        public virtual ICollection<NotificationTemplateText> NotificationTemplateTexts { get; set; }
    }
}
