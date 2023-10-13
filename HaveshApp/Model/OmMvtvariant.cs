using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class OmMvtvariant
    {
        public OmMvtvariant()
        {
            Mvtcombinations = new HashSet<OmMvtcombination>();
        }

        public int MvtvariantId { get; set; }
        public string MvtvariantName { get; set; } = null!;
        public string MvtvariantDisplayName { get; set; } = null!;
        public Guid? MvtvariantInstanceGuid { get; set; }
        public string? MvtvariantZoneId { get; set; }
        public int MvtvariantPageTemplateId { get; set; }
        public bool? MvtvariantEnabled { get; set; }
        public string? MvtvariantWebParts { get; set; }
        public Guid MvtvariantGuid { get; set; }
        public DateTime MvtvariantLastModified { get; set; }
        public string? MvtvariantDescription { get; set; }
        public int? MvtvariantDocumentId { get; set; }

        public virtual CmsPageTemplate MvtvariantPageTemplate { get; set; } = null!;

        public virtual ICollection<OmMvtcombination> Mvtcombinations { get; set; }
    }
}
