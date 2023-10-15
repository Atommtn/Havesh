using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OmContact
    {
        public OmContact()
        {
            CmsConsentAgreements = new HashSet<CmsConsentAgreement>();
            OmAccountAccountPrimaryContacts = new HashSet<OmAccount>();
            OmAccountAccountSecondaryContacts = new HashSet<OmAccount>();
            OmAccountContacts = new HashSet<OmAccountContact>();
            OmMemberships = new HashSet<OmMembership>();
            OmScoreContactRules = new HashSet<OmScoreContactRule>();
            OmVisitorToContacts = new HashSet<OmVisitorToContact>();
        }

        public int ContactId { get; set; }
        public string? ContactFirstName { get; set; }
        public string? ContactMiddleName { get; set; }
        public string? ContactLastName { get; set; }
        public string? ContactJobTitle { get; set; }
        public string? ContactAddress1 { get; set; }
        public string? ContactCity { get; set; }
        public string? ContactZip { get; set; }
        public int? ContactStateId { get; set; }
        public int? ContactCountryId { get; set; }
        public string? ContactMobilePhone { get; set; }
        public string? ContactBusinessPhone { get; set; }
        public string? ContactEmail { get; set; }
        public DateTime? ContactBirthday { get; set; }
        public int? ContactGender { get; set; }
        public int? ContactStatusId { get; set; }
        public string? ContactNotes { get; set; }
        public int? ContactOwnerUserId { get; set; }
        public bool? ContactMonitored { get; set; }
        public Guid ContactGuid { get; set; }
        public DateTime ContactLastModified { get; set; }
        public DateTime ContactCreated { get; set; }
        public int? ContactBounces { get; set; }
        public string? ContactCampaign { get; set; }
        public string? ContactSalesForceLeadId { get; set; }
        public bool? ContactSalesForceLeadReplicationDisabled { get; set; }
        public DateTime? ContactSalesForceLeadReplicationDateTime { get; set; }
        public DateTime? ContactSalesForceLeadReplicationSuspensionDateTime { get; set; }
        public string? ContactCompanyName { get; set; }
        public bool? ContactSalesForceLeadReplicationRequired { get; set; }
        public int? ContactPersonaId { get; set; }

        public virtual CmsCountry? ContactCountry { get; set; }
        public virtual CmsUser? ContactOwnerUser { get; set; }
        public virtual CmsState? ContactState { get; set; }
        public virtual OmContactStatus? ContactStatus { get; set; }
        public virtual ICollection<CmsConsentAgreement> CmsConsentAgreements { get; set; }
        public virtual ICollection<OmAccount> OmAccountAccountPrimaryContacts { get; set; }
        public virtual ICollection<OmAccount> OmAccountAccountSecondaryContacts { get; set; }
        public virtual ICollection<OmAccountContact> OmAccountContacts { get; set; }
        public virtual ICollection<OmMembership> OmMemberships { get; set; }
        public virtual ICollection<OmScoreContactRule> OmScoreContactRules { get; set; }
        public virtual ICollection<OmVisitorToContact> OmVisitorToContacts { get; set; }
    }
}
