using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class OmContactRole
    {
        public OmContactRole()
        {
            OmAccountContacts = new HashSet<OmAccountContact>();
        }

        public int ContactRoleId { get; set; }
        public string ContactRoleName { get; set; } = null!;
        public string ContactRoleDisplayName { get; set; } = null!;
        public string? ContactRoleDescription { get; set; }

        public virtual ICollection<OmAccountContact> OmAccountContacts { get; set; }
    }
}
