using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsUserSite
    {
        public int UserSiteId { get; set; }
        public int UserId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsSite Site { get; set; } = null!;
        public virtual CmsUser User { get; set; } = null!;
    }
}
