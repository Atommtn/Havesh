using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class SmFacebookAccount
    {
        public SmFacebookAccount()
        {
            SmFacebookPosts = new HashSet<SmFacebookPost>();
        }

        public int FacebookAccountId { get; set; }
        public Guid FacebookAccountGuid { get; set; }
        public DateTime FacebookAccountLastModified { get; set; }
        public int FacebookAccountSiteId { get; set; }
        public string FacebookAccountName { get; set; } = null!;
        public string FacebookAccountDisplayName { get; set; } = null!;
        public string FacebookAccountPageId { get; set; } = null!;
        public string FacebookAccountPageAccessToken { get; set; } = null!;
        public int FacebookAccountFacebookApplicationId { get; set; }
        public DateTime? FacebookAccountPageAccessTokenExpiration { get; set; }
        public bool? FacebookAccountIsDefault { get; set; }

        public virtual SmFacebookApplication FacebookAccountFacebookApplication { get; set; } = null!;
        public virtual CmsSite FacebookAccountSite { get; set; } = null!;
        public virtual ICollection<SmFacebookPost> SmFacebookPosts { get; set; }
    }
}
