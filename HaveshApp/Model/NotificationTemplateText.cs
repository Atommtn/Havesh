using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NotificationTemplateText
    {
        public int TemplateTextId { get; set; }
        public int TemplateId { get; set; }
        public int GatewayId { get; set; }
        public string TemplateSubject { get; set; } = null!;
        public string TemplateHtmltext { get; set; } = null!;
        public string TemplatePlainText { get; set; } = null!;
        public Guid TemplateTextGuid { get; set; }
        public DateTime TemplateTextLastModified { get; set; }

        public virtual NotificationGateway Gateway { get; set; } = null!;
        public virtual NotificationTemplate Template { get; set; } = null!;
    }
}
