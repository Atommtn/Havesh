using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComOrderItem
    {
        public ComOrderItem()
        {
            ComOrderItemSkufiles = new HashSet<ComOrderItemSkufile>();
        }

        public int OrderItemId { get; set; }
        public int OrderItemOrderId { get; set; }
        public int OrderItemSkuid { get; set; }
        public string OrderItemSkuname { get; set; } = null!;
        public decimal OrderItemUnitPrice { get; set; }
        public int OrderItemUnitCount { get; set; }
        public string? OrderItemCustomData { get; set; }
        public Guid OrderItemGuid { get; set; }
        public Guid? OrderItemParentGuid { get; set; }
        public DateTime OrderItemLastModified { get; set; }
        public DateTime? OrderItemValidTo { get; set; }
        public Guid? OrderItemBundleGuid { get; set; }
        public decimal? OrderItemTotalPriceInMainCurrency { get; set; }
        public bool? OrderItemSendNotification { get; set; }
        public string? OrderItemText { get; set; }
        public string? OrderItemProductDiscounts { get; set; }
        public string? OrderItemDiscountSummary { get; set; }
        public decimal OrderItemTotalPrice { get; set; }

        public virtual ComOrder OrderItemOrder { get; set; } = null!;
        public virtual ComSku OrderItemSku { get; set; } = null!;
        public virtual ICollection<ComOrderItemSkufile> ComOrderItemSkufiles { get; set; }
    }
}
