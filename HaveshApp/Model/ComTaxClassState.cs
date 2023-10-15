using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComTaxClassState
    {
        public int TaxClassStateId { get; set; }
        public int TaxClassId { get; set; }
        public int StateId { get; set; }
        public decimal TaxValue { get; set; }

        public virtual CmsState State { get; set; } = null!;
        public virtual ComTaxClass TaxClass { get; set; } = null!;
    }
}
