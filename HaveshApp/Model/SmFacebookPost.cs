using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class SmFacebookPost
    {
        public int FacebookPostId { get; set; }
        public Guid FacebookPostGuid { get; set; }
        public DateTime FacebookPostLastModified { get; set; }
        public int FacebookPostSiteId { get; set; }
        public int FacebookPostFacebookAccountId { get; set; }
        public string FacebookPostText { get; set; } = null!;
        public int? FacebookPostUrlshortenerType { get; set; }
        public int? FacebookPostErrorCode { get; set; }
        public int? FacebookPostErrorSubcode { get; set; }
        public string? FacebookPostExternalId { get; set; }
        public DateTime? FacebookPostPublishedDateTime { get; set; }
        public DateTime? FacebookPostScheduledPublishDateTime { get; set; }
        public int? FacebookPostCampaignId { get; set; }
        public bool? FacebookPostPostAfterDocumentPublish { get; set; }
        public int? FacebookPostInsightPeopleReached { get; set; }
        public int? FacebookPostInsightLikesFromPage { get; set; }
        public int? FacebookPostInsightCommentsFromPage { get; set; }
        public int? FacebookPostInsightSharesFromPage { get; set; }
        public int? FacebookPostInsightLikesTotal { get; set; }
        public int? FacebookPostInsightCommentsTotal { get; set; }
        public int? FacebookPostInsightNegativeHidePost { get; set; }
        public int? FacebookPostInsightNegativeHideAllPosts { get; set; }
        public int? FacebookPostInsightNegativeReportSpam { get; set; }
        public int? FacebookPostInsightNegativeUnlikePage { get; set; }
        public DateTime? FacebookPostInsightsLastUpdated { get; set; }
        public Guid? FacebookPostDocumentGuid { get; set; }
        public bool? FacebookPostIsCreatedByUser { get; set; }

        public virtual AnalyticsCampaign? FacebookPostCampaign { get; set; }
        public virtual SmFacebookAccount FacebookPostFacebookAccount { get; set; } = null!;
        public virtual CmsSite FacebookPostSite { get; set; } = null!;
    }
}
