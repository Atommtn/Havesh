using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsQuery
    {
        public int QueryId { get; set; }
        public string QueryName { get; set; } = null!;
        public int QueryTypeId { get; set; }
        public string QueryText { get; set; } = null!;
        public bool QueryRequiresTransaction { get; set; }
        public int? ClassId { get; set; }
        public bool QueryIsLocked { get; set; }
        public DateTime QueryLastModified { get; set; }
        public Guid QueryGuid { get; set; }
        public bool? QueryIsCustom { get; set; }
        public string? QueryConnectionString { get; set; }

        public virtual CmsClass? Class { get; set; }
    }
}
