using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class AnalyticsConversion
    {
        public int ConversionId { get; set; }
        public string ConversionName { get; set; } = null!;
        public string ConversionDisplayName { get; set; } = null!;
        public string? ConversionDescription { get; set; }
        public Guid ConversionGuid { get; set; }
        public DateTime ConversionLastModified { get; set; }
        public int ConversionSiteId { get; set; }

        public virtual CmsSite ConversionSite { get; set; } = null!;
    }
}
