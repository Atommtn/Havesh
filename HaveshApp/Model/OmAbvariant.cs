using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class OmAbvariant
    {
        public int AbvariantId { get; set; }
        public string AbvariantDisplayName { get; set; } = null!;
        public string AbvariantName { get; set; } = null!;
        public int AbvariantTestId { get; set; }
        public string AbvariantPath { get; set; } = null!;
        public Guid AbvariantGuid { get; set; }
        public DateTime AbvariantLastModified { get; set; }
        public int AbvariantSiteId { get; set; }

        public virtual CmsSite AbvariantSite { get; set; } = null!;
        public virtual OmAbtest AbvariantTest { get; set; } = null!;
    }
}
