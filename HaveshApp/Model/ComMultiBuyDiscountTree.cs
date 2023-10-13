using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComMultiBuyDiscountTree
    {
        public int MultiBuyDiscountId { get; set; }
        public int NodeId { get; set; }
        public bool? NodeIncluded { get; set; }

        public virtual ComMultiBuyDiscount MultiBuyDiscount { get; set; } = null!;
        public virtual CmsTree Node { get; set; } = null!;
    }
}
