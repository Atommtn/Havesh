using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsEmailAttachment
    {
        public CmsEmailAttachment()
        {
            Emails = new HashSet<CmsEmail>();
        }

        public int AttachmentId { get; set; }
        public string AttachmentName { get; set; } = null!;
        public string AttachmentExtension { get; set; } = null!;
        public int AttachmentSize { get; set; }
        public string AttachmentMimeType { get; set; } = null!;
        public byte[] AttachmentBinary { get; set; } = null!;
        public Guid AttachmentGuid { get; set; }
        public DateTime AttachmentLastModified { get; set; }
        public string? AttachmentContentId { get; set; }
        public int? AttachmentSiteId { get; set; }

        public virtual ICollection<CmsEmail> Emails { get; set; }
    }
}
