using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComShoppingCart
    {
        public ComShoppingCart()
        {
            ComShoppingCartCouponCodes = new HashSet<ComShoppingCartCouponCode>();
            ComShoppingCartSkus = new HashSet<ComShoppingCartSku>();
        }

        public int ShoppingCartId { get; set; }
        public Guid ShoppingCartGuid { get; set; }
        public int? ShoppingCartUserId { get; set; }
        public int ShoppingCartSiteId { get; set; }
        public DateTime ShoppingCartLastUpdate { get; set; }
        public int? ShoppingCartCurrencyId { get; set; }
        public int? ShoppingCartPaymentOptionId { get; set; }
        public int? ShoppingCartShippingOptionId { get; set; }
        public int? ShoppingCartBillingAddressId { get; set; }
        public int? ShoppingCartShippingAddressId { get; set; }
        public int? ShoppingCartCustomerId { get; set; }
        public string? ShoppingCartNote { get; set; }
        public int? ShoppingCartCompanyAddressId { get; set; }
        public string? ShoppingCartCustomData { get; set; }
        public int? ShoppingCartContactId { get; set; }

        public virtual ComAddress? ShoppingCartBillingAddress { get; set; }
        public virtual ComAddress? ShoppingCartCompanyAddress { get; set; }
        public virtual ComCurrency? ShoppingCartCurrency { get; set; }
        public virtual ComCustomer? ShoppingCartCustomer { get; set; }
        public virtual ComPaymentOption? ShoppingCartPaymentOption { get; set; }
        public virtual ComAddress? ShoppingCartShippingAddress { get; set; }
        public virtual ComShippingOption? ShoppingCartShippingOption { get; set; }
        public virtual CmsSite ShoppingCartSite { get; set; } = null!;
        public virtual CmsUser? ShoppingCartUser { get; set; }
        public virtual ICollection<ComShoppingCartCouponCode> ComShoppingCartCouponCodes { get; set; }
        public virtual ICollection<ComShoppingCartSku> ComShoppingCartSkus { get; set; }
    }
}
