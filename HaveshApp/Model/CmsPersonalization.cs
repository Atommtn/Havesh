using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsPersonalization
    {
        public int PersonalizationId { get; set; }
        public Guid PersonalizationGuid { get; set; }
        public DateTime PersonalizationLastModified { get; set; }
        public int? PersonalizationUserId { get; set; }
        public int? PersonalizationDocumentId { get; set; }
        public string? PersonalizationWebParts { get; set; }
        public string? PersonalizationDashboardName { get; set; }
        public int? PersonalizationSiteId { get; set; }

        public virtual CmsDocument? PersonalizationDocument { get; set; }
        public virtual CmsSite? PersonalizationSite { get; set; }
        public virtual CmsUser? PersonalizationUser { get; set; }
    }
}
