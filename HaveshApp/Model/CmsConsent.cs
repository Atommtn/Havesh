using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsConsent
    {
        public CmsConsent()
        {
            CmsConsentAgreements = new HashSet<CmsConsentAgreement>();
            CmsConsentArchives = new HashSet<CmsConsentArchive>();
        }

        public int ConsentId { get; set; }
        public string ConsentDisplayName { get; set; } = null!;
        public string ConsentName { get; set; } = null!;
        public string ConsentContent { get; set; } = null!;
        public Guid ConsentGuid { get; set; }
        public DateTime ConsentLastModified { get; set; }
        public string ConsentHash { get; set; } = null!;

        public virtual ICollection<CmsConsentAgreement> CmsConsentAgreements { get; set; }
        public virtual ICollection<CmsConsentArchive> CmsConsentArchives { get; set; }
    }
}
