using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComCarrier
    {
        public ComCarrier()
        {
            ComShippingOptions = new HashSet<ComShippingOption>();
        }

        public int CarrierId { get; set; }
        public string CarrierDisplayName { get; set; } = null!;
        public string CarrierName { get; set; } = null!;
        public int CarrierSiteId { get; set; }
        public Guid CarrierGuid { get; set; }
        public string CarrierAssemblyName { get; set; } = null!;
        public string CarrierClassName { get; set; } = null!;
        public DateTime CarrierLastModified { get; set; }

        public virtual CmsSite CarrierSite { get; set; } = null!;
        public virtual ICollection<ComShippingOption> ComShippingOptions { get; set; }
    }
}
