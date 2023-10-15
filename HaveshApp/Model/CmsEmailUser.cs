using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsEmailUser
    {
        public int EmailId { get; set; }
        public int UserId { get; set; }
        public string? LastSendResult { get; set; }
        public DateTime? LastSendAttempt { get; set; }
        public int? Status { get; set; }

        public virtual CmsEmail Email { get; set; } = null!;
        public virtual CmsUser User { get; set; } = null!;
    }
}
