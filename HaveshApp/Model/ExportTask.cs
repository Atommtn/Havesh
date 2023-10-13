using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ExportTask
    {
        public int TaskId { get; set; }
        public int? TaskSiteId { get; set; }
        public string TaskTitle { get; set; } = null!;
        public string TaskData { get; set; } = null!;
        public DateTime TaskTime { get; set; }
        public string TaskType { get; set; } = null!;
        public string? TaskObjectType { get; set; }
        public int? TaskObjectId { get; set; }

        public virtual CmsSite? TaskSite { get; set; }
    }
}
