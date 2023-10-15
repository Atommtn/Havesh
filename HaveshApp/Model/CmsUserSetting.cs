using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsUserSetting
    {
        public int UserSettingsId { get; set; }
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
        public Guid UserSettingsUserGuid { get; set; }
        public int UserSettingsUserId { get; set; }
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

        public virtual CmsUser? UserActivatedByUser { get; set; }
        public virtual CmsAvatar? UserAvatar { get; set; }
        public virtual CmsBadge? UserBadge { get; set; }
        public virtual CmsUser UserSettingsUser { get; set; } = null!;
        public virtual CmsUser UserSettingsUserGu { get; set; } = null!;
        public virtual CmsTimeZone? UserTimeZone { get; set; }
    }
}
