using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class NewsletterClickedLink
    {
        public int ClickedLinkId { get; set; }
        public Guid ClickedLinkGuid { get; set; }
        public string ClickedLinkEmail { get; set; } = null!;
        public int ClickedLinkNewsletterLinkId { get; set; }
        public DateTime? ClickedLinkTime { get; set; }

        public virtual NewsletterLink ClickedLinkNewsletterLink { get; set; } = null!;
    }
}
