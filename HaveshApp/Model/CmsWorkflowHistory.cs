using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsWorkflowHistory
    {
        public int WorkflowHistoryId { get; set; }
        public int VersionHistoryId { get; set; }
        public int? StepId { get; set; }
        public string StepDisplayName { get; set; } = null!;
        public int? ApprovedByUserId { get; set; }
        public DateTime? ApprovedWhen { get; set; }
        public string? Comment { get; set; }
        public bool WasRejected { get; set; }
        public string? StepName { get; set; }
        public int? TargetStepId { get; set; }
        public string? TargetStepName { get; set; }
        public string? TargetStepDisplayName { get; set; }
        public int? StepType { get; set; }
        public int? TargetStepType { get; set; }
        public string? HistoryObjectType { get; set; }
        public int? HistoryObjectId { get; set; }
        public int? HistoryTransitionType { get; set; }
        public int? HistoryWorkflowId { get; set; }
        public bool? HistoryRejected { get; set; }

        public virtual CmsUser? ApprovedByUser { get; set; }
        public virtual CmsWorkflow? HistoryWorkflow { get; set; }
        public virtual CmsWorkflowStep? Step { get; set; }
        public virtual CmsWorkflowStep? TargetStep { get; set; }
        public virtual CmsVersionHistory VersionHistory { get; set; } = null!;
    }
}
