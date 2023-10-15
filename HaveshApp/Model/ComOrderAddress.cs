using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComOrderAddress
    {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; } = null!;
        public string? AddressLine2 { get; set; }
        public string AddressCity { get; set; } = null!;
        public string AddressZip { get; set; } = null!;
        public string? AddressPhone { get; set; }
        public int AddressCountryId { get; set; }
        public int? AddressStateId { get; set; }
        public string AddressPersonalName { get; set; } = null!;
        public Guid? AddressGuid { get; set; }
        public DateTime AddressLastModified { get; set; }
        public int AddressOrderId { get; set; }
        public int AddressType { get; set; }

        public virtual CmsCountry AddressCountry { get; set; } = null!;
        public virtual ComOrder AddressOrder { get; set; } = null!;
        public virtual CmsState? AddressState { get; set; }
    }
}
