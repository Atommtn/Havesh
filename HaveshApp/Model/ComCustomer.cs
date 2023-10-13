using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComCustomer
    {
        public ComCustomer()
        {
            ComAddresses = new HashSet<ComAddress>();
            ComCustomerCreditHistories = new HashSet<ComCustomerCreditHistory>();
            ComOrders = new HashSet<ComOrder>();
            ComShoppingCarts = new HashSet<ComShoppingCart>();
        }

        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; } = null!;
        public string CustomerLastName { get; set; } = null!;
        public string? CustomerEmail { get; set; }
        public string? CustomerPhone { get; set; }
        public string? CustomerFax { get; set; }
        public string? CustomerCompany { get; set; }
        public int? CustomerUserId { get; set; }
        public Guid CustomerGuid { get; set; }
        public string? CustomerTaxRegistrationId { get; set; }
        public string? CustomerOrganizationId { get; set; }
        public DateTime CustomerLastModified { get; set; }
        public int? CustomerSiteId { get; set; }
        public DateTime? CustomerCreated { get; set; }

        public virtual CmsSite? CustomerSite { get; set; }
        public virtual CmsUser? CustomerUser { get; set; }
        public virtual ICollection<ComAddress> ComAddresses { get; set; }
        public virtual ICollection<ComCustomerCreditHistory> ComCustomerCreditHistories { get; set; }
        public virtual ICollection<ComOrder> ComOrders { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCarts { get; set; }
    }
}
