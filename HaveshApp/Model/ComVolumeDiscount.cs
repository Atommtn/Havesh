using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComVolumeDiscount
    {
        public int VolumeDiscountId { get; set; }
        public int VolumeDiscountSkuid { get; set; }
        public int VolumeDiscountMinCount { get; set; }
        public decimal VolumeDiscountValue { get; set; }
        public bool VolumeDiscountIsFlatValue { get; set; }
        public Guid VolumeDiscountGuid { get; set; }
        public DateTime VolumeDiscountLastModified { get; set; }

        public virtual ComSku VolumeDiscountSku { get; set; } = null!;
    }
}
