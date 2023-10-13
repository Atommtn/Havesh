using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ContentSimpleArticle
    {
        public int ArticleId { get; set; }
        public string ArticleTitle { get; set; } = null!;
        public string ArticleText { get; set; } = null!;
    }
}
