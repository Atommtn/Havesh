using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ContentPressRelease
    {
        public int PressReleaseId { get; set; }
        public string PressReleaseTitle { get; set; } = null!;
        public DateTime PressReleaseDate { get; set; }
        public string PressReleaseSummary { get; set; } = null!;
        public string PressReleaseText { get; set; } = null!;
        public string? PressReleaseAbout { get; set; }
        public string? PressReleaseTrademarks { get; set; }
    }
}
