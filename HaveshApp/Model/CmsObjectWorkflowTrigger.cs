using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsObjectWorkflowTrigger
    {
        public int TriggerId { get; set; }
        public Guid TriggerGuid { get; set; }
        public DateTime TriggerLastModified { get; set; }
        public int TriggerType { get; set; }
        public string? TriggerMacroCondition { get; set; }
        public int TriggerWorkflowId { get; set; }
        public string TriggerDisplayName { get; set; } = null!;
        public string TriggerObjectType { get; set; } = null!;
        public string? TriggerParameters { get; set; }
        public string? TriggerTargetObjectType { get; set; }
        public int? TriggerTargetObjectId { get; set; }

        public virtual CmsWorkflow TriggerWorkflow { get; set; } = null!;
    }
}
