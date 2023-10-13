using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComShoppingCartSku
    {
        public int CartItemId { get; set; }
        public int ShoppingCartId { get; set; }
        public int Skuid { get; set; }
        public int Skuunits { get; set; }
        public string? CartItemCustomData { get; set; }
        public Guid? CartItemGuid { get; set; }
        public Guid? CartItemParentGuid { get; set; }
        public DateTime? CartItemValidTo { get; set; }
        public Guid? CartItemBundleGuid { get; set; }
        public string? CartItemText { get; set; }
        public int? CartItemAutoAddedUnits { get; set; }

        public virtual ComShoppingCart ShoppingCart { get; set; } = null!;
        public virtual ComSku Sku { get; set; } = null!;
    }
}
