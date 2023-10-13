using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComCustomerCreditHistory
    {
        public int EventId { get; set; }
        public string EventName { get; set; } = null!;
        public decimal EventCreditChange { get; set; }
        public DateTime EventDate { get; set; }
        public string? EventDescription { get; set; }
        public int EventCustomerId { get; set; }
        public Guid? EventCreditGuid { get; set; }
        public DateTime EventCreditLastModified { get; set; }
        public int? EventSiteId { get; set; }

        public virtual ComCustomer EventCustomer { get; set; } = null!;
        public virtual CmsSite? EventSite { get; set; }
    }
}
