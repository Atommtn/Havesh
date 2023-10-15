using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OnlineTeacherLink
    {
        public int ItemId { get; set; }
        public int? ItemCreatedBy { get; set; }
        public DateTime? ItemCreatedWhen { get; set; }
        public int? ItemModifiedBy { get; set; }
        public DateTime? ItemModifiedWhen { get; set; }
        public int? ItemOrder { get; set; }
        public Guid ItemGuid { get; set; }
        public string Name { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string DocName { get; set; } = null!;
        public int SessionNo { get; set; }
        public string Book { get; set; } = null!;
    }
}
