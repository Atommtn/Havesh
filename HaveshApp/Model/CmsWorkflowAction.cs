using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsWorkflowAction
    {
        public CmsWorkflowAction()
        {
            CmsWorkflowSteps = new HashSet<CmsWorkflowStep>();
        }

        public int ActionId { get; set; }
        public string ActionDisplayName { get; set; } = null!;
        public string ActionName { get; set; } = null!;
        public string? ActionParameters { get; set; }
        public string? ActionDescription { get; set; }
        public string ActionAssemblyName { get; set; } = null!;
        public string ActionClass { get; set; } = null!;
        public int? ActionResourceId { get; set; }
        public Guid? ActionThumbnailGuid { get; set; }
        public Guid ActionGuid { get; set; }
        public DateTime ActionLastModified { get; set; }
        public bool? ActionEnabled { get; set; }
        public string? ActionAllowedObjects { get; set; }
        public Guid? ActionIconGuid { get; set; }
        public int? ActionWorkflowType { get; set; }
        public string? ActionIconClass { get; set; }
        public string? ActionThumbnailClass { get; set; }

        public virtual CmsResource? ActionResource { get; set; }
        public virtual ICollection<CmsWorkflowStep> CmsWorkflowSteps { get; set; }
    }
}
