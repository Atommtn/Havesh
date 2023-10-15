using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsTranslationService
    {
        public CmsTranslationService()
        {
            CmsTranslationSubmissions = new HashSet<CmsTranslationSubmission>();
        }

        public int TranslationServiceId { get; set; }
        public string TranslationServiceAssemblyName { get; set; } = null!;
        public string TranslationServiceClassName { get; set; } = null!;
        public string TranslationServiceName { get; set; } = null!;
        public string TranslationServiceDisplayName { get; set; } = null!;
        public bool TranslationServiceIsMachine { get; set; }
        public DateTime TranslationServiceLastModified { get; set; }
        public Guid TranslationServiceGuid { get; set; }
        public bool TranslationServiceEnabled { get; set; }
        public bool? TranslationServiceSupportsInstructions { get; set; }
        public bool? TranslationServiceSupportsPriority { get; set; }
        public bool? TranslationServiceSupportsDeadline { get; set; }
        public bool? TranslationServiceGenerateTargetTag { get; set; }
        public string? TranslationServiceParameter { get; set; }
        public bool? TranslationServiceSupportsStatusUpdate { get; set; }
        public bool? TranslationServiceSupportsCancel { get; set; }

        public virtual ICollection<CmsTranslationSubmission> CmsTranslationSubmissions { get; set; }
    }
}
