using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ContentBlogPost
    {
        public int BlogPostId { get; set; }
        public string BlogPostTitle { get; set; } = null!;
        public DateTime BlogPostDate { get; set; }
        public string? BlogPostSummary { get; set; }
        public string BlogPostBody { get; set; } = null!;
        public Guid? BlogPostTeaser { get; set; }
        public bool? BlogPostAllowComments { get; set; }
        public bool? BlogLogActivity { get; set; }
        public string? FacebookAutoPost { get; set; }
        public string? TwitterAutoPost { get; set; }
        public string? LinkedInAutoPost { get; set; }
    }
}
