using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewCmsObjectVersionHistoryUserJoined
    {
        public int VersionId { get; set; }
        public int? VersionObjectId { get; set; }
        public string VersionObjectType { get; set; } = null!;
        public int? VersionObjectSiteId { get; set; }
        public string VersionObjectDisplayName { get; set; } = null!;
        public string VersionXml { get; set; } = null!;
        public string? VersionBinaryDataXml { get; set; }
        public int? VersionModifiedByUserId { get; set; }
        public DateTime VersionModifiedWhen { get; set; }
        public int? VersionDeletedByUserId { get; set; }
        public DateTime? VersionDeletedWhen { get; set; }
        public string VersionNumber { get; set; } = null!;
        public string? VersionSiteBindingIds { get; set; }
        public string? VersionComment { get; set; }
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? UserPassword { get; set; }
        public string? PreferredCultureCode { get; set; }
        public string? PreferredUicultureCode { get; set; }
        public bool? UserEnabled { get; set; }
        public bool? UserIsExternal { get; set; }
        public string? UserPasswordFormat { get; set; }
        public DateTime? UserCreated { get; set; }
        public DateTime? LastLogon { get; set; }
        public string? UserStartingAliasPath { get; set; }
        public Guid? UserGuid { get; set; }
        public DateTime? UserLastModified { get; set; }
        public string? UserLastLogonInfo { get; set; }
        public bool? UserIsHidden { get; set; }
        public string? UserVisibility { get; set; }
        public bool? UserIsDomain { get; set; }
        public bool? UserHasAllowedCultures { get; set; }
        public bool? UserMfrequired { get; set; }
        public int? UserPrivilegeLevel { get; set; }
        public string? UserSecurityStamp { get; set; }
        public byte[]? UserMfsecret { get; set; }
        public long? UserMftimestep { get; set; }
    }
}
