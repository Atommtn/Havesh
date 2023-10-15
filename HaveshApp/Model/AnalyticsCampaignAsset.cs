using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class AnalyticsCampaignAsset
    {
        public AnalyticsCampaignAsset()
        {
            AnalyticsCampaignAssetUrls = new HashSet<AnalyticsCampaignAssetUrl>();
        }

        public int CampaignAssetId { get; set; }
        public Guid CampaignAssetGuid { get; set; }
        public DateTime CampaignAssetLastModified { get; set; }
        public Guid CampaignAssetAssetGuid { get; set; }
        public int CampaignAssetCampaignId { get; set; }
        public string CampaignAssetType { get; set; } = null!;

        public virtual AnalyticsCampaign CampaignAssetCampaign { get; set; } = null!;
        public virtual ICollection<AnalyticsCampaignAssetUrl> AnalyticsCampaignAssetUrls { get; set; }
    }
}
