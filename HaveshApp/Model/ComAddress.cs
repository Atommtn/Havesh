using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComAddress
    {
        public ComAddress()
        {
            ComShoppingCartShoppingCartBillingAddresses = new HashSet<ComShoppingCart>();
            ComShoppingCartShoppingCartCompanyAddresses = new HashSet<ComShoppingCart>();
            ComShoppingCartShoppingCartShippingAddresses = new HashSet<ComShoppingCart>();
        }

        public int AddressId { get; set; }
        public string AddressName { get; set; } = null!;
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string AddressCity { get; set; } = null!;
        public string AddressZip { get; set; } = null!;
        public string? AddressPhone { get; set; }
        public int AddressCustomerId { get; set; }
        public int AddressCountryId { get; set; }
        public int? AddressStateId { get; set; }
        public string AddressPersonalName { get; set; } = null!;
        public Guid? AddressGuid { get; set; }
        public DateTime AddressLastModified { get; set; }

        public virtual CmsCountry AddressCountry { get; set; } = null!;
        public virtual ComCustomer AddressCustomer { get; set; } = null!;
        public virtual CmsState? AddressState { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCartShoppingCartBillingAddresses { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCartShoppingCartCompanyAddresses { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCartShoppingCartShippingAddresses { get; set; }
    }
}
