using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsConsentArchive
    {
        public int ConsentArchiveId { get; set; }
        public Guid ConsentArchiveGuid { get; set; }
        public DateTime ConsentArchiveLastModified { get; set; }
        public int ConsentArchiveConsentId { get; set; }
        public string ConsentArchiveHash { get; set; } = null!;
        public string ConsentArchiveContent { get; set; } = null!;

        public virtual CmsConsent ConsentArchiveConsent { get; set; } = null!;
    }
}
