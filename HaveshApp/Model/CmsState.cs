using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsState
    {
        public CmsState()
        {
            ComAddresses = new HashSet<ComAddress>();
            ComOrderAddresses = new HashSet<ComOrderAddress>();
            ComTaxClassStates = new HashSet<ComTaxClassState>();
            OmAccounts = new HashSet<OmAccount>();
            OmContacts = new HashSet<OmContact>();
        }

        public int StateId { get; set; }
        public string StateDisplayName { get; set; } = null!;
        public string StateName { get; set; } = null!;
        public string? StateCode { get; set; }
        public int CountryId { get; set; }
        public Guid StateGuid { get; set; }
        public DateTime StateLastModified { get; set; }

        public virtual CmsCountry Country { get; set; } = null!;
        public virtual ICollection<ComAddress> ComAddresses { get; set; }
        public virtual ICollection<ComOrderAddress> ComOrderAddresses { get; set; }
        public virtual ICollection<ComTaxClassState> ComTaxClassStates { get; set; }
        public virtual ICollection<OmAccount> OmAccounts { get; set; }
        public virtual ICollection<OmContact> OmContacts { get; set; }
    }
}
