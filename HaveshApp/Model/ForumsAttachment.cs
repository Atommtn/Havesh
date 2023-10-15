using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ForumsAttachment
    {
        public int AttachmentId { get; set; }
        public string AttachmentFileName { get; set; } = null!;
        public string AttachmentFileExtension { get; set; } = null!;
        public byte[]? AttachmentBinary { get; set; }
        public Guid AttachmentGuid { get; set; }
        public DateTime AttachmentLastModified { get; set; }
        public string AttachmentMimeType { get; set; } = null!;
        public int AttachmentFileSize { get; set; }
        public int? AttachmentImageHeight { get; set; }
        public int? AttachmentImageWidth { get; set; }
        public int AttachmentPostId { get; set; }
        public int AttachmentSiteId { get; set; }

        public virtual ForumsForumPost AttachmentPost { get; set; } = null!;
        public virtual CmsSite AttachmentSite { get; set; } = null!;
    }
}
