using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class AnalyticsCampaign
    {
        public AnalyticsCampaign()
        {
            AnalyticsCampaignAssets = new HashSet<AnalyticsCampaignAsset>();
            AnalyticsCampaignConversions = new HashSet<AnalyticsCampaignConversion>();
            SmFacebookPosts = new HashSet<SmFacebookPost>();
            SmLinkedInPosts = new HashSet<SmLinkedInPost>();
            SmTwitterPosts = new HashSet<SmTwitterPost>();
        }

        public int CampaignId { get; set; }
        public string CampaignName { get; set; } = null!;
        public string CampaignDisplayName { get; set; } = null!;
        public string? CampaignDescription { get; set; }
        public int CampaignSiteId { get; set; }
        public DateTime? CampaignOpenFrom { get; set; }
        public DateTime? CampaignOpenTo { get; set; }
        public Guid CampaignGuid { get; set; }
        public DateTime CampaignLastModified { get; set; }
        public string? CampaignUtmcode { get; set; }
        public DateTime? CampaignCalculatedTo { get; set; }
        public int? CampaignScheduledTaskId { get; set; }
        public int? CampaignVisitors { get; set; }

        public virtual CmsScheduledTask? CampaignScheduledTask { get; set; }
        public virtual CmsSite CampaignSite { get; set; } = null!;
        public virtual AnalyticsCampaignObjective? AnalyticsCampaignObjective { get; set; }
        public virtual ICollection<AnalyticsCampaignAsset> AnalyticsCampaignAssets { get; set; }
        public virtual ICollection<AnalyticsCampaignConversion> AnalyticsCampaignConversions { get; set; }
        public virtual ICollection<SmFacebookPost> SmFacebookPosts { get; set; }
        public virtual ICollection<SmLinkedInPost> SmLinkedInPosts { get; set; }
        public virtual ICollection<SmTwitterPost> SmTwitterPosts { get; set; }
    }
}
