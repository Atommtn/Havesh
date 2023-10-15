using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsOpenIduser
    {
        public int OpenIduserId { get; set; }
        public string OpenId { get; set; } = null!;
        public string? OpenIdproviderUrl { get; set; }
        public int UserId { get; set; }

        public virtual CmsUser User { get; set; } = null!;
    }
}
