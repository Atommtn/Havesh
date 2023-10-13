using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ContentNews
    {
        public int NewsId { get; set; }
        public string NewsTitle { get; set; } = null!;
        public DateTime NewsReleaseDate { get; set; }
        public string NewsSummary { get; set; } = null!;
        public string? NewsText { get; set; }
        public Guid? NewsTeaser { get; set; }
    }
}
