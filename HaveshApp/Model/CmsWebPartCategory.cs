using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsWebPartCategory
    {
        public CmsWebPartCategory()
        {
            CmsWebParts = new HashSet<CmsWebPart>();
            InverseCategoryParent = new HashSet<CmsWebPartCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; } = null!;
        public int? CategoryParentId { get; set; }
        public string CategoryName { get; set; } = null!;
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public string? CategoryImagePath { get; set; }
        public string CategoryPath { get; set; } = null!;
        public int? CategoryLevel { get; set; }
        public int? CategoryChildCount { get; set; }
        public int? CategoryWebPartChildCount { get; set; }

        public virtual CmsWebPartCategory? CategoryParent { get; set; }
        public virtual ICollection<CmsWebPart> CmsWebParts { get; set; }
        public virtual ICollection<CmsWebPartCategory> InverseCategoryParent { get; set; }
    }
}
