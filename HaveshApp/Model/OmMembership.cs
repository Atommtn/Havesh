using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class OmMembership
    {
        public int MembershipId { get; set; }
        public int RelatedId { get; set; }
        public int MemberType { get; set; }
        public Guid MembershipGuid { get; set; }
        public DateTime MembershipCreated { get; set; }
        public int ContactId { get; set; }

        public virtual OmContact Contact { get; set; } = null!;
    }
}
