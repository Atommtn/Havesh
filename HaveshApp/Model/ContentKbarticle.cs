using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ContentKbarticle
    {
        public int KbarticleId { get; set; }
        public string? ArticleIdentifier { get; set; }
        public string ArticleName { get; set; } = null!;
        public string ArticleSummary { get; set; } = null!;
        public string ArticleAppliesTo { get; set; } = null!;
        public string ArticleText { get; set; } = null!;
        public string? ArticleSeeAlso { get; set; }
    }
}
