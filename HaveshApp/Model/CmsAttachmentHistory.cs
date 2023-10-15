using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsAttachmentHistory
    {
        public CmsAttachmentHistory()
        {
            InverseAttachmentVariantParent = new HashSet<CmsAttachmentHistory>();
            VersionHistories = new HashSet<CmsVersionHistory>();
        }

        public int AttachmentHistoryId { get; set; }
        public string AttachmentName { get; set; } = null!;
        public string AttachmentExtension { get; set; } = null!;
        public int AttachmentSize { get; set; }
        public string AttachmentMimeType { get; set; } = null!;
        public byte[]? AttachmentBinary { get; set; }
        public int? AttachmentImageWidth { get; set; }
        public int? AttachmentImageHeight { get; set; }
        public int AttachmentDocumentId { get; set; }
        public Guid AttachmentGuid { get; set; }
        public bool? AttachmentIsUnsorted { get; set; }
        public int? AttachmentOrder { get; set; }
        public Guid? AttachmentGroupGuid { get; set; }
        public string? AttachmentHash { get; set; }
        public string? AttachmentTitle { get; set; }
        public string? AttachmentDescription { get; set; }
        public string? AttachmentCustomData { get; set; }
        public DateTime? AttachmentLastModified { get; set; }
        public Guid AttachmentHistoryGuid { get; set; }
        public int AttachmentSiteId { get; set; }
        public string? AttachmentSearchContent { get; set; }
        public string? AttachmentVariantDefinitionIdentifier { get; set; }
        public int? AttachmentVariantParentId { get; set; }

        public virtual CmsSite AttachmentSite { get; set; } = null!;
        public virtual CmsAttachmentHistory? AttachmentVariantParent { get; set; }
        public virtual ICollection<CmsAttachmentHistory> InverseAttachmentVariantParent { get; set; }

        public virtual ICollection<CmsVersionHistory> VersionHistories { get; set; }
    }
}
