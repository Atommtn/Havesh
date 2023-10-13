using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class SmTwitterApplication
    {
        public SmTwitterApplication()
        {
            SmTwitterAccounts = new HashSet<SmTwitterAccount>();
        }

        public int TwitterApplicationId { get; set; }
        public string TwitterApplicationDisplayName { get; set; } = null!;
        public string TwitterApplicationName { get; set; } = null!;
        public DateTime TwitterApplicationLastModified { get; set; }
        public Guid TwitterApplicationGuid { get; set; }
        public int TwitterApplicationSiteId { get; set; }
        public string TwitterApplicationConsumerKey { get; set; } = null!;
        public string TwitterApplicationConsumerSecret { get; set; } = null!;

        public virtual CmsSite TwitterApplicationSite { get; set; } = null!;
        public virtual ICollection<SmTwitterAccount> SmTwitterAccounts { get; set; }
    }
}
