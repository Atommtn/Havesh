using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsUserCulture
    {
        public int UserId { get; set; }
        public int CultureId { get; set; }
        public int SiteId { get; set; }

        public virtual CmsCulture Culture { get; set; } = null!;
        public virtual CmsSite Site { get; set; } = null!;
        public virtual CmsUser User { get; set; } = null!;
    }
}
