using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsAlternativeUrl
    {
        public int AlternativeUrlId { get; set; }
        public Guid AlternativeUrlGuid { get; set; }
        public int AlternativeUrlDocumentId { get; set; }
        public int AlternativeUrlSiteId { get; set; }
        public string AlternativeUrlUrl { get; set; } = null!;
        public DateTime AlternativeUrlLastModified { get; set; }

        public virtual CmsDocument AlternativeUrlDocument { get; set; } = null!;
        public virtual CmsSite AlternativeUrlSite { get; set; } = null!;
    }
}
