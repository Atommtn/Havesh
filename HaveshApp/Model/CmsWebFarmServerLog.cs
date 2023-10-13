using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsWebFarmServerLog
    {
        public int WebFarmServerLogId { get; set; }
        public DateTime LogTime { get; set; }
        public string LogCode { get; set; } = null!;
        public int ServerId { get; set; }
    }
}
