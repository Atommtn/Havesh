using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsUielement
    {
        public CmsUielement()
        {
            CmsHelpTopics = new HashSet<CmsHelpTopic>();
            InverseElementParent = new HashSet<CmsUielement>();
            Roles = new HashSet<CmsRole>();
            RolesNavigation = new HashSet<CmsRole>();
        }

        public int ElementId { get; set; }
        public string ElementDisplayName { get; set; } = null!;
        public string ElementName { get; set; } = null!;
        public string? ElementCaption { get; set; }
        public string? ElementTargetUrl { get; set; }
        public int ElementResourceId { get; set; }
        public int? ElementParentId { get; set; }
        public int ElementChildCount { get; set; }
        public int? ElementOrder { get; set; }
        public int ElementLevel { get; set; }
        public string ElementIdpath { get; set; } = null!;
        public string? ElementIconPath { get; set; }
        public bool? ElementIsCustom { get; set; }
        public DateTime ElementLastModified { get; set; }
        public Guid ElementGuid { get; set; }
        public int? ElementSize { get; set; }
        public string? ElementDescription { get; set; }
        public string? ElementFromVersion { get; set; }
        public int? ElementPageTemplateId { get; set; }
        public string? ElementType { get; set; }
        public string? ElementProperties { get; set; }
        public bool? ElementIsMenu { get; set; }
        public string? ElementFeature { get; set; }
        public string? ElementIconClass { get; set; }
        public bool? ElementIsGlobalApplication { get; set; }
        public bool? ElementCheckModuleReadPermission { get; set; }
        public string? ElementAccessCondition { get; set; }
        public string? ElementVisibilityCondition { get; set; }
        public bool ElementRequiresGlobalAdminPriviligeLevel { get; set; }

        public virtual CmsPageTemplate? ElementPageTemplate { get; set; }
        public virtual CmsUielement? ElementParent { get; set; }
        public virtual CmsResource ElementResource { get; set; } = null!;
        public virtual ICollection<CmsHelpTopic> CmsHelpTopics { get; set; }
        public virtual ICollection<CmsUielement> InverseElementParent { get; set; }

        public virtual ICollection<CmsRole> Roles { get; set; }
        public virtual ICollection<CmsRole> RolesNavigation { get; set; }
    }
}
