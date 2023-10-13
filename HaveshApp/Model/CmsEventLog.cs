using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsEventLog
    {
        public int EventId { get; set; }
        public string EventType { get; set; } = null!;
        public DateTime EventTime { get; set; }
        public string Source { get; set; } = null!;
        public string EventCode { get; set; } = null!;
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Ipaddress { get; set; }
        public int? NodeId { get; set; }
        public string? DocumentName { get; set; }
        public string? EventDescription { get; set; }
        public int? SiteId { get; set; }
        public string? EventUrl { get; set; }
        public string? EventMachineName { get; set; }
        public string? EventUserAgent { get; set; }
        public string? EventUrlReferrer { get; set; }
    }
}
