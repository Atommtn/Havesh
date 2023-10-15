using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NotificationGateway
    {
        public NotificationGateway()
        {
            NotificationSubscriptions = new HashSet<NotificationSubscription>();
            NotificationTemplateTexts = new HashSet<NotificationTemplateText>();
        }

        public int GatewayId { get; set; }
        public string GatewayName { get; set; } = null!;
        public string GatewayDisplayName { get; set; } = null!;
        public string GatewayAssemblyName { get; set; } = null!;
        public string GatewayClassName { get; set; } = null!;
        public string? GatewayDescription { get; set; }
        public bool? GatewaySupportsEmail { get; set; }
        public bool? GatewaySupportsPlainText { get; set; }
        public bool? GatewaySupportsHtmltext { get; set; }
        public DateTime GatewayLastModified { get; set; }
        public Guid GatewayGuid { get; set; }
        public bool? GatewayEnabled { get; set; }

        public virtual ICollection<NotificationSubscription> NotificationSubscriptions { get; set; }
        public virtual ICollection<NotificationTemplateText> NotificationTemplateTexts { get; set; }
    }
}
