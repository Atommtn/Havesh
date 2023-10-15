using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsWorkflowScope
    {
        public int ScopeId { get; set; }
        public string ScopeStartingPath { get; set; } = null!;
        public int ScopeWorkflowId { get; set; }
        public int? ScopeClassId { get; set; }
        public int ScopeSiteId { get; set; }
        public Guid ScopeGuid { get; set; }
        public DateTime ScopeLastModified { get; set; }
        public int? ScopeCultureId { get; set; }
        public bool? ScopeExcludeChildren { get; set; }
        public bool ScopeExcluded { get; set; }
        public string? ScopeMacroCondition { get; set; }

        public virtual CmsClass? ScopeClass { get; set; }
        public virtual CmsCulture? ScopeCulture { get; set; }
        public virtual CmsSite ScopeSite { get; set; } = null!;
        public virtual CmsWorkflow ScopeWorkflow { get; set; } = null!;
    }
}
