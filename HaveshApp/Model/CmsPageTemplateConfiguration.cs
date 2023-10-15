using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsPageTemplateConfiguration
    {
        public int PageTemplateConfigurationId { get; set; }
        public Guid PageTemplateConfigurationGuid { get; set; }
        public int PageTemplateConfigurationSiteId { get; set; }
        public DateTime PageTemplateConfigurationLastModified { get; set; }
        public string PageTemplateConfigurationName { get; set; } = null!;
        public string? PageTemplateConfigurationDescription { get; set; }
        public Guid? PageTemplateConfigurationThumbnailGuid { get; set; }
        public string PageTemplateConfigurationTemplate { get; set; } = null!;
        public string? PageTemplateConfigurationWidgets { get; set; }

        public virtual CmsSite PageTemplateConfigurationSite { get; set; } = null!;
    }
}
