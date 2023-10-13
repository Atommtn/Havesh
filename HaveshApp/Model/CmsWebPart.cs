using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsWebPart
    {
        public CmsWebPart()
        {
            CmsWebPartLayouts = new HashSet<CmsWebPartLayout>();
            CmsWidgets = new HashSet<CmsWidget>();
            InverseWebPartParent = new HashSet<CmsWebPart>();
        }

        public int WebPartId { get; set; }
        public string WebPartName { get; set; } = null!;
        public string WebPartDisplayName { get; set; } = null!;
        public string? WebPartDescription { get; set; }
        public string WebPartFileName { get; set; } = null!;
        public string WebPartProperties { get; set; } = null!;
        public int WebPartCategoryId { get; set; }
        public int? WebPartParentId { get; set; }
        public string? WebPartDocumentation { get; set; }
        public Guid WebPartGuid { get; set; }
        public DateTime WebPartLastModified { get; set; }
        public int? WebPartType { get; set; }
        public string? WebPartDefaultValues { get; set; }
        public int? WebPartResourceId { get; set; }
        public string? WebPartCss { get; set; }
        public bool? WebPartSkipInsertProperties { get; set; }
        public Guid? WebPartThumbnailGuid { get; set; }
        public string? WebPartDefaultConfiguration { get; set; }
        public string? WebPartIconClass { get; set; }

        public virtual CmsWebPartCategory WebPartCategory { get; set; } = null!;
        public virtual CmsWebPart? WebPartParent { get; set; }
        public virtual CmsResource? WebPartResource { get; set; }
        public virtual ICollection<CmsWebPartLayout> CmsWebPartLayouts { get; set; }
        public virtual ICollection<CmsWidget> CmsWidgets { get; set; }
        public virtual ICollection<CmsWebPart> InverseWebPartParent { get; set; }
    }
}
