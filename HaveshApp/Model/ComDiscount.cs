using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComDiscount
    {
        public ComDiscount()
        {
            ComCouponCodes = new HashSet<ComCouponCode>();
        }

        public int DiscountId { get; set; }
        public string DiscountDisplayName { get; set; } = null!;
        public string DiscountName { get; set; } = null!;
        public decimal DiscountValue { get; set; }
        public bool? DiscountEnabled { get; set; }
        public Guid DiscountGuid { get; set; }
        public DateTime DiscountLastModified { get; set; }
        public int DiscountSiteId { get; set; }
        public string? DiscountDescription { get; set; }
        public DateTime? DiscountValidFrom { get; set; }
        public DateTime? DiscountValidTo { get; set; }
        public double DiscountOrder { get; set; }
        public string? DiscountProductCondition { get; set; }
        public string? DiscountRoles { get; set; }
        public string? DiscountCustomerRestriction { get; set; }
        public bool DiscountIsFlat { get; set; }
        public string? DiscountCartCondition { get; set; }
        public string DiscountApplyTo { get; set; } = null!;
        public bool? DiscountApplyFurtherDiscounts { get; set; }
        public decimal? DiscountOrderAmount { get; set; }
        public bool DiscountUsesCoupons { get; set; }

        public virtual CmsSite DiscountSite { get; set; } = null!;
        public virtual ICollection<ComCouponCode> ComCouponCodes { get; set; }
    }
}
