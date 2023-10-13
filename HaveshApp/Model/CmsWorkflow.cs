using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsWorkflow
    {
        public CmsWorkflow()
        {
            CmsAutomationHistories = new HashSet<CmsAutomationHistory>();
            CmsAutomationStates = new HashSet<CmsAutomationState>();
            CmsObjectWorkflowTriggers = new HashSet<CmsObjectWorkflowTrigger>();
            CmsVersionHistories = new HashSet<CmsVersionHistory>();
            CmsWorkflowHistories = new HashSet<CmsWorkflowHistory>();
            CmsWorkflowScopes = new HashSet<CmsWorkflowScope>();
            CmsWorkflowSteps = new HashSet<CmsWorkflowStep>();
            CmsWorkflowTransitions = new HashSet<CmsWorkflowTransition>();
            Users = new HashSet<CmsUser>();
        }

        public int WorkflowId { get; set; }
        public string WorkflowDisplayName { get; set; } = null!;
        public string WorkflowName { get; set; } = null!;
        public Guid WorkflowGuid { get; set; }
        public DateTime WorkflowLastModified { get; set; }
        public bool? WorkflowAutoPublishChanges { get; set; }
        public bool? WorkflowUseCheckinCheckout { get; set; }
        public int? WorkflowType { get; set; }
        public bool? WorkflowSendEmails { get; set; }
        public bool? WorkflowSendApproveEmails { get; set; }
        public bool? WorkflowSendRejectEmails { get; set; }
        public bool? WorkflowSendPublishEmails { get; set; }
        public bool? WorkflowSendArchiveEmails { get; set; }
        public string? WorkflowApprovedTemplateName { get; set; }
        public string? WorkflowRejectedTemplateName { get; set; }
        public string? WorkflowPublishedTemplateName { get; set; }
        public string? WorkflowArchivedTemplateName { get; set; }
        public bool? WorkflowSendReadyForApprovalEmails { get; set; }
        public string? WorkflowReadyForApprovalTemplateName { get; set; }
        public string? WorkflowNotificationTemplateName { get; set; }
        public string? WorkflowAllowedObjects { get; set; }
        public int? WorkflowRecurrenceType { get; set; }
        public bool? WorkflowEnabled { get; set; }

        public virtual ICollection<CmsAutomationHistory> CmsAutomationHistories { get; set; }
        public virtual ICollection<CmsAutomationState> CmsAutomationStates { get; set; }
        public virtual ICollection<CmsObjectWorkflowTrigger> CmsObjectWorkflowTriggers { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistories { get; set; }
        public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistories { get; set; }
        public virtual ICollection<CmsWorkflowScope> CmsWorkflowScopes { get; set; }
        public virtual ICollection<CmsWorkflowStep> CmsWorkflowSteps { get; set; }
        public virtual ICollection<CmsWorkflowTransition> CmsWorkflowTransitions { get; set; }

        public virtual ICollection<CmsUser> Users { get; set; }
    }
}
