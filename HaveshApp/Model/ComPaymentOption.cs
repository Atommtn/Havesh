using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComPaymentOption
    {
        public ComPaymentOption()
        {
            ComOrders = new HashSet<ComOrder>();
            ComShoppingCarts = new HashSet<ComShoppingCart>();
        }

        public int PaymentOptionId { get; set; }
        public string PaymentOptionName { get; set; } = null!;
        public string PaymentOptionDisplayName { get; set; } = null!;
        public bool? PaymentOptionEnabled { get; set; }
        public int? PaymentOptionSiteId { get; set; }
        public string? PaymentOptionPaymentGateUrl { get; set; }
        public string? PaymentOptionAssemblyName { get; set; }
        public string? PaymentOptionClassName { get; set; }
        public int? PaymentOptionSucceededOrderStatusId { get; set; }
        public int? PaymentOptionFailedOrderStatusId { get; set; }
        public Guid PaymentOptionGuid { get; set; }
        public DateTime PaymentOptionLastModified { get; set; }
        public bool? PaymentOptionAllowIfNoShipping { get; set; }
        public Guid? PaymentOptionThumbnailGuid { get; set; }
        public string? PaymentOptionDescription { get; set; }
        public int? PaymentOptionAuthorizedOrderStatusId { get; set; }

        public virtual ComOrderStatus? PaymentOptionAuthorizedOrderStatus { get; set; }
        public virtual ComOrderStatus? PaymentOptionFailedOrderStatus { get; set; }
        public virtual CmsSite? PaymentOptionSite { get; set; }
        public virtual ComOrderStatus? PaymentOptionSucceededOrderStatus { get; set; }
        public virtual ICollection<ComOrder> ComOrders { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCarts { get; set; }
    }
}
