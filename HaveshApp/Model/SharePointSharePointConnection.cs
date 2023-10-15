using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class SharePointSharePointConnection
    {
        public SharePointSharePointConnection()
        {
            SharePointSharePointLibraries = new HashSet<SharePointSharePointLibrary>();
        }

        public int SharePointConnectionId { get; set; }
        public Guid SharePointConnectionGuid { get; set; }
        public int SharePointConnectionSiteId { get; set; }
        public string SharePointConnectionSiteUrl { get; set; } = null!;
        public string SharePointConnectionAuthMode { get; set; } = null!;
        public string SharePointConnectionDisplayName { get; set; } = null!;
        public string SharePointConnectionName { get; set; } = null!;
        public string SharePointConnectionSharePointVersion { get; set; } = null!;
        public string? SharePointConnectionUserName { get; set; }
        public string? SharePointConnectionPassword { get; set; }
        public string? SharePointConnectionDomain { get; set; }
        public DateTime SharePointConnectionLastModified { get; set; }

        public virtual CmsSite SharePointConnectionSite { get; set; } = null!;
        public virtual ICollection<SharePointSharePointLibrary> SharePointSharePointLibraries { get; set; }
    }
}
