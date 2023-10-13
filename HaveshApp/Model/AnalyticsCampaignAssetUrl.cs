using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class AnalyticsCampaignAssetUrl
    {
        public int CampaignAssetUrlId { get; set; }
        public Guid CampaignAssetUrlGuid { get; set; }
        public string CampaignAssetUrlTarget { get; set; } = null!;
        public string CampaignAssetUrlPageTitle { get; set; } = null!;
        public int CampaignAssetUrlCampaignAssetId { get; set; }

        public virtual AnalyticsCampaignAsset CampaignAssetUrlCampaignAsset { get; set; } = null!;
    }
}
