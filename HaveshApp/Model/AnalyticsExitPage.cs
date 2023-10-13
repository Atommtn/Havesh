using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class AnalyticsExitPage
    {
        public string SessionIdentificator { get; set; } = null!;
        public int ExitPageNodeId { get; set; }
        public DateTime ExitPageLastModified { get; set; }
        public int ExitPageSiteId { get; set; }
        public string? ExitPageCulture { get; set; }
    }
}
