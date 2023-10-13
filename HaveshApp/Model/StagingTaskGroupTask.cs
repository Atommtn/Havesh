using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class StagingTaskGroupTask
    {
        public int TaskGroupTaskId { get; set; }
        public int TaskGroupId { get; set; }
        public int TaskId { get; set; }

        public virtual StagingTask Task { get; set; } = null!;
        public virtual StagingTaskGroup TaskGroup { get; set; } = null!;
    }
}
