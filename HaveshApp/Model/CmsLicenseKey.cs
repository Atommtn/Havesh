using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsLicenseKey
    {
        public int LicenseKeyId { get; set; }
        public string? LicenseDomain { get; set; }
        public string? LicenseKey { get; set; }
        public string? LicenseEdition { get; set; }
        public string? LicenseExpiration { get; set; }
        public int? LicenseServers { get; set; }
    }
}
