using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsDocumentAlias
    {
        public int AliasId { get; set; }
        public int AliasNodeId { get; set; }
        public string? AliasCulture { get; set; }
        public string? AliasUrlpath { get; set; }
        public string? AliasExtensions { get; set; }
        public string? AliasWildcardRule { get; set; }
        public int? AliasPriority { get; set; }
        public Guid? AliasGuid { get; set; }
        public DateTime AliasLastModified { get; set; }
        public int AliasSiteId { get; set; }
        public string? AliasActionMode { get; set; }

        public virtual CmsTree AliasNode { get; set; } = null!;
        public virtual CmsSite AliasSite { get; set; } = null!;
    }
}
