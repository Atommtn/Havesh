using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComMultiBuyDiscountBrand
    {
        public int MultiBuyDiscountId { get; set; }
        public int BrandId { get; set; }
        public bool? BrandIncluded { get; set; }

        public virtual ComBrand Brand { get; set; } = null!;
        public virtual ComMultiBuyDiscount MultiBuyDiscount { get; set; } = null!;
    }
}
