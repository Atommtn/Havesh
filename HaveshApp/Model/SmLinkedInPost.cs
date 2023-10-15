using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class SmLinkedInPost
    {
        public int LinkedInPostId { get; set; }
        public int LinkedInPostLinkedInAccountId { get; set; }
        public string LinkedInPostComment { get; set; } = null!;
        public int LinkedInPostSiteId { get; set; }
        public Guid LinkedInPostGuid { get; set; }
        public DateTime? LinkedInPostLastModified { get; set; }
        public string? LinkedInPostUpdateKey { get; set; }
        public int? LinkedInPostUrlshortenerType { get; set; }
        public DateTime? LinkedInPostScheduledPublishDateTime { get; set; }
        public int? LinkedInPostCampaignId { get; set; }
        public DateTime? LinkedInPostPublishedDateTime { get; set; }
        public int? LinkedInPostHttpstatusCode { get; set; }
        public int? LinkedInPostErrorCode { get; set; }
        public string? LinkedInPostErrorMessage { get; set; }
        public Guid? LinkedInPostDocumentGuid { get; set; }
        public bool? LinkedInPostIsCreatedByUser { get; set; }
        public bool? LinkedInPostPostAfterDocumentPublish { get; set; }
        public DateTime? LinkedInPostInsightsLastUpdated { get; set; }
        public int? LinkedInPostCommentCount { get; set; }
        public int? LinkedInPostImpressionCount { get; set; }
        public int? LinkedInPostLikeCount { get; set; }
        public int? LinkedInPostShareCount { get; set; }
        public int? LinkedInPostClickCount { get; set; }
        public double? LinkedInPostEngagement { get; set; }

        public virtual AnalyticsCampaign? LinkedInPostCampaign { get; set; }
        public virtual SmLinkedInAccount LinkedInPostLinkedInAccount { get; set; } = null!;
        public virtual CmsSite LinkedInPostSite { get; set; } = null!;
    }
}
