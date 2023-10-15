using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class SmLinkedInAccount
    {
        public SmLinkedInAccount()
        {
            SmLinkedInPosts = new HashSet<SmLinkedInPost>();
        }

        public int LinkedInAccountId { get; set; }
        public string LinkedInAccountDisplayName { get; set; } = null!;
        public string LinkedInAccountName { get; set; } = null!;
        public bool? LinkedInAccountIsDefault { get; set; }
        public string LinkedInAccountAccessToken { get; set; } = null!;
        public DateTime LinkedInAccountLastModified { get; set; }
        public Guid LinkedInAccountGuid { get; set; }
        public int LinkedInAccountSiteId { get; set; }
        public string LinkedInAccountProfileId { get; set; } = null!;
        public int LinkedInAccountLinkedInApplicationId { get; set; }
        public string? LinkedInAccountProfileName { get; set; }
        public DateTime? LinkedInAccountAccessTokenExpiration { get; set; }

        public virtual ICollection<SmLinkedInPost> SmLinkedInPosts { get; set; }
    }
}
