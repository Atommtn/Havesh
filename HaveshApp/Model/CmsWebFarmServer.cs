using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsWebFarmServer
    {
        public CmsWebFarmServer()
        {
            CmsWebFarmServerTasks = new HashSet<CmsWebFarmServerTask>();
        }

        public int ServerId { get; set; }
        public string ServerDisplayName { get; set; } = null!;
        public string ServerName { get; set; } = null!;
        public Guid? ServerGuid { get; set; }
        public DateTime ServerLastModified { get; set; }
        public bool ServerEnabled { get; set; }
        public bool IsExternalWebAppServer { get; set; }

        public virtual ICollection<CmsWebFarmServerTask> CmsWebFarmServerTasks { get; set; }
    }
}
