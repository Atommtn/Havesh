using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OmAccountStatus
    {
        public OmAccountStatus()
        {
            OmAccounts = new HashSet<OmAccount>();
        }

        public int AccountStatusId { get; set; }
        public string AccountStatusName { get; set; } = null!;
        public string AccountStatusDisplayName { get; set; } = null!;
        public string? AccountStatusDescription { get; set; }

        public virtual ICollection<OmAccount> OmAccounts { get; set; }
    }
}
