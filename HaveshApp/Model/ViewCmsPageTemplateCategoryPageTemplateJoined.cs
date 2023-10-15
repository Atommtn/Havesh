using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewCmsPageTemplateCategoryPageTemplateJoined
    {
        public int ObjectId { get; set; }
        public string? CodeName { get; set; }
        public string DisplayName { get; set; } = null!;
        public int? ParentId { get; set; }
        public Guid Guid { get; set; }
        public DateTime LastModified { get; set; }
        public string? CategoryImagePath { get; set; }
        public string? ObjectPath { get; set; }
        public int? ObjectLevel { get; set; }
        public int? CategoryChildCount { get; set; }
        public int? CategoryTemplateChildCount { get; set; }
        public int? CompleteChildCount { get; set; }
        public string ObjectType { get; set; } = null!;
        public bool? Parameter { get; set; }
        public int? PageTemplateForAllPages { get; set; }
        public string? PageTemplateType { get; set; }
        public int? PageTemplateIsReusable { get; set; }
        public string? PageTemplateIconClass { get; set; }
    }
}
