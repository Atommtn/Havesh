using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComShippingCost
    {
        public int ShippingCostId { get; set; }
        public int ShippingCostShippingOptionId { get; set; }
        public double ShippingCostMinWeight { get; set; }
        public decimal ShippingCostValue { get; set; }
        public Guid ShippingCostGuid { get; set; }
        public DateTime ShippingCostLastModified { get; set; }

        public virtual ComShippingOption ShippingCostShippingOption { get; set; } = null!;
    }
}
