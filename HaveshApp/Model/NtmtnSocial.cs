using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class NtmtnSocial
    {
        public int SocialId { get; set; }
        public string SocialName { get; set; } = null!;
        public string? Class { get; set; }
        public string? SocialLink { get; set; }
    }
}
