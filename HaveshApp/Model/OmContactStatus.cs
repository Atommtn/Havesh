using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OmContactStatus
    {
        public OmContactStatus()
        {
            OmContacts = new HashSet<OmContact>();
        }

        public int ContactStatusId { get; set; }
        public string ContactStatusName { get; set; } = null!;
        public string ContactStatusDisplayName { get; set; } = null!;
        public string? ContactStatusDescription { get; set; }

        public virtual ICollection<OmContact> OmContacts { get; set; }
    }
}
