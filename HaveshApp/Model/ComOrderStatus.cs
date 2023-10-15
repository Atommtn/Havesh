using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ComOrderStatus
    {
        public ComOrderStatus()
        {
            ComOrderStatusUserFromStatuses = new HashSet<ComOrderStatusUser>();
            ComOrderStatusUserToStatuses = new HashSet<ComOrderStatusUser>();
            ComOrders = new HashSet<ComOrder>();
            ComPaymentOptionPaymentOptionAuthorizedOrderStatuses = new HashSet<ComPaymentOption>();
            ComPaymentOptionPaymentOptionFailedOrderStatuses = new HashSet<ComPaymentOption>();
            ComPaymentOptionPaymentOptionSucceededOrderStatuses = new HashSet<ComPaymentOption>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; } = null!;
        public string StatusDisplayName { get; set; } = null!;
        public int? StatusOrder { get; set; }
        public bool? StatusEnabled { get; set; }
        public string? StatusColor { get; set; }
        public Guid StatusGuid { get; set; }
        public DateTime StatusLastModified { get; set; }
        public bool? StatusSendNotification { get; set; }
        public int? StatusSiteId { get; set; }
        public bool? StatusOrderIsPaid { get; set; }

        public virtual CmsSite? StatusSite { get; set; }
        public virtual ICollection<ComOrderStatusUser> ComOrderStatusUserFromStatuses { get; set; }
        public virtual ICollection<ComOrderStatusUser> ComOrderStatusUserToStatuses { get; set; }
        public virtual ICollection<ComOrder> ComOrders { get; set; }
        public virtual ICollection<ComPaymentOption> ComPaymentOptionPaymentOptionAuthorizedOrderStatuses { get; set; }
        public virtual ICollection<ComPaymentOption> ComPaymentOptionPaymentOptionFailedOrderStatuses { get; set; }
        public virtual ICollection<ComPaymentOption> ComPaymentOptionPaymentOptionSucceededOrderStatuses { get; set; }
    }
}
