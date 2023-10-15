using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class AnalyticsCampaignConversionHit
    {
        public int CampaignConversionHitsId { get; set; }
        public int CampaignConversionHitsConversionId { get; set; }
        public int CampaignConversionHitsCount { get; set; }
        public string CampaignConversionHitsSourceName { get; set; } = null!;
        public string? CampaignConversionHitsContentName { get; set; }

        public virtual AnalyticsCampaignConversion CampaignConversionHitsConversion { get; set; } = null!;
    }
}
