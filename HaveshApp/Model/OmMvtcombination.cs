using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OmMvtcombination
    {
        public OmMvtcombination()
        {
            Mvtvariants = new HashSet<OmMvtvariant>();
        }

        public int MvtcombinationId { get; set; }
        public string MvtcombinationName { get; set; } = null!;
        public string? MvtcombinationCustomName { get; set; }
        public int MvtcombinationPageTemplateId { get; set; }
        public bool MvtcombinationEnabled { get; set; }
        public Guid MvtcombinationGuid { get; set; }
        public DateTime MvtcombinationLastModified { get; set; }
        public bool? MvtcombinationIsDefault { get; set; }
        public int? MvtcombinationConversions { get; set; }
        public int? MvtcombinationDocumentId { get; set; }

        public virtual ICollection<OmMvtvariant> Mvtvariants { get; set; }
    }
}
