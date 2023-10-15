using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class AnalyticsWeekHit
    {
        public int HitsId { get; set; }
        public int HitsStatisticsId { get; set; }
        public DateTime HitsStartTime { get; set; }
        public DateTime HitsEndTime { get; set; }
        public int HitsCount { get; set; }
        public double? HitsValue { get; set; }

        public virtual AnalyticsStatistic HitsStatistics { get; set; } = null!;
    }
}
