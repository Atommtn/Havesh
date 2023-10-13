using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ForumsUserFavorite
    {
        public int FavoriteId { get; set; }
        public int UserId { get; set; }
        public int? PostId { get; set; }
        public int? ForumId { get; set; }
        public string? FavoriteName { get; set; }
        public int SiteId { get; set; }
        public Guid FavoriteGuid { get; set; }
        public DateTime FavoriteLastModified { get; set; }

        public virtual ForumsForum? Forum { get; set; }
        public virtual ForumsForumPost? Post { get; set; }
        public virtual CmsSite Site { get; set; } = null!;
        public virtual CmsUser User { get; set; } = null!;
    }
}
