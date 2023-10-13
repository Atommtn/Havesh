using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewIntegrationTaskJoined
    {
        public int? SynchronizationId { get; set; }
        public int? SynchronizationTaskId { get; set; }
        public int? SynchronizationConnectorId { get; set; }
        public DateTime? SynchronizationLastRun { get; set; }
        public string? SynchronizationErrorMessage { get; set; }
        public bool? SynchronizationIsRunning { get; set; }
        public int TaskId { get; set; }
        public int? TaskNodeId { get; set; }
        public int? TaskDocumentId { get; set; }
        public string? TaskNodeAliasPath { get; set; }
        public string TaskTitle { get; set; } = null!;
        public DateTime TaskTime { get; set; }
        public string TaskType { get; set; } = null!;
        public string? TaskObjectType { get; set; }
        public int? TaskObjectId { get; set; }
        public bool TaskIsInbound { get; set; }
        public string? TaskProcessType { get; set; }
        public string TaskData { get; set; } = null!;
        public int? TaskSiteId { get; set; }
        public string? TaskDataType { get; set; }
    }
}
