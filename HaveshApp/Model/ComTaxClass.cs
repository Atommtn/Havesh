using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComTaxClass
    {
        public ComTaxClass()
        {
            ComDepartments = new HashSet<ComDepartment>();
            ComShippingOptions = new HashSet<ComShippingOption>();
            ComSkus = new HashSet<ComSku>();
            ComTaxClassCountries = new HashSet<ComTaxClassCountry>();
            ComTaxClassStates = new HashSet<ComTaxClassState>();
        }

        public int TaxClassId { get; set; }
        public string TaxClassName { get; set; } = null!;
        public string TaxClassDisplayName { get; set; } = null!;
        public bool? TaxClassZeroIfIdsupplied { get; set; }
        public Guid TaxClassGuid { get; set; }
        public DateTime TaxClassLastModified { get; set; }
        public int? TaxClassSiteId { get; set; }

        public virtual CmsSite? TaxClassSite { get; set; }
        public virtual ICollection<ComDepartment> ComDepartments { get; set; }
        public virtual ICollection<ComShippingOption> ComShippingOptions { get; set; }
        public virtual ICollection<ComSku> ComSkus { get; set; }
        public virtual ICollection<ComTaxClassCountry> ComTaxClassCountries { get; set; }
        public virtual ICollection<ComTaxClassState> ComTaxClassStates { get; set; }
    }
}
