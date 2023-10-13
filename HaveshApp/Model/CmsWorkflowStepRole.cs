using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsWorkflowStepRole
    {
        public int WorkflowStepRoleId { get; set; }
        public int StepId { get; set; }
        public int RoleId { get; set; }
        public Guid? StepSourcePointGuid { get; set; }

        public virtual CmsRole Role { get; set; } = null!;
        public virtual CmsWorkflowStep Step { get; set; } = null!;
    }
}
