using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewCmsWebPartCategoryWebpartJoined
    {
        public int ObjectId { get; set; }
        public string CodeName { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public int? ParentId { get; set; }
        public Guid Guid { get; set; }
        public DateTime LastModified { get; set; }
        public string? CategoryImagePath { get; set; }
        public string? ObjectPath { get; set; }
        public int? ObjectLevel { get; set; }
        public int? CategoryChildCount { get; set; }
        public int? CategoryWebPartChildCount { get; set; }
        public int? CompleteChildCount { get; set; }
        public int? WebPartParentId { get; set; }
        public string? WebPartFileName { get; set; }
        public Guid? WebPartGuid { get; set; }
        public int? WebPartType { get; set; }
        public string? WebPartDescription { get; set; }
        public string ObjectType { get; set; } = null!;
        public Guid? ThumbnailGuid { get; set; }
        public string? IconClass { get; set; }
        public bool? WebPartSkipInsertProperties { get; set; }
    }
}
