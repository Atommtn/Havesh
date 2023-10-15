using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsTransformation
    {
        public int TransformationId { get; set; }
        public string TransformationName { get; set; } = null!;
        public string TransformationCode { get; set; } = null!;
        public string TransformationType { get; set; } = null!;
        public int TransformationClassId { get; set; }
        public string? TransformationVersionGuid { get; set; }
        public Guid TransformationGuid { get; set; }
        public DateTime TransformationLastModified { get; set; }
        public bool? TransformationIsHierarchical { get; set; }
        public string? TransformationHierarchicalXml { get; set; }
        public string? TransformationCss { get; set; }
        public string? TransformationPreferredDocument { get; set; }

        public virtual CmsClass TransformationClass { get; set; } = null!;
    }
}
