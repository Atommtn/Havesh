using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class SmFacebookApplication
    {
        public SmFacebookApplication()
        {
            SmFacebookAccounts = new HashSet<SmFacebookAccount>();
        }

        public int FacebookApplicationId { get; set; }
        public string FacebookApplicationConsumerKey { get; set; } = null!;
        public string FacebookApplicationConsumerSecret { get; set; } = null!;
        public string FacebookApplicationName { get; set; } = null!;
        public string FacebookApplicationDisplayName { get; set; } = null!;
        public Guid FacebookApplicationGuid { get; set; }
        public DateTime FacebookApplicationLastModified { get; set; }
        public int FacebookApplicationSiteId { get; set; }

        public virtual CmsSite FacebookApplicationSite { get; set; } = null!;
        public virtual ICollection<SmFacebookAccount> SmFacebookAccounts { get; set; }
    }
}
