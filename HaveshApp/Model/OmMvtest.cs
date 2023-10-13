using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class OmMvtest
    {
        public int MvtestId { get; set; }
        public string MvtestName { get; set; } = null!;
        public string? MvtestDescription { get; set; }
        public string MvtestPage { get; set; } = null!;
        public int MvtestSiteId { get; set; }
        public string? MvtestCulture { get; set; }
        public DateTime? MvtestOpenFrom { get; set; }
        public DateTime? MvtestOpenTo { get; set; }
        public int? MvtestMaxConversions { get; set; }
        public int? MvtestConversions { get; set; }
        public string? MvtestTargetConversionType { get; set; }
        public Guid MvtestGuid { get; set; }
        public DateTime MvtestLastModified { get; set; }
        public bool MvtestEnabled { get; set; }
        public string MvtestDisplayName { get; set; } = null!;

        public virtual CmsSite MvtestSite { get; set; } = null!;
    }
}
