using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsSession
    {
        public string SessionIdentificator { get; set; } = null!;
        public int? SessionUserId { get; set; }
        public string? SessionLocation { get; set; }
        public DateTime SessionLastActive { get; set; }
        public DateTime? SessionLastLogon { get; set; }
        public DateTime SessionExpires { get; set; }
        public bool SessionExpired { get; set; }
        public int? SessionSiteId { get; set; }
        public bool SessionUserIsHidden { get; set; }
        public string? SessionFullName { get; set; }
        public string? SessionEmail { get; set; }
        public string? SessionUserName { get; set; }
        public string? SessionNickName { get; set; }
        public DateTime? SessionUserCreated { get; set; }
        public int? SessionContactId { get; set; }
        public int SessionId { get; set; }

        public virtual CmsSite? SessionSite { get; set; }
        public virtual CmsUser? SessionUser { get; set; }
    }
}
