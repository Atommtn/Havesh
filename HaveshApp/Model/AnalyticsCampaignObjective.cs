using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class AnalyticsCampaignObjective
    {
        public int CampaignObjectiveId { get; set; }
        public Guid CampaignObjectiveGuid { get; set; }
        public DateTime CampaignObjectiveLastModified { get; set; }
        public int CampaignObjectiveCampaignId { get; set; }
        public int? CampaignObjectiveValue { get; set; }
        public int CampaignObjectiveCampaignConversionId { get; set; }

        public virtual AnalyticsCampaign CampaignObjectiveCampaign { get; set; } = null!;
        public virtual AnalyticsCampaignConversion CampaignObjectiveCampaignConversion { get; set; } = null!;
    }
}
