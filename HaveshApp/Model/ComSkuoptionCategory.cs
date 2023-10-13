using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComSkuoptionCategory
    {
        public int Skuid { get; set; }
        public int CategoryId { get; set; }
        public bool? AllowAllOptions { get; set; }
        public int SkucategoryId { get; set; }
        public int? SkucategoryOrder { get; set; }

        public virtual ComOptionCategory Category { get; set; } = null!;
        public virtual ComSku Sku { get; set; } = null!;
    }
}
