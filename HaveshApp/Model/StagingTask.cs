using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class StagingTask
    {
        public StagingTask()
        {
            StagingSynchronizations = new HashSet<StagingSynchronization>();
            StagingTaskGroupTasks = new HashSet<StagingTaskGroupTask>();
            StagingTaskUsers = new HashSet<StagingTaskUser>();
        }

        public int TaskId { get; set; }
        public int? TaskSiteId { get; set; }
        public int? TaskDocumentId { get; set; }
        public string? TaskNodeAliasPath { get; set; }
        public string TaskTitle { get; set; } = null!;
        public string TaskData { get; set; } = null!;
        public DateTime TaskTime { get; set; }
        public string TaskType { get; set; } = null!;
        public string? TaskObjectType { get; set; }
        public int? TaskObjectId { get; set; }
        public bool? TaskRunning { get; set; }
        public int? TaskNodeId { get; set; }
        public string? TaskServers { get; set; }

        public virtual CmsSite? TaskSite { get; set; }
        public virtual ICollection<StagingSynchronization> StagingSynchronizations { get; set; }
        public virtual ICollection<StagingTaskGroupTask> StagingTaskGroupTasks { get; set; }
        public virtual ICollection<StagingTaskUser> StagingTaskUsers { get; set; }
    }
}
