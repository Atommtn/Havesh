using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewMembershipMembershipUserJoined
    {
        public string MembershipDisplayName { get; set; } = null!;
        public int MembershipId { get; set; }
        public DateTime? ValidTo { get; set; }
        public int UserId { get; set; }
        public string? FullName { get; set; }
        public string UserName { get; set; } = null!;
        public int? MembershipSiteId { get; set; }
    }
}
