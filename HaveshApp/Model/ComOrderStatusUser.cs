using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComOrderStatusUser
    {
        public int OrderStatusUserId { get; set; }
        public int OrderId { get; set; }
        public int? FromStatusId { get; set; }
        public int ToStatusId { get; set; }
        public int? ChangedByUserId { get; set; }
        public DateTime Date { get; set; }
        public string? Note { get; set; }

        public virtual CmsUser? ChangedByUser { get; set; }
        public virtual ComOrderStatus? FromStatus { get; set; }
        public virtual ComOrder Order { get; set; } = null!;
        public virtual ComOrderStatus ToStatus { get; set; } = null!;
    }
}
