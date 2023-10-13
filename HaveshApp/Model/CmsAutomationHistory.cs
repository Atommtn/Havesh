using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsAutomationHistory
    {
        public int HistoryId { get; set; }
        public int? HistoryStepId { get; set; }
        public string? HistoryStepName { get; set; }
        public string HistoryStepDisplayName { get; set; } = null!;
        public int? HistoryStepType { get; set; }
        public int? HistoryTargetStepId { get; set; }
        public string? HistoryTargetStepName { get; set; }
        public string? HistoryTargetStepDisplayName { get; set; }
        public int? HistoryTargetStepType { get; set; }
        public int? HistoryApprovedByUserId { get; set; }
        public DateTime? HistoryApprovedWhen { get; set; }
        public string? HistoryComment { get; set; }
        public int? HistoryTransitionType { get; set; }
        public int HistoryWorkflowId { get; set; }
        public bool? HistoryRejected { get; set; }
        public bool HistoryWasRejected { get; set; }
        public int HistoryStateId { get; set; }

        public virtual CmsUser? HistoryApprovedByUser { get; set; }
        public virtual CmsAutomationState HistoryState { get; set; } = null!;
        public virtual CmsWorkflowStep? HistoryStep { get; set; }
        public virtual CmsWorkflowStep? HistoryTargetStep { get; set; }
        public virtual CmsWorkflow HistoryWorkflow { get; set; } = null!;
    }
}
