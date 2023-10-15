using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class StagingSynchronization
    {
        public int SynchronizationId { get; set; }
        public int SynchronizationTaskId { get; set; }
        public int SynchronizationServerId { get; set; }
        public DateTime? SynchronizationLastRun { get; set; }
        public string? SynchronizationErrorMessage { get; set; }

        public virtual StagingServer SynchronizationServer { get; set; } = null!;
        public virtual StagingTask SynchronizationTask { get; set; } = null!;
    }
}
