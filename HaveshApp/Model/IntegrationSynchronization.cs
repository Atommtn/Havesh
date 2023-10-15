using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class IntegrationSynchronization
    {
        public IntegrationSynchronization()
        {
            IntegrationSyncLogs = new HashSet<IntegrationSyncLog>();
        }

        public int SynchronizationId { get; set; }
        public int SynchronizationTaskId { get; set; }
        public int SynchronizationConnectorId { get; set; }
        public DateTime SynchronizationLastRun { get; set; }
        public string? SynchronizationErrorMessage { get; set; }
        public bool? SynchronizationIsRunning { get; set; }

        public virtual IntegrationConnector SynchronizationConnector { get; set; } = null!;
        public virtual IntegrationTask SynchronizationTask { get; set; } = null!;
        public virtual ICollection<IntegrationSyncLog> IntegrationSyncLogs { get; set; }
    }
}
