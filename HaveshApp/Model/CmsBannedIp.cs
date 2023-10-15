using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsBannedIp
    {
        public int IpaddressId { get; set; }
        public string Ipaddress { get; set; } = null!;
        public string IpaddressRegular { get; set; } = null!;
        public bool IpaddressAllowed { get; set; }
        public bool IpaddressAllowOverride { get; set; }
        public string? IpaddressBanReason { get; set; }
        public string IpaddressBanType { get; set; } = null!;
        public bool? IpaddressBanEnabled { get; set; }
        public int? IpaddressSiteId { get; set; }
        public Guid IpaddressGuid { get; set; }
        public DateTime IpaddressLastModified { get; set; }

        public virtual CmsSite? IpaddressSite { get; set; }
    }
}
