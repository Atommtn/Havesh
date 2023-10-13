using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsWidgetRole
    {
        public int WidgetId { get; set; }
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public virtual CmsPermission Permission { get; set; } = null!;
        public virtual CmsRole Role { get; set; } = null!;
        public virtual CmsWidget Widget { get; set; } = null!;
    }
}
