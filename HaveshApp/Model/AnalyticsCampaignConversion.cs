using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class AnalyticsCampaignConversion
    {
        public AnalyticsCampaignConversion()
        {
            AnalyticsCampaignConversionHits = new HashSet<AnalyticsCampaignConversionHit>();
            AnalyticsCampaignObjectives = new HashSet<AnalyticsCampaignObjective>();
        }

        public int CampaignConversionId { get; set; }
        public Guid CampaignConversionGuid { get; set; }
        public DateTime CampaignConversionLastModified { get; set; }
        public string CampaignConversionDisplayName { get; set; } = null!;
        public string CampaignConversionName { get; set; } = null!;
        public int CampaignConversionCampaignId { get; set; }
        public int CampaignConversionOrder { get; set; }
        public string CampaignConversionActivityType { get; set; } = null!;
        public int CampaignConversionHits { get; set; }
        public int? CampaignConversionItemId { get; set; }
        public double CampaignConversionValue { get; set; }
        public bool CampaignConversionIsFunnelStep { get; set; }
        public string? CampaignConversionUrl { get; set; }

        public virtual AnalyticsCampaign CampaignConversionCampaign { get; set; } = null!;
        public virtual ICollection<AnalyticsCampaignConversionHit> AnalyticsCampaignConversionHits { get; set; }
        public virtual ICollection<AnalyticsCampaignObjective> AnalyticsCampaignObjectives { get; set; }
    }
}
