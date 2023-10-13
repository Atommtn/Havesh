using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class SmLinkedInApplication
    {
        public int LinkedInApplicationId { get; set; }
        public string LinkedInApplicationDisplayName { get; set; } = null!;
        public string LinkedInApplicationName { get; set; } = null!;
        public string LinkedInApplicationConsumerSecret { get; set; } = null!;
        public string LinkedInApplicationConsumerKey { get; set; } = null!;
        public DateTime LinkedInApplicationLastModified { get; set; }
        public Guid LinkedInApplicationGuid { get; set; }
        public int LinkedInApplicationSiteId { get; set; }

        public virtual CmsSite LinkedInApplicationSite { get; set; } = null!;
    }
}
