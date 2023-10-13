using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsPageTemplateCategory
    {
        public CmsPageTemplateCategory()
        {
            CmsClasses = new HashSet<CmsClass>();
            CmsPageTemplates = new HashSet<CmsPageTemplate>();
            InverseCategoryParent = new HashSet<CmsPageTemplateCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryDisplayName { get; set; } = null!;
        public int? CategoryParentId { get; set; }
        public string? CategoryName { get; set; }
        public Guid CategoryGuid { get; set; }
        public DateTime CategoryLastModified { get; set; }
        public string? CategoryImagePath { get; set; }
        public int? CategoryChildCount { get; set; }
        public int? CategoryTemplateChildCount { get; set; }
        public string? CategoryPath { get; set; }
        public int? CategoryLevel { get; set; }

        public virtual CmsPageTemplateCategory? CategoryParent { get; set; }
        public virtual ICollection<CmsClass> CmsClasses { get; set; }
        public virtual ICollection<CmsPageTemplate> CmsPageTemplates { get; set; }
        public virtual ICollection<CmsPageTemplateCategory> InverseCategoryParent { get; set; }
    }
}
