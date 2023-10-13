using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComMultiBuyDiscountCollection
    {
        public int MultibuyDiscountId { get; set; }
        public int CollectionId { get; set; }
        public bool? CollectionIncluded { get; set; }

        public virtual ComCollection Collection { get; set; } = null!;
        public virtual ComMultiBuyDiscount MultibuyDiscount { get; set; } = null!;
    }
}
