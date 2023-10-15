using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsWebFarmServerMonitoring
    {
        public int WebFarmServerMonitoringId { get; set; }
        public int ServerId { get; set; }
        public DateTime? ServerPing { get; set; }
    }
}
