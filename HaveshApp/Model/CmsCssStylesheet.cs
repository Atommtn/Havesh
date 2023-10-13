using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsCssStylesheet
    {
        public CmsCssStylesheet()
        {
            CmsDocuments = new HashSet<CmsDocument>();
            CmsSiteSiteDefaultEditorStylesheetNavigations = new HashSet<CmsSite>();
            CmsSiteSiteDefaultStylesheets = new HashSet<CmsSite>();
            Sites = new HashSet<CmsSite>();
        }

        public int StylesheetId { get; set; }
        public string StylesheetDisplayName { get; set; } = null!;
        public string StylesheetName { get; set; } = null!;
        public string? StylesheetText { get; set; }
        public Guid? StylesheetVersionGuid { get; set; }
        public Guid? StylesheetGuid { get; set; }
        public DateTime StylesheetLastModified { get; set; }
        public string? StylesheetDynamicCode { get; set; }
        public string? StylesheetDynamicLanguage { get; set; }

        public virtual ICollection<CmsDocument> CmsDocuments { get; set; }
        public virtual ICollection<CmsSite> CmsSiteSiteDefaultEditorStylesheetNavigations { get; set; }
        public virtual ICollection<CmsSite> CmsSiteSiteDefaultStylesheets { get; set; }

        public virtual ICollection<CmsSite> Sites { get; set; }
    }
}
