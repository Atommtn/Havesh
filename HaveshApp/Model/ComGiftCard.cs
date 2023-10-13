using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComGiftCard
    {
        public ComGiftCard()
        {
            ComGiftCardCouponCodes = new HashSet<ComGiftCardCouponCode>();
        }

        public int GiftCardId { get; set; }
        public Guid GiftCardGuid { get; set; }
        public string GiftCardDisplayName { get; set; } = null!;
        public string GiftCardName { get; set; } = null!;
        public string? GiftCardDescription { get; set; }
        public bool? GiftCardEnabled { get; set; }
        public DateTime GiftCardLastModified { get; set; }
        public int GiftCardSiteId { get; set; }
        public decimal GiftCardValue { get; set; }
        public decimal? GiftCardMinimumOrderPrice { get; set; }
        public string? GiftCardCartCondition { get; set; }
        public DateTime? GiftCardValidFrom { get; set; }
        public DateTime? GiftCardValidTo { get; set; }
        public string? GiftCardCustomerRestriction { get; set; }
        public string? GiftCardRoles { get; set; }

        public virtual CmsSite GiftCardSite { get; set; } = null!;
        public virtual ICollection<ComGiftCardCouponCode> ComGiftCardCouponCodes { get; set; }
    }
}
