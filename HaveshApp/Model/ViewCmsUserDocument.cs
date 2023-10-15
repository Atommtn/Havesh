using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewCmsUserDocument
    {
        public string DocumentName { get; set; } = null!;
        public int NodeSiteId { get; set; }
        public int NodeId { get; set; }
        public string ClassName { get; set; } = null!;
        public string ClassDisplayName { get; set; } = null!;
        public string? DocumentNamePath { get; set; }
        public DateTime? DocumentModifiedWhen { get; set; }
        public string DocumentCulture { get; set; } = null!;
        public string? CultureName { get; set; }
        public int? UserId1 { get; set; }
        public int? UserId2 { get; set; }
        public int? UserId3 { get; set; }
        public int? DocumentWorkflowStepId { get; set; }
        public string NodeAliasPath { get; set; } = null!;
        public string Type { get; set; } = null!;
    }
}
