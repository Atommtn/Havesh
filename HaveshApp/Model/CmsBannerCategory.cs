using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsBannerCategory
    {
        public CmsBannerCategory()
        {
            CmsBanners = new HashSet<CmsBanner>();
        }

        public int BannerCategoryId { get; set; }
        public string BannerCategoryName { get; set; } = null!;
        public string BannerCategoryDisplayName { get; set; } = null!;
        public int? BannerCategorySiteId { get; set; }
        public Guid BannerCategoryGuid { get; set; }
        public DateTime BannerCategoryLastModified { get; set; }
        public bool? BannerCategoryEnabled { get; set; }

        public virtual CmsSite? BannerCategorySite { get; set; }
        public virtual ICollection<CmsBanner> CmsBanners { get; set; }
    }
}
