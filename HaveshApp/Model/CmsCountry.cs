using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsCountry
    {
        public CmsCountry()
        {
            CmsStates = new HashSet<CmsState>();
            ComAddresses = new HashSet<ComAddress>();
            ComOrderAddresses = new HashSet<ComOrderAddress>();
            ComTaxClassCountries = new HashSet<ComTaxClassCountry>();
            OmAccounts = new HashSet<OmAccount>();
            OmContacts = new HashSet<OmContact>();
        }

        public int CountryId { get; set; }
        public string CountryDisplayName { get; set; } = null!;
        public string CountryName { get; set; } = null!;
        public Guid CountryGuid { get; set; }
        public DateTime CountryLastModified { get; set; }
        public string? CountryTwoLetterCode { get; set; }
        public string? CountryThreeLetterCode { get; set; }

        public virtual ICollection<CmsState> CmsStates { get; set; }
        public virtual ICollection<ComAddress> ComAddresses { get; set; }
        public virtual ICollection<ComOrderAddress> ComOrderAddresses { get; set; }
        public virtual ICollection<ComTaxClassCountry> ComTaxClassCountries { get; set; }
        public virtual ICollection<OmAccount> OmAccounts { get; set; }
        public virtual ICollection<OmContact> OmContacts { get; set; }
    }
}
