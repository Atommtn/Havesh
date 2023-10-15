using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class SmTwitterPost
    {
        public int TwitterPostId { get; set; }
        public Guid TwitterPostGuid { get; set; }
        public DateTime TwitterPostLastModified { get; set; }
        public int TwitterPostSiteId { get; set; }
        public int TwitterPostTwitterAccountId { get; set; }
        public string TwitterPostText { get; set; } = null!;
        public int? TwitterPostUrlshortenerType { get; set; }
        public string? TwitterPostExternalId { get; set; }
        public int? TwitterPostErrorCode { get; set; }
        public DateTime? TwitterPostPublishedDateTime { get; set; }
        public DateTime? TwitterPostScheduledPublishDateTime { get; set; }
        public int? TwitterPostCampaignId { get; set; }
        public int? TwitterPostFavorites { get; set; }
        public int? TwitterPostRetweets { get; set; }
        public bool? TwitterPostPostAfterDocumentPublish { get; set; }
        public DateTime? TwitterPostInsightsUpdateDateTime { get; set; }
        public Guid? TwitterPostDocumentGuid { get; set; }
        public bool? TwitterPostIsCreatedByUser { get; set; }

        public virtual AnalyticsCampaign? TwitterPostCampaign { get; set; }
        public virtual CmsSite TwitterPostSite { get; set; } = null!;
        public virtual SmTwitterAccount TwitterPostTwitterAccount { get; set; } = null!;
    }
}
