using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewComSkuoptionCategoryOptionCategoryJoined
    {
        public int Skuid { get; set; }
        public int CategoryId { get; set; }
        public bool? AllowAllOptions { get; set; }
        public int SkucategoryId { get; set; }
        public int? SkucategoryOrder { get; set; }
        public string CategoryDisplayName { get; set; } = null!;
        public string CategoryName { get; set; } = null!;
        public string CategorySelectionType { get; set; } = null!;
        public string? CategoryDefaultOptions { get; set; }
        public string? CategoryDescription { get; set; }
        public string? CategoryDefaultRecord { get; set; }
        public bool CategoryEnabled { get; set; }
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public bool? CategoryDisplayPrice { get; set; }
        public int? CategorySiteId { get; set; }
        public int? CategoryTextMaxLength { get; set; }
        public string? CategoryType { get; set; }
        public int? CategoryTextMinLength { get; set; }
        public string? CategoryLiveSiteDisplayName { get; set; }
    }
}
