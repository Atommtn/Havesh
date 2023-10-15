using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsVersionHistory
    {
        public CmsVersionHistory()
        {
            CmsDocumentDocumentCheckedOutVersionHistories = new HashSet<CmsDocument>();
            CmsDocumentDocumentPublishedVersionHistories = new HashSet<CmsDocument>();
            CmsWorkflowHistories = new HashSet<CmsWorkflowHistory>();
            AttachmentHistories = new HashSet<CmsAttachmentHistory>();
        }

        public int VersionHistoryId { get; set; }
        public int NodeSiteId { get; set; }
        public int? DocumentId { get; set; }
        public string DocumentNamePath { get; set; } = null!;
        public string NodeXml { get; set; } = null!;
        public int? ModifiedByUserId { get; set; }
        public DateTime ModifiedWhen { get; set; }
        public string? VersionNumber { get; set; }
        public string? VersionComment { get; set; }
        public bool ToBePublished { get; set; }
        public DateTime? PublishFrom { get; set; }
        public DateTime? PublishTo { get; set; }
        public DateTime? WasPublishedFrom { get; set; }
        public DateTime? WasPublishedTo { get; set; }
        public string? VersionDocumentName { get; set; }
        public string? VersionDocumentType { get; set; }
        public int? VersionClassId { get; set; }
        public string? VersionMenuRedirectUrl { get; set; }
        public int? VersionWorkflowId { get; set; }
        public int? VersionWorkflowStepId { get; set; }
        public string? VersionNodeAliasPath { get; set; }
        public int? VersionDeletedByUserId { get; set; }
        public DateTime? VersionDeletedWhen { get; set; }

        public virtual CmsUser? ModifiedByUser { get; set; }
        public virtual CmsSite NodeSite { get; set; } = null!;
        public virtual CmsClass? VersionClass { get; set; }
        public virtual CmsUser? VersionDeletedByUser { get; set; }
        public virtual CmsWorkflow? VersionWorkflow { get; set; }
        public virtual CmsWorkflowStep? VersionWorkflowStep { get; set; }
        public virtual ICollection<CmsDocument> CmsDocumentDocumentCheckedOutVersionHistories { get; set; }
        public virtual ICollection<CmsDocument> CmsDocumentDocumentPublishedVersionHistories { get; set; }
        public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistories { get; set; }

        public virtual ICollection<CmsAttachmentHistory> AttachmentHistories { get; set; }
    }
}
