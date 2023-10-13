using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class OmAbtest
    {
        public OmAbtest()
        {
            OmAbvariantData = new HashSet<OmAbvariantDatum>();
            OmAbvariants = new HashSet<OmAbvariant>();
        }

        public int AbtestId { get; set; }
        public string AbtestName { get; set; } = null!;
        public string? AbtestDescription { get; set; }
        public string? AbtestCulture { get; set; }
        public string AbtestOriginalPage { get; set; } = null!;
        public DateTime? AbtestOpenFrom { get; set; }
        public DateTime? AbtestOpenTo { get; set; }
        public int AbtestSiteId { get; set; }
        public Guid AbtestGuid { get; set; }
        public DateTime AbtestLastModified { get; set; }
        public string AbtestDisplayName { get; set; } = null!;
        public int AbtestIncludedTraffic { get; set; }
        public string? AbtestVisitorTargeting { get; set; }
        public string? AbtestConversions { get; set; }
        public Guid? AbtestWinnerGuid { get; set; }

        public virtual CmsSite AbtestSite { get; set; } = null!;
        public virtual ICollection<OmAbvariantDatum> OmAbvariantData { get; set; }
        public virtual ICollection<OmAbvariant> OmAbvariants { get; set; }
    }
}
