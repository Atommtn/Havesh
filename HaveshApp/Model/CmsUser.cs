using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsUser
    {
        public CmsUser()
        {
            BlogCommentCommentApprovedByUsers = new HashSet<BlogComment>();
            BlogCommentCommentUsers = new HashSet<BlogComment>();
            BlogPostSubscriptions = new HashSet<BlogPostSubscription>();
            BoardBoards = new HashSet<BoardBoard>();
            BoardMessageMessageApprovedByUsers = new HashSet<BoardMessage>();
            BoardMessageMessageUsers = new HashSet<BoardMessage>();
            BoardSubscriptions = new HashSet<BoardSubscription>();
            ChatInitiatedChatRequests = new HashSet<ChatInitiatedChatRequest>();
            ChatUsers = new HashSet<ChatUser>();
            CmsAbuseReports = new HashSet<CmsAbuseReport>();
            CmsAclitemLastModifiedByUsers = new HashSet<CmsAclitem>();
            CmsAclitemUsers = new HashSet<CmsAclitem>();
            CmsAutomationHistories = new HashSet<CmsAutomationHistory>();
            CmsAutomationStates = new HashSet<CmsAutomationState>();
            CmsCategories = new HashSet<CmsCategory>();
            CmsDocumentDocumentCheckedOutByUsers = new HashSet<CmsDocument>();
            CmsDocumentDocumentCreatedByUsers = new HashSet<CmsDocument>();
            CmsDocumentDocumentModifiedByUsers = new HashSet<CmsDocument>();
            CmsEmailUsers = new HashSet<CmsEmailUser>();
            CmsExternalLogins = new HashSet<CmsExternalLogin>();
            CmsMacroIdentities = new HashSet<CmsMacroIdentity>();
            CmsMembershipUsers = new HashSet<CmsMembershipUser>();
            CmsObjectSettings = new HashSet<CmsObjectSetting>();
            CmsObjectVersionHistoryVersionDeletedByUsers = new HashSet<CmsObjectVersionHistory>();
            CmsObjectVersionHistoryVersionModifiedByUsers = new HashSet<CmsObjectVersionHistory>();
            CmsOpenIdusers = new HashSet<CmsOpenIduser>();
            CmsPersonalizations = new HashSet<CmsPersonalization>();
            CmsScheduledTasks = new HashSet<CmsScheduledTask>();
            CmsSessions = new HashSet<CmsSession>();
            CmsTranslationSubmissions = new HashSet<CmsTranslationSubmission>();
            CmsTrees = new HashSet<CmsTree>();
            CmsUserCultures = new HashSet<CmsUserCulture>();
            CmsUserRoles = new HashSet<CmsUserRole>();
            CmsUserSettingUserActivatedByUsers = new HashSet<CmsUserSetting>();
            CmsUserSettingUserSettingsUserGus = new HashSet<CmsUserSetting>();
            CmsUserSites = new HashSet<CmsUserSite>();
            CmsVersionHistoryModifiedByUsers = new HashSet<CmsVersionHistory>();
            CmsVersionHistoryVersionDeletedByUsers = new HashSet<CmsVersionHistory>();
            CmsWorkflowHistories = new HashSet<CmsWorkflowHistory>();
            CmsWorkflowStepUsers = new HashSet<CmsWorkflowStepUser>();
            ComCustomers = new HashSet<ComCustomer>();
            ComOrderStatusUsers = new HashSet<ComOrderStatusUser>();
            ComOrders = new HashSet<ComOrder>();
            ComShoppingCarts = new HashSet<ComShoppingCart>();
            ComWishlists = new HashSet<ComWishlist>();
            CommunityGroupGroupApprovedByUsers = new HashSet<CommunityGroup>();
            CommunityGroupGroupCreatedByUsers = new HashSet<CommunityGroup>();
            CommunityGroupMemberMemberApprovedByUsers = new HashSet<CommunityGroupMember>();
            CommunityGroupMemberMemberInvitedByUsers = new HashSet<CommunityGroupMember>();
            CommunityGroupMemberMemberUsers = new HashSet<CommunityGroupMember>();
            CommunityInvitationInvitedByUsers = new HashSet<CommunityInvitation>();
            CommunityInvitationInvitedUsers = new HashSet<CommunityInvitation>();
            ExportHistories = new HashSet<ExportHistory>();
            ForumsForumPostPostApprovedByUsers = new HashSet<ForumsForumPost>();
            ForumsForumPostPostUsers = new HashSet<ForumsForumPost>();
            ForumsForumSubscriptions = new HashSet<ForumsForumSubscription>();
            ForumsUserFavorites = new HashSet<ForumsUserFavorite>();
            MediaFileFileCreatedByUsers = new HashSet<MediaFile>();
            MediaFileFileModifiedByUsers = new HashSet<MediaFile>();
            NotificationSubscriptions = new HashSet<NotificationSubscription>();
            OmAccounts = new HashSet<OmAccount>();
            OmContacts = new HashSet<OmContact>();
            ReportingReportSubscriptions = new HashSet<ReportingReportSubscription>();
            ReportingSavedReports = new HashSet<ReportingSavedReport>();
            StagingTaskUsers = new HashSet<StagingTaskUser>();
            Boards = new HashSet<BoardBoard>();
            Forums = new HashSet<ForumsForum>();
            Workflows = new HashSet<CmsWorkflow>();
        }

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

        public virtual CmsUserMacroIdentity? CmsUserMacroIdentity { get; set; }
        public virtual CmsUserSetting? CmsUserSettingUserSettingsUser { get; set; }
        public virtual StagingTaskGroupUser? StagingTaskGroupUser { get; set; }
        public virtual ICollection<BlogComment> BlogCommentCommentApprovedByUsers { get; set; }
        public virtual ICollection<BlogComment> BlogCommentCommentUsers { get; set; }
        public virtual ICollection<BlogPostSubscription> BlogPostSubscriptions { get; set; }
        public virtual ICollection<BoardBoard> BoardBoards { get; set; }
        public virtual ICollection<BoardMessage> BoardMessageMessageApprovedByUsers { get; set; }
        public virtual ICollection<BoardMessage> BoardMessageMessageUsers { get; set; }
        public virtual ICollection<BoardSubscription> BoardSubscriptions { get; set; }
        public virtual ICollection<ChatInitiatedChatRequest> ChatInitiatedChatRequests { get; set; }
        public virtual ICollection<ChatUser> ChatUsers { get; set; }
        public virtual ICollection<CmsAbuseReport> CmsAbuseReports { get; set; }
        public virtual ICollection<CmsAclitem> CmsAclitemLastModifiedByUsers { get; set; }
        public virtual ICollection<CmsAclitem> CmsAclitemUsers { get; set; }
        public virtual ICollection<CmsAutomationHistory> CmsAutomationHistories { get; set; }
        public virtual ICollection<CmsAutomationState> CmsAutomationStates { get; set; }
        public virtual ICollection<CmsCategory> CmsCategories { get; set; }
        public virtual ICollection<CmsDocument> CmsDocumentDocumentCheckedOutByUsers { get; set; }
        public virtual ICollection<CmsDocument> CmsDocumentDocumentCreatedByUsers { get; set; }
        public virtual ICollection<CmsDocument> CmsDocumentDocumentModifiedByUsers { get; set; }
        public virtual ICollection<CmsEmailUser> CmsEmailUsers { get; set; }
        public virtual ICollection<CmsExternalLogin> CmsExternalLogins { get; set; }
        public virtual ICollection<CmsMacroIdentity> CmsMacroIdentities { get; set; }
        public virtual ICollection<CmsMembershipUser> CmsMembershipUsers { get; set; }
        public virtual ICollection<CmsObjectSetting> CmsObjectSettings { get; set; }
        public virtual ICollection<CmsObjectVersionHistory> CmsObjectVersionHistoryVersionDeletedByUsers { get; set; }
        public virtual ICollection<CmsObjectVersionHistory> CmsObjectVersionHistoryVersionModifiedByUsers { get; set; }
        public virtual ICollection<CmsOpenIduser> CmsOpenIdusers { get; set; }
        public virtual ICollection<CmsPersonalization> CmsPersonalizations { get; set; }
        public virtual ICollection<CmsScheduledTask> CmsScheduledTasks { get; set; }
        public virtual ICollection<CmsSession> CmsSessions { get; set; }
        public virtual ICollection<CmsTranslationSubmission> CmsTranslationSubmissions { get; set; }
        public virtual ICollection<CmsTree> CmsTrees { get; set; }
        public virtual ICollection<CmsUserCulture> CmsUserCultures { get; set; }
        public virtual ICollection<CmsUserRole> CmsUserRoles { get; set; }
        public virtual ICollection<CmsUserSetting> CmsUserSettingUserActivatedByUsers { get; set; }
        public virtual ICollection<CmsUserSetting> CmsUserSettingUserSettingsUserGus { get; set; }
        public virtual ICollection<CmsUserSite> CmsUserSites { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistoryModifiedByUsers { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistoryVersionDeletedByUsers { get; set; }
        public virtual ICollection<CmsWorkflowHistory> CmsWorkflowHistories { get; set; }
        public virtual ICollection<CmsWorkflowStepUser> CmsWorkflowStepUsers { get; set; }
        public virtual ICollection<ComCustomer> ComCustomers { get; set; }
        public virtual ICollection<ComOrderStatusUser> ComOrderStatusUsers { get; set; }
        public virtual ICollection<ComOrder> ComOrders { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCarts { get; set; }
        public virtual ICollection<ComWishlist> ComWishlists { get; set; }
        public virtual ICollection<CommunityGroup> CommunityGroupGroupApprovedByUsers { get; set; }
        public virtual ICollection<CommunityGroup> CommunityGroupGroupCreatedByUsers { get; set; }
        public virtual ICollection<CommunityGroupMember> CommunityGroupMemberMemberApprovedByUsers { get; set; }
        public virtual ICollection<CommunityGroupMember> CommunityGroupMemberMemberInvitedByUsers { get; set; }
        public virtual ICollection<CommunityGroupMember> CommunityGroupMemberMemberUsers { get; set; }
        public virtual ICollection<CommunityInvitation> CommunityInvitationInvitedByUsers { get; set; }
        public virtual ICollection<CommunityInvitation> CommunityInvitationInvitedUsers { get; set; }
        public virtual ICollection<ExportHistory> ExportHistories { get; set; }
        public virtual ICollection<ForumsForumPost> ForumsForumPostPostApprovedByUsers { get; set; }
        public virtual ICollection<ForumsForumPost> ForumsForumPostPostUsers { get; set; }
        public virtual ICollection<ForumsForumSubscription> ForumsForumSubscriptions { get; set; }
        public virtual ICollection<ForumsUserFavorite> ForumsUserFavorites { get; set; }
        public virtual ICollection<MediaFile> MediaFileFileCreatedByUsers { get; set; }
        public virtual ICollection<MediaFile> MediaFileFileModifiedByUsers { get; set; }
        public virtual ICollection<NotificationSubscription> NotificationSubscriptions { get; set; }
        public virtual ICollection<OmAccount> OmAccounts { get; set; }
        public virtual ICollection<OmContact> OmContacts { get; set; }
        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscriptions { get; set; }
        public virtual ICollection<ReportingSavedReport> ReportingSavedReports { get; set; }
        public virtual ICollection<StagingTaskUser> StagingTaskUsers { get; set; }

        public virtual ICollection<BoardBoard> Boards { get; set; }
        public virtual ICollection<ForumsForum> Forums { get; set; }
        public virtual ICollection<CmsWorkflow> Workflows { get; set; }
    }
}
