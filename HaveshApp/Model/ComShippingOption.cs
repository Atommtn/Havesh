using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComShippingOption
    {
        public ComShippingOption()
        {
            ComOrders = new HashSet<ComOrder>();
            ComShippingCosts = new HashSet<ComShippingCost>();
            ComShoppingCarts = new HashSet<ComShoppingCart>();
        }

        public int ShippingOptionId { get; set; }
        public string ShippingOptionName { get; set; } = null!;
        public string ShippingOptionDisplayName { get; set; } = null!;
        public bool? ShippingOptionEnabled { get; set; }
        public int? ShippingOptionSiteId { get; set; }
        public Guid ShippingOptionGuid { get; set; }
        public DateTime ShippingOptionLastModified { get; set; }
        public Guid? ShippingOptionThumbnailGuid { get; set; }
        public string? ShippingOptionDescription { get; set; }
        public int? ShippingOptionCarrierId { get; set; }
        public string? ShippingOptionCarrierServiceName { get; set; }
        public int? ShippingOptionTaxClassId { get; set; }

        public virtual ComCarrier? ShippingOptionCarrier { get; set; }
        public virtual CmsSite? ShippingOptionSite { get; set; }
        public virtual ComTaxClass? ShippingOptionTaxClass { get; set; }
        public virtual ICollection<ComOrder> ComOrders { get; set; }
        public virtual ICollection<ComShippingCost> ComShippingCosts { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCarts { get; set; }
    }
}
