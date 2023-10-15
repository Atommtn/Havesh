using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class PersonasPersonaNode
    {
        public int PersonaId { get; set; }
        public int NodeId { get; set; }

        public virtual CmsTree Node { get; set; } = null!;
    }
}
