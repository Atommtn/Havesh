using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class AnalyticsStatistic
    {
        public AnalyticsStatistic()
        {
            AnalyticsDayHits = new HashSet<AnalyticsDayHit>();
            AnalyticsHourHits = new HashSet<AnalyticsHourHit>();
            AnalyticsMonthHits = new HashSet<AnalyticsMonthHit>();
            AnalyticsWeekHits = new HashSet<AnalyticsWeekHit>();
            AnalyticsYearHits = new HashSet<AnalyticsYearHit>();
        }

        public int StatisticsId { get; set; }
        public int? StatisticsSiteId { get; set; }
        public string StatisticsCode { get; set; } = null!;
        public string? StatisticsObjectName { get; set; }
        public int? StatisticsObjectId { get; set; }
        public string? StatisticsObjectCulture { get; set; }

        public virtual CmsSite? StatisticsSite { get; set; }
        public virtual ICollection<AnalyticsDayHit> AnalyticsDayHits { get; set; }
        public virtual ICollection<AnalyticsHourHit> AnalyticsHourHits { get; set; }
        public virtual ICollection<AnalyticsMonthHit> AnalyticsMonthHits { get; set; }
        public virtual ICollection<AnalyticsWeekHit> AnalyticsWeekHits { get; set; }
        public virtual ICollection<AnalyticsYearHit> AnalyticsYearHits { get; set; }
    }
}
