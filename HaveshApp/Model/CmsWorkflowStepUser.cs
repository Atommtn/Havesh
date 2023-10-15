using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsWorkflowStepUser
    {
        public int WorkflowStepUserId { get; set; }
        public int StepId { get; set; }
        public int UserId { get; set; }
        public Guid? StepSourcePointGuid { get; set; }

        public virtual CmsWorkflowStep Step { get; set; } = null!;
        public virtual CmsUser User { get; set; } = null!;
    }
}
