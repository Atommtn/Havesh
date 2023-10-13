using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComOrder
    {
        public ComOrder()
        {
            ComOrderAddresses = new HashSet<ComOrderAddress>();
            ComOrderItems = new HashSet<ComOrderItem>();
            ComOrderStatusUsers = new HashSet<ComOrderStatusUser>();
        }

        public int OrderId { get; set; }
        public int? OrderShippingOptionId { get; set; }
        public decimal? OrderTotalShipping { get; set; }
        public decimal OrderTotalPrice { get; set; }
        public decimal OrderTotalTax { get; set; }
        public DateTime OrderDate { get; set; }
        public int? OrderStatusId { get; set; }
        public int? OrderCurrencyId { get; set; }
        public int OrderCustomerId { get; set; }
        public int? OrderCreatedByUserId { get; set; }
        public string? OrderNote { get; set; }
        public int OrderSiteId { get; set; }
        public int? OrderPaymentOptionId { get; set; }
        public string? OrderInvoice { get; set; }
        public string? OrderInvoiceNumber { get; set; }
        public string? OrderTrackingNumber { get; set; }
        public string? OrderCustomData { get; set; }
        public string? OrderPaymentResult { get; set; }
        public Guid OrderGuid { get; set; }
        public DateTime OrderLastModified { get; set; }
        public decimal? OrderTotalPriceInMainCurrency { get; set; }
        public bool? OrderIsPaid { get; set; }
        public string? OrderCulture { get; set; }
        public string? OrderDiscounts { get; set; }
        public decimal OrderGrandTotal { get; set; }
        public decimal? OrderGrandTotalInMainCurrency { get; set; }
        public string? OrderOtherPayments { get; set; }
        public string? OrderTaxSummary { get; set; }
        public string? OrderCouponCodes { get; set; }

        public virtual CmsUser? OrderCreatedByUser { get; set; }
        public virtual ComCurrency? OrderCurrency { get; set; }
        public virtual ComCustomer OrderCustomer { get; set; } = null!;
        public virtual ComPaymentOption? OrderPaymentOption { get; set; }
        public virtual ComShippingOption? OrderShippingOption { get; set; }
        public virtual CmsSite OrderSite { get; set; } = null!;
        public virtual ComOrderStatus? OrderStatus { get; set; }
        public virtual ICollection<ComOrderAddress> ComOrderAddresses { get; set; }
        public virtual ICollection<ComOrderItem> ComOrderItems { get; set; }
        public virtual ICollection<ComOrderStatusUser> ComOrderStatusUsers { get; set; }
    }
}
