using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsConsentAgreement
    {
        public int ConsentAgreementId { get; set; }
        public Guid ConsentAgreementGuid { get; set; }
        public bool ConsentAgreementRevoked { get; set; }
        public int ConsentAgreementContactId { get; set; }
        public int ConsentAgreementConsentId { get; set; }
        public string? ConsentAgreementConsentHash { get; set; }
        public DateTime ConsentAgreementTime { get; set; }

        public virtual CmsConsent ConsentAgreementConsent { get; set; } = null!;
        public virtual OmContact ConsentAgreementContact { get; set; } = null!;
    }
}
