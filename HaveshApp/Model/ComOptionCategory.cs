using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComOptionCategory
    {
        public ComOptionCategory()
        {
            ComSkuoptionCategories = new HashSet<ComSkuoptionCategory>();
            ComSkus = new HashSet<ComSku>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public string CategorySelectionType { get; set; } = null!;
        public string? CategoryDefaultOptions { get; set; }
        public string? CategoryDescription { get; set; }
        public string? CategoryDefaultRecord { get; set; }
        public bool? CategoryEnabled { get; set; }
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public bool? CategoryDisplayPrice { get; set; }
        public int? CategorySiteId { get; set; }
        public int? CategoryTextMaxLength { get; set; }
        public string? CategoryType { get; set; }
        public int? CategoryTextMinLength { get; set; }
        public string? CategoryLiveSiteDisplayName { get; set; }

        public virtual CmsSite? CategorySite { get; set; }
        public virtual ICollection<ComSkuoptionCategory> ComSkuoptionCategories { get; set; }
        public virtual ICollection<ComSku> ComSkus { get; set; }
    }
}
