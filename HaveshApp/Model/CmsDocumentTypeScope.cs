using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsDocumentTypeScope
    {
        public CmsDocumentTypeScope()
        {
            Classes = new HashSet<CmsClass>();
        }

        public int ScopeId { get; set; }
        public string ScopePath { get; set; } = null!;
        public int? ScopeSiteId { get; set; }
        public DateTime ScopeLastModified { get; set; }
        public Guid? ScopeGuid { get; set; }
        public bool? ScopeIncludeChildren { get; set; }
        public bool? ScopeAllowAllTypes { get; set; }
        public bool? ScopeAllowLinks { get; set; }
        public bool? ScopeAllowAbvariant { get; set; }
        public string? ScopeMacroCondition { get; set; }

        public virtual CmsSite? ScopeSite { get; set; }

        public virtual ICollection<CmsClass> Classes { get; set; }
    }
}
