using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class StagingServer
    {
        public StagingServer()
        {
            StagingSynchronizations = new HashSet<StagingSynchronization>();
        }

        public int ServerId { get; set; }
        public string ServerName { get; set; } = null!;
        public string ServerDisplayName { get; set; } = null!;
        public int ServerSiteId { get; set; }
        public string ServerUrl { get; set; } = null!;
        public bool? ServerEnabled { get; set; }
        public string ServerAuthentication { get; set; } = null!;
        public string? ServerUsername { get; set; }
        public string? ServerPassword { get; set; }
        public string? ServerX509clientKeyId { get; set; }
        public string? ServerX509serverKeyId { get; set; }
        public Guid ServerGuid { get; set; }
        public DateTime ServerLastModified { get; set; }

        public virtual CmsSite ServerSite { get; set; } = null!;
        public virtual ICollection<StagingSynchronization> StagingSynchronizations { get; set; }
    }
}
