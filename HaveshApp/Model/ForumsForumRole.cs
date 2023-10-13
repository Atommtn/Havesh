using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ForumsForumRole
    {
        public int ForumId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual ForumsForum Forum { get; set; } = null!;
        public virtual CmsPermission Permission { get; set; } = null!;
        public virtual CmsRole Role { get; set; } = null!;
    }
}
