using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OmAbvariantDatum
    {
        public int AbvariantId { get; set; }
        public string AbvariantDisplayName { get; set; } = null!;
        public Guid AbvariantGuid { get; set; }
        public int AbvariantTestId { get; set; }
        public bool AbvariantIsOriginal { get; set; }

        public virtual OmAbtest AbvariantTest { get; set; } = null!;
    }
}
