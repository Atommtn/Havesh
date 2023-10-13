using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class SmTwitterAccount
    {
        public SmTwitterAccount()
        {
            SmTwitterPosts = new HashSet<SmTwitterPost>();
        }

        public int TwitterAccountId { get; set; }
        public string TwitterAccountDisplayName { get; set; } = null!;
        public string TwitterAccountName { get; set; } = null!;
        public DateTime TwitterAccountLastModified { get; set; }
        public Guid TwitterAccountGuid { get; set; }
        public int TwitterAccountSiteId { get; set; }
        public string TwitterAccountAccessToken { get; set; } = null!;
        public string TwitterAccountAccessTokenSecret { get; set; } = null!;
        public int TwitterAccountTwitterApplicationId { get; set; }
        public int? TwitterAccountFollowers { get; set; }
        public int? TwitterAccountMentions { get; set; }
        public string? TwitterAccountMentionsRange { get; set; }
        public string? TwitterAccountUserId { get; set; }
        public bool? TwitterAccountIsDefault { get; set; }

        public virtual CmsSite TwitterAccountSite { get; set; } = null!;
        public virtual SmTwitterApplication TwitterAccountTwitterApplication { get; set; } = null!;
        public virtual ICollection<SmTwitterPost> SmTwitterPosts { get; set; }
    }
}
