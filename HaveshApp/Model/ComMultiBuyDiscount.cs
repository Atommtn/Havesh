using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComMultiBuyDiscount
    {
        public ComMultiBuyDiscount()
        {
            ComMultiBuyCouponCodes = new HashSet<ComMultiBuyCouponCode>();
            ComMultiBuyDiscountBrands = new HashSet<ComMultiBuyDiscountBrand>();
            ComMultiBuyDiscountCollections = new HashSet<ComMultiBuyDiscountCollection>();
            ComMultiBuyDiscountTrees = new HashSet<ComMultiBuyDiscountTree>();
            Departments = new HashSet<ComDepartment>();
            Skus = new HashSet<ComSku>();
        }

        public int MultiBuyDiscountId { get; set; }
        public string MultiBuyDiscountDisplayName { get; set; } = null!;
        public string MultiBuyDiscountName { get; set; } = null!;
        public string? MultiBuyDiscountDescription { get; set; }
        public bool? MultiBuyDiscountEnabled { get; set; }
        public Guid MultiBuyDiscountGuid { get; set; }
        public DateTime MultiBuyDiscountLastModified { get; set; }
        public int MultiBuyDiscountSiteId { get; set; }
        public bool? MultiBuyDiscountApplyFurtherDiscounts { get; set; }
        public int MultiBuyDiscountMinimumBuyCount { get; set; }
        public DateTime? MultiBuyDiscountValidFrom { get; set; }
        public DateTime? MultiBuyDiscountValidTo { get; set; }
        public string MultiBuyDiscountCustomerRestriction { get; set; } = null!;
        public string? MultiBuyDiscountRoles { get; set; }
        public int? MultiBuyDiscountApplyToSkuid { get; set; }
        public int? MultiBuyDiscountLimitPerOrder { get; set; }
        public bool? MultiBuyDiscountUsesCoupons { get; set; }
        public decimal? MultiBuyDiscountValue { get; set; }
        public bool? MultiBuyDiscountIsFlat { get; set; }
        public bool? MultiBuyDiscountAutoAddEnabled { get; set; }
        public int? MultiBuyDiscountPriority { get; set; }
        public bool MultiBuyDiscountIsProductCoupon { get; set; }

        public virtual ComSku? MultiBuyDiscountApplyToSku { get; set; }
        public virtual CmsSite MultiBuyDiscountSite { get; set; } = null!;
        public virtual ICollection<ComMultiBuyCouponCode> ComMultiBuyCouponCodes { get; set; }
        public virtual ICollection<ComMultiBuyDiscountBrand> ComMultiBuyDiscountBrands { get; set; }
        public virtual ICollection<ComMultiBuyDiscountCollection> ComMultiBuyDiscountCollections { get; set; }
        public virtual ICollection<ComMultiBuyDiscountTree> ComMultiBuyDiscountTrees { get; set; }

        public virtual ICollection<ComDepartment> Departments { get; set; }
        public virtual ICollection<ComSku> Skus { get; set; }
    }
}
