using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OmPersonalizationVariant
    {
        public int VariantId { get; set; }
        public bool? VariantEnabled { get; set; }
        public string VariantName { get; set; } = null!;
        public string VariantDisplayName { get; set; } = null!;
        public Guid? VariantInstanceGuid { get; set; }
        public string? VariantZoneId { get; set; }
        public int VariantPageTemplateId { get; set; }
        public string VariantWebParts { get; set; } = null!;
        public int? VariantPosition { get; set; }
        public Guid VariantGuid { get; set; }
        public DateTime VariantLastModified { get; set; }
        public string? VariantDescription { get; set; }
        public int? VariantDocumentId { get; set; }
        public string VariantDisplayCondition { get; set; } = null!;

        public virtual CmsDocument? VariantDocument { get; set; }
        public virtual CmsPageTemplate VariantPageTemplate { get; set; } = null!;
    }
}
