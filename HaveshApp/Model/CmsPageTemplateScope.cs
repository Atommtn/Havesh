using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsPageTemplateScope
    {
        public int PageTemplateScopeId { get; set; }
        public string PageTemplateScopePath { get; set; } = null!;
        public string? PageTemplateScopeLevels { get; set; }
        public int? PageTemplateScopeCultureId { get; set; }
        public int? PageTemplateScopeClassId { get; set; }
        public int PageTemplateScopeTemplateId { get; set; }
        public int? PageTemplateScopeSiteId { get; set; }
        public DateTime PageTemplateScopeLastModified { get; set; }
        public Guid PageTemplateScopeGuid { get; set; }

        public virtual CmsClass? PageTemplateScopeClass { get; set; }
        public virtual CmsCulture? PageTemplateScopeCulture { get; set; }
        public virtual CmsSite? PageTemplateScopeSite { get; set; }
        public virtual CmsPageTemplate PageTemplateScopeTemplate { get; set; } = null!;
    }
}
