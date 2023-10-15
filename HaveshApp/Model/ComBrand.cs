using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComBrand
    {
        public ComBrand()
        {
            ComMultiBuyDiscountBrands = new HashSet<ComMultiBuyDiscountBrand>();
            ComSkus = new HashSet<ComSku>();
        }

        public int BrandId { get; set; }
        public string BrandDisplayName { get; set; } = null!;
        public string BrandName { get; set; } = null!;
        public string? BrandDescription { get; set; }
        public string? BrandHomepage { get; set; }
        public Guid? BrandThumbnailGuid { get; set; }
        public int BrandSiteId { get; set; }
        public bool? BrandEnabled { get; set; }
        public Guid BrandGuid { get; set; }
        public DateTime BrandLastModified { get; set; }

        public virtual CmsSite BrandSite { get; set; } = null!;
        public virtual ICollection<ComMultiBuyDiscountBrand> ComMultiBuyDiscountBrands { get; set; }
        public virtual ICollection<ComSku> ComSkus { get; set; }
    }
}
