using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class SmInsight
    {
        public SmInsight()
        {
            SmInsightHitDays = new HashSet<SmInsightHitDay>();
            SmInsightHitMonths = new HashSet<SmInsightHitMonth>();
            SmInsightHitWeeks = new HashSet<SmInsightHitWeek>();
            SmInsightHitYears = new HashSet<SmInsightHitYear>();
        }

        public int InsightId { get; set; }
        public string InsightCodeName { get; set; } = null!;
        public string InsightExternalId { get; set; } = null!;
        public string InsightPeriodType { get; set; } = null!;
        public string? InsightValueName { get; set; }

        public virtual ICollection<SmInsightHitDay> SmInsightHitDays { get; set; }
        public virtual ICollection<SmInsightHitMonth> SmInsightHitMonths { get; set; }
        public virtual ICollection<SmInsightHitWeek> SmInsightHitWeeks { get; set; }
        public virtual ICollection<SmInsightHitYear> SmInsightHitYears { get; set; }
    }
}
