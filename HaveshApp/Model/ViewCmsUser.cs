using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewCmsUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string UserPassword { get; set; } = null!;
        public string? PreferredCultureCode { get; set; }
        public string? PreferredUicultureCode { get; set; }
        public bool UserEnabled { get; set; }
        public bool? UserIsExternal { get; set; }
        public string? UserPasswordFormat { get; set; }
        public DateTime? UserCreated { get; set; }
        public DateTime? LastLogon { get; set; }
        public string? UserStartingAliasPath { get; set; }
        public Guid UserGuid { get; set; }
        public DateTime UserLastModified { get; set; }
        public string? UserLastLogonInfo { get; set; }
        public bool? UserIsHidden { get; set; }
        public string? UserVisibility { get; set; }
        public bool? UserIsDomain { get; set; }
        public bool? UserHasAllowedCultures { get; set; }
        public bool? UserMfrequired { get; set; }
        public int UserPrivilegeLevel { get; set; }
        public string? UserSecurityStamp { get; set; }
        public byte[]? UserMfsecret { get; set; }
        public long? UserMftimestep { get; set; }
        public int? UserSettingsId { get; set; }
        public string? UserNickName { get; set; }
        public string? UserPicture { get; set; }
        public string? UserSignature { get; set; }
        public string? UserUrlreferrer { get; set; }
        public string? UserCampaign { get; set; }
        public string? UserCustomData { get; set; }
        public string? UserRegistrationInfo { get; set; }
        public string? UserPreferences { get; set; }
        public DateTime? UserActivationDate { get; set; }
        public int? UserActivatedByUserId { get; set; }
        public int? UserTimeZoneId { get; set; }
        public int? UserAvatarId { get; set; }
        public int? UserBadgeId { get; set; }
        public int? UserActivityPoints { get; set; }
        public int? UserForumPosts { get; set; }
        public int? UserBlogComments { get; set; }
        public int? UserGender { get; set; }
        public DateTime? UserDateOfBirth { get; set; }
        public int? UserMessageBoardPosts { get; set; }
        public Guid? UserSettingsUserGuid { get; set; }
        public int? UserSettingsUserId { get; set; }
        public string? WindowsLiveId { get; set; }
        public int? UserBlogPosts { get; set; }
        public bool? UserWaitingForApproval { get; set; }
        public string? UserDialogsConfiguration { get; set; }
        public string? UserDescription { get; set; }
        public string? UserUsedWebParts { get; set; }
        public string? UserUsedWidgets { get; set; }
        public string? UserFacebookId { get; set; }
        public Guid? UserAuthenticationGuid { get; set; }
        public string? UserSkype { get; set; }
        public string? UserIm { get; set; }
        public string? UserPhone { get; set; }
        public string? UserPosition { get; set; }
        public string? UserLinkedInId { get; set; }
        public bool? UserLogActivities { get; set; }
        public string? UserPasswordRequestHash { get; set; }
        public int? UserInvalidLogOnAttempts { get; set; }
        public string? UserInvalidLogOnAttemptsHash { get; set; }
        public string? UserAvatarType { get; set; }
        public int? UserAccountLockReason { get; set; }
        public DateTime? UserPasswordLastChanged { get; set; }
        public bool? UserShowIntroductionTile { get; set; }
        public string? UserDashboardApplications { get; set; }
        public string? UserDismissedSmartTips { get; set; }
        public int? AvatarId { get; set; }
        public string? AvatarFileName { get; set; }
        public Guid? AvatarGuid { get; set; }
    }
}
