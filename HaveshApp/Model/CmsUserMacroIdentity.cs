using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsUserMacroIdentity
    {
        public int UserMacroIdentityId { get; set; }
        public DateTime UserMacroIdentityLastModified { get; set; }
        public int UserMacroIdentityUserId { get; set; }
        public int? UserMacroIdentityMacroIdentityId { get; set; }
        public Guid UserMacroIdentityUserGuid { get; set; }

        public virtual CmsMacroIdentity? UserMacroIdentityMacroIdentity { get; set; }
        public virtual CmsUser UserMacroIdentityUser { get; set; } = null!;
    }
}
