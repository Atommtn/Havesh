using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsCulture
    {
        public CmsCulture()
        {
            CmsPageTemplateScopes = new HashSet<CmsPageTemplateScope>();
            CmsResourceTranslations = new HashSet<CmsResourceTranslation>();
            CmsUserCultures = new HashSet<CmsUserCulture>();
            CmsWorkflowScopes = new HashSet<CmsWorkflowScope>();
            Indices = new HashSet<CmsSearchIndex>();
            Sites = new HashSet<CmsSite>();
            Words = new HashSet<BadWordsWord>();
        }

        public int CultureId { get; set; }
        public string CultureName { get; set; } = null!;
        public string CultureCode { get; set; } = null!;
        public string CultureShortName { get; set; } = null!;
        public Guid CultureGuid { get; set; }
        public DateTime CultureLastModified { get; set; }
        public string? CultureAlias { get; set; }
        public bool? CultureIsUiculture { get; set; }

        public virtual ICollection<CmsPageTemplateScope> CmsPageTemplateScopes { get; set; }
        public virtual ICollection<CmsResourceTranslation> CmsResourceTranslations { get; set; }
        public virtual ICollection<CmsUserCulture> CmsUserCultures { get; set; }
        public virtual ICollection<CmsWorkflowScope> CmsWorkflowScopes { get; set; }

        public virtual ICollection<CmsSearchIndex> Indices { get; set; }
        public virtual ICollection<CmsSite> Sites { get; set; }
        public virtual ICollection<BadWordsWord> Words { get; set; }
    }
}
