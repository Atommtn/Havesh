using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CustomtableSampleTable
    {
        public int ItemId { get; set; }
        public int? ItemCreatedBy { get; set; }
        public DateTime? ItemCreatedWhen { get; set; }
        public int? ItemModifiedBy { get; set; }
        public DateTime? ItemModifiedWhen { get; set; }
        public int? ItemOrder { get; set; }
        public string ItemText { get; set; } = null!;
        public Guid ItemGuid { get; set; }
    }
}
