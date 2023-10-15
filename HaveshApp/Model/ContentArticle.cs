using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ContentArticle
    {
        public int ArticleId { get; set; }
        public string ArticleName { get; set; } = null!;
        public string? ArticleTeaserText { get; set; }
        public Guid? ArticleTeaserImage { get; set; }
        public string? ArticleText { get; set; }
        public string PageLink { get; set; } = null!;
    }
}
