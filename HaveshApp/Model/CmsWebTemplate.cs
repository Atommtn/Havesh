using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsWebTemplate
    {
        public int WebTemplateId { get; set; }
        public string WebTemplateDisplayName { get; set; } = null!;
        public string WebTemplateFileName { get; set; } = null!;
        public string WebTemplateDescription { get; set; } = null!;
        public Guid WebTemplateGuid { get; set; }
        public DateTime WebTemplateLastModified { get; set; }
        public string WebTemplateName { get; set; } = null!;
        public int WebTemplateOrder { get; set; }
        public string WebTemplateLicenses { get; set; } = null!;
        public Guid? WebTemplateThumbnailGuid { get; set; }
        public string? WebTemplateShortDescription { get; set; }
    }
}
