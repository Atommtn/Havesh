using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsMacroIdentity
    {
        public CmsMacroIdentity()
        {
            CmsUserMacroIdentities = new HashSet<CmsUserMacroIdentity>();
        }

        public int MacroIdentityId { get; set; }
        public Guid MacroIdentityGuid { get; set; }
        public DateTime MacroIdentityLastModified { get; set; }
        public string MacroIdentityName { get; set; } = null!;
        public int? MacroIdentityEffectiveUserId { get; set; }

        public virtual CmsUser? MacroIdentityEffectiveUser { get; set; }
        public virtual ICollection<CmsUserMacroIdentity> CmsUserMacroIdentities { get; set; }
    }
}
