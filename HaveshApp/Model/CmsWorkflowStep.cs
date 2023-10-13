using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsWorkflowStep
    {
        public CmsWorkflowStep()
        {
            CmsAutomationHistoryHistorySteps = new HashSet<CmsAutomationHistory>();
            CmsAutomationHistoryHistoryTargetSteps = new HashSet<CmsAutomationHistory>();
            CmsAutomationStates = new HashSet<CmsAutomationState>();
            CmsDocuments = new HashSet<CmsDocument>();
            CmsObjectSettings = new HashSet<CmsObjectSetting>();
            CmsVersionHistories = new HashSet<CmsVersionHistory>();
            CmsWorkflowHistorySteps = new HashSet<CmsWorkflowHistory>();
            CmsWorkflowHistoryTargetSteps = new HashSet<CmsWorkflowHistory>();
            CmsWorkflowStepRoles = new HashSet<CmsWorkflowStepRole>();
            CmsWorkflowStepUsers = new HashSet<CmsWorkflowStepUser>();
            CmsWorkflowTransitionTransitionEndSteps = new HashSet<CmsWorkflowTransition>();
            CmsWorkflowTransitionTransitionStartSteps = new HashSet<CmsWorkflowTransition>();
        }

        public int StepId { get; set; }
        public string StepDisplayName { get; set; } = null!;
        public string? StepName { get; set; }
        public int? StepOrder { get; set; }
        public int StepWorkflowId { get; set; }
        public Guid StepGuid { get; set; }
        public DateTime StepLastModified { get; set; }
        public int? StepType { get; set; }
        public bool? StepAllowReject { get; set; }
        public string? StepDefinition { get; set; }
        public int? StepRolesSecurity { get; set; }
        public int? StepUsersSecurity { get; set; }
        public string? StepApprovedTemplateName { get; set; }
        public string? StepRejectedTemplateName { get; set; }
        public string? StepReadyforApprovalTemplateName { get; set; }
        public bool? StepSendApproveEmails { get; set; }
        public bool? StepSendRejectEmails { get; set; }
        public bool? StepSendReadyForApprovalEmails { get; set; }
        public bool? StepSendEmails { get; set; }
        public bool? StepAllowPublish { get; set; }
        public int? StepActionId { get; set; }
        public string? StepActionParameters { get; set; }
        public int? StepWorkflowType { get; set; }

        public virtual CmsWorkflowAction? StepAction { get; set; }
        public virtual CmsWorkflow StepWorkflow { get; set; } = null!;
        public virtual ICollection<CmsAutomationHistory> CmsAutomationHistoryHistorySteps { get; set; }
        public virtual ICollection<CmsAutomationHistory> CmsAutomationHistoryHistoryTargetSteps { get; set; }
        public virtual ICollection<CmsAutomationState> CmsAutomationStates { get; set; }
        public virtual ICollection<CmsDocument> CmsDocuments { get; set; }
        public virtual ICollection<CmsObjectSetting> CmsObjectSettings { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistories { get; set; }
        public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistorySteps { get; set; }
        public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistoryTargetSteps { get; set; }
        public virtual ICollection<CmsWorkflowStepRole> CmsWorkflowStepRoles { get; set; }
        public virtual ICollection<CmsWorkflowStepUser> CmsWorkflowStepUsers { get; set; }
        public virtual ICollection<CmsWorkflowTransition> CmsWorkflowTransitionTransitionEndSteps { get; set; }
        public virtual ICollection<CmsWorkflowTransition> CmsWorkflowTransitionTransitionStartSteps { get; set; }
    }
}
