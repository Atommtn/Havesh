using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsTranslationSubmission
    {
        public CmsTranslationSubmission()
        {
            CmsTranslationSubmissionItems = new HashSet<CmsTranslationSubmissionItem>();
        }

        public int SubmissionId { get; set; }
        public string SubmissionName { get; set; } = null!;
        public string? SubmissionTicket { get; set; }
        public int SubmissionStatus { get; set; }
        public int SubmissionServiceId { get; set; }
        public string SubmissionSourceCulture { get; set; } = null!;
        public string SubmissionTargetCulture { get; set; } = null!;
        public int SubmissionPriority { get; set; }
        public DateTime? SubmissionDeadline { get; set; }
        public string? SubmissionInstructions { get; set; }
        public DateTime SubmissionLastModified { get; set; }
        public Guid SubmissionGuid { get; set; }
        public int? SubmissionSiteId { get; set; }
        public double? SubmissionPrice { get; set; }
        public string? SubmissionStatusMessage { get; set; }
        public bool? SubmissionTranslateAttachments { get; set; }
        public int SubmissionItemCount { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int? SubmissionWordCount { get; set; }
        public int? SubmissionCharCount { get; set; }
        public int? SubmissionSubmittedByUserId { get; set; }

        public virtual CmsTranslationService SubmissionService { get; set; } = null!;
        public virtual CmsUser? SubmissionSubmittedByUser { get; set; }
        public virtual ICollection<CmsTranslationSubmissionItem> CmsTranslationSubmissionItems { get; set; }
    }
}
