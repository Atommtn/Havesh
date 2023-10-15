using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComMultiBuyCouponCode
    {
        public int MultiBuyCouponCodeId { get; set; }
        public string MultiBuyCouponCodeCode { get; set; } = null!;
        public int? MultiBuyCouponCodeUseLimit { get; set; }
        public int? MultiBuyCouponCodeUseCount { get; set; }
        public int MultiBuyCouponCodeMultiBuyDiscountId { get; set; }
        public DateTime MultiBuyCouponCodeLastModified { get; set; }
        public Guid MultiBuyCouponCodeGuid { get; set; }

        public virtual ComMultiBuyDiscount MultiBuyCouponCodeMultiBuyDiscount { get; set; } = null!;
    }
}
