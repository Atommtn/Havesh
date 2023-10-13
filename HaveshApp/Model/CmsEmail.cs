using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsEmail
    {
        public CmsEmail()
        {
            CmsEmailUsers = new HashSet<CmsEmailUser>();
            Attachments = new HashSet<CmsEmailAttachment>();
        }

        public int EmailId { get; set; }
        public string EmailFrom { get; set; } = null!;
        public string? EmailTo { get; set; }
        public string? EmailCc { get; set; }
        public string? EmailBcc { get; set; }
        public string EmailSubject { get; set; } = null!;
        public string? EmailBody { get; set; }
        public string? EmailPlainTextBody { get; set; }
        public int EmailFormat { get; set; }
        public int EmailPriority { get; set; }
        public int? EmailSiteId { get; set; }
        public string? EmailLastSendResult { get; set; }
        public DateTime? EmailLastSendAttempt { get; set; }
        public Guid EmailGuid { get; set; }
        public DateTime EmailLastModified { get; set; }
        public int? EmailStatus { get; set; }
        public bool? EmailIsMass { get; set; }
        public string? EmailReplyTo { get; set; }
        public string? EmailHeaders { get; set; }
        public DateTime? EmailCreated { get; set; }

        public virtual ICollection<CmsEmailUser> CmsEmailUsers { get; set; }

        public virtual ICollection<CmsEmailAttachment> Attachments { get; set; }
    }
}
