using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HaveshApp.Model
{
    public partial class MyDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options , IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        public virtual DbSet<AnalyticsCampaign> AnalyticsCampaigns { get; set; } = null!;
        public virtual DbSet<AnalyticsCampaignAsset> AnalyticsCampaignAssets { get; set; } = null!;
        public virtual DbSet<AnalyticsCampaignAssetUrl> AnalyticsCampaignAssetUrls { get; set; } = null!;
        public virtual DbSet<AnalyticsCampaignConversion> AnalyticsCampaignConversions { get; set; } = null!;
        public virtual DbSet<AnalyticsCampaignConversionHit> AnalyticsCampaignConversionHits { get; set; } = null!;
        public virtual DbSet<AnalyticsCampaignObjective> AnalyticsCampaignObjectives { get; set; } = null!;
        public virtual DbSet<AnalyticsConversion> AnalyticsConversions { get; set; } = null!;
        public virtual DbSet<AnalyticsDayHit> AnalyticsDayHits { get; set; } = null!;
        public virtual DbSet<AnalyticsExitPage> AnalyticsExitPages { get; set; } = null!;
        public virtual DbSet<AnalyticsHourHit> AnalyticsHourHits { get; set; } = null!;
        public virtual DbSet<AnalyticsMonthHit> AnalyticsMonthHits { get; set; } = null!;
        public virtual DbSet<AnalyticsStatistic> AnalyticsStatistics { get; set; } = null!;
        public virtual DbSet<AnalyticsWeekHit> AnalyticsWeekHits { get; set; } = null!;
        public virtual DbSet<AnalyticsYearHit> AnalyticsYearHits { get; set; } = null!;
        public virtual DbSet<BadWordsWord> BadWordsWords { get; set; } = null!;
        public virtual DbSet<BlogComment> BlogComments { get; set; } = null!;
        public virtual DbSet<BlogPostSubscription> BlogPostSubscriptions { get; set; } = null!;
        public virtual DbSet<BoardBoard> BoardBoards { get; set; } = null!;
        public virtual DbSet<BoardMessage> BoardMessages { get; set; } = null!;
        public virtual DbSet<BoardSubscription> BoardSubscriptions { get; set; } = null!;
        public virtual DbSet<ChatInitiatedChatRequest> ChatInitiatedChatRequests { get; set; } = null!;
        public virtual DbSet<ChatMessage> ChatMessages { get; set; } = null!;
        public virtual DbSet<ChatNotification> ChatNotifications { get; set; } = null!;
        public virtual DbSet<ChatOnlineSupport> ChatOnlineSupports { get; set; } = null!;
        public virtual DbSet<ChatOnlineUser> ChatOnlineUsers { get; set; } = null!;
        public virtual DbSet<ChatPopupWindowSetting> ChatPopupWindowSettings { get; set; } = null!;
        public virtual DbSet<ChatRoom> ChatRooms { get; set; } = null!;
        public virtual DbSet<ChatRoomUser> ChatRoomUsers { get; set; } = null!;
        public virtual DbSet<ChatSupportCannedResponse> ChatSupportCannedResponses { get; set; } = null!;
        public virtual DbSet<ChatSupportTakenRoom> ChatSupportTakenRooms { get; set; } = null!;
        public virtual DbSet<ChatUser> ChatUsers { get; set; } = null!;
        public virtual DbSet<CiFileMetadatum> CiFileMetadata { get; set; } = null!;
        public virtual DbSet<CiMigration> CiMigrations { get; set; } = null!;
        public virtual DbSet<CmsAbuseReport> CmsAbuseReports { get; set; } = null!;
        public virtual DbSet<CmsAcl> CmsAcls { get; set; } = null!;
        public virtual DbSet<CmsAclitem> CmsAclitems { get; set; } = null!;
        public virtual DbSet<CmsAlternativeForm> CmsAlternativeForms { get; set; } = null!;
        public virtual DbSet<CmsAlternativeUrl> CmsAlternativeUrls { get; set; } = null!;
        public virtual DbSet<CmsAttachment> CmsAttachments { get; set; } = null!;
        public virtual DbSet<CmsAttachmentHistory> CmsAttachmentHistories { get; set; } = null!;
        public virtual DbSet<CmsAutomationHistory> CmsAutomationHistories { get; set; } = null!;
        public virtual DbSet<CmsAutomationState> CmsAutomationStates { get; set; } = null!;
        public virtual DbSet<CmsAvatar> CmsAvatars { get; set; } = null!;
        public virtual DbSet<CmsBadge> CmsBadges { get; set; } = null!;
        public virtual DbSet<CmsBannedIp> CmsBannedIps { get; set; } = null!;
        public virtual DbSet<CmsBanner> CmsBanners { get; set; } = null!;
        public virtual DbSet<CmsBannerCategory> CmsBannerCategories { get; set; } = null!;
        public virtual DbSet<CmsCategory> CmsCategories { get; set; } = null!;
        public virtual DbSet<CmsClass> CmsClasses { get; set; } = null!;
        public virtual DbSet<CmsConsent> CmsConsents { get; set; } = null!;
        public virtual DbSet<CmsConsentAgreement> CmsConsentAgreements { get; set; } = null!;
        public virtual DbSet<CmsConsentArchive> CmsConsentArchives { get; set; } = null!;
        public virtual DbSet<CmsCountry> CmsCountries { get; set; } = null!;
        public virtual DbSet<CmsCssStylesheet> CmsCssStylesheets { get; set; } = null!;
        public virtual DbSet<CmsCulture> CmsCultures { get; set; } = null!;
        public virtual DbSet<CmsDeviceProfile> CmsDeviceProfiles { get; set; } = null!;
        public virtual DbSet<CmsDeviceProfileLayout> CmsDeviceProfileLayouts { get; set; } = null!;
        public virtual DbSet<CmsDocument> CmsDocuments { get; set; } = null!;
        public virtual DbSet<CmsDocumentAlias> CmsDocumentAliases { get; set; } = null!;
        public virtual DbSet<CmsDocumentTypeScope> CmsDocumentTypeScopes { get; set; } = null!;
        public virtual DbSet<CmsEmail> CmsEmails { get; set; } = null!;
        public virtual DbSet<CmsEmailAttachment> CmsEmailAttachments { get; set; } = null!;
        public virtual DbSet<CmsEmailTemplate> CmsEmailTemplates { get; set; } = null!;
        public virtual DbSet<CmsEmailUser> CmsEmailUsers { get; set; } = null!;
        public virtual DbSet<CmsEventLog> CmsEventLogs { get; set; } = null!;
        public virtual DbSet<CmsExternalLogin> CmsExternalLogins { get; set; } = null!;
        public virtual DbSet<CmsForm> CmsForms { get; set; } = null!;
        public virtual DbSet<CmsFormUserControl> CmsFormUserControls { get; set; } = null!;
        public virtual DbSet<CmsHelpTopic> CmsHelpTopics { get; set; } = null!;
        public virtual DbSet<CmsLayout> CmsLayouts { get; set; } = null!;
        public virtual DbSet<CmsLicenseKey> CmsLicenseKeys { get; set; } = null!;
        public virtual DbSet<CmsMacroIdentity> CmsMacroIdentities { get; set; } = null!;
        public virtual DbSet<CmsMacroRule> CmsMacroRules { get; set; } = null!;
        public virtual DbSet<CmsMembership> CmsMemberships { get; set; } = null!;
        public virtual DbSet<CmsMembershipUser> CmsMembershipUsers { get; set; } = null!;
        public virtual DbSet<CmsMetaFile> CmsMetaFiles { get; set; } = null!;
        public virtual DbSet<CmsModuleLicenseKey> CmsModuleLicenseKeys { get; set; } = null!;
        public virtual DbSet<CmsModuleUsageCounter> CmsModuleUsageCounters { get; set; } = null!;
        public virtual DbSet<CmsObjectSetting> CmsObjectSettings { get; set; } = null!;
        public virtual DbSet<CmsObjectVersionHistory> CmsObjectVersionHistories { get; set; } = null!;
        public virtual DbSet<CmsObjectWorkflowTrigger> CmsObjectWorkflowTriggers { get; set; } = null!;
        public virtual DbSet<CmsOpenIduser> CmsOpenIdusers { get; set; } = null!;
        public virtual DbSet<CmsPageTemplate> CmsPageTemplates { get; set; } = null!;
        public virtual DbSet<CmsPageTemplateCategory> CmsPageTemplateCategories { get; set; } = null!;
        public virtual DbSet<CmsPageTemplateConfiguration> CmsPageTemplateConfigurations { get; set; } = null!;
        public virtual DbSet<CmsPageTemplateScope> CmsPageTemplateScopes { get; set; } = null!;
        public virtual DbSet<CmsPermission> CmsPermissions { get; set; } = null!;
        public virtual DbSet<CmsPersonalization> CmsPersonalizations { get; set; } = null!;
        public virtual DbSet<CmsQuery> CmsQueries { get; set; } = null!;
        public virtual DbSet<CmsRelationship> CmsRelationships { get; set; } = null!;
        public virtual DbSet<CmsRelationshipName> CmsRelationshipNames { get; set; } = null!;
        public virtual DbSet<CmsResource> CmsResources { get; set; } = null!;
        public virtual DbSet<CmsResourceLibrary> CmsResourceLibraries { get; set; } = null!;
        public virtual DbSet<CmsResourceString> CmsResourceStrings { get; set; } = null!;
        public virtual DbSet<CmsResourceTranslation> CmsResourceTranslations { get; set; } = null!;
        public virtual DbSet<CmsRole> CmsRoles { get; set; } = null!;
        public virtual DbSet<CmsScheduledTask> CmsScheduledTasks { get; set; } = null!;
        public virtual DbSet<CmsSearchEngine> CmsSearchEngines { get; set; } = null!;
        public virtual DbSet<CmsSearchIndex> CmsSearchIndices { get; set; } = null!;
        public virtual DbSet<CmsSearchTask> CmsSearchTasks { get; set; } = null!;
        public virtual DbSet<CmsSearchTaskAzure> CmsSearchTaskAzures { get; set; } = null!;
        public virtual DbSet<CmsSession> CmsSessions { get; set; } = null!;
        public virtual DbSet<CmsSettingsCategory> CmsSettingsCategories { get; set; } = null!;
        public virtual DbSet<CmsSettingsKey> CmsSettingsKeys { get; set; } = null!;
        public virtual DbSet<CmsSite> CmsSites { get; set; } = null!;
        public virtual DbSet<CmsSiteDomainAlias> CmsSiteDomainAliases { get; set; } = null!;
        public virtual DbSet<CmsSmtpserver> CmsSmtpservers { get; set; } = null!;
        public virtual DbSet<CmsState> CmsStates { get; set; } = null!;
        public virtual DbSet<CmsTag> CmsTags { get; set; } = null!;
        public virtual DbSet<CmsTagGroup> CmsTagGroups { get; set; } = null!;
        public virtual DbSet<CmsTemplateDeviceLayout> CmsTemplateDeviceLayouts { get; set; } = null!;
        public virtual DbSet<CmsTimeZone> CmsTimeZones { get; set; } = null!;
        public virtual DbSet<CmsTransformation> CmsTransformations { get; set; } = null!;
        public virtual DbSet<CmsTranslationService> CmsTranslationServices { get; set; } = null!;
        public virtual DbSet<CmsTranslationSubmission> CmsTranslationSubmissions { get; set; } = null!;
        public virtual DbSet<CmsTranslationSubmissionItem> CmsTranslationSubmissionItems { get; set; } = null!;
        public virtual DbSet<CmsTree> CmsTrees { get; set; } = null!;
        public virtual DbSet<CmsUielement> CmsUielements { get; set; } = null!;
        public virtual DbSet<CmsUser> CmsUsers { get; set; } = null!;
        public virtual DbSet<CmsUserCulture> CmsUserCultures { get; set; } = null!;
        public virtual DbSet<CmsUserMacroIdentity> CmsUserMacroIdentities { get; set; } = null!;
        public virtual DbSet<CmsUserRole> CmsUserRoles { get; set; } = null!;
        public virtual DbSet<CmsUserSetting> CmsUserSettings { get; set; } = null!;
        public virtual DbSet<CmsUserSite> CmsUserSites { get; set; } = null!;
        public virtual DbSet<CmsVersionHistory> CmsVersionHistories { get; set; } = null!;
        public virtual DbSet<CmsWebFarmServer> CmsWebFarmServers { get; set; } = null!;
        public virtual DbSet<CmsWebFarmServerLog> CmsWebFarmServerLogs { get; set; } = null!;
        public virtual DbSet<CmsWebFarmServerMonitoring> CmsWebFarmServerMonitorings { get; set; } = null!;
        public virtual DbSet<CmsWebFarmServerTask> CmsWebFarmServerTasks { get; set; } = null!;
        public virtual DbSet<CmsWebFarmTask> CmsWebFarmTasks { get; set; } = null!;
        public virtual DbSet<CmsWebPart> CmsWebParts { get; set; } = null!;
        public virtual DbSet<CmsWebPartCategory> CmsWebPartCategories { get; set; } = null!;
        public virtual DbSet<CmsWebPartContainer> CmsWebPartContainers { get; set; } = null!;
        public virtual DbSet<CmsWebPartLayout> CmsWebPartLayouts { get; set; } = null!;
        public virtual DbSet<CmsWebTemplate> CmsWebTemplates { get; set; } = null!;
        public virtual DbSet<CmsWidget> CmsWidgets { get; set; } = null!;
        public virtual DbSet<CmsWidgetCategory> CmsWidgetCategories { get; set; } = null!;
        public virtual DbSet<CmsWidgetRole> CmsWidgetRoles { get; set; } = null!;
        public virtual DbSet<CmsWorkflow> CmsWorkflows { get; set; } = null!;
        public virtual DbSet<CmsWorkflowAction> CmsWorkflowActions { get; set; } = null!;
        public virtual DbSet<CmsWorkflowHistory> CmsWorkflowHistories { get; set; } = null!;
        public virtual DbSet<CmsWorkflowScope> CmsWorkflowScopes { get; set; } = null!;
        public virtual DbSet<CmsWorkflowStep> CmsWorkflowSteps { get; set; } = null!;
        public virtual DbSet<CmsWorkflowStepRole> CmsWorkflowStepRoles { get; set; } = null!;
        public virtual DbSet<CmsWorkflowStepUser> CmsWorkflowStepUsers { get; set; } = null!;
        public virtual DbSet<CmsWorkflowTransition> CmsWorkflowTransitions { get; set; } = null!;
        public virtual DbSet<ComAddress> ComAddresses { get; set; } = null!;
        public virtual DbSet<ComBrand> ComBrands { get; set; } = null!;
        public virtual DbSet<ComCarrier> ComCarriers { get; set; } = null!;
        public virtual DbSet<ComCollection> ComCollections { get; set; } = null!;
        public virtual DbSet<ComCouponCode> ComCouponCodes { get; set; } = null!;
        public virtual DbSet<ComCurrency> ComCurrencies { get; set; } = null!;
        public virtual DbSet<ComCurrencyExchangeRate> ComCurrencyExchangeRates { get; set; } = null!;
        public virtual DbSet<ComCustomer> ComCustomers { get; set; } = null!;
        public virtual DbSet<ComCustomerCreditHistory> ComCustomerCreditHistories { get; set; } = null!;
        public virtual DbSet<ComDepartment> ComDepartments { get; set; } = null!;
        public virtual DbSet<ComDiscount> ComDiscounts { get; set; } = null!;
        public virtual DbSet<ComExchangeTable> ComExchangeTables { get; set; } = null!;
        public virtual DbSet<ComGiftCard> ComGiftCards { get; set; } = null!;
        public virtual DbSet<ComGiftCardCouponCode> ComGiftCardCouponCodes { get; set; } = null!;
        public virtual DbSet<ComInternalStatus> ComInternalStatuses { get; set; } = null!;
        public virtual DbSet<ComManufacturer> ComManufacturers { get; set; } = null!;
        public virtual DbSet<ComMultiBuyCouponCode> ComMultiBuyCouponCodes { get; set; } = null!;
        public virtual DbSet<ComMultiBuyDiscount> ComMultiBuyDiscounts { get; set; } = null!;
        public virtual DbSet<ComMultiBuyDiscountBrand> ComMultiBuyDiscountBrands { get; set; } = null!;
        public virtual DbSet<ComMultiBuyDiscountCollection> ComMultiBuyDiscountCollections { get; set; } = null!;
        public virtual DbSet<ComMultiBuyDiscountTree> ComMultiBuyDiscountTrees { get; set; } = null!;
        public virtual DbSet<ComOptionCategory> ComOptionCategories { get; set; } = null!;
        public virtual DbSet<ComOrder> ComOrders { get; set; } = null!;
        public virtual DbSet<ComOrderAddress> ComOrderAddresses { get; set; } = null!;
        public virtual DbSet<ComOrderItem> ComOrderItems { get; set; } = null!;
        public virtual DbSet<ComOrderItemSkufile> ComOrderItemSkufiles { get; set; } = null!;
        public virtual DbSet<ComOrderStatus> ComOrderStatuses { get; set; } = null!;
        public virtual DbSet<ComOrderStatusUser> ComOrderStatusUsers { get; set; } = null!;
        public virtual DbSet<ComPaymentOption> ComPaymentOptions { get; set; } = null!;
        public virtual DbSet<ComPublicStatus> ComPublicStatuses { get; set; } = null!;
        public virtual DbSet<ComShippingCost> ComShippingCosts { get; set; } = null!;
        public virtual DbSet<ComShippingOption> ComShippingOptions { get; set; } = null!;
        public virtual DbSet<ComShoppingCart> ComShoppingCarts { get; set; } = null!;
        public virtual DbSet<ComShoppingCartCouponCode> ComShoppingCartCouponCodes { get; set; } = null!;
        public virtual DbSet<ComShoppingCartSku> ComShoppingCartSkus { get; set; } = null!;
        public virtual DbSet<ComSku> ComSkus { get; set; } = null!;
        public virtual DbSet<ComSkufile> ComSkufiles { get; set; } = null!;
        public virtual DbSet<ComSkuoptionCategory> ComSkuoptionCategories { get; set; } = null!;
        public virtual DbSet<ComSupplier> ComSuppliers { get; set; } = null!;
        public virtual DbSet<ComTaxClass> ComTaxClasses { get; set; } = null!;
        public virtual DbSet<ComTaxClassCountry> ComTaxClassCountries { get; set; } = null!;
        public virtual DbSet<ComTaxClassState> ComTaxClassStates { get; set; } = null!;
        public virtual DbSet<ComVolumeDiscount> ComVolumeDiscounts { get; set; } = null!;
        public virtual DbSet<ComWishlist> ComWishlists { get; set; } = null!;
        public virtual DbSet<CommunityGroup> CommunityGroups { get; set; } = null!;
        public virtual DbSet<CommunityGroupMember> CommunityGroupMembers { get; set; } = null!;
        public virtual DbSet<CommunityGroupRolePermission> CommunityGroupRolePermissions { get; set; } = null!;
        public virtual DbSet<CommunityInvitation> CommunityInvitations { get; set; } = null!;
        public virtual DbSet<ContentArticle> ContentArticles { get; set; } = null!;
        public virtual DbSet<ContentBlog> ContentBlogs { get; set; } = null!;
        public virtual DbSet<ContentBlogMonth> ContentBlogMonths { get; set; } = null!;
        public virtual DbSet<ContentBlogPost> ContentBlogPosts { get; set; } = null!;
        public virtual DbSet<ContentBookingEvent> ContentBookingEvents { get; set; } = null!;
        public virtual DbSet<ContentEvent> ContentEvents { get; set; } = null!;
        public virtual DbSet<ContentFaq> ContentFaqs { get; set; } = null!;
        public virtual DbSet<ContentFile> ContentFiles { get; set; } = null!;
        public virtual DbSet<ContentImageGallery> ContentImageGalleries { get; set; } = null!;
        public virtual DbSet<ContentJob> ContentJobs { get; set; } = null!;
        public virtual DbSet<ContentKbarticle> ContentKbarticles { get; set; } = null!;
        public virtual DbSet<ContentMenuItem> ContentMenuItems { get; set; } = null!;
        public virtual DbSet<ContentNews> ContentNews { get; set; } = null!;
        public virtual DbSet<ContentOffice> ContentOffices { get; set; } = null!;
        public virtual DbSet<ContentPressRelease> ContentPressReleases { get; set; } = null!;
        public virtual DbSet<ContentProduct> ContentProducts { get; set; } = null!;
        public virtual DbSet<ContentSimpleArticle> ContentSimpleArticles { get; set; } = null!;
        public virtual DbSet<CustomtableSampleTable> CustomtableSampleTables { get; set; } = null!;
        public virtual DbSet<EventsAttendee> EventsAttendees { get; set; } = null!;
        public virtual DbSet<ExportHistory> ExportHistories { get; set; } = null!;
        public virtual DbSet<ExportTask> ExportTasks { get; set; } = null!;
        public virtual DbSet<FormAbbasarabzadehArabzadehContact> FormAbbasarabzadehArabzadehContacts { get; set; } = null!;
        public virtual DbSet<FormShokouhCenterBranchRequest> FormShokouhCenterBranchRequests { get; set; } = null!;
        public virtual DbSet<FormShokouhCenterContactU> FormShokouhCenterContactUs { get; set; } = null!;
        public virtual DbSet<FormShokouhCenterHiring> FormShokouhCenterHirings { get; set; } = null!;
        public virtual DbSet<FormShokouhOnlinePortalContact> FormShokouhOnlinePortalContacts { get; set; } = null!;
        public virtual DbSet<FormShokouhOnlinePortalHiring> FormShokouhOnlinePortalHirings { get; set; } = null!;
        public virtual DbSet<FormShokouhOnlinePortalStudentName> FormShokouhOnlinePortalStudentNames { get; set; } = null!;
        public virtual DbSet<FormShokouhOnlinePortalStudentNameTel> FormShokouhOnlinePortalStudentNameTels { get; set; } = null!;
        public virtual DbSet<FormShokouhOnlinePortalStudentNameTelBackup> FormShokouhOnlinePortalStudentNameTelBackups { get; set; } = null!;
        public virtual DbSet<FormShokouhOnlinePortalWriting> FormShokouhOnlinePortalWritings { get; set; } = null!;
        public virtual DbSet<FormShokouhOnlinePortalWritingBackup> FormShokouhOnlinePortalWritingBackups { get; set; } = null!;
        public virtual DbSet<ForumsAttachment> ForumsAttachments { get; set; } = null!;
        public virtual DbSet<ForumsForum> ForumsForums { get; set; } = null!;
        public virtual DbSet<ForumsForumGroup> ForumsForumGroups { get; set; } = null!;
        public virtual DbSet<ForumsForumPost> ForumsForumPosts { get; set; } = null!;
        public virtual DbSet<ForumsForumRole> ForumsForumRoles { get; set; } = null!;
        public virtual DbSet<ForumsForumSubscription> ForumsForumSubscriptions { get; set; } = null!;
        public virtual DbSet<ForumsUserFavorite> ForumsUserFavorites { get; set; } = null!;
        public virtual DbSet<IntegrationConnector> IntegrationConnectors { get; set; } = null!;
        public virtual DbSet<IntegrationSyncLog> IntegrationSyncLogs { get; set; } = null!;
        public virtual DbSet<IntegrationSynchronization> IntegrationSynchronizations { get; set; } = null!;
        public virtual DbSet<IntegrationTask> IntegrationTasks { get; set; } = null!;
        public virtual DbSet<IntranetPortalDepartment> IntranetPortalDepartments { get; set; } = null!;
        public virtual DbSet<IntranetPortalWorkingEnvironment> IntranetPortalWorkingEnvironments { get; set; } = null!;
        public virtual DbSet<MediaFile> MediaFiles { get; set; } = null!;
        public virtual DbSet<MediaLibrary> MediaLibraries { get; set; } = null!;
        public virtual DbSet<MediaLibraryRolePermission> MediaLibraryRolePermissions { get; set; } = null!;
        public virtual DbSet<NewsletterAbtest> NewsletterAbtests { get; set; } = null!;
        public virtual DbSet<NewsletterClickedLink> NewsletterClickedLinks { get; set; } = null!;
        public virtual DbSet<NewsletterEmail> NewsletterEmails { get; set; } = null!;
        public virtual DbSet<NewsletterEmailTemplate> NewsletterEmailTemplates { get; set; } = null!;
        public virtual DbSet<NewsletterEmailWidget> NewsletterEmailWidgets { get; set; } = null!;
        public virtual DbSet<NewsletterEmailWidgetTemplate> NewsletterEmailWidgetTemplates { get; set; } = null!;
        public virtual DbSet<NewsletterIssueContactGroup> NewsletterIssueContactGroups { get; set; } = null!;
        public virtual DbSet<NewsletterLink> NewsletterLinks { get; set; } = null!;
        public virtual DbSet<NewsletterNewsletter> NewsletterNewsletters { get; set; } = null!;
        public virtual DbSet<NewsletterNewsletterIssue> NewsletterNewsletterIssues { get; set; } = null!;
        public virtual DbSet<NewsletterOpenedEmail> NewsletterOpenedEmails { get; set; } = null!;
        public virtual DbSet<NewsletterSubscriber> NewsletterSubscribers { get; set; } = null!;
        public virtual DbSet<NewsletterSubscriberNewsletter> NewsletterSubscriberNewsletters { get; set; } = null!;
        public virtual DbSet<NewsletterUnsubscription> NewsletterUnsubscriptions { get; set; } = null!;
        public virtual DbSet<NotificationGateway> NotificationGateways { get; set; } = null!;
        public virtual DbSet<NotificationSubscription> NotificationSubscriptions { get; set; } = null!;
        public virtual DbSet<NotificationTemplate> NotificationTemplates { get; set; } = null!;
        public virtual DbSet<NotificationTemplateText> NotificationTemplateTexts { get; set; } = null!;
        public virtual DbSet<NtmtnSocial> NtmtnSocials { get; set; } = null!;
        public virtual DbSet<OmAbtest> OmAbtests { get; set; } = null!;
        public virtual DbSet<OmAbvariant> OmAbvariants { get; set; } = null!;
        public virtual DbSet<OmAbvariantDatum> OmAbvariantData { get; set; } = null!;
        public virtual DbSet<OmAccount> OmAccounts { get; set; } = null!;
        public virtual DbSet<OmAccountContact> OmAccountContacts { get; set; } = null!;
        public virtual DbSet<OmAccountStatus> OmAccountStatuses { get; set; } = null!;
        public virtual DbSet<OmActivity> OmActivities { get; set; } = null!;
        public virtual DbSet<OmActivityRecalculationQueue> OmActivityRecalculationQueues { get; set; } = null!;
        public virtual DbSet<OmActivityType> OmActivityTypes { get; set; } = null!;
        public virtual DbSet<OmContact> OmContacts { get; set; } = null!;
        public virtual DbSet<OmContactChangeRecalculationQueue> OmContactChangeRecalculationQueues { get; set; } = null!;
        public virtual DbSet<OmContactGroup> OmContactGroups { get; set; } = null!;
        public virtual DbSet<OmContactGroupMember> OmContactGroupMembers { get; set; } = null!;
        public virtual DbSet<OmContactRole> OmContactRoles { get; set; } = null!;
        public virtual DbSet<OmContactStatus> OmContactStatuses { get; set; } = null!;
        public virtual DbSet<OmMembership> OmMemberships { get; set; } = null!;
        public virtual DbSet<OmMvtcombination> OmMvtcombinations { get; set; } = null!;
        public virtual DbSet<OmMvtest> OmMvtests { get; set; } = null!;
        public virtual DbSet<OmMvtvariant> OmMvtvariants { get; set; } = null!;
        public virtual DbSet<OmPersonalizationVariant> OmPersonalizationVariants { get; set; } = null!;
        public virtual DbSet<OmRule> OmRules { get; set; } = null!;
        public virtual DbSet<OmScore> OmScores { get; set; } = null!;
        public virtual DbSet<OmScoreContactRule> OmScoreContactRules { get; set; } = null!;
        public virtual DbSet<OmVisitorToContact> OmVisitorToContacts { get; set; } = null!;
        public virtual DbSet<OnlineTeacherLink> OnlineTeacherLinks { get; set; } = null!;
        public virtual DbSet<OnlineTermTable> OnlineTermTables { get; set; } = null!;
        public virtual DbSet<PageBookCalssRecord> PageBookCalssRecords { get; set; } = null!;
        public virtual DbSet<PageBookPageType> PageBookPageTypes { get; set; } = null!;
        public virtual DbSet<PersonasPersona> PersonasPersonas { get; set; } = null!;
        public virtual DbSet<PersonasPersonaContactHistory> PersonasPersonaContactHistories { get; set; } = null!;
        public virtual DbSet<PersonasPersonaNode> PersonasPersonaNodes { get; set; } = null!;
        public virtual DbSet<PollsPoll> PollsPolls { get; set; } = null!;
        public virtual DbSet<PollsPollAnswer> PollsPollAnswers { get; set; } = null!;
        public virtual DbSet<ReportingReport> ReportingReports { get; set; } = null!;
        public virtual DbSet<ReportingReportCategory> ReportingReportCategories { get; set; } = null!;
        public virtual DbSet<ReportingReportGraph> ReportingReportGraphs { get; set; } = null!;
        public virtual DbSet<ReportingReportSubscription> ReportingReportSubscriptions { get; set; } = null!;
        public virtual DbSet<ReportingReportTable> ReportingReportTables { get; set; } = null!;
        public virtual DbSet<ReportingReportValue> ReportingReportValues { get; set; } = null!;
        public virtual DbSet<ReportingSavedGraph> ReportingSavedGraphs { get; set; } = null!;
        public virtual DbSet<ReportingSavedReport> ReportingSavedReports { get; set; } = null!;
        public virtual DbSet<SharePointSharePointConnection> SharePointSharePointConnections { get; set; } = null!;
        public virtual DbSet<SharePointSharePointFile> SharePointSharePointFiles { get; set; } = null!;
        public virtual DbSet<SharePointSharePointLibrary> SharePointSharePointLibraries { get; set; } = null!;
        public virtual DbSet<ShokouhBranchNode> ShokouhBranchNodes { get; set; } = null!;
        public virtual DbSet<ShokouhPardisAccountingCode> ShokouhPardisAccountingCodes { get; set; } = null!;
        public virtual DbSet<ShokouhPardisAccountingTransaction> ShokouhPardisAccountingTransactions { get; set; } = null!;
        public virtual DbSet<ShokouhPardisBookClass> ShokouhPardisBookClasses { get; set; } = null!;
        public virtual DbSet<ShokouhPardisClassRoom> ShokouhPardisClassRooms { get; set; } = null!;
        public virtual DbSet<ShokouhPardisCourse> ShokouhPardisCourses { get; set; } = null!;
        public virtual DbSet<ShokouhPardisCourseStudent> ShokouhPardisCourseStudents { get; set; } = null!;
        public virtual DbSet<ShokouhPardisDailyJv> ShokouhPardisDailyJvs { get; set; } = null!;
        public virtual DbSet<ShokouhPardisDaySession> ShokouhPardisDaySessions { get; set; } = null!;
        public virtual DbSet<ShokouhPardisEmployee> ShokouhPardisEmployees { get; set; } = null!;
        public virtual DbSet<ShokouhPardisFileAttachment> ShokouhPardisFileAttachments { get; set; } = null!;
        public virtual DbSet<ShokouhPardisFinanceFlat> ShokouhPardisFinanceFlats { get; set; } = null!;
        public virtual DbSet<ShokouhPardisInterval> ShokouhPardisIntervals { get; set; } = null!;
        public virtual DbSet<ShokouhPardisJvfromSite> ShokouhPardisJvfromSites { get; set; } = null!;
        public virtual DbSet<ShokouhPardisLevelBookPrice> ShokouhPardisLevelBookPrices { get; set; } = null!;
        public virtual DbSet<ShokouhPardisLevelClass> ShokouhPardisLevelClasses { get; set; } = null!;
        public virtual DbSet<ShokouhPardisProgram> ShokouhPardisPrograms { get; set; } = null!;
        public virtual DbSet<ShokouhPardisSchedule> ShokouhPardisSchedules { get; set; } = null!;
        public virtual DbSet<ShokouhPardisStudentClass> ShokouhPardisStudentClasses { get; set; } = null!;
        public virtual DbSet<ShokouhPardisStudentClassDto> ShokouhPardisStudentClassDtos { get; set; } = null!;
        public virtual DbSet<ShokouhPardisStudentClassOnlineForm> ShokouhPardisStudentClassOnlineForms { get; set; } = null!;
        public virtual DbSet<ShokouhPardisTeacherClass> ShokouhPardisTeacherClasses { get; set; } = null!;
        public virtual DbSet<ShokouhPardisTeacherLevel> ShokouhPardisTeacherLevels { get; set; } = null!;
        public virtual DbSet<ShokouhPardisTeacherTermClass> ShokouhPardisTeacherTermClasses { get; set; } = null!;
        public virtual DbSet<ShokouhPardisTeacherTimeSheet> ShokouhPardisTeacherTimeSheets { get; set; } = null!;
        public virtual DbSet<ShokouhPardisTermClass> ShokouhPardisTermClasses { get; set; } = null!;
        public virtual DbSet<ShokouhPardisTimeTable> ShokouhPardisTimeTables { get; set; } = null!;
        public virtual DbSet<ShokouhPardisTimeTableStudent> ShokouhPardisTimeTableStudents { get; set; } = null!;
        public virtual DbSet<ShokouhPardisWeekDay> ShokouhPardisWeekDays { get; set; } = null!;
        public virtual DbSet<ShokouhPardisYearClass> ShokouhPardisYearClasses { get; set; } = null!;
        public virtual DbSet<SmFacebookAccount> SmFacebookAccounts { get; set; } = null!;
        public virtual DbSet<SmFacebookApplication> SmFacebookApplications { get; set; } = null!;
        public virtual DbSet<SmFacebookPost> SmFacebookPosts { get; set; } = null!;
        public virtual DbSet<SmInsight> SmInsights { get; set; } = null!;
        public virtual DbSet<SmInsightHitDay> SmInsightHitDays { get; set; } = null!;
        public virtual DbSet<SmInsightHitMonth> SmInsightHitMonths { get; set; } = null!;
        public virtual DbSet<SmInsightHitWeek> SmInsightHitWeeks { get; set; } = null!;
        public virtual DbSet<SmInsightHitYear> SmInsightHitYears { get; set; } = null!;
        public virtual DbSet<SmLinkedInAccount> SmLinkedInAccounts { get; set; } = null!;
        public virtual DbSet<SmLinkedInApplication> SmLinkedInApplications { get; set; } = null!;
        public virtual DbSet<SmLinkedInPost> SmLinkedInPosts { get; set; } = null!;
        public virtual DbSet<SmTwitterAccount> SmTwitterAccounts { get; set; } = null!;
        public virtual DbSet<SmTwitterApplication> SmTwitterApplications { get; set; } = null!;
        public virtual DbSet<SmTwitterPost> SmTwitterPosts { get; set; } = null!;
        public virtual DbSet<SopBookFolderId> SopBookFolderIds { get; set; } = null!;
        public virtual DbSet<StagingServer> StagingServers { get; set; } = null!;
        public virtual DbSet<StagingSynchronization> StagingSynchronizations { get; set; } = null!;
        public virtual DbSet<StagingTask> StagingTasks { get; set; } = null!;
        public virtual DbSet<StagingTaskGroup> StagingTaskGroups { get; set; } = null!;
        public virtual DbSet<StagingTaskGroupTask> StagingTaskGroupTasks { get; set; } = null!;
        public virtual DbSet<StagingTaskGroupUser> StagingTaskGroupUsers { get; set; } = null!;
        public virtual DbSet<StagingTaskUser> StagingTaskUsers { get; set; } = null!;
        public virtual DbSet<StatementMeliN> StatementMeliNs { get; set; } = null!;
        public virtual DbSet<StatementParsianM> StatementParsianMs { get; set; } = null!;
        public virtual DbSet<TempFile> TempFiles { get; set; } = null!;
        public virtual DbSet<TempPageBuilderWidget> TempPageBuilderWidgets { get; set; } = null!;
        public virtual DbSet<ViewBoardsBoardMessageJoined> ViewBoardsBoardMessageJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsAclitemItemsAndOperator> ViewCmsAclitemItemsAndOperators { get; set; } = null!;
        public virtual DbSet<ViewCmsObjectVersionHistoryUserJoined> ViewCmsObjectVersionHistoryUserJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsPageTemplateCategoryPageTemplateJoined> ViewCmsPageTemplateCategoryPageTemplateJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsRelationshipJoined> ViewCmsRelationshipJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsResourceStringJoined> ViewCmsResourceStringJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsResourceTranslatedJoined> ViewCmsResourceTranslatedJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsRoleResourcePermissionJoined> ViewCmsRoleResourcePermissionJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsSiteDocumentCount> ViewCmsSiteDocumentCounts { get; set; } = null!;
        public virtual DbSet<ViewCmsSiteRoleResourceUielementJoined> ViewCmsSiteRoleResourceUielementJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsTreeJoined> ViewCmsTreeJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsUser> ViewCmsUsers { get; set; } = null!;
        public virtual DbSet<ViewCmsUserDocument> ViewCmsUserDocuments { get; set; } = null!;
        public virtual DbSet<ViewCmsUserRoleJoined> ViewCmsUserRoleJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsUserRoleMembershipRole> ViewCmsUserRoleMembershipRoles { get; set; } = null!;
        public virtual DbSet<ViewCmsUserRoleMembershipRoleValidOnlyJoined> ViewCmsUserRoleMembershipRoleValidOnlyJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsUserSettingsRoleJoined> ViewCmsUserSettingsRoleJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsWebPartCategoryWebpartJoined> ViewCmsWebPartCategoryWebpartJoineds { get; set; } = null!;
        public virtual DbSet<ViewCmsWidgetCategoryWidgetJoined> ViewCmsWidgetCategoryWidgetJoineds { get; set; } = null!;
        public virtual DbSet<ViewComSkuoptionCategoryOptionCategoryJoined> ViewComSkuoptionCategoryOptionCategoryJoineds { get; set; } = null!;
        public virtual DbSet<ViewCommunityGroup> ViewCommunityGroups { get; set; } = null!;
        public virtual DbSet<ViewCommunityMember> ViewCommunityMembers { get; set; } = null!;
        public virtual DbSet<ViewForumsGroupForumPostJoined> ViewForumsGroupForumPostJoineds { get; set; } = null!;
        public virtual DbSet<ViewIntegrationTaskJoined> ViewIntegrationTaskJoineds { get; set; } = null!;
        public virtual DbSet<ViewMembershipMembershipUserJoined> ViewMembershipMembershipUserJoineds { get; set; } = null!;
        public virtual DbSet<ViewNewsletterSubscriptionsJoined> ViewNewsletterSubscriptionsJoineds { get; set; } = null!;
        public virtual DbSet<ViewOmAccountContactAccountJoined> ViewOmAccountContactAccountJoineds { get; set; } = null!;
        public virtual DbSet<ViewOmAccountContactContactJoined> ViewOmAccountContactContactJoineds { get; set; } = null!;
        public virtual DbSet<ViewOmAccountJoined> ViewOmAccountJoineds { get; set; } = null!;
        public virtual DbSet<ViewOmContactGroupMemberAccountJoined> ViewOmContactGroupMemberAccountJoineds { get; set; } = null!;
        public virtual DbSet<ViewPollAnswerCount> ViewPollAnswerCounts { get; set; } = null!;
        public virtual DbSet<ViewReportingCategoryReportJoined> ViewReportingCategoryReportJoineds { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source=94.232.174.176;Initial Catalog=ShoukouhPardis12DB;Integrated Security=False;Persist Security Info=False;User ID=ShoukouhPardis12DBAdmin;Password=ShoukouhPardis12DB@pass;Connect Timeout=60;Encrypt=False;Current Language=English;");
                var conStr = _configuration["ConnectionStrings:ArvanConnection"];
                //optionsBuilder.UseSqlServer("Data Source=94.101.189.165;Initial Catalog=ShoukouhPardis12DB;Integrated Security=False;Persist Security Info=False;User ID=ShoukouhPardis12DBAdmin;Password=ShoukouhPardis12DB@pass;Connect Timeout=60;Encrypt=False;Current Language=English;");
                optionsBuilder.UseSqlServer(conStr);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ShoukouhPardis12DBAdmin")
                .UseCollation("Latin1_General_CI_AS");

            modelBuilder.Entity<AnalyticsCampaign>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("Analytics_Campaign", "dbo");

                entity.HasIndex(e => e.CampaignScheduledTaskId, "IX_Analytics_Campaign_CampaignScheduledTaskID");

                entity.HasIndex(e => e.CampaignSiteId, "IX_Analytics_Campaign_CampaignSiteID");

                entity.Property(e => e.CampaignId).HasColumnName("CampaignID");

                entity.Property(e => e.CampaignDisplayName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CampaignGuid).HasColumnName("CampaignGUID");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CampaignScheduledTaskId).HasColumnName("CampaignScheduledTaskID");

                entity.Property(e => e.CampaignSiteId).HasColumnName("CampaignSiteID");

                entity.Property(e => e.CampaignUtmcode)
                    .HasMaxLength(200)
                    .HasColumnName("CampaignUTMCode");

                entity.HasOne(d => d.CampaignScheduledTask)
                    .WithMany(p => p.AnalyticsCampaigns)
                    .HasForeignKey(d => d.CampaignScheduledTaskId)
                    .HasConstraintName("FK_Analytics_Campaign_CampaignScheduledTaskID_ScheduledTask");

                entity.HasOne(d => d.CampaignSite)
                    .WithMany(p => p.AnalyticsCampaigns)
                    .HasForeignKey(d => d.CampaignSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_Campaign_StatisticsSiteID_CMS_Site");
            });

            modelBuilder.Entity<AnalyticsCampaignAsset>(entity =>
            {
                entity.HasKey(e => e.CampaignAssetId);

                entity.ToTable("Analytics_CampaignAsset", "dbo");

                entity.HasIndex(e => e.CampaignAssetCampaignId, "IX_Analytics_CampaignAsset_CampaignAssetCampaignID");

                entity.Property(e => e.CampaignAssetId).HasColumnName("CampaignAssetID");

                entity.Property(e => e.CampaignAssetCampaignId).HasColumnName("CampaignAssetCampaignID");

                entity.Property(e => e.CampaignAssetLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.CampaignAssetType)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.CampaignAssetCampaign)
                    .WithMany(p => p.AnalyticsCampaignAssets)
                    .HasForeignKey(d => d.CampaignAssetCampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_CampaignAsset_CampaignAssetCampaignID_Analytics_Campaign");
            });

            modelBuilder.Entity<AnalyticsCampaignAssetUrl>(entity =>
            {
                entity.HasKey(e => e.CampaignAssetUrlId);

                entity.ToTable("Analytics_CampaignAssetUrl", "dbo");

                entity.HasIndex(e => e.CampaignAssetUrlCampaignAssetId, "IX_Analytics_CampaignAssetUrl_CampaignAssetUrlCampaignAssetID");

                entity.Property(e => e.CampaignAssetUrlId).HasColumnName("CampaignAssetUrlID");

                entity.Property(e => e.CampaignAssetUrlCampaignAssetId).HasColumnName("CampaignAssetUrlCampaignAssetID");

                entity.Property(e => e.CampaignAssetUrlPageTitle)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CampaignAssetUrlTarget).HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.CampaignAssetUrlCampaignAsset)
                    .WithMany(p => p.AnalyticsCampaignAssetUrls)
                    .HasForeignKey(d => d.CampaignAssetUrlCampaignAssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_CampaignAssetUrl_CampaignAssetUrlCampaignAssetID_Analytics_CampaignAsset");
            });

            modelBuilder.Entity<AnalyticsCampaignConversion>(entity =>
            {
                entity.HasKey(e => e.CampaignConversionId);

                entity.ToTable("Analytics_CampaignConversion", "dbo");

                entity.HasIndex(e => e.CampaignConversionCampaignId, "IX_Analytics_CampaignConversion_CampaignConversionCampaignID");

                entity.Property(e => e.CampaignConversionId).HasColumnName("CampaignConversionID");

                entity.Property(e => e.CampaignConversionActivityType)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CampaignConversionCampaignId).HasColumnName("CampaignConversionCampaignID");

                entity.Property(e => e.CampaignConversionDisplayName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CampaignConversionItemId).HasColumnName("CampaignConversionItemID");

                entity.Property(e => e.CampaignConversionLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.CampaignConversionName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CampaignConversionUrl).HasColumnName("CampaignConversionURL");

                entity.HasOne(d => d.CampaignConversionCampaign)
                    .WithMany(p => p.AnalyticsCampaignConversions)
                    .HasForeignKey(d => d.CampaignConversionCampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_CampaignConversion_CampaignConversionCampaignID_Analytics_Campaign");
            });

            modelBuilder.Entity<AnalyticsCampaignConversionHit>(entity =>
            {
                entity.HasKey(e => e.CampaignConversionHitsId);

                entity.ToTable("Analytics_CampaignConversionHits", "dbo");

                entity.HasIndex(e => e.CampaignConversionHitsConversionId, "IX_Analytics_CampaignConversionHits_CampaignConversionHitsConversionID");

                entity.Property(e => e.CampaignConversionHitsId).HasColumnName("CampaignConversionHitsID");

                entity.Property(e => e.CampaignConversionHitsContentName).HasMaxLength(200);

                entity.Property(e => e.CampaignConversionHitsConversionId).HasColumnName("CampaignConversionHitsConversionID");

                entity.Property(e => e.CampaignConversionHitsSourceName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.CampaignConversionHitsConversion)
                    .WithMany(p => p.AnalyticsCampaignConversionHits)
                    .HasForeignKey(d => d.CampaignConversionHitsConversionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_CampaignConversionHits_CampaignConversionHitsConversionID_Analytics_CampaignConversion");
            });

            modelBuilder.Entity<AnalyticsCampaignObjective>(entity =>
            {
                entity.HasKey(e => e.CampaignObjectiveId);

                entity.ToTable("Analytics_CampaignObjective", "dbo");

                entity.HasIndex(e => e.CampaignObjectiveCampaignId, "CK_Analytics_CampaignObjective_CampaignObjectiveCampaignID")
                    .IsUnique();

                entity.HasIndex(e => e.CampaignObjectiveCampaignConversionId, "IX_Analytics_CampaignObjective_CampaignObjectiveCampaignConversionID");

                entity.Property(e => e.CampaignObjectiveId).HasColumnName("CampaignObjectiveID");

                entity.Property(e => e.CampaignObjectiveCampaignConversionId).HasColumnName("CampaignObjectiveCampaignConversionID");

                entity.Property(e => e.CampaignObjectiveCampaignId).HasColumnName("CampaignObjectiveCampaignID");

                entity.Property(e => e.CampaignObjectiveLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.HasOne(d => d.CampaignObjectiveCampaignConversion)
                    .WithMany(p => p.AnalyticsCampaignObjectives)
                    .HasForeignKey(d => d.CampaignObjectiveCampaignConversionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_CampaignObjective_CampaignObjectiveCampaignConversionID_Analytics_CampaignConversion");

                entity.HasOne(d => d.CampaignObjectiveCampaign)
                    .WithOne(p => p.AnalyticsCampaignObjective)
                    .HasForeignKey<AnalyticsCampaignObjective>(d => d.CampaignObjectiveCampaignId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_CampaignObjective_CampaignObjectiveCampaignID_Analytics_Campaign");
            });

            modelBuilder.Entity<AnalyticsConversion>(entity =>
            {
                entity.HasKey(e => e.ConversionId)
                    .HasName("PK_CMS_Conversion");

                entity.ToTable("Analytics_Conversion", "dbo");

                entity.HasIndex(e => e.ConversionSiteId, "IX_Analytics_Conversion_ConversionSiteID");

                entity.Property(e => e.ConversionId).HasColumnName("ConversionID");

                entity.Property(e => e.ConversionDisplayName).HasMaxLength(200);

                entity.Property(e => e.ConversionGuid).HasColumnName("ConversionGUID");

                entity.Property(e => e.ConversionName).HasMaxLength(200);

                entity.Property(e => e.ConversionSiteId).HasColumnName("ConversionSiteID");

                entity.HasOne(d => d.ConversionSite)
                    .WithMany(p => p.AnalyticsConversions)
                    .HasForeignKey(d => d.ConversionSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_Conversion_ConversionSiteID_CMS_Site");
            });

            modelBuilder.Entity<AnalyticsDayHit>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .IsClustered(false);

                entity.ToTable("Analytics_DayHits", "dbo");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime }, "IX_Analytics_DayHits_HitsStartTime_HitsEndTime")
                    .IsClustered();

                entity.HasIndex(e => e.HitsStatisticsId, "IX_Analytics_DayHits_HitsStatisticsID");

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsDayHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_DayHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<AnalyticsExitPage>(entity =>
            {
                entity.HasKey(e => e.SessionIdentificator);

                entity.ToTable("Analytics_ExitPages", "dbo");

                entity.HasIndex(e => e.ExitPageLastModified, "IX_Analytics_ExitPages_ExitPageLastModified");

                entity.Property(e => e.SessionIdentificator).HasMaxLength(200);

                entity.Property(e => e.ExitPageCulture).HasMaxLength(10);

                entity.Property(e => e.ExitPageNodeId).HasColumnName("ExitPageNodeID");

                entity.Property(e => e.ExitPageSiteId).HasColumnName("ExitPageSiteID");
            });

            modelBuilder.Entity<AnalyticsHourHit>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .IsClustered(false);

                entity.ToTable("Analytics_HourHits", "dbo");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime }, "IX_Analytics_HourHits_HitsStartTime_HitsEndTime")
                    .IsClustered();

                entity.HasIndex(e => e.HitsStatisticsId, "IX_Analytics_HourHits_HitsStatisticsID");

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsHourHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_HourHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<AnalyticsMonthHit>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .IsClustered(false);

                entity.ToTable("Analytics_MonthHits", "dbo");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime }, "IX_Analytics_MonthHits_HitsStartTime_HitsEndTime")
                    .IsClustered();

                entity.HasIndex(e => e.HitsStatisticsId, "IX_Analytics_MonthHits_HitsStatisticsID");

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsMonthHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_MonthHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<AnalyticsStatistic>(entity =>
            {
                entity.HasKey(e => e.StatisticsId)
                    .IsClustered(false);

                entity.ToTable("Analytics_Statistics", "dbo");

                entity.HasIndex(e => e.StatisticsCode, "IX_Analytics_Statistics_StatisticsCode_StatisticsSiteID_StatisticsObjectID_StatisticsObjectCulture")
                    .IsClustered();

                entity.HasIndex(e => e.StatisticsSiteId, "IX_Analytics_Statistics_StatisticsSiteID");

                entity.Property(e => e.StatisticsId).HasColumnName("StatisticsID");

                entity.Property(e => e.StatisticsCode)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatisticsObjectCulture)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StatisticsObjectId).HasColumnName("StatisticsObjectID");

                entity.Property(e => e.StatisticsObjectName)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StatisticsSiteId).HasColumnName("StatisticsSiteID");

                entity.HasOne(d => d.StatisticsSite)
                    .WithMany(p => p.AnalyticsStatistics)
                    .HasForeignKey(d => d.StatisticsSiteId)
                    .HasConstraintName("FK_Analytics_Statistics_StatisticsSiteID_CMS_Site");
            });

            modelBuilder.Entity<AnalyticsWeekHit>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .IsClustered(false);

                entity.ToTable("Analytics_WeekHits", "dbo");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime }, "IX_Analytics_WeekHits_HitsStartTime_HitsEndTime")
                    .IsClustered();

                entity.HasIndex(e => e.HitsStatisticsId, "IX_Analytics_WeekHits_HitsStatisticsID");

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsWeekHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_WeekHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<AnalyticsYearHit>(entity =>
            {
                entity.HasKey(e => e.HitsId)
                    .IsClustered(false);

                entity.ToTable("Analytics_YearHits", "dbo");

                entity.HasIndex(e => e.HitsStatisticsId, "IX_Analytics_WeekYearHits_HitsStatisticsID");

                entity.HasIndex(e => new { e.HitsStartTime, e.HitsEndTime }, "IX_Analytics_YearHits_HitsStartTime_HitsEndTime")
                    .IsClustered();

                entity.Property(e => e.HitsId).HasColumnName("HitsID");

                entity.Property(e => e.HitsStatisticsId).HasColumnName("HitsStatisticsID");

                entity.HasOne(d => d.HitsStatistics)
                    .WithMany(p => p.AnalyticsYearHits)
                    .HasForeignKey(d => d.HitsStatisticsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Analytics_YearHits_HitsStatisticsID_Analytics_Statistics");
            });

            modelBuilder.Entity<BadWordsWord>(entity =>
            {
                entity.HasKey(e => e.WordId)
                    .IsClustered(false);

                entity.ToTable("BadWords_Word", "dbo");

                entity.HasIndex(e => e.WordExpression, "IX_BadWords_Word_WordExpression")
                    .IsClustered();

                entity.HasIndex(e => e.WordIsGlobal, "IX_BadWords_Word_WordIsGlobal");

                entity.Property(e => e.WordId).HasColumnName("WordID");

                entity.Property(e => e.WordExpression)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WordGuid).HasColumnName("WordGUID");

                entity.Property(e => e.WordReplacement).HasMaxLength(200);

                entity.HasMany(d => d.Cultures)
                    .WithMany(p => p.Words)
                    .UsingEntity<Dictionary<string, object>>(
                        "BadWordsWordCulture",
                        l => l.HasOne<CmsCulture>().WithMany().HasForeignKey("CultureId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BadWords_WordCulture_CultureID_CMS_Culture"),
                        r => r.HasOne<BadWordsWord>().WithMany().HasForeignKey("WordId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BadWords_WordCulture_WordID_BadWords_Word"),
                        j =>
                        {
                            j.HasKey("WordId", "CultureId");

                            j.ToTable("BadWords_WordCulture", "dbo");

                            j.HasIndex(new[] { "CultureId" }, "IX_BadWords_WordCulture_CultureID");

                            j.IndexerProperty<int>("WordId").HasColumnName("WordID");

                            j.IndexerProperty<int>("CultureId").HasColumnName("CultureID");
                        });
            });

            modelBuilder.Entity<BlogComment>(entity =>
            {
                entity.HasKey(e => e.CommentId)
                    .IsClustered(false);

                entity.ToTable("Blog_Comment", "dbo");

                entity.HasIndex(e => e.CommentApprovedByUserId, "IX_Blog_Comment_CommentApprovedByUserID");

                entity.HasIndex(e => e.CommentDate, "IX_Blog_Comment_CommentDate")
                    .IsClustered();

                entity.HasIndex(e => e.CommentPostDocumentId, "IX_Blog_Comment_CommentPostDocumentID");

                entity.HasIndex(e => e.CommentUserId, "IX_Blog_Comment_CommentUserID");

                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.CommentApprovedByUserId).HasColumnName("CommentApprovedByUserID");

                entity.Property(e => e.CommentEmail).HasMaxLength(254);

                entity.Property(e => e.CommentGuid).HasColumnName("CommentGUID");

                entity.Property(e => e.CommentIsSpam).HasDefaultValueSql("((0))");

                entity.Property(e => e.CommentPostDocumentId).HasColumnName("CommentPostDocumentID");

                entity.Property(e => e.CommentUrl).HasMaxLength(450);

                entity.Property(e => e.CommentUserId).HasColumnName("CommentUserID");

                entity.Property(e => e.CommentUserName).HasMaxLength(200);

                entity.HasOne(d => d.CommentApprovedByUser)
                    .WithMany(p => p.BlogCommentCommentApprovedByUsers)
                    .HasForeignKey(d => d.CommentApprovedByUserId)
                    .HasConstraintName("FK_Blog_Comment_CommentApprovedByUserID_CMS_User");

                entity.HasOne(d => d.CommentPostDocument)
                    .WithMany(p => p.BlogComments)
                    .HasForeignKey(d => d.CommentPostDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Blog_Comment_CommentPostDocumentID_CMS_Document");

                entity.HasOne(d => d.CommentUser)
                    .WithMany(p => p.BlogCommentCommentUsers)
                    .HasForeignKey(d => d.CommentUserId)
                    .HasConstraintName("FK_Blog_Comment_CommentUserID_CMS_User");
            });

            modelBuilder.Entity<BlogPostSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("Blog_PostSubscription", "dbo");

                entity.HasIndex(e => e.SubscriptionPostDocumentId, "IX_Blog_PostSubscription_SubscriptionPostDocumentID");

                entity.HasIndex(e => e.SubscriptionUserId, "IX_Blog_PostSubscription_SubscriptionUserID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.SubscriptionApprovalHash).HasMaxLength(100);

                entity.Property(e => e.SubscriptionEmail).HasMaxLength(254);

                entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");

                entity.Property(e => e.SubscriptionPostDocumentId).HasColumnName("SubscriptionPostDocumentID");

                entity.Property(e => e.SubscriptionUserId).HasColumnName("SubscriptionUserID");

                entity.HasOne(d => d.SubscriptionPostDocument)
                    .WithMany(p => p.BlogPostSubscriptions)
                    .HasForeignKey(d => d.SubscriptionPostDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Blog_PostSubscription_SubscriptionPostDocumentID_CMS_Document");

                entity.HasOne(d => d.SubscriptionUser)
                    .WithMany(p => p.BlogPostSubscriptions)
                    .HasForeignKey(d => d.SubscriptionUserId)
                    .HasConstraintName("FK_Blog_PostSubscription_SubscriptionUserID_CMS_User");
            });

            modelBuilder.Entity<BoardBoard>(entity =>
            {
                entity.HasKey(e => e.BoardId);

                entity.ToTable("Board_Board", "dbo");

                entity.HasIndex(e => new { e.BoardDocumentId, e.BoardName }, "IX_Board_Board_BoardDocumentID_BoardName")
                    .IsUnique();

                entity.HasIndex(e => new { e.BoardGroupId, e.BoardName }, "IX_Board_Board_BoardGroupID_BoardName");

                entity.HasIndex(e => e.BoardSiteId, "IX_Board_Board_BoardSiteID");

                entity.HasIndex(e => new { e.BoardUserId, e.BoardName }, "IX_Board_Board_BoardUserID_BoardName");

                entity.Property(e => e.BoardId).HasColumnName("BoardID");

                entity.Property(e => e.BoardBaseUrl)
                    .HasMaxLength(450)
                    .HasColumnName("BoardBaseURL");

                entity.Property(e => e.BoardDisplayName).HasMaxLength(250);

                entity.Property(e => e.BoardDocumentId).HasColumnName("BoardDocumentID");

                entity.Property(e => e.BoardGroupId).HasColumnName("BoardGroupID");

                entity.Property(e => e.BoardGuid).HasColumnName("BoardGUID");

                entity.Property(e => e.BoardLastMessageUserName).HasMaxLength(250);

                entity.Property(e => e.BoardName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BoardOptInApprovalUrl)
                    .HasMaxLength(450)
                    .HasColumnName("BoardOptInApprovalURL");

                entity.Property(e => e.BoardRequireEmails).HasDefaultValueSql("((0))");

                entity.Property(e => e.BoardSiteId).HasColumnName("BoardSiteID");

                entity.Property(e => e.BoardUnsubscriptionUrl)
                    .HasMaxLength(450)
                    .HasColumnName("BoardUnsubscriptionURL");

                entity.Property(e => e.BoardUserId).HasColumnName("BoardUserID");

                entity.HasOne(d => d.BoardDocument)
                    .WithMany(p => p.BoardBoards)
                    .HasForeignKey(d => d.BoardDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Board_Board_BoardDocumentID_CMS_Document");

                entity.HasOne(d => d.BoardGroup)
                    .WithMany(p => p.BoardBoards)
                    .HasForeignKey(d => d.BoardGroupId)
                    .HasConstraintName("FK_Board_Board_BoardGroupID_Community_Group");

                entity.HasOne(d => d.BoardSite)
                    .WithMany(p => p.BoardBoards)
                    .HasForeignKey(d => d.BoardSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Board_Board_BoardSiteID_CMS_Site");

                entity.HasOne(d => d.BoardUser)
                    .WithMany(p => p.BoardBoards)
                    .HasForeignKey(d => d.BoardUserId)
                    .HasConstraintName("FK_Board_Board_BoardUserID_CMS_User");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Boards)
                    .UsingEntity<Dictionary<string, object>>(
                        "BoardRole",
                        l => l.HasOne<CmsRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Board_Role_RoleID_CMS_Role"),
                        r => r.HasOne<BoardBoard>().WithMany().HasForeignKey("BoardId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Board_Role_BoardID_Board_Board"),
                        j =>
                        {
                            j.HasKey("BoardId", "RoleId");

                            j.ToTable("Board_Role", "dbo");

                            j.HasIndex(new[] { "RoleId" }, "IX_Board_Role_RoleID");

                            j.IndexerProperty<int>("BoardId").HasColumnName("BoardID");

                            j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");
                        });

                entity.HasMany(d => d.Users)
                    .WithMany(p => p.Boards)
                    .UsingEntity<Dictionary<string, object>>(
                        "BoardModerator",
                        l => l.HasOne<CmsUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Board_Moderator_UserID_CMS_User"),
                        r => r.HasOne<BoardBoard>().WithMany().HasForeignKey("BoardId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Board_Moderator_BoardID_Board_Board"),
                        j =>
                        {
                            j.HasKey("BoardId", "UserId");

                            j.ToTable("Board_Moderator", "dbo");

                            j.HasIndex(new[] { "UserId" }, "IX_Board_Moderator_UserID");

                            j.IndexerProperty<int>("BoardId").HasColumnName("BoardID");

                            j.IndexerProperty<int>("UserId").HasColumnName("UserID");
                        });
            });

            modelBuilder.Entity<BoardMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .IsClustered(false);

                entity.ToTable("Board_Message", "dbo");

                entity.HasIndex(e => e.MessageApprovedByUserId, "IX_Board_Message_MessageApprovedByUserID");

                entity.HasIndex(e => new { e.MessageApproved, e.MessageIsSpam }, "IX_Board_Message_MessageApproved_MessageIsSpam");

                entity.HasIndex(e => new { e.MessageBoardId, e.MessageGuid }, "IX_Board_Message_MessageBoardID_MessageGUID")
                    .IsUnique();

                entity.HasIndex(e => e.MessageInserted, "IX_Board_Message_MessageInserted")
                    .IsClustered();

                entity.HasIndex(e => e.MessageUserId, "IX_Board_Message_MessageUserID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.MessageApprovedByUserId).HasColumnName("MessageApprovedByUserID");

                entity.Property(e => e.MessageAvatarGuid).HasColumnName("MessageAvatarGUID");

                entity.Property(e => e.MessageBoardId).HasColumnName("MessageBoardID");

                entity.Property(e => e.MessageEmail)
                    .HasMaxLength(254)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MessageGuid).HasColumnName("MessageGUID");

                entity.Property(e => e.MessageInserted).HasDefaultValueSql("('8/26/2008 12:14:50 PM')");

                entity.Property(e => e.MessageLastModified).HasDefaultValueSql("('8/26/2008 12:15:04 PM')");

                entity.Property(e => e.MessageText).HasDefaultValueSql("('')");

                entity.Property(e => e.MessageUrl)
                    .HasMaxLength(450)
                    .HasColumnName("MessageURL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MessageUserId).HasColumnName("MessageUserID");

                entity.Property(e => e.MessageUserInfo).HasDefaultValueSql("('')");

                entity.Property(e => e.MessageUserName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.MessageApprovedByUser)
                    .WithMany(p => p.BoardMessageMessageApprovedByUsers)
                    .HasForeignKey(d => d.MessageApprovedByUserId)
                    .HasConstraintName("FK_Board_Message_MessageApprovedByUserID_CMS_User");

                entity.HasOne(d => d.MessageBoard)
                    .WithMany(p => p.BoardMessagesNavigation)
                    .HasForeignKey(d => d.MessageBoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Board_Message_MessageBoardID_Board_Board");

                entity.HasOne(d => d.MessageUser)
                    .WithMany(p => p.BoardMessageMessageUsers)
                    .HasForeignKey(d => d.MessageUserId)
                    .HasConstraintName("FK_Board_Message_MessageUserID_CMS_User");
            });

            modelBuilder.Entity<BoardSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("Board_Subscription", "dbo");

                entity.HasIndex(e => e.SubscriptionBoardId, "IX_Board_Subscription_SubscriptionBoardID");

                entity.HasIndex(e => e.SubscriptionUserId, "IX_Board_Subscription_SubscriptionUserID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.SubscriptionApprovalHash).HasMaxLength(100);

                entity.Property(e => e.SubscriptionBoardId).HasColumnName("SubscriptionBoardID");

                entity.Property(e => e.SubscriptionEmail)
                    .HasMaxLength(254)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");

                entity.Property(e => e.SubscriptionUserId).HasColumnName("SubscriptionUserID");

                entity.HasOne(d => d.SubscriptionBoard)
                    .WithMany(p => p.BoardSubscriptions)
                    .HasForeignKey(d => d.SubscriptionBoardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Board_Subscription_SubscriptionBoardID_Board_Board");

                entity.HasOne(d => d.SubscriptionUser)
                    .WithMany(p => p.BoardSubscriptions)
                    .HasForeignKey(d => d.SubscriptionUserId)
                    .HasConstraintName("FK_Board_Subscription_SubscriptionUserID_CMS_User");
            });

            modelBuilder.Entity<ChatInitiatedChatRequest>(entity =>
            {
                entity.HasKey(e => e.InitiatedChatRequestId);

                entity.ToTable("Chat_InitiatedChatRequest", "dbo");

                entity.HasIndex(e => e.InitiatedChatRequestInitiatorChatUserId, "IX_Chat_InitiatedChatRequest_InitiatedChatRequestInitiatorChatUserID");

                entity.HasIndex(e => e.InitiatedChatRequestUserId, "IX_Chat_InitiatedChatRequest_InitiatedChatRequestUserID");

                entity.HasIndex(e => e.InitiatedChatRequestRoomId, "UQ_Chat_InitiatedChatRequest_RoomID")
                    .IsUnique();

                entity.HasIndex(e => new { e.InitiatedChatRequestUserId, e.InitiatedChatRequestContactId }, "UQ_Chat_InitiatedChatRequest_UserIDContactID")
                    .IsUnique();

                entity.Property(e => e.InitiatedChatRequestId).HasColumnName("InitiatedChatRequestID");

                entity.Property(e => e.InitiatedChatRequestContactId).HasColumnName("InitiatedChatRequestContactID");

                entity.Property(e => e.InitiatedChatRequestInitiatorChatUserId).HasColumnName("InitiatedChatRequestInitiatorChatUserID");

                entity.Property(e => e.InitiatedChatRequestInitiatorName).HasMaxLength(100);

                entity.Property(e => e.InitiatedChatRequestRoomId).HasColumnName("InitiatedChatRequestRoomID");

                entity.Property(e => e.InitiatedChatRequestState).HasDefaultValueSql("((1))");

                entity.Property(e => e.InitiatedChatRequestUserId).HasColumnName("InitiatedChatRequestUserID");

                entity.HasOne(d => d.InitiatedChatRequestInitiatorChatUser)
                    .WithMany(p => p.ChatInitiatedChatRequests)
                    .HasForeignKey(d => d.InitiatedChatRequestInitiatorChatUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_InitiatedChatRequest_Chat_User");

                entity.HasOne(d => d.InitiatedChatRequestRoom)
                    .WithOne(p => p.ChatInitiatedChatRequest)
                    .HasForeignKey<ChatInitiatedChatRequest>(d => d.InitiatedChatRequestRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_InitiatedChatRequest_Chat_Room");

                entity.HasOne(d => d.InitiatedChatRequestUser)
                    .WithMany(p => p.ChatInitiatedChatRequests)
                    .HasForeignKey(d => d.InitiatedChatRequestUserId)
                    .HasConstraintName("FK_Chat_InitiatedChatRequest_CMS_User");
            });

            modelBuilder.Entity<ChatMessage>(entity =>
            {
                entity.ToTable("Chat_Message", "dbo");

                entity.HasIndex(e => e.ChatMessageLastModified, "IX_Chat_Message_ChatMessageLastModified");

                entity.HasIndex(e => e.ChatMessageRecipientId, "IX_Chat_Message_ChatMessageRecipientID");

                entity.HasIndex(e => e.ChatMessageRoomId, "IX_Chat_Message_ChatMessageRoomID");

                entity.HasIndex(e => e.ChatMessageSystemMessageType, "IX_Chat_Message_ChatMessageSystemMessageType");

                entity.HasIndex(e => e.ChatMessageUserId, "IX_Chat_Message_ChatMessageUserID");

                entity.Property(e => e.ChatMessageId).HasColumnName("ChatMessageID");

                entity.Property(e => e.ChatMessageCreatedWhen).HasDefaultValueSql("('7/25/2011 2:47:18 PM')");

                entity.Property(e => e.ChatMessageIpaddress)
                    .HasColumnName("ChatMessageIPAddress")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChatMessageLastModified).HasDefaultValueSql("('8/3/2011 11:24:54 AM')");

                entity.Property(e => e.ChatMessageRecipientId).HasColumnName("ChatMessageRecipientID");

                entity.Property(e => e.ChatMessageRoomId).HasColumnName("ChatMessageRoomID");

                entity.Property(e => e.ChatMessageText).HasDefaultValueSql("('')");

                entity.Property(e => e.ChatMessageUserId).HasColumnName("ChatMessageUserID");

                entity.HasOne(d => d.ChatMessageRecipient)
                    .WithMany(p => p.ChatMessageChatMessageRecipients)
                    .HasForeignKey(d => d.ChatMessageRecipientId)
                    .HasConstraintName("FK_Chat_Message_Chat_User_Recipient");

                entity.HasOne(d => d.ChatMessageRoom)
                    .WithMany(p => p.ChatMessages)
                    .HasForeignKey(d => d.ChatMessageRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_Message_Chat_Room");

                entity.HasOne(d => d.ChatMessageUser)
                    .WithMany(p => p.ChatMessageChatMessageUsers)
                    .HasForeignKey(d => d.ChatMessageUserId)
                    .HasConstraintName("FK_Chat_Message_Chat_User_Sender");
            });

            modelBuilder.Entity<ChatNotification>(entity =>
            {
                entity.ToTable("Chat_Notification", "dbo");

                entity.HasIndex(e => e.ChatNotificationReceiverId, "IX_Chat_Notification_ChatNotificationReceiverID");

                entity.HasIndex(e => e.ChatNotificationRoomId, "IX_Chat_Notification_ChatNotificationRoomID");

                entity.HasIndex(e => e.ChatNotificationSenderId, "IX_Chat_Notification_ChatNotificationSenderID");

                entity.HasIndex(e => e.ChatNotificationSiteId, "IX_Chat_Notification_ChatNotificationSiteID");

                entity.Property(e => e.ChatNotificationId).HasColumnName("ChatNotificationID");

                entity.Property(e => e.ChatNotificationReceiverId).HasColumnName("ChatNotificationReceiverID");

                entity.Property(e => e.ChatNotificationRoomId).HasColumnName("ChatNotificationRoomID");

                entity.Property(e => e.ChatNotificationSenderId).HasColumnName("ChatNotificationSenderID");

                entity.Property(e => e.ChatNotificationSiteId).HasColumnName("ChatNotificationSiteID");

                entity.HasOne(d => d.ChatNotificationReceiver)
                    .WithMany(p => p.ChatNotificationChatNotificationReceivers)
                    .HasForeignKey(d => d.ChatNotificationReceiverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_Notification_Chat_User_Receiver");

                entity.HasOne(d => d.ChatNotificationRoom)
                    .WithMany(p => p.ChatNotifications)
                    .HasForeignKey(d => d.ChatNotificationRoomId)
                    .HasConstraintName("FK_Chat_Notification_Chat_Room");

                entity.HasOne(d => d.ChatNotificationSender)
                    .WithMany(p => p.ChatNotificationChatNotificationSenders)
                    .HasForeignKey(d => d.ChatNotificationSenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_Notification_Chat_User_Sender");

                entity.HasOne(d => d.ChatNotificationSite)
                    .WithMany(p => p.ChatNotifications)
                    .HasForeignKey(d => d.ChatNotificationSiteId)
                    .HasConstraintName("FK_Chat_Notification_CMS_Site");
            });

            modelBuilder.Entity<ChatOnlineSupport>(entity =>
            {
                entity.ToTable("Chat_OnlineSupport", "dbo");

                entity.HasIndex(e => e.ChatOnlineSupportChatUserId, "IX_Chat_OnlineSupport_ChatOnlineSupportChatUserID");

                entity.HasIndex(e => e.ChatOnlineSupportSiteId, "IX_Chat_OnlineSupport_SiteID");

                entity.HasIndex(e => new { e.ChatOnlineSupportChatUserId, e.ChatOnlineSupportSiteId }, "UQ_Chat_OnlineSupport_ChatUserID-SiteID")
                    .IsUnique();

                entity.Property(e => e.ChatOnlineSupportId).HasColumnName("ChatOnlineSupportID");

                entity.Property(e => e.ChatOnlineSupportChatUserId).HasColumnName("ChatOnlineSupportChatUserID");

                entity.Property(e => e.ChatOnlineSupportSiteId).HasColumnName("ChatOnlineSupportSiteID");

                entity.Property(e => e.ChatOnlineSupportToken).HasMaxLength(50);

                entity.HasOne(d => d.ChatOnlineSupportChatUser)
                    .WithMany(p => p.ChatOnlineSupports)
                    .HasForeignKey(d => d.ChatOnlineSupportChatUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_OnlineSupport_Chat_User");

                entity.HasOne(d => d.ChatOnlineSupportSite)
                    .WithMany(p => p.ChatOnlineSupports)
                    .HasForeignKey(d => d.ChatOnlineSupportSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_OnlineSupport_CMS_Site");
            });

            modelBuilder.Entity<ChatOnlineUser>(entity =>
            {
                entity.ToTable("Chat_OnlineUser", "dbo");

                entity.HasIndex(e => e.ChatOnlineUserChatUserId, "IX_Chat_OnlineUser_ChatOnlineUserChatUserID");

                entity.HasIndex(e => e.ChatOnlineUserSiteId, "IX_Chat_OnlineUser_SiteID");

                entity.HasIndex(e => new { e.ChatOnlineUserChatUserId, e.ChatOnlineUserSiteId }, "UQ_Chat_OnlineUser_SiteID-ChatUserID")
                    .IsUnique();

                entity.Property(e => e.ChatOnlineUserId).HasColumnName("ChatOnlineUserID");

                entity.Property(e => e.ChatOnlineUserChatUserId).HasColumnName("ChatOnlineUserChatUserID");

                entity.Property(e => e.ChatOnlineUserSiteId).HasColumnName("ChatOnlineUserSiteID");

                entity.Property(e => e.ChatOnlineUserToken).HasMaxLength(50);

                entity.HasOne(d => d.ChatOnlineUserChatUser)
                    .WithMany(p => p.ChatOnlineUsers)
                    .HasForeignKey(d => d.ChatOnlineUserChatUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_OnlineUser_Chat_User");

                entity.HasOne(d => d.ChatOnlineUserSite)
                    .WithMany(p => p.ChatOnlineUsers)
                    .HasForeignKey(d => d.ChatOnlineUserSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_OnlineUser_CMS_Site");
            });

            modelBuilder.Entity<ChatPopupWindowSetting>(entity =>
            {
                entity.HasKey(e => e.ChatPopupWindowSettingsId);

                entity.ToTable("Chat_PopupWindowSettings", "dbo");

                entity.Property(e => e.ChatPopupWindowSettingsId).HasColumnName("ChatPopupWindowSettingsID");

                entity.Property(e => e.ErrorClearTransformationName).HasMaxLength(255);

                entity.Property(e => e.ErrorTransformationName).HasMaxLength(255);

                entity.Property(e => e.MessageTransformationName).HasMaxLength(255);

                entity.Property(e => e.UserTransformationName).HasMaxLength(255);
            });

            modelBuilder.Entity<ChatRoom>(entity =>
            {
                entity.ToTable("Chat_Room", "dbo");

                entity.HasIndex(e => e.ChatRoomCreatedByChatUserId, "IX_Chat_Room_ChatRoomCreatedByChatUserID");

                entity.HasIndex(e => e.ChatRoomEnabled, "IX_Chat_Room_Enabled");

                entity.HasIndex(e => e.ChatRoomIsSupport, "IX_Chat_Room_IsSupport");

                entity.HasIndex(e => e.ChatRoomSiteId, "IX_Chat_Room_SiteID");

                entity.Property(e => e.ChatRoomId).HasColumnName("ChatRoomID");

                entity.Property(e => e.ChatRoomCreatedByChatUserId).HasColumnName("ChatRoomCreatedByChatUserID");

                entity.Property(e => e.ChatRoomDescription).HasMaxLength(500);

                entity.Property(e => e.ChatRoomDisplayName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChatRoomGuid).HasColumnName("ChatRoomGUID");

                entity.Property(e => e.ChatRoomLastModification).HasDefaultValueSql("('10/19/2011 12:16:33 PM')");

                entity.Property(e => e.ChatRoomName).HasMaxLength(100);

                entity.Property(e => e.ChatRoomPassword).HasMaxLength(100);

                entity.Property(e => e.ChatRoomPrivateStateLastModification).HasDefaultValueSql("('1/30/2012 4:36:47 PM')");

                entity.Property(e => e.ChatRoomSiteId).HasColumnName("ChatRoomSiteID");

                entity.HasOne(d => d.ChatRoomCreatedByChatUser)
                    .WithMany(p => p.ChatRooms)
                    .HasForeignKey(d => d.ChatRoomCreatedByChatUserId)
                    .HasConstraintName("FK_Chat_Room_Chat_User");

                entity.HasOne(d => d.ChatRoomSite)
                    .WithMany(p => p.ChatRooms)
                    .HasForeignKey(d => d.ChatRoomSiteId)
                    .HasConstraintName("FK_Chat_Room_CMS_Site");
            });

            modelBuilder.Entity<ChatRoomUser>(entity =>
            {
                entity.ToTable("Chat_RoomUser", "dbo");

                entity.HasIndex(e => e.ChatRoomUserChatUserId, "IX_Chat_RoomUser_ChatRoomUserChatUserID");

                entity.HasIndex(e => e.ChatRoomUserRoomId, "IX_Chat_RoomUser_ChatRoomUserRoomID");

                entity.HasIndex(e => new { e.ChatRoomUserRoomId, e.ChatRoomUserChatUserId }, "UQ_Chat_RoomUser_RoomID-ChatUserID")
                    .IsUnique();

                entity.Property(e => e.ChatRoomUserId).HasColumnName("ChatRoomUserID");

                entity.Property(e => e.ChatRoomUserChatUserId).HasColumnName("ChatRoomUserChatUserID");

                entity.Property(e => e.ChatRoomUserLastModification).HasDefaultValueSql("('11/10/2011 3:29:00 PM')");

                entity.Property(e => e.ChatRoomUserRoomId).HasColumnName("ChatRoomUserRoomID");

                entity.HasOne(d => d.ChatRoomUserChatUser)
                    .WithMany(p => p.ChatRoomUsers)
                    .HasForeignKey(d => d.ChatRoomUserChatUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_RoomUser_Chat_User");

                entity.HasOne(d => d.ChatRoomUserRoom)
                    .WithMany(p => p.ChatRoomUsers)
                    .HasForeignKey(d => d.ChatRoomUserRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_RoomUser_Chat_Room");
            });

            modelBuilder.Entity<ChatSupportCannedResponse>(entity =>
            {
                entity.ToTable("Chat_SupportCannedResponse", "dbo");

                entity.HasIndex(e => e.ChatSupportCannedResponseChatUserId, "IX_Chat_SupportCannedResponse_ChatSupportCannedResponseChatUserID");

                entity.HasIndex(e => e.ChatSupportCannedResponseSiteId, "IX_Chat_SupportCannedResponse_ChatSupportCannedResponseSiteID");

                entity.Property(e => e.ChatSupportCannedResponseId).HasColumnName("ChatSupportCannedResponseID");

                entity.Property(e => e.ChatSupportCannedResponseChatUserId).HasColumnName("ChatSupportCannedResponseChatUserID");

                entity.Property(e => e.ChatSupportCannedResponseName).HasMaxLength(100);

                entity.Property(e => e.ChatSupportCannedResponseSiteId).HasColumnName("ChatSupportCannedResponseSiteID");

                entity.Property(e => e.ChatSupportCannedResponseTagName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChatSupportCannedResponseText).HasMaxLength(500);

                entity.HasOne(d => d.ChatSupportCannedResponseChatUser)
                    .WithMany(p => p.ChatSupportCannedResponses)
                    .HasForeignKey(d => d.ChatSupportCannedResponseChatUserId)
                    .HasConstraintName("FK_Chat_SupportCannedResponse_Chat_User");

                entity.HasOne(d => d.ChatSupportCannedResponseSite)
                    .WithMany(p => p.ChatSupportCannedResponses)
                    .HasForeignKey(d => d.ChatSupportCannedResponseSiteId)
                    .HasConstraintName("FK_Chat_SupportCannedResponse_CMS_Site");
            });

            modelBuilder.Entity<ChatSupportTakenRoom>(entity =>
            {
                entity.ToTable("Chat_SupportTakenRoom", "dbo");

                entity.HasIndex(e => e.ChatSupportTakenRoomChatUserId, "IX_Chat_SupportTakenRoom_ChatSupportTakenRoomChatUserID");

                entity.HasIndex(e => e.ChatSupportTakenRoomRoomId, "IX_Chat_SupportTakenRoom_ChatSupportTakenRoomRoomID");

                entity.Property(e => e.ChatSupportTakenRoomId).HasColumnName("ChatSupportTakenRoomID");

                entity.Property(e => e.ChatSupportTakenRoomChatUserId).HasColumnName("ChatSupportTakenRoomChatUserID");

                entity.Property(e => e.ChatSupportTakenRoomLastModification).HasDefaultValueSql("('4/16/2012 5:11:30 PM')");

                entity.Property(e => e.ChatSupportTakenRoomRoomId).HasColumnName("ChatSupportTakenRoomRoomID");

                entity.HasOne(d => d.ChatSupportTakenRoomChatUser)
                    .WithMany(p => p.ChatSupportTakenRooms)
                    .HasForeignKey(d => d.ChatSupportTakenRoomChatUserId)
                    .HasConstraintName("FK_Chat_SupportTakenRoom_Chat_User");

                entity.HasOne(d => d.ChatSupportTakenRoomRoom)
                    .WithMany(p => p.ChatSupportTakenRooms)
                    .HasForeignKey(d => d.ChatSupportTakenRoomRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chat_SupportTakenRoom_Chat_Room");
            });

            modelBuilder.Entity<ChatUser>(entity =>
            {
                entity.ToTable("Chat_User", "dbo");

                entity.HasIndex(e => e.ChatUserUserId, "IX_Chat_User_UserID");

                entity.Property(e => e.ChatUserId).HasColumnName("ChatUserID");

                entity.Property(e => e.ChatUserLastModification).HasDefaultValueSql("('2/20/2012 2:02:00 PM')");

                entity.Property(e => e.ChatUserNickname)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ChatUserUserId).HasColumnName("ChatUserUserID");

                entity.HasOne(d => d.ChatUserUser)
                    .WithMany(p => p.ChatUsers)
                    .HasForeignKey(d => d.ChatUserUserId)
                    .HasConstraintName("FK_Chat_User_CMS_User");
            });

            modelBuilder.Entity<CiFileMetadatum>(entity =>
            {
                entity.HasKey(e => e.FileMetadataId);

                entity.ToTable("CI_FileMetadata", "dbo");

                entity.HasIndex(e => e.FileLocation, "UQ_CI_FileMetadata_FileLocation")
                    .IsUnique();

                entity.Property(e => e.FileMetadataId).HasColumnName("FileMetadataID");

                entity.Property(e => e.FileHash)
                    .HasMaxLength(32)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FileLocation)
                    .HasMaxLength(260)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CiMigration>(entity =>
            {
                entity.HasKey(e => e.MigrationId);

                entity.ToTable("CI_Migration", "dbo");

                entity.HasIndex(e => e.MigrationName, "IX_CI_Migration_MigrationName")
                    .IsUnique();

                entity.Property(e => e.MigrationId).HasColumnName("MigrationID");

                entity.Property(e => e.DateApplied)
                    .HasPrecision(3)
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.MigrationName).HasMaxLength(255);
            });

            modelBuilder.Entity<CmsAbuseReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .IsClustered(false);

                entity.ToTable("CMS_AbuseReport", "dbo");

                entity.HasIndex(e => e.ReportSiteId, "IX_CMS_AbuseReport_ReportSiteID");

                entity.HasIndex(e => e.ReportStatus, "IX_CMS_AbuseReport_ReportStatus");

                entity.HasIndex(e => e.ReportUserId, "IX_CMS_AbuseReport_ReportUserID");

                entity.HasIndex(e => e.ReportWhen, "IX_CMS_AbuseReport_ReportWhen")
                    .IsClustered();

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ReportComment).HasDefaultValueSql("('')");

                entity.Property(e => e.ReportCulture)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportGuid).HasColumnName("ReportGUID");

                entity.Property(e => e.ReportObjectId).HasColumnName("ReportObjectID");

                entity.Property(e => e.ReportObjectType).HasMaxLength(100);

                entity.Property(e => e.ReportSiteId).HasColumnName("ReportSiteID");

                entity.Property(e => e.ReportTitle)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportUrl)
                    .HasMaxLength(1000)
                    .HasColumnName("ReportURL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportUserId).HasColumnName("ReportUserID");

                entity.Property(e => e.ReportWhen).HasDefaultValueSql("('9/11/2008 4:32:15 PM')");

                entity.HasOne(d => d.ReportSite)
                    .WithMany(p => p.CmsAbuseReports)
                    .HasForeignKey(d => d.ReportSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_AbuseReport_ReportSiteID_CMS_Site");

                entity.HasOne(d => d.ReportUser)
                    .WithMany(p => p.CmsAbuseReports)
                    .HasForeignKey(d => d.ReportUserId)
                    .HasConstraintName("FK_CMS_AbuseReport_ReportUserID_CMS_User");
            });

            modelBuilder.Entity<CmsAcl>(entity =>
            {
                entity.HasKey(e => e.Aclid);

                entity.ToTable("CMS_ACL", "dbo");

                entity.HasIndex(e => e.AclinheritedAcls, "IX_CMS_ACL_ACLInheritedACLs");

                entity.HasIndex(e => e.AclsiteId, "IX_CMS_ACL_ACLSiteID");

                entity.Property(e => e.Aclid).HasColumnName("ACLID");

                entity.Property(e => e.Aclguid).HasColumnName("ACLGUID");

                entity.Property(e => e.AclinheritedAcls)
                    .HasColumnName("ACLInheritedACLs")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AcllastModified)
                    .HasColumnName("ACLLastModified")
                    .HasDefaultValueSql("('10/30/2008 9:17:31 AM')");

                entity.Property(e => e.AclsiteId).HasColumnName("ACLSiteID");

                entity.HasOne(d => d.Aclsite)
                    .WithMany(p => p.CmsAcls)
                    .HasForeignKey(d => d.AclsiteId)
                    .HasConstraintName("FK_CMS_ACL_ACLSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsAclitem>(entity =>
            {
                entity.HasKey(e => e.AclitemId);

                entity.ToTable("CMS_ACLItem", "dbo");

                entity.HasIndex(e => e.Aclid, "IX_CMS_ACLItem_ACLID");

                entity.HasIndex(e => e.LastModifiedByUserId, "IX_CMS_ACLItem_LastModifiedByUserID");

                entity.HasIndex(e => e.RoleId, "IX_CMS_ACLItem_RoleID");

                entity.HasIndex(e => e.UserId, "IX_CMS_ACLItem_UserID");

                entity.Property(e => e.AclitemId).HasColumnName("ACLItemID");

                entity.Property(e => e.Aclid).HasColumnName("ACLID");

                entity.Property(e => e.AclitemGuid).HasColumnName("ACLItemGUID");

                entity.Property(e => e.LastModifiedByUserId).HasColumnName("LastModifiedByUserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Acl)
                    .WithMany(p => p.CmsAclitems)
                    .HasForeignKey(d => d.Aclid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ACLItem_ACLID_CMS_ACL");

                entity.HasOne(d => d.LastModifiedByUser)
                    .WithMany(p => p.CmsAclitemLastModifiedByUsers)
                    .HasForeignKey(d => d.LastModifiedByUserId)
                    .HasConstraintName("FK_CMS_ACLItem_LastModifiedByUserID_CMS_User");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsAclitems)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_CMS_ACLItem_RoleID_CMS_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsAclitemUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CMS_ACLItem_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsAlternativeForm>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("CMS_AlternativeForm", "dbo");

                entity.HasIndex(e => new { e.FormClassId, e.FormName }, "IX_CMS_AlternativeForm_FormClassID_FormName");

                entity.HasIndex(e => e.FormCoupledClassId, "IX_CMS_AlternativeForm_FormCoupledClassID");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormClassId).HasColumnName("FormClassID");

                entity.Property(e => e.FormCoupledClassId).HasColumnName("FormCoupledClassID");

                entity.Property(e => e.FormCustomizedColumns).HasMaxLength(400);

                entity.Property(e => e.FormDisplayName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormGuid).HasColumnName("FormGUID");

                entity.Property(e => e.FormHideNewParentFields).HasDefaultValueSql("((0))");

                entity.Property(e => e.FormIsCustom).HasDefaultValueSql("((0))");

                entity.Property(e => e.FormLayoutType).HasMaxLength(50);

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormVersionGuid)
                    .HasMaxLength(50)
                    .HasColumnName("FormVersionGUID");

                entity.HasOne(d => d.FormClass)
                    .WithMany(p => p.CmsAlternativeFormFormClasses)
                    .HasForeignKey(d => d.FormClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_AlternativeForm_FormClassID_CMS_Class");

                entity.HasOne(d => d.FormCoupledClass)
                    .WithMany(p => p.CmsAlternativeFormFormCoupledClasses)
                    .HasForeignKey(d => d.FormCoupledClassId)
                    .HasConstraintName("FK_CMS_AlternativeForm_FormCoupledClassID_CMS_Class");
            });

            modelBuilder.Entity<CmsAlternativeUrl>(entity =>
            {
                entity.HasKey(e => e.AlternativeUrlId);

                entity.ToTable("CMS_AlternativeUrl", "dbo");

                entity.HasIndex(e => e.AlternativeUrlDocumentId, "IX_CMS_AlternativeUrl_AlternativeUrlDocumentID");

                entity.HasIndex(e => new { e.AlternativeUrlSiteId, e.AlternativeUrlUrl }, "IX_CMS_AlternativeUrl_AlternativeUrlSiteID_AlternativeUrlUrl")
                    .IsUnique();

                entity.Property(e => e.AlternativeUrlId).HasColumnName("AlternativeUrlID");

                entity.Property(e => e.AlternativeUrlDocumentId).HasColumnName("AlternativeUrlDocumentID");

                entity.Property(e => e.AlternativeUrlGuid).HasColumnName("AlternativeUrlGUID");

                entity.Property(e => e.AlternativeUrlLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.AlternativeUrlSiteId).HasColumnName("AlternativeUrlSiteID");

                entity.Property(e => e.AlternativeUrlUrl).HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.AlternativeUrlDocument)
                    .WithMany(p => p.CmsAlternativeUrls)
                    .HasForeignKey(d => d.AlternativeUrlDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_AlternativeUrl_CMS_Document");

                entity.HasOne(d => d.AlternativeUrlSite)
                    .WithMany(p => p.CmsAlternativeUrls)
                    .HasForeignKey(d => d.AlternativeUrlSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_AlternativeUrl_CMS_Site");
            });

            modelBuilder.Entity<CmsAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId)
                    .IsClustered(false);

                entity.ToTable("CMS_Attachment", "dbo");

                entity.HasIndex(e => e.AttachmentDocumentId, "IX_CMS_Attachment_AttachmentDocumentID");

                entity.HasIndex(e => new { e.AttachmentDocumentId, e.AttachmentName, e.AttachmentIsUnsorted, e.AttachmentOrder }, "IX_CMS_Attachment_AttachmentDocumentID_AttachmentIsUnsorted_AttachmentName_AttachmentOrder")
                    .IsClustered();

                entity.HasIndex(e => new { e.AttachmentGuid, e.AttachmentSiteId }, "IX_CMS_Attachment_AttachmentGUID_AttachmentSiteID");

                entity.HasIndex(e => new { e.AttachmentIsUnsorted, e.AttachmentGroupGuid, e.AttachmentFormGuid, e.AttachmentOrder }, "IX_CMS_Attachment_AttachmentIsUnsorted_AttachmentGroupGUID_AttachmentFormGUID_AttachmentOrder");

                entity.HasIndex(e => e.AttachmentSiteId, "IX_CMS_Attachment_AttachmentSiteID");

                entity.HasIndex(e => e.AttachmentVariantParentId, "IX_CMS_Attachment_AttachmentVariantParentID");

                entity.HasIndex(e => new { e.AttachmentVariantDefinitionIdentifier, e.AttachmentVariantParentId }, "IX_CMS_Attachment_AttachmentVariantParentID_AttachmentVariantDefinitionIdentifier")
                    .IsUnique()
                    .HasFilter("([AttachmentVariantDefinitionIdentifier] IS NOT NULL AND [AttachmentVariantParentID] IS NOT NULL)");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentDocumentId).HasColumnName("AttachmentDocumentID");

                entity.Property(e => e.AttachmentExtension).HasMaxLength(50);

                entity.Property(e => e.AttachmentFormGuid).HasColumnName("AttachmentFormGUID");

                entity.Property(e => e.AttachmentGroupGuid).HasColumnName("AttachmentGroupGUID");

                entity.Property(e => e.AttachmentGuid).HasColumnName("AttachmentGUID");

                entity.Property(e => e.AttachmentHash).HasMaxLength(32);

                entity.Property(e => e.AttachmentMimeType).HasMaxLength(100);

                entity.Property(e => e.AttachmentName).HasMaxLength(255);

                entity.Property(e => e.AttachmentSiteId).HasColumnName("AttachmentSiteID");

                entity.Property(e => e.AttachmentTitle).HasMaxLength(250);

                entity.Property(e => e.AttachmentVariantDefinitionIdentifier).HasMaxLength(50);

                entity.Property(e => e.AttachmentVariantParentId).HasColumnName("AttachmentVariantParentID");

                entity.HasOne(d => d.AttachmentDocument)
                    .WithMany(p => p.CmsAttachments)
                    .HasForeignKey(d => d.AttachmentDocumentId)
                    .HasConstraintName("FK_CMS_Attachment_AttachmentDocumentID_CMS_Document");

                entity.HasOne(d => d.AttachmentSite)
                    .WithMany(p => p.CmsAttachments)
                    .HasForeignKey(d => d.AttachmentSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Attachment_AttachmentSiteID_CMS_Site");

                entity.HasOne(d => d.AttachmentVariantParent)
                    .WithMany(p => p.InverseAttachmentVariantParent)
                    .HasForeignKey(d => d.AttachmentVariantParentId)
                    .HasConstraintName("FK_CMS_Attachment_AttachmentVariantParentID_CMS_Attachment");
            });

            modelBuilder.Entity<CmsAttachmentHistory>(entity =>
            {
                entity.HasKey(e => e.AttachmentHistoryId)
                    .IsClustered(false);

                entity.ToTable("CMS_AttachmentHistory", "dbo");

                entity.HasIndex(e => new { e.AttachmentDocumentId, e.AttachmentName }, "IX_CMS_AttachmentHistory_AttachmentDocumentID_AttachmentName")
                    .IsClustered();

                entity.HasIndex(e => e.AttachmentGuid, "IX_CMS_AttachmentHistory_AttachmentGUID");

                entity.HasIndex(e => new { e.AttachmentIsUnsorted, e.AttachmentGroupGuid, e.AttachmentOrder }, "IX_CMS_AttachmentHistory_AttachmentIsUnsorted_AttachmentGroupGUID_AttachmentOrder");

                entity.HasIndex(e => e.AttachmentSiteId, "IX_CMS_AttachmentHistory_AttachmentSiteID");

                entity.HasIndex(e => e.AttachmentVariantParentId, "IX_CMS_AttachmentHistory_AttachmentVariantParentID");

                entity.HasIndex(e => new { e.AttachmentVariantDefinitionIdentifier, e.AttachmentVariantParentId }, "IX_CMS_AttachmentHistory_AttachmentVariantParentID_AttachmentVariantDefinitionIdentifier")
                    .IsUnique()
                    .HasFilter("([AttachmentVariantDefinitionIdentifier] IS NOT NULL AND [AttachmentVariantParentID] IS NOT NULL)");

                entity.Property(e => e.AttachmentHistoryId).HasColumnName("AttachmentHistoryID");

                entity.Property(e => e.AttachmentDocumentId).HasColumnName("AttachmentDocumentID");

                entity.Property(e => e.AttachmentExtension).HasMaxLength(50);

                entity.Property(e => e.AttachmentGroupGuid).HasColumnName("AttachmentGroupGUID");

                entity.Property(e => e.AttachmentGuid).HasColumnName("AttachmentGUID");

                entity.Property(e => e.AttachmentHash).HasMaxLength(32);

                entity.Property(e => e.AttachmentHistoryGuid).HasColumnName("AttachmentHistoryGUID");

                entity.Property(e => e.AttachmentMimeType).HasMaxLength(100);

                entity.Property(e => e.AttachmentName).HasMaxLength(255);

                entity.Property(e => e.AttachmentSiteId).HasColumnName("AttachmentSiteID");

                entity.Property(e => e.AttachmentTitle).HasMaxLength(250);

                entity.Property(e => e.AttachmentVariantDefinitionIdentifier).HasMaxLength(50);

                entity.Property(e => e.AttachmentVariantParentId).HasColumnName("AttachmentVariantParentID");

                entity.HasOne(d => d.AttachmentSite)
                    .WithMany(p => p.CmsAttachmentHistories)
                    .HasForeignKey(d => d.AttachmentSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_AttachmentHistory_AttachmentSiteID_CMS_Site");

                entity.HasOne(d => d.AttachmentVariantParent)
                    .WithMany(p => p.InverseAttachmentVariantParent)
                    .HasForeignKey(d => d.AttachmentVariantParentId)
                    .HasConstraintName("FK_CMS_AttachmentHistory_AttachmentVariantParentID_CMS_AttachmentHistory");
            });

            modelBuilder.Entity<CmsAutomationHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("CMS_AutomationHistory", "dbo");

                entity.HasIndex(e => e.HistoryApprovedByUserId, "IX_CMS_AutomationHistory_HistoryApprovedByUserID");

                entity.HasIndex(e => e.HistoryApprovedWhen, "IX_CMS_AutomationHistory_HistoryApprovedWhen");

                entity.HasIndex(e => e.HistoryStateId, "IX_CMS_AutomationHistory_HistoryStateID");

                entity.HasIndex(e => e.HistoryStepId, "IX_CMS_AutomationHistory_HistoryStepID");

                entity.HasIndex(e => e.HistoryTargetStepId, "IX_CMS_AutomationHistory_HistoryTargetStepID");

                entity.HasIndex(e => e.HistoryWorkflowId, "IX_CMS_AutomationHistory_HistoryWorkflowID");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.HistoryApprovedByUserId).HasColumnName("HistoryApprovedByUserID");

                entity.Property(e => e.HistoryRejected).HasDefaultValueSql("((0))");

                entity.Property(e => e.HistoryStateId).HasColumnName("HistoryStateID");

                entity.Property(e => e.HistoryStepDisplayName)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HistoryStepId).HasColumnName("HistoryStepID");

                entity.Property(e => e.HistoryStepName).HasMaxLength(440);

                entity.Property(e => e.HistoryTargetStepDisplayName).HasMaxLength(450);

                entity.Property(e => e.HistoryTargetStepId).HasColumnName("HistoryTargetStepID");

                entity.Property(e => e.HistoryTargetStepName).HasMaxLength(440);

                entity.Property(e => e.HistoryWorkflowId).HasColumnName("HistoryWorkflowID");

                entity.HasOne(d => d.HistoryApprovedByUser)
                    .WithMany(p => p.CmsAutomationHistories)
                    .HasForeignKey(d => d.HistoryApprovedByUserId)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryApprovedByUserID");

                entity.HasOne(d => d.HistoryState)
                    .WithMany(p => p.CmsAutomationHistories)
                    .HasForeignKey(d => d.HistoryStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryStateID");

                entity.HasOne(d => d.HistoryStep)
                    .WithMany(p => p.CmsAutomationHistoryHistorySteps)
                    .HasForeignKey(d => d.HistoryStepId)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryStepID");

                entity.HasOne(d => d.HistoryTargetStep)
                    .WithMany(p => p.CmsAutomationHistoryHistoryTargetSteps)
                    .HasForeignKey(d => d.HistoryTargetStepId)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryTargetStepID");

                entity.HasOne(d => d.HistoryWorkflow)
                    .WithMany(p => p.CmsAutomationHistories)
                    .HasForeignKey(d => d.HistoryWorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_AutomationHistory_HistoryWorkflowID");
            });

            modelBuilder.Entity<CmsAutomationState>(entity =>
            {
                entity.HasKey(e => e.StateId);

                entity.ToTable("CMS_AutomationState", "dbo");

                entity.HasIndex(e => new { e.StateObjectId, e.StateObjectType }, "IX_CMS_AutomationState_StateObjectID_StateObjectType");

                entity.HasIndex(e => e.StateSiteId, "IX_CMS_AutomationState_StateSiteID");

                entity.HasIndex(e => e.StateStepId, "IX_CMS_AutomationState_StateStepID");

                entity.HasIndex(e => e.StateUserId, "IX_CMS_AutomationState_StateUserID");

                entity.HasIndex(e => e.StateWorkflowId, "IX_CMS_AutomationState_StateWorkflowID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.StateActionStatus).HasMaxLength(450);

                entity.Property(e => e.StateGuid).HasColumnName("StateGUID");

                entity.Property(e => e.StateObjectId).HasColumnName("StateObjectID");

                entity.Property(e => e.StateObjectType).HasMaxLength(100);

                entity.Property(e => e.StateSiteId).HasColumnName("StateSiteID");

                entity.Property(e => e.StateStepId).HasColumnName("StateStepID");

                entity.Property(e => e.StateUserId).HasColumnName("StateUserID");

                entity.Property(e => e.StateWorkflowId).HasColumnName("StateWorkflowID");

                entity.HasOne(d => d.StateSite)
                    .WithMany(p => p.CmsAutomationStates)
                    .HasForeignKey(d => d.StateSiteId)
                    .HasConstraintName("FK_CMS_AutomationState_StateSiteID_CMS_Site");

                entity.HasOne(d => d.StateStep)
                    .WithMany(p => p.CmsAutomationStates)
                    .HasForeignKey(d => d.StateStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_AutomationState_StateStepID");

                entity.HasOne(d => d.StateUser)
                    .WithMany(p => p.CmsAutomationStates)
                    .HasForeignKey(d => d.StateUserId)
                    .HasConstraintName("FK_CMS_AutomationState_StateUserID_CMS_User");

                entity.HasOne(d => d.StateWorkflow)
                    .WithMany(p => p.CmsAutomationStates)
                    .HasForeignKey(d => d.StateWorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_AutomationState_StateWorkflowID");
            });

            modelBuilder.Entity<CmsAvatar>(entity =>
            {
                entity.HasKey(e => e.AvatarId)
                    .IsClustered(false);

                entity.ToTable("CMS_Avatar", "dbo");

                entity.HasIndex(e => e.AvatarGuid, "IX_CMS_Avatar_AvatarGUID");

                entity.HasIndex(e => e.AvatarName, "IX_CMS_Avatar_AvatarName")
                    .IsClustered();

                entity.HasIndex(e => new { e.AvatarType, e.AvatarIsCustom }, "IX_CMS_Avatar_AvatarType_AvatarIsCustom");

                entity.Property(e => e.AvatarId).HasColumnName("AvatarID");

                entity.Property(e => e.AvatarFileExtension).HasMaxLength(10);

                entity.Property(e => e.AvatarFileName).HasMaxLength(200);

                entity.Property(e => e.AvatarGuid).HasColumnName("AvatarGUID");

                entity.Property(e => e.AvatarMimeType).HasMaxLength(100);

                entity.Property(e => e.AvatarName).HasMaxLength(200);

                entity.Property(e => e.AvatarType).HasMaxLength(50);

                entity.Property(e => e.DefaultFemaleUserAvatar).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultGroupAvatar).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultMaleUserAvatar).HasDefaultValueSql("((0))");

                entity.Property(e => e.DefaultUserAvatar).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CmsBadge>(entity =>
            {
                entity.HasKey(e => e.BadgeId)
                    .IsClustered(false);

                entity.ToTable("CMS_Badge", "dbo");

                entity.HasIndex(e => e.BadgeTopLimit, "IX_CMS_Badge_BadgeTopLimit")
                    .IsClustered();

                entity.Property(e => e.BadgeId).HasColumnName("BadgeID");

                entity.Property(e => e.BadgeDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BadgeGuid).HasColumnName("BadgeGUID");

                entity.Property(e => e.BadgeImageUrl)
                    .HasMaxLength(200)
                    .HasColumnName("BadgeImageURL");

                entity.Property(e => e.BadgeLastModified).HasDefaultValueSql("('9/25/2008 5:07:55 PM')");

                entity.Property(e => e.BadgeName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CmsBannedIp>(entity =>
            {
                entity.HasKey(e => e.IpaddressId)
                    .IsClustered(false);

                entity.ToTable("CMS_BannedIP", "dbo");

                entity.HasIndex(e => e.IpaddressSiteId, "IX_CMS_BannedIP_IPAddressSiteID");

                entity.HasIndex(e => new { e.Ipaddress, e.IpaddressSiteId }, "IX_CMS_BannedIP_IPAddressSiteID_IPAddress")
                    .IsClustered();

                entity.Property(e => e.IpaddressId).HasColumnName("IPAddressID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.IpaddressAllowOverride).HasColumnName("IPAddressAllowOverride");

                entity.Property(e => e.IpaddressAllowed).HasColumnName("IPAddressAllowed");

                entity.Property(e => e.IpaddressBanEnabled)
                    .HasColumnName("IPAddressBanEnabled")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IpaddressBanReason)
                    .HasMaxLength(450)
                    .HasColumnName("IPAddressBanReason");

                entity.Property(e => e.IpaddressBanType)
                    .HasMaxLength(100)
                    .HasColumnName("IPAddressBanType");

                entity.Property(e => e.IpaddressGuid).HasColumnName("IPAddressGUID");

                entity.Property(e => e.IpaddressLastModified).HasColumnName("IPAddressLastModified");

                entity.Property(e => e.IpaddressRegular)
                    .HasMaxLength(200)
                    .HasColumnName("IPAddressRegular");

                entity.Property(e => e.IpaddressSiteId).HasColumnName("IPAddressSiteID");

                entity.HasOne(d => d.IpaddressSite)
                    .WithMany(p => p.CmsBannedIps)
                    .HasForeignKey(d => d.IpaddressSiteId)
                    .HasConstraintName("FK_CMS_BannedIP_IPAddressSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsBanner>(entity =>
            {
                entity.HasKey(e => e.BannerId);

                entity.ToTable("CMS_Banner", "dbo");

                entity.HasIndex(e => e.BannerCategoryId, "IX_CMS_Banner_BannerCategoryID");

                entity.HasIndex(e => e.BannerSiteId, "IX_CMS_Banner_BannerSiteID");

                entity.Property(e => e.BannerId).HasColumnName("BannerID");

                entity.Property(e => e.BannerCategoryId).HasColumnName("BannerCategoryID");

                entity.Property(e => e.BannerContent).HasDefaultValueSql("(N'')");

                entity.Property(e => e.BannerDisplayName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BannerEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BannerLastModified).HasDefaultValueSql("('1/1/1970 12:00:00 AM')");

                entity.Property(e => e.BannerName)
                    .HasMaxLength(256)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BannerSiteId).HasColumnName("BannerSiteID");

                entity.Property(e => e.BannerType).HasDefaultValueSql("((2))");

                entity.Property(e => e.BannerUrl)
                    .HasMaxLength(2083)
                    .HasColumnName("BannerURL");

                entity.Property(e => e.BannerWeight).HasDefaultValueSql("((5))");

                entity.HasOne(d => d.BannerCategory)
                    .WithMany(p => p.CmsBanners)
                    .HasForeignKey(d => d.BannerCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Banner_CMS_BannerCategory");

                entity.HasOne(d => d.BannerSite)
                    .WithMany(p => p.CmsBanners)
                    .HasForeignKey(d => d.BannerSiteId)
                    .HasConstraintName("FK_CMS_Banner_CMS_Site");
            });

            modelBuilder.Entity<CmsBannerCategory>(entity =>
            {
                entity.HasKey(e => e.BannerCategoryId)
                    .HasName("PK__CMS_BannerCategory");

                entity.ToTable("CMS_BannerCategory", "dbo");

                entity.HasIndex(e => new { e.BannerCategoryName, e.BannerCategorySiteId }, "IX_CMS_BannerCategory_BannerCategoryName_BannerCategorySiteID")
                    .IsUnique();

                entity.HasIndex(e => e.BannerCategorySiteId, "IX_CMS_BannerCategory_BannerCategorySiteID");

                entity.Property(e => e.BannerCategoryId).HasColumnName("BannerCategoryID");

                entity.Property(e => e.BannerCategoryDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BannerCategoryEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BannerCategoryLastModified).HasDefaultValueSql("('1/1/1970 12:00:00 AM')");

                entity.Property(e => e.BannerCategoryName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BannerCategorySiteId).HasColumnName("BannerCategorySiteID");

                entity.HasOne(d => d.BannerCategorySite)
                    .WithMany(p => p.CmsBannerCategories)
                    .HasForeignKey(d => d.BannerCategorySiteId)
                    .HasConstraintName("FK_CMS_BannerCategory_CMS_Site");
            });

            modelBuilder.Entity<CmsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .IsClustered(false);

                entity.ToTable("CMS_Category", "dbo");

                entity.HasIndex(e => new { e.CategoryDisplayName, e.CategoryEnabled }, "IX_CMS_Category_CategoryDisplayName_CategoryEnabled")
                    .IsClustered();

                entity.HasIndex(e => e.CategorySiteId, "IX_CMS_Category_CategorySiteID");

                entity.HasIndex(e => e.CategoryUserId, "IX_CMS_Category_CategoryUserID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDisplayName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryIdpath)
                    .HasMaxLength(450)
                    .HasColumnName("CategoryIDPath");

                entity.Property(e => e.CategoryName).HasMaxLength(250);

                entity.Property(e => e.CategoryNamePath).HasMaxLength(1500);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategorySiteId).HasColumnName("CategorySiteID");

                entity.Property(e => e.CategoryUserId).HasColumnName("CategoryUserID");

                entity.HasOne(d => d.CategorySite)
                    .WithMany(p => p.CmsCategories)
                    .HasForeignKey(d => d.CategorySiteId)
                    .HasConstraintName("FK_CMS_Category_CategorySiteID_CMS_Site");

                entity.HasOne(d => d.CategoryUser)
                    .WithMany(p => p.CmsCategories)
                    .HasForeignKey(d => d.CategoryUserId)
                    .HasConstraintName("FK_CMS_Category_CategoryUserID_CMS_User");
            });

            modelBuilder.Entity<CmsClass>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .IsClustered(false);

                entity.ToTable("CMS_Class", "dbo");

                entity.HasIndex(e => e.ClassDefaultPageTemplateId, "IX_CMS_Class_ClassDefaultPageTemplateID");

                entity.HasIndex(e => new { e.ClassId, e.ClassName, e.ClassDisplayName }, "IX_CMS_Class_ClassID_ClassName_ClassDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.ClassName, "IX_CMS_Class_ClassName")
                    .IsUnique();

                entity.HasIndex(e => new { e.ClassName, e.ClassGuid }, "IX_CMS_Class_ClassName_ClassGUID");

                entity.HasIndex(e => e.ClassPageTemplateCategoryId, "IX_CMS_Class_ClassPageTemplateCategoryID");

                entity.HasIndex(e => e.ClassResourceId, "IX_CMS_Class_ClassResourceID");

                entity.HasIndex(e => new { e.ClassShowAsSystemTable, e.ClassIsCustomTable, e.ClassIsCoupledClass, e.ClassIsDocumentType }, "IX_CMS_Class_ClassShowAsSystemTable_ClassIsCustomTable_ClassIsCoupledClass_ClassIsDocumentType");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.ClassConnectionString).HasMaxLength(100);

                entity.Property(e => e.ClassCreateSku).HasColumnName("ClassCreateSKU");

                entity.Property(e => e.ClassCustomizedColumns).HasMaxLength(400);

                entity.Property(e => e.ClassDefaultObjectType).HasMaxLength(100);

                entity.Property(e => e.ClassDefaultPageTemplateId).HasColumnName("ClassDefaultPageTemplateID");

                entity.Property(e => e.ClassDisplayName).HasMaxLength(100);

                entity.Property(e => e.ClassEditingPageUrl).HasMaxLength(450);

                entity.Property(e => e.ClassFormLayoutType).HasMaxLength(50);

                entity.Property(e => e.ClassGuid).HasColumnName("ClassGUID");

                entity.Property(e => e.ClassIconClass).HasMaxLength(200);

                entity.Property(e => e.ClassInheritsFromClassId).HasColumnName("ClassInheritsFromClassID");

                entity.Property(e => e.ClassIsContentOnly).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClassListPageUrl).HasMaxLength(450);

                entity.Property(e => e.ClassName).HasMaxLength(100);

                entity.Property(e => e.ClassNewPageUrl).HasMaxLength(450);

                entity.Property(e => e.ClassNodeAliasSource).HasMaxLength(100);

                entity.Property(e => e.ClassNodeNameSource).HasMaxLength(100);

                entity.Property(e => e.ClassPageTemplateCategoryId).HasColumnName("ClassPageTemplateCategoryID");

                entity.Property(e => e.ClassPreviewPageUrl).HasMaxLength(450);

                entity.Property(e => e.ClassResourceId).HasColumnName("ClassResourceID");

                entity.Property(e => e.ClassSearchContentColumn).HasMaxLength(200);

                entity.Property(e => e.ClassSearchCreationDateColumn).HasMaxLength(200);

                entity.Property(e => e.ClassSearchImageColumn).HasMaxLength(200);

                entity.Property(e => e.ClassSearchTitleColumn).HasMaxLength(200);

                entity.Property(e => e.ClassShowColumns).HasMaxLength(1000);

                entity.Property(e => e.ClassSkudefaultDepartmentId).HasColumnName("ClassSKUDefaultDepartmentID");

                entity.Property(e => e.ClassSkudefaultDepartmentName)
                    .HasMaxLength(200)
                    .HasColumnName("ClassSKUDefaultDepartmentName");

                entity.Property(e => e.ClassSkudefaultProductType)
                    .HasMaxLength(50)
                    .HasColumnName("ClassSKUDefaultProductType");

                entity.Property(e => e.ClassSkumappings).HasColumnName("ClassSKUMappings");

                entity.Property(e => e.ClassTableName).HasMaxLength(100);

                entity.Property(e => e.ClassUrlpattern)
                    .HasMaxLength(200)
                    .HasColumnName("ClassURLPattern");

                entity.Property(e => e.ClassVersionGuid)
                    .HasMaxLength(50)
                    .HasColumnName("ClassVersionGUID");

                entity.Property(e => e.ClassViewPageUrl).HasMaxLength(450);

                entity.HasOne(d => d.ClassDefaultPageTemplate)
                    .WithMany(p => p.CmsClasses)
                    .HasForeignKey(d => d.ClassDefaultPageTemplateId)
                    .HasConstraintName("FK_CMS_Class_ClassDefaultPageTemplateID_CMS_PageTemplate");

                entity.HasOne(d => d.ClassPageTemplateCategory)
                    .WithMany(p => p.CmsClasses)
                    .HasForeignKey(d => d.ClassPageTemplateCategoryId)
                    .HasConstraintName("FK_CMS_Class_ClassPageTemplateCategoryID_CMS_PageTemplateCategory");

                entity.HasOne(d => d.ClassResource)
                    .WithMany(p => p.CmsClasses)
                    .HasForeignKey(d => d.ClassResourceId)
                    .HasConstraintName("FK_CMS_Class_ClassResourceID_CMS_Resource");

                entity.HasMany(d => d.ChildClasses)
                    .WithMany(p => p.ParentClasses)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsAllowedChildClass",
                        l => l.HasOne<CmsClass>().WithMany().HasForeignKey("ChildClassId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_AllowedChildClasses_ChildClassID_CMS_Class"),
                        r => r.HasOne<CmsClass>().WithMany().HasForeignKey("ParentClassId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_AllowedChildClasses_ParentClassID_CMS_Class"),
                        j =>
                        {
                            j.HasKey("ParentClassId", "ChildClassId");

                            j.ToTable("CMS_AllowedChildClasses", "dbo");

                            j.HasIndex(new[] { "ChildClassId" }, "IX_CMS_AllowedChildClasses_ChildClassID");

                            j.IndexerProperty<int>("ParentClassId").HasColumnName("ParentClassID");

                            j.IndexerProperty<int>("ChildClassId").HasColumnName("ChildClassID");
                        });

                entity.HasMany(d => d.ParentClasses)
                    .WithMany(p => p.ChildClasses)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsAllowedChildClass",
                        l => l.HasOne<CmsClass>().WithMany().HasForeignKey("ParentClassId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_AllowedChildClasses_ParentClassID_CMS_Class"),
                        r => r.HasOne<CmsClass>().WithMany().HasForeignKey("ChildClassId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_AllowedChildClasses_ChildClassID_CMS_Class"),
                        j =>
                        {
                            j.HasKey("ParentClassId", "ChildClassId");

                            j.ToTable("CMS_AllowedChildClasses", "dbo");

                            j.HasIndex(new[] { "ChildClassId" }, "IX_CMS_AllowedChildClasses_ChildClassID");

                            j.IndexerProperty<int>("ParentClassId").HasColumnName("ParentClassID");

                            j.IndexerProperty<int>("ChildClassId").HasColumnName("ChildClassID");
                        });

                entity.HasMany(d => d.Sites)
                    .WithMany(p => p.Classes)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsClassSite",
                        l => l.HasOne<CmsSite>().WithMany().HasForeignKey("SiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_Class_SiteID_CMS_Site"),
                        r => r.HasOne<CmsClass>().WithMany().HasForeignKey("ClassId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_Class_ClassID_CMS_Class"),
                        j =>
                        {
                            j.HasKey("ClassId", "SiteId");

                            j.ToTable("CMS_ClassSite", "dbo");

                            j.HasIndex(new[] { "SiteId" }, "IX_CMS_ClassSite_SiteID");

                            j.IndexerProperty<int>("ClassId").HasColumnName("ClassID");

                            j.IndexerProperty<int>("SiteId").HasColumnName("SiteID");
                        });
            });

            modelBuilder.Entity<CmsConsent>(entity =>
            {
                entity.HasKey(e => e.ConsentId);

                entity.ToTable("CMS_Consent", "dbo");

                entity.Property(e => e.ConsentId).HasColumnName("ConsentID");

                entity.Property(e => e.ConsentContent).HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConsentDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConsentHash)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConsentLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.ConsentName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CmsConsentAgreement>(entity =>
            {
                entity.HasKey(e => e.ConsentAgreementId);

                entity.ToTable("CMS_ConsentAgreement", "dbo");

                entity.HasIndex(e => new { e.ConsentAgreementContactId, e.ConsentAgreementConsentId }, "IX_CMS_ConsentAgreement_ConsentAgreementContactID_ConsentAgreementConsentID");

                entity.Property(e => e.ConsentAgreementId).HasColumnName("ConsentAgreementID");

                entity.Property(e => e.ConsentAgreementConsentHash).HasMaxLength(100);

                entity.Property(e => e.ConsentAgreementConsentId).HasColumnName("ConsentAgreementConsentID");

                entity.Property(e => e.ConsentAgreementContactId).HasColumnName("ConsentAgreementContactID");

                entity.Property(e => e.ConsentAgreementTime).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.HasOne(d => d.ConsentAgreementConsent)
                    .WithMany(p => p.CmsConsentAgreements)
                    .HasForeignKey(d => d.ConsentAgreementConsentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ConsentAgreement_ConsentAgreementConsentID_CMS_Consent");

                entity.HasOne(d => d.ConsentAgreementContact)
                    .WithMany(p => p.CmsConsentAgreements)
                    .HasForeignKey(d => d.ConsentAgreementContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ConsentAgreement_ConsentAgreementContactID_OM_Contact");
            });

            modelBuilder.Entity<CmsConsentArchive>(entity =>
            {
                entity.HasKey(e => e.ConsentArchiveId);

                entity.ToTable("CMS_ConsentArchive", "dbo");

                entity.HasIndex(e => e.ConsentArchiveConsentId, "IX_ConsentArchive_ConsentArchiveConsentID");

                entity.Property(e => e.ConsentArchiveId).HasColumnName("ConsentArchiveID");

                entity.Property(e => e.ConsentArchiveConsentId).HasColumnName("ConsentArchiveConsentID");

                entity.Property(e => e.ConsentArchiveContent).HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConsentArchiveHash)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ConsentArchiveLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.HasOne(d => d.ConsentArchiveConsent)
                    .WithMany(p => p.CmsConsentArchives)
                    .HasForeignKey(d => d.ConsentArchiveConsentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ConsentArchive_ConsentArchiveConsentID_CMS_Consent");
            });

            modelBuilder.Entity<CmsCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .IsClustered(false);

                entity.ToTable("CMS_Country", "dbo");

                entity.HasIndex(e => e.CountryDisplayName, "IX_CMS_Country_CountryDisplayName")
                    .IsClustered();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryGuid).HasColumnName("CountryGUID");

                entity.Property(e => e.CountryLastModified).HasDefaultValueSql("('11/14/2013 1:43:04 PM')");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryThreeLetterCode).HasMaxLength(3);

                entity.Property(e => e.CountryTwoLetterCode).HasMaxLength(2);
            });

            modelBuilder.Entity<CmsCssStylesheet>(entity =>
            {
                entity.HasKey(e => e.StylesheetId)
                    .IsClustered(false);

                entity.ToTable("CMS_CssStylesheet", "dbo");

                entity.HasIndex(e => e.StylesheetDisplayName, "IX_CMS_CssStylesheet_StylesheetDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.StylesheetName, "IX_CMS_CssStylesheet_StylesheetName");

                entity.Property(e => e.StylesheetId).HasColumnName("StylesheetID");

                entity.Property(e => e.StylesheetDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StylesheetDynamicLanguage)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('plaincss')");

                entity.Property(e => e.StylesheetGuid).HasColumnName("StylesheetGUID");

                entity.Property(e => e.StylesheetName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StylesheetVersionGuid).HasColumnName("StylesheetVersionGUID");

                entity.HasMany(d => d.Sites)
                    .WithMany(p => p.Stylesheets)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsCssStylesheetSite",
                        l => l.HasOne<CmsSite>().WithMany().HasForeignKey("SiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_CssStylesheetSite_SiteID_CMS_Site"),
                        r => r.HasOne<CmsCssStylesheet>().WithMany().HasForeignKey("StylesheetId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_CssStylesheetSite_StylesheetID_CMS_CssStylesheet"),
                        j =>
                        {
                            j.HasKey("StylesheetId", "SiteId");

                            j.ToTable("CMS_CssStylesheetSite", "dbo");

                            j.HasIndex(new[] { "SiteId" }, "IX_CMS_CssStylesheetSite_SiteID");

                            j.IndexerProperty<int>("StylesheetId").HasColumnName("StylesheetID");

                            j.IndexerProperty<int>("SiteId").HasColumnName("SiteID");
                        });
            });

            modelBuilder.Entity<CmsCulture>(entity =>
            {
                entity.HasKey(e => e.CultureId)
                    .IsClustered(false);

                entity.ToTable("CMS_Culture", "dbo");

                entity.HasIndex(e => e.CultureAlias, "IX_CMS_CulturAlias");

                entity.HasIndex(e => e.CultureCode, "IX_CMS_Culture_CultureCode");

                entity.HasIndex(e => e.CultureName, "IX_CMS_Culture_CultureName")
                    .IsClustered();

                entity.Property(e => e.CultureId).HasColumnName("CultureID");

                entity.Property(e => e.CultureAlias).HasMaxLength(100);

                entity.Property(e => e.CultureCode).HasMaxLength(50);

                entity.Property(e => e.CultureGuid).HasColumnName("CultureGUID");

                entity.Property(e => e.CultureIsUiculture)
                    .HasColumnName("CultureIsUICulture")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CultureName).HasMaxLength(200);

                entity.Property(e => e.CultureShortName).HasMaxLength(200);
            });

            modelBuilder.Entity<CmsDeviceProfile>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.ToTable("CMS_DeviceProfile", "dbo");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ProfileDisplayName).HasMaxLength(200);

                entity.Property(e => e.ProfileEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProfileGuid).HasColumnName("ProfileGUID");

                entity.Property(e => e.ProfileName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CmsDeviceProfileLayout>(entity =>
            {
                entity.HasKey(e => e.DeviceProfileLayoutId);

                entity.ToTable("CMS_DeviceProfileLayout", "dbo");

                entity.HasIndex(e => e.DeviceProfileId, "IX_CMS_DeviceProfileLayout_DeviceProfileID");

                entity.HasIndex(e => e.SourceLayoutId, "IX_CMS_DeviceProfileLayout_SourceLayoutID");

                entity.HasIndex(e => e.TargetLayoutId, "IX_CMS_DeviceProfileLayout_TargetLayoutID");

                entity.Property(e => e.DeviceProfileLayoutId).HasColumnName("DeviceProfileLayoutID");

                entity.Property(e => e.DeviceProfileId).HasColumnName("DeviceProfileID");

                entity.Property(e => e.DeviceProfileLayoutGuid).HasColumnName("DeviceProfileLayoutGUID");

                entity.Property(e => e.SourceLayoutId).HasColumnName("SourceLayoutID");

                entity.Property(e => e.TargetLayoutId).HasColumnName("TargetLayoutID");

                entity.HasOne(d => d.DeviceProfile)
                    .WithMany(p => p.CmsDeviceProfileLayouts)
                    .HasForeignKey(d => d.DeviceProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_DeviceProfileLayout_DeviceProfileID_CMS_DeviceProfile");

                entity.HasOne(d => d.SourceLayout)
                    .WithMany(p => p.CmsDeviceProfileLayoutSourceLayouts)
                    .HasForeignKey(d => d.SourceLayoutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_DeviceProfileLayout_SourceLayoutID_CMS_Layout");

                entity.HasOne(d => d.TargetLayout)
                    .WithMany(p => p.CmsDeviceProfileLayoutTargetLayouts)
                    .HasForeignKey(d => d.TargetLayoutId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_DeviceProfileLayout_TargetLayoutID_CMS_Layout");
            });

            modelBuilder.Entity<CmsDocument>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("CMS_Document", "dbo");

                entity.HasIndex(e => e.DocumentCheckedOutByUserId, "IX_CMS_Document_DocumentCheckedOutByUserID");

                entity.HasIndex(e => e.DocumentCheckedOutVersionHistoryId, "IX_CMS_Document_DocumentCheckedOutVersionHistoryID");

                entity.HasIndex(e => e.DocumentCreatedByUserId, "IX_CMS_Document_DocumentCreatedByUserID");

                entity.HasIndex(e => e.DocumentCulture, "IX_CMS_Document_DocumentCulture");

                entity.HasIndex(e => new { e.DocumentForeignKeyValue, e.DocumentId, e.DocumentNodeId }, "IX_CMS_Document_DocumentForeignKeyValue_DocumentID_DocumentNodeID");

                entity.HasIndex(e => e.DocumentModifiedByUserId, "IX_CMS_Document_DocumentModifiedByUserID");

                entity.HasIndex(e => new { e.DocumentNodeId, e.DocumentId, e.DocumentCulture }, "IX_CMS_Document_DocumentNodeID_DocumentID_DocumentCulture")
                    .IsUnique();

                entity.HasIndex(e => e.DocumentPageTemplateId, "IX_CMS_Document_DocumentPageTemplateID");

                entity.HasIndex(e => e.DocumentPublishedVersionHistoryId, "IX_CMS_Document_DocumentPublishedVersionHistoryID");

                entity.HasIndex(e => e.DocumentTagGroupId, "IX_CMS_Document_DocumentTagGroupID");

                entity.HasIndex(e => e.DocumentUrlPath, "IX_CMS_Document_DocumentUrlPath_DocumentID_DocumentNodeID");

                entity.HasIndex(e => new { e.DocumentWildcardRule, e.DocumentPriority }, "IX_CMS_Document_DocumentWildcardRule_DocumentPriority");

                entity.HasIndex(e => e.DocumentWorkflowStepId, "IX_CMS_Document_DocumentWorkflowStepID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentAbtestConfiguration).HasColumnName("DocumentABTestConfiguration");

                entity.Property(e => e.DocumentCanBePublished)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DocumentCheckedOutByUserId).HasColumnName("DocumentCheckedOutByUserID");

                entity.Property(e => e.DocumentCheckedOutVersionHistoryId).HasColumnName("DocumentCheckedOutVersionHistoryID");

                entity.Property(e => e.DocumentConversionValue).HasMaxLength(100);

                entity.Property(e => e.DocumentCreatedByUserId).HasColumnName("DocumentCreatedByUserID");

                entity.Property(e => e.DocumentCulture).HasMaxLength(10);

                entity.Property(e => e.DocumentExtensions).HasMaxLength(100);

                entity.Property(e => e.DocumentGuid).HasColumnName("DocumentGUID");

                entity.Property(e => e.DocumentHash).HasMaxLength(32);

                entity.Property(e => e.DocumentInheritsStylesheet)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DocumentLastVersionNumber).HasMaxLength(50);

                entity.Property(e => e.DocumentMenuCaption).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuClass).HasMaxLength(100);

                entity.Property(e => e.DocumentMenuClassHighlighted).HasMaxLength(100);

                entity.Property(e => e.DocumentMenuItemImage).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemImageHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemLeftImage).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemLeftImageHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemRightImage).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemRightImageHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuJavascript).HasMaxLength(450);

                entity.Property(e => e.DocumentMenuRedirectToFirstChild).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentMenuRedirectUrl).HasMaxLength(450);

                entity.Property(e => e.DocumentMenuStyle).HasMaxLength(100);

                entity.Property(e => e.DocumentMenuStyleHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentModifiedByUserId).HasColumnName("DocumentModifiedByUserID");

                entity.Property(e => e.DocumentName).HasMaxLength(100);

                entity.Property(e => e.DocumentNamePath).HasMaxLength(1500);

                entity.Property(e => e.DocumentNodeId).HasColumnName("DocumentNodeID");

                entity.Property(e => e.DocumentPageTemplateId).HasColumnName("DocumentPageTemplateID");

                entity.Property(e => e.DocumentPublishedVersionHistoryId).HasColumnName("DocumentPublishedVersionHistoryID");

                entity.Property(e => e.DocumentSitemapSettings).HasMaxLength(100);

                entity.Property(e => e.DocumentSkudescription).HasColumnName("DocumentSKUDescription");

                entity.Property(e => e.DocumentSkuname)
                    .HasMaxLength(440)
                    .HasColumnName("DocumentSKUName");

                entity.Property(e => e.DocumentSkushortDescription).HasColumnName("DocumentSKUShortDescription");

                entity.Property(e => e.DocumentStylesheetId).HasColumnName("DocumentStylesheetID");

                entity.Property(e => e.DocumentTagGroupId).HasColumnName("DocumentTagGroupID");

                entity.Property(e => e.DocumentTrackConversionName).HasMaxLength(200);

                entity.Property(e => e.DocumentType).HasMaxLength(50);

                entity.Property(e => e.DocumentUseCustomExtensions).HasDefaultValueSql("((0))");

                entity.Property(e => e.DocumentWildcardRule).HasMaxLength(440);

                entity.Property(e => e.DocumentWorkflowActionStatus).HasMaxLength(450);

                entity.Property(e => e.DocumentWorkflowCycleGuid).HasColumnName("DocumentWorkflowCycleGUID");

                entity.Property(e => e.DocumentWorkflowStepId).HasColumnName("DocumentWorkflowStepID");

                entity.HasOne(d => d.DocumentCheckedOutByUser)
                    .WithMany(p => p.CmsDocumentDocumentCheckedOutByUsers)
                    .HasForeignKey(d => d.DocumentCheckedOutByUserId)
                    .HasConstraintName("FK_CMS_Document_DocumentCheckedOutByUserID_CMS_User");

                entity.HasOne(d => d.DocumentCheckedOutVersionHistory)
                    .WithMany(p => p.CmsDocumentDocumentCheckedOutVersionHistories)
                    .HasForeignKey(d => d.DocumentCheckedOutVersionHistoryId)
                    .HasConstraintName("FK_CMS_Document_DocumentCheckedOutVersionHistoryID_CMS_VersionHistory");

                entity.HasOne(d => d.DocumentCreatedByUser)
                    .WithMany(p => p.CmsDocumentDocumentCreatedByUsers)
                    .HasForeignKey(d => d.DocumentCreatedByUserId)
                    .HasConstraintName("FK_CMS_Document_DocumentCreatedByUserID_CMS_User");

                entity.HasOne(d => d.DocumentModifiedByUser)
                    .WithMany(p => p.CmsDocumentDocumentModifiedByUsers)
                    .HasForeignKey(d => d.DocumentModifiedByUserId)
                    .HasConstraintName("FK_CMS_Document_DocumentModifiedByUserID_CMS_User");

                entity.HasOne(d => d.DocumentNode)
                    .WithMany(p => p.CmsDocuments)
                    .HasForeignKey(d => d.DocumentNodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Document_DocumentNodeID_CMS_Tree");

                entity.HasOne(d => d.DocumentPageTemplate)
                    .WithMany(p => p.CmsDocuments)
                    .HasForeignKey(d => d.DocumentPageTemplateId)
                    .HasConstraintName("FK_CMS_Document_DocumentPageTemplateID_CMS_Template");

                entity.HasOne(d => d.DocumentPublishedVersionHistory)
                    .WithMany(p => p.CmsDocumentDocumentPublishedVersionHistories)
                    .HasForeignKey(d => d.DocumentPublishedVersionHistoryId)
                    .HasConstraintName("FK_CMS_Document_DocumentPublishedVersionHistoryID_CMS_VersionHistory");

                entity.HasOne(d => d.DocumentStylesheet)
                    .WithMany(p => p.CmsDocuments)
                    .HasForeignKey(d => d.DocumentStylesheetId)
                    .HasConstraintName("FK_CMS_Document_DocumentStylesheetID_CMS_CssStylesheet");

                entity.HasOne(d => d.DocumentTagGroup)
                    .WithMany(p => p.CmsDocuments)
                    .HasForeignKey(d => d.DocumentTagGroupId)
                    .HasConstraintName("FK_CMS_Document_DocumentTagGroupID_CMS_TagGroup");

                entity.HasOne(d => d.DocumentWorkflowStep)
                    .WithMany(p => p.CmsDocuments)
                    .HasForeignKey(d => d.DocumentWorkflowStepId)
                    .HasConstraintName("FK_CMS_Document_DocumentWorkflowStepID_CMS_WorkflowStep");

                entity.HasMany(d => d.Categories)
                    .WithMany(p => p.Documents)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsDocumentCategory",
                        l => l.HasOne<CmsCategory>().WithMany().HasForeignKey("CategoryId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_DocumentCategory_CategoryID_CMS_Category"),
                        r => r.HasOne<CmsDocument>().WithMany().HasForeignKey("DocumentId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_DocumentCategory_DocumentID_CMS_Document"),
                        j =>
                        {
                            j.HasKey("DocumentId", "CategoryId");

                            j.ToTable("CMS_DocumentCategory", "dbo");

                            j.HasIndex(new[] { "CategoryId" }, "IX_CMS_DocumentCategory_CategoryID");

                            j.IndexerProperty<int>("DocumentId").HasColumnName("DocumentID");

                            j.IndexerProperty<int>("CategoryId").HasColumnName("CategoryID");
                        });

                entity.HasMany(d => d.Tags)
                    .WithMany(p => p.Documents)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsDocumentTag",
                        l => l.HasOne<CmsTag>().WithMany().HasForeignKey("TagId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_DocumentTag_TagID_CMS_Tag"),
                        r => r.HasOne<CmsDocument>().WithMany().HasForeignKey("DocumentId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_DocumentTag_DocumentID_CMS_Document"),
                        j =>
                        {
                            j.HasKey("DocumentId", "TagId");

                            j.ToTable("CMS_DocumentTag", "dbo");

                            j.HasIndex(new[] { "TagId" }, "IX_CMS_DocumentTag_TagID");

                            j.IndexerProperty<int>("DocumentId").HasColumnName("DocumentID");

                            j.IndexerProperty<int>("TagId").HasColumnName("TagID");
                        });
            });

            modelBuilder.Entity<CmsDocumentAlias>(entity =>
            {
                entity.HasKey(e => e.AliasId)
                    .IsClustered(false);

                entity.ToTable("CMS_DocumentAlias", "dbo");

                entity.HasIndex(e => e.AliasNodeId, "IX_CMS_DocumentAlias_AliasNodeID");

                entity.HasIndex(e => e.AliasSiteId, "IX_CMS_DocumentAlias_AliasSiteID");

                entity.HasIndex(e => e.AliasUrlpath, "IX_CMS_DocumentAlias_AliasURLPath")
                    .IsClustered();

                entity.HasIndex(e => new { e.AliasWildcardRule, e.AliasPriority }, "IX_CMS_DocumentAlias_AliasWildcardRule_AliasPriority");

                entity.HasIndex(e => e.AliasCulture, "IX_CMS_Document_AliasCulture");

                entity.Property(e => e.AliasId).HasColumnName("AliasID");

                entity.Property(e => e.AliasActionMode).HasMaxLength(50);

                entity.Property(e => e.AliasCulture)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AliasExtensions)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AliasGuid).HasColumnName("AliasGUID");

                entity.Property(e => e.AliasLastModified).HasDefaultValueSql("('10/22/2008 12:55:43 PM')");

                entity.Property(e => e.AliasNodeId).HasColumnName("AliasNodeID");

                entity.Property(e => e.AliasSiteId).HasColumnName("AliasSiteID");

                entity.Property(e => e.AliasUrlpath)
                    .HasColumnName("AliasURLPath")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AliasWildcardRule).HasMaxLength(440);

                entity.HasOne(d => d.AliasNode)
                    .WithMany(p => p.CmsDocumentAliases)
                    .HasForeignKey(d => d.AliasNodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_DocumentAlias_AliasNodeID_CMS_Tree");

                entity.HasOne(d => d.AliasSite)
                    .WithMany(p => p.CmsDocumentAliases)
                    .HasForeignKey(d => d.AliasSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_DocumentAlias_AliasSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsDocumentTypeScope>(entity =>
            {
                entity.HasKey(e => e.ScopeId)
                    .IsClustered(false);

                entity.ToTable("CMS_DocumentTypeScope", "dbo");

                entity.HasIndex(e => e.ScopePath, "IX_CMS_DocumentTypeScope_ScopePath")
                    .IsClustered();

                entity.HasIndex(e => e.ScopeSiteId, "IX_CMS_DocumentTypeScope_ScopeSiteID");

                entity.Property(e => e.ScopeId).HasColumnName("ScopeID");

                entity.Property(e => e.ScopeAllowAbvariant)
                    .HasColumnName("ScopeAllowABVariant")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ScopeAllowAllTypes).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScopeAllowLinks).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScopeGuid).HasColumnName("ScopeGUID");

                entity.Property(e => e.ScopeLastModified).HasDefaultValueSql("('4/30/2013 2:47:21 PM')");

                entity.Property(e => e.ScopePath).HasDefaultValueSql("('')");

                entity.Property(e => e.ScopeSiteId).HasColumnName("ScopeSiteID");

                entity.HasOne(d => d.ScopeSite)
                    .WithMany(p => p.CmsDocumentTypeScopes)
                    .HasForeignKey(d => d.ScopeSiteId)
                    .HasConstraintName("FK_CMS_DocumentTypeScope_ScopeSiteID_CMS_Site");

                entity.HasMany(d => d.Classes)
                    .WithMany(p => p.Scopes)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsDocumentTypeScopeClass",
                        l => l.HasOne<CmsClass>().WithMany().HasForeignKey("ClassId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_DocumentTypeScopeClass_ClassID_CMS_Class"),
                        r => r.HasOne<CmsDocumentTypeScope>().WithMany().HasForeignKey("ScopeId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_DocumentTypeScopeClass_ScopeID_CMS_DocumentTypeScope"),
                        j =>
                        {
                            j.HasKey("ScopeId", "ClassId");

                            j.ToTable("CMS_DocumentTypeScopeClass", "dbo");

                            j.HasIndex(new[] { "ClassId" }, "IX_CMS_DocumentTypeScopeClass_ClassID");

                            j.IndexerProperty<int>("ScopeId").HasColumnName("ScopeID");

                            j.IndexerProperty<int>("ClassId").HasColumnName("ClassID");
                        });
            });

            modelBuilder.Entity<CmsEmail>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.ToTable("CMS_Email", "dbo");

                entity.HasIndex(e => new { e.EmailPriority, e.EmailId }, "IX_CMS_Email_EmailPriority_EmailID")
                    .IsUnique();

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.EmailBcc).HasMaxLength(998);

                entity.Property(e => e.EmailCc).HasMaxLength(998);

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(254)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EmailGuid).HasColumnName("EmailGUID");

                entity.Property(e => e.EmailIsMass).HasDefaultValueSql("((1))");

                entity.Property(e => e.EmailLastModified).HasDefaultValueSql("('6/17/2016 10:11:21 AM')");

                entity.Property(e => e.EmailReplyTo).HasMaxLength(254);

                entity.Property(e => e.EmailSiteId).HasColumnName("EmailSiteID");

                entity.Property(e => e.EmailSubject)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailTo).HasMaxLength(998);

                entity.HasMany(d => d.Attachments)
                    .WithMany(p => p.Emails)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsAttachmentForEmail",
                        l => l.HasOne<CmsEmailAttachment>().WithMany().HasForeignKey("AttachmentId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_AttachmentForEmail_AttachmentID_CMS_EmailAttachment"),
                        r => r.HasOne<CmsEmail>().WithMany().HasForeignKey("EmailId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_AttachmentForEmail_EmailID_CMS_Email"),
                        j =>
                        {
                            j.HasKey("EmailId", "AttachmentId");

                            j.ToTable("CMS_AttachmentForEmail", "dbo");

                            j.HasIndex(new[] { "AttachmentId" }, "IX_CMS_AttachmentForEmail_AttachmentID");

                            j.IndexerProperty<int>("EmailId").HasColumnName("EmailID");

                            j.IndexerProperty<int>("AttachmentId").HasColumnName("AttachmentID");
                        });
            });

            modelBuilder.Entity<CmsEmailAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId);

                entity.ToTable("CMS_EmailAttachment", "dbo");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentContentId)
                    .HasMaxLength(255)
                    .HasColumnName("AttachmentContentID");

                entity.Property(e => e.AttachmentExtension).HasMaxLength(50);

                entity.Property(e => e.AttachmentGuid).HasColumnName("AttachmentGUID");

                entity.Property(e => e.AttachmentMimeType).HasMaxLength(100);

                entity.Property(e => e.AttachmentName).HasMaxLength(255);

                entity.Property(e => e.AttachmentSiteId).HasColumnName("AttachmentSiteID");
            });

            modelBuilder.Entity<CmsEmailTemplate>(entity =>
            {
                entity.HasKey(e => e.EmailTemplateId)
                    .IsClustered(false);

                entity.ToTable("CMS_EmailTemplate", "dbo");

                entity.HasIndex(e => e.EmailTemplateDisplayName, "IX_CMS_EmailTemplate_EmailTemplateDisplayName")
                    .IsClustered();

                entity.HasIndex(e => new { e.EmailTemplateName, e.EmailTemplateSiteId }, "IX_CMS_EmailTemplate_EmailTemplateName_EmailTemplateSiteID");

                entity.HasIndex(e => e.EmailTemplateSiteId, "IX_CMS_EmailTemplate_EmailTemplateSiteID");

                entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");

                entity.Property(e => e.EmailTemplateBcc).HasMaxLength(998);

                entity.Property(e => e.EmailTemplateCc).HasMaxLength(998);

                entity.Property(e => e.EmailTemplateDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailTemplateFrom).HasMaxLength(254);

                entity.Property(e => e.EmailTemplateGuid).HasColumnName("EmailTemplateGUID");

                entity.Property(e => e.EmailTemplateName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EmailTemplateReplyTo).HasMaxLength(254);

                entity.Property(e => e.EmailTemplateSiteId).HasColumnName("EmailTemplateSiteID");

                entity.Property(e => e.EmailTemplateSubject).HasMaxLength(250);

                entity.Property(e => e.EmailTemplateType).HasMaxLength(100);

                entity.HasOne(d => d.EmailTemplateSite)
                    .WithMany(p => p.CmsEmailTemplates)
                    .HasForeignKey(d => d.EmailTemplateSiteId)
                    .HasConstraintName("FK_CMS_Email_EmailTemplateSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsEmailUser>(entity =>
            {
                entity.HasKey(e => new { e.EmailId, e.UserId });

                entity.ToTable("CMS_EmailUser", "dbo");

                entity.HasIndex(e => e.Status, "IX_CMS_EmailUser_Status");

                entity.HasIndex(e => e.UserId, "IX_CMS_EmailUser_UserID");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.CmsEmailUsers)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_EmailUser_EmailID_CMS_Email");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsEmailUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_EmailUser_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsEventLog>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("CMS_EventLog", "dbo");

                entity.HasIndex(e => e.SiteId, "IX_CMS_EventLog_SiteID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EventCode)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EventMachineName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EventTime).HasDefaultValueSql("('4/21/2015 8:21:43 AM')");

                entity.Property(e => e.EventType)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EventUrl).HasDefaultValueSql("(N'')");

                entity.Property(e => e.EventUrlReferrer).HasDefaultValueSql("(N'')");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(100)
                    .HasColumnName("IPAddress")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(250);
            });

            modelBuilder.Entity<CmsExternalLogin>(entity =>
            {
                entity.HasKey(e => e.ExternalLoginId);

                entity.ToTable("CMS_ExternalLogin", "dbo");

                entity.HasIndex(e => e.UserId, "IX_CMS_ExternalLogin_UserID");

                entity.Property(e => e.ExternalLoginId).HasColumnName("ExternalLoginID");

                entity.Property(e => e.IdentityKey).HasMaxLength(200);

                entity.Property(e => e.LoginProvider).HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsExternalLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ExternalLogin_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsForm>(entity =>
            {
                entity.HasKey(e => e.FormId)
                    .IsClustered(false);

                entity.ToTable("CMS_Form", "dbo");

                entity.HasIndex(e => e.FormClassId, "IX_CMS_Form_FormClassID");

                entity.HasIndex(e => e.FormDisplayName, "IX_CMS_Form_FormDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.FormSiteId, "IX_CMS_Form_FormSiteID");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormClassId).HasColumnName("FormClassID");

                entity.Property(e => e.FormConfirmationEmailField).HasMaxLength(254);

                entity.Property(e => e.FormConfirmationEmailSubject)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FormConfirmationSendFromEmail).HasMaxLength(254);

                entity.Property(e => e.FormDisplayName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormEmailAttachUploadedDocs).HasDefaultValueSql("((0))");

                entity.Property(e => e.FormEmailSubject).HasMaxLength(250);

                entity.Property(e => e.FormGuid).HasColumnName("FormGUID");

                entity.Property(e => e.FormLastModified).HasDefaultValueSql("('9/17/2012 1:37:08 PM')");

                entity.Property(e => e.FormLogActivity).HasDefaultValueSql("((1))");

                entity.Property(e => e.FormName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormRedirectToUrl).HasMaxLength(400);

                entity.Property(e => e.FormSendFromEmail).HasMaxLength(254);

                entity.Property(e => e.FormSendToEmail).HasMaxLength(998);

                entity.Property(e => e.FormSiteId).HasColumnName("FormSiteID");

                entity.Property(e => e.FormSubmitButtonImage).HasMaxLength(255);

                entity.Property(e => e.FormSubmitButtonText)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.FormClass)
                    .WithMany(p => p.CmsForms)
                    .HasForeignKey(d => d.FormClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Form_FormClassID_CMS_Class");

                entity.HasOne(d => d.FormSite)
                    .WithMany(p => p.CmsForms)
                    .HasForeignKey(d => d.FormSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Form_FormSiteID_CMS_Site");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Forms)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsFormRole",
                        l => l.HasOne<CmsRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_FormRole_RoleID_CMS_Role"),
                        r => r.HasOne<CmsForm>().WithMany().HasForeignKey("FormId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_FormRole_FormID_CMS_Form"),
                        j =>
                        {
                            j.HasKey("FormId", "RoleId");

                            j.ToTable("CMS_FormRole", "dbo");

                            j.HasIndex(new[] { "RoleId" }, "IX_CMS_FormRole_RoleID");

                            j.IndexerProperty<int>("FormId").HasColumnName("FormID");

                            j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");
                        });
            });

            modelBuilder.Entity<CmsFormUserControl>(entity =>
            {
                entity.HasKey(e => e.UserControlId)
                    .IsClustered(false);

                entity.ToTable("CMS_FormUserControl", "dbo");

                entity.HasIndex(e => e.UserControlCodeName, "IX_CMS_FormUserControl_UserControlCodeName")
                    .IsUnique();

                entity.HasIndex(e => e.UserControlDisplayName, "IX_CMS_FormUserControl_UserControlDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.UserControlParentId, "IX_CMS_FormUserControl_UserControlParentID");

                entity.HasIndex(e => e.UserControlResourceId, "IX_CMS_FormUserControl_UserControlResourceID");

                entity.Property(e => e.UserControlId).HasColumnName("UserControlID");

                entity.Property(e => e.UserControlAssemblyName).HasMaxLength(200);

                entity.Property(e => e.UserControlClassName).HasMaxLength(200);

                entity.Property(e => e.UserControlCodeName).HasMaxLength(200);

                entity.Property(e => e.UserControlDefaultDataType).HasMaxLength(50);

                entity.Property(e => e.UserControlDisplayName).HasMaxLength(200);

                entity.Property(e => e.UserControlFileName).HasMaxLength(400);

                entity.Property(e => e.UserControlGuid).HasColumnName("UserControlGUID");

                entity.Property(e => e.UserControlIsSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserControlParentId).HasColumnName("UserControlParentID");

                entity.Property(e => e.UserControlPriority).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserControlResourceId).HasColumnName("UserControlResourceID");

                entity.Property(e => e.UserControlShowInCustomTables).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserControlThumbnailGuid).HasColumnName("UserControlThumbnailGUID");

                entity.HasOne(d => d.UserControlParent)
                    .WithMany(p => p.InverseUserControlParent)
                    .HasForeignKey(d => d.UserControlParentId)
                    .HasConstraintName("FK_CMS_FormUserControl_UserControlParentID_CMS_FormUserControl");

                entity.HasOne(d => d.UserControlResource)
                    .WithMany(p => p.CmsFormUserControls)
                    .HasForeignKey(d => d.UserControlResourceId)
                    .HasConstraintName("FK_CMS_FormUserControl_UserControlResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsHelpTopic>(entity =>
            {
                entity.HasKey(e => e.HelpTopicId);

                entity.ToTable("CMS_HelpTopic", "dbo");

                entity.HasIndex(e => e.HelpTopicUielementId, "IX_CMS_HelpTopic_HelpTopicUIElementID");

                entity.Property(e => e.HelpTopicId).HasColumnName("HelpTopicID");

                entity.Property(e => e.HelpTopicGuid).HasColumnName("HelpTopicGUID");

                entity.Property(e => e.HelpTopicLink)
                    .HasMaxLength(1023)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HelpTopicName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.HelpTopicUielementId).HasColumnName("HelpTopicUIElementID");

                entity.HasOne(d => d.HelpTopicUielement)
                    .WithMany(p => p.CmsHelpTopics)
                    .HasForeignKey(d => d.HelpTopicUielementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_HelpTopic_HelpTopicUIElementID_CMS_UIElement");
            });

            modelBuilder.Entity<CmsLayout>(entity =>
            {
                entity.HasKey(e => e.LayoutId);

                entity.ToTable("CMS_Layout", "dbo");

                entity.HasIndex(e => e.LayoutDisplayName, "IX_CMS_Layout_LayoutDisplayName");

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.Property(e => e.LayoutCode).HasDefaultValueSql("('<cms:CMSWebPartZone ZoneID=\"zoneA\" runat=\"server\" />')");

                entity.Property(e => e.LayoutCodeName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LayoutCss).HasColumnName("LayoutCSS");

                entity.Property(e => e.LayoutDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LayoutGuid).HasColumnName("LayoutGUID");

                entity.Property(e => e.LayoutIconClass)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'icon-layout')");

                entity.Property(e => e.LayoutIsConvertible).HasDefaultValueSql("((0))");

                entity.Property(e => e.LayoutThumbnailGuid).HasColumnName("LayoutThumbnailGUID");

                entity.Property(e => e.LayoutType).HasMaxLength(50);

                entity.Property(e => e.LayoutVersionGuid)
                    .HasMaxLength(50)
                    .HasColumnName("LayoutVersionGUID");
            });

            modelBuilder.Entity<CmsLicenseKey>(entity =>
            {
                entity.HasKey(e => e.LicenseKeyId)
                    .IsClustered(false);

                entity.ToTable("CMS_LicenseKey", "dbo");

                entity.HasIndex(e => e.LicenseDomain, "IX_CMS_LicenseKey_LicenseDomain")
                    .IsClustered();

                entity.Property(e => e.LicenseKeyId).HasColumnName("LicenseKeyID");

                entity.Property(e => e.LicenseDomain).HasMaxLength(255);

                entity.Property(e => e.LicenseEdition).HasMaxLength(200);

                entity.Property(e => e.LicenseExpiration).HasMaxLength(200);
            });

            modelBuilder.Entity<CmsMacroIdentity>(entity =>
            {
                entity.HasKey(e => e.MacroIdentityId);

                entity.ToTable("CMS_MacroIdentity", "dbo");

                entity.HasIndex(e => e.MacroIdentityEffectiveUserId, "IX_CMS_MacroIdentity_MacroIdentityEffectiveUserID");

                entity.Property(e => e.MacroIdentityId).HasColumnName("MacroIdentityID");

                entity.Property(e => e.MacroIdentityEffectiveUserId).HasColumnName("MacroIdentityEffectiveUserID");

                entity.Property(e => e.MacroIdentityLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.MacroIdentityName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.MacroIdentityEffectiveUser)
                    .WithMany(p => p.CmsMacroIdentities)
                    .HasForeignKey(d => d.MacroIdentityEffectiveUserId)
                    .HasConstraintName("FK_CMS_MacroIdentity_MacroIdentityEffectiveUserID_CMS_User");
            });

            modelBuilder.Entity<CmsMacroRule>(entity =>
            {
                entity.HasKey(e => e.MacroRuleId);

                entity.ToTable("CMS_MacroRule", "dbo");

                entity.Property(e => e.MacroRuleId).HasColumnName("MacroRuleID");

                entity.Property(e => e.MacroRuleAvailability).HasDefaultValueSql("((0))");

                entity.Property(e => e.MacroRuleCondition).HasDefaultValueSql("(N'')");

                entity.Property(e => e.MacroRuleDescription).HasMaxLength(450);

                entity.Property(e => e.MacroRuleDisplayName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MacroRuleEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.MacroRuleGuid).HasColumnName("MacroRuleGUID");

                entity.Property(e => e.MacroRuleIsCustom).HasDefaultValueSql("((0))");

                entity.Property(e => e.MacroRuleLastModified).HasDefaultValueSql("('5/1/2012 8:46:33 AM')");

                entity.Property(e => e.MacroRuleName).HasMaxLength(200);

                entity.Property(e => e.MacroRuleRequiredData).HasMaxLength(2500);

                entity.Property(e => e.MacroRuleResourceName).HasMaxLength(100);

                entity.Property(e => e.MacroRuleText).HasMaxLength(1000);
            });

            modelBuilder.Entity<CmsMembership>(entity =>
            {
                entity.HasKey(e => e.MembershipId);

                entity.ToTable("CMS_Membership", "dbo");

                entity.HasIndex(e => e.MembershipSiteId, "IX_CMS_Membership_MembershipSiteID");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.MembershipDisplayName).HasMaxLength(200);

                entity.Property(e => e.MembershipGuid).HasColumnName("MembershipGUID");

                entity.Property(e => e.MembershipName).HasMaxLength(200);

                entity.Property(e => e.MembershipSiteId).HasColumnName("MembershipSiteID");

                entity.HasOne(d => d.MembershipSite)
                    .WithMany(p => p.CmsMemberships)
                    .HasForeignKey(d => d.MembershipSiteId)
                    .HasConstraintName("FK_CMS_Membership_MembershipSiteID_CMS_Site");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Memberships)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsMembershipRole",
                        l => l.HasOne<CmsRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_MembershipRole_RoleID_CMS_Role"),
                        r => r.HasOne<CmsMembership>().WithMany().HasForeignKey("MembershipId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_MembershipRole_MembershipID_CMS_Membership"),
                        j =>
                        {
                            j.HasKey("MembershipId", "RoleId");

                            j.ToTable("CMS_MembershipRole", "dbo");

                            j.HasIndex(new[] { "RoleId" }, "IX_CMS_MembershipRole_RoleID");

                            j.IndexerProperty<int>("MembershipId").HasColumnName("MembershipID");

                            j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");
                        });
            });

            modelBuilder.Entity<CmsMembershipUser>(entity =>
            {
                entity.HasKey(e => e.MembershipUserId);

                entity.ToTable("CMS_MembershipUser", "dbo");

                entity.HasIndex(e => new { e.MembershipId, e.UserId }, "IX_CMS_MembershipUser_MembershipID_UserID")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "IX_CMS_MembershipUser_UserID");

                entity.Property(e => e.MembershipUserId).HasColumnName("MembershipUserID");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Membership)
                    .WithMany(p => p.CmsMembershipUsers)
                    .HasForeignKey(d => d.MembershipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_MembershipUser_MembershipID_CMS_Membership");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsMembershipUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_MembershipUser_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsMetaFile>(entity =>
            {
                entity.HasKey(e => e.MetaFileId)
                    .IsClustered(false);

                entity.ToTable("CMS_MetaFile", "dbo");

                entity.HasIndex(e => new { e.MetaFileGuid, e.MetaFileSiteId, e.MetaFileObjectType, e.MetaFileObjectId, e.MetaFileGroupName }, "IX_CMS_MetaFile_MetaFileGUID_MetaFileSiteID_MetaFileObjectType_MetaFileObjectID_MetaFileGroupName");

                entity.HasIndex(e => e.MetaFileSiteId, "IX_CMS_MetaFile_MetaFileSiteID");

                entity.HasIndex(e => new { e.MetaFileObjectType, e.MetaFileObjectId, e.MetaFileGroupName }, "IX_CMS_Metafile_MetaFileObjectType_MetaFileObjectID_MetaFileGroupName")
                    .IsClustered();

                entity.Property(e => e.MetaFileId).HasColumnName("MetaFileID");

                entity.Property(e => e.MetaFileExtension).HasMaxLength(50);

                entity.Property(e => e.MetaFileGroupName).HasMaxLength(100);

                entity.Property(e => e.MetaFileGuid).HasColumnName("MetaFileGUID");

                entity.Property(e => e.MetaFileMimeType).HasMaxLength(100);

                entity.Property(e => e.MetaFileName).HasMaxLength(250);

                entity.Property(e => e.MetaFileObjectId).HasColumnName("MetaFileObjectID");

                entity.Property(e => e.MetaFileObjectType).HasMaxLength(100);

                entity.Property(e => e.MetaFileSiteId).HasColumnName("MetaFileSiteID");

                entity.Property(e => e.MetaFileTitle).HasMaxLength(250);

                entity.HasOne(d => d.MetaFileSite)
                    .WithMany(p => p.CmsMetaFiles)
                    .HasForeignKey(d => d.MetaFileSiteId)
                    .HasConstraintName("FK_CMS_MetaFile_MetaFileSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsModuleLicenseKey>(entity =>
            {
                entity.HasKey(e => e.ModuleLicenseKeyId);

                entity.ToTable("CMS_ModuleLicenseKey", "dbo");

                entity.HasIndex(e => e.ModuleLicenseKeyResourceId, "IX_CMS_ModuleLicenseKey_ModuleLicenseKeyResourceID");

                entity.Property(e => e.ModuleLicenseKeyId).HasColumnName("ModuleLicenseKeyID");

                entity.Property(e => e.ModuleLicenseKeyLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.ModuleLicenseKeyLicense).HasDefaultValueSql("(N'')");

                entity.Property(e => e.ModuleLicenseKeyResourceId).HasColumnName("ModuleLicenseKeyResourceID");

                entity.HasOne(d => d.ModuleLicenseKeyResource)
                    .WithMany(p => p.CmsModuleLicenseKeys)
                    .HasForeignKey(d => d.ModuleLicenseKeyResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ModuleLicenseKey_ModuleLicenseKeyResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsModuleUsageCounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CMS_ModuleUsageCounter", "dbo");

                entity.HasIndex(e => e.ModuleUsageCounterName, "IX_CMS_ModuleUsageCounter_ModuleUsageCounterName")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.ModuleUsageCounterId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ModuleUsageCounterID");

                entity.Property(e => e.ModuleUsageCounterName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CmsObjectSetting>(entity =>
            {
                entity.HasKey(e => e.ObjectSettingsId);

                entity.ToTable("CMS_ObjectSettings", "dbo");

                entity.HasIndex(e => e.ObjectCheckedOutByUserId, "IX_CMS_ObjectSettings_ObjectCheckedOutByUserID");

                entity.HasIndex(e => e.ObjectCheckedOutVersionHistoryId, "IX_CMS_ObjectSettings_ObjectCheckedOutVersionHistoryID");

                entity.HasIndex(e => e.ObjectPublishedVersionHistoryId, "IX_CMS_ObjectSettings_ObjectPublishedVersionHistoryID");

                entity.HasIndex(e => new { e.ObjectSettingsObjectId, e.ObjectSettingsObjectType }, "IX_CMS_ObjectSettings_ObjectSettingsObjectType_ObjectSettingsObjectID")
                    .IsUnique();

                entity.HasIndex(e => e.ObjectWorkflowStepId, "IX_CMS_ObjectSettings_ObjectWorkflowStepID");

                entity.Property(e => e.ObjectSettingsId).HasColumnName("ObjectSettingsID");

                entity.Property(e => e.ObjectCheckedOutByUserId).HasColumnName("ObjectCheckedOutByUserID");

                entity.Property(e => e.ObjectCheckedOutVersionHistoryId).HasColumnName("ObjectCheckedOutVersionHistoryID");

                entity.Property(e => e.ObjectPublishedVersionHistoryId).HasColumnName("ObjectPublishedVersionHistoryID");

                entity.Property(e => e.ObjectSettingsObjectId).HasColumnName("ObjectSettingsObjectID");

                entity.Property(e => e.ObjectSettingsObjectType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ObjectWorkflowSendEmails).HasDefaultValueSql("((1))");

                entity.Property(e => e.ObjectWorkflowStepId).HasColumnName("ObjectWorkflowStepID");

                entity.HasOne(d => d.ObjectCheckedOutByUser)
                    .WithMany(p => p.CmsObjectSettings)
                    .HasForeignKey(d => d.ObjectCheckedOutByUserId)
                    .HasConstraintName("FK_CMS_ObjectSettings_ObjectCheckedOutByUserID_CMS_User");

                entity.HasOne(d => d.ObjectCheckedOutVersionHistory)
                    .WithMany(p => p.CmsObjectSettingObjectCheckedOutVersionHistories)
                    .HasForeignKey(d => d.ObjectCheckedOutVersionHistoryId)
                    .HasConstraintName("FK_CMS_ObjectSettings_ObjectCheckedOutVersionHistoryID_CMS_ObjectVersionHistory");

                entity.HasOne(d => d.ObjectPublishedVersionHistory)
                    .WithMany(p => p.CmsObjectSettingObjectPublishedVersionHistories)
                    .HasForeignKey(d => d.ObjectPublishedVersionHistoryId)
                    .HasConstraintName("FK_CMS_ObjectSettings_ObjectPublishedVersionHistoryID_CMS_ObjectVersionHistory");

                entity.HasOne(d => d.ObjectWorkflowStep)
                    .WithMany(p => p.CmsObjectSettings)
                    .HasForeignKey(d => d.ObjectWorkflowStepId)
                    .HasConstraintName("FK_CMS_ObjectSettings_ObjectWorkflowStepID_CMS_WorkflowStep");
            });

            modelBuilder.Entity<CmsObjectVersionHistory>(entity =>
            {
                entity.HasKey(e => e.VersionId)
                    .HasName("PK_CMS_ObjectVersionHistory_VersionID")
                    .IsClustered(false);

                entity.ToTable("CMS_ObjectVersionHistory", "dbo");

                entity.HasIndex(e => new { e.VersionDeletedByUserId, e.VersionDeletedWhen }, "IX_CMS_ObjectVersionHistory_VersionDeletedByUserID_VersionDeletedWhen");

                entity.HasIndex(e => e.VersionModifiedByUserId, "IX_CMS_ObjectVersionHistory_VersionModifiedByUserID");

                entity.HasIndex(e => new { e.VersionObjectSiteId, e.VersionDeletedWhen }, "IX_CMS_ObjectVersionHistory_VersionObjectSiteID_VersionDeletedWhen");

                entity.HasIndex(e => new { e.VersionObjectType, e.VersionObjectId, e.VersionModifiedWhen }, "IX_CMS_ObjectVersionHistory_VersionObjectType_VersionObjectID_VersionModifiedWhen");

                entity.HasIndex(e => new { e.VersionObjectType, e.VersionObjectId, e.VersionId }, "PK_CMS_ObjectVersionHistory")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionBinaryDataXml).HasColumnName("VersionBinaryDataXML");

                entity.Property(e => e.VersionDeletedByUserId).HasColumnName("VersionDeletedByUserID");

                entity.Property(e => e.VersionModifiedByUserId).HasColumnName("VersionModifiedByUserID");

                entity.Property(e => e.VersionNumber)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VersionObjectDisplayName).HasMaxLength(450);

                entity.Property(e => e.VersionObjectId).HasColumnName("VersionObjectID");

                entity.Property(e => e.VersionObjectSiteId).HasColumnName("VersionObjectSiteID");

                entity.Property(e => e.VersionObjectType).HasMaxLength(100);

                entity.Property(e => e.VersionSiteBindingIds).HasColumnName("VersionSiteBindingIDs");

                entity.Property(e => e.VersionXml).HasColumnName("VersionXML");

                entity.HasOne(d => d.VersionDeletedByUser)
                    .WithMany(p => p.CmsObjectVersionHistoryVersionDeletedByUsers)
                    .HasForeignKey(d => d.VersionDeletedByUserId)
                    .HasConstraintName("FK_CMS_ObjectVersionHistory_VersionDeletedByUserID_CMS_User");

                entity.HasOne(d => d.VersionModifiedByUser)
                    .WithMany(p => p.CmsObjectVersionHistoryVersionModifiedByUsers)
                    .HasForeignKey(d => d.VersionModifiedByUserId)
                    .HasConstraintName("FK_CMS_ObjectVersionHistory_VersionModifiedByUserID_CMS_User");

                entity.HasOne(d => d.VersionObjectSite)
                    .WithMany(p => p.CmsObjectVersionHistories)
                    .HasForeignKey(d => d.VersionObjectSiteId)
                    .HasConstraintName("FK_CMS_ObjectVersionHistory_VersionObjectSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsObjectWorkflowTrigger>(entity =>
            {
                entity.HasKey(e => e.TriggerId);

                entity.ToTable("CMS_ObjectWorkflowTrigger", "dbo");

                entity.HasIndex(e => e.TriggerWorkflowId, "IX_CMS_ObjectWorkflowTrigger_TriggerWorkflowID");

                entity.Property(e => e.TriggerId).HasColumnName("TriggerID");

                entity.Property(e => e.TriggerDisplayName)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TriggerGuid).HasColumnName("TriggerGUID");

                entity.Property(e => e.TriggerObjectType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TriggerTargetObjectId).HasColumnName("TriggerTargetObjectID");

                entity.Property(e => e.TriggerTargetObjectType).HasMaxLength(100);

                entity.Property(e => e.TriggerWorkflowId).HasColumnName("TriggerWorkflowID");

                entity.HasOne(d => d.TriggerWorkflow)
                    .WithMany(p => p.CmsObjectWorkflowTriggers)
                    .HasForeignKey(d => d.TriggerWorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ObjectWorkflowTrigger_TriggerWorkflowID");
            });

            modelBuilder.Entity<CmsOpenIduser>(entity =>
            {
                entity.HasKey(e => e.OpenIduserId);

                entity.ToTable("CMS_OpenIDUser", "dbo");

                entity.HasIndex(e => e.OpenId, "IX_CMS_OpenIDUser_OpenID");

                entity.HasIndex(e => e.UserId, "IX_CMS_OpenIDUser_UserID");

                entity.Property(e => e.OpenIduserId).HasColumnName("OpenIDUserID");

                entity.Property(e => e.OpenId)
                    .HasColumnName("OpenID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpenIdproviderUrl)
                    .HasMaxLength(450)
                    .HasColumnName("OpenIDProviderURL");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsOpenIdusers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_OpenIDUser_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsPageTemplate>(entity =>
            {
                entity.HasKey(e => e.PageTemplateId)
                    .IsClustered(false);

                entity.ToTable("CMS_PageTemplate", "dbo");

                entity.HasIndex(e => e.PageTemplateCategoryId, "IX_CMS_PageTemplate_PageTemplateCategoryID")
                    .IsClustered();

                entity.HasIndex(e => new { e.PageTemplateCodeName, e.PageTemplateDisplayName }, "IX_CMS_PageTemplate_PageTemplateCodeName_PageTemplateDisplayName");

                entity.HasIndex(e => new { e.PageTemplateIsReusable, e.PageTemplateForAllPages, e.PageTemplateShowAsMasterTemplate }, "IX_CMS_PageTemplate_PageTemplateIsReusable_PageTemplateForAllPages_PageTemplateShowAsMasterTemplate");

                entity.HasIndex(e => e.PageTemplateLayoutId, "IX_CMS_PageTemplate_PageTemplateLayoutID");

                entity.HasIndex(e => new { e.PageTemplateSiteId, e.PageTemplateCodeName, e.PageTemplateGuid }, "IX_CMS_PageTemplate_PageTemplateSiteID_PageTemplateCodeName_PageTemplateGUID");

                entity.Property(e => e.PageTemplateId).HasColumnName("PageTemplateID");

                entity.Property(e => e.PageTemplateCategoryId).HasColumnName("PageTemplateCategoryID");

                entity.Property(e => e.PageTemplateCloneAsAdHoc).HasDefaultValueSql("((0))");

                entity.Property(e => e.PageTemplateCodeName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PageTemplateCss).HasColumnName("PageTemplateCSS");

                entity.Property(e => e.PageTemplateDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PageTemplateFile).HasMaxLength(400);

                entity.Property(e => e.PageTemplateForAllPages).HasDefaultValueSql("((1))");

                entity.Property(e => e.PageTemplateGuid).HasColumnName("PageTemplateGUID");

                entity.Property(e => e.PageTemplateIconClass)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'icon-layout')");

                entity.Property(e => e.PageTemplateInheritPageLevels).HasMaxLength(200);

                entity.Property(e => e.PageTemplateIsLayout).HasDefaultValueSql("((0))");

                entity.Property(e => e.PageTemplateIsReusable).HasDefaultValueSql("((0))");

                entity.Property(e => e.PageTemplateLayoutId).HasColumnName("PageTemplateLayoutID");

                entity.Property(e => e.PageTemplateLayoutType).HasMaxLength(50);

                entity.Property(e => e.PageTemplateMasterPageTemplateId).HasColumnName("PageTemplateMasterPageTemplateID");

                entity.Property(e => e.PageTemplateNodeGuid).HasColumnName("PageTemplateNodeGUID");

                entity.Property(e => e.PageTemplateShowAsMasterTemplate).HasDefaultValueSql("((0))");

                entity.Property(e => e.PageTemplateSiteId).HasColumnName("PageTemplateSiteID");

                entity.Property(e => e.PageTemplateThumbnailGuid).HasColumnName("PageTemplateThumbnailGUID");

                entity.Property(e => e.PageTemplateType)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'portal')");

                entity.Property(e => e.PageTemplateVersionGuid)
                    .HasMaxLength(200)
                    .HasColumnName("PageTemplateVersionGUID");

                entity.HasOne(d => d.PageTemplateCategory)
                    .WithMany(p => p.CmsPageTemplates)
                    .HasForeignKey(d => d.PageTemplateCategoryId)
                    .HasConstraintName("FK_CMS_PageTemplate_PageTemplateCategoryID_CMS_PageTemplateCategory");

                entity.HasOne(d => d.PageTemplateLayoutNavigation)
                    .WithMany(p => p.CmsPageTemplates)
                    .HasForeignKey(d => d.PageTemplateLayoutId)
                    .HasConstraintName("FK_CMS_PageTemplate_PageTemplateLayoutID_CMS_Layout");

                entity.HasOne(d => d.PageTemplateSite)
                    .WithMany(p => p.CmsPageTemplates)
                    .HasForeignKey(d => d.PageTemplateSiteId)
                    .HasConstraintName("FK_CMS_PageTemplate_PageTemplateSiteID_CMS_Site");

                entity.HasMany(d => d.Sites)
                    .WithMany(p => p.PageTemplates)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsPageTemplateSite",
                        l => l.HasOne<CmsSite>().WithMany().HasForeignKey("SiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_PageTemplateSite_SiteID_CMS_Site"),
                        r => r.HasOne<CmsPageTemplate>().WithMany().HasForeignKey("PageTemplateId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_PageTemplateSite_PageTemplateID_CMS_PageTemplate"),
                        j =>
                        {
                            j.HasKey("PageTemplateId", "SiteId");

                            j.ToTable("CMS_PageTemplateSite", "dbo");

                            j.HasIndex(new[] { "SiteId" }, "IX_CMS_PageTemplateSite_SiteID");

                            j.IndexerProperty<int>("PageTemplateId").HasColumnName("PageTemplateID");

                            j.IndexerProperty<int>("SiteId").HasColumnName("SiteID");
                        });
            });

            modelBuilder.Entity<CmsPageTemplateCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .IsClustered(false);

                entity.ToTable("CMS_PageTemplateCategory", "dbo");

                entity.HasIndex(e => e.CategoryLevel, "IX_CMS_PageTemplateCategory_CategoryLevel");

                entity.HasIndex(e => e.CategoryParentId, "IX_CMS_PageTemplateCategory_CategoryParentID");

                entity.HasIndex(e => e.CategoryPath, "IX_CMS_PageTemplateCategory_CategoryPath")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryChildCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.CategoryDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.CategoryName).HasMaxLength(200);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategoryTemplateChildCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CategoryParent)
                    .WithMany(p => p.InverseCategoryParent)
                    .HasForeignKey(d => d.CategoryParentId)
                    .HasConstraintName("FK_CMS_PageTemplateCategory_CategoryParentID_CMS_PageTemplateCategory");
            });

            modelBuilder.Entity<CmsPageTemplateConfiguration>(entity =>
            {
                entity.HasKey(e => e.PageTemplateConfigurationId);

                entity.ToTable("CMS_PageTemplateConfiguration", "dbo");

                entity.HasIndex(e => e.PageTemplateConfigurationSiteId, "IX_CMS_PageTemplateConfiguration_PageTemplateConfigurationSiteID");

                entity.Property(e => e.PageTemplateConfigurationId).HasColumnName("PageTemplateConfigurationID");

                entity.Property(e => e.PageTemplateConfigurationGuid).HasColumnName("PageTemplateConfigurationGUID");

                entity.Property(e => e.PageTemplateConfigurationLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.PageTemplateConfigurationName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PageTemplateConfigurationSiteId).HasColumnName("PageTemplateConfigurationSiteID");

                entity.Property(e => e.PageTemplateConfigurationTemplate).HasDefaultValueSql("(N'')");

                entity.Property(e => e.PageTemplateConfigurationThumbnailGuid).HasColumnName("PageTemplateConfigurationThumbnailGUID");

                entity.HasOne(d => d.PageTemplateConfigurationSite)
                    .WithMany(p => p.CmsPageTemplateConfigurations)
                    .HasForeignKey(d => d.PageTemplateConfigurationSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_PageTemplateConfiguration_PageTemplateConfigurationSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsPageTemplateScope>(entity =>
            {
                entity.HasKey(e => e.PageTemplateScopeId)
                    .IsClustered(false);

                entity.ToTable("CMS_PageTemplateScope", "dbo");

                entity.HasIndex(e => e.PageTemplateScopeClassId, "IX_CMS_PageTemplateScope_PageTemplateScopeClassID");

                entity.HasIndex(e => e.PageTemplateScopeCultureId, "IX_CMS_PageTemplateScope_PageTemplateScopeCultureID");

                entity.HasIndex(e => e.PageTemplateScopeLevels, "IX_CMS_PageTemplateScope_PageTemplateScopeLevels");

                entity.HasIndex(e => e.PageTemplateScopePath, "IX_CMS_PageTemplateScope_PageTemplateScopePath")
                    .IsClustered();

                entity.HasIndex(e => e.PageTemplateScopeSiteId, "IX_CMS_PageTemplateScope_PageTemplateScopeSiteID");

                entity.HasIndex(e => e.PageTemplateScopeTemplateId, "IX_CMS_PageTemplateScope_PageTemplateScopeTemplateID");

                entity.Property(e => e.PageTemplateScopeId).HasColumnName("PageTemplateScopeID");

                entity.Property(e => e.PageTemplateScopeClassId).HasColumnName("PageTemplateScopeClassID");

                entity.Property(e => e.PageTemplateScopeCultureId).HasColumnName("PageTemplateScopeCultureID");

                entity.Property(e => e.PageTemplateScopeGuid).HasColumnName("PageTemplateScopeGUID");

                entity.Property(e => e.PageTemplateScopeLastModified).HasDefaultValueSql("('2/22/2010 9:30:07 AM')");

                entity.Property(e => e.PageTemplateScopePath).HasDefaultValueSql("('')");

                entity.Property(e => e.PageTemplateScopeSiteId).HasColumnName("PageTemplateScopeSiteID");

                entity.Property(e => e.PageTemplateScopeTemplateId).HasColumnName("PageTemplateScopeTemplateID");

                entity.HasOne(d => d.PageTemplateScopeClass)
                    .WithMany(p => p.CmsPageTemplateScopes)
                    .HasForeignKey(d => d.PageTemplateScopeClassId)
                    .HasConstraintName("FK_CMS_PageTemplateScope_PageTemplateScopeClassID_CMS_Class");

                entity.HasOne(d => d.PageTemplateScopeCulture)
                    .WithMany(p => p.CmsPageTemplateScopes)
                    .HasForeignKey(d => d.PageTemplateScopeCultureId)
                    .HasConstraintName("FK_CMS_PageTemplateScope_PageTemplateScopeCultureID_CMS_Culture");

                entity.HasOne(d => d.PageTemplateScopeSite)
                    .WithMany(p => p.CmsPageTemplateScopes)
                    .HasForeignKey(d => d.PageTemplateScopeSiteId)
                    .HasConstraintName("FK_CMS_PageTemplateScope_PageTemplateScopeSiteID_CMS_Site");

                entity.HasOne(d => d.PageTemplateScopeTemplate)
                    .WithMany(p => p.CmsPageTemplateScopes)
                    .HasForeignKey(d => d.PageTemplateScopeTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_PageTemplateScope_PageTemplateScopeTemplateID_CMS_PageTemplate");
            });

            modelBuilder.Entity<CmsPermission>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.ToTable("CMS_Permission", "dbo");

                entity.HasIndex(e => new { e.ClassId, e.PermissionName }, "IX_CMS_Permission_ClassID_PermissionName");

                entity.HasIndex(e => new { e.ResourceId, e.PermissionName }, "IX_CMS_Permission_ResourceID_PermissionName");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.PermissionDisplayInMatrix).HasDefaultValueSql("((0))");

                entity.Property(e => e.PermissionDisplayName).HasMaxLength(100);

                entity.Property(e => e.PermissionGuid).HasColumnName("PermissionGUID");

                entity.Property(e => e.PermissionName).HasMaxLength(100);

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.CmsPermissions)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_CMS_Permission_ClassID_CMS_Class");

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.CmsPermissions)
                    .HasForeignKey(d => d.ResourceId)
                    .HasConstraintName("FK_CMS_Permission_ResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsPersonalization>(entity =>
            {
                entity.HasKey(e => e.PersonalizationId)
                    .IsClustered(false);

                entity.ToTable("CMS_Personalization", "dbo");

                entity.HasIndex(e => new { e.PersonalizationId, e.PersonalizationUserId, e.PersonalizationDocumentId, e.PersonalizationDashboardName }, "IX_CMS_Personalization_PersonalizationID_PersonalizationUserID_PersonalizationDocumentID_PersonalizationDashboardName")
                    .IsUnique();

                entity.HasIndex(e => e.PersonalizationSiteId, "IX_CMS_Personalization_PersonalizationSiteID_SiteID");

                entity.HasIndex(e => e.PersonalizationUserId, "IX_CMS_Personalization_PersonalizationUserID");

                entity.HasIndex(e => e.PersonalizationDocumentId, "IX_CMS_Personalization_PersonalizationUserID_PersonalizationDocumentID")
                    .IsClustered();

                entity.Property(e => e.PersonalizationId).HasColumnName("PersonalizationID");

                entity.Property(e => e.PersonalizationDashboardName).HasMaxLength(200);

                entity.Property(e => e.PersonalizationDocumentId).HasColumnName("PersonalizationDocumentID");

                entity.Property(e => e.PersonalizationGuid).HasColumnName("PersonalizationGUID");

                entity.Property(e => e.PersonalizationLastModified).HasDefaultValueSql("('9/2/2008 5:36:59 PM')");

                entity.Property(e => e.PersonalizationSiteId).HasColumnName("PersonalizationSiteID");

                entity.Property(e => e.PersonalizationUserId).HasColumnName("PersonalizationUserID");

                entity.HasOne(d => d.PersonalizationDocument)
                    .WithMany(p => p.CmsPersonalizations)
                    .HasForeignKey(d => d.PersonalizationDocumentId)
                    .HasConstraintName("FK_CMS_Personalization_PersonalizationDocumentID_CMS_Document");

                entity.HasOne(d => d.PersonalizationSite)
                    .WithMany(p => p.CmsPersonalizations)
                    .HasForeignKey(d => d.PersonalizationSiteId)
                    .HasConstraintName("FK_CMS_Personalization_PersonalizationSiteID_CMS_Site");

                entity.HasOne(d => d.PersonalizationUser)
                    .WithMany(p => p.CmsPersonalizations)
                    .HasForeignKey(d => d.PersonalizationUserId)
                    .HasConstraintName("FK_CMS_Personalization_PersonalizationUserID_CMS_User");
            });

            modelBuilder.Entity<CmsQuery>(entity =>
            {
                entity.HasKey(e => e.QueryId);

                entity.ToTable("CMS_Query", "dbo");

                entity.HasIndex(e => new { e.ClassId, e.QueryName }, "IX_CMS_Query_QueryClassID_QueryName");

                entity.Property(e => e.QueryId).HasColumnName("QueryID");

                entity.Property(e => e.ClassId).HasColumnName("ClassID");

                entity.Property(e => e.QueryConnectionString).HasMaxLength(100);

                entity.Property(e => e.QueryGuid).HasColumnName("QueryGUID");

                entity.Property(e => e.QueryIsCustom).HasDefaultValueSql("((0))");

                entity.Property(e => e.QueryName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.QueryTypeId).HasColumnName("QueryTypeID");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.CmsQueries)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK_CMS_Query_ClassID_CMS_Class");
            });

            modelBuilder.Entity<CmsRelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId);

                entity.ToTable("CMS_Relationship", "dbo");

                entity.HasIndex(e => e.LeftNodeId, "IX_CMS_Relationship_LeftNodeID");

                entity.HasIndex(e => e.RelationshipNameId, "IX_CMS_Relationship_RelationshipNameID");

                entity.HasIndex(e => e.RightNodeId, "IX_CMS_Relationship_RightNodeID");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.LeftNodeId).HasColumnName("LeftNodeID");

                entity.Property(e => e.RelationshipNameId).HasColumnName("RelationshipNameID");

                entity.Property(e => e.RightNodeId).HasColumnName("RightNodeID");

                entity.HasOne(d => d.LeftNode)
                    .WithMany(p => p.CmsRelationshipLeftNodes)
                    .HasForeignKey(d => d.LeftNodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Relationship_LeftNodeID_CMS_Tree");

                entity.HasOne(d => d.RelationshipName)
                    .WithMany(p => p.CmsRelationships)
                    .HasForeignKey(d => d.RelationshipNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Relationship_RelationshipNameID_CMS_RelationshipName");

                entity.HasOne(d => d.RightNode)
                    .WithMany(p => p.CmsRelationshipRightNodes)
                    .HasForeignKey(d => d.RightNodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Relationship_RightNodeID_CMS_Tree");
            });

            modelBuilder.Entity<CmsRelationshipName>(entity =>
            {
                entity.HasKey(e => e.RelationshipNameId);

                entity.ToTable("CMS_RelationshipName", "dbo");

                entity.HasIndex(e => e.RelationshipAllowedObjects, "IX_CMS_RelationshipName_RelationshipAllowedObjects");

                entity.HasIndex(e => new { e.RelationshipName, e.RelationshipDisplayName }, "IX_CMS_RelationshipName_RelationshipName_RelationshipDisplayName");

                entity.Property(e => e.RelationshipNameId).HasColumnName("RelationshipNameID");

                entity.Property(e => e.RelationshipDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RelationshipGuid).HasColumnName("RelationshipGUID");

                entity.Property(e => e.RelationshipName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.HasMany(d => d.Sites)
                    .WithMany(p => p.RelationshipNames)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsRelationshipNameSite",
                        l => l.HasOne<CmsSite>().WithMany().HasForeignKey("SiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_RelationshipNameSite_SiteID_CMS_Site"),
                        r => r.HasOne<CmsRelationshipName>().WithMany().HasForeignKey("RelationshipNameId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_RelationshipNameSite_RelationshipNameID_CMS_RelationshipName"),
                        j =>
                        {
                            j.HasKey("RelationshipNameId", "SiteId");

                            j.ToTable("CMS_RelationshipNameSite", "dbo");

                            j.HasIndex(new[] { "SiteId" }, "IX_CMS_RelationshipNameSite_SiteID");

                            j.IndexerProperty<int>("RelationshipNameId").HasColumnName("RelationshipNameID");

                            j.IndexerProperty<int>("SiteId").HasColumnName("SiteID");
                        });
            });

            modelBuilder.Entity<CmsResource>(entity =>
            {
                entity.HasKey(e => e.ResourceId)
                    .IsClustered(false);

                entity.ToTable("CMS_Resource", "dbo");

                entity.HasIndex(e => e.ResourceDisplayName, "IX_CMS_Resource_ResourceDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.ResourceName, "IX_CMS_Resource_ResourceName");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.ResourceAuthor).HasMaxLength(200);

                entity.Property(e => e.ResourceDisplayName).HasMaxLength(100);

                entity.Property(e => e.ResourceGuid).HasColumnName("ResourceGUID");

                entity.Property(e => e.ResourceHasFiles).HasDefaultValueSql("((0))");

                entity.Property(e => e.ResourceInstallationState)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ResourceInstalledVersion)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ResourceName).HasMaxLength(100);

                entity.Property(e => e.ResourceUrl)
                    .HasMaxLength(1000)
                    .HasColumnName("ResourceURL");

                entity.Property(e => e.ResourceVersion).HasMaxLength(200);

                entity.Property(e => e.ShowInDevelopment).HasDefaultValueSql("((0))");

                entity.HasMany(d => d.Sites)
                    .WithMany(p => p.Resources)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsResourceSite",
                        l => l.HasOne<CmsSite>().WithMany().HasForeignKey("SiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_ResourceSite_SiteID_CMS_Site"),
                        r => r.HasOne<CmsResource>().WithMany().HasForeignKey("ResourceId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_ResourceSite_ResourceID_CMS_Resource"),
                        j =>
                        {
                            j.HasKey("ResourceId", "SiteId");

                            j.ToTable("CMS_ResourceSite", "dbo");

                            j.HasIndex(new[] { "SiteId" }, "IX_CMS_ResourceSite_SiteID");

                            j.IndexerProperty<int>("ResourceId").HasColumnName("ResourceID");

                            j.IndexerProperty<int>("SiteId").HasColumnName("SiteID");
                        });
            });

            modelBuilder.Entity<CmsResourceLibrary>(entity =>
            {
                entity.HasKey(e => e.ResourceLibraryId);

                entity.ToTable("CMS_ResourceLibrary", "dbo");

                entity.HasIndex(e => e.ResourceLibraryResourceId, "IX_CMS_ResourceLibrary");

                entity.Property(e => e.ResourceLibraryId).HasColumnName("ResourceLibraryID");

                entity.Property(e => e.ResourceLibraryPath)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ResourceLibraryResourceId).HasColumnName("ResourceLibraryResourceID");

                entity.HasOne(d => d.ResourceLibraryResource)
                    .WithMany(p => p.CmsResourceLibraries)
                    .HasForeignKey(d => d.ResourceLibraryResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ResourceLibrary_CMS_Resource");
            });

            modelBuilder.Entity<CmsResourceString>(entity =>
            {
                entity.HasKey(e => e.StringId);

                entity.ToTable("CMS_ResourceString", "dbo");

                entity.HasIndex(e => e.StringKey, "IX_CMS_ResourceString_StringKey");

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.StringGuid).HasColumnName("StringGUID");

                entity.Property(e => e.StringKey).HasMaxLength(200);
            });

            modelBuilder.Entity<CmsResourceTranslation>(entity =>
            {
                entity.HasKey(e => e.TranslationId);

                entity.ToTable("CMS_ResourceTranslation", "dbo");

                entity.HasIndex(e => e.TranslationCultureId, "IX_CMS_ResourceTranslation_TranslationCultureID");

                entity.HasIndex(e => e.TranslationStringId, "IX_CMS_ResourceTranslation_TranslationStringID");

                entity.Property(e => e.TranslationId).HasColumnName("TranslationID");

                entity.Property(e => e.TranslationCultureId).HasColumnName("TranslationCultureID");

                entity.Property(e => e.TranslationStringId).HasColumnName("TranslationStringID");

                entity.HasOne(d => d.TranslationCulture)
                    .WithMany(p => p.CmsResourceTranslations)
                    .HasForeignKey(d => d.TranslationCultureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ResourceTranslation_TranslationCultureID_CMS_Culture");

                entity.HasOne(d => d.TranslationString)
                    .WithMany(p => p.CmsResourceTranslations)
                    .HasForeignKey(d => d.TranslationStringId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_ResourceTranslation_TranslationStringID_CMS_ResourceString");
            });

            modelBuilder.Entity<CmsRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .IsClustered(false);

                entity.ToTable("CMS_Role", "dbo");

                entity.HasIndex(e => e.RoleGroupId, "IX_CMS_Role_RoleGroupID");

                entity.HasIndex(e => new { e.SiteId, e.RoleId }, "IX_CMS_Role_SiteID_RoleID");

                entity.HasIndex(e => new { e.SiteId, e.RoleName, e.RoleDisplayName }, "IX_CMS_Role_SiteID_RoleName_RoleDisplayName")
                    .IsClustered();

                entity.HasIndex(e => new { e.SiteId, e.RoleName, e.RoleGroupId }, "IX_CMS_Role_SiteID_RoleName_RoleGroupID")
                    .IsUnique();

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleDisplayName).HasMaxLength(100);

                entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");

                entity.Property(e => e.RoleGuid).HasColumnName("RoleGUID");

                entity.Property(e => e.RoleName).HasMaxLength(100);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.RoleGroup)
                    .WithMany(p => p.CmsRoles)
                    .HasForeignKey(d => d.RoleGroupId)
                    .HasConstraintName("FK_CMS_Role_RoleGroupID_Community_Group");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsRoles)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_CMS_Role_SiteID_CMS_SiteID");

                entity.HasMany(d => d.Elements)
                    .WithMany(p => p.Roles)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsRoleApplication",
                        l => l.HasOne<CmsUielement>().WithMany().HasForeignKey("ElementId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_RoleApplication_CMS_UIElement"),
                        r => r.HasOne<CmsRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_RoleApplication_CMS_Role"),
                        j =>
                        {
                            j.HasKey("RoleId", "ElementId");

                            j.ToTable("CMS_RoleApplication", "dbo");

                            j.HasIndex(new[] { "ElementId" }, "IX_CMS_RoleApplication");

                            j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");

                            j.IndexerProperty<int>("ElementId").HasColumnName("ElementID");
                        });

                entity.HasMany(d => d.ElementsNavigation)
                    .WithMany(p => p.RolesNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsRoleUielement",
                        l => l.HasOne<CmsUielement>().WithMany().HasForeignKey("ElementId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_RoleUIElement_ElementID_CMS_UIElement"),
                        r => r.HasOne<CmsRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_RoleUIElement_RoleID_CMS_Role"),
                        j =>
                        {
                            j.HasKey("RoleId", "ElementId");

                            j.ToTable("CMS_RoleUIElement", "dbo");

                            j.HasIndex(new[] { "ElementId" }, "IX_CMS_RoleUIElement_ElementID");

                            j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");

                            j.IndexerProperty<int>("ElementId").HasColumnName("ElementID");
                        });

                entity.HasMany(d => d.Permissions)
                    .WithMany(p => p.Roles)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsRolePermission",
                        l => l.HasOne<CmsPermission>().WithMany().HasForeignKey("PermissionId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_RolePermission_PermissionID_CMS_Permission"),
                        r => r.HasOne<CmsRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_RolePermission_RoleID_CMS_Role"),
                        j =>
                        {
                            j.HasKey("RoleId", "PermissionId");

                            j.ToTable("CMS_RolePermission", "dbo");

                            j.HasIndex(new[] { "PermissionId" }, "IX_CMS_RolePermission_PermissionID");

                            j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");

                            j.IndexerProperty<int>("PermissionId").HasColumnName("PermissionID");
                        });
            });

            modelBuilder.Entity<CmsScheduledTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("CMS_ScheduledTask", "dbo");

                entity.HasIndex(e => new { e.TaskNextRunTime, e.TaskEnabled, e.TaskServerName }, "IX_CMS_ScheduledTask_TaskNextRunTime_TaskEnabled_TaskServerName");

                entity.HasIndex(e => e.TaskResourceId, "IX_CMS_ScheduledTask_TaskResourceID");

                entity.HasIndex(e => new { e.TaskSiteId, e.TaskDisplayName }, "IX_CMS_ScheduledTask_TaskSiteID_TaskDisplayName");

                entity.HasIndex(e => e.TaskUserId, "IX_CMS_ScheduledTask_TaskUserID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskAllowExternalService).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaskAssemblyName).HasMaxLength(200);

                entity.Property(e => e.TaskClass).HasMaxLength(200);

                entity.Property(e => e.TaskCondition).HasMaxLength(400);

                entity.Property(e => e.TaskDisplayName).HasMaxLength(200);

                entity.Property(e => e.TaskExecutingServerName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TaskGuid).HasColumnName("TaskGUID");

                entity.Property(e => e.TaskInterval).HasMaxLength(1000);

                entity.Property(e => e.TaskName).HasMaxLength(200);

                entity.Property(e => e.TaskObjectId).HasColumnName("TaskObjectID");

                entity.Property(e => e.TaskObjectType).HasMaxLength(100);

                entity.Property(e => e.TaskResourceId).HasColumnName("TaskResourceID");

                entity.Property(e => e.TaskServerName).HasMaxLength(100);

                entity.Property(e => e.TaskSiteId).HasColumnName("TaskSiteID");

                entity.Property(e => e.TaskUserId).HasColumnName("TaskUserID");

                entity.HasOne(d => d.TaskResource)
                    .WithMany(p => p.CmsScheduledTasks)
                    .HasForeignKey(d => d.TaskResourceId)
                    .HasConstraintName("FK_CMS_ScheduledTask_TaskResourceID_CMS_Resource");

                entity.HasOne(d => d.TaskSite)
                    .WithMany(p => p.CmsScheduledTasks)
                    .HasForeignKey(d => d.TaskSiteId)
                    .HasConstraintName("FK_CMS_ScheduledTask_TaskSiteID_CMS_Site");

                entity.HasOne(d => d.TaskUser)
                    .WithMany(p => p.CmsScheduledTasks)
                    .HasForeignKey(d => d.TaskUserId)
                    .HasConstraintName("FK_CMS_ScheduledTask_TaskUserID_CMS_User");
            });

            modelBuilder.Entity<CmsSearchEngine>(entity =>
            {
                entity.HasKey(e => e.SearchEngineId);

                entity.ToTable("CMS_SearchEngine", "dbo");

                entity.Property(e => e.SearchEngineId).HasColumnName("SearchEngineID");

                entity.Property(e => e.SearchEngineCrawler).HasMaxLength(200);

                entity.Property(e => e.SearchEngineDisplayName).HasMaxLength(200);

                entity.Property(e => e.SearchEngineDomainRule).HasMaxLength(450);

                entity.Property(e => e.SearchEngineGuid).HasColumnName("SearchEngineGUID");

                entity.Property(e => e.SearchEngineKeywordParameter).HasMaxLength(200);

                entity.Property(e => e.SearchEngineName).HasMaxLength(200);
            });

            modelBuilder.Entity<CmsSearchIndex>(entity =>
            {
                entity.HasKey(e => e.IndexId)
                    .IsClustered(false);

                entity.ToTable("CMS_SearchIndex", "dbo");

                entity.HasIndex(e => e.IndexDisplayName, "IX_CMS_SearchIndex_IndexDisplayName")
                    .IsClustered();

                entity.Property(e => e.IndexId).HasColumnName("IndexID");

                entity.Property(e => e.IndexAdminKey).HasMaxLength(200);

                entity.Property(e => e.IndexAnalyzerType).HasMaxLength(200);

                entity.Property(e => e.IndexCrawlerDomain).HasMaxLength(200);

                entity.Property(e => e.IndexCrawlerFormsUserName).HasMaxLength(200);

                entity.Property(e => e.IndexCrawlerUserName).HasMaxLength(200);

                entity.Property(e => e.IndexCrawlerUserPassword).HasMaxLength(200);

                entity.Property(e => e.IndexCustomAnalyzerAssemblyName).HasMaxLength(200);

                entity.Property(e => e.IndexCustomAnalyzerClassName).HasMaxLength(200);

                entity.Property(e => e.IndexDisplayName).HasMaxLength(200);

                entity.Property(e => e.IndexGuid).HasColumnName("IndexGUID");

                entity.Property(e => e.IndexName).HasMaxLength(200);

                entity.Property(e => e.IndexProvider)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IndexQueryKey).HasMaxLength(200);

                entity.Property(e => e.IndexSearchServiceName).HasMaxLength(200);

                entity.Property(e => e.IndexStatus).HasMaxLength(10);

                entity.Property(e => e.IndexStopWordsFile).HasMaxLength(200);

                entity.Property(e => e.IndexType)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.HasMany(d => d.IndexCultures)
                    .WithMany(p => p.Indices)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsSearchIndexCulture",
                        l => l.HasOne<CmsCulture>().WithMany().HasForeignKey("IndexCultureId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_SearchIndexCulture_IndexCultureID_CMS_Culture"),
                        r => r.HasOne<CmsSearchIndex>().WithMany().HasForeignKey("IndexId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_SearchIndexCulture_IndexID_CMS_SearchIndex"),
                        j =>
                        {
                            j.HasKey("IndexId", "IndexCultureId");

                            j.ToTable("CMS_SearchIndexCulture", "dbo");

                            j.HasIndex(new[] { "IndexCultureId" }, "IX_CMS_SearchIndexCulture_IndexCultureID");

                            j.IndexerProperty<int>("IndexId").HasColumnName("IndexID");

                            j.IndexerProperty<int>("IndexCultureId").HasColumnName("IndexCultureID");
                        });

                entity.HasMany(d => d.IndexSites)
                    .WithMany(p => p.Indices)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsSearchIndexSite",
                        l => l.HasOne<CmsSite>().WithMany().HasForeignKey("IndexSiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_SearchIndexSite_IndexSiteID_CMS_Site"),
                        r => r.HasOne<CmsSearchIndex>().WithMany().HasForeignKey("IndexId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_SearchIndexSite_IndexID_CMS_SearchIndex"),
                        j =>
                        {
                            j.HasKey("IndexId", "IndexSiteId");

                            j.ToTable("CMS_SearchIndexSite", "dbo");

                            j.HasIndex(new[] { "IndexSiteId" }, "IX_CMS_SearchIndexSite_IndexSiteID");

                            j.IndexerProperty<int>("IndexId").HasColumnName("IndexID");

                            j.IndexerProperty<int>("IndexSiteId").HasColumnName("IndexSiteID");
                        });
            });

            modelBuilder.Entity<CmsSearchTask>(entity =>
            {
                entity.HasKey(e => e.SearchTaskId)
                    .IsClustered(false);

                entity.ToTable("CMS_SearchTask", "dbo");

                entity.HasIndex(e => new { e.SearchTaskPriority, e.SearchTaskStatus, e.SearchTaskServerName }, "IX_CMS_SearchTask_SearchTaskPriority_SearchTaskStatus_SearchTaskServerName")
                    .IsClustered();

                entity.Property(e => e.SearchTaskId).HasColumnName("SearchTaskID");

                entity.Property(e => e.SearchTaskCreated).HasDefaultValueSql("('4/15/2009 11:23:52 AM')");

                entity.Property(e => e.SearchTaskField).HasMaxLength(200);

                entity.Property(e => e.SearchTaskObjectType).HasMaxLength(100);

                entity.Property(e => e.SearchTaskRelatedObjectId).HasColumnName("SearchTaskRelatedObjectID");

                entity.Property(e => e.SearchTaskServerName).HasMaxLength(200);

                entity.Property(e => e.SearchTaskStatus)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SearchTaskType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SearchTaskValue)
                    .HasMaxLength(600)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CmsSearchTaskAzure>(entity =>
            {
                entity.HasKey(e => e.SearchTaskAzureId);

                entity.ToTable("CMS_SearchTaskAzure", "dbo");

                entity.HasIndex(e => e.SearchTaskAzurePriority, "IX_CMS_SearchTaskAzure_SearchTaskAzurePriority");

                entity.Property(e => e.SearchTaskAzureId).HasColumnName("SearchTaskAzureID");

                entity.Property(e => e.SearchTaskAzureAdditionalData)
                    .HasMaxLength(600)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SearchTaskAzureCreated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.SearchTaskAzureInitiatorObjectId).HasColumnName("SearchTaskAzureInitiatorObjectID");

                entity.Property(e => e.SearchTaskAzureMetadata).HasMaxLength(200);

                entity.Property(e => e.SearchTaskAzureObjectType).HasMaxLength(100);

                entity.Property(e => e.SearchTaskAzureType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CmsSession>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("CMS_Session", "dbo");

                entity.HasIndex(e => e.SessionIdentificator, "IX_CMS_Session_SessionIdentificator")
                    .IsUnique();

                entity.HasIndex(e => e.SessionSiteId, "IX_CMS_Session_SessionSiteID");

                entity.HasIndex(e => e.SessionUserId, "IX_CMS_Session_SessionUserID");

                entity.HasIndex(e => e.SessionUserIsHidden, "IX_CMS_Session_SessionUserIsHidden");

                entity.Property(e => e.SessionId).HasColumnName("SessionID");

                entity.Property(e => e.SessionContactId).HasColumnName("SessionContactID");

                entity.Property(e => e.SessionEmail).HasMaxLength(254);

                entity.Property(e => e.SessionExpires).HasDefaultValueSql("('9/9/2008 3:45:44 PM')");

                entity.Property(e => e.SessionFullName).HasMaxLength(450);

                entity.Property(e => e.SessionIdentificator)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SessionLastActive).HasDefaultValueSql("('9/9/2008 3:44:26 PM')");

                entity.Property(e => e.SessionLocation).HasMaxLength(450);

                entity.Property(e => e.SessionNickName).HasMaxLength(254);

                entity.Property(e => e.SessionSiteId).HasColumnName("SessionSiteID");

                entity.Property(e => e.SessionUserId).HasColumnName("SessionUserID");

                entity.Property(e => e.SessionUserName).HasMaxLength(254);

                entity.HasOne(d => d.SessionSite)
                    .WithMany(p => p.CmsSessions)
                    .HasForeignKey(d => d.SessionSiteId)
                    .HasConstraintName("FK_CMS_Session_SessionSiteID_CMS_Site");

                entity.HasOne(d => d.SessionUser)
                    .WithMany(p => p.CmsSessions)
                    .HasForeignKey(d => d.SessionUserId)
                    .HasConstraintName("FK_CMS_Session_SessionUserID_CMS_User");
            });

            modelBuilder.Entity<CmsSettingsCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .IsClustered(false);

                entity.ToTable("CMS_SettingsCategory", "dbo");

                entity.HasIndex(e => e.CategoryOrder, "IX_CMS_SettingsCategory_CategoryOrder")
                    .IsClustered();

                entity.HasIndex(e => e.CategoryParentId, "IX_CMS_SettingsCategory_CategoryParentID");

                entity.HasIndex(e => e.CategoryResourceId, "IX_CMS_SettingsCategory_CategoryResourceID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryIconPath).HasMaxLength(200);

                entity.Property(e => e.CategoryIdpath)
                    .HasMaxLength(450)
                    .HasColumnName("CategoryIDPath");

                entity.Property(e => e.CategoryIsCustom).HasDefaultValueSql("((0))");

                entity.Property(e => e.CategoryIsGroup).HasDefaultValueSql("((0))");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategoryResourceId).HasColumnName("CategoryResourceID");

                entity.HasOne(d => d.CategoryParent)
                    .WithMany(p => p.InverseCategoryParent)
                    .HasForeignKey(d => d.CategoryParentId)
                    .HasConstraintName("FK_CMS_SettingsCategory_CMS_SettingsCategory1");

                entity.HasOne(d => d.CategoryResource)
                    .WithMany(p => p.CmsSettingsCategories)
                    .HasForeignKey(d => d.CategoryResourceId)
                    .HasConstraintName("FK_CMS_SettingsCategory_CategoryResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsSettingsKey>(entity =>
            {
                entity.HasKey(e => e.KeyId);

                entity.ToTable("CMS_SettingsKey", "dbo");

                entity.HasIndex(e => e.KeyCategoryId, "IX_CMS_SettingsKey_KeyCategoryID");

                entity.HasIndex(e => new { e.SiteId, e.KeyName }, "IX_CMS_SettingsKey_SiteID_KeyName");

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.KeyCategoryId).HasColumnName("KeyCategoryID");

                entity.Property(e => e.KeyDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyEditingControlPath).HasMaxLength(200);

                entity.Property(e => e.KeyExplanationText).HasDefaultValueSql("(N'')");

                entity.Property(e => e.KeyGuid).HasColumnName("KeyGUID");

                entity.Property(e => e.KeyIsCustom).HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyIsGlobal).HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyIsHidden).HasDefaultValueSql("((0))");

                entity.Property(e => e.KeyName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.KeyValidation).HasMaxLength(255);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.KeyCategory)
                    .WithMany(p => p.CmsSettingsKeys)
                    .HasForeignKey(d => d.KeyCategoryId)
                    .HasConstraintName("FK_CMS_SettingsKey_KeyCategoryID_CMS_SettingsCategory");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsSettingsKeys)
                    .HasForeignKey(d => d.SiteId)
                    .HasConstraintName("FK_CMS_SettingsKey_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsSite>(entity =>
            {
                entity.HasKey(e => e.SiteId)
                    .IsClustered(false);

                entity.ToTable("CMS_Site", "dbo");

                entity.HasIndex(e => e.SiteDefaultEditorStylesheet, "IX_CMS_Site_SiteDefaultEditorStylesheet");

                entity.HasIndex(e => e.SiteDefaultStylesheetId, "IX_CMS_Site_SiteDefaultStylesheetID");

                entity.HasIndex(e => e.SiteDisplayName, "IX_CMS_Site_SiteDisplayName")
                    .IsClustered();

                entity.HasIndex(e => new { e.SiteDomainName, e.SiteStatus }, "IX_CMS_Site_SiteDomainName_SiteStatus");

                entity.HasIndex(e => e.SiteName, "IX_CMS_Site_SiteName");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SiteDefaultStylesheetId).HasColumnName("SiteDefaultStylesheetID");

                entity.Property(e => e.SiteDefaultVisitorCulture).HasMaxLength(50);

                entity.Property(e => e.SiteDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteDomainName)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteGuid).HasColumnName("SiteGUID");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteOfflineRedirectUrl)
                    .HasMaxLength(400)
                    .HasColumnName("SiteOfflineRedirectURL");

                entity.Property(e => e.SitePresentationUrl)
                    .HasMaxLength(400)
                    .HasColumnName("SitePresentationURL");

                entity.Property(e => e.SiteStatus)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.SiteDefaultEditorStylesheetNavigation)
                    .WithMany(p => p.CmsSiteSiteDefaultEditorStylesheetNavigations)
                    .HasForeignKey(d => d.SiteDefaultEditorStylesheet)
                    .HasConstraintName("FK_CMS_Site_SiteDefaultEditorStylesheet_CMS_CssStylesheet");

                entity.HasOne(d => d.SiteDefaultStylesheet)
                    .WithMany(p => p.CmsSiteSiteDefaultStylesheets)
                    .HasForeignKey(d => d.SiteDefaultStylesheetId)
                    .HasConstraintName("FK_CMS_Site_SiteDefaultStylesheetID_CMS_CssStylesheet");

                entity.HasMany(d => d.Cultures)
                    .WithMany(p => p.Sites)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsSiteCulture",
                        l => l.HasOne<CmsCulture>().WithMany().HasForeignKey("CultureId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_SiteCulture_CultureID_CMS_Culture"),
                        r => r.HasOne<CmsSite>().WithMany().HasForeignKey("SiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_SiteCulture_SiteID_CMS_Site"),
                        j =>
                        {
                            j.HasKey("SiteId", "CultureId");

                            j.ToTable("CMS_SiteCulture", "dbo");

                            j.HasIndex(new[] { "CultureId" }, "IX_CMS_SiteCulture_CultureID");

                            j.IndexerProperty<int>("SiteId").HasColumnName("SiteID");

                            j.IndexerProperty<int>("CultureId").HasColumnName("CultureID");
                        });
            });

            modelBuilder.Entity<CmsSiteDomainAlias>(entity =>
            {
                entity.HasKey(e => e.SiteDomainAliasId);

                entity.ToTable("CMS_SiteDomainAlias", "dbo");

                entity.HasIndex(e => e.SiteDomainAliasName, "IX_CMS_SiteDomainAlias_SiteDomainAliasName");

                entity.HasIndex(e => e.SiteId, "IX_CMS_SiteDomainAlias_SiteID");

                entity.Property(e => e.SiteDomainAliasId).HasColumnName("SiteDomainAliasID");

                entity.Property(e => e.SiteDefaultVisitorCulture).HasMaxLength(50);

                entity.Property(e => e.SiteDomainAliasName)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SiteDomainDefaultAliasPath).HasMaxLength(450);

                entity.Property(e => e.SiteDomainGuid).HasColumnName("SiteDomainGUID");

                entity.Property(e => e.SiteDomainRedirectUrl).HasMaxLength(450);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsSiteDomainAliases)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_SiteDomainAlias_SiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsSmtpserver>(entity =>
            {
                entity.HasKey(e => e.ServerId);

                entity.ToTable("CMS_SMTPServer", "dbo");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.ServerDeliveryMethod).HasDefaultValueSql("((0))");

                entity.Property(e => e.ServerGuid).HasColumnName("ServerGUID");

                entity.Property(e => e.ServerName).HasMaxLength(200);

                entity.Property(e => e.ServerPassword).HasMaxLength(200);

                entity.Property(e => e.ServerPickupDirectory).HasMaxLength(450);

                entity.Property(e => e.ServerUseSsl).HasColumnName("ServerUseSSL");

                entity.Property(e => e.ServerUserName).HasMaxLength(50);

                entity.HasMany(d => d.Sites)
                    .WithMany(p => p.Servers)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsSmtpserverSite",
                        l => l.HasOne<CmsSite>().WithMany().HasForeignKey("SiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_SMTPServerSite_CMS_Site"),
                        r => r.HasOne<CmsSmtpserver>().WithMany().HasForeignKey("ServerId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_SMTPServerSite_CMS_SMTPServer"),
                        j =>
                        {
                            j.HasKey("ServerId", "SiteId");

                            j.ToTable("CMS_SMTPServerSite", "dbo");

                            j.HasIndex(new[] { "SiteId" }, "IX_CMS_SMTPServerSite_SiteID");

                            j.IndexerProperty<int>("ServerId").HasColumnName("ServerID");

                            j.IndexerProperty<int>("SiteId").HasColumnName("SiteID");
                        });
            });

            modelBuilder.Entity<CmsState>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .IsClustered(false);

                entity.ToTable("CMS_State", "dbo");

                entity.HasIndex(e => e.CountryId, "IX_CMS_State_CountryID");

                entity.HasIndex(e => e.StateDisplayName, "IX_CMS_State_CountryID_StateDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.StateCode, "IX_CMS_State_StateCode");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.StateCode).HasMaxLength(100);

                entity.Property(e => e.StateDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StateGuid).HasColumnName("StateGUID");

                entity.Property(e => e.StateName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CmsStates)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_State_CountryID_CMS_Country");
            });

            modelBuilder.Entity<CmsTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .IsClustered(false);

                entity.ToTable("CMS_Tag", "dbo");

                entity.HasIndex(e => e.TagGroupId, "IX_CMS_Tag_TagGroupID");

                entity.HasIndex(e => e.TagName, "IX_CMS_Tag_TagName")
                    .IsClustered();

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.TagGroupId).HasColumnName("TagGroupID");

                entity.Property(e => e.TagGuid).HasColumnName("TagGUID");

                entity.Property(e => e.TagName).HasMaxLength(250);

                entity.HasOne(d => d.TagGroup)
                    .WithMany(p => p.CmsTags)
                    .HasForeignKey(d => d.TagGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Tag_TagGroupID_CMS_TagGroup");
            });

            modelBuilder.Entity<CmsTagGroup>(entity =>
            {
                entity.HasKey(e => e.TagGroupId)
                    .IsClustered(false);

                entity.ToTable("CMS_TagGroup", "dbo");

                entity.HasIndex(e => e.TagGroupDisplayName, "IX_CMS_TagGroup_TagGroupDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.TagGroupSiteId, "IX_CMS_TagGroup_TagGroupSiteID");

                entity.Property(e => e.TagGroupId).HasColumnName("TagGroupID");

                entity.Property(e => e.TagGroupDisplayName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TagGroupGuid).HasColumnName("TagGroupGUID");

                entity.Property(e => e.TagGroupName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TagGroupSiteId).HasColumnName("TagGroupSiteID");

                entity.HasOne(d => d.TagGroupSite)
                    .WithMany(p => p.CmsTagGroups)
                    .HasForeignKey(d => d.TagGroupSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_TagGroup_TagGroupSiteID_CMS_Site");
            });

            modelBuilder.Entity<CmsTemplateDeviceLayout>(entity =>
            {
                entity.HasKey(e => e.TemplateDeviceLayoutId);

                entity.ToTable("CMS_TemplateDeviceLayout", "dbo");

                entity.HasIndex(e => e.LayoutId, "IX_CMS_TemplateDeviceLayout_LayoutID");

                entity.HasIndex(e => new { e.PageTemplateId, e.ProfileId }, "IX_CMS_TemplateDeviceLayout_PageTemplateID_ProfileID")
                    .IsUnique();

                entity.HasIndex(e => e.ProfileId, "IX_CMS_TemplateDeviceLayout_ProfileID");

                entity.Property(e => e.TemplateDeviceLayoutId).HasColumnName("TemplateDeviceLayoutID");

                entity.Property(e => e.LayoutCss).HasColumnName("LayoutCSS");

                entity.Property(e => e.LayoutGuid).HasColumnName("LayoutGUID");

                entity.Property(e => e.LayoutId).HasColumnName("LayoutID");

                entity.Property(e => e.LayoutLastModified).HasDefaultValueSql("('7/31/2012 12:10:49 PM')");

                entity.Property(e => e.LayoutType).HasMaxLength(50);

                entity.Property(e => e.LayoutVersionGuid)
                    .HasMaxLength(50)
                    .HasColumnName("LayoutVersionGUID");

                entity.Property(e => e.PageTemplateId).HasColumnName("PageTemplateID");

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.CmsTemplateDeviceLayouts)
                    .HasForeignKey(d => d.LayoutId)
                    .HasConstraintName("FK_CMS_TemplateDeviceLayout_LayoutID_CMS_Layout");

                entity.HasOne(d => d.PageTemplate)
                    .WithMany(p => p.CmsTemplateDeviceLayouts)
                    .HasForeignKey(d => d.PageTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_TemplateDeviceLayout_PageTemplateID_CMS_PageTemplate");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.CmsTemplateDeviceLayouts)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_TemplateDeviceLayout_ProfileID_CMS_DeviceProfile");
            });

            modelBuilder.Entity<CmsTimeZone>(entity =>
            {
                entity.HasKey(e => e.TimeZoneId)
                    .IsClustered(false);

                entity.ToTable("CMS_TimeZone", "dbo");

                entity.HasIndex(e => e.TimeZoneDisplayName, "IX_CMS_TimeZone_TimeZoneDisplayName")
                    .IsClustered();

                entity.Property(e => e.TimeZoneId).HasColumnName("TimeZoneID");

                entity.Property(e => e.TimeZoneDaylight).HasDefaultValueSql("((0))");

                entity.Property(e => e.TimeZoneDisplayName).HasMaxLength(200);

                entity.Property(e => e.TimeZoneGmt).HasColumnName("TimeZoneGMT");

                entity.Property(e => e.TimeZoneGuid).HasColumnName("TimeZoneGUID");

                entity.Property(e => e.TimeZoneName).HasMaxLength(200);

                entity.Property(e => e.TimeZoneRuleEndRule).HasMaxLength(200);

                entity.Property(e => e.TimeZoneRuleStartRule).HasMaxLength(200);
            });

            modelBuilder.Entity<CmsTransformation>(entity =>
            {
                entity.HasKey(e => e.TransformationId)
                    .IsClustered(false);

                entity.ToTable("CMS_Transformation", "dbo");

                entity.HasIndex(e => e.TransformationClassId, "IX_CMS_Transformation_TransformationClassID");

                entity.HasIndex(e => new { e.TransformationClassId, e.TransformationName }, "IX_CMS_Transformation_TransformationClassID_TransformationName")
                    .IsClustered();

                entity.Property(e => e.TransformationId).HasColumnName("TransformationID");

                entity.Property(e => e.TransformationClassId).HasColumnName("TransformationClassID");

                entity.Property(e => e.TransformationCode).HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransformationCss).HasColumnName("TransformationCSS");

                entity.Property(e => e.TransformationGuid).HasColumnName("TransformationGUID");

                entity.Property(e => e.TransformationHierarchicalXml).HasColumnName("TransformationHierarchicalXML");

                entity.Property(e => e.TransformationIsHierarchical).HasDefaultValueSql("((0))");

                entity.Property(e => e.TransformationName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransformationPreferredDocument).HasMaxLength(700);

                entity.Property(e => e.TransformationType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TransformationVersionGuid)
                    .HasMaxLength(50)
                    .HasColumnName("TransformationVersionGUID");

                entity.HasOne(d => d.TransformationClass)
                    .WithMany(p => p.CmsTransformations)
                    .HasForeignKey(d => d.TransformationClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Transformation_TransformationClassID_CMS_Class");
            });

            modelBuilder.Entity<CmsTranslationService>(entity =>
            {
                entity.HasKey(e => e.TranslationServiceId);

                entity.ToTable("CMS_TranslationService", "dbo");

                entity.Property(e => e.TranslationServiceId).HasColumnName("TranslationServiceID");

                entity.Property(e => e.TranslationServiceAssemblyName).HasMaxLength(200);

                entity.Property(e => e.TranslationServiceClassName).HasMaxLength(200);

                entity.Property(e => e.TranslationServiceDisplayName).HasMaxLength(200);

                entity.Property(e => e.TranslationServiceGenerateTargetTag).HasDefaultValueSql("((0))");

                entity.Property(e => e.TranslationServiceGuid).HasColumnName("TranslationServiceGUID");

                entity.Property(e => e.TranslationServiceName).HasMaxLength(200);

                entity.Property(e => e.TranslationServiceParameter).HasMaxLength(1000);

                entity.Property(e => e.TranslationServiceSupportsCancel).HasDefaultValueSql("((0))");

                entity.Property(e => e.TranslationServiceSupportsStatusUpdate).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CmsTranslationSubmission>(entity =>
            {
                entity.HasKey(e => e.SubmissionId);

                entity.ToTable("CMS_TranslationSubmission", "dbo");

                entity.HasIndex(e => e.SubmissionServiceId, "IX_CMS_TranslationSubmission_SubmissionServiceID");

                entity.HasIndex(e => e.SubmissionSubmittedByUserId, "IX_CMS_TranslationSubmission_SubmissionSubmittedByUserID");

                entity.Property(e => e.SubmissionId).HasColumnName("SubmissionID");

                entity.Property(e => e.SubmissionGuid).HasColumnName("SubmissionGUID");

                entity.Property(e => e.SubmissionInstructions).HasMaxLength(500);

                entity.Property(e => e.SubmissionName).HasMaxLength(200);

                entity.Property(e => e.SubmissionServiceId).HasColumnName("SubmissionServiceID");

                entity.Property(e => e.SubmissionSiteId).HasColumnName("SubmissionSiteID");

                entity.Property(e => e.SubmissionSourceCulture).HasMaxLength(10);

                entity.Property(e => e.SubmissionSubmittedByUserId).HasColumnName("SubmissionSubmittedByUserID");

                entity.Property(e => e.SubmissionTargetCulture).HasDefaultValueSql("(N'')");

                entity.Property(e => e.SubmissionTicket).HasMaxLength(200);

                entity.HasOne(d => d.SubmissionService)
                    .WithMany(p => p.CmsTranslationSubmissions)
                    .HasForeignKey(d => d.SubmissionServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_TranslationSubmission_CMS_TranslationService");

                entity.HasOne(d => d.SubmissionSubmittedByUser)
                    .WithMany(p => p.CmsTranslationSubmissions)
                    .HasForeignKey(d => d.SubmissionSubmittedByUserId)
                    .HasConstraintName("FK_CMS_TranslationSubmission_CMS_User");
            });

            modelBuilder.Entity<CmsTranslationSubmissionItem>(entity =>
            {
                entity.HasKey(e => e.SubmissionItemId);

                entity.ToTable("CMS_TranslationSubmissionItem", "dbo");

                entity.HasIndex(e => e.SubmissionItemSubmissionId, "IX_CMS_TranslationSubmissionItem_SubmissionItemSubmissionID");

                entity.Property(e => e.SubmissionItemId).HasColumnName("SubmissionItemID");

                entity.Property(e => e.SubmissionItemGuid).HasColumnName("SubmissionItemGUID");

                entity.Property(e => e.SubmissionItemName).HasMaxLength(200);

                entity.Property(e => e.SubmissionItemObjectId).HasColumnName("SubmissionItemObjectID");

                entity.Property(e => e.SubmissionItemObjectType).HasMaxLength(100);

                entity.Property(e => e.SubmissionItemSourceXliff).HasColumnName("SubmissionItemSourceXLIFF");

                entity.Property(e => e.SubmissionItemSubmissionId).HasColumnName("SubmissionItemSubmissionID");

                entity.Property(e => e.SubmissionItemTargetCulture).HasMaxLength(10);

                entity.Property(e => e.SubmissionItemTargetObjectId).HasColumnName("SubmissionItemTargetObjectID");

                entity.Property(e => e.SubmissionItemTargetXliff).HasColumnName("SubmissionItemTargetXLIFF");

                entity.Property(e => e.SubmissionItemType).HasMaxLength(50);

                entity.HasOne(d => d.SubmissionItemSubmission)
                    .WithMany(p => p.CmsTranslationSubmissionItems)
                    .HasForeignKey(d => d.SubmissionItemSubmissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_TranslationSubmissionItem_CMS_TranslationSubmission");
            });

            modelBuilder.Entity<CmsTree>(entity =>
            {
                entity.HasKey(e => e.NodeId);

                entity.ToTable("CMS_Tree", "dbo");

                entity.HasIndex(e => e.NodeAclid, "IX_CMS_Tree_NodeACLID");

                entity.HasIndex(e => e.NodeAliasPath, "IX_CMS_Tree_NodeAliasPath");

                entity.HasIndex(e => e.NodeClassId, "IX_CMS_Tree_NodeClassID");

                entity.HasIndex(e => e.NodeGroupId, "IX_CMS_Tree_NodeGroupID");

                entity.HasIndex(e => e.NodeLevel, "IX_CMS_Tree_NodeLevel");

                entity.HasIndex(e => e.NodeLinkedNodeId, "IX_CMS_Tree_NodeLinkedNodeID");

                entity.HasIndex(e => e.NodeLinkedNodeSiteId, "IX_CMS_Tree_NodeLinkedNodeSiteID");

                entity.HasIndex(e => e.NodeOriginalNodeId, "IX_CMS_Tree_NodeOriginalNodeID");

                entity.HasIndex(e => e.NodeOwner, "IX_CMS_Tree_NodeOwner");

                entity.HasIndex(e => new { e.NodeParentId, e.NodeAlias, e.NodeName }, "IX_CMS_Tree_NodeParentID_NodeAlias_NodeName");

                entity.HasIndex(e => e.NodeSkuid, "IX_CMS_Tree_NodeSKUID");

                entity.HasIndex(e => new { e.NodeSiteId, e.NodeGuid }, "IX_CMS_Tree_NodeSiteID_NodeGUID")
                    .IsUnique();

                entity.HasIndex(e => e.NodeTemplateId, "IX_CMS_Tree_NodeTemplateID");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.Property(e => e.NodeAclid).HasColumnName("NodeACLID");

                entity.Property(e => e.NodeAlias).HasMaxLength(50);

                entity.Property(e => e.NodeAllowCacheInFileSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.NodeClassId).HasColumnName("NodeClassID");

                entity.Property(e => e.NodeGroupId).HasColumnName("NodeGroupID");

                entity.Property(e => e.NodeGuid).HasColumnName("NodeGUID");

                entity.Property(e => e.NodeHasChildren).HasDefaultValueSql("((0))");

                entity.Property(e => e.NodeHasLinks).HasDefaultValueSql("((0))");

                entity.Property(e => e.NodeInheritPageLevels).HasMaxLength(200);

                entity.Property(e => e.NodeInheritPageTemplate).HasDefaultValueSql("((0))");

                entity.Property(e => e.NodeIsAclowner).HasColumnName("NodeIsACLOwner");

                entity.Property(e => e.NodeLinkedNodeId).HasColumnName("NodeLinkedNodeID");

                entity.Property(e => e.NodeLinkedNodeSiteId).HasColumnName("NodeLinkedNodeSiteID");

                entity.Property(e => e.NodeName).HasMaxLength(100);

                entity.Property(e => e.NodeOriginalNodeId).HasColumnName("NodeOriginalNodeID");

                entity.Property(e => e.NodeParentId).HasColumnName("NodeParentID");

                entity.Property(e => e.NodeSiteId).HasColumnName("NodeSiteID");

                entity.Property(e => e.NodeSkuid).HasColumnName("NodeSKUID");

                entity.Property(e => e.NodeTemplateForAllCultures).HasDefaultValueSql("((0))");

                entity.Property(e => e.NodeTemplateId).HasColumnName("NodeTemplateID");

                entity.Property(e => e.RequiresSsl).HasColumnName("RequiresSSL");

                entity.HasOne(d => d.NodeAcl)
                    .WithMany(p => p.CmsTrees)
                    .HasForeignKey(d => d.NodeAclid)
                    .HasConstraintName("FK_CMS_Tree_NodeACLID_CMS_ACL");

                entity.HasOne(d => d.NodeClass)
                    .WithMany(p => p.CmsTrees)
                    .HasForeignKey(d => d.NodeClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Tree_NodeClassID_CMS_Class");

                entity.HasOne(d => d.NodeGroup)
                    .WithMany(p => p.CmsTrees)
                    .HasForeignKey(d => d.NodeGroupId)
                    .HasConstraintName("FK_CMS_Tree_NodeGroupID_Community_Group");

                entity.HasOne(d => d.NodeLinkedNode)
                    .WithMany(p => p.InverseNodeLinkedNode)
                    .HasForeignKey(d => d.NodeLinkedNodeId)
                    .HasConstraintName("FK_CMS_Tree_NodeLinkedNodeID_CMS_Tree");

                entity.HasOne(d => d.NodeLinkedNodeSite)
                    .WithMany(p => p.CmsTreeNodeLinkedNodeSites)
                    .HasForeignKey(d => d.NodeLinkedNodeSiteId)
                    .HasConstraintName("FK_CMS_Tree_NodeLinkedNodeSiteID_CMS_Site");

                entity.HasOne(d => d.NodeOriginalNode)
                    .WithMany(p => p.InverseNodeOriginalNode)
                    .HasForeignKey(d => d.NodeOriginalNodeId)
                    .HasConstraintName("FK_CMS_Tree_NodeOriginalNodeID_CMS_Tree");

                entity.HasOne(d => d.NodeOwnerNavigation)
                    .WithMany(p => p.CmsTrees)
                    .HasForeignKey(d => d.NodeOwner)
                    .HasConstraintName("FK_CMS_Tree_NodeOwner_CMS_User");

                entity.HasOne(d => d.NodeParent)
                    .WithMany(p => p.InverseNodeParent)
                    .HasForeignKey(d => d.NodeParentId)
                    .HasConstraintName("FK_CMS_Tree_NodeParentID_CMS_Tree");

                entity.HasOne(d => d.NodeSite)
                    .WithMany(p => p.CmsTreeNodeSites)
                    .HasForeignKey(d => d.NodeSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Tree_NodeSiteID_CMS_Site");

                entity.HasOne(d => d.NodeSku)
                    .WithMany(p => p.CmsTrees)
                    .HasForeignKey(d => d.NodeSkuid)
                    .HasConstraintName("FK_CMS_Tree_NodeSKUID_COM_SKU");

                entity.HasOne(d => d.NodeTemplate)
                    .WithMany(p => p.CmsTrees)
                    .HasForeignKey(d => d.NodeTemplateId)
                    .HasConstraintName("FK_CMS_Tree_NodeTemplateID_CMS_PageTemplate");
            });

            modelBuilder.Entity<CmsUielement>(entity =>
            {
                entity.HasKey(e => e.ElementId)
                    .IsClustered(false);

                entity.ToTable("CMS_UIElement", "dbo");

                entity.HasIndex(e => e.ElementGuid, "IX_CMS_UIElement_ElementGUID")
                    .IsUnique();

                entity.HasIndex(e => e.ElementPageTemplateId, "IX_CMS_UIElement_ElementPageTemplateID");

                entity.HasIndex(e => e.ElementParentId, "IX_CMS_UIElement_ElementParentID");

                entity.HasIndex(e => new { e.ElementResourceId, e.ElementLevel, e.ElementParentId, e.ElementOrder, e.ElementCaption }, "IX_CMS_UIElement_ElementResourceID_ElementLevel_ElementParentID_ElementOrder_ElementCaption")
                    .IsClustered();

                entity.Property(e => e.ElementId).HasColumnName("ElementID");

                entity.Property(e => e.ElementCaption).HasMaxLength(200);

                entity.Property(e => e.ElementCheckModuleReadPermission).HasDefaultValueSql("((1))");

                entity.Property(e => e.ElementDisplayName).HasMaxLength(200);

                entity.Property(e => e.ElementFeature).HasMaxLength(200);

                entity.Property(e => e.ElementFromVersion).HasMaxLength(20);

                entity.Property(e => e.ElementGuid).HasColumnName("ElementGUID");

                entity.Property(e => e.ElementIconClass).HasMaxLength(100);

                entity.Property(e => e.ElementIconPath).HasMaxLength(200);

                entity.Property(e => e.ElementIdpath)
                    .HasMaxLength(450)
                    .HasColumnName("ElementIDPath");

                entity.Property(e => e.ElementIsCustom).HasDefaultValueSql("((0))");

                entity.Property(e => e.ElementIsGlobalApplication).HasDefaultValueSql("((0))");

                entity.Property(e => e.ElementIsMenu).HasDefaultValueSql("((0))");

                entity.Property(e => e.ElementName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ElementPageTemplateId).HasColumnName("ElementPageTemplateID");

                entity.Property(e => e.ElementParentId).HasColumnName("ElementParentID");

                entity.Property(e => e.ElementResourceId).HasColumnName("ElementResourceID");

                entity.Property(e => e.ElementSize).HasDefaultValueSql("((0))");

                entity.Property(e => e.ElementTargetUrl)
                    .HasMaxLength(650)
                    .HasColumnName("ElementTargetURL");

                entity.Property(e => e.ElementType).HasMaxLength(50);

                entity.HasOne(d => d.ElementPageTemplate)
                    .WithMany(p => p.CmsUielements)
                    .HasForeignKey(d => d.ElementPageTemplateId)
                    .HasConstraintName("FK_CMS_UIElement_ElementPageTemplateID_CMS_PageTemplate");

                entity.HasOne(d => d.ElementParent)
                    .WithMany(p => p.InverseElementParent)
                    .HasForeignKey(d => d.ElementParentId)
                    .HasConstraintName("FK_CMS_UIElement_ElementParentID_CMS_UIElement");

                entity.HasOne(d => d.ElementResource)
                    .WithMany(p => p.CmsUielements)
                    .HasForeignKey(d => d.ElementResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UIElement_ElementResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsUser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("CMS_User", "dbo");

                entity.HasIndex(e => e.Email, "IX_CMS_User_Email");

                entity.HasIndex(e => e.FullName, "IX_CMS_User_FullName");

                entity.HasIndex(e => new { e.UserEnabled, e.UserIsHidden }, "IX_CMS_User_UserEnabled_UserIsHidden");

                entity.HasIndex(e => e.UserGuid, "IX_CMS_User_UserGUID")
                    .IsUnique();

                entity.HasIndex(e => e.UserName, "IX_CMS_User_UserName")
                    .IsUnique();

                entity.HasIndex(e => e.UserPrivilegeLevel, "IX_CMS_User_UserPrivilegeLevel");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Email).HasMaxLength(254);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.PreferredCultureCode).HasMaxLength(10);

                entity.Property(e => e.PreferredUicultureCode)
                    .HasMaxLength(10)
                    .HasColumnName("PreferredUICultureCode");

                entity.Property(e => e.UserGuid).HasColumnName("UserGUID");

                entity.Property(e => e.UserIsDomain).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserIsExternal).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserIsHidden).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserMfrequired).HasColumnName("UserMFRequired");

                entity.Property(e => e.UserMfsecret).HasColumnName("UserMFSecret");

                entity.Property(e => e.UserMftimestep).HasColumnName("UserMFTimestep");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UserPasswordFormat).HasMaxLength(10);

                entity.Property(e => e.UserSecurityStamp).HasMaxLength(72);

                entity.Property(e => e.UserStartingAliasPath).HasMaxLength(200);

                entity.HasMany(d => d.Forums)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "ForumsForumModerator",
                        l => l.HasOne<ForumsForum>().WithMany().HasForeignKey("ForumId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Forums_ForumModerators_ForumID_Forums_Forum"),
                        r => r.HasOne<CmsUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Forums_ForumModerators_UserID_CMS_User"),
                        j =>
                        {
                            j.HasKey("UserId", "ForumId");

                            j.ToTable("Forums_ForumModerators", "dbo");

                            j.HasIndex(new[] { "ForumId" }, "IX_Forums_ForumModerators_ForumID");

                            j.IndexerProperty<int>("UserId").HasColumnName("UserID");

                            j.IndexerProperty<int>("ForumId").HasColumnName("ForumID");
                        });
            });

            modelBuilder.Entity<CmsUserCulture>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CultureId, e.SiteId });

                entity.ToTable("CMS_UserCulture", "dbo");

                entity.HasIndex(e => e.CultureId, "IX_CMS_UserCulture_CultureID");

                entity.HasIndex(e => e.SiteId, "IX_CMS_UserCulture_SiteID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CultureId).HasColumnName("CultureID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.CmsUserCultures)
                    .HasForeignKey(d => d.CultureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserCulture_CultureID_CMS_Culture");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsUserCultures)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserCulture_SiteID_CMS_Site");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsUserCultures)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserCulture_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsUserMacroIdentity>(entity =>
            {
                entity.HasKey(e => e.UserMacroIdentityId);

                entity.ToTable("CMS_UserMacroIdentity", "dbo");

                entity.HasIndex(e => e.UserMacroIdentityMacroIdentityId, "IX_CMS_UserMacroIdentity_UserMacroIdentityMacroIdentityID");

                entity.HasIndex(e => e.UserMacroIdentityUserId, "UQ_CMS_UserMacroIdentity_UserMacroIdentityUserID")
                    .IsUnique();

                entity.Property(e => e.UserMacroIdentityId).HasColumnName("UserMacroIdentityID");

                entity.Property(e => e.UserMacroIdentityLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.UserMacroIdentityMacroIdentityId).HasColumnName("UserMacroIdentityMacroIdentityID");

                entity.Property(e => e.UserMacroIdentityUserId).HasColumnName("UserMacroIdentityUserID");

                entity.HasOne(d => d.UserMacroIdentityMacroIdentity)
                    .WithMany(p => p.CmsUserMacroIdentities)
                    .HasForeignKey(d => d.UserMacroIdentityMacroIdentityId)
                    .HasConstraintName("FK_CMS_UserMacroIdentity_UserMacroIdentityMacroIdentityID_CMS_MacroIdentity");

                entity.HasOne(d => d.UserMacroIdentityUser)
                    .WithOne(p => p.CmsUserMacroIdentity)
                    .HasForeignKey<CmsUserMacroIdentity>(d => d.UserMacroIdentityUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserMacroIdentity_UserMacroIdentityUserID_CMS_User");
            });

            modelBuilder.Entity<CmsUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.ToTable("CMS_UserRole", "dbo");

                entity.HasIndex(e => e.RoleId, "IX_CMS_UserRole_RoleID");

                entity.HasIndex(e => new { e.RoleId, e.ValidTo, e.UserId }, "IX_CMS_UserRole_UserID");

                entity.HasIndex(e => new { e.UserId, e.RoleId }, "IX_CMS_UserRole_UserID_RoleID")
                    .IsUnique();

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserRole_RoleID_CMS_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserRole_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsUserSetting>(entity =>
            {
                entity.HasKey(e => e.UserSettingsId);

                entity.ToTable("CMS_UserSettings", "dbo");

                entity.HasIndex(e => e.UserActivatedByUserId, "IX_CMS_UserSettings_UserActivatedByUserID");

                entity.HasIndex(e => e.UserAuthenticationGuid, "IX_CMS_UserSettings_UserAuthenticationGUID");

                entity.HasIndex(e => e.UserAvatarId, "IX_CMS_UserSettings_UserAvatarID");

                entity.HasIndex(e => e.UserBadgeId, "IX_CMS_UserSettings_UserBadgeID");

                entity.HasIndex(e => e.UserFacebookId, "IX_CMS_UserSettings_UserFacebookID");

                entity.HasIndex(e => e.UserGender, "IX_CMS_UserSettings_UserGender");

                entity.HasIndex(e => e.UserNickName, "IX_CMS_UserSettings_UserNickName");

                entity.HasIndex(e => e.UserPasswordRequestHash, "IX_CMS_UserSettings_UserPasswordRequestHash");

                entity.HasIndex(e => e.UserSettingsUserGuid, "IX_CMS_UserSettings_UserSettingsUserGUID");

                entity.HasIndex(e => e.UserSettingsUserId, "IX_CMS_UserSettings_UserSettingsUserID")
                    .IsUnique();

                entity.HasIndex(e => e.UserTimeZoneId, "IX_CMS_UserSettings_UserTimeZoneID");

                entity.HasIndex(e => e.UserWaitingForApproval, "IX_CMS_UserSettings_UserWaitingForApproval");

                entity.HasIndex(e => e.WindowsLiveId, "IX_CMS_UserSettings_WindowsLiveID");

                entity.Property(e => e.UserSettingsId).HasColumnName("UserSettingsID");

                entity.Property(e => e.UserAccountLockReason).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserActivatedByUserId).HasColumnName("UserActivatedByUserID");

                entity.Property(e => e.UserAuthenticationGuid).HasColumnName("UserAuthenticationGUID");

                entity.Property(e => e.UserAvatarId).HasColumnName("UserAvatarID");

                entity.Property(e => e.UserAvatarType).HasMaxLength(200);

                entity.Property(e => e.UserBadgeId).HasColumnName("UserBadgeID");

                entity.Property(e => e.UserCampaign).HasMaxLength(200);

                entity.Property(e => e.UserFacebookId)
                    .HasMaxLength(100)
                    .HasColumnName("UserFacebookID");

                entity.Property(e => e.UserIm)
                    .HasMaxLength(100)
                    .HasColumnName("UserIM");

                entity.Property(e => e.UserInvalidLogOnAttempts).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserInvalidLogOnAttemptsHash).HasMaxLength(100);

                entity.Property(e => e.UserLinkedInId)
                    .HasMaxLength(100)
                    .HasColumnName("UserLinkedInID");

                entity.Property(e => e.UserNickName).HasMaxLength(200);

                entity.Property(e => e.UserPasswordRequestHash).HasMaxLength(100);

                entity.Property(e => e.UserPhone).HasMaxLength(26);

                entity.Property(e => e.UserPicture).HasMaxLength(200);

                entity.Property(e => e.UserPosition).HasMaxLength(200);

                entity.Property(e => e.UserSettingsUserGuid).HasColumnName("UserSettingsUserGUID");

                entity.Property(e => e.UserSettingsUserId).HasColumnName("UserSettingsUserID");

                entity.Property(e => e.UserSkype).HasMaxLength(100);

                entity.Property(e => e.UserTimeZoneId).HasColumnName("UserTimeZoneID");

                entity.Property(e => e.UserUrlreferrer)
                    .HasMaxLength(450)
                    .HasColumnName("UserURLReferrer");

                entity.Property(e => e.UserUsedWebParts).HasMaxLength(1000);

                entity.Property(e => e.UserUsedWidgets).HasMaxLength(1000);

                entity.Property(e => e.UserWaitingForApproval).HasDefaultValueSql("((0))");

                entity.Property(e => e.WindowsLiveId)
                    .HasMaxLength(50)
                    .HasColumnName("WindowsLiveID");

                entity.HasOne(d => d.UserActivatedByUser)
                    .WithMany(p => p.CmsUserSettingUserActivatedByUsers)
                    .HasForeignKey(d => d.UserActivatedByUserId)
                    .HasConstraintName("FK_CMS_UserSettings_UserActivatedByUserID_CMS_User");

                entity.HasOne(d => d.UserAvatar)
                    .WithMany(p => p.CmsUserSettings)
                    .HasForeignKey(d => d.UserAvatarId)
                    .HasConstraintName("FK_CMS_UserSettings_UserAvatarID_CMS_Avatar");

                entity.HasOne(d => d.UserBadge)
                    .WithMany(p => p.CmsUserSettings)
                    .HasForeignKey(d => d.UserBadgeId)
                    .HasConstraintName("FK_CMS_UserSettings_UserBadgeID_CMS_Badge");

                entity.HasOne(d => d.UserSettingsUserGu)
                    .WithMany(p => p.CmsUserSettingUserSettingsUserGus)
                    .HasPrincipalKey(p => p.UserGuid)
                    .HasForeignKey(d => d.UserSettingsUserGuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserSettings_UserSettingsUserGUID_CMS_User");

                entity.HasOne(d => d.UserSettingsUser)
                    .WithOne(p => p.CmsUserSettingUserSettingsUser)
                    .HasForeignKey<CmsUserSetting>(d => d.UserSettingsUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserSettings_UserSettingsUserID_CMS_User");

                entity.HasOne(d => d.UserTimeZone)
                    .WithMany(p => p.CmsUserSettings)
                    .HasForeignKey(d => d.UserTimeZoneId)
                    .HasConstraintName("FK_CMS_UserSettings_UserTimeZoneID_CMS_TimeZone");
            });

            modelBuilder.Entity<CmsUserSite>(entity =>
            {
                entity.HasKey(e => e.UserSiteId);

                entity.ToTable("CMS_UserSite", "dbo");

                entity.HasIndex(e => e.SiteId, "IX_CMS_UserSite_SiteID");

                entity.HasIndex(e => new { e.UserId, e.SiteId }, "IX_CMS_UserSite_UserID_SiteID")
                    .IsUnique();

                entity.Property(e => e.UserSiteId).HasColumnName("UserSiteID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.CmsUserSites)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserSite_SiteID_CMS_Site");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsUserSites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_UserSite_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsVersionHistory>(entity =>
            {
                entity.HasKey(e => e.VersionHistoryId)
                    .IsClustered(false);

                entity.ToTable("CMS_VersionHistory", "dbo");

                entity.HasIndex(e => e.DocumentId, "IX_CMS_VersionHistory_DocumentID")
                    .IsClustered();

                entity.HasIndex(e => e.ModifiedByUserId, "IX_CMS_VersionHistory_ModifiedByUserID");

                entity.HasIndex(e => e.NodeSiteId, "IX_CMS_VersionHistory_NodeSiteID");

                entity.HasIndex(e => new { e.ToBePublished, e.PublishFrom, e.PublishTo }, "IX_CMS_VersionHistory_ToBePublished_PublishFrom_PublishTo");

                entity.HasIndex(e => e.VersionClassId, "IX_CMS_VersionHistory_VersionClassID");

                entity.HasIndex(e => new { e.VersionDeletedByUserId, e.VersionDeletedWhen }, "IX_CMS_VersionHistory_VersionDeletedByUserID_VersionDeletedWhen");

                entity.HasIndex(e => e.VersionWorkflowId, "IX_CMS_VersionHistory_VersionWorkflowID");

                entity.HasIndex(e => e.VersionWorkflowStepId, "IX_CMS_VersionHistory_VersionWorkflowStepID");

                entity.Property(e => e.VersionHistoryId).HasColumnName("VersionHistoryID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentNamePath)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ModifiedByUserId).HasColumnName("ModifiedByUserID");

                entity.Property(e => e.NodeSiteId).HasColumnName("NodeSiteID");

                entity.Property(e => e.NodeXml).HasColumnName("NodeXML");

                entity.Property(e => e.VersionClassId).HasColumnName("VersionClassID");

                entity.Property(e => e.VersionDeletedByUserId).HasColumnName("VersionDeletedByUserID");

                entity.Property(e => e.VersionDocumentName).HasMaxLength(100);

                entity.Property(e => e.VersionDocumentType).HasMaxLength(50);

                entity.Property(e => e.VersionMenuRedirectUrl).HasMaxLength(450);

                entity.Property(e => e.VersionNodeAliasPath).HasMaxLength(450);

                entity.Property(e => e.VersionNumber).HasMaxLength(50);

                entity.Property(e => e.VersionWorkflowId).HasColumnName("VersionWorkflowID");

                entity.Property(e => e.VersionWorkflowStepId).HasColumnName("VersionWorkflowStepID");

                entity.HasOne(d => d.ModifiedByUser)
                    .WithMany(p => p.CmsVersionHistoryModifiedByUsers)
                    .HasForeignKey(d => d.ModifiedByUserId)
                    .HasConstraintName("FK_CMS_VersionHistory_ModifiedByUserID_CMS_User");

                entity.HasOne(d => d.NodeSite)
                    .WithMany(p => p.CmsVersionHistories)
                    .HasForeignKey(d => d.NodeSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_VersionHistory_NodeSiteID_CMS_Site");

                entity.HasOne(d => d.VersionClass)
                    .WithMany(p => p.CmsVersionHistories)
                    .HasForeignKey(d => d.VersionClassId)
                    .HasConstraintName("FK_CMS_VersionHistory_VersionClassID_CMS_Class");

                entity.HasOne(d => d.VersionDeletedByUser)
                    .WithMany(p => p.CmsVersionHistoryVersionDeletedByUsers)
                    .HasForeignKey(d => d.VersionDeletedByUserId)
                    .HasConstraintName("FK_CMS_VersionHistory_DeletedByUserID_CMS_User");

                entity.HasOne(d => d.VersionWorkflow)
                    .WithMany(p => p.CmsVersionHistories)
                    .HasForeignKey(d => d.VersionWorkflowId)
                    .HasConstraintName("FK_CMS_VersionHistory_VersionWorkflowID_CMS_Workflow");

                entity.HasOne(d => d.VersionWorkflowStep)
                    .WithMany(p => p.CmsVersionHistories)
                    .HasForeignKey(d => d.VersionWorkflowStepId)
                    .HasConstraintName("FK_CMS_VersionHistory_VersionWorkflowStepID_CMS_WorkflowStep");

                entity.HasMany(d => d.AttachmentHistories)
                    .WithMany(p => p.VersionHistories)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsVersionAttachment",
                        l => l.HasOne<CmsAttachmentHistory>().WithMany().HasForeignKey("AttachmentHistoryId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_VersionAttachment_AttachmentHistoryID_CMS_AttachmentHistory"),
                        r => r.HasOne<CmsVersionHistory>().WithMany().HasForeignKey("VersionHistoryId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_VersionAttachment_VersionHistoryID_CMS_VersionHistory"),
                        j =>
                        {
                            j.HasKey("VersionHistoryId", "AttachmentHistoryId");

                            j.ToTable("CMS_VersionAttachment", "dbo");

                            j.HasIndex(new[] { "AttachmentHistoryId" }, "IX_CMS_VersionAttachment_AttachmentHistoryID");

                            j.IndexerProperty<int>("VersionHistoryId").HasColumnName("VersionHistoryID");

                            j.IndexerProperty<int>("AttachmentHistoryId").HasColumnName("AttachmentHistoryID");
                        });
            });

            modelBuilder.Entity<CmsWebFarmServer>(entity =>
            {
                entity.HasKey(e => e.ServerId)
                    .IsClustered(false);

                entity.ToTable("CMS_WebFarmServer", "dbo");

                entity.HasIndex(e => e.ServerDisplayName, "IX_CMS_WebFarmServer_ServerDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.ServerName, "IX_CMS_WebFarmServer_ServerName")
                    .IsUnique();

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.ServerDisplayName)
                    .HasMaxLength(300)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServerGuid).HasColumnName("ServerGUID");

                entity.Property(e => e.ServerLastModified).HasDefaultValueSql("('9/17/2013 12:18:06 PM')");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(300)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CmsWebFarmServerLog>(entity =>
            {
                entity.HasKey(e => e.WebFarmServerLogId);

                entity.ToTable("CMS_WebFarmServerLog", "dbo");

                entity.Property(e => e.WebFarmServerLogId).HasColumnName("WebFarmServerLogID");

                entity.Property(e => e.LogCode)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");
            });

            modelBuilder.Entity<CmsWebFarmServerMonitoring>(entity =>
            {
                entity.HasKey(e => e.WebFarmServerMonitoringId);

                entity.ToTable("CMS_WebFarmServerMonitoring", "dbo");

                entity.Property(e => e.WebFarmServerMonitoringId).HasColumnName("WebFarmServerMonitoringID");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");
            });

            modelBuilder.Entity<CmsWebFarmServerTask>(entity =>
            {
                entity.HasKey(e => new { e.ServerId, e.TaskId });

                entity.ToTable("CMS_WebFarmServerTask", "dbo");

                entity.HasIndex(e => e.TaskId, "IX_CMS_WebFarmServerTask_TaskID");

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.CmsWebFarmServerTasks)
                    .HasForeignKey(d => d.ServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WebFarmServerTask_ServerID_CMS_WebFarmServer");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.CmsWebFarmServerTasks)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WebFarmServerTask_TaskID_CMS_WebFarmTask");
            });

            modelBuilder.Entity<CmsWebFarmTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("CMS_WebFarmTask", "dbo");

                entity.HasIndex(e => new { e.TaskIsMemory, e.TaskCreated }, "IX_CMS_WebFarmTask_TaskIsMemory_TaskCreated");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskGuid)
                    .HasColumnName("TaskGUID")
                    .HasDefaultValueSql("('00000000-0000-0000-0000-000000000000')");

                entity.Property(e => e.TaskIsMemory).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaskMachineName).HasMaxLength(450);

                entity.Property(e => e.TaskType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CmsWebPart>(entity =>
            {
                entity.HasKey(e => e.WebPartId);

                entity.ToTable("CMS_WebPart", "dbo");

                entity.HasIndex(e => e.WebPartCategoryId, "IX_CMS_WebPart_WebPartCategoryID");

                entity.HasIndex(e => e.WebPartName, "IX_CMS_WebPart_WebPartName");

                entity.HasIndex(e => e.WebPartParentId, "IX_CMS_WebPart_WebPartParentID");

                entity.HasIndex(e => e.WebPartResourceId, "IX_CMS_WebPart_WebPartResourceID");

                entity.Property(e => e.WebPartId).HasColumnName("WebPartID");

                entity.Property(e => e.WebPartCategoryId).HasColumnName("WebPartCategoryID");

                entity.Property(e => e.WebPartCss).HasColumnName("WebPartCSS");

                entity.Property(e => e.WebPartDisplayName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WebPartFileName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WebPartGuid).HasColumnName("WebPartGUID");

                entity.Property(e => e.WebPartIconClass).HasMaxLength(200);

                entity.Property(e => e.WebPartLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.WebPartName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.WebPartParentId).HasColumnName("WebPartParentID");

                entity.Property(e => e.WebPartProperties).HasDefaultValueSql("(N'')");

                entity.Property(e => e.WebPartResourceId).HasColumnName("WebPartResourceID");

                entity.Property(e => e.WebPartSkipInsertProperties).HasDefaultValueSql("((0))");

                entity.Property(e => e.WebPartThumbnailGuid).HasColumnName("WebPartThumbnailGUID");

                entity.HasOne(d => d.WebPartCategory)
                    .WithMany(p => p.CmsWebParts)
                    .HasForeignKey(d => d.WebPartCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WebPart_WebPartCategoryID_CMS_WebPartCategory");

                entity.HasOne(d => d.WebPartParent)
                    .WithMany(p => p.InverseWebPartParent)
                    .HasForeignKey(d => d.WebPartParentId)
                    .HasConstraintName("FK_CMS_WebPart_WebPartParentID_CMS_WebPart");

                entity.HasOne(d => d.WebPartResource)
                    .WithMany(p => p.CmsWebParts)
                    .HasForeignKey(d => d.WebPartResourceId)
                    .HasConstraintName("FK_CMS_WebPart_WebPartResourceID_CMS_Resource");
            });

            modelBuilder.Entity<CmsWebPartCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .IsClustered(false);

                entity.ToTable("CMS_WebPartCategory", "dbo");

                entity.HasIndex(e => e.CategoryParentId, "IX_CMS_WebPartCategory_CategoryParentID");

                entity.HasIndex(e => e.CategoryPath, "IX_CMS_WebPartCategory_CategoryPath")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDisplayName).HasMaxLength(100);

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategoryPath).HasDefaultValueSql("('')");

                entity.HasOne(d => d.CategoryParent)
                    .WithMany(p => p.InverseCategoryParent)
                    .HasForeignKey(d => d.CategoryParentId)
                    .HasConstraintName("FK_CMS_WebPartCategory_CategoryParentID_CMS_WebPartCategory");
            });

            modelBuilder.Entity<CmsWebPartContainer>(entity =>
            {
                entity.HasKey(e => e.ContainerId)
                    .IsClustered(false);

                entity.ToTable("CMS_WebPartContainer", "dbo");

                entity.HasIndex(e => e.ContainerDisplayName, "IX_CMS_WebPartContainer_ContainerDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.ContainerName, "IX_CMS_WebPartContainer_ContainerName");

                entity.Property(e => e.ContainerId).HasColumnName("ContainerID");

                entity.Property(e => e.ContainerCss).HasColumnName("ContainerCSS");

                entity.Property(e => e.ContainerDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContainerGuid).HasColumnName("ContainerGUID");

                entity.Property(e => e.ContainerName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.HasMany(d => d.Sites)
                    .WithMany(p => p.Containers)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsWebPartContainerSite",
                        l => l.HasOne<CmsSite>().WithMany().HasForeignKey("SiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_WebPartContainerSite_SiteID_CMS_Site"),
                        r => r.HasOne<CmsWebPartContainer>().WithMany().HasForeignKey("ContainerId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_WebPartContainerSite_ContainerID_CMS_WebPartContainer"),
                        j =>
                        {
                            j.HasKey("ContainerId", "SiteId");

                            j.ToTable("CMS_WebPartContainerSite", "dbo");

                            j.HasIndex(new[] { "SiteId" }, "IX_CMS_WebPartContainerSite_SiteID");

                            j.IndexerProperty<int>("ContainerId").HasColumnName("ContainerID");

                            j.IndexerProperty<int>("SiteId").HasColumnName("SiteID");
                        });
            });

            modelBuilder.Entity<CmsWebPartLayout>(entity =>
            {
                entity.HasKey(e => e.WebPartLayoutId)
                    .IsClustered(false);

                entity.ToTable("CMS_WebPartLayout", "dbo");

                entity.HasIndex(e => e.WebPartLayoutWebPartId, "IX_CMS_WebPartLayout_WebPartLayoutWebPartID");

                entity.HasIndex(e => new { e.WebPartLayoutWebPartId, e.WebPartLayoutCodeName }, "IX_CMS_WebPartLayout_WebPartLayoutWebPartID_WebPartLayoutCodeName")
                    .IsClustered();

                entity.Property(e => e.WebPartLayoutId).HasColumnName("WebPartLayoutID");

                entity.Property(e => e.WebPartLayoutCodeName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WebPartLayoutCss).HasColumnName("WebPartLayoutCSS");

                entity.Property(e => e.WebPartLayoutDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WebPartLayoutGuid).HasColumnName("WebPartLayoutGUID");

                entity.Property(e => e.WebPartLayoutVersionGuid)
                    .HasMaxLength(100)
                    .HasColumnName("WebPartLayoutVersionGUID");

                entity.Property(e => e.WebPartLayoutWebPartId).HasColumnName("WebPartLayoutWebPartID");

                entity.HasOne(d => d.WebPartLayoutWebPart)
                    .WithMany(p => p.CmsWebPartLayouts)
                    .HasForeignKey(d => d.WebPartLayoutWebPartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WebPartLayout_WebPartLayoutWebPartID_CMS_WebPart");
            });

            modelBuilder.Entity<CmsWebTemplate>(entity =>
            {
                entity.HasKey(e => e.WebTemplateId)
                    .IsClustered(false);

                entity.ToTable("CMS_WebTemplate", "dbo");

                entity.HasIndex(e => e.WebTemplateOrder, "IX_CMS_WebTemplate_WebTemplateOrder")
                    .IsClustered();

                entity.Property(e => e.WebTemplateId).HasColumnName("WebTemplateID");

                entity.Property(e => e.WebTemplateDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WebTemplateFileName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WebTemplateGuid).HasColumnName("WebTemplateGUID");

                entity.Property(e => e.WebTemplateLicenses)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WebTemplateName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WebTemplateOrder).HasDefaultValueSql("((99999))");

                entity.Property(e => e.WebTemplateThumbnailGuid).HasColumnName("WebTemplateThumbnailGUID");
            });

            modelBuilder.Entity<CmsWidget>(entity =>
            {
                entity.HasKey(e => e.WidgetId)
                    .IsClustered(false);

                entity.ToTable("CMS_Widget", "dbo");

                entity.HasIndex(e => e.WidgetCategoryId, "IX_CMS_Widget_WidgetCategoryID");

                entity.HasIndex(e => new { e.WidgetCategoryId, e.WidgetDisplayName }, "IX_CMS_Widget_WidgetCategoryID_WidgetDisplayName")
                    .IsClustered();

                entity.HasIndex(e => new { e.WidgetIsEnabled, e.WidgetForGroup, e.WidgetForEditor, e.WidgetForUser }, "IX_CMS_Widget_WidgetIsEnabled_WidgetForGroup_WidgetForEditor_WidgetForUser");

                entity.HasIndex(e => e.WidgetLayoutId, "IX_CMS_Widget_WidgetLayoutID");

                entity.HasIndex(e => e.WidgetWebPartId, "IX_CMS_Widget_WidgetWebPartID");

                entity.Property(e => e.WidgetId).HasColumnName("WidgetID");

                entity.Property(e => e.WidgetCategoryId).HasColumnName("WidgetCategoryID");

                entity.Property(e => e.WidgetDisplayName).HasMaxLength(100);

                entity.Property(e => e.WidgetGuid).HasColumnName("WidgetGUID");

                entity.Property(e => e.WidgetIconClass).HasMaxLength(200);

                entity.Property(e => e.WidgetLayoutId).HasColumnName("WidgetLayoutID");

                entity.Property(e => e.WidgetName).HasMaxLength(100);

                entity.Property(e => e.WidgetSecurity).HasDefaultValueSql("((2))");

                entity.Property(e => e.WidgetThumbnailGuid).HasColumnName("WidgetThumbnailGUID");

                entity.Property(e => e.WidgetWebPartId).HasColumnName("WidgetWebPartID");

                entity.HasOne(d => d.WidgetCategory)
                    .WithMany(p => p.CmsWidgets)
                    .HasForeignKey(d => d.WidgetCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Widget_WidgetCategoryID_CMS_WidgetCategory");

                entity.HasOne(d => d.WidgetLayout)
                    .WithMany(p => p.CmsWidgets)
                    .HasForeignKey(d => d.WidgetLayoutId)
                    .HasConstraintName("FK_CMS_Widget_WidgetLayoutID_CMS_WebPartLayout");

                entity.HasOne(d => d.WidgetWebPart)
                    .WithMany(p => p.CmsWidgets)
                    .HasForeignKey(d => d.WidgetWebPartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_Widget_WidgetWebPartID_CMS_WebPart");
            });

            modelBuilder.Entity<CmsWidgetCategory>(entity =>
            {
                entity.HasKey(e => e.WidgetCategoryId)
                    .IsClustered(false);

                entity.ToTable("CMS_WidgetCategory", "dbo");

                entity.HasIndex(e => e.WidgetCategoryPath, "IX_CMS_WidgetCategory_CategoryPath")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.WidgetCategoryParentId, "IX_CMS_WidgetCategory_WidgetCategoryParentID");

                entity.Property(e => e.WidgetCategoryId).HasColumnName("WidgetCategoryID");

                entity.Property(e => e.WidgetCategoryDisplayName).HasMaxLength(100);

                entity.Property(e => e.WidgetCategoryGuid).HasColumnName("WidgetCategoryGUID");

                entity.Property(e => e.WidgetCategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.WidgetCategoryName).HasMaxLength(100);

                entity.Property(e => e.WidgetCategoryParentId).HasColumnName("WidgetCategoryParentID");

                entity.HasOne(d => d.WidgetCategoryParent)
                    .WithMany(p => p.InverseWidgetCategoryParent)
                    .HasForeignKey(d => d.WidgetCategoryParentId)
                    .HasConstraintName("FK_CMS_WidgetCategory_WidgetCategoryParentID_CMS_WidgetCategory");
            });

            modelBuilder.Entity<CmsWidgetRole>(entity =>
            {
                entity.HasKey(e => new { e.WidgetId, e.RoleId, e.PermissionId });

                entity.ToTable("CMS_WidgetRole", "dbo");

                entity.HasIndex(e => e.PermissionId, "IX_CMS_WidgetRole_PermissionID");

                entity.HasIndex(e => e.RoleId, "IX_CMS_WidgetRole_RoleID");

                entity.Property(e => e.WidgetId).HasColumnName("WidgetID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.CmsWidgetRoles)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WidgetRole_PermissionID_CMS_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsWidgetRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WidgetRole_RoleID_CMS_Role");

                entity.HasOne(d => d.Widget)
                    .WithMany(p => p.CmsWidgetRoles)
                    .HasForeignKey(d => d.WidgetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WidgetRole_WidgetID_CMS_Widget");
            });

            modelBuilder.Entity<CmsWorkflow>(entity =>
            {
                entity.HasKey(e => e.WorkflowId)
                    .IsClustered(false);

                entity.ToTable("CMS_Workflow", "dbo");

                entity.HasIndex(e => e.WorkflowDisplayName, "IX_CMS_Workflow_WorkflowDisplayName")
                    .IsClustered();

                entity.Property(e => e.WorkflowId).HasColumnName("WorkflowID");

                entity.Property(e => e.WorkflowApprovedTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowArchivedTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowAutoPublishChanges).HasDefaultValueSql("((0))");

                entity.Property(e => e.WorkflowDisplayName).HasDefaultValueSql("('')");

                entity.Property(e => e.WorkflowEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkflowGuid).HasColumnName("WorkflowGUID");

                entity.Property(e => e.WorkflowName)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WorkflowNotificationTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowPublishedTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowReadyForApprovalTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowRejectedTemplateName).HasMaxLength(200);

                entity.Property(e => e.WorkflowSendApproveEmails).HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkflowSendArchiveEmails).HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkflowSendPublishEmails).HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkflowSendReadyForApprovalEmails).HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkflowSendRejectEmails).HasDefaultValueSql("((1))");

                entity.Property(e => e.WorkflowUseCheckinCheckout).HasDefaultValueSql("((0))");

                entity.HasMany(d => d.Users)
                    .WithMany(p => p.Workflows)
                    .UsingEntity<Dictionary<string, object>>(
                        "CmsWorkflowUser",
                        l => l.HasOne<CmsUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_WorkflowUser_UserID_CMS_User"),
                        r => r.HasOne<CmsWorkflow>().WithMany().HasForeignKey("WorkflowId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_CMS_WorkflowUser_WorkflowID_CMS_Workflow"),
                        j =>
                        {
                            j.HasKey("WorkflowId", "UserId").HasName("PK_CMS_WorkflowUser_1");

                            j.ToTable("CMS_WorkflowUser", "dbo");

                            j.HasIndex(new[] { "UserId" }, "IX_CMS_WorkflowUser_UserID");

                            j.IndexerProperty<int>("WorkflowId").HasColumnName("WorkflowID");

                            j.IndexerProperty<int>("UserId").HasColumnName("UserID");
                        });
            });

            modelBuilder.Entity<CmsWorkflowAction>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("CMS_WorkflowAction", "dbo");

                entity.HasIndex(e => e.ActionResourceId, "IX_CMS_WorkflowAction_ActionResourceID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ActionAssemblyName).HasMaxLength(200);

                entity.Property(e => e.ActionClass).HasMaxLength(200);

                entity.Property(e => e.ActionDisplayName).HasMaxLength(200);

                entity.Property(e => e.ActionEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ActionGuid).HasColumnName("ActionGUID");

                entity.Property(e => e.ActionIconClass).HasMaxLength(200);

                entity.Property(e => e.ActionIconGuid).HasColumnName("ActionIconGUID");

                entity.Property(e => e.ActionName).HasMaxLength(200);

                entity.Property(e => e.ActionResourceId).HasColumnName("ActionResourceID");

                entity.Property(e => e.ActionThumbnailClass).HasMaxLength(200);

                entity.Property(e => e.ActionThumbnailGuid).HasColumnName("ActionThumbnailGUID");

                entity.HasOne(d => d.ActionResource)
                    .WithMany(p => p.CmsWorkflowActions)
                    .HasForeignKey(d => d.ActionResourceId)
                    .HasConstraintName("FK_CMS_WorkflowAction_ActionResourceID");
            });

            modelBuilder.Entity<CmsWorkflowHistory>(entity =>
            {
                entity.HasKey(e => e.WorkflowHistoryId);

                entity.ToTable("CMS_WorkflowHistory", "dbo");

                entity.HasIndex(e => e.ApprovedByUserId, "IX_CMS_WorkflowHistory_ApprovedByUserID");

                entity.HasIndex(e => e.ApprovedWhen, "IX_CMS_WorkflowHistory_ApprovedWhen");

                entity.HasIndex(e => e.HistoryWorkflowId, "IX_CMS_WorkflowHistory_HistoryWorkflowID");

                entity.HasIndex(e => e.StepId, "IX_CMS_WorkflowHistory_StepID");

                entity.HasIndex(e => e.TargetStepId, "IX_CMS_WorkflowHistory_TargetStepID");

                entity.HasIndex(e => e.VersionHistoryId, "IX_CMS_WorkflowHistory_VersionHistoryID");

                entity.Property(e => e.WorkflowHistoryId).HasColumnName("WorkflowHistoryID");

                entity.Property(e => e.ApprovedByUserId).HasColumnName("ApprovedByUserID");

                entity.Property(e => e.HistoryObjectId).HasColumnName("HistoryObjectID");

                entity.Property(e => e.HistoryObjectType).HasMaxLength(100);

                entity.Property(e => e.HistoryRejected).HasDefaultValueSql("((0))");

                entity.Property(e => e.HistoryWorkflowId).HasColumnName("HistoryWorkflowID");

                entity.Property(e => e.StepDisplayName).HasMaxLength(450);

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.StepName).HasMaxLength(440);

                entity.Property(e => e.TargetStepDisplayName).HasMaxLength(450);

                entity.Property(e => e.TargetStepId).HasColumnName("TargetStepID");

                entity.Property(e => e.TargetStepName).HasMaxLength(440);

                entity.Property(e => e.VersionHistoryId).HasColumnName("VersionHistoryID");

                entity.HasOne(d => d.ApprovedByUser)
                    .WithMany(p => p.CmsWorkflowHistories)
                    .HasForeignKey(d => d.ApprovedByUserId)
                    .HasConstraintName("FK_CMS_WorkflowHistory_ApprovedByUserID_CMS_User");

                entity.HasOne(d => d.HistoryWorkflow)
                    .WithMany(p => p.CmsWorkflowHistories)
                    .HasForeignKey(d => d.HistoryWorkflowId)
                    .HasConstraintName("FK_CMS_WorkflowHistory_HistoryWorkflowID_CMS_Workflow");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.CmsWorkflowHistorySteps)
                    .HasForeignKey(d => d.StepId)
                    .HasConstraintName("FK_CMS_WorkflowHistory_StepID_CMS_WorkflowStep");

                entity.HasOne(d => d.TargetStep)
                    .WithMany(p => p.CmsWorkflowHistoryTargetSteps)
                    .HasForeignKey(d => d.TargetStepId)
                    .HasConstraintName("FK_CMS_WorkflowHistory_TargetStepID_CMS_WorkflowStep");

                entity.HasOne(d => d.VersionHistory)
                    .WithMany(p => p.CmsWorkflowHistories)
                    .HasForeignKey(d => d.VersionHistoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowHistory_VersionHistoryID_CMS_VersionHistory");
            });

            modelBuilder.Entity<CmsWorkflowScope>(entity =>
            {
                entity.HasKey(e => e.ScopeId)
                    .IsClustered(false);

                entity.ToTable("CMS_WorkflowScope", "dbo");

                entity.HasIndex(e => e.ScopeClassId, "IX_CMS_WorkflowScope_ScopeClassID");

                entity.HasIndex(e => e.ScopeCultureId, "IX_CMS_WorkflowScope_ScopeCultureID");

                entity.HasIndex(e => e.ScopeSiteId, "IX_CMS_WorkflowScope_ScopeSiteID");

                entity.HasIndex(e => e.ScopeStartingPath, "IX_CMS_WorkflowScope_ScopeStartingPath")
                    .IsClustered();

                entity.HasIndex(e => e.ScopeWorkflowId, "IX_CMS_WorkflowScope_ScopeWorkflowID");

                entity.Property(e => e.ScopeId).HasColumnName("ScopeID");

                entity.Property(e => e.ScopeClassId).HasColumnName("ScopeClassID");

                entity.Property(e => e.ScopeCultureId).HasColumnName("ScopeCultureID");

                entity.Property(e => e.ScopeGuid).HasColumnName("ScopeGUID");

                entity.Property(e => e.ScopeSiteId).HasColumnName("ScopeSiteID");

                entity.Property(e => e.ScopeWorkflowId).HasColumnName("ScopeWorkflowID");

                entity.HasOne(d => d.ScopeClass)
                    .WithMany(p => p.CmsWorkflowScopes)
                    .HasForeignKey(d => d.ScopeClassId)
                    .HasConstraintName("FK_CMS_WorkflowScope_ScopeClassID_CMS_Class");

                entity.HasOne(d => d.ScopeCulture)
                    .WithMany(p => p.CmsWorkflowScopes)
                    .HasForeignKey(d => d.ScopeCultureId)
                    .HasConstraintName("FK_CMS_WorkflowScope_ScopeCultureID_CMS_Culture");

                entity.HasOne(d => d.ScopeSite)
                    .WithMany(p => p.CmsWorkflowScopes)
                    .HasForeignKey(d => d.ScopeSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowScope_ScopeSiteID_CMS_Site");

                entity.HasOne(d => d.ScopeWorkflow)
                    .WithMany(p => p.CmsWorkflowScopes)
                    .HasForeignKey(d => d.ScopeWorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowScope_ScopeWorkflowID_CMS_WorkflowID");
            });

            modelBuilder.Entity<CmsWorkflowStep>(entity =>
            {
                entity.HasKey(e => e.StepId);

                entity.ToTable("CMS_WorkflowStep", "dbo");

                entity.HasIndex(e => e.StepActionId, "IX_CMS_WorkflowStep_StepActionID");

                entity.HasIndex(e => new { e.StepId, e.StepName }, "IX_CMS_WorkflowStep_StepID_StepName");

                entity.HasIndex(e => new { e.StepWorkflowId, e.StepName }, "IX_CMS_WorkflowStep_StepWorkflowID_StepName")
                    .IsUnique();

                entity.HasIndex(e => new { e.StepWorkflowId, e.StepOrder }, "IX_CMS_WorkflowStep_StepWorkflowID_StepOrder");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.StepActionId).HasColumnName("StepActionID");

                entity.Property(e => e.StepAllowPublish).HasDefaultValueSql("((0))");

                entity.Property(e => e.StepAllowReject).HasDefaultValueSql("((1))");

                entity.Property(e => e.StepApprovedTemplateName).HasMaxLength(200);

                entity.Property(e => e.StepDisplayName).HasMaxLength(450);

                entity.Property(e => e.StepGuid).HasColumnName("StepGUID");

                entity.Property(e => e.StepName).HasMaxLength(440);

                entity.Property(e => e.StepReadyforApprovalTemplateName).HasMaxLength(200);

                entity.Property(e => e.StepRejectedTemplateName).HasMaxLength(200);

                entity.Property(e => e.StepWorkflowId).HasColumnName("StepWorkflowID");

                entity.HasOne(d => d.StepAction)
                    .WithMany(p => p.CmsWorkflowSteps)
                    .HasForeignKey(d => d.StepActionId)
                    .HasConstraintName("FK_CMS_WorkflowStep_StepActionID");

                entity.HasOne(d => d.StepWorkflow)
                    .WithMany(p => p.CmsWorkflowSteps)
                    .HasForeignKey(d => d.StepWorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowStep_StepWorkflowID");
            });

            modelBuilder.Entity<CmsWorkflowStepRole>(entity =>
            {
                entity.HasKey(e => e.WorkflowStepRoleId)
                    .IsClustered(false);

                entity.ToTable("CMS_WorkflowStepRoles", "dbo");

                entity.HasIndex(e => e.RoleId, "IX_CMS_WorkflowStepRoles_RoleID");

                entity.HasIndex(e => new { e.StepId, e.StepSourcePointGuid, e.RoleId }, "IX_CMS_WorkflowStepRoles_StepID_StepSourcePointGUID_RoleID")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.WorkflowStepRoleId).HasColumnName("WorkflowStepRoleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.StepSourcePointGuid).HasColumnName("StepSourcePointGUID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CmsWorkflowStepRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowStepRoles_RoleID_CMS_Role");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.CmsWorkflowStepRoles)
                    .HasForeignKey(d => d.StepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowStepRoles_StepID_CMS_WorkflowStep");
            });

            modelBuilder.Entity<CmsWorkflowStepUser>(entity =>
            {
                entity.HasKey(e => e.WorkflowStepUserId)
                    .IsClustered(false);

                entity.ToTable("CMS_WorkflowStepUser", "dbo");

                entity.HasIndex(e => new { e.StepId, e.StepSourcePointGuid, e.UserId }, "IX_CMS_WorkflowStepUser_StepID_StepSourcePointGUID_UserID")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.UserId, "IX_CMS_WorkflowStepUser_UserID");

                entity.Property(e => e.WorkflowStepUserId).HasColumnName("WorkflowStepUserID");

                entity.Property(e => e.StepId).HasColumnName("StepID");

                entity.Property(e => e.StepSourcePointGuid).HasColumnName("StepSourcePointGUID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Step)
                    .WithMany(p => p.CmsWorkflowStepUsers)
                    .HasForeignKey(d => d.StepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowStepUser_StepID_CMS_WorkflowStep");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CmsWorkflowStepUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowStepUser_UserID_CMS_User");
            });

            modelBuilder.Entity<CmsWorkflowTransition>(entity =>
            {
                entity.HasKey(e => e.TransitionId);

                entity.ToTable("CMS_WorkflowTransition", "dbo");

                entity.HasIndex(e => e.TransitionEndStepId, "IX_CMS_WorkflowTransition_TransitionEndStepID");

                entity.HasIndex(e => new { e.TransitionStartStepId, e.TransitionSourcePointGuid, e.TransitionEndStepId }, "IX_CMS_WorkflowTransition_TransitionStartStepID_TransitionSourcePointGUID_TransitionEndStepID")
                    .IsUnique();

                entity.HasIndex(e => e.TransitionWorkflowId, "IX_CMS_WorkflowTransition_TransitionWorkflowID");

                entity.Property(e => e.TransitionId).HasColumnName("TransitionID");

                entity.Property(e => e.TransitionEndStepId).HasColumnName("TransitionEndStepID");

                entity.Property(e => e.TransitionSourcePointGuid).HasColumnName("TransitionSourcePointGUID");

                entity.Property(e => e.TransitionStartStepId).HasColumnName("TransitionStartStepID");

                entity.Property(e => e.TransitionWorkflowId).HasColumnName("TransitionWorkflowID");

                entity.HasOne(d => d.TransitionEndStep)
                    .WithMany(p => p.CmsWorkflowTransitionTransitionEndSteps)
                    .HasForeignKey(d => d.TransitionEndStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowTransition_TransitionEndStepID_CMS_WorkflowStep");

                entity.HasOne(d => d.TransitionStartStep)
                    .WithMany(p => p.CmsWorkflowTransitionTransitionStartSteps)
                    .HasForeignKey(d => d.TransitionStartStepId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowTransition_TransitionStartStepID_CMS_WorkflowStep");

                entity.HasOne(d => d.TransitionWorkflow)
                    .WithMany(p => p.CmsWorkflowTransitions)
                    .HasForeignKey(d => d.TransitionWorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CMS_WorkflowTransition_TransitionWorkflowID_CMS_Workflow");
            });

            modelBuilder.Entity<ComAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PK_COM_CustomerAdress");

                entity.ToTable("COM_Address", "dbo");

                entity.HasIndex(e => e.AddressCountryId, "IX_COM_Address_AddressCountryID");

                entity.HasIndex(e => e.AddressCustomerId, "IX_COM_Address_AddressCustomerID");

                entity.HasIndex(e => e.AddressStateId, "IX_COM_Address_AddressStateID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressCity)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressCountryId).HasColumnName("AddressCountryID");

                entity.Property(e => e.AddressCustomerId).HasColumnName("AddressCustomerID");

                entity.Property(e => e.AddressGuid).HasColumnName("AddressGUID");

                entity.Property(e => e.AddressLastModified).HasDefaultValueSql("('10/18/2012 3:39:07 PM')");

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.AddressName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddressPersonalName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AddressPhone).HasMaxLength(26);

                entity.Property(e => e.AddressStateId).HasColumnName("AddressStateID");

                entity.Property(e => e.AddressZip)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.AddressCountry)
                    .WithMany(p => p.ComAddresses)
                    .HasForeignKey(d => d.AddressCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Address_AddressCountryID_CMS_Country");

                entity.HasOne(d => d.AddressCustomer)
                    .WithMany(p => p.ComAddresses)
                    .HasForeignKey(d => d.AddressCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Address_AddressCustomerID_COM_Customer");

                entity.HasOne(d => d.AddressState)
                    .WithMany(p => p.ComAddresses)
                    .HasForeignKey(d => d.AddressStateId)
                    .HasConstraintName("FK_COM_Address_AddressStateID_CMS_State");
            });

            modelBuilder.Entity<ComBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.ToTable("COM_Brand", "dbo");

                entity.HasIndex(e => e.BrandDisplayName, "IX_COM_Brand_BrandDisplayName");

                entity.HasIndex(e => new { e.BrandSiteId, e.BrandEnabled }, "IX_COM_Brand_BrandSiteID_BrandEnabled");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BrandEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BrandHomepage).HasMaxLength(400);

                entity.Property(e => e.BrandLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BrandSiteId).HasColumnName("BrandSiteID");

                entity.Property(e => e.BrandThumbnailGuid).HasColumnName("BrandThumbnailGUID");

                entity.HasOne(d => d.BrandSite)
                    .WithMany(p => p.ComBrands)
                    .HasForeignKey(d => d.BrandSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Brand_BrandSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComCarrier>(entity =>
            {
                entity.HasKey(e => e.CarrierId);

                entity.ToTable("COM_Carrier", "dbo");

                entity.HasIndex(e => e.CarrierSiteId, "IX_COM_Carrier_CarrierSiteID");

                entity.Property(e => e.CarrierId).HasColumnName("CarrierID");

                entity.Property(e => e.CarrierAssemblyName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CarrierClassName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CarrierDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CarrierGuid).HasColumnName("CarrierGUID");

                entity.Property(e => e.CarrierLastModified).HasDefaultValueSql("('9/22/2014 3:00:14 PM')");

                entity.Property(e => e.CarrierName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CarrierSiteId).HasColumnName("CarrierSiteID");

                entity.HasOne(d => d.CarrierSite)
                    .WithMany(p => p.ComCarriers)
                    .HasForeignKey(d => d.CarrierSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Carrier_CarrierSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComCollection>(entity =>
            {
                entity.HasKey(e => e.CollectionId);

                entity.ToTable("COM_Collection", "dbo");

                entity.HasIndex(e => e.CollectionDisplayName, "IX_COM_Collection_CollectionDisplayName");

                entity.HasIndex(e => new { e.CollectionSiteId, e.CollectionEnabled }, "IX_COM_Collection_CollectionSiteID_CollectionEnabled");

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.CollectionDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CollectionEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CollectionLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.CollectionName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CollectionSiteId).HasColumnName("CollectionSiteID");

                entity.HasOne(d => d.CollectionSite)
                    .WithMany(p => p.ComCollections)
                    .HasForeignKey(d => d.CollectionSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Collection_CollectionSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComCouponCode>(entity =>
            {
                entity.HasKey(e => e.CouponCodeId);

                entity.ToTable("COM_CouponCode", "dbo");

                entity.HasIndex(e => e.CouponCodeDiscountId, "IX_COM_CouponCode_CouponCodeDiscountID");

                entity.Property(e => e.CouponCodeId).HasColumnName("CouponCodeID");

                entity.Property(e => e.CouponCodeCode)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CouponCodeDiscountId).HasColumnName("CouponCodeDiscountID");

                entity.Property(e => e.CouponCodeGuid).HasColumnName("CouponCodeGUID");

                entity.HasOne(d => d.CouponCodeDiscount)
                    .WithMany(p => p.ComCouponCodes)
                    .HasForeignKey(d => d.CouponCodeDiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_CouponCode_CouponCodeDiscountID_COM_Discount");
            });

            modelBuilder.Entity<ComCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId);

                entity.ToTable("COM_Currency", "dbo");

                entity.HasIndex(e => e.CurrencyDisplayName, "IX_COM_Currency_CurrencyDisplayName");

                entity.HasIndex(e => e.CurrencySiteId, "IX_COM_Currency_CurrencySiteID");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyFormatString)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencyGuid).HasColumnName("CurrencyGUID");

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CurrencySiteId).HasColumnName("CurrencySiteID");

                entity.HasOne(d => d.CurrencySite)
                    .WithMany(p => p.ComCurrencies)
                    .HasForeignKey(d => d.CurrencySiteId)
                    .HasConstraintName("FK_COM_Currency_CurrencySiteID_CMS_Site");
            });

            modelBuilder.Entity<ComCurrencyExchangeRate>(entity =>
            {
                entity.HasKey(e => e.ExchagneRateId);

                entity.ToTable("COM_CurrencyExchangeRate", "dbo");

                entity.HasIndex(e => e.ExchangeRateToCurrencyId, "IX_COM_CurrencyExchangeRate_ExchangeRateToCurrencyID");

                entity.HasIndex(e => e.ExchangeTableId, "IX_COM_CurrencyExchangeRate_ExchangeTableID");

                entity.Property(e => e.ExchagneRateId).HasColumnName("ExchagneRateID");

                entity.Property(e => e.ExchangeRateGuid).HasColumnName("ExchangeRateGUID");

                entity.Property(e => e.ExchangeRateToCurrencyId).HasColumnName("ExchangeRateToCurrencyID");

                entity.Property(e => e.ExchangeRateValue).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.ExchangeTableId).HasColumnName("ExchangeTableID");

                entity.HasOne(d => d.ExchangeRateToCurrency)
                    .WithMany(p => p.ComCurrencyExchangeRates)
                    .HasForeignKey(d => d.ExchangeRateToCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_CurrencyExchangeRate_ExchangeRateToCurrencyID_COM_Currency");

                entity.HasOne(d => d.ExchangeTable)
                    .WithMany(p => p.ComCurrencyExchangeRates)
                    .HasForeignKey(d => d.ExchangeTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_CurrencyExchangeRate_ExchangeTableID_COM_ExchangeTable");
            });

            modelBuilder.Entity<ComCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("COM_Customer", "dbo");

                entity.HasIndex(e => e.CustomerCompany, "IX_COM_Customer_CustomerCompany")
                    .HasFilter("([CustomerCompany] IS NOT NULL)")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CustomerEmail, "IX_COM_Customer_CustomerEmail");

                entity.HasIndex(e => e.CustomerFirstName, "IX_COM_Customer_CustomerFirstName");

                entity.HasIndex(e => e.CustomerLastName, "IX_COM_Customer_CustomerLastName");

                entity.HasIndex(e => e.CustomerSiteId, "IX_COM_Customer_CustomerSiteID");

                entity.HasIndex(e => e.CustomerUserId, "IX_COM_Customer_CustomerUserID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerCompany).HasMaxLength(200);

                entity.Property(e => e.CustomerEmail).HasMaxLength(254);

                entity.Property(e => e.CustomerFax).HasMaxLength(50);

                entity.Property(e => e.CustomerFirstName).HasMaxLength(200);

                entity.Property(e => e.CustomerGuid).HasColumnName("CustomerGUID");

                entity.Property(e => e.CustomerLastName).HasMaxLength(200);

                entity.Property(e => e.CustomerOrganizationId)
                    .HasMaxLength(50)
                    .HasColumnName("CustomerOrganizationID");

                entity.Property(e => e.CustomerPhone).HasMaxLength(26);

                entity.Property(e => e.CustomerSiteId).HasColumnName("CustomerSiteID");

                entity.Property(e => e.CustomerTaxRegistrationId)
                    .HasMaxLength(50)
                    .HasColumnName("CustomerTaxRegistrationID");

                entity.Property(e => e.CustomerUserId).HasColumnName("CustomerUserID");

                entity.HasOne(d => d.CustomerSite)
                    .WithMany(p => p.ComCustomers)
                    .HasForeignKey(d => d.CustomerSiteId)
                    .HasConstraintName("FK_COM_Customer_CustomerSiteID_CMS_Site");

                entity.HasOne(d => d.CustomerUser)
                    .WithMany(p => p.ComCustomers)
                    .HasForeignKey(d => d.CustomerUserId)
                    .HasConstraintName("FK_COM_Customer_CustomerUserID_CMS_User");
            });

            modelBuilder.Entity<ComCustomerCreditHistory>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("COM_CustomerCreditHistory", "dbo");

                entity.HasIndex(e => new { e.EventCustomerId, e.EventDate }, "IX_COM_CustomerCreditHistory_EventCustomerID_EventDate");

                entity.HasIndex(e => e.EventSiteId, "IX_COM_CustomerCreditHistory_EventSiteID");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventCreditChange).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.EventCreditGuid).HasColumnName("EventCreditGUID");

                entity.Property(e => e.EventCreditLastModified).HasDefaultValueSql("('9/26/2012 12:21:38 PM')");

                entity.Property(e => e.EventCustomerId).HasColumnName("EventCustomerID");

                entity.Property(e => e.EventDate).HasDefaultValueSql("('9/27/2012 2:48:56 PM')");

                entity.Property(e => e.EventName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EventSiteId).HasColumnName("EventSiteID");

                entity.HasOne(d => d.EventCustomer)
                    .WithMany(p => p.ComCustomerCreditHistories)
                    .HasForeignKey(d => d.EventCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_CustomerCreditHistory_EventCustomerID_COM_Customer");

                entity.HasOne(d => d.EventSite)
                    .WithMany(p => p.ComCustomerCreditHistories)
                    .HasForeignKey(d => d.EventSiteId)
                    .HasConstraintName("FK_COM_CustomerCreditHistory_EventSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("COM_Department", "dbo");

                entity.HasIndex(e => e.DepartmentDefaultTaxClassId, "IX_COM_Department_DepartmentDefaultTaxClassID");

                entity.HasIndex(e => e.DepartmentDisplayName, "IX_COM_Department_DepartmentDisplayName");

                entity.HasIndex(e => new { e.DepartmentName, e.DepartmentSiteId }, "IX_COM_Department_DepartmentName_DepartmentSiteID")
                    .IsUnique();

                entity.HasIndex(e => e.DepartmentSiteId, "IX_COM_Department_DepartmentSiteID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentDefaultTaxClassId).HasColumnName("DepartmentDefaultTaxClassID");

                entity.Property(e => e.DepartmentDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DepartmentGuid).HasColumnName("DepartmentGUID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DepartmentSiteId).HasColumnName("DepartmentSiteID");

                entity.HasOne(d => d.DepartmentDefaultTaxClass)
                    .WithMany(p => p.ComDepartments)
                    .HasForeignKey(d => d.DepartmentDefaultTaxClassId)
                    .HasConstraintName("FK_COM_Department_DepartmentDefaultTaxClassID_COM_TaxClass");

                entity.HasOne(d => d.DepartmentSite)
                    .WithMany(p => p.ComDepartments)
                    .HasForeignKey(d => d.DepartmentSiteId)
                    .HasConstraintName("FK_COM_Department_DepartmentSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComDiscount>(entity =>
            {
                entity.HasKey(e => e.DiscountId);

                entity.ToTable("COM_Discount", "dbo");

                entity.HasIndex(e => e.DiscountSiteId, "IX_COM_Discount_DiscountSiteID");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.DiscountApplyFurtherDiscounts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DiscountApplyTo)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('Order')");

                entity.Property(e => e.DiscountCustomerRestriction).HasMaxLength(200);

                entity.Property(e => e.DiscountDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DiscountEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DiscountGuid).HasColumnName("DiscountGUID");

                entity.Property(e => e.DiscountName).HasMaxLength(200);

                entity.Property(e => e.DiscountOrder).HasDefaultValueSql("((1))");

                entity.Property(e => e.DiscountOrderAmount).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.DiscountRoles).HasMaxLength(400);

                entity.Property(e => e.DiscountSiteId).HasColumnName("DiscountSiteID");

                entity.Property(e => e.DiscountValue).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.DiscountSite)
                    .WithMany(p => p.ComDiscounts)
                    .HasForeignKey(d => d.DiscountSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Discount_DiscountSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComExchangeTable>(entity =>
            {
                entity.HasKey(e => e.ExchangeTableId)
                    .IsClustered(false);

                entity.ToTable("COM_ExchangeTable", "dbo");

                entity.HasIndex(e => e.ExchangeTableSiteId, "IX_COM_ExchangeTable_ExchangeTableSiteID");

                entity.HasIndex(e => new { e.ExchangeTableValidFrom, e.ExchangeTableValidTo }, "IX_COM_ExchangeTable_ExchangeTableValidFrom_ExchangeTableValidTo")
                    .IsClustered();

                entity.Property(e => e.ExchangeTableId).HasColumnName("ExchangeTableID");

                entity.Property(e => e.ExchangeTableDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExchangeTableGuid).HasColumnName("ExchangeTableGUID");

                entity.Property(e => e.ExchangeTableRateFromGlobalCurrency).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.ExchangeTableSiteId).HasColumnName("ExchangeTableSiteID");

                entity.HasOne(d => d.ExchangeTableSite)
                    .WithMany(p => p.ComExchangeTables)
                    .HasForeignKey(d => d.ExchangeTableSiteId)
                    .HasConstraintName("FK_COM_ExchangeTable_ExchangeTableSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComGiftCard>(entity =>
            {
                entity.HasKey(e => e.GiftCardId);

                entity.ToTable("COM_GiftCard", "dbo");

                entity.HasIndex(e => e.GiftCardSiteId, "IX_COM_GiftCard_GiftCardSiteID");

                entity.Property(e => e.GiftCardId).HasColumnName("GiftCardID");

                entity.Property(e => e.GiftCardCustomerRestriction)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'enum1')");

                entity.Property(e => e.GiftCardDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GiftCardEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GiftCardLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.GiftCardMinimumOrderPrice).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.GiftCardName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GiftCardRoles).HasMaxLength(400);

                entity.Property(e => e.GiftCardSiteId).HasColumnName("GiftCardSiteID");

                entity.Property(e => e.GiftCardValue).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.GiftCardSite)
                    .WithMany(p => p.ComGiftCards)
                    .HasForeignKey(d => d.GiftCardSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_GiftCard_GiftCardSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComGiftCardCouponCode>(entity =>
            {
                entity.HasKey(e => e.GiftCardCouponCodeId);

                entity.ToTable("COM_GiftCardCouponCode", "dbo");

                entity.HasIndex(e => e.GiftCardCouponCodeGiftCardId, "IX_COM_GiftCardCouponCodeGiftCardID");

                entity.Property(e => e.GiftCardCouponCodeId).HasColumnName("GiftCardCouponCodeID");

                entity.Property(e => e.GiftCardCouponCodeCode)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GiftCardCouponCodeGiftCardId).HasColumnName("GiftCardCouponCodeGiftCardID");

                entity.Property(e => e.GiftCardCouponCodeLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.GiftCardCouponCodeRemainingValue).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.GiftCardCouponCodeGiftCard)
                    .WithMany(p => p.ComGiftCardCouponCodes)
                    .HasForeignKey(d => d.GiftCardCouponCodeGiftCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_GiftCardCouponCode_GiftCardCouponCodeGiftCardID_COM_GiftCard");
            });

            modelBuilder.Entity<ComInternalStatus>(entity =>
            {
                entity.HasKey(e => e.InternalStatusId);

                entity.ToTable("COM_InternalStatus", "dbo");

                entity.HasIndex(e => new { e.InternalStatusSiteId, e.InternalStatusDisplayName, e.InternalStatusEnabled }, "IX_COM_InternalStatus_InternalStatusSiteID_InternalStatusDisplayName_InternalStatusEnabled");

                entity.Property(e => e.InternalStatusId).HasColumnName("InternalStatusID");

                entity.Property(e => e.InternalStatusDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InternalStatusEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.InternalStatusGuid).HasColumnName("InternalStatusGUID");

                entity.Property(e => e.InternalStatusLastModified).HasDefaultValueSql("('9/20/2012 2:45:44 PM')");

                entity.Property(e => e.InternalStatusName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.InternalStatusSiteId).HasColumnName("InternalStatusSiteID");

                entity.HasOne(d => d.InternalStatusSite)
                    .WithMany(p => p.ComInternalStatuses)
                    .HasForeignKey(d => d.InternalStatusSiteId)
                    .HasConstraintName("FK_COM_InternalStatus_InternalStatusSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComManufacturer>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId)
                    .IsClustered(false);

                entity.ToTable("COM_Manufacturer", "dbo");

                entity.HasIndex(e => new { e.ManufacturerDisplayName, e.ManufacturerEnabled }, "IX_COM_Manufacturer_ManufacturerDisplayName_ManufacturerEnabled")
                    .IsClustered();

                entity.HasIndex(e => e.ManufacturerSiteId, "IX_COM_Manufacturer_ManufacturerSiteID");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.ManufactureHomepage).HasMaxLength(400);

                entity.Property(e => e.ManufacturerDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ManufacturerEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ManufacturerGuid).HasColumnName("ManufacturerGUID");

                entity.Property(e => e.ManufacturerLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.ManufacturerName).HasMaxLength(200);

                entity.Property(e => e.ManufacturerSiteId).HasColumnName("ManufacturerSiteID");

                entity.Property(e => e.ManufacturerThumbnailGuid).HasColumnName("ManufacturerThumbnailGUID");

                entity.HasOne(d => d.ManufacturerSite)
                    .WithMany(p => p.ComManufacturers)
                    .HasForeignKey(d => d.ManufacturerSiteId)
                    .HasConstraintName("FK_COM_Manufacturer_ManufacturerSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComMultiBuyCouponCode>(entity =>
            {
                entity.HasKey(e => e.MultiBuyCouponCodeId);

                entity.ToTable("COM_MultiBuyCouponCode", "dbo");

                entity.HasIndex(e => e.MultiBuyCouponCodeMultiBuyDiscountId, "IX_COM_MultiBuyCouponCode_MultiBuyCouponCodeMultiBuyDiscountID");

                entity.Property(e => e.MultiBuyCouponCodeId).HasColumnName("MultiBuyCouponCodeID");

                entity.Property(e => e.MultiBuyCouponCodeCode)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MultiBuyCouponCodeGuid).HasColumnName("MultiBuyCouponCodeGUID");

                entity.Property(e => e.MultiBuyCouponCodeMultiBuyDiscountId).HasColumnName("MultiBuyCouponCodeMultiBuyDiscountID");

                entity.Property(e => e.MultiBuyCouponCodeUseCount).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MultiBuyCouponCodeMultiBuyDiscount)
                    .WithMany(p => p.ComMultiBuyCouponCodes)
                    .HasForeignKey(d => d.MultiBuyCouponCodeMultiBuyDiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_MultiBuyCouponCode_MultiBuyCouponCodeMultiBuyDiscountID_COM_MultiBuyDiscount");
            });

            modelBuilder.Entity<ComMultiBuyDiscount>(entity =>
            {
                entity.HasKey(e => e.MultiBuyDiscountId);

                entity.ToTable("COM_MultiBuyDiscount", "dbo");

                entity.HasIndex(e => e.MultiBuyDiscountApplyToSkuid, "IX_COM_MultiBuyDiscount_MultiBuyDiscountApplyToSKUID");

                entity.HasIndex(e => e.MultiBuyDiscountSiteId, "IX_COM_MultiBuyDiscount_MultiBuyDiscountSiteID");

                entity.Property(e => e.MultiBuyDiscountId).HasColumnName("MultiBuyDiscountID");

                entity.Property(e => e.MultiBuyDiscountApplyFurtherDiscounts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MultiBuyDiscountApplyToSkuid).HasColumnName("MultiBuyDiscountApplyToSKUID");

                entity.Property(e => e.MultiBuyDiscountAutoAddEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MultiBuyDiscountCustomerRestriction)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'All')");

                entity.Property(e => e.MultiBuyDiscountDisplayName).HasMaxLength(200);

                entity.Property(e => e.MultiBuyDiscountEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MultiBuyDiscountGuid).HasColumnName("MultiBuyDiscountGUID");

                entity.Property(e => e.MultiBuyDiscountIsFlat).HasDefaultValueSql("((1))");

                entity.Property(e => e.MultiBuyDiscountMinimumBuyCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.MultiBuyDiscountName).HasMaxLength(200);

                entity.Property(e => e.MultiBuyDiscountRoles).HasMaxLength(400);

                entity.Property(e => e.MultiBuyDiscountSiteId).HasColumnName("MultiBuyDiscountSiteID");

                entity.Property(e => e.MultiBuyDiscountUsesCoupons).HasDefaultValueSql("((0))");

                entity.Property(e => e.MultiBuyDiscountValue).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.MultiBuyDiscountApplyToSku)
                    .WithMany(p => p.ComMultiBuyDiscounts)
                    .HasForeignKey(d => d.MultiBuyDiscountApplyToSkuid)
                    .HasConstraintName("FK_COM_MultiBuyDiscount_MultiBuyDiscountApplyToSKUID_COM_SKU");

                entity.HasOne(d => d.MultiBuyDiscountSite)
                    .WithMany(p => p.ComMultiBuyDiscounts)
                    .HasForeignKey(d => d.MultiBuyDiscountSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_MultiBuyDiscount_MultiBuyDiscountSiteID_CMS_Site");

                entity.HasMany(d => d.Departments)
                    .WithMany(p => p.MultiBuyDiscounts)
                    .UsingEntity<Dictionary<string, object>>(
                        "ComMultiBuyDiscountDepartment",
                        l => l.HasOne<ComDepartment>().WithMany().HasForeignKey("DepartmentId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_MultiBuyDiscountDepartment_DepartmentID_COM_Department"),
                        r => r.HasOne<ComMultiBuyDiscount>().WithMany().HasForeignKey("MultiBuyDiscountId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_MultiBuyDiscountDepartment_MultiBuyDiscountID_COM_MultiBuyDiscount"),
                        j =>
                        {
                            j.HasKey("MultiBuyDiscountId", "DepartmentId");

                            j.ToTable("COM_MultiBuyDiscountDepartment", "dbo");

                            j.HasIndex(new[] { "DepartmentId" }, "IX_COM_MultiBuyDiscountDepartment_DepartmentID");

                            j.IndexerProperty<int>("MultiBuyDiscountId").HasColumnName("MultiBuyDiscountID");

                            j.IndexerProperty<int>("DepartmentId").HasColumnName("DepartmentID");
                        });

                entity.HasMany(d => d.Skus)
                    .WithMany(p => p.MultiBuyDiscounts)
                    .UsingEntity<Dictionary<string, object>>(
                        "ComMultiBuyDiscountSku",
                        l => l.HasOne<ComSku>().WithMany().HasForeignKey("Skuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_MultiBuyDiscountSKU_SKUID_COM_SKU"),
                        r => r.HasOne<ComMultiBuyDiscount>().WithMany().HasForeignKey("MultiBuyDiscountId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_MultiBuyDiscountSKU_MultiBuyDiscountID_COM_MultiBuyDiscount"),
                        j =>
                        {
                            j.HasKey("MultiBuyDiscountId", "Skuid");

                            j.ToTable("COM_MultiBuyDiscountSKU", "dbo");

                            j.HasIndex(new[] { "Skuid" }, "IX_COM_MultiBuyDiscountSKU_SKUID");

                            j.IndexerProperty<int>("MultiBuyDiscountId").HasColumnName("MultiBuyDiscountID");

                            j.IndexerProperty<int>("Skuid").HasColumnName("SKUID");
                        });
            });

            modelBuilder.Entity<ComMultiBuyDiscountBrand>(entity =>
            {
                entity.HasKey(e => new { e.MultiBuyDiscountId, e.BrandId });

                entity.ToTable("COM_MultiBuyDiscountBrand", "dbo");

                entity.HasIndex(e => e.BrandId, "IX_COM_MultiBuyDiscountBrand_BrandID");

                entity.Property(e => e.MultiBuyDiscountId).HasColumnName("MultiBuyDiscountID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.BrandIncluded)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ComMultiBuyDiscountBrands)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_MultiBuyDiscountBrand_BrandID_COM_Brand");

                entity.HasOne(d => d.MultiBuyDiscount)
                    .WithMany(p => p.ComMultiBuyDiscountBrands)
                    .HasForeignKey(d => d.MultiBuyDiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_MultiBuyDiscountBrand_MultiBuyDiscountID_COM_MultiBuyDiscount");
            });

            modelBuilder.Entity<ComMultiBuyDiscountCollection>(entity =>
            {
                entity.HasKey(e => new { e.MultibuyDiscountId, e.CollectionId });

                entity.ToTable("COM_MultiBuyDiscountCollection", "dbo");

                entity.HasIndex(e => e.CollectionId, "IX_COM_MultiBuyDiscountCollection_CollectionID");

                entity.Property(e => e.MultibuyDiscountId).HasColumnName("MultibuyDiscountID");

                entity.Property(e => e.CollectionId).HasColumnName("CollectionID");

                entity.Property(e => e.CollectionIncluded)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.ComMultiBuyDiscountCollections)
                    .HasForeignKey(d => d.CollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_MultiBuyDiscountCollection_CollectionID_COM_Collection");

                entity.HasOne(d => d.MultibuyDiscount)
                    .WithMany(p => p.ComMultiBuyDiscountCollections)
                    .HasForeignKey(d => d.MultibuyDiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_MultiBuyDiscountCollection_MultiBuyDiscountID_COM_MultiBuyDiscount");
            });

            modelBuilder.Entity<ComMultiBuyDiscountTree>(entity =>
            {
                entity.HasKey(e => new { e.MultiBuyDiscountId, e.NodeId });

                entity.ToTable("COM_MultiBuyDiscountTree", "dbo");

                entity.HasIndex(e => e.NodeId, "IX_COM_MultiBuyDiscountTree_NodeID");

                entity.Property(e => e.MultiBuyDiscountId).HasColumnName("MultiBuyDiscountID");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.Property(e => e.NodeIncluded)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.MultiBuyDiscount)
                    .WithMany(p => p.ComMultiBuyDiscountTrees)
                    .HasForeignKey(d => d.MultiBuyDiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_MultiBuyDiscountTree_MultiBuyDiscountID_COM_MultiBuyDiscount");

                entity.HasOne(d => d.Node)
                    .WithMany(p => p.ComMultiBuyDiscountTrees)
                    .HasForeignKey(d => d.NodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_MultiBuyDiscountTree_NodeID_CMS_Tree");
            });

            modelBuilder.Entity<ComOptionCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .IsClustered(false);

                entity.ToTable("COM_OptionCategory", "dbo");

                entity.HasIndex(e => new { e.CategoryDisplayName, e.CategoryEnabled }, "IX_COM_OptionCategory_CategoryDisplayName_CategoryEnabled")
                    .IsClustered();

                entity.HasIndex(e => e.CategorySiteId, "IX_COM_OptionCategory_CategorySiteID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryDefaultOptions).HasMaxLength(200);

                entity.Property(e => e.CategoryDefaultRecord).HasMaxLength(200);

                entity.Property(e => e.CategoryDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CategoryDisplayPrice).HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryLiveSiteDisplayName).HasMaxLength(200);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CategorySelectionType)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.CategorySiteId).HasColumnName("CategorySiteID");

                entity.Property(e => e.CategoryType).HasMaxLength(20);

                entity.HasOne(d => d.CategorySite)
                    .WithMany(p => p.ComOptionCategories)
                    .HasForeignKey(d => d.CategorySiteId)
                    .HasConstraintName("FK_COM_OptionCategory_CategorySiteID_CMS_Site");
            });

            modelBuilder.Entity<ComOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("COM_Order", "dbo");

                entity.HasIndex(e => e.OrderCreatedByUserId, "IX_COM_Order_OrderCreatedByUserID");

                entity.HasIndex(e => e.OrderCurrencyId, "IX_COM_Order_OrderCurrencyID");

                entity.HasIndex(e => e.OrderCustomerId, "IX_COM_Order_OrderCustomerID");

                entity.HasIndex(e => e.OrderPaymentOptionId, "IX_COM_Order_OrderPaymentOptionID");

                entity.HasIndex(e => e.OrderShippingOptionId, "IX_COM_Order_OrderShippingOptionID");

                entity.HasIndex(e => new { e.OrderSiteId, e.OrderDate }, "IX_COM_Order_OrderSiteID_OrderDate");

                entity.HasIndex(e => e.OrderStatusId, "IX_COM_Order_OrderStatusID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderCreatedByUserId).HasColumnName("OrderCreatedByUserID");

                entity.Property(e => e.OrderCulture).HasMaxLength(10);

                entity.Property(e => e.OrderCurrencyId).HasColumnName("OrderCurrencyID");

                entity.Property(e => e.OrderCustomerId).HasColumnName("OrderCustomerID");

                entity.Property(e => e.OrderGrandTotal).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.OrderGrandTotalInMainCurrency).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.OrderGuid).HasColumnName("OrderGUID");

                entity.Property(e => e.OrderInvoiceNumber).HasMaxLength(200);

                entity.Property(e => e.OrderPaymentOptionId).HasColumnName("OrderPaymentOptionID");

                entity.Property(e => e.OrderShippingOptionId).HasColumnName("OrderShippingOptionID");

                entity.Property(e => e.OrderSiteId).HasColumnName("OrderSiteID");

                entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");

                entity.Property(e => e.OrderTotalPrice).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.OrderTotalPriceInMainCurrency).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.OrderTotalShipping).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.OrderTotalTax).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.OrderTrackingNumber).HasMaxLength(100);

                entity.HasOne(d => d.OrderCreatedByUser)
                    .WithMany(p => p.ComOrders)
                    .HasForeignKey(d => d.OrderCreatedByUserId)
                    .HasConstraintName("FK_COM_Order_OrderCreatedByUserID_CMS_User");

                entity.HasOne(d => d.OrderCurrency)
                    .WithMany(p => p.ComOrders)
                    .HasForeignKey(d => d.OrderCurrencyId)
                    .HasConstraintName("FK_COM_Order_OrderCurrencyID_COM_Currency");

                entity.HasOne(d => d.OrderCustomer)
                    .WithMany(p => p.ComOrders)
                    .HasForeignKey(d => d.OrderCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Order_OrderCustomerID_COM_Customer");

                entity.HasOne(d => d.OrderPaymentOption)
                    .WithMany(p => p.ComOrders)
                    .HasForeignKey(d => d.OrderPaymentOptionId)
                    .HasConstraintName("FK_COM_Order_OrderPaymentOptionID_COM_PaymentOption");

                entity.HasOne(d => d.OrderShippingOption)
                    .WithMany(p => p.ComOrders)
                    .HasForeignKey(d => d.OrderShippingOptionId)
                    .HasConstraintName("FK_COM_Order_OrderShippingOptionID_COM_ShippingOption");

                entity.HasOne(d => d.OrderSite)
                    .WithMany(p => p.ComOrders)
                    .HasForeignKey(d => d.OrderSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Order_OrderSiteID_CMS_Site");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.ComOrders)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_COM_Order_OrderStatusID_COM_Status");
            });

            modelBuilder.Entity<ComOrderAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.ToTable("COM_OrderAddress", "dbo");

                entity.HasIndex(e => e.AddressCountryId, "IX_COM_OrderAddress_AddressCountryID");

                entity.HasIndex(e => new { e.AddressOrderId, e.AddressType }, "IX_COM_OrderAddress_AddressOrderID_AddressType")
                    .IsUnique();

                entity.HasIndex(e => e.AddressStateId, "IX_COM_OrderAddress_AddressStateID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressCity).HasMaxLength(100);

                entity.Property(e => e.AddressCountryId).HasColumnName("AddressCountryID");

                entity.Property(e => e.AddressGuid).HasColumnName("AddressGUID");

                entity.Property(e => e.AddressLine1).HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.AddressOrderId).HasColumnName("AddressOrderID");

                entity.Property(e => e.AddressPersonalName).HasMaxLength(200);

                entity.Property(e => e.AddressPhone).HasMaxLength(26);

                entity.Property(e => e.AddressStateId).HasColumnName("AddressStateID");

                entity.Property(e => e.AddressZip).HasMaxLength(20);

                entity.HasOne(d => d.AddressCountry)
                    .WithMany(p => p.ComOrderAddresses)
                    .HasForeignKey(d => d.AddressCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_OrderAddress_AddressCountryID_CMS_Country");

                entity.HasOne(d => d.AddressOrder)
                    .WithMany(p => p.ComOrderAddresses)
                    .HasForeignKey(d => d.AddressOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_OrderAddress_AddressOrderID_COM_Order");

                entity.HasOne(d => d.AddressState)
                    .WithMany(p => p.ComOrderAddresses)
                    .HasForeignKey(d => d.AddressStateId)
                    .HasConstraintName("FK_COM_OrderAddress_AddressStateID_CMS_State");
            });

            modelBuilder.Entity<ComOrderItem>(entity =>
            {
                entity.HasKey(e => e.OrderItemId);

                entity.ToTable("COM_OrderItem", "dbo");

                entity.HasIndex(e => e.OrderItemOrderId, "IX_COM_OrderItem_OrderItemOrderID");

                entity.HasIndex(e => e.OrderItemSkuid, "IX_COM_OrderItem_OrderItemSKUID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.Property(e => e.OrderItemBundleGuid).HasColumnName("OrderItemBundleGUID");

                entity.Property(e => e.OrderItemOrderId).HasColumnName("OrderItemOrderID");

                entity.Property(e => e.OrderItemSkuid).HasColumnName("OrderItemSKUID");

                entity.Property(e => e.OrderItemSkuname)
                    .HasMaxLength(450)
                    .HasColumnName("OrderItemSKUName");

                entity.Property(e => e.OrderItemTotalPrice).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.OrderItemTotalPriceInMainCurrency).HasColumnType("decimal(18, 9)");

                entity.Property(e => e.OrderItemUnitPrice).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.OrderItemOrder)
                    .WithMany(p => p.ComOrderItems)
                    .HasForeignKey(d => d.OrderItemOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_OrderItem_OrderItemOrderID_COM_Order");

                entity.HasOne(d => d.OrderItemSku)
                    .WithMany(p => p.ComOrderItems)
                    .HasForeignKey(d => d.OrderItemSkuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_OrderItem_OrderItemSKUID_COM_SKU");
            });

            modelBuilder.Entity<ComOrderItemSkufile>(entity =>
            {
                entity.HasKey(e => e.OrderItemSkufileId);

                entity.ToTable("COM_OrderItemSKUFile", "dbo");

                entity.HasIndex(e => e.FileId, "IX_COM_OrderItemSKUFile_FileID");

                entity.HasIndex(e => e.OrderItemId, "IX_COM_OrderItemSKUFile_OrderItemID");

                entity.Property(e => e.OrderItemSkufileId).HasColumnName("OrderItemSKUFileID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.OrderItemId).HasColumnName("OrderItemID");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ComOrderItemSkufiles)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_OrderItemSKUFile_COM_SKUFile");

                entity.HasOne(d => d.OrderItem)
                    .WithMany(p => p.ComOrderItemSkufiles)
                    .HasForeignKey(d => d.OrderItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_OrderItemSKUFile_COM_OrderItem");
            });

            modelBuilder.Entity<ComOrderStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("COM_OrderStatus", "dbo");

                entity.HasIndex(e => new { e.StatusSiteId, e.StatusOrder }, "IX_COM_OrderStatus_StatusSiteID_StatusOrder");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusColor).HasMaxLength(7);

                entity.Property(e => e.StatusDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StatusEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StatusGuid).HasColumnName("StatusGUID");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StatusSendNotification).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusSiteId).HasColumnName("StatusSiteID");

                entity.HasOne(d => d.StatusSite)
                    .WithMany(p => p.ComOrderStatuses)
                    .HasForeignKey(d => d.StatusSiteId)
                    .HasConstraintName("FK_COM_OrderStatus_StatusSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComOrderStatusUser>(entity =>
            {
                entity.HasKey(e => e.OrderStatusUserId);

                entity.ToTable("COM_OrderStatusUser", "dbo");

                entity.HasIndex(e => e.ChangedByUserId, "IX_COM_OrderStatusUser_ChangedByUserID");

                entity.HasIndex(e => e.FromStatusId, "IX_COM_OrderStatusUser_FromStatusID");

                entity.HasIndex(e => new { e.OrderId, e.Date }, "IX_COM_OrderStatusUser_OrderID_Date");

                entity.HasIndex(e => e.ToStatusId, "IX_COM_OrderStatusUser_ToStatusID");

                entity.Property(e => e.OrderStatusUserId).HasColumnName("OrderStatusUserID");

                entity.Property(e => e.ChangedByUserId).HasColumnName("ChangedByUserID");

                entity.Property(e => e.FromStatusId).HasColumnName("FromStatusID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ToStatusId).HasColumnName("ToStatusID");

                entity.HasOne(d => d.ChangedByUser)
                    .WithMany(p => p.ComOrderStatusUsers)
                    .HasForeignKey(d => d.ChangedByUserId)
                    .HasConstraintName("FK_COM_OrderStatusUser_ChangedByUserID_CMS_User");

                entity.HasOne(d => d.FromStatus)
                    .WithMany(p => p.ComOrderStatusUserFromStatuses)
                    .HasForeignKey(d => d.FromStatusId)
                    .HasConstraintName("FK_COM_OrderStatusUser_FromStatusID_COM_Status");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.ComOrderStatusUsers)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_OrderStatusUser_OrderID_COM_Order");

                entity.HasOne(d => d.ToStatus)
                    .WithMany(p => p.ComOrderStatusUserToStatuses)
                    .HasForeignKey(d => d.ToStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_OrderStatusUser_ToStatusID_COM_Status");
            });

            modelBuilder.Entity<ComPaymentOption>(entity =>
            {
                entity.HasKey(e => e.PaymentOptionId)
                    .IsClustered(false);

                entity.ToTable("COM_PaymentOption", "dbo");

                entity.HasIndex(e => e.PaymentOptionAuthorizedOrderStatusId, "IX_COM_PaymentOption_PaymentOptionAuthorizedOrderStatusID");

                entity.HasIndex(e => e.PaymentOptionFailedOrderStatusId, "IX_COM_PaymentOption_PaymentOptionFailedOrderStatusID");

                entity.HasIndex(e => e.PaymentOptionSiteId, "IX_COM_PaymentOption_PaymentOptionSiteID");

                entity.HasIndex(e => new { e.PaymentOptionSiteId, e.PaymentOptionDisplayName, e.PaymentOptionEnabled }, "IX_COM_PaymentOption_PaymentOptionSiteID_PaymentOptionDisplayName_PaymentOptionEnabled")
                    .IsClustered();

                entity.HasIndex(e => e.PaymentOptionSucceededOrderStatusId, "IX_COM_PaymentOption_PaymentOptionSucceededOrderStatusID");

                entity.Property(e => e.PaymentOptionId).HasColumnName("PaymentOptionID");

                entity.Property(e => e.PaymentOptionAllowIfNoShipping).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentOptionAssemblyName).HasMaxLength(200);

                entity.Property(e => e.PaymentOptionAuthorizedOrderStatusId).HasColumnName("PaymentOptionAuthorizedOrderStatusID");

                entity.Property(e => e.PaymentOptionClassName).HasMaxLength(200);

                entity.Property(e => e.PaymentOptionDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PaymentOptionEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentOptionFailedOrderStatusId).HasColumnName("PaymentOptionFailedOrderStatusID");

                entity.Property(e => e.PaymentOptionGuid).HasColumnName("PaymentOptionGUID");

                entity.Property(e => e.PaymentOptionLastModified).HasDefaultValueSql("('9/27/2012 4:18:26 PM')");

                entity.Property(e => e.PaymentOptionName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PaymentOptionPaymentGateUrl).HasMaxLength(500);

                entity.Property(e => e.PaymentOptionSiteId).HasColumnName("PaymentOptionSiteID");

                entity.Property(e => e.PaymentOptionSucceededOrderStatusId).HasColumnName("PaymentOptionSucceededOrderStatusID");

                entity.Property(e => e.PaymentOptionThumbnailGuid).HasColumnName("PaymentOptionThumbnailGUID");

                entity.HasOne(d => d.PaymentOptionAuthorizedOrderStatus)
                    .WithMany(p => p.ComPaymentOptionPaymentOptionAuthorizedOrderStatuses)
                    .HasForeignKey(d => d.PaymentOptionAuthorizedOrderStatusId)
                    .HasConstraintName("FK_COM_PaymentOption_PaymentOptionAuthorizedOrderStatusID_COM_OrderStatus");

                entity.HasOne(d => d.PaymentOptionFailedOrderStatus)
                    .WithMany(p => p.ComPaymentOptionPaymentOptionFailedOrderStatuses)
                    .HasForeignKey(d => d.PaymentOptionFailedOrderStatusId)
                    .HasConstraintName("FK_COM_PaymentOption_PaymentOptionFailedOrderStatusID_COM_OrderStatus");

                entity.HasOne(d => d.PaymentOptionSite)
                    .WithMany(p => p.ComPaymentOptions)
                    .HasForeignKey(d => d.PaymentOptionSiteId)
                    .HasConstraintName("FK_COM_PaymentOption_PaymentOptionSiteID_CMS_Site");

                entity.HasOne(d => d.PaymentOptionSucceededOrderStatus)
                    .WithMany(p => p.ComPaymentOptionPaymentOptionSucceededOrderStatuses)
                    .HasForeignKey(d => d.PaymentOptionSucceededOrderStatusId)
                    .HasConstraintName("FK_COM_PaymentOption_PaymentOptionSucceededOrderStatusID_COM_OrderStatus");
            });

            modelBuilder.Entity<ComPublicStatus>(entity =>
            {
                entity.HasKey(e => e.PublicStatusId)
                    .IsClustered(false);

                entity.ToTable("COM_PublicStatus", "dbo");

                entity.HasIndex(e => new { e.PublicStatusDisplayName, e.PublicStatusEnabled }, "IX_COM_PublicStatus_PublicStatusDisplayName_PublicStatusEnabled")
                    .IsClustered();

                entity.HasIndex(e => e.PublicStatusSiteId, "IX_COM_PublicStatus_PublicStatusSiteID");

                entity.Property(e => e.PublicStatusId).HasColumnName("PublicStatusID");

                entity.Property(e => e.PublicStatusDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PublicStatusEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PublicStatusGuid).HasColumnName("PublicStatusGUID");

                entity.Property(e => e.PublicStatusName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PublicStatusSiteId).HasColumnName("PublicStatusSiteID");

                entity.HasOne(d => d.PublicStatusSite)
                    .WithMany(p => p.ComPublicStatuses)
                    .HasForeignKey(d => d.PublicStatusSiteId)
                    .HasConstraintName("FK_COM_PublicStatus_PublicStatusSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComShippingCost>(entity =>
            {
                entity.HasKey(e => e.ShippingCostId)
                    .HasName("PK__COM_ShippingCost");

                entity.ToTable("COM_ShippingCost", "dbo");

                entity.HasIndex(e => e.ShippingCostShippingOptionId, "IX_COM_ShippingCost_ShippingCostShippingOptionID");

                entity.Property(e => e.ShippingCostId).HasColumnName("ShippingCostID");

                entity.Property(e => e.ShippingCostGuid).HasColumnName("ShippingCostGUID");

                entity.Property(e => e.ShippingCostShippingOptionId).HasColumnName("ShippingCostShippingOptionID");

                entity.Property(e => e.ShippingCostValue).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.ShippingCostShippingOption)
                    .WithMany(p => p.ComShippingCosts)
                    .HasForeignKey(d => d.ShippingCostShippingOptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_ShippingCost_ShippingCostShippingOptionID_COM_ShippingOption");
            });

            modelBuilder.Entity<ComShippingOption>(entity =>
            {
                entity.HasKey(e => e.ShippingOptionId)
                    .IsClustered(false);

                entity.ToTable("COM_ShippingOption", "dbo");

                entity.HasIndex(e => e.ShippingOptionDisplayName, "IX_COM_ShippingOptionDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.ShippingOptionCarrierId, "IX_COM_ShippingOption_ShippingOptionCarrierID");

                entity.HasIndex(e => e.ShippingOptionSiteId, "IX_COM_ShippingOption_ShippingOptionSiteID_ShippingOptionDisplayName_ShippingOptionEnabled");

                entity.HasIndex(e => e.ShippingOptionTaxClassId, "IX_COM_ShippingOption_ShippingOptionTaxClassID");

                entity.Property(e => e.ShippingOptionId).HasColumnName("ShippingOptionID");

                entity.Property(e => e.ShippingOptionCarrierId).HasColumnName("ShippingOptionCarrierID");

                entity.Property(e => e.ShippingOptionCarrierServiceName).HasMaxLength(200);

                entity.Property(e => e.ShippingOptionDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingOptionEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShippingOptionGuid).HasColumnName("ShippingOptionGUID");

                entity.Property(e => e.ShippingOptionLastModified).HasDefaultValueSql("('9/26/2012 12:44:18 PM')");

                entity.Property(e => e.ShippingOptionName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShippingOptionSiteId).HasColumnName("ShippingOptionSiteID");

                entity.Property(e => e.ShippingOptionTaxClassId).HasColumnName("ShippingOptionTaxClassID");

                entity.Property(e => e.ShippingOptionThumbnailGuid).HasColumnName("ShippingOptionThumbnailGUID");

                entity.HasOne(d => d.ShippingOptionCarrier)
                    .WithMany(p => p.ComShippingOptions)
                    .HasForeignKey(d => d.ShippingOptionCarrierId)
                    .HasConstraintName("FK_COM_ShippingOption_ShippingOptionCarrierID_COM_Carrier");

                entity.HasOne(d => d.ShippingOptionSite)
                    .WithMany(p => p.ComShippingOptions)
                    .HasForeignKey(d => d.ShippingOptionSiteId)
                    .HasConstraintName("FK_COM_ShippingOption_ShippingOptionSiteID_CMS_Site");

                entity.HasOne(d => d.ShippingOptionTaxClass)
                    .WithMany(p => p.ComShippingOptions)
                    .HasForeignKey(d => d.ShippingOptionTaxClassId)
                    .HasConstraintName("FK_COM_ShippingOption_ShippingOptionTaxClassID_COM_TaxClass");
            });

            modelBuilder.Entity<ComShoppingCart>(entity =>
            {
                entity.HasKey(e => e.ShoppingCartId);

                entity.ToTable("COM_ShoppingCart", "dbo");

                entity.HasIndex(e => e.ShoppingCartBillingAddressId, "IX_COM_ShoppingCart_ShoppingCartBillingAddressID");

                entity.HasIndex(e => e.ShoppingCartCompanyAddressId, "IX_COM_ShoppingCart_ShoppingCartCompanyAddressID");

                entity.HasIndex(e => e.ShoppingCartCurrencyId, "IX_COM_ShoppingCart_ShoppingCartCurrencyID");

                entity.HasIndex(e => e.ShoppingCartCustomerId, "IX_COM_ShoppingCart_ShoppingCartCustomerID");

                entity.HasIndex(e => e.ShoppingCartLastUpdate, "IX_COM_ShoppingCart_ShoppingCartLastUpdate");

                entity.HasIndex(e => e.ShoppingCartPaymentOptionId, "IX_COM_ShoppingCart_ShoppingCartPaymentOptionID");

                entity.HasIndex(e => e.ShoppingCartShippingAddressId, "IX_COM_ShoppingCart_ShoppingCartShippingAddressID");

                entity.HasIndex(e => e.ShoppingCartShippingOptionId, "IX_COM_ShoppingCart_ShoppingCartShippingOptionID");

                entity.HasIndex(e => e.ShoppingCartSiteId, "IX_COM_ShoppingCart_ShoppingCartSiteID");

                entity.HasIndex(e => e.ShoppingCartGuid, "IX_COM_ShoppingCart_ShoppingCartSiteID_ShoppingCartGUID");

                entity.HasIndex(e => e.ShoppingCartUserId, "IX_COM_ShoppingCart_ShoppingCartUserID");

                entity.Property(e => e.ShoppingCartId).HasColumnName("ShoppingCartID");

                entity.Property(e => e.ShoppingCartBillingAddressId).HasColumnName("ShoppingCartBillingAddressID");

                entity.Property(e => e.ShoppingCartCompanyAddressId).HasColumnName("ShoppingCartCompanyAddressID");

                entity.Property(e => e.ShoppingCartContactId).HasColumnName("ShoppingCartContactID");

                entity.Property(e => e.ShoppingCartCurrencyId).HasColumnName("ShoppingCartCurrencyID");

                entity.Property(e => e.ShoppingCartCustomerId).HasColumnName("ShoppingCartCustomerID");

                entity.Property(e => e.ShoppingCartGuid).HasColumnName("ShoppingCartGUID");

                entity.Property(e => e.ShoppingCartPaymentOptionId).HasColumnName("ShoppingCartPaymentOptionID");

                entity.Property(e => e.ShoppingCartShippingAddressId).HasColumnName("ShoppingCartShippingAddressID");

                entity.Property(e => e.ShoppingCartShippingOptionId).HasColumnName("ShoppingCartShippingOptionID");

                entity.Property(e => e.ShoppingCartSiteId).HasColumnName("ShoppingCartSiteID");

                entity.Property(e => e.ShoppingCartUserId).HasColumnName("ShoppingCartUserID");

                entity.HasOne(d => d.ShoppingCartBillingAddress)
                    .WithMany(p => p.ComShoppingCartShoppingCartBillingAddresses)
                    .HasForeignKey(d => d.ShoppingCartBillingAddressId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartBillingAddressID_COM_Address");

                entity.HasOne(d => d.ShoppingCartCompanyAddress)
                    .WithMany(p => p.ComShoppingCartShoppingCartCompanyAddresses)
                    .HasForeignKey(d => d.ShoppingCartCompanyAddressId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartCompanyAddressID_COM_Address");

                entity.HasOne(d => d.ShoppingCartCurrency)
                    .WithMany(p => p.ComShoppingCarts)
                    .HasForeignKey(d => d.ShoppingCartCurrencyId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartCurrencyID_COM_Currency");

                entity.HasOne(d => d.ShoppingCartCustomer)
                    .WithMany(p => p.ComShoppingCarts)
                    .HasForeignKey(d => d.ShoppingCartCustomerId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartCustomerID_COM_Customer");

                entity.HasOne(d => d.ShoppingCartPaymentOption)
                    .WithMany(p => p.ComShoppingCarts)
                    .HasForeignKey(d => d.ShoppingCartPaymentOptionId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartPaymentOptionID_COM_PaymentOption");

                entity.HasOne(d => d.ShoppingCartShippingAddress)
                    .WithMany(p => p.ComShoppingCartShoppingCartShippingAddresses)
                    .HasForeignKey(d => d.ShoppingCartShippingAddressId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartShippingAddressID_COM_Address");

                entity.HasOne(d => d.ShoppingCartShippingOption)
                    .WithMany(p => p.ComShoppingCarts)
                    .HasForeignKey(d => d.ShoppingCartShippingOptionId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartShippingOptionID_COM_ShippingOption");

                entity.HasOne(d => d.ShoppingCartSite)
                    .WithMany(p => p.ComShoppingCarts)
                    .HasForeignKey(d => d.ShoppingCartSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartSiteID_CMS_Site");

                entity.HasOne(d => d.ShoppingCartUser)
                    .WithMany(p => p.ComShoppingCarts)
                    .HasForeignKey(d => d.ShoppingCartUserId)
                    .HasConstraintName("FK_COM_ShoppingCart_ShoppingCartUserID_CMS_User");
            });

            modelBuilder.Entity<ComShoppingCartCouponCode>(entity =>
            {
                entity.HasKey(e => e.ShoppingCartCouponCodeId);

                entity.ToTable("COM_ShoppingCartCouponCode", "dbo");

                entity.HasIndex(e => e.ShoppingCartId, "IX_COM_ShoppingCartCouponCode_ShoppingCartID");

                entity.Property(e => e.ShoppingCartCouponCodeId).HasColumnName("ShoppingCartCouponCodeID");

                entity.Property(e => e.CouponCode)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ShoppingCartId).HasColumnName("ShoppingCartID");

                entity.HasOne(d => d.ShoppingCart)
                    .WithMany(p => p.ComShoppingCartCouponCodes)
                    .HasForeignKey(d => d.ShoppingCartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_ShoppingCartCouponCode_ShoppingCartID_COM_ShoppingCart");
            });

            modelBuilder.Entity<ComShoppingCartSku>(entity =>
            {
                entity.HasKey(e => e.CartItemId);

                entity.ToTable("COM_ShoppingCartSKU", "dbo");

                entity.HasIndex(e => e.Skuid, "IX_COM_ShoppingCartSKU_SKUID");

                entity.HasIndex(e => e.ShoppingCartId, "IX_COM_ShoppingCartSKU_ShoppingCartID");

                entity.Property(e => e.CartItemId).HasColumnName("CartItemID");

                entity.Property(e => e.CartItemAutoAddedUnits).HasDefaultValueSql("((0))");

                entity.Property(e => e.CartItemBundleGuid).HasColumnName("CartItemBundleGUID");

                entity.Property(e => e.ShoppingCartId).HasColumnName("ShoppingCartID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.Property(e => e.Skuunits).HasColumnName("SKUUnits");

                entity.HasOne(d => d.ShoppingCart)
                    .WithMany(p => p.ComShoppingCartSkus)
                    .HasForeignKey(d => d.ShoppingCartId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_ShoppingCartSKU_ShoppingCartID_COM_ShoppingCart");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComShoppingCartSkus)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_ShoppingCartSKU_SKUID_COM_SKU");
            });

            modelBuilder.Entity<ComSku>(entity =>
            {
                entity.HasKey(e => e.Skuid);

                entity.ToTable("COM_SKU", "dbo");

                entity.HasIndex(e => e.SkubrandId, "IX_COM_SKU_SKUBrandID");

                entity.HasIndex(e => e.SkucollectionId, "IX_COM_SKU_SKUCollectionID");

                entity.HasIndex(e => e.SkudepartmentId, "IX_COM_SKU_SKUDepartmentID");

                entity.HasIndex(e => e.SkuinternalStatusId, "IX_COM_SKU_SKUInternalStatusID");

                entity.HasIndex(e => e.SkumanufacturerId, "IX_COM_SKU_SKUManufacturerID");

                entity.HasIndex(e => e.Skuname, "IX_COM_SKU_SKUName");

                entity.HasIndex(e => e.Skunumber, "IX_COM_SKU_SKUNumber")
                    .HasFilter("([SKUNumber] IS NOT NULL)")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.SkuoptionCategoryId, "IX_COM_SKU_SKUOptionCategoryID");

                entity.HasIndex(e => e.SkuparentSkuid, "IX_COM_SKU_SKUParentSKUID");

                entity.HasIndex(e => e.Skuprice, "IX_COM_SKU_SKUPrice");

                entity.HasIndex(e => e.SkupublicStatusId, "IX_COM_SKU_SKUPublicStatusID");

                entity.HasIndex(e => e.SkusiteId, "IX_COM_SKU_SKUSiteID");

                entity.HasIndex(e => e.SkusupplierId, "IX_COM_SKU_SKUSupplierID");

                entity.HasIndex(e => e.SkutaxClassId, "IX_COM_SKU_SKUTaxClassID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.Property(e => e.SkuavailableInDays).HasColumnName("SKUAvailableInDays");

                entity.Property(e => e.SkuavailableItems).HasColumnName("SKUAvailableItems");

                entity.Property(e => e.SkubrandId).HasColumnName("SKUBrandID");

                entity.Property(e => e.SkubundleInventoryType)
                    .HasMaxLength(50)
                    .HasColumnName("SKUBundleInventoryType")
                    .HasDefaultValueSql("('REMOVEBUNDLE')");

                entity.Property(e => e.SkubundleItemsCount).HasColumnName("SKUBundleItemsCount");

                entity.Property(e => e.SkucollectionId).HasColumnName("SKUCollectionID");

                entity.Property(e => e.SkuconversionName)
                    .HasMaxLength(100)
                    .HasColumnName("SKUConversionName");

                entity.Property(e => e.SkuconversionValue)
                    .HasMaxLength(200)
                    .HasColumnName("SKUConversionValue")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Skucreated).HasColumnName("SKUCreated");

                entity.Property(e => e.SkucustomData).HasColumnName("SKUCustomData");

                entity.Property(e => e.SkudepartmentId).HasColumnName("SKUDepartmentID");

                entity.Property(e => e.Skudepth).HasColumnName("SKUDepth");

                entity.Property(e => e.Skudescription).HasColumnName("SKUDescription");

                entity.Property(e => e.Skuenabled)
                    .IsRequired()
                    .HasColumnName("SKUEnabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SkueproductFilesCount).HasColumnName("SKUEproductFilesCount");

                entity.Property(e => e.Skuguid).HasColumnName("SKUGUID");

                entity.Property(e => e.Skuheight).HasColumnName("SKUHeight");

                entity.Property(e => e.SkuimagePath)
                    .HasMaxLength(450)
                    .HasColumnName("SKUImagePath");

                entity.Property(e => e.SkuinStoreFrom).HasColumnName("SKUInStoreFrom");

                entity.Property(e => e.SkuinternalStatusId).HasColumnName("SKUInternalStatusID");

                entity.Property(e => e.SkulastModified).HasColumnName("SKULastModified");

                entity.Property(e => e.SkumanufacturerId).HasColumnName("SKUManufacturerID");

                entity.Property(e => e.SkumaxItemsInOrder).HasColumnName("SKUMaxItemsInOrder");

                entity.Property(e => e.SkumembershipGuid).HasColumnName("SKUMembershipGUID");

                entity.Property(e => e.SkuminItemsInOrder).HasColumnName("SKUMinItemsInOrder");

                entity.Property(e => e.Skuname)
                    .HasMaxLength(440)
                    .HasColumnName("SKUName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SkuneedsShipping).HasColumnName("SKUNeedsShipping");

                entity.Property(e => e.Skunumber)
                    .HasMaxLength(200)
                    .HasColumnName("SKUNumber");

                entity.Property(e => e.SkuoptionCategoryId).HasColumnName("SKUOptionCategoryID");

                entity.Property(e => e.Skuorder).HasColumnName("SKUOrder");

                entity.Property(e => e.SkuparentSkuid).HasColumnName("SKUParentSKUID");

                entity.Property(e => e.Skuprice)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("SKUPrice");

                entity.Property(e => e.SkuproductType)
                    .HasMaxLength(50)
                    .HasColumnName("SKUProductType");

                entity.Property(e => e.SkupublicStatusId).HasColumnName("SKUPublicStatusID");

                entity.Property(e => e.SkureorderAt).HasColumnName("SKUReorderAt");

                entity.Property(e => e.SkuretailPrice)
                    .HasColumnType("decimal(18, 9)")
                    .HasColumnName("SKURetailPrice");

                entity.Property(e => e.SkusellOnlyAvailable)
                    .HasColumnName("SKUSellOnlyAvailable")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SkushortDescription).HasColumnName("SKUShortDescription");

                entity.Property(e => e.SkusiteId).HasColumnName("SKUSiteID");

                entity.Property(e => e.SkusupplierId).HasColumnName("SKUSupplierID");

                entity.Property(e => e.SkutaxClassId).HasColumnName("SKUTaxClassID");

                entity.Property(e => e.SkutrackInventory)
                    .HasMaxLength(50)
                    .HasColumnName("SKUTrackInventory")
                    .HasDefaultValueSql("(N'ByProduct')");

                entity.Property(e => e.SkuvalidFor).HasColumnName("SKUValidFor");

                entity.Property(e => e.SkuvalidUntil).HasColumnName("SKUValidUntil");

                entity.Property(e => e.Skuvalidity)
                    .HasMaxLength(50)
                    .HasColumnName("SKUValidity");

                entity.Property(e => e.Skuweight).HasColumnName("SKUWeight");

                entity.Property(e => e.Skuwidth).HasColumnName("SKUWidth");

                entity.HasOne(d => d.Skubrand)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkubrandId)
                    .HasConstraintName("FK_COM_SKU_SKUBrandID_COM_Brand");

                entity.HasOne(d => d.Skucollection)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkucollectionId)
                    .HasConstraintName("FK_COM_SKU_SKUCollectionID_COM_Collection");

                entity.HasOne(d => d.Skudepartment)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkudepartmentId)
                    .HasConstraintName("FK_COM_SKU_SKUDepartmentID_COM_Department");

                entity.HasOne(d => d.SkuinternalStatus)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkuinternalStatusId)
                    .HasConstraintName("FK_COM_SKU_SKUInternalStatusID_COM_InternalStatus");

                entity.HasOne(d => d.Skumanufacturer)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkumanufacturerId)
                    .HasConstraintName("FK_COM_SKU_SKUManufacturerID_COM_Manifacturer");

                entity.HasOne(d => d.SkuoptionCategory)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkuoptionCategoryId)
                    .HasConstraintName("FK_COM_SKU_SKUOptionCategoryID_COM_OptionCategory");

                entity.HasOne(d => d.SkuparentSku)
                    .WithMany(p => p.InverseSkuparentSku)
                    .HasForeignKey(d => d.SkuparentSkuid)
                    .HasConstraintName("FK_COM_SKU_SKUParentSKUID_COM_SKU");

                entity.HasOne(d => d.SkupublicStatus)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkupublicStatusId)
                    .HasConstraintName("FK_COM_SKU_SKUPublicStatusID_COM_PublicStatus");

                entity.HasOne(d => d.Skusite)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkusiteId)
                    .HasConstraintName("FK_COM_SKU_SKUSiteID_CMS_Site");

                entity.HasOne(d => d.Skusupplier)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkusupplierId)
                    .HasConstraintName("FK_COM_SKU_SKUSupplierID_COM_Supplier");

                entity.HasOne(d => d.SkutaxClass)
                    .WithMany(p => p.ComSkus)
                    .HasForeignKey(d => d.SkutaxClassId)
                    .HasConstraintName("FK_COM_SKU_SKUTaxClass_COM_TaxClass");

                entity.HasMany(d => d.Bundles)
                    .WithMany(p => p.Skus)
                    .UsingEntity<Dictionary<string, object>>(
                        "ComBundle",
                        l => l.HasOne<ComSku>().WithMany().HasForeignKey("BundleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_Bundle_BundleID_COM_SKU"),
                        r => r.HasOne<ComSku>().WithMany().HasForeignKey("Skuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_Bundle_SKUID_COM_SKU"),
                        j =>
                        {
                            j.HasKey("BundleId", "Skuid");

                            j.ToTable("COM_Bundle", "dbo");

                            j.HasIndex(new[] { "Skuid" }, "IX_COM_Bundle_SKUID");

                            j.IndexerProperty<int>("BundleId").HasColumnName("BundleID");

                            j.IndexerProperty<int>("Skuid").HasColumnName("SKUID");
                        });

                entity.HasMany(d => d.OptionSkus)
                    .WithMany(p => p.SkusNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "ComSkuallowedOption",
                        l => l.HasOne<ComSku>().WithMany().HasForeignKey("OptionSkuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_SKUOption_OptionSKUID_COM_SKU"),
                        r => r.HasOne<ComSku>().WithMany().HasForeignKey("Skuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_SKUOption_SKUID_COM_SKU"),
                        j =>
                        {
                            j.HasKey("OptionSkuid", "Skuid").HasName("PK_COM_SKUOption");

                            j.ToTable("COM_SKUAllowedOption", "dbo");

                            j.HasIndex(new[] { "Skuid" }, "IX_COM_SKUAllowedOption_SKUID");

                            j.IndexerProperty<int>("OptionSkuid").HasColumnName("OptionSKUID");

                            j.IndexerProperty<int>("Skuid").HasColumnName("SKUID");
                        });

                entity.HasMany(d => d.OptionSkusNavigation)
                    .WithMany(p => p.VariantSkus)
                    .UsingEntity<Dictionary<string, object>>(
                        "ComVariantOption",
                        l => l.HasOne<ComSku>().WithMany().HasForeignKey("OptionSkuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_VariantOption_OptionSKUID_COM_SKU"),
                        r => r.HasOne<ComSku>().WithMany().HasForeignKey("VariantSkuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_VariantOption_VariantSKUID_COM_SKU"),
                        j =>
                        {
                            j.HasKey("VariantSkuid", "OptionSkuid");

                            j.ToTable("COM_VariantOption", "dbo");

                            j.HasIndex(new[] { "OptionSkuid" }, "IX_COM_VariantOption_OptionSKUID");

                            j.IndexerProperty<int>("VariantSkuid").HasColumnName("VariantSKUID");

                            j.IndexerProperty<int>("OptionSkuid").HasColumnName("OptionSKUID");
                        });

                entity.HasMany(d => d.Skus)
                    .WithMany(p => p.Bundles)
                    .UsingEntity<Dictionary<string, object>>(
                        "ComBundle",
                        l => l.HasOne<ComSku>().WithMany().HasForeignKey("Skuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_Bundle_SKUID_COM_SKU"),
                        r => r.HasOne<ComSku>().WithMany().HasForeignKey("BundleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_Bundle_BundleID_COM_SKU"),
                        j =>
                        {
                            j.HasKey("BundleId", "Skuid");

                            j.ToTable("COM_Bundle", "dbo");

                            j.HasIndex(new[] { "Skuid" }, "IX_COM_Bundle_SKUID");

                            j.IndexerProperty<int>("BundleId").HasColumnName("BundleID");

                            j.IndexerProperty<int>("Skuid").HasColumnName("SKUID");
                        });

                entity.HasMany(d => d.SkusNavigation)
                    .WithMany(p => p.OptionSkus)
                    .UsingEntity<Dictionary<string, object>>(
                        "ComSkuallowedOption",
                        l => l.HasOne<ComSku>().WithMany().HasForeignKey("Skuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_SKUOption_SKUID_COM_SKU"),
                        r => r.HasOne<ComSku>().WithMany().HasForeignKey("OptionSkuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_SKUOption_OptionSKUID_COM_SKU"),
                        j =>
                        {
                            j.HasKey("OptionSkuid", "Skuid").HasName("PK_COM_SKUOption");

                            j.ToTable("COM_SKUAllowedOption", "dbo");

                            j.HasIndex(new[] { "Skuid" }, "IX_COM_SKUAllowedOption_SKUID");

                            j.IndexerProperty<int>("OptionSkuid").HasColumnName("OptionSKUID");

                            j.IndexerProperty<int>("Skuid").HasColumnName("SKUID");
                        });

                entity.HasMany(d => d.VariantSkus)
                    .WithMany(p => p.OptionSkusNavigation)
                    .UsingEntity<Dictionary<string, object>>(
                        "ComVariantOption",
                        l => l.HasOne<ComSku>().WithMany().HasForeignKey("VariantSkuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_VariantOption_VariantSKUID_COM_SKU"),
                        r => r.HasOne<ComSku>().WithMany().HasForeignKey("OptionSkuid").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_COM_VariantOption_OptionSKUID_COM_SKU"),
                        j =>
                        {
                            j.HasKey("VariantSkuid", "OptionSkuid");

                            j.ToTable("COM_VariantOption", "dbo");

                            j.HasIndex(new[] { "OptionSkuid" }, "IX_COM_VariantOption_OptionSKUID");

                            j.IndexerProperty<int>("VariantSkuid").HasColumnName("VariantSKUID");

                            j.IndexerProperty<int>("OptionSkuid").HasColumnName("OptionSKUID");
                        });
            });

            modelBuilder.Entity<ComSkufile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("COM_SKUFile", "dbo");

                entity.HasIndex(e => e.FileSkuid, "IX_COM_SKUFile_FileSKUID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileGuid).HasColumnName("FileGUID");

                entity.Property(e => e.FileMetaFileGuid).HasColumnName("FileMetaFileGUID");

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.FilePath).HasMaxLength(450);

                entity.Property(e => e.FileSkuid).HasColumnName("FileSKUID");

                entity.Property(e => e.FileType).HasMaxLength(50);

                entity.HasOne(d => d.FileSku)
                    .WithMany(p => p.ComSkufiles)
                    .HasForeignKey(d => d.FileSkuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_SKUFile_COM_SKU");
            });

            modelBuilder.Entity<ComSkuoptionCategory>(entity =>
            {
                entity.HasKey(e => e.SkucategoryId);

                entity.ToTable("COM_SKUOptionCategory", "dbo");

                entity.HasIndex(e => e.CategoryId, "IX_COM_SKUOptionCategory_CategoryID");

                entity.HasIndex(e => e.Skuid, "IX_COM_SKUOptionCategory_SKUID");

                entity.Property(e => e.SkucategoryId).HasColumnName("SKUCategoryID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.SkucategoryOrder).HasColumnName("SKUCategoryOrder");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ComSkuoptionCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_SKUOptionCategory_CategoryID_COM_OptionCategory");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComSkuoptionCategories)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_SKUOptionCategory_SKUID_COM_SKU");
            });

            modelBuilder.Entity<ComSupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .IsClustered(false);

                entity.ToTable("COM_Supplier", "dbo");

                entity.HasIndex(e => new { e.SupplierDisplayName, e.SupplierEnabled }, "IX_COM_Supplier_SupplierDisplayName_SupplierEnabled")
                    .IsClustered();

                entity.HasIndex(e => e.SupplierSiteId, "IX_COM_Supplier_SupplierSiteID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SupplierEmail).HasMaxLength(254);

                entity.Property(e => e.SupplierEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SupplierFax).HasMaxLength(50);

                entity.Property(e => e.SupplierGuid).HasColumnName("SupplierGUID");

                entity.Property(e => e.SupplierLastModified).HasDefaultValueSql("('9/21/2012 12:34:09 PM')");

                entity.Property(e => e.SupplierName).HasMaxLength(200);

                entity.Property(e => e.SupplierPhone).HasMaxLength(50);

                entity.Property(e => e.SupplierSiteId).HasColumnName("SupplierSiteID");

                entity.HasOne(d => d.SupplierSite)
                    .WithMany(p => p.ComSuppliers)
                    .HasForeignKey(d => d.SupplierSiteId)
                    .HasConstraintName("FK_COM_Supplier_SupplierSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComTaxClass>(entity =>
            {
                entity.HasKey(e => e.TaxClassId)
                    .IsClustered(false);

                entity.ToTable("COM_TaxClass", "dbo");

                entity.HasIndex(e => e.TaxClassDisplayName, "IX_COM_TaxClass_TaxClassDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.TaxClassSiteId, "IX_COM_TaxClass_TaxClassSiteID");

                entity.Property(e => e.TaxClassId).HasColumnName("TaxClassID");

                entity.Property(e => e.TaxClassDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TaxClassGuid).HasColumnName("TaxClassGUID");

                entity.Property(e => e.TaxClassLastModified).HasDefaultValueSql("('9/20/2012 1:31:27 PM')");

                entity.Property(e => e.TaxClassName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TaxClassSiteId).HasColumnName("TaxClassSiteID");

                entity.Property(e => e.TaxClassZeroIfIdsupplied)
                    .HasColumnName("TaxClassZeroIfIDSupplied")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.TaxClassSite)
                    .WithMany(p => p.ComTaxClasses)
                    .HasForeignKey(d => d.TaxClassSiteId)
                    .HasConstraintName("FK_COM_TaxClass_TaxClassSiteID_CMS_Site");
            });

            modelBuilder.Entity<ComTaxClassCountry>(entity =>
            {
                entity.HasKey(e => e.TaxClassCountryId);

                entity.ToTable("COM_TaxClassCountry", "dbo");

                entity.HasIndex(e => e.CountryId, "IX_COM_TaxClassCountry_CountryID");

                entity.HasIndex(e => new { e.TaxClassId, e.CountryId }, "IX_COM_TaxClassCountry_TaxClassID_CountryID")
                    .IsUnique();

                entity.Property(e => e.TaxClassCountryId).HasColumnName("TaxClassCountryID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.TaxClassId).HasColumnName("TaxClassID");

                entity.Property(e => e.TaxValue).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ComTaxClassCountries)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_TaxCategoryCountry_CountryID_CMS_Country");

                entity.HasOne(d => d.TaxClass)
                    .WithMany(p => p.ComTaxClassCountries)
                    .HasForeignKey(d => d.TaxClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_TaxCategoryCountry_TaxClassID_COM_TaxClass");
            });

            modelBuilder.Entity<ComTaxClassState>(entity =>
            {
                entity.HasKey(e => e.TaxClassStateId);

                entity.ToTable("COM_TaxClassState", "dbo");

                entity.HasIndex(e => e.StateId, "IX_COM_TaxClassState_StateID");

                entity.HasIndex(e => new { e.TaxClassId, e.StateId }, "IX_COM_TaxClassState_TaxClassID_StateID")
                    .IsUnique();

                entity.Property(e => e.TaxClassStateId).HasColumnName("TaxClassStateID");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.TaxClassId).HasColumnName("TaxClassID");

                entity.Property(e => e.TaxValue).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ComTaxClassStates)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_TaxClassState_StateID_CMS_State");

                entity.HasOne(d => d.TaxClass)
                    .WithMany(p => p.ComTaxClassStates)
                    .HasForeignKey(d => d.TaxClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_TaxClassState_TaxClassID_COM_TaxClass");
            });

            modelBuilder.Entity<ComVolumeDiscount>(entity =>
            {
                entity.HasKey(e => e.VolumeDiscountId);

                entity.ToTable("COM_VolumeDiscount", "dbo");

                entity.HasIndex(e => e.VolumeDiscountSkuid, "IX_COM_VolumeDiscount_VolumeDiscountSKUID");

                entity.Property(e => e.VolumeDiscountId).HasColumnName("VolumeDiscountID");

                entity.Property(e => e.VolumeDiscountGuid).HasColumnName("VolumeDiscountGUID");

                entity.Property(e => e.VolumeDiscountSkuid).HasColumnName("VolumeDiscountSKUID");

                entity.Property(e => e.VolumeDiscountValue).HasColumnType("decimal(18, 9)");

                entity.HasOne(d => d.VolumeDiscountSku)
                    .WithMany(p => p.ComVolumeDiscounts)
                    .HasForeignKey(d => d.VolumeDiscountSkuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_VolumeDiscount_VolumeDiscountSKUID_COM_SKU");
            });

            modelBuilder.Entity<ComWishlist>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Skuid, e.SiteId });

                entity.ToTable("COM_Wishlist", "dbo");

                entity.HasIndex(e => e.Skuid, "IX_COM_Wishlist_SKUID");

                entity.HasIndex(e => new { e.SiteId, e.UserId }, "IX_COM_Wishlist_SiteID_UserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ComWishlists)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Wishlist_SiteID_CMS_Site");

                entity.HasOne(d => d.Sku)
                    .WithMany(p => p.ComWishlists)
                    .HasForeignKey(d => d.Skuid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Wishlist_SKUID_COM_SKU");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ComWishlists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COM_Wishlist_UserID_CMS_User");
            });

            modelBuilder.Entity<CommunityGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .IsClustered(false);

                entity.ToTable("Community_Group", "dbo");

                entity.HasIndex(e => e.GroupApproved, "IX_Community_Group_GroupApproved");

                entity.HasIndex(e => e.GroupApprovedByUserId, "IX_Community_Group_GroupApprovedByUserID");

                entity.HasIndex(e => e.GroupAvatarId, "IX_Community_Group_GroupAvatarID");

                entity.HasIndex(e => e.GroupCreatedByUserId, "IX_Community_Group_GroupCreatedByUserID");

                entity.HasIndex(e => new { e.GroupSiteId, e.GroupDisplayName }, "IX_Community_Group_GroupDisplayName")
                    .IsClustered();

                entity.HasIndex(e => new { e.GroupSiteId, e.GroupName }, "IX_Community_Group_GroupSiteID_GroupName");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupApprovedByUserId).HasColumnName("GroupApprovedByUserID");

                entity.Property(e => e.GroupAvatarId).HasColumnName("GroupAvatarID");

                entity.Property(e => e.GroupCreatedByUserId).HasColumnName("GroupCreatedByUserID");

                entity.Property(e => e.GroupCreatedWhen).HasDefaultValueSql("('10/21/2008 10:17:56 AM')");

                entity.Property(e => e.GroupDisplayName).HasMaxLength(200);

                entity.Property(e => e.GroupGuid).HasColumnName("GroupGUID");

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.GroupNodeGuid).HasColumnName("GroupNodeGUID");

                entity.Property(e => e.GroupSecurity).HasDefaultValueSql("((444))");

                entity.Property(e => e.GroupSendJoinLeaveNotification).HasDefaultValueSql("((1))");

                entity.Property(e => e.GroupSendWaitingForApprovalNotification).HasDefaultValueSql("((1))");

                entity.Property(e => e.GroupSiteId).HasColumnName("GroupSiteID");

                entity.HasOne(d => d.GroupApprovedByUser)
                    .WithMany(p => p.CommunityGroupGroupApprovedByUsers)
                    .HasForeignKey(d => d.GroupApprovedByUserId)
                    .HasConstraintName("FK_Community_Group_GroupApprovedByUserID_CMS_User");

                entity.HasOne(d => d.GroupAvatar)
                    .WithMany(p => p.CommunityGroups)
                    .HasForeignKey(d => d.GroupAvatarId)
                    .HasConstraintName("FK_Community_Group_GroupAvatarID_CMS_Avatar");

                entity.HasOne(d => d.GroupCreatedByUser)
                    .WithMany(p => p.CommunityGroupGroupCreatedByUsers)
                    .HasForeignKey(d => d.GroupCreatedByUserId)
                    .HasConstraintName("FK_Community_Group_GroupCreatedByUserID_CMS_User");

                entity.HasOne(d => d.GroupSite)
                    .WithMany(p => p.CommunityGroups)
                    .HasForeignKey(d => d.GroupSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Community_Group_GroupSiteID_CMS_Site");
            });

            modelBuilder.Entity<CommunityGroupMember>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .IsClustered(false);

                entity.ToTable("Community_GroupMember", "dbo");

                entity.HasIndex(e => e.MemberApprovedByUserId, "IX_Community_GroupMember_MemberApprovedByUserID");

                entity.HasIndex(e => e.MemberGroupId, "IX_Community_GroupMember_MemberGroupID");

                entity.HasIndex(e => e.MemberInvitedByUserId, "IX_Community_GroupMember_MemberInvitedByUserID");

                entity.HasIndex(e => e.MemberJoined, "IX_Community_GroupMember_MemberJoined")
                    .IsClustered();

                entity.HasIndex(e => e.MemberStatus, "IX_Community_GroupMember_MemberStatus");

                entity.HasIndex(e => e.MemberUserId, "IX_Community_GroupMember_MemberUserID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.MemberApprovedByUserId).HasColumnName("MemberApprovedByUserID");

                entity.Property(e => e.MemberGroupId).HasColumnName("MemberGroupID");

                entity.Property(e => e.MemberGuid).HasColumnName("MemberGUID");

                entity.Property(e => e.MemberInvitedByUserId).HasColumnName("MemberInvitedByUserID");

                entity.Property(e => e.MemberStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.MemberUserId).HasColumnName("MemberUserID");

                entity.HasOne(d => d.MemberApprovedByUser)
                    .WithMany(p => p.CommunityGroupMemberMemberApprovedByUsers)
                    .HasForeignKey(d => d.MemberApprovedByUserId)
                    .HasConstraintName("FK_Community_GroupMember_MemberApprovedByUserID_CMS_User");

                entity.HasOne(d => d.MemberGroup)
                    .WithMany(p => p.CommunityGroupMembers)
                    .HasForeignKey(d => d.MemberGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Community_GroupMember_MemberGroupID_Community_Group");

                entity.HasOne(d => d.MemberInvitedByUser)
                    .WithMany(p => p.CommunityGroupMemberMemberInvitedByUsers)
                    .HasForeignKey(d => d.MemberInvitedByUserId)
                    .HasConstraintName("FK_Community_GroupMember_MemberInvitedByUserID_CMS_User");

                entity.HasOne(d => d.MemberUser)
                    .WithMany(p => p.CommunityGroupMemberMemberUsers)
                    .HasForeignKey(d => d.MemberUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Community_GroupMember_MemberUserID_CMS_User");
            });

            modelBuilder.Entity<CommunityGroupRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.RoleId, e.PermissionId });

                entity.ToTable("Community_GroupRolePermission", "dbo");

                entity.HasIndex(e => e.PermissionId, "IX_Community_GroupRolePermission_PermissionID");

                entity.HasIndex(e => e.RoleId, "IX_Community_GroupRolePermission_RoleID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.CommunityGroupRolePermissions)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_community_GroupRolePermission_GroupID_Community_Group");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.CommunityGroupRolePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_community_GroupRolePermission_PermissionID_CMS_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.CommunityGroupRolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_community_GroupRolePermission_RoleID_CMS_Role");
            });

            modelBuilder.Entity<CommunityInvitation>(entity =>
            {
                entity.HasKey(e => e.InvitationId)
                    .HasName("PK_Community_GroupInvitation");

                entity.ToTable("Community_Invitation", "dbo");

                entity.HasIndex(e => e.InvitationGroupId, "IX_Community_Invitation_InvitationGroupID");

                entity.HasIndex(e => e.InvitedByUserId, "IX_Community_Invitation_InvitedByUserID");

                entity.HasIndex(e => e.InvitedUserId, "IX_Community_Invitation_InvitedUserID");

                entity.Property(e => e.InvitationId).HasColumnName("InvitationID");

                entity.Property(e => e.InvitationGroupId).HasColumnName("InvitationGroupID");

                entity.Property(e => e.InvitationGuid).HasColumnName("InvitationGUID");

                entity.Property(e => e.InvitationUserEmail).HasMaxLength(254);

                entity.Property(e => e.InvitedByUserId).HasColumnName("InvitedByUserID");

                entity.Property(e => e.InvitedUserId).HasColumnName("InvitedUserID");

                entity.HasOne(d => d.InvitationGroup)
                    .WithMany(p => p.CommunityInvitations)
                    .HasForeignKey(d => d.InvitationGroupId)
                    .HasConstraintName("FK_Community_GroupInvitation_InvitationGroupID_Community_Group");

                entity.HasOne(d => d.InvitedByUser)
                    .WithMany(p => p.CommunityInvitationInvitedByUsers)
                    .HasForeignKey(d => d.InvitedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Community_GroupInvitation_InvitedByUserID_CMS_User");

                entity.HasOne(d => d.InvitedUser)
                    .WithMany(p => p.CommunityInvitationInvitedUsers)
                    .HasForeignKey(d => d.InvitedUserId)
                    .HasConstraintName("FK_Community_GroupInvitation_InvitedUserID_CMS_User");
            });

            modelBuilder.Entity<ContentArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleId);

                entity.ToTable("CONTENT_Article", "dbo");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.ArticleName)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PageLink)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'Article-Published')");
            });

            modelBuilder.Entity<ContentBlog>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.ToTable("CONTENT_Blog", "dbo");

                entity.Property(e => e.BlogId).HasColumnName("BlogID");

                entity.Property(e => e.BlogAllowAnonymousComments)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BlogDescription).HasDefaultValueSql("(N'')");

                entity.Property(e => e.BlogEnableOptIn).HasDefaultValueSql("((-1))");

                entity.Property(e => e.BlogEnableSubscriptions).HasDefaultValueSql("((0))");

                entity.Property(e => e.BlogModerators).HasMaxLength(450);

                entity.Property(e => e.BlogName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BlogOpenCommentsFor)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BlogOptInApprovalUrl)
                    .HasMaxLength(450)
                    .HasColumnName("BlogOptInApprovalURL");

                entity.Property(e => e.BlogRequireEmails).HasDefaultValueSql("((0))");

                entity.Property(e => e.BlogSendCommentsToEmail).HasMaxLength(254);

                entity.Property(e => e.BlogSendOptInConfirmation).HasDefaultValueSql("((-1))");

                entity.Property(e => e.BlogUnsubscriptionUrl).HasMaxLength(250);

                entity.Property(e => e.BlogUseCaptchaforComments)
                    .IsRequired()
                    .HasColumnName("BlogUseCAPTCHAForComments")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ContentBlogMonth>(entity =>
            {
                entity.HasKey(e => e.BlogMonthId);

                entity.ToTable("CONTENT_BlogMonth", "dbo");

                entity.Property(e => e.BlogMonthId).HasColumnName("BlogMonthID");

                entity.Property(e => e.BlogMonthName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BlogMonthStartingDate).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ContentBlogPost>(entity =>
            {
                entity.HasKey(e => e.BlogPostId);

                entity.ToTable("CONTENT_BlogPost", "dbo");

                entity.Property(e => e.BlogPostId).HasColumnName("BlogPostID");

                entity.Property(e => e.BlogLogActivity).HasDefaultValueSql("((1))");

                entity.Property(e => e.BlogPostAllowComments)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BlogPostBody).HasDefaultValueSql("(N'')");

                entity.Property(e => e.BlogPostDate).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.BlogPostTitle)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInAutoPost).HasMaxLength(200);
            });

            modelBuilder.Entity<ContentBookingEvent>(entity =>
            {
                entity.HasKey(e => e.BookingEventId);

                entity.ToTable("CONTENT_BookingEvent", "dbo");

                entity.Property(e => e.BookingEventId).HasColumnName("BookingEventID");

                entity.Property(e => e.EventAllDay).HasDefaultValueSql("((0))");

                entity.Property(e => e.EventAllowRegistrationOverCapacity).HasDefaultValueSql("((0))");

                entity.Property(e => e.EventLogActivity).HasDefaultValueSql("((1))");

                entity.Property(e => e.EventName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ContentEvent>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("CONTENT_Event", "dbo");

                entity.Property(e => e.EventId).HasColumnName("EventID");

                entity.Property(e => e.EventName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ContentFaq>(entity =>
            {
                entity.HasKey(e => e.Faqid);

                entity.ToTable("CONTENT_FAQ", "dbo");

                entity.Property(e => e.Faqid).HasColumnName("FAQID");

                entity.Property(e => e.Faqanswer)
                    .HasColumnName("FAQAnswer")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Faqquestion)
                    .HasMaxLength(450)
                    .HasColumnName("FAQQuestion")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ContentFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("CONTENT_File", "dbo");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileDescription).HasMaxLength(500);

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<ContentImageGallery>(entity =>
            {
                entity.HasKey(e => e.ImageGalleryId);

                entity.ToTable("CONTENT_ImageGallery", "dbo");

                entity.Property(e => e.ImageGalleryId).HasColumnName("ImageGalleryID");

                entity.Property(e => e.GalleryName)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ContentJob>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.ToTable("CONTENT_Job", "dbo");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ContentKbarticle>(entity =>
            {
                entity.HasKey(e => e.KbarticleId);

                entity.ToTable("CONTENT_KBArticle", "dbo");

                entity.Property(e => e.KbarticleId).HasColumnName("KBArticleID");

                entity.Property(e => e.ArticleAppliesTo).HasDefaultValueSql("(N'')");

                entity.Property(e => e.ArticleIdentifier).HasMaxLength(200);

                entity.Property(e => e.ArticleName)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ArticleSummary).HasDefaultValueSql("(N'')");

                entity.Property(e => e.ArticleText).HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ContentMenuItem>(entity =>
            {
                entity.HasKey(e => e.MenuItemId);

                entity.ToTable("CONTENT_MenuItem", "dbo");

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.MenuItemGroup).HasMaxLength(100);

                entity.Property(e => e.MenuItemName)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ContentNews>(entity =>
            {
                entity.HasKey(e => e.NewsId);

                entity.ToTable("CONTENT_News", "dbo");

                entity.Property(e => e.NewsId).HasColumnName("NewsID");

                entity.Property(e => e.NewsReleaseDate).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.NewsSummary).HasDefaultValueSql("(N'')");

                entity.Property(e => e.NewsTitle)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ContentOffice>(entity =>
            {
                entity.HasKey(e => e.OfficeId);

                entity.ToTable("CONTENT_Office", "dbo");

                entity.Property(e => e.OfficeId).HasColumnName("OfficeID");

                entity.Property(e => e.OfficeAddress1).HasMaxLength(400);

                entity.Property(e => e.OfficeAddress2).HasMaxLength(400);

                entity.Property(e => e.OfficeCity).HasMaxLength(400);

                entity.Property(e => e.OfficeCompanyName).HasMaxLength(200);

                entity.Property(e => e.OfficeCountry).HasMaxLength(200);

                entity.Property(e => e.OfficeEmail).HasMaxLength(254);

                entity.Property(e => e.OfficeIconUrl)
                    .HasMaxLength(200)
                    .HasColumnName("OfficeIconURL");

                entity.Property(e => e.OfficeIsHeadquarters).HasDefaultValueSql("((0))");

                entity.Property(e => e.OfficeName)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OfficePhone).HasMaxLength(100);

                entity.Property(e => e.OfficeState).HasMaxLength(200);

                entity.Property(e => e.OfficeZip)
                    .HasMaxLength(50)
                    .HasColumnName("OfficeZIP");
            });

            modelBuilder.Entity<ContentPressRelease>(entity =>
            {
                entity.HasKey(e => e.PressReleaseId);

                entity.ToTable("CONTENT_PressRelease", "dbo");

                entity.Property(e => e.PressReleaseId).HasColumnName("PressReleaseID");

                entity.Property(e => e.PressReleaseDate).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.PressReleaseSummary).HasDefaultValueSql("(N'')");

                entity.Property(e => e.PressReleaseText).HasDefaultValueSql("(N'')");

                entity.Property(e => e.PressReleaseTitle)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ContentProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("CONTENT_Product", "dbo");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductName).HasMaxLength(440);
            });

            modelBuilder.Entity<ContentSimpleArticle>(entity =>
            {
                entity.HasKey(e => e.ArticleId);

                entity.ToTable("CONTENT_SimpleArticle", "dbo");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.ArticleText).HasDefaultValueSql("(N'')");

                entity.Property(e => e.ArticleTitle)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<CustomtableSampleTable>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("customtable_SampleTable");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

                entity.Property(e => e.ItemText)
                    .HasMaxLength(400)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<EventsAttendee>(entity =>
            {
                entity.HasKey(e => e.AttendeeId)
                    .IsClustered(false);

                entity.ToTable("Events_Attendee", "dbo");

                entity.HasIndex(e => new { e.AttendeeEmail, e.AttendeeFirstName, e.AttendeeLastName }, "IX_Events_Attendee_AttendeeEmail_AttendeeFirstName_AttendeeLastName")
                    .IsClustered();

                entity.HasIndex(e => e.AttendeeEventNodeId, "IX_Events_Attendee_AttendeeEventNodeID");

                entity.Property(e => e.AttendeeId).HasColumnName("AttendeeID");

                entity.Property(e => e.AttendeeEmail)
                    .HasMaxLength(254)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AttendeeEventNodeId).HasColumnName("AttendeeEventNodeID");

                entity.Property(e => e.AttendeeFirstName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AttendeeGuid).HasColumnName("AttendeeGUID");

                entity.Property(e => e.AttendeeLastModified).HasDefaultValueSql("('1/20/2015 8:52:25 AM')");

                entity.Property(e => e.AttendeeLastName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AttendeePhone)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.AttendeeEventNode)
                    .WithMany(p => p.EventsAttendees)
                    .HasForeignKey(d => d.AttendeeEventNodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Events_Attendee_AttendeeEventNodeID_CMS_Tree");
            });

            modelBuilder.Entity<ExportHistory>(entity =>
            {
                entity.HasKey(e => e.ExportId)
                    .IsClustered(false);

                entity.ToTable("Export_History", "dbo");

                entity.HasIndex(e => e.ExportDateTime, "IX_Export_History_ExportDateTime")
                    .IsClustered();

                entity.HasIndex(e => e.ExportSiteId, "IX_Export_History_ExportSiteID");

                entity.HasIndex(e => e.ExportUserId, "IX_Export_History_ExportUserID");

                entity.Property(e => e.ExportId).HasColumnName("ExportID");

                entity.Property(e => e.ExportFileName)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ExportSiteId).HasColumnName("ExportSiteID");

                entity.Property(e => e.ExportUserId).HasColumnName("ExportUserID");

                entity.HasOne(d => d.ExportSite)
                    .WithMany(p => p.ExportHistories)
                    .HasForeignKey(d => d.ExportSiteId)
                    .HasConstraintName("FK_Export_History_ExportSiteID_CMS_Site");

                entity.HasOne(d => d.ExportUser)
                    .WithMany(p => p.ExportHistories)
                    .HasForeignKey(d => d.ExportUserId)
                    .HasConstraintName("FK_Export_History_ExportUserID_CMS_User");
            });

            modelBuilder.Entity<ExportTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("Export_Task", "dbo");

                entity.HasIndex(e => new { e.TaskSiteId, e.TaskObjectType }, "IX_Export_Task_TaskSiteID_TaskObjectType");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskObjectId).HasColumnName("TaskObjectID");

                entity.Property(e => e.TaskObjectType).HasMaxLength(100);

                entity.Property(e => e.TaskSiteId).HasColumnName("TaskSiteID");

                entity.Property(e => e.TaskTitle).HasMaxLength(450);

                entity.Property(e => e.TaskType).HasMaxLength(50);

                entity.HasOne(d => d.TaskSite)
                    .WithMany(p => p.ExportTasks)
                    .HasForeignKey(d => d.TaskSiteId)
                    .HasConstraintName("FK_Export_Task_TaskSiteID_CMS_Site");
            });

            modelBuilder.Entity<FormAbbasarabzadehArabzadehContact>(entity =>
            {
                entity.HasKey(e => e.ArabzadehContactId);

                entity.ToTable("Form_abbasarabzadeh_ArabzadehContact");

                entity.Property(e => e.ArabzadehContactId).HasColumnName("ArabzadehContactID");

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Message)
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Subject).HasMaxLength(500);

                entity.Property(e => e.YourEmail)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.YourName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<FormShokouhCenterBranchRequest>(entity =>
            {
                entity.HasKey(e => e.BranchRequestId);

                entity.ToTable("Form_ShokouhCenter_BranchRequest");

                entity.Property(e => e.BranchRequestId).HasColumnName("BranchRequestID");

                entity.Property(e => e.CalendarControl1).HasColumnName("CalendarControl_1");

                entity.Property(e => e.DropDownListControl).HasMaxLength(500);

                entity.Property(e => e.Emailinput)
                    .HasMaxLength(100)
                    .HasColumnName("emailinput");

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.MultipleChoiceControl)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'مرد')");

                entity.Property(e => e.TextAreaControl).HasMaxLength(500);

                entity.Property(e => e.TextAreaControl1)
                    .HasMaxLength(500)
                    .HasColumnName("TextAreaControl_1");

                entity.Property(e => e.TextAreaControl2)
                    .HasMaxLength(500)
                    .HasColumnName("TextAreaControl_2");

                entity.Property(e => e.TextAreaControl3)
                    .HasMaxLength(500)
                    .HasColumnName("TextAreaControl_3");

                entity.Property(e => e.TextBoxControl)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TextBoxControl1)
                    .HasMaxLength(500)
                    .HasColumnName("TextBoxControl_1")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TextBoxControl2)
                    .HasMaxLength(500)
                    .HasColumnName("TextBoxControl_2");

                entity.Property(e => e.TextBoxControl3)
                    .HasMaxLength(500)
                    .HasColumnName("TextBoxControl_3");

                entity.Property(e => e.TextBoxControl4)
                    .HasMaxLength(500)
                    .HasColumnName("TextBoxControl_4");

                entity.Property(e => e.TextBoxControl5)
                    .HasMaxLength(500)
                    .HasColumnName("TextBoxControl_5");

                entity.Property(e => e.TextBoxControl6)
                    .HasMaxLength(500)
                    .HasColumnName("TextBoxControl_6");

                entity.Property(e => e.TextBoxControl7)
                    .HasMaxLength(500)
                    .HasColumnName("TextBoxControl_7");
            });

            modelBuilder.Entity<FormShokouhCenterContactU>(entity =>
            {
                entity.HasKey(e => e.ContactUsId);

                entity.ToTable("Form_ShokouhCenter_ContactUs");

                entity.Property(e => e.ContactUsId).HasColumnName("ContactUsID");

                entity.Property(e => e.Emailinput)
                    .HasMaxLength(100)
                    .HasColumnName("emailinput");

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.TextAreaControl)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TextBoxControl)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TextBoxControl1)
                    .HasMaxLength(500)
                    .HasColumnName("TextBoxControl_1")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<FormShokouhCenterHiring>(entity =>
            {
                entity.HasKey(e => e.HiringCenterId);

                entity.ToTable("Form_ShokouhCenter_Hiring");

                entity.Property(e => e.HiringCenterId).HasColumnName("HiringCenterID");

                entity.Property(e => e.ActivitiesList).HasMaxLength(500);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Cretification)
                    .HasMaxLength(500)
                    .HasColumnName("CRETIFICATION");

                entity.Property(e => e.Education)
                    .HasMaxLength(500)
                    .HasColumnName("EDUCATION");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Experience)
                    .HasMaxLength(500)
                    .HasColumnName("EXPERIENCE");

                entity.Property(e => e.Family)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.MaritalStatus).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Phone).HasMaxLength(500);

                entity.Property(e => e.Photo)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Sex)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<FormShokouhOnlinePortalContact>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("Form_ShokouhOnlinePortal_Contact");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Emailinput)
                    .HasMaxLength(100)
                    .HasColumnName("emailinput")
                    .HasDefaultValueSql("(N'پست الکترونیک')");

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Message)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Subje)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'موضوع')");

                entity.Property(e => e.YourName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'نام و نام خانوادگی')");
            });

            modelBuilder.Entity<FormShokouhOnlinePortalHiring>(entity =>
            {
                entity.HasKey(e => e.HiringId);

                entity.ToTable("Form_ShokouhOnlinePortal_Hiring");

                entity.Property(e => e.HiringId).HasColumnName("HiringID");

                entity.Property(e => e.ActivitiesList).HasMaxLength(500);

                entity.Property(e => e.CellPhone)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Cretification)
                    .HasMaxLength(500)
                    .HasColumnName("CRETIFICATION");

                entity.Property(e => e.Education)
                    .HasMaxLength(500)
                    .HasColumnName("EDUCATION");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Experience)
                    .HasMaxLength(500)
                    .HasColumnName("EXPERIENCE");

                entity.Property(e => e.Family)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.MaritalStatus).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Phone).HasMaxLength(500);

                entity.Property(e => e.Photo)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Sex)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<FormShokouhOnlinePortalStudentName>(entity =>
            {
                entity.HasKey(e => e.StudentNameId);

                entity.ToTable("Form_ShokouhOnlinePortal_StudentName");

                entity.Property(e => e.StudentNameId).HasColumnName("StudentNameID");

                entity.Property(e => e.Day).HasMaxLength(200);

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Hour)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Level)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'No Level Selected')");

                entity.Property(e => e.StdName1).HasMaxLength(500);

                entity.Property(e => e.StdName10).HasMaxLength(500);

                entity.Property(e => e.StdName11).HasMaxLength(500);

                entity.Property(e => e.StdName12).HasMaxLength(500);

                entity.Property(e => e.StdName13).HasMaxLength(500);

                entity.Property(e => e.StdName14).HasMaxLength(500);

                entity.Property(e => e.StdName15).HasMaxLength(500);

                entity.Property(e => e.StdName16).HasMaxLength(500);

                entity.Property(e => e.StdName17).HasMaxLength(500);

                entity.Property(e => e.StdName18).HasMaxLength(500);

                entity.Property(e => e.StdName19).HasMaxLength(500);

                entity.Property(e => e.StdName2).HasMaxLength(500);

                entity.Property(e => e.StdName20).HasMaxLength(500);

                entity.Property(e => e.StdName3).HasMaxLength(500);

                entity.Property(e => e.StdName4).HasMaxLength(500);

                entity.Property(e => e.StdName5).HasMaxLength(500);

                entity.Property(e => e.StdName6).HasMaxLength(500);

                entity.Property(e => e.StdName7).HasMaxLength(500);

                entity.Property(e => e.StdName8).HasMaxLength(500);

                entity.Property(e => e.StdName9).HasMaxLength(500);

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Tel1).HasMaxLength(500);

                entity.Property(e => e.Tel10)
                    .HasMaxLength(500)
                    .HasColumnName("tel10");

                entity.Property(e => e.Tel11)
                    .HasMaxLength(500)
                    .HasColumnName("tel11");

                entity.Property(e => e.Tel12)
                    .HasMaxLength(500)
                    .HasColumnName("tel12");

                entity.Property(e => e.Tel13)
                    .HasMaxLength(500)
                    .HasColumnName("tel13");

                entity.Property(e => e.Tel14)
                    .HasMaxLength(500)
                    .HasColumnName("tel14");

                entity.Property(e => e.Tel15)
                    .HasMaxLength(500)
                    .HasColumnName("tel15");

                entity.Property(e => e.Tel16)
                    .HasMaxLength(500)
                    .HasColumnName("tel16");

                entity.Property(e => e.Tel17)
                    .HasMaxLength(500)
                    .HasColumnName("tel17");

                entity.Property(e => e.Tel18)
                    .HasMaxLength(500)
                    .HasColumnName("tel18");

                entity.Property(e => e.Tel19)
                    .HasMaxLength(500)
                    .HasColumnName("tel19");

                entity.Property(e => e.Tel2).HasMaxLength(500);

                entity.Property(e => e.Tel20)
                    .HasMaxLength(500)
                    .HasColumnName("tel20");

                entity.Property(e => e.Tel3).HasMaxLength(500);

                entity.Property(e => e.Tel4)
                    .HasMaxLength(500)
                    .HasColumnName("tel4");

                entity.Property(e => e.Tel5)
                    .HasMaxLength(500)
                    .HasColumnName("tel5");

                entity.Property(e => e.Tel6)
                    .HasMaxLength(500)
                    .HasColumnName("tel6");

                entity.Property(e => e.Tel7)
                    .HasMaxLength(500)
                    .HasColumnName("tel7");

                entity.Property(e => e.Tel8)
                    .HasMaxLength(500)
                    .HasColumnName("tel8");

                entity.Property(e => e.Tel9)
                    .HasMaxLength(500)
                    .HasColumnName("tel9");

                entity.Property(e => e.Term)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'اول تابستان')");
            });

            modelBuilder.Entity<FormShokouhOnlinePortalStudentNameTel>(entity =>
            {
                entity.HasKey(e => e.StudentNameTelId);

                entity.ToTable("Form_ShokouhOnlinePortal_StudentName_Tel");

                entity.Property(e => e.StudentNameTelId).HasColumnName("StudentName_TelID");

                entity.Property(e => e.Day).HasMaxLength(200);

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Hour)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Level)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'No Level Selected')");

                entity.Property(e => e.StdName1).HasMaxLength(500);

                entity.Property(e => e.StdName10).HasMaxLength(500);

                entity.Property(e => e.StdName11).HasMaxLength(500);

                entity.Property(e => e.StdName12).HasMaxLength(500);

                entity.Property(e => e.StdName13).HasMaxLength(500);

                entity.Property(e => e.StdName14).HasMaxLength(500);

                entity.Property(e => e.StdName15).HasMaxLength(500);

                entity.Property(e => e.StdName16).HasMaxLength(500);

                entity.Property(e => e.StdName17).HasMaxLength(500);

                entity.Property(e => e.StdName18).HasMaxLength(500);

                entity.Property(e => e.StdName19).HasMaxLength(500);

                entity.Property(e => e.StdName2).HasMaxLength(500);

                entity.Property(e => e.StdName20).HasMaxLength(500);

                entity.Property(e => e.StdName3).HasMaxLength(500);

                entity.Property(e => e.StdName4).HasMaxLength(500);

                entity.Property(e => e.StdName5).HasMaxLength(500);

                entity.Property(e => e.StdName6).HasMaxLength(500);

                entity.Property(e => e.StdName7).HasMaxLength(500);

                entity.Property(e => e.StdName8).HasMaxLength(500);

                entity.Property(e => e.StdName9).HasMaxLength(500);

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Tel1).HasMaxLength(500);

                entity.Property(e => e.Tel10)
                    .HasMaxLength(500)
                    .HasColumnName("tel10");

                entity.Property(e => e.Tel11)
                    .HasMaxLength(500)
                    .HasColumnName("tel11");

                entity.Property(e => e.Tel12)
                    .HasMaxLength(500)
                    .HasColumnName("tel12");

                entity.Property(e => e.Tel13)
                    .HasMaxLength(500)
                    .HasColumnName("tel13");

                entity.Property(e => e.Tel14)
                    .HasMaxLength(500)
                    .HasColumnName("tel14");

                entity.Property(e => e.Tel15)
                    .HasMaxLength(500)
                    .HasColumnName("tel15");

                entity.Property(e => e.Tel16)
                    .HasMaxLength(500)
                    .HasColumnName("tel16");

                entity.Property(e => e.Tel17)
                    .HasMaxLength(500)
                    .HasColumnName("tel17");

                entity.Property(e => e.Tel18)
                    .HasMaxLength(500)
                    .HasColumnName("tel18");

                entity.Property(e => e.Tel19)
                    .HasMaxLength(500)
                    .HasColumnName("tel19");

                entity.Property(e => e.Tel2).HasMaxLength(500);

                entity.Property(e => e.Tel20)
                    .HasMaxLength(500)
                    .HasColumnName("tel20");

                entity.Property(e => e.Tel3).HasMaxLength(500);

                entity.Property(e => e.Tel4)
                    .HasMaxLength(500)
                    .HasColumnName("tel4");

                entity.Property(e => e.Tel5)
                    .HasMaxLength(500)
                    .HasColumnName("tel5");

                entity.Property(e => e.Tel6)
                    .HasMaxLength(500)
                    .HasColumnName("tel6");

                entity.Property(e => e.Tel7)
                    .HasMaxLength(500)
                    .HasColumnName("tel7");

                entity.Property(e => e.Tel8)
                    .HasMaxLength(500)
                    .HasColumnName("tel8");

                entity.Property(e => e.Tel9)
                    .HasMaxLength(500)
                    .HasColumnName("tel9");

                entity.Property(e => e.Term)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'اول تابستان')");

                entity.Property(e => e.Tuition).HasDefaultValueSql("((3500000))");
            });

            modelBuilder.Entity<FormShokouhOnlinePortalStudentNameTelBackup>(entity =>
            {
                entity.HasKey(e => e.StudentNameTelBackupId);

                entity.ToTable("Form_ShokouhOnlinePortal_StudentName_Tel_backup");

                entity.Property(e => e.StudentNameTelBackupId).HasColumnName("StudentName_Tel_backupID");

                entity.Property(e => e.Day).HasMaxLength(200);

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Hour)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Level)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'No Level Selected')");

                entity.Property(e => e.StdName1).HasMaxLength(500);

                entity.Property(e => e.StdName10).HasMaxLength(500);

                entity.Property(e => e.StdName11).HasMaxLength(500);

                entity.Property(e => e.StdName12).HasMaxLength(500);

                entity.Property(e => e.StdName13).HasMaxLength(500);

                entity.Property(e => e.StdName14).HasMaxLength(500);

                entity.Property(e => e.StdName15).HasMaxLength(500);

                entity.Property(e => e.StdName16).HasMaxLength(500);

                entity.Property(e => e.StdName17).HasMaxLength(500);

                entity.Property(e => e.StdName18).HasMaxLength(500);

                entity.Property(e => e.StdName19).HasMaxLength(500);

                entity.Property(e => e.StdName2).HasMaxLength(500);

                entity.Property(e => e.StdName20).HasMaxLength(500);

                entity.Property(e => e.StdName3).HasMaxLength(500);

                entity.Property(e => e.StdName4).HasMaxLength(500);

                entity.Property(e => e.StdName5).HasMaxLength(500);

                entity.Property(e => e.StdName6).HasMaxLength(500);

                entity.Property(e => e.StdName7).HasMaxLength(500);

                entity.Property(e => e.StdName8).HasMaxLength(500);

                entity.Property(e => e.StdName9).HasMaxLength(500);

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Tel1).HasMaxLength(500);

                entity.Property(e => e.Tel10)
                    .HasMaxLength(500)
                    .HasColumnName("tel10");

                entity.Property(e => e.Tel11)
                    .HasMaxLength(500)
                    .HasColumnName("tel11");

                entity.Property(e => e.Tel12)
                    .HasMaxLength(500)
                    .HasColumnName("tel12");

                entity.Property(e => e.Tel13)
                    .HasMaxLength(500)
                    .HasColumnName("tel13");

                entity.Property(e => e.Tel14)
                    .HasMaxLength(500)
                    .HasColumnName("tel14");

                entity.Property(e => e.Tel15)
                    .HasMaxLength(500)
                    .HasColumnName("tel15");

                entity.Property(e => e.Tel16)
                    .HasMaxLength(500)
                    .HasColumnName("tel16");

                entity.Property(e => e.Tel17)
                    .HasMaxLength(500)
                    .HasColumnName("tel17");

                entity.Property(e => e.Tel18)
                    .HasMaxLength(500)
                    .HasColumnName("tel18");

                entity.Property(e => e.Tel19)
                    .HasMaxLength(500)
                    .HasColumnName("tel19");

                entity.Property(e => e.Tel2).HasMaxLength(500);

                entity.Property(e => e.Tel20)
                    .HasMaxLength(500)
                    .HasColumnName("tel20");

                entity.Property(e => e.Tel3).HasMaxLength(500);

                entity.Property(e => e.Tel4)
                    .HasMaxLength(500)
                    .HasColumnName("tel4");

                entity.Property(e => e.Tel5)
                    .HasMaxLength(500)
                    .HasColumnName("tel5");

                entity.Property(e => e.Tel6)
                    .HasMaxLength(500)
                    .HasColumnName("tel6");

                entity.Property(e => e.Tel7)
                    .HasMaxLength(500)
                    .HasColumnName("tel7");

                entity.Property(e => e.Tel8)
                    .HasMaxLength(500)
                    .HasColumnName("tel8");

                entity.Property(e => e.Tel9)
                    .HasMaxLength(500)
                    .HasColumnName("tel9");

                entity.Property(e => e.Term)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'اول تابستان')");

                entity.Property(e => e.Tuition).HasDefaultValueSql("((3500000))");
            });

            modelBuilder.Entity<FormShokouhOnlinePortalWriting>(entity =>
            {
                entity.HasKey(e => e.WritingId);

                entity.ToTable("Form_ShokouhOnlinePortal_Writing");

                entity.Property(e => e.WritingId).HasColumnName("WritingID");

                entity.Property(e => e.DropDownListControl).HasMaxLength(500);

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Student)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Teacher)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.YourLevel)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.YourWriting).HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<FormShokouhOnlinePortalWritingBackup>(entity =>
            {
                entity.HasKey(e => e.WritingBackupId);

                entity.ToTable("Form_ShokouhOnlinePortal_Writing_backup");

                entity.Property(e => e.WritingBackupId).HasColumnName("Writing_backupID");

                entity.Property(e => e.DropDownListControl).HasMaxLength(500);

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Student)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Teacher)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.YourLevel)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.YourWriting).HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ForumsAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId);

                entity.ToTable("Forums_Attachment", "dbo");

                entity.HasIndex(e => new { e.AttachmentSiteId, e.AttachmentGuid }, "IX_Forums_Attachment_AttachmentGUID")
                    .IsUnique();

                entity.HasIndex(e => e.AttachmentPostId, "IX_Forums_Attachment_AttachmentPostID");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AttachmentFileExtension).HasMaxLength(10);

                entity.Property(e => e.AttachmentFileName).HasMaxLength(200);

                entity.Property(e => e.AttachmentGuid).HasColumnName("AttachmentGUID");

                entity.Property(e => e.AttachmentMimeType).HasMaxLength(100);

                entity.Property(e => e.AttachmentPostId).HasColumnName("AttachmentPostID");

                entity.Property(e => e.AttachmentSiteId).HasColumnName("AttachmentSiteID");

                entity.HasOne(d => d.AttachmentPost)
                    .WithMany(p => p.ForumsAttachments)
                    .HasForeignKey(d => d.AttachmentPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_Attachment_AttachmentPostID_Forums_ForumPost");

                entity.HasOne(d => d.AttachmentSite)
                    .WithMany(p => p.ForumsAttachments)
                    .HasForeignKey(d => d.AttachmentSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_Attachment_AttachmentSiteID_CMS_Site");
            });

            modelBuilder.Entity<ForumsForum>(entity =>
            {
                entity.HasKey(e => e.ForumId)
                    .IsClustered(false);

                entity.ToTable("Forums_Forum", "dbo");

                entity.HasIndex(e => e.ForumCommunityGroupId, "IX_Forums_Forum_ForumCommunityGroupID");

                entity.HasIndex(e => e.ForumDocumentId, "IX_Forums_Forum_ForumDocumentID");

                entity.HasIndex(e => new { e.ForumGroupId, e.ForumOrder }, "IX_Forums_Forum_ForumGroupID_ForumOrder")
                    .IsClustered();

                entity.HasIndex(e => new { e.ForumSiteId, e.ForumName }, "IX_Forums_Forum_ForumSiteID_ForumName");

                entity.Property(e => e.ForumId).HasColumnName("ForumID");

                entity.Property(e => e.ForumBaseUrl).HasMaxLength(200);

                entity.Property(e => e.ForumCommunityGroupId).HasColumnName("ForumCommunityGroupID");

                entity.Property(e => e.ForumDisplayName).HasMaxLength(200);

                entity.Property(e => e.ForumDocumentId).HasColumnName("ForumDocumentID");

                entity.Property(e => e.ForumGroupId).HasColumnName("ForumGroupID");

                entity.Property(e => e.ForumGuid).HasColumnName("ForumGUID");

                entity.Property(e => e.ForumHtmleditor).HasColumnName("ForumHTMLEditor");

                entity.Property(e => e.ForumImageMaxSideSize).HasDefaultValueSql("((400))");

                entity.Property(e => e.ForumIsAnswerLimit).HasDefaultValueSql("((5))");

                entity.Property(e => e.ForumIsLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.ForumLastPostUserName).HasMaxLength(200);

                entity.Property(e => e.ForumLastPostUserNameAbsolute).HasMaxLength(200);

                entity.Property(e => e.ForumName).HasMaxLength(200);

                entity.Property(e => e.ForumOptInApprovalUrl)
                    .HasMaxLength(450)
                    .HasColumnName("ForumOptInApprovalURL");

                entity.Property(e => e.ForumSiteId).HasColumnName("ForumSiteID");

                entity.Property(e => e.ForumUnsubscriptionUrl).HasMaxLength(200);

                entity.Property(e => e.ForumUseCaptcha).HasColumnName("ForumUseCAPTCHA");

                entity.HasOne(d => d.ForumCommunityGroup)
                    .WithMany(p => p.ForumsForums)
                    .HasForeignKey(d => d.ForumCommunityGroupId)
                    .HasConstraintName("FK_Forums_Forum_ForumCommunityGroupID_Community_Group");

                entity.HasOne(d => d.ForumDocument)
                    .WithMany(p => p.ForumsForums)
                    .HasForeignKey(d => d.ForumDocumentId)
                    .HasConstraintName("FK_Forums_Forum_ForumDocumentID_CMS_Document");

                entity.HasOne(d => d.ForumGroup)
                    .WithMany(p => p.ForumsForums)
                    .HasForeignKey(d => d.ForumGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_Forum_ForumGroupID_Forums_ForumGroup");

                entity.HasOne(d => d.ForumSite)
                    .WithMany(p => p.ForumsForums)
                    .HasForeignKey(d => d.ForumSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_Forum_ForumSiteID_CMS_Site");
            });

            modelBuilder.Entity<ForumsForumGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .IsClustered(false);

                entity.ToTable("Forums_ForumGroup", "dbo");

                entity.HasIndex(e => e.GroupGroupId, "IX_Forums_ForumGroup_GroupGroupID");

                entity.HasIndex(e => new { e.GroupSiteId, e.GroupName }, "IX_Forums_ForumGroup_GroupSiteID_GroupName");

                entity.HasIndex(e => new { e.GroupSiteId, e.GroupOrder }, "IX_Forums_ForumGroup_GroupSiteID_GroupOrder")
                    .IsClustered();

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupBaseUrl).HasMaxLength(200);

                entity.Property(e => e.GroupDisplayName).HasMaxLength(200);

                entity.Property(e => e.GroupGroupId).HasColumnName("GroupGroupID");

                entity.Property(e => e.GroupGuid).HasColumnName("GroupGUID");

                entity.Property(e => e.GroupHtmleditor)
                    .HasColumnName("GroupHTMLEditor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupImageMaxSideSize).HasDefaultValueSql("((400))");

                entity.Property(e => e.GroupLastModified).HasDefaultValueSql("('11/6/2013 2:43:02 PM')");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.GroupOptInApprovalUrl)
                    .HasMaxLength(450)
                    .HasColumnName("GroupOptInApprovalURL");

                entity.Property(e => e.GroupSiteId).HasColumnName("GroupSiteID");

                entity.Property(e => e.GroupUnsubscriptionUrl).HasMaxLength(200);

                entity.Property(e => e.GroupUseCaptcha)
                    .HasColumnName("GroupUseCAPTCHA")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.GroupGroup)
                    .WithMany(p => p.ForumsForumGroups)
                    .HasForeignKey(d => d.GroupGroupId)
                    .HasConstraintName("FK_Forums_ForumGroup_GroupGroupID_Community_Group");

                entity.HasOne(d => d.GroupSite)
                    .WithMany(p => p.ForumsForumGroups)
                    .HasForeignKey(d => d.GroupSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_ForumGroup_GroupSiteID_CMS_Site");
            });

            modelBuilder.Entity<ForumsForumPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .IsClustered(false);

                entity.ToTable("Forums_ForumPost", "dbo");

                entity.HasIndex(e => e.PostApproved, "IX_Forums_ForumPost_PostApproved");

                entity.HasIndex(e => e.PostApprovedByUserId, "IX_Forums_ForumPost_PostApprovedByUserID");

                entity.HasIndex(e => e.PostForumId, "IX_Forums_ForumPost_PostForumID");

                entity.HasIndex(e => e.PostIdpath, "IX_Forums_ForumPost_PostIDPath")
                    .IsUnique()
                    .IsClustered();

                entity.HasIndex(e => e.PostLevel, "IX_Forums_ForumPost_PostLevel");

                entity.HasIndex(e => e.PostParentId, "IX_Forums_ForumPost_PostParentID");

                entity.HasIndex(e => e.PostUserId, "IX_Forums_ForumPost_PostUserID");

                entity.Property(e => e.PostApprovedByUserId).HasColumnName("PostApprovedByUserID");

                entity.Property(e => e.PostAttachmentCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostForumId).HasColumnName("PostForumID");

                entity.Property(e => e.PostGuid).HasColumnName("PostGUID");

                entity.Property(e => e.PostIdpath).HasColumnName("PostIDPath");

                entity.Property(e => e.PostIsLocked).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostParentId).HasColumnName("PostParentID");

                entity.Property(e => e.PostQuestionSolved).HasDefaultValueSql("((0))");

                entity.Property(e => e.PostSiteId).HasColumnName("PostSiteID");

                entity.Property(e => e.PostSubject).HasMaxLength(450);

                entity.Property(e => e.PostThreadLastPostUserName).HasMaxLength(200);

                entity.Property(e => e.PostThreadLastPostUserNameAbsolute).HasMaxLength(200);

                entity.Property(e => e.PostUserId).HasColumnName("PostUserID");

                entity.Property(e => e.PostUserMail).HasMaxLength(254);

                entity.Property(e => e.PostUserName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.PostApprovedByUser)
                    .WithMany(p => p.ForumsForumPostPostApprovedByUsers)
                    .HasForeignKey(d => d.PostApprovedByUserId)
                    .HasConstraintName("FK_Forums_ForumPost_PostApprovedByUserID_CMS_User");

                entity.HasOne(d => d.PostForum)
                    .WithMany(p => p.ForumsForumPosts)
                    .HasForeignKey(d => d.PostForumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_ForumPost_PostForumID_Forums_Forum");

                entity.HasOne(d => d.PostParent)
                    .WithMany(p => p.InversePostParent)
                    .HasForeignKey(d => d.PostParentId)
                    .HasConstraintName("FK_Forums_ForumPost_PostParentID_Forums_ForumPost");

                entity.HasOne(d => d.PostUser)
                    .WithMany(p => p.ForumsForumPostPostUsers)
                    .HasForeignKey(d => d.PostUserId)
                    .HasConstraintName("FK_Forums_ForumPost_PostUserID_CMS_User");
            });

            modelBuilder.Entity<ForumsForumRole>(entity =>
            {
                entity.HasKey(e => new { e.ForumId, e.RoleId, e.PermissionId });

                entity.ToTable("Forums_ForumRoles", "dbo");

                entity.HasIndex(e => e.PermissionId, "IX_Forums_ForumRoles_PermissionID");

                entity.HasIndex(e => e.RoleId, "IX_Forums_ForumRoles_RoleID");

                entity.Property(e => e.ForumId).HasColumnName("ForumID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumsForumRoles)
                    .HasForeignKey(d => d.ForumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_ForumRoles_ForumID_Forums_Forum");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.ForumsForumRoles)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_ForumRoles_PermissionID_CMS_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ForumsForumRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_ForumRoles_RoleID_CMS_Role");
            });

            modelBuilder.Entity<ForumsForumSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .IsClustered(false);

                entity.ToTable("Forums_ForumSubscription", "dbo");

                entity.HasIndex(e => e.SubscriptionForumId, "IX_Forums_ForumSubscription_SubscriptionForumID");

                entity.HasIndex(e => new { e.SubscriptionEmail, e.SubscriptionForumId }, "IX_Forums_ForumSubscription_SubscriptionForumID_SubscriptionEmail")
                    .IsClustered();

                entity.HasIndex(e => e.SubscriptionPostId, "IX_Forums_ForumSubscription_SubscriptionPostID");

                entity.HasIndex(e => e.SubscriptionUserId, "IX_Forums_ForumSubscription_SubscriptionUserID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.SubscriptionApprovalHash).HasMaxLength(100);

                entity.Property(e => e.SubscriptionEmail).HasMaxLength(254);

                entity.Property(e => e.SubscriptionForumId).HasColumnName("SubscriptionForumID");

                entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");

                entity.Property(e => e.SubscriptionPostId).HasColumnName("SubscriptionPostID");

                entity.Property(e => e.SubscriptionUserId).HasColumnName("SubscriptionUserID");

                entity.HasOne(d => d.SubscriptionForum)
                    .WithMany(p => p.ForumsForumSubscriptions)
                    .HasForeignKey(d => d.SubscriptionForumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_ForumSubscription_SubscriptionForumID_Forums_Forum");

                entity.HasOne(d => d.SubscriptionPost)
                    .WithMany(p => p.ForumsForumSubscriptions)
                    .HasForeignKey(d => d.SubscriptionPostId)
                    .HasConstraintName("FK_Forums_ForumSubscription_SubscriptionPostID_Forums_ForumPost");

                entity.HasOne(d => d.SubscriptionUser)
                    .WithMany(p => p.ForumsForumSubscriptions)
                    .HasForeignKey(d => d.SubscriptionUserId)
                    .HasConstraintName("FK_Forums_ForumSubscription_SubscriptionUserID_CMS_User");
            });

            modelBuilder.Entity<ForumsUserFavorite>(entity =>
            {
                entity.HasKey(e => e.FavoriteId);

                entity.ToTable("Forums_UserFavorites", "dbo");

                entity.HasIndex(e => e.ForumId, "IX_Forums_UserFavorites_ForumID");

                entity.HasIndex(e => e.PostId, "IX_Forums_UserFavorites_PostID");

                entity.HasIndex(e => e.SiteId, "IX_Forums_UserFavorites_SiteID");

                entity.HasIndex(e => e.UserId, "IX_Forums_UserFavorites_UserID");

                entity.HasIndex(e => new { e.UserId, e.PostId, e.ForumId }, "IX_Forums_UserFavorites_UserID_PostID_ForumID")
                    .IsUnique();

                entity.Property(e => e.FavoriteId).HasColumnName("FavoriteID");

                entity.Property(e => e.FavoriteGuid).HasColumnName("FavoriteGUID");

                entity.Property(e => e.FavoriteLastModified).HasDefaultValueSql("('12/4/2008 3:23:57 PM')");

                entity.Property(e => e.FavoriteName).HasMaxLength(100);

                entity.Property(e => e.ForumId).HasColumnName("ForumID");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Forum)
                    .WithMany(p => p.ForumsUserFavorites)
                    .HasForeignKey(d => d.ForumId)
                    .HasConstraintName("FK_Forums_UserFavorites_ForumID_Forums_Forum");

                entity.HasOne(d => d.Post)
                    .WithMany(p => p.ForumsUserFavorites)
                    .HasForeignKey(d => d.PostId)
                    .HasConstraintName("FK_Forums_UserFavorites_PostID_Forums_ForumPost");

                entity.HasOne(d => d.Site)
                    .WithMany(p => p.ForumsUserFavorites)
                    .HasForeignKey(d => d.SiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_UserFavorites_SiteID_CMS_Site");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ForumsUserFavorites)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Forums_UserFavorites_UserID_CMS_User");
            });

            modelBuilder.Entity<IntegrationConnector>(entity =>
            {
                entity.HasKey(e => e.ConnectorId)
                    .IsClustered(false);

                entity.ToTable("Integration_Connector", "dbo");

                entity.HasIndex(e => e.ConnectorDisplayName, "IX_Integration_Connector_ConnectorDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.ConnectorEnabled, "IX_Integration_Connector_ConnectorEnabled");

                entity.Property(e => e.ConnectorId).HasColumnName("ConnectorID");

                entity.Property(e => e.ConnectorAssemblyName).HasMaxLength(400);

                entity.Property(e => e.ConnectorClassName).HasMaxLength(400);

                entity.Property(e => e.ConnectorDisplayName).HasMaxLength(440);

                entity.Property(e => e.ConnectorEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConnectorName).HasMaxLength(100);
            });

            modelBuilder.Entity<IntegrationSyncLog>(entity =>
            {
                entity.HasKey(e => e.SyncLogId);

                entity.ToTable("Integration_SyncLog", "dbo");

                entity.HasIndex(e => e.SyncLogSynchronizationId, "IX_Integration_SyncLog_SyncLogTaskID");

                entity.Property(e => e.SyncLogId).HasColumnName("SyncLogID");

                entity.Property(e => e.SyncLogSynchronizationId).HasColumnName("SyncLogSynchronizationID");

                entity.HasOne(d => d.SyncLogSynchronization)
                    .WithMany(p => p.IntegrationSyncLogs)
                    .HasForeignKey(d => d.SyncLogSynchronizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Integration_SyncLog_SyncLogSynchronizationID_Integration_Synchronization");
            });

            modelBuilder.Entity<IntegrationSynchronization>(entity =>
            {
                entity.HasKey(e => e.SynchronizationId);

                entity.ToTable("Integration_Synchronization", "dbo");

                entity.HasIndex(e => e.SynchronizationConnectorId, "IX_Integration_Synchronization_SynchronizationConnectorID");

                entity.HasIndex(e => e.SynchronizationTaskId, "IX_Integration_Synchronization_SynchronizationTaskID");

                entity.Property(e => e.SynchronizationId).HasColumnName("SynchronizationID");

                entity.Property(e => e.SynchronizationConnectorId).HasColumnName("SynchronizationConnectorID");

                entity.Property(e => e.SynchronizationTaskId).HasColumnName("SynchronizationTaskID");

                entity.HasOne(d => d.SynchronizationConnector)
                    .WithMany(p => p.IntegrationSynchronizations)
                    .HasForeignKey(d => d.SynchronizationConnectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Integration_Synchronization_SynchronizationConnectorID_Integration_Connector");

                entity.HasOne(d => d.SynchronizationTask)
                    .WithMany(p => p.IntegrationSynchronizations)
                    .HasForeignKey(d => d.SynchronizationTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Integration_Synchronization_SynchronizationTaskID_Integration_Task");
            });

            modelBuilder.Entity<IntegrationTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .IsClustered(false);

                entity.ToTable("Integration_Task", "dbo");

                entity.HasIndex(e => e.TaskIsInbound, "IX_Integration_Task_TaskIsInbound");

                entity.HasIndex(e => e.TaskNodeAliasPath, "IX_Integration_Task_TaskNodeAliasPath")
                    .IsClustered();

                entity.HasIndex(e => e.TaskSiteId, "IX_Integration_Task_TaskSiteID");

                entity.HasIndex(e => e.TaskType, "IX_Integration_Task_TaskType");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskDataType).HasMaxLength(50);

                entity.Property(e => e.TaskDocumentId).HasColumnName("TaskDocumentID");

                entity.Property(e => e.TaskNodeId).HasColumnName("TaskNodeID");

                entity.Property(e => e.TaskObjectId).HasColumnName("TaskObjectID");

                entity.Property(e => e.TaskObjectType).HasMaxLength(100);

                entity.Property(e => e.TaskProcessType).HasMaxLength(50);

                entity.Property(e => e.TaskSiteId).HasColumnName("TaskSiteID");

                entity.Property(e => e.TaskTitle).HasMaxLength(450);

                entity.Property(e => e.TaskType).HasMaxLength(50);

                entity.HasOne(d => d.TaskSite)
                    .WithMany(p => p.IntegrationTasks)
                    .HasForeignKey(d => d.TaskSiteId)
                    .HasConstraintName("FK_IntegrationTask_TaskSiteID_CMS_Site");
            });

            modelBuilder.Entity<IntranetPortalDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("IntranetPortal_Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentDescription).HasMaxLength(450);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.DepartmentRoles).HasMaxLength(100);

                entity.Property(e => e.DepartmentSections).HasMaxLength(450);
            });

            modelBuilder.Entity<IntranetPortalWorkingEnvironment>(entity =>
            {
                entity.HasKey(e => e.WorkingenvironmentId);

                entity.ToTable("IntranetPortal_WorkingEnvironment");

                entity.Property(e => e.WorkingenvironmentId).HasColumnName("workingenvironmentID");

                entity.Property(e => e.FormInserted).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.FormUpdated).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.OfficeSatisfaction)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'Neutral')");

                entity.Property(e => e.YourName).HasMaxLength(200);
            });

            modelBuilder.Entity<MediaFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .IsClustered(false);

                entity.ToTable("Media_File", "dbo");

                entity.HasIndex(e => e.FileCreatedByUserId, "IX_Media_File_FileCreatedByUserID");

                entity.HasIndex(e => e.FileLibraryId, "IX_Media_File_FileLibraryID");

                entity.HasIndex(e => e.FileModifiedByUserId, "IX_Media_File_FileModifiedByUserID");

                entity.HasIndex(e => e.FilePath, "IX_Media_File_FilePath")
                    .IsClustered();

                entity.HasIndex(e => new { e.FileSiteId, e.FileGuid }, "IX_Media_File_FileSiteID_FileGUID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileCreatedByUserId).HasColumnName("FileCreatedByUserID");

                entity.Property(e => e.FileCreatedWhen).HasDefaultValueSql("('11/11/2008 4:10:00 PM')");

                entity.Property(e => e.FileExtension).HasMaxLength(50);

                entity.Property(e => e.FileGuid).HasColumnName("FileGUID");

                entity.Property(e => e.FileLibraryId).HasColumnName("FileLibraryID");

                entity.Property(e => e.FileMimeType).HasMaxLength(100);

                entity.Property(e => e.FileModifiedByUserId).HasColumnName("FileModifiedByUserID");

                entity.Property(e => e.FileModifiedWhen).HasDefaultValueSql("('11/11/2008 4:11:15 PM')");

                entity.Property(e => e.FileName).HasMaxLength(250);

                entity.Property(e => e.FileSiteId).HasColumnName("FileSiteID");

                entity.Property(e => e.FileTitle)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.FileCreatedByUser)
                    .WithMany(p => p.MediaFileFileCreatedByUsers)
                    .HasForeignKey(d => d.FileCreatedByUserId)
                    .HasConstraintName("FK_Media_File_FileCreatedByUserID_CMS_User");

                entity.HasOne(d => d.FileLibrary)
                    .WithMany(p => p.MediaFiles)
                    .HasForeignKey(d => d.FileLibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_File_FileLibraryID_Media_Library");

                entity.HasOne(d => d.FileModifiedByUser)
                    .WithMany(p => p.MediaFileFileModifiedByUsers)
                    .HasForeignKey(d => d.FileModifiedByUserId)
                    .HasConstraintName("FK_Media_File_FileModifiedByUserID_CMS_User");

                entity.HasOne(d => d.FileSite)
                    .WithMany(p => p.MediaFiles)
                    .HasForeignKey(d => d.FileSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_File_FileSiteID_CMS_Site");
            });

            modelBuilder.Entity<MediaLibrary>(entity =>
            {
                entity.HasKey(e => e.LibraryId)
                    .IsClustered(false);

                entity.ToTable("Media_Library", "dbo");

                entity.HasIndex(e => new { e.LibrarySiteId, e.LibraryDisplayName }, "IX_Media_Library_LibraryDisplayName")
                    .IsClustered();

                entity.HasIndex(e => e.LibraryGroupId, "IX_Media_Library_LibraryGroupID");

                entity.HasIndex(e => new { e.LibrarySiteId, e.LibraryName, e.LibraryGuid }, "IX_Media_Library_LibrarySiteID_LibraryName_LibraryGUID")
                    .IsUnique();

                entity.Property(e => e.LibraryId).HasColumnName("LibraryID");

                entity.Property(e => e.LibraryDisplayName).HasMaxLength(250);

                entity.Property(e => e.LibraryFolder).HasMaxLength(250);

                entity.Property(e => e.LibraryGroupId).HasColumnName("LibraryGroupID");

                entity.Property(e => e.LibraryGuid).HasColumnName("LibraryGUID");

                entity.Property(e => e.LibraryName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LibrarySiteId).HasColumnName("LibrarySiteID");

                entity.Property(e => e.LibraryTeaserGuid).HasColumnName("LibraryTeaserGUID");

                entity.Property(e => e.LibraryTeaserPath).HasMaxLength(450);

                entity.HasOne(d => d.LibraryGroup)
                    .WithMany(p => p.MediaLibraries)
                    .HasForeignKey(d => d.LibraryGroupId)
                    .HasConstraintName("FK_Media_Library_LibraryGroupID_Community_Group");

                entity.HasOne(d => d.LibrarySite)
                    .WithMany(p => p.MediaLibraries)
                    .HasForeignKey(d => d.LibrarySiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_Library_LibrarySiteID_CMS_Site");
            });

            modelBuilder.Entity<MediaLibraryRolePermission>(entity =>
            {
                entity.HasKey(e => new { e.LibraryId, e.RoleId, e.PermissionId });

                entity.ToTable("Media_LibraryRolePermission", "dbo");

                entity.HasIndex(e => e.PermissionId, "IX_Media_LibraryRolePermission_PermissionID");

                entity.HasIndex(e => e.RoleId, "IX_Media_LibraryRolePermission_RoleID");

                entity.Property(e => e.LibraryId).HasColumnName("LibraryID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.HasOne(d => d.Library)
                    .WithMany(p => p.MediaLibraryRolePermissions)
                    .HasForeignKey(d => d.LibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_LibraryRolePermission_LibraryID_Media_Library");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.MediaLibraryRolePermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_LibraryRolePermission_PermissionID_CMS_Permission");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MediaLibraryRolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_LibraryRolePermission_RoleID_CMS_Role");
            });

            modelBuilder.Entity<NewsletterAbtest>(entity =>
            {
                entity.HasKey(e => e.TestId);

                entity.ToTable("Newsletter_ABTest", "dbo");

                entity.HasIndex(e => e.TestIssueId, "IX_Newsletter_ABTest_TestIssueID")
                    .IsUnique();

                entity.HasIndex(e => e.TestWinnerIssueId, "IX_Newsletter_ABTest_TestWinnerIssueID");

                entity.HasIndex(e => e.TestWinnerScheduledTaskId, "IX_Newsletter_ABTest_TestWinnerScheduledTaskID");

                entity.Property(e => e.TestId).HasColumnName("TestID");

                entity.Property(e => e.TestGuid).HasColumnName("TestGUID");

                entity.Property(e => e.TestIssueId).HasColumnName("TestIssueID");

                entity.Property(e => e.TestLastModified).HasDefaultValueSql("('12/5/2011 4:56:38 PM')");

                entity.Property(e => e.TestWinnerIssueId).HasColumnName("TestWinnerIssueID");

                entity.Property(e => e.TestWinnerScheduledTaskId).HasColumnName("TestWinnerScheduledTaskID");

                entity.HasOne(d => d.TestIssue)
                    .WithOne(p => p.NewsletterAbtestTestIssue)
                    .HasForeignKey<NewsletterAbtest>(d => d.TestIssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_ABTest_Newsletter_NewsletterIssue");

                entity.HasOne(d => d.TestWinnerIssue)
                    .WithMany(p => p.NewsletterAbtestTestWinnerIssues)
                    .HasForeignKey(d => d.TestWinnerIssueId)
                    .HasConstraintName("FK_Newsletter_ABTest_TestWinnerIssueID_Newsletter_NewsletterIssue");

                entity.HasOne(d => d.TestWinnerScheduledTask)
                    .WithMany(p => p.NewsletterAbtests)
                    .HasForeignKey(d => d.TestWinnerScheduledTaskId)
                    .HasConstraintName("FK_Newsletter_ABTest_TestWinnerScheduledTaskID_CMS_ScheduledTask");
            });

            modelBuilder.Entity<NewsletterClickedLink>(entity =>
            {
                entity.HasKey(e => e.ClickedLinkId);

                entity.ToTable("Newsletter_ClickedLink", "dbo");

                entity.HasIndex(e => e.ClickedLinkNewsletterLinkId, "IX_Newsletter_ClickedLink_ClickedLinkNewsletterLinkID");

                entity.Property(e => e.ClickedLinkId).HasColumnName("ClickedLinkID");

                entity.Property(e => e.ClickedLinkEmail)
                    .HasMaxLength(254)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ClickedLinkNewsletterLinkId).HasColumnName("ClickedLinkNewsletterLinkID");

                entity.HasOne(d => d.ClickedLinkNewsletterLink)
                    .WithMany(p => p.NewsletterClickedLinks)
                    .HasForeignKey(d => d.ClickedLinkNewsletterLinkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_ClickedLink_Newsletter_Link");
            });

            modelBuilder.Entity<NewsletterEmail>(entity =>
            {
                entity.HasKey(e => e.EmailId);

                entity.ToTable("Newsletter_Emails", "dbo");

                entity.HasIndex(e => e.EmailGuid, "IX_Newsletter_Emails_EmailGUID")
                    .IsUnique();

                entity.HasIndex(e => e.EmailNewsletterIssueId, "IX_Newsletter_Emails_EmailNewsletterIssueID");

                entity.HasIndex(e => e.EmailSending, "IX_Newsletter_Emails_EmailSending");

                entity.HasIndex(e => e.EmailSiteId, "IX_Newsletter_Emails_EmailSiteID");

                entity.HasIndex(e => e.EmailSubscriberId, "IX_Newsletter_Emails_EmailSubscriberID");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.EmailAddress).HasMaxLength(254);

                entity.Property(e => e.EmailContactId).HasColumnName("EmailContactID");

                entity.Property(e => e.EmailGuid).HasColumnName("EmailGUID");

                entity.Property(e => e.EmailNewsletterIssueId).HasColumnName("EmailNewsletterIssueID");

                entity.Property(e => e.EmailSiteId).HasColumnName("EmailSiteID");

                entity.Property(e => e.EmailSubscriberId).HasColumnName("EmailSubscriberID");

                entity.HasOne(d => d.EmailNewsletterIssue)
                    .WithMany(p => p.NewsletterEmails)
                    .HasForeignKey(d => d.EmailNewsletterIssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Emails_EmailNewsletterIssueID_Newsletter_NewsletterIssue");

                entity.HasOne(d => d.EmailSite)
                    .WithMany(p => p.NewsletterEmails)
                    .HasForeignKey(d => d.EmailSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Emails_EmailSiteID_CMS_Site");

                entity.HasOne(d => d.EmailSubscriber)
                    .WithMany(p => p.NewsletterEmails)
                    .HasForeignKey(d => d.EmailSubscriberId)
                    .HasConstraintName("FK_Newsletter_Emails_EmailSubscriberID_Newsletter_Subscriber");
            });

            modelBuilder.Entity<NewsletterEmailTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .IsClustered(false);

                entity.ToTable("Newsletter_EmailTemplate", "dbo");

                entity.HasIndex(e => new { e.TemplateSiteId, e.TemplateDisplayName }, "IX_Newsletter_EmailTemplate_TemplateSiteID_TemplateDisplayName")
                    .IsClustered();

                entity.HasIndex(e => new { e.TemplateSiteId, e.TemplateName }, "IX_Newsletter_EmailTemplate_TemplateSiteID_TemplateName")
                    .IsUnique();

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TemplateDisplayName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TemplateGuid).HasColumnName("TemplateGUID");

                entity.Property(e => e.TemplateIconClass)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'icon-accordion')");

                entity.Property(e => e.TemplateInlineCss).HasColumnName("TemplateInlineCSS");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TemplateSiteId).HasColumnName("TemplateSiteID");

                entity.Property(e => e.TemplateSubject).HasMaxLength(450);

                entity.Property(e => e.TemplateThumbnailGuid).HasColumnName("TemplateThumbnailGUID");

                entity.Property(e => e.TemplateType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.TemplateSite)
                    .WithMany(p => p.NewsletterEmailTemplates)
                    .HasForeignKey(d => d.TemplateSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_EmailTemplate_TemplateSiteID_CMS_Site");

                entity.HasMany(d => d.Newsletters)
                    .WithMany(p => p.Templates)
                    .UsingEntity<Dictionary<string, object>>(
                        "NewsletterEmailTemplateNewsletter",
                        l => l.HasOne<NewsletterNewsletter>().WithMany().HasForeignKey("NewsletterId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Newsletter_EmailTemplateNewsletter_Newsletter_Newsletter"),
                        r => r.HasOne<NewsletterEmailTemplate>().WithMany().HasForeignKey("TemplateId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Newsletter_EmailTemplateNewsletter_Newsletter_EmailTemplate"),
                        j =>
                        {
                            j.HasKey("TemplateId", "NewsletterId");

                            j.ToTable("Newsletter_EmailTemplateNewsletter", "dbo");

                            j.HasIndex(new[] { "NewsletterId" }, "IX_Newsletter_EmailTemplateNewsletter_NewsletterID");

                            j.IndexerProperty<int>("TemplateId").HasColumnName("TemplateID");

                            j.IndexerProperty<int>("NewsletterId").HasColumnName("NewsletterID");
                        });
            });

            modelBuilder.Entity<NewsletterEmailWidget>(entity =>
            {
                entity.HasKey(e => e.EmailWidgetId);

                entity.ToTable("Newsletter_EmailWidget", "dbo");

                entity.HasIndex(e => e.EmailWidgetSiteId, "IX_Newsletter_EmailWidget_EmailWidgetSiteID");

                entity.Property(e => e.EmailWidgetId).HasColumnName("EmailWidgetID");

                entity.Property(e => e.EmailWidgetDisplayName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EmailWidgetIconCssClass)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'icon-cogwheel-square')");

                entity.Property(e => e.EmailWidgetLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.EmailWidgetName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.EmailWidgetSiteId).HasColumnName("EmailWidgetSiteID");

                entity.Property(e => e.EmailWidgetThumbnailGuid).HasColumnName("EmailWidgetThumbnailGUID");

                entity.HasOne(d => d.EmailWidgetSite)
                    .WithMany(p => p.NewsletterEmailWidgets)
                    .HasForeignKey(d => d.EmailWidgetSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_EmailWidget_EmailWidgetSiteID_CMS_Site");
            });

            modelBuilder.Entity<NewsletterEmailWidgetTemplate>(entity =>
            {
                entity.HasKey(e => e.EmailWidgetTemplateId);

                entity.ToTable("Newsletter_EmailWidgetTemplate", "dbo");

                entity.HasIndex(e => e.EmailWidgetId, "IX_Newsletter_EmailWidgetTemplate_EmailWidgetID");

                entity.HasIndex(e => e.TemplateId, "IX_Newsletter_EmailWidgetTemplate_TemplateID");

                entity.Property(e => e.EmailWidgetTemplateId).HasColumnName("EmailWidgetTemplateID");

                entity.Property(e => e.EmailWidgetId).HasColumnName("EmailWidgetID");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.HasOne(d => d.EmailWidget)
                    .WithMany(p => p.NewsletterEmailWidgetTemplates)
                    .HasForeignKey(d => d.EmailWidgetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_EmailWidgetTemplate_EmailWidgetID_Newsletter_EmailWidget");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.NewsletterEmailWidgetTemplates)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_EmailWidgetTemplate_TemplateID_Newsletter_EmailTemplate");
            });

            modelBuilder.Entity<NewsletterIssueContactGroup>(entity =>
            {
                entity.HasKey(e => e.IssueContactGroupId);

                entity.ToTable("Newsletter_IssueContactGroup", "dbo");

                entity.HasIndex(e => e.ContactGroupId, "IX_Newsletter_IssueContactGroup_ContactGroupID");

                entity.Property(e => e.IssueContactGroupId).HasColumnName("IssueContactGroupID");

                entity.Property(e => e.ContactGroupId).HasColumnName("ContactGroupID");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.HasOne(d => d.ContactGroup)
                    .WithMany(p => p.NewsletterIssueContactGroups)
                    .HasForeignKey(d => d.ContactGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_IssueContactGroup_ContactGroupID");
            });

            modelBuilder.Entity<NewsletterLink>(entity =>
            {
                entity.HasKey(e => e.LinkId);

                entity.ToTable("Newsletter_Link", "dbo");

                entity.HasIndex(e => e.LinkIssueId, "IX_Newsletter_Link_LinkIssueID");

                entity.Property(e => e.LinkId).HasColumnName("LinkID");

                entity.Property(e => e.LinkDescription).HasMaxLength(450);

                entity.Property(e => e.LinkGuid).HasColumnName("LinkGUID");

                entity.Property(e => e.LinkIssueId).HasColumnName("LinkIssueID");

                entity.HasOne(d => d.LinkIssue)
                    .WithMany(p => p.NewsletterLinks)
                    .HasForeignKey(d => d.LinkIssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Link_Newsletter_NewsletterIssue");
            });

            modelBuilder.Entity<NewsletterNewsletter>(entity =>
            {
                entity.HasKey(e => e.NewsletterId)
                    .IsClustered(false);

                entity.ToTable("Newsletter_Newsletter", "dbo");

                entity.HasIndex(e => e.NewsletterDynamicScheduledTaskId, "IX_Newsletter_Newsletter_NewsletterDynamicScheduledTaskID");

                entity.HasIndex(e => e.NewsletterOptInTemplateId, "IX_Newsletter_Newsletter_NewsletterOptInTemplateID");

                entity.HasIndex(e => new { e.NewsletterSiteId, e.NewsletterDisplayName }, "IX_Newsletter_Newsletter_NewsletterSiteID_NewsletterDisplayName")
                    .IsClustered();

                entity.HasIndex(e => new { e.NewsletterSiteId, e.NewsletterName }, "IX_Newsletter_Newsletter_NewsletterSiteID_NewsletterName")
                    .IsUnique();

                entity.HasIndex(e => e.NewsletterSubscriptionTemplateId, "IX_Newsletter_Newsletter_NewsletterSubscriptionTemplateID");

                entity.HasIndex(e => e.NewsletterUnsubscriptionTemplateId, "IX_Newsletter_Newsletter_NewsletterUnsubscriptionTemplateID");

                entity.Property(e => e.NewsletterId).HasColumnName("NewsletterID");

                entity.Property(e => e.NewsletterBaseUrl).HasMaxLength(500);

                entity.Property(e => e.NewsletterDisplayName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewsletterDraftEmails).HasMaxLength(998);

                entity.Property(e => e.NewsletterDynamicScheduledTaskId).HasColumnName("NewsletterDynamicScheduledTaskID");

                entity.Property(e => e.NewsletterDynamicSubject).HasMaxLength(100);

                entity.Property(e => e.NewsletterDynamicUrl)
                    .HasMaxLength(500)
                    .HasColumnName("NewsletterDynamicURL");

                entity.Property(e => e.NewsletterEnableOptIn).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewsletterGuid).HasColumnName("NewsletterGUID");

                entity.Property(e => e.NewsletterLastModified).HasDefaultValueSql("('3/13/2015 2:53:28 PM')");

                entity.Property(e => e.NewsletterLogActivity).HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsletterName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewsletterOptInApprovalUrl)
                    .HasMaxLength(450)
                    .HasColumnName("NewsletterOptInApprovalURL");

                entity.Property(e => e.NewsletterOptInTemplateId).HasColumnName("NewsletterOptInTemplateID");

                entity.Property(e => e.NewsletterSendOptInConfirmation).HasDefaultValueSql("((0))");

                entity.Property(e => e.NewsletterSenderEmail)
                    .HasMaxLength(254)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NewsletterSenderName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NewsletterSiteId).HasColumnName("NewsletterSiteID");

                entity.Property(e => e.NewsletterSource)
                    .HasMaxLength(5)
                    .HasDefaultValueSql("(N'T')");

                entity.Property(e => e.NewsletterSubscriptionTemplateId).HasColumnName("NewsletterSubscriptionTemplateID");

                entity.Property(e => e.NewsletterTrackClickedLinks).HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsletterTrackOpenEmails).HasDefaultValueSql("((1))");

                entity.Property(e => e.NewsletterUnsubscribeUrl).HasMaxLength(1000);

                entity.Property(e => e.NewsletterUnsubscriptionTemplateId).HasColumnName("NewsletterUnsubscriptionTemplateID");

                entity.HasOne(d => d.NewsletterDynamicScheduledTask)
                    .WithMany(p => p.NewsletterNewsletters)
                    .HasForeignKey(d => d.NewsletterDynamicScheduledTaskId)
                    .HasConstraintName("FK_Newsletter_Newsletter_NewsletterDynamicScheduledTaskID_CMS_ScheduledTask");

                entity.HasOne(d => d.NewsletterOptInTemplate)
                    .WithMany(p => p.NewsletterNewsletterNewsletterOptInTemplates)
                    .HasForeignKey(d => d.NewsletterOptInTemplateId)
                    .HasConstraintName("FK_Newsletter_Newsletter_NewsletterOptInTemplateID_EmailTemplate");

                entity.HasOne(d => d.NewsletterSite)
                    .WithMany(p => p.NewsletterNewsletters)
                    .HasForeignKey(d => d.NewsletterSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Newsletter_NewsletterSiteID_CMS_Site");

                entity.HasOne(d => d.NewsletterUnsubscriptionTemplate)
                    .WithMany(p => p.NewsletterNewsletterNewsletterUnsubscriptionTemplates)
                    .HasForeignKey(d => d.NewsletterUnsubscriptionTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Newsletter_NewsletterUnsubscriptionTemplateID_Newsletter_EmailTemplate");
            });

            modelBuilder.Entity<NewsletterNewsletterIssue>(entity =>
            {
                entity.HasKey(e => e.IssueId);

                entity.ToTable("Newsletter_NewsletterIssue", "dbo");

                entity.HasIndex(e => e.IssueNewsletterId, "IX_Newsletter_NewsletterIssue_IssueNewsletterID");

                entity.HasIndex(e => e.IssueScheduledTaskId, "IX_Newsletter_NewsletterIssue_IssueScheduledTaskID");

                entity.HasIndex(e => e.IssueSiteId, "IX_Newsletter_NewsletterIssue_IssueSiteID");

                entity.HasIndex(e => e.IssueTemplateId, "IX_Newsletter_NewsletterIssue_IssueTemplateID");

                entity.HasIndex(e => e.IssueVariantOfIssueId, "IX_Newsletter_NewsletterIssue_IssueVariantOfIssueID");

                entity.Property(e => e.IssueId).HasColumnName("IssueID");

                entity.Property(e => e.IssueDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.IssueGuid).HasColumnName("IssueGUID");

                entity.Property(e => e.IssueIsAbtest).HasColumnName("IssueIsABTest");

                entity.Property(e => e.IssueNewsletterId).HasColumnName("IssueNewsletterID");

                entity.Property(e => e.IssueScheduledTaskId).HasColumnName("IssueScheduledTaskID");

                entity.Property(e => e.IssueSenderEmail).HasMaxLength(254);

                entity.Property(e => e.IssueSenderName).HasMaxLength(200);

                entity.Property(e => e.IssueSiteId).HasColumnName("IssueSiteID");

                entity.Property(e => e.IssueSubject)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IssueTemplateId).HasColumnName("IssueTemplateID");

                entity.Property(e => e.IssueUseUtm).HasColumnName("IssueUseUTM");

                entity.Property(e => e.IssueUtmcampaign)
                    .HasMaxLength(200)
                    .HasColumnName("IssueUTMCampaign");

                entity.Property(e => e.IssueUtmsource)
                    .HasMaxLength(200)
                    .HasColumnName("IssueUTMSource");

                entity.Property(e => e.IssueVariantName).HasMaxLength(200);

                entity.Property(e => e.IssueVariantOfIssueId).HasColumnName("IssueVariantOfIssueID");

                entity.HasOne(d => d.IssueNewsletter)
                    .WithMany(p => p.NewsletterNewsletterIssues)
                    .HasForeignKey(d => d.IssueNewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_NewsletterIssue_IssueNewsletterID_Newsletter_Newsletter");

                entity.HasOne(d => d.IssueSite)
                    .WithMany(p => p.NewsletterNewsletterIssues)
                    .HasForeignKey(d => d.IssueSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_NewsletterIssue_IssueSiteID_CMS_Site");

                entity.HasOne(d => d.IssueTemplate)
                    .WithMany(p => p.NewsletterNewsletterIssues)
                    .HasForeignKey(d => d.IssueTemplateId)
                    .HasConstraintName("FK_Newsletter_NewsletterIssue_IssueTemplateID_Newsletter_EmailTemplate");

                entity.HasOne(d => d.IssueVariantOfIssue)
                    .WithMany(p => p.InverseIssueVariantOfIssue)
                    .HasForeignKey(d => d.IssueVariantOfIssueId)
                    .HasConstraintName("FK_Newsletter_NewsletterIssue_IssueVariantOfIssue_NewsletterIssue");
            });

            modelBuilder.Entity<NewsletterOpenedEmail>(entity =>
            {
                entity.HasKey(e => e.OpenedEmailId);

                entity.ToTable("Newsletter_OpenedEmail", "dbo");

                entity.HasIndex(e => e.OpenedEmailIssueId, "IX_Newsletter_OpenedEmail_OpenedEmailIssueID");

                entity.Property(e => e.OpenedEmailId).HasColumnName("OpenedEmailID");

                entity.Property(e => e.OpenedEmailEmail)
                    .HasMaxLength(254)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.OpenedEmailIssueId).HasColumnName("OpenedEmailIssueID");

                entity.HasOne(d => d.OpenedEmailIssue)
                    .WithMany(p => p.NewsletterOpenedEmails)
                    .HasForeignKey(d => d.OpenedEmailIssueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_OpenedEmail_OpenedEmailIssueID_Newsletter_NewsletterIssue");
            });

            modelBuilder.Entity<NewsletterSubscriber>(entity =>
            {
                entity.HasKey(e => e.SubscriberId)
                    .IsClustered(false);

                entity.ToTable("Newsletter_Subscriber", "dbo");

                entity.HasIndex(e => e.SubscriberEmail, "IX_Newsletter_Subscriber_SubscriberEmail");

                entity.HasIndex(e => new { e.SubscriberSiteId, e.SubscriberFullName }, "IX_Newsletter_Subscriber_SubscriberSiteID_SubscriberFullName")
                    .IsClustered();

                entity.HasIndex(e => new { e.SubscriberType, e.SubscriberRelatedId }, "IX_Newsletter_Subscriber_SubscriberType_SubscriberRelatedID");

                entity.Property(e => e.SubscriberId).HasColumnName("SubscriberID");

                entity.Property(e => e.SubscriberEmail).HasMaxLength(254);

                entity.Property(e => e.SubscriberFirstName).HasMaxLength(200);

                entity.Property(e => e.SubscriberFullName).HasMaxLength(440);

                entity.Property(e => e.SubscriberGuid).HasColumnName("SubscriberGUID");

                entity.Property(e => e.SubscriberLastName).HasMaxLength(200);

                entity.Property(e => e.SubscriberRelatedId).HasColumnName("SubscriberRelatedID");

                entity.Property(e => e.SubscriberSiteId).HasColumnName("SubscriberSiteID");

                entity.Property(e => e.SubscriberType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.SubscriberSite)
                    .WithMany(p => p.NewsletterSubscribers)
                    .HasForeignKey(d => d.SubscriberSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_Subscriber_SubscriberSiteID_CMS_Site");
            });

            modelBuilder.Entity<NewsletterSubscriberNewsletter>(entity =>
            {
                entity.HasKey(e => e.SubscriberNewsletterId);

                entity.ToTable("Newsletter_SubscriberNewsletter", "dbo");

                entity.HasIndex(e => new { e.NewsletterId, e.SubscriptionApproved }, "IX_Newsletter_SubscriberNewsletter_NewsletterID_SubscriptionApproved");

                entity.HasIndex(e => new { e.SubscriberId, e.NewsletterId }, "UQ_Newsletter_SubscriberNewsletter")
                    .IsUnique();

                entity.Property(e => e.SubscriberNewsletterId).HasColumnName("SubscriberNewsletterID");

                entity.Property(e => e.NewsletterId).HasColumnName("NewsletterID");

                entity.Property(e => e.SubscriberId).HasColumnName("SubscriberID");

                entity.Property(e => e.SubscriptionApprovalHash).HasMaxLength(100);

                entity.Property(e => e.SubscriptionApproved).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Newsletter)
                    .WithMany(p => p.NewsletterSubscriberNewsletters)
                    .HasForeignKey(d => d.NewsletterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_SubscriberNewsletter_NewsletterID_Newsletter_Newsletter");

                entity.HasOne(d => d.Subscriber)
                    .WithMany(p => p.NewsletterSubscriberNewsletters)
                    .HasForeignKey(d => d.SubscriberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Newsletter_SubscriberNewsletter_SubscriberID_Newsletter_Subscriber");
            });

            modelBuilder.Entity<NewsletterUnsubscription>(entity =>
            {
                entity.HasKey(e => e.UnsubscriptionId);

                entity.ToTable("Newsletter_Unsubscription", "dbo");

                entity.HasIndex(e => new { e.UnsubscriptionEmail, e.UnsubscriptionNewsletterId }, "IX_Newsletter_Unsubscription_Email_NewsletterID");

                entity.HasIndex(e => e.UnsubscriptionNewsletterId, "IX_Newsletter_Unsubscription_NewsletterID");

                entity.HasIndex(e => e.UnsubscriptionFromIssueId, "IX_Newsletter_Unsubscription_UnsubscriptionFromIssueID");

                entity.Property(e => e.UnsubscriptionId).HasColumnName("UnsubscriptionID");

                entity.Property(e => e.UnsubscriptionEmail)
                    .HasMaxLength(254)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UnsubscriptionFromIssueId).HasColumnName("UnsubscriptionFromIssueID");

                entity.Property(e => e.UnsubscriptionGuid).HasColumnName("UnsubscriptionGUID");

                entity.Property(e => e.UnsubscriptionNewsletterId).HasColumnName("UnsubscriptionNewsletterID");

                entity.HasOne(d => d.UnsubscriptionFromIssue)
                    .WithMany(p => p.NewsletterUnsubscriptions)
                    .HasForeignKey(d => d.UnsubscriptionFromIssueId)
                    .HasConstraintName("FK_Newsletter_Unsubscription_UnsubscriptionFromIssueID_Newsletter_NewsletterIssue");

                entity.HasOne(d => d.UnsubscriptionNewsletter)
                    .WithMany(p => p.NewsletterUnsubscriptions)
                    .HasForeignKey(d => d.UnsubscriptionNewsletterId)
                    .HasConstraintName("FK_Newsletter_Unsubscription_UnsubscriptionNewsletterID_Newsletter_Newsletter");
            });

            modelBuilder.Entity<NotificationGateway>(entity =>
            {
                entity.HasKey(e => e.GatewayId)
                    .IsClustered(false);

                entity.ToTable("Notification_Gateway", "dbo");

                entity.HasIndex(e => e.GatewayDisplayName, "IX_Notification_Gateway_GatewayDisplayName")
                    .IsClustered();

                entity.Property(e => e.GatewayId).HasColumnName("GatewayID");

                entity.Property(e => e.GatewayAssemblyName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GatewayClassName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GatewayDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GatewayEnabled).HasDefaultValueSql("((0))");

                entity.Property(e => e.GatewayGuid).HasColumnName("GatewayGUID");

                entity.Property(e => e.GatewayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GatewaySupportsEmail).HasDefaultValueSql("((0))");

                entity.Property(e => e.GatewaySupportsHtmltext)
                    .HasColumnName("GatewaySupportsHTMLText")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GatewaySupportsPlainText).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NotificationSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.ToTable("Notification_Subscription", "dbo");

                entity.HasIndex(e => new { e.SubscriptionEventSource, e.SubscriptionEventCode, e.SubscriptionEventObjectId }, "IX_Notification_Subscription_SubscriptionEventSource_SubscriptionEventCode_SubscriptionEventObjectID");

                entity.HasIndex(e => e.SubscriptionGatewayId, "IX_Notification_Subscription_SubscriptionGatewayID");

                entity.HasIndex(e => e.SubscriptionSiteId, "IX_Notification_Subscription_SubscriptionSiteID");

                entity.HasIndex(e => e.SubscriptionTemplateId, "IX_Notification_Subscription_SubscriptionTemplateID");

                entity.HasIndex(e => e.SubscriptionUserId, "IX_Notification_Subscription_SubscriptionUserID");

                entity.Property(e => e.SubscriptionId).HasColumnName("SubscriptionID");

                entity.Property(e => e.SubscriptionEventCode).HasMaxLength(100);

                entity.Property(e => e.SubscriptionEventDisplayName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubscriptionEventObjectId).HasColumnName("SubscriptionEventObjectID");

                entity.Property(e => e.SubscriptionEventSource).HasMaxLength(100);

                entity.Property(e => e.SubscriptionGatewayId).HasColumnName("SubscriptionGatewayID");

                entity.Property(e => e.SubscriptionGuid).HasColumnName("SubscriptionGUID");

                entity.Property(e => e.SubscriptionSiteId)
                    .HasColumnName("SubscriptionSiteID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubscriptionTarget).HasMaxLength(250);

                entity.Property(e => e.SubscriptionTemplateId).HasColumnName("SubscriptionTemplateID");

                entity.Property(e => e.SubscriptionUseHtml)
                    .HasColumnName("SubscriptionUseHTML")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SubscriptionUserId).HasColumnName("SubscriptionUserID");

                entity.HasOne(d => d.SubscriptionGateway)
                    .WithMany(p => p.NotificationSubscriptions)
                    .HasForeignKey(d => d.SubscriptionGatewayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_Subscription_SubscriptionGatewayID_Notification_Gateway");

                entity.HasOne(d => d.SubscriptionSite)
                    .WithMany(p => p.NotificationSubscriptions)
                    .HasForeignKey(d => d.SubscriptionSiteId)
                    .HasConstraintName("FK_Notification_Subscription_SubscriptionSiteID_CMS_Site");

                entity.HasOne(d => d.SubscriptionTemplate)
                    .WithMany(p => p.NotificationSubscriptions)
                    .HasForeignKey(d => d.SubscriptionTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_Subscription_SubscriptionTemplateID_Notification_Template");

                entity.HasOne(d => d.SubscriptionUser)
                    .WithMany(p => p.NotificationSubscriptions)
                    .HasForeignKey(d => d.SubscriptionUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_Subscription_SubscriptionUserID_CMS_User");
            });

            modelBuilder.Entity<NotificationTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .IsClustered(false);

                entity.ToTable("Notification_Template", "dbo");

                entity.HasIndex(e => e.TemplateSiteId, "IX_Notification_Template_TemplateSiteID");

                entity.HasIndex(e => new { e.TemplateSiteId, e.TemplateDisplayName }, "IX_Notification_Template_TemplateSiteID_TemplateDisplayName")
                    .IsClustered();

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TemplateDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TemplateGuid).HasColumnName("TemplateGUID");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TemplateSiteId).HasColumnName("TemplateSiteID");

                entity.HasOne(d => d.TemplateSite)
                    .WithMany(p => p.NotificationTemplates)
                    .HasForeignKey(d => d.TemplateSiteId)
                    .HasConstraintName("FK_Notification_Template_TemplateSiteID_CMS_Site");
            });

            modelBuilder.Entity<NotificationTemplateText>(entity =>
            {
                entity.HasKey(e => e.TemplateTextId);

                entity.ToTable("Notification_TemplateText", "dbo");

                entity.HasIndex(e => e.GatewayId, "IX_Notification_TemplateText_GatewayID");

                entity.HasIndex(e => e.TemplateId, "IX_Notification_TemplateText_TemplateID");

                entity.Property(e => e.TemplateTextId).HasColumnName("TemplateTextID");

                entity.Property(e => e.GatewayId).HasColumnName("GatewayID");

                entity.Property(e => e.TemplateHtmltext).HasColumnName("TemplateHTMLText");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.TemplateSubject).HasMaxLength(250);

                entity.Property(e => e.TemplateTextGuid).HasColumnName("TemplateTextGUID");

                entity.HasOne(d => d.Gateway)
                    .WithMany(p => p.NotificationTemplateTexts)
                    .HasForeignKey(d => d.GatewayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_TemplateText_GatewayID_Notification_Gateway");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.NotificationTemplateTexts)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_TemplateText_TemplateID_Notification_Template");
            });

            modelBuilder.Entity<NtmtnSocial>(entity =>
            {
                entity.HasKey(e => e.SocialId);

                entity.ToTable("ntmtn_social");

                entity.Property(e => e.SocialId).HasColumnName("SocialID");

                entity.Property(e => e.Class)
                    .HasMaxLength(200)
                    .HasColumnName("class");

                entity.Property(e => e.SocialLink)
                    .HasMaxLength(500)
                    .HasColumnName("socialLink");

                entity.Property(e => e.SocialName)
                    .HasMaxLength(50)
                    .HasColumnName("socialName")
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<OmAbtest>(entity =>
            {
                entity.HasKey(e => e.AbtestId);

                entity.ToTable("OM_ABTest", "dbo");

                entity.HasIndex(e => e.AbtestSiteId, "IX_OM_ABTest_SiteID");

                entity.Property(e => e.AbtestId).HasColumnName("ABTestID");

                entity.Property(e => e.AbtestConversions).HasColumnName("ABTestConversions");

                entity.Property(e => e.AbtestCulture)
                    .HasMaxLength(50)
                    .HasColumnName("ABTestCulture");

                entity.Property(e => e.AbtestDescription).HasColumnName("ABTestDescription");

                entity.Property(e => e.AbtestDisplayName)
                    .HasMaxLength(100)
                    .HasColumnName("ABTestDisplayName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AbtestGuid).HasColumnName("ABTestGUID");

                entity.Property(e => e.AbtestIncludedTraffic)
                    .HasColumnName("ABTestIncludedTraffic")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.AbtestLastModified).HasColumnName("ABTestLastModified");

                entity.Property(e => e.AbtestName)
                    .HasMaxLength(50)
                    .HasColumnName("ABTestName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AbtestOpenFrom).HasColumnName("ABTestOpenFrom");

                entity.Property(e => e.AbtestOpenTo).HasColumnName("ABTestOpenTo");

                entity.Property(e => e.AbtestOriginalPage)
                    .HasMaxLength(450)
                    .HasColumnName("ABTestOriginalPage")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AbtestSiteId).HasColumnName("ABTestSiteID");

                entity.Property(e => e.AbtestVisitorTargeting).HasColumnName("ABTestVisitorTargeting");

                entity.Property(e => e.AbtestWinnerGuid).HasColumnName("ABTestWinnerGUID");

                entity.HasOne(d => d.AbtestSite)
                    .WithMany(p => p.OmAbtests)
                    .HasForeignKey(d => d.AbtestSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_ABTest_SiteID_CMS_Site");
            });

            modelBuilder.Entity<OmAbvariant>(entity =>
            {
                entity.HasKey(e => e.AbvariantId);

                entity.ToTable("OM_ABVariant", "dbo");

                entity.HasIndex(e => e.AbvariantSiteId, "IX_OM_ABVariant_ABVariantSiteID");

                entity.HasIndex(e => e.AbvariantTestId, "IX_OM_ABVariant_ABVariantTestID");

                entity.Property(e => e.AbvariantId).HasColumnName("ABVariantID");

                entity.Property(e => e.AbvariantDisplayName)
                    .HasMaxLength(110)
                    .HasColumnName("ABVariantDisplayName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AbvariantGuid).HasColumnName("ABVariantGUID");

                entity.Property(e => e.AbvariantLastModified).HasColumnName("ABVariantLastModified");

                entity.Property(e => e.AbvariantName)
                    .HasMaxLength(50)
                    .HasColumnName("ABVariantName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AbvariantPath)
                    .HasMaxLength(450)
                    .HasColumnName("ABVariantPath");

                entity.Property(e => e.AbvariantSiteId).HasColumnName("ABVariantSiteID");

                entity.Property(e => e.AbvariantTestId).HasColumnName("ABVariantTestID");

                entity.HasOne(d => d.AbvariantSite)
                    .WithMany(p => p.OmAbvariants)
                    .HasForeignKey(d => d.AbvariantSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_ABVariant_CMS_Site");

                entity.HasOne(d => d.AbvariantTest)
                    .WithMany(p => p.OmAbvariants)
                    .HasForeignKey(d => d.AbvariantTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_ABVariant_ABVariantTestID_OM_ABTest");
            });

            modelBuilder.Entity<OmAbvariantDatum>(entity =>
            {
                entity.HasKey(e => e.AbvariantId);

                entity.ToTable("OM_ABVariantData", "dbo");

                entity.HasIndex(e => new { e.AbvariantTestId, e.AbvariantGuid }, "IX_OM_ABVariantData_ABVariantTestID_ABVariantGUID");

                entity.Property(e => e.AbvariantId).HasColumnName("ABVariantID");

                entity.Property(e => e.AbvariantDisplayName)
                    .HasMaxLength(100)
                    .HasColumnName("ABVariantDisplayName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.AbvariantGuid).HasColumnName("ABVariantGUID");

                entity.Property(e => e.AbvariantIsOriginal).HasColumnName("ABVariantIsOriginal");

                entity.Property(e => e.AbvariantTestId).HasColumnName("ABVariantTestID");

                entity.HasOne(d => d.AbvariantTest)
                    .WithMany(p => p.OmAbvariantData)
                    .HasForeignKey(d => d.AbvariantTestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_ABVariantData_ABVariantTestID_OM_ABTest");
            });

            modelBuilder.Entity<OmAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("OM_Account", "dbo");

                entity.HasIndex(e => e.AccountCountryId, "IX_OM_Account_AccountCountryID");

                entity.HasIndex(e => e.AccountOwnerUserId, "IX_OM_Account_AccountOwnerUserID");

                entity.HasIndex(e => e.AccountPrimaryContactId, "IX_OM_Account_AccountPrimaryContactID");

                entity.HasIndex(e => e.AccountSecondaryContactId, "IX_OM_Account_AccountSecondaryContactID");

                entity.HasIndex(e => e.AccountStateId, "IX_OM_Account_AccountStateID");

                entity.HasIndex(e => e.AccountStatusId, "IX_OM_Account_AccountStatusID");

                entity.HasIndex(e => e.AccountSubsidiaryOfId, "IX_OM_Account_AccountSubsidiaryOfID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountAddress1).HasMaxLength(100);

                entity.Property(e => e.AccountAddress2).HasMaxLength(100);

                entity.Property(e => e.AccountCity).HasMaxLength(100);

                entity.Property(e => e.AccountCountryId).HasColumnName("AccountCountryID");

                entity.Property(e => e.AccountEmail).HasMaxLength(254);

                entity.Property(e => e.AccountFax).HasMaxLength(26);

                entity.Property(e => e.AccountGuid).HasColumnName("AccountGUID");

                entity.Property(e => e.AccountName).HasMaxLength(200);

                entity.Property(e => e.AccountOwnerUserId).HasColumnName("AccountOwnerUserID");

                entity.Property(e => e.AccountPhone).HasMaxLength(26);

                entity.Property(e => e.AccountPrimaryContactId).HasColumnName("AccountPrimaryContactID");

                entity.Property(e => e.AccountSecondaryContactId).HasColumnName("AccountSecondaryContactID");

                entity.Property(e => e.AccountStateId).HasColumnName("AccountStateID");

                entity.Property(e => e.AccountStatusId).HasColumnName("AccountStatusID");

                entity.Property(e => e.AccountSubsidiaryOfId).HasColumnName("AccountSubsidiaryOfID");

                entity.Property(e => e.AccountWebSite).HasMaxLength(200);

                entity.Property(e => e.AccountZip)
                    .HasMaxLength(20)
                    .HasColumnName("AccountZIP");

                entity.HasOne(d => d.AccountCountry)
                    .WithMany(p => p.OmAccounts)
                    .HasForeignKey(d => d.AccountCountryId)
                    .HasConstraintName("FK_OM_Account_CMS_Country");

                entity.HasOne(d => d.AccountOwnerUser)
                    .WithMany(p => p.OmAccounts)
                    .HasForeignKey(d => d.AccountOwnerUserId)
                    .HasConstraintName("FK_OM_Account_CMS_User");

                entity.HasOne(d => d.AccountPrimaryContact)
                    .WithMany(p => p.OmAccountAccountPrimaryContacts)
                    .HasForeignKey(d => d.AccountPrimaryContactId)
                    .HasConstraintName("FK_OM_Account_OM_Contact_PrimaryContact");

                entity.HasOne(d => d.AccountSecondaryContact)
                    .WithMany(p => p.OmAccountAccountSecondaryContacts)
                    .HasForeignKey(d => d.AccountSecondaryContactId)
                    .HasConstraintName("FK_OM_Account_OM_Contact_SecondaryContact");

                entity.HasOne(d => d.AccountState)
                    .WithMany(p => p.OmAccounts)
                    .HasForeignKey(d => d.AccountStateId)
                    .HasConstraintName("FK_OM_Account_CMS_State");

                entity.HasOne(d => d.AccountStatus)
                    .WithMany(p => p.OmAccounts)
                    .HasForeignKey(d => d.AccountStatusId)
                    .HasConstraintName("FK_OM_Account_OM_AccountStatus");

                entity.HasOne(d => d.AccountSubsidiaryOf)
                    .WithMany(p => p.InverseAccountSubsidiaryOf)
                    .HasForeignKey(d => d.AccountSubsidiaryOfId)
                    .HasConstraintName("FK_OM_Account_OM_Account_SubsidiaryOf");
            });

            modelBuilder.Entity<OmAccountContact>(entity =>
            {
                entity.HasKey(e => e.AccountContactId);

                entity.ToTable("OM_AccountContact", "dbo");

                entity.HasIndex(e => e.AccountId, "IX_OM_AccountContact_AccountID");

                entity.HasIndex(e => e.ContactId, "IX_OM_AccountContact_ContactID");

                entity.HasIndex(e => e.ContactRoleId, "IX_OM_AccountContact_ContactRoleID");

                entity.Property(e => e.AccountContactId).HasColumnName("AccountContactID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactRoleId).HasColumnName("ContactRoleID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.OmAccountContacts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_AccountContact_OM_Account");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.OmAccountContacts)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_AccountContact_OM_Contact");

                entity.HasOne(d => d.ContactRole)
                    .WithMany(p => p.OmAccountContacts)
                    .HasForeignKey(d => d.ContactRoleId)
                    .HasConstraintName("FK_OM_AccountContact_OM_ContactRole");
            });

            modelBuilder.Entity<OmAccountStatus>(entity =>
            {
                entity.HasKey(e => e.AccountStatusId);

                entity.ToTable("OM_AccountStatus", "dbo");

                entity.Property(e => e.AccountStatusId).HasColumnName("AccountStatusID");

                entity.Property(e => e.AccountStatusDisplayName).HasMaxLength(200);

                entity.Property(e => e.AccountStatusName).HasMaxLength(200);
            });

            modelBuilder.Entity<OmActivity>(entity =>
            {
                entity.HasKey(e => e.ActivityId);

                entity.ToTable("OM_Activity", "dbo");

                entity.HasIndex(e => e.ActivityCampaign, "IX_OM_Activity_ActivityCampaign")
                    .HasFilter("([ActivityCampaign] IS NOT NULL)")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ActivityContactId, "IX_OM_Activity_ActivityContactID");

                entity.HasIndex(e => e.ActivityCreated, "IX_OM_Activity_ActivityCreated");

                entity.HasIndex(e => e.ActivityItemDetailId, "IX_OM_Activity_ActivityItemDetailID");

                entity.HasIndex(e => e.ActivitySiteId, "IX_OM_Activity_ActivitySiteID");

                entity.HasIndex(e => new { e.ActivityType, e.ActivityItemId, e.ActivityNodeId }, "IX_OM_Activity_ActivityType_ActivityItemID_ActivityNodeID_ActivityUTMSource_ActivityUTMContent_ActivityCampaign");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.ActivityAbvariantName)
                    .HasMaxLength(200)
                    .HasColumnName("ActivityABVariantName");

                entity.Property(e => e.ActivityCampaign).HasMaxLength(200);

                entity.Property(e => e.ActivityContactId).HasColumnName("ActivityContactID");

                entity.Property(e => e.ActivityCulture).HasMaxLength(10);

                entity.Property(e => e.ActivityItemDetailId).HasColumnName("ActivityItemDetailID");

                entity.Property(e => e.ActivityItemId).HasColumnName("ActivityItemID");

                entity.Property(e => e.ActivityMvtcombinationName)
                    .HasMaxLength(200)
                    .HasColumnName("ActivityMVTCombinationName");

                entity.Property(e => e.ActivityNodeId).HasColumnName("ActivityNodeID");

                entity.Property(e => e.ActivitySiteId).HasColumnName("ActivitySiteID");

                entity.Property(e => e.ActivityTitle).HasMaxLength(250);

                entity.Property(e => e.ActivityType).HasMaxLength(250);

                entity.Property(e => e.ActivityUrl).HasColumnName("ActivityURL");

                entity.Property(e => e.ActivityUrlhash).HasColumnName("ActivityURLHash");

                entity.Property(e => e.ActivityUrlreferrer).HasColumnName("ActivityURLReferrer");

                entity.Property(e => e.ActivityUtmcontent)
                    .HasMaxLength(200)
                    .HasColumnName("ActivityUTMContent");

                entity.Property(e => e.ActivityUtmsource)
                    .HasMaxLength(200)
                    .HasColumnName("ActivityUTMSource");

                entity.Property(e => e.ActivityValue).HasMaxLength(250);
            });

            modelBuilder.Entity<OmActivityRecalculationQueue>(entity =>
            {
                entity.HasKey(e => e.ActivityRecalculationQueueId);

                entity.ToTable("OM_ActivityRecalculationQueue", "dbo");

                entity.Property(e => e.ActivityRecalculationQueueId).HasColumnName("ActivityRecalculationQueueID");

                entity.Property(e => e.ActivityRecalculationQueueActivityId).HasColumnName("ActivityRecalculationQueueActivityID");
            });

            modelBuilder.Entity<OmActivityType>(entity =>
            {
                entity.HasKey(e => e.ActivityTypeId);

                entity.ToTable("OM_ActivityType", "dbo");

                entity.Property(e => e.ActivityTypeId).HasColumnName("ActivityTypeID");

                entity.Property(e => e.ActivityTypeColor).HasMaxLength(7);

                entity.Property(e => e.ActivityTypeDetailFormControl).HasMaxLength(200);

                entity.Property(e => e.ActivityTypeDisplayName).HasMaxLength(250);

                entity.Property(e => e.ActivityTypeEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActivityTypeIsCustom).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActivityTypeMainFormControl).HasMaxLength(200);

                entity.Property(e => e.ActivityTypeName).HasMaxLength(250);
            });

            modelBuilder.Entity<OmContact>(entity =>
            {
                entity.HasKey(e => e.ContactId);

                entity.ToTable("OM_Contact", "dbo");

                entity.HasIndex(e => e.ContactCountryId, "IX_OM_Contact_ContactCountryID");

                entity.HasIndex(e => e.ContactEmail, "IX_OM_Contact_ContactEmail");

                entity.HasIndex(e => e.ContactGuid, "IX_OM_Contact_ContactGUID")
                    .IsUnique();

                entity.HasIndex(e => e.ContactLastName, "IX_OM_Contact_ContactLastName");

                entity.HasIndex(e => e.ContactOwnerUserId, "IX_OM_Contact_ContactOwnerUserID");

                entity.HasIndex(e => new { e.ContactPersonaId, e.ContactLastName }, "IX_OM_Contact_ContactPersonaID_ContactLastName");

                entity.HasIndex(e => e.ContactStateId, "IX_OM_Contact_ContactStateID");

                entity.HasIndex(e => e.ContactStatusId, "IX_OM_Contact_ContactStatusID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactAddress1).HasMaxLength(100);

                entity.Property(e => e.ContactBusinessPhone).HasMaxLength(26);

                entity.Property(e => e.ContactCampaign).HasMaxLength(200);

                entity.Property(e => e.ContactCity).HasMaxLength(100);

                entity.Property(e => e.ContactCompanyName).HasMaxLength(100);

                entity.Property(e => e.ContactCountryId).HasColumnName("ContactCountryID");

                entity.Property(e => e.ContactCreated).HasDefaultValueSql("('5/3/2011 10:51:13 AM')");

                entity.Property(e => e.ContactEmail).HasMaxLength(254);

                entity.Property(e => e.ContactFirstName).HasMaxLength(100);

                entity.Property(e => e.ContactGuid).HasColumnName("ContactGUID");

                entity.Property(e => e.ContactJobTitle).HasMaxLength(50);

                entity.Property(e => e.ContactLastName).HasMaxLength(100);

                entity.Property(e => e.ContactMiddleName).HasMaxLength(100);

                entity.Property(e => e.ContactMobilePhone).HasMaxLength(26);

                entity.Property(e => e.ContactMonitored).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactOwnerUserId).HasColumnName("ContactOwnerUserID");

                entity.Property(e => e.ContactPersonaId).HasColumnName("ContactPersonaID");

                entity.Property(e => e.ContactSalesForceLeadId)
                    .HasMaxLength(18)
                    .HasColumnName("ContactSalesForceLeadID");

                entity.Property(e => e.ContactSalesForceLeadReplicationDisabled).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactSalesForceLeadReplicationRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactStateId).HasColumnName("ContactStateID");

                entity.Property(e => e.ContactStatusId).HasColumnName("ContactStatusID");

                entity.Property(e => e.ContactZip)
                    .HasMaxLength(100)
                    .HasColumnName("ContactZIP");

                entity.HasOne(d => d.ContactCountry)
                    .WithMany(p => p.OmContacts)
                    .HasForeignKey(d => d.ContactCountryId)
                    .HasConstraintName("FK_OM_Contact_CMS_Country");

                entity.HasOne(d => d.ContactOwnerUser)
                    .WithMany(p => p.OmContacts)
                    .HasForeignKey(d => d.ContactOwnerUserId)
                    .HasConstraintName("FK_OM_Contact_CMS_User");

                entity.HasOne(d => d.ContactState)
                    .WithMany(p => p.OmContacts)
                    .HasForeignKey(d => d.ContactStateId)
                    .HasConstraintName("FK_OM_Contact_CMS_State");

                entity.HasOne(d => d.ContactStatus)
                    .WithMany(p => p.OmContacts)
                    .HasForeignKey(d => d.ContactStatusId)
                    .HasConstraintName("FK_OM_Contact_OM_ContactStatus");
            });

            modelBuilder.Entity<OmContactChangeRecalculationQueue>(entity =>
            {
                entity.HasKey(e => e.ContactChangeRecalculationQueueId);

                entity.ToTable("OM_ContactChangeRecalculationQueue", "dbo");

                entity.Property(e => e.ContactChangeRecalculationQueueId).HasColumnName("ContactChangeRecalculationQueueID");

                entity.Property(e => e.ContactChangeRecalculationQueueContactId).HasColumnName("ContactChangeRecalculationQueueContactID");
            });

            modelBuilder.Entity<OmContactGroup>(entity =>
            {
                entity.HasKey(e => e.ContactGroupId)
                    .HasName("PK_CMS_ContactGroup");

                entity.ToTable("OM_ContactGroup", "dbo");

                entity.Property(e => e.ContactGroupId).HasColumnName("ContactGroupID");

                entity.Property(e => e.ContactGroupDisplayName).HasMaxLength(200);

                entity.Property(e => e.ContactGroupGuid).HasColumnName("ContactGroupGUID");

                entity.Property(e => e.ContactGroupName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<OmContactGroupMember>(entity =>
            {
                entity.HasKey(e => e.ContactGroupMemberId);

                entity.ToTable("OM_ContactGroupMember", "dbo");

                entity.HasIndex(e => new { e.ContactGroupMemberContactGroupId, e.ContactGroupMemberType }, "IX_OM_ContactGroupMember_ContactGroupID_Type_MemberID_RelatedID_FromCondition_FromAccount_FromManual");

                entity.HasIndex(e => new { e.ContactGroupMemberContactGroupId, e.ContactGroupMemberType, e.ContactGroupMemberRelatedId }, "IX_OM_ContactGroupMember_ContactGroupID_Type_RelatedID")
                    .IsUnique();

                entity.HasIndex(e => e.ContactGroupMemberRelatedId, "IX_OM_ContactGroupMember_ContactGroupMemberRelatedID");

                entity.Property(e => e.ContactGroupMemberId).HasColumnName("ContactGroupMemberID");

                entity.Property(e => e.ContactGroupMemberContactGroupId).HasColumnName("ContactGroupMemberContactGroupID");

                entity.Property(e => e.ContactGroupMemberFromCondition).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactGroupMemberFromManual).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactGroupMemberRelatedId).HasColumnName("ContactGroupMemberRelatedID");

                entity.HasOne(d => d.ContactGroupMemberContactGroup)
                    .WithMany(p => p.OmContactGroupMembers)
                    .HasForeignKey(d => d.ContactGroupMemberContactGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_ContactGroupMembers_OM_ContactGroup");
            });

            modelBuilder.Entity<OmContactRole>(entity =>
            {
                entity.HasKey(e => e.ContactRoleId);

                entity.ToTable("OM_ContactRole", "dbo");

                entity.Property(e => e.ContactRoleId).HasColumnName("ContactRoleID");

                entity.Property(e => e.ContactRoleDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactRoleName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<OmContactStatus>(entity =>
            {
                entity.HasKey(e => e.ContactStatusId);

                entity.ToTable("OM_ContactStatus", "dbo");

                entity.Property(e => e.ContactStatusId).HasColumnName("ContactStatusID");

                entity.Property(e => e.ContactStatusDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContactStatusName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<OmMembership>(entity =>
            {
                entity.HasKey(e => e.MembershipId);

                entity.ToTable("OM_Membership", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_OM_Membership_ContactID");

                entity.HasIndex(e => e.RelatedId, "IX_OM_Membership_RelatedID");

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.MembershipGuid).HasColumnName("MembershipGUID");

                entity.Property(e => e.RelatedId).HasColumnName("RelatedID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.OmMemberships)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_Membership_OM_Contact");
            });

            modelBuilder.Entity<OmMvtcombination>(entity =>
            {
                entity.HasKey(e => e.MvtcombinationId);

                entity.ToTable("OM_MVTCombination", "dbo");

                entity.HasIndex(e => e.MvtcombinationPageTemplateId, "IX_OM_MVTCombination_MVTCombinationPageTemplateID");

                entity.Property(e => e.MvtcombinationId).HasColumnName("MVTCombinationID");

                entity.Property(e => e.MvtcombinationConversions).HasColumnName("MVTCombinationConversions");

                entity.Property(e => e.MvtcombinationCustomName)
                    .HasMaxLength(200)
                    .HasColumnName("MVTCombinationCustomName");

                entity.Property(e => e.MvtcombinationDocumentId).HasColumnName("MVTCombinationDocumentID");

                entity.Property(e => e.MvtcombinationEnabled).HasColumnName("MVTCombinationEnabled");

                entity.Property(e => e.MvtcombinationGuid).HasColumnName("MVTCombinationGUID");

                entity.Property(e => e.MvtcombinationIsDefault)
                    .HasColumnName("MVTCombinationIsDefault")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MvtcombinationLastModified).HasColumnName("MVTCombinationLastModified");

                entity.Property(e => e.MvtcombinationName)
                    .HasMaxLength(200)
                    .HasColumnName("MVTCombinationName");

                entity.Property(e => e.MvtcombinationPageTemplateId).HasColumnName("MVTCombinationPageTemplateID");

                entity.HasMany(d => d.Mvtvariants)
                    .WithMany(p => p.Mvtcombinations)
                    .UsingEntity<Dictionary<string, object>>(
                        "OmMvtcombinationVariation",
                        l => l.HasOne<OmMvtvariant>().WithMany().HasForeignKey("MvtvariantId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_OM_MVTCombinationVariation_OM_MVTVariant"),
                        r => r.HasOne<OmMvtcombination>().WithMany().HasForeignKey("MvtcombinationId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_OM_MVTCombinationVariation_OM_MVTCombination"),
                        j =>
                        {
                            j.HasKey("MvtcombinationId", "MvtvariantId");

                            j.ToTable("OM_MVTCombinationVariation", "dbo");

                            j.HasIndex(new[] { "MvtvariantId" }, "IX_OM_MVTCombinationVariation_MVTVariantID");

                            j.IndexerProperty<int>("MvtcombinationId").HasColumnName("MVTCombinationID");

                            j.IndexerProperty<int>("MvtvariantId").HasColumnName("MVTVariantID");
                        });
            });

            modelBuilder.Entity<OmMvtest>(entity =>
            {
                entity.HasKey(e => e.MvtestId);

                entity.ToTable("OM_MVTest", "dbo");

                entity.HasIndex(e => e.MvtestSiteId, "IX_OM_MVTest_MVTestSiteID");

                entity.Property(e => e.MvtestId).HasColumnName("MVTestID");

                entity.Property(e => e.MvtestConversions).HasColumnName("MVTestConversions");

                entity.Property(e => e.MvtestCulture)
                    .HasMaxLength(50)
                    .HasColumnName("MVTestCulture");

                entity.Property(e => e.MvtestDescription).HasColumnName("MVTestDescription");

                entity.Property(e => e.MvtestDisplayName)
                    .HasMaxLength(100)
                    .HasColumnName("MVTestDisplayName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MvtestEnabled).HasColumnName("MVTestEnabled");

                entity.Property(e => e.MvtestGuid).HasColumnName("MVTestGUID");

                entity.Property(e => e.MvtestLastModified).HasColumnName("MVTestLastModified");

                entity.Property(e => e.MvtestMaxConversions).HasColumnName("MVTestMaxConversions");

                entity.Property(e => e.MvtestName)
                    .HasMaxLength(50)
                    .HasColumnName("MVTestName")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MvtestOpenFrom).HasColumnName("MVTestOpenFrom");

                entity.Property(e => e.MvtestOpenTo).HasColumnName("MVTestOpenTo");

                entity.Property(e => e.MvtestPage)
                    .HasMaxLength(450)
                    .HasColumnName("MVTestPage")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MvtestSiteId).HasColumnName("MVTestSiteID");

                entity.Property(e => e.MvtestTargetConversionType)
                    .HasMaxLength(100)
                    .HasColumnName("MVTestTargetConversionType")
                    .HasDefaultValueSql("('TOTAL')");

                entity.HasOne(d => d.MvtestSite)
                    .WithMany(p => p.OmMvtests)
                    .HasForeignKey(d => d.MvtestSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_MVTest_MVTestSiteID_CMS_Site");
            });

            modelBuilder.Entity<OmMvtvariant>(entity =>
            {
                entity.HasKey(e => e.MvtvariantId);

                entity.ToTable("OM_MVTVariant", "dbo");

                entity.HasIndex(e => e.MvtvariantPageTemplateId, "IX_OM_MVTVariant_MVTVariantPageTemplateID");

                entity.Property(e => e.MvtvariantId).HasColumnName("MVTVariantID");

                entity.Property(e => e.MvtvariantDescription).HasColumnName("MVTVariantDescription");

                entity.Property(e => e.MvtvariantDisplayName)
                    .HasMaxLength(200)
                    .HasColumnName("MVTVariantDisplayName");

                entity.Property(e => e.MvtvariantDocumentId).HasColumnName("MVTVariantDocumentID");

                entity.Property(e => e.MvtvariantEnabled)
                    .IsRequired()
                    .HasColumnName("MVTVariantEnabled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MvtvariantGuid).HasColumnName("MVTVariantGUID");

                entity.Property(e => e.MvtvariantInstanceGuid).HasColumnName("MVTVariantInstanceGUID");

                entity.Property(e => e.MvtvariantLastModified).HasColumnName("MVTVariantLastModified");

                entity.Property(e => e.MvtvariantName)
                    .HasMaxLength(100)
                    .HasColumnName("MVTVariantName")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.MvtvariantPageTemplateId).HasColumnName("MVTVariantPageTemplateID");

                entity.Property(e => e.MvtvariantWebParts).HasColumnName("MVTVariantWebParts");

                entity.Property(e => e.MvtvariantZoneId)
                    .HasMaxLength(200)
                    .HasColumnName("MVTVariantZoneID");

                entity.HasOne(d => d.MvtvariantPageTemplate)
                    .WithMany(p => p.OmMvtvariants)
                    .HasForeignKey(d => d.MvtvariantPageTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_MVTVariant_MVTVariantPageTemplateID_CMS_PageTemplate");
            });

            modelBuilder.Entity<OmPersonalizationVariant>(entity =>
            {
                entity.HasKey(e => e.VariantId);

                entity.ToTable("OM_PersonalizationVariant", "dbo");

                entity.HasIndex(e => e.VariantPageTemplateId, "IX_OM_PersonalizationVariant_VariantDocumentID");

                entity.HasIndex(e => e.VariantDocumentId, "IX_OM_PersonalizationVariant_VariantPageTemplateID");

                entity.Property(e => e.VariantId).HasColumnName("VariantID");

                entity.Property(e => e.VariantDisplayCondition).HasDefaultValueSql("('')");

                entity.Property(e => e.VariantDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VariantDocumentId).HasColumnName("VariantDocumentID");

                entity.Property(e => e.VariantEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.VariantGuid).HasColumnName("VariantGUID");

                entity.Property(e => e.VariantInstanceGuid).HasColumnName("VariantInstanceGUID");

                entity.Property(e => e.VariantName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VariantPageTemplateId).HasColumnName("VariantPageTemplateID");

                entity.Property(e => e.VariantZoneId)
                    .HasMaxLength(200)
                    .HasColumnName("VariantZoneID");

                entity.HasOne(d => d.VariantDocument)
                    .WithMany(p => p.OmPersonalizationVariants)
                    .HasForeignKey(d => d.VariantDocumentId)
                    .HasConstraintName("FK_OM_PersonalizationVariant_VariantDocumentID_CMS_Document");

                entity.HasOne(d => d.VariantPageTemplate)
                    .WithMany(p => p.OmPersonalizationVariants)
                    .HasForeignKey(d => d.VariantPageTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_PersonalizationVariant_VariantPageTemplateID_CMS_PageTemplate");
            });

            modelBuilder.Entity<OmRule>(entity =>
            {
                entity.HasKey(e => e.RuleId);

                entity.ToTable("OM_Rule", "dbo");

                entity.HasIndex(e => e.RuleScoreId, "IX_OM_Rule_RuleScoreID");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.RuleDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.RuleGuid).HasColumnName("RuleGUID");

                entity.Property(e => e.RuleName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'[_][_]AUTO[_][_]')");

                entity.Property(e => e.RuleParameter).HasMaxLength(250);

                entity.Property(e => e.RuleScoreId).HasColumnName("RuleScoreID");

                entity.Property(e => e.RuleType).HasDefaultValueSql("((1))");

                entity.Property(e => e.RuleValidity).HasMaxLength(50);

                entity.HasOne(d => d.RuleScore)
                    .WithMany(p => p.OmRules)
                    .HasForeignKey(d => d.RuleScoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_Rule_OM_Score");
            });

            modelBuilder.Entity<OmScore>(entity =>
            {
                entity.HasKey(e => e.ScoreId);

                entity.ToTable("OM_Score", "dbo");

                entity.Property(e => e.ScoreId).HasColumnName("ScoreID");

                entity.Property(e => e.ScoreDisplayName).HasMaxLength(200);

                entity.Property(e => e.ScoreGuid).HasColumnName("ScoreGUID");

                entity.Property(e => e.ScoreName).HasMaxLength(200);

                entity.Property(e => e.ScoreNotificationEmail).HasMaxLength(998);

                entity.Property(e => e.ScoreScheduledTaskId).HasColumnName("ScoreScheduledTaskID");
            });

            modelBuilder.Entity<OmScoreContactRule>(entity =>
            {
                entity.HasKey(e => e.ScoreContactRuleId);

                entity.ToTable("OM_ScoreContactRule", "dbo");

                entity.HasIndex(e => e.ContactId, "IX_OM_ScoreContactRule_ContactID");

                entity.HasIndex(e => e.RuleId, "IX_OM_ScoreContactRule_RuleID");

                entity.HasIndex(e => e.ScoreId, "IX_OM_ScoreContactRule_ScoreID_ContactID_Value_Expiration");

                entity.HasIndex(e => new { e.ScoreId, e.ContactId, e.RuleId }, "UQ_OM_ScoreContactRule")
                    .IsUnique();

                entity.Property(e => e.ScoreContactRuleId).HasColumnName("ScoreContactRuleID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.ScoreId).HasColumnName("ScoreID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.OmScoreContactRules)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_ScoreContactRule_OM_Contact");

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.OmScoreContactRules)
                    .HasForeignKey(d => d.RuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_ScoreContactRule_OM_Rule");

                entity.HasOne(d => d.Score)
                    .WithMany(p => p.OmScoreContactRules)
                    .HasForeignKey(d => d.ScoreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_ScoreContactRule_OM_Score");
            });

            modelBuilder.Entity<OmVisitorToContact>(entity =>
            {
                entity.HasKey(e => e.VisitorToContactId);

                entity.ToTable("OM_VisitorToContact", "dbo");

                entity.HasIndex(e => e.VisitorToContactContactId, "IX_OM_VisitorToContact_VisitorToContactContactID");

                entity.HasIndex(e => e.VisitorToContactVisitorGuid, "IX_OM_VisitorToContact_VisitorToContactVisitorGUID")
                    .IsUnique();

                entity.Property(e => e.VisitorToContactId).HasColumnName("VisitorToContactID");

                entity.Property(e => e.VisitorToContactContactId).HasColumnName("VisitorToContactContactID");

                entity.Property(e => e.VisitorToContactVisitorGuid).HasColumnName("VisitorToContactVisitorGUID");

                entity.HasOne(d => d.VisitorToContactContact)
                    .WithMany(p => p.OmVisitorToContacts)
                    .HasForeignKey(d => d.VisitorToContactContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OM_VisitorToContact_OM_Contact_Cascade");
            });

            modelBuilder.Entity<OnlineTeacherLink>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Online_TeacherLink");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Book).HasDefaultValueSql("(N'')");

                entity.Property(e => e.DocName)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

                entity.Property(e => e.Name)
                    .HasMaxLength(250)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SessionNo).HasColumnName("sessionNo");

                entity.Property(e => e.Url)
                    .HasMaxLength(1024)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<OnlineTermTable>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Online_TermTable");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.DayOf)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

                entity.Property(e => e.Level)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NewProgram).HasMaxLength(1024);

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TimOf)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PageBookCalssRecord>(entity =>
            {
                entity.HasKey(e => e.BookCalssRecordId);

                entity.ToTable("Page_BookCalssRecord");

                entity.Property(e => e.BookCalssRecordId).HasColumnName("BookCalssRecordID");

                entity.Property(e => e.RecordUrl).HasDefaultValueSql("(N'')");

                entity.Property(e => e.SessionNo).HasMaxLength(200);

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<PageBookPageType>(entity =>
            {
                entity.HasKey(e => e.BookPageTypeId);

                entity.ToTable("Page_BookPageType");

                entity.Property(e => e.BookPageTypeId).HasColumnName("BookPageTypeID");

                entity.Property(e => e.BookName)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BookType).HasMaxLength(200);
            });

            modelBuilder.Entity<PersonasPersona>(entity =>
            {
                entity.HasKey(e => e.PersonaId);

                entity.ToTable("Personas_Persona", "dbo");

                entity.HasIndex(e => e.PersonaScoreId, "IX_Personas_Persona_PersonaScoreID");

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.PersonaDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PersonaEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PersonaGuid).HasColumnName("PersonaGUID");

                entity.Property(e => e.PersonaName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'[_][_]AUTO[_][_]')");

                entity.Property(e => e.PersonaPictureMetafileGuid).HasColumnName("PersonaPictureMetafileGUID");

                entity.Property(e => e.PersonaPointsThreshold).HasDefaultValueSql("((100))");

                entity.Property(e => e.PersonaScoreId).HasColumnName("PersonaScoreID");
            });

            modelBuilder.Entity<PersonasPersonaContactHistory>(entity =>
            {
                entity.HasKey(e => e.PersonaContactHistoryId);

                entity.ToTable("Personas_PersonaContactHistory", "dbo");

                entity.HasIndex(e => e.PersonaContactHistoryPersonaId, "IX_Personas_PersonaContactHistoryPersonaID");

                entity.Property(e => e.PersonaContactHistoryId).HasColumnName("PersonaContactHistoryID");

                entity.Property(e => e.PersonaContactHistoryDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.PersonaContactHistoryPersonaId).HasColumnName("PersonaContactHistoryPersonaID");

                entity.HasOne(d => d.PersonaContactHistoryPersona)
                    .WithMany(p => p.PersonasPersonaContactHistories)
                    .HasForeignKey(d => d.PersonaContactHistoryPersonaId)
                    .HasConstraintName("FK_Personas_PersonaContactHistory_Personas_Persona");
            });

            modelBuilder.Entity<PersonasPersonaNode>(entity =>
            {
                entity.HasKey(e => new { e.PersonaId, e.NodeId });

                entity.ToTable("Personas_PersonaNode", "dbo");

                entity.HasIndex(e => e.NodeId, "IX_Personas_PersonaNode_NodeID");

                entity.HasIndex(e => e.PersonaId, "IX_Personas_PersonaNode_PersonaID");

                entity.Property(e => e.PersonaId).HasColumnName("PersonaID");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.HasOne(d => d.Node)
                    .WithMany(p => p.PersonasPersonaNodes)
                    .HasForeignKey(d => d.NodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personas_PersonaNode_CMS_Tree");
            });

            modelBuilder.Entity<PollsPoll>(entity =>
            {
                entity.HasKey(e => e.PollId)
                    .IsClustered(false);

                entity.ToTable("Polls_Poll", "dbo");

                entity.HasIndex(e => e.PollGroupId, "IX_Polls_Poll_PollGroupID");

                entity.HasIndex(e => new { e.PollSiteId, e.PollCodeName }, "IX_Polls_Poll_PollSiteID_PollCodeName");

                entity.HasIndex(e => new { e.PollSiteId, e.PollDisplayName }, "IX_Polls_Poll_PollSiteID_PollDisplayName")
                    .IsClustered();

                entity.Property(e => e.PollId).HasColumnName("PollID");

                entity.Property(e => e.PollCodeName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PollDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PollGroupId).HasColumnName("PollGroupID");

                entity.Property(e => e.PollGuid).HasColumnName("PollGUID");

                entity.Property(e => e.PollQuestion)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PollResponseMessage)
                    .HasMaxLength(450)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.PollSiteId).HasColumnName("PollSiteID");

                entity.Property(e => e.PollTitle)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.PollGroup)
                    .WithMany(p => p.PollsPolls)
                    .HasForeignKey(d => d.PollGroupId)
                    .HasConstraintName("FK_Polls_Poll_PollGroupID_Community_Group");

                entity.HasOne(d => d.PollSite)
                    .WithMany(p => p.PollsPolls)
                    .HasForeignKey(d => d.PollSiteId)
                    .HasConstraintName("FK_Polls_Poll_PollSiteID_CMS_Site");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Polls)
                    .UsingEntity<Dictionary<string, object>>(
                        "PollsPollRole",
                        l => l.HasOne<CmsRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Polls_PollRoles_RoleID_CMS_Role"),
                        r => r.HasOne<PollsPoll>().WithMany().HasForeignKey("PollId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Polls_PollRoles_PollID_Polls_Poll"),
                        j =>
                        {
                            j.HasKey("PollId", "RoleId");

                            j.ToTable("Polls_PollRoles", "dbo");

                            j.HasIndex(new[] { "RoleId" }, "IX_Polls_PollRoles_RoleID");

                            j.IndexerProperty<int>("PollId").HasColumnName("PollID");

                            j.IndexerProperty<int>("RoleId").HasColumnName("RoleID");
                        });

                entity.HasMany(d => d.Sites)
                    .WithMany(p => p.Polls)
                    .UsingEntity<Dictionary<string, object>>(
                        "PollsPollSite",
                        l => l.HasOne<CmsSite>().WithMany().HasForeignKey("SiteId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Polls_PollSite_SiteID_CMS_Site"),
                        r => r.HasOne<PollsPoll>().WithMany().HasForeignKey("PollId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Polls_PollSite_PollID_Polls_Poll"),
                        j =>
                        {
                            j.HasKey("PollId", "SiteId");

                            j.ToTable("Polls_PollSite", "dbo");

                            j.HasIndex(new[] { "SiteId" }, "IX_Polls_PollSite_SiteID");

                            j.IndexerProperty<int>("PollId").HasColumnName("PollID");

                            j.IndexerProperty<int>("SiteId").HasColumnName("SiteID");
                        });
            });

            modelBuilder.Entity<PollsPollAnswer>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .IsClustered(false);

                entity.ToTable("Polls_PollAnswer", "dbo");

                entity.HasIndex(e => e.AnswerPollId, "IX_Polls_PollAnswer_AnswerPollID");

                entity.HasIndex(e => new { e.AnswerOrder, e.AnswerPollId, e.AnswerEnabled }, "IX_Polls_PollAnswer_AnswerPollID_AnswerOrder_AnswerEnabled")
                    .IsClustered();

                entity.Property(e => e.AnswerId).HasColumnName("AnswerID");

                entity.Property(e => e.AnswerAlternativeForm).HasMaxLength(100);

                entity.Property(e => e.AnswerForm).HasMaxLength(100);

                entity.Property(e => e.AnswerGuid).HasColumnName("AnswerGUID");

                entity.Property(e => e.AnswerHideForm).HasDefaultValueSql("((0))");

                entity.Property(e => e.AnswerPollId).HasColumnName("AnswerPollID");

                entity.Property(e => e.AnswerText)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.HasOne(d => d.AnswerPoll)
                    .WithMany(p => p.PollsPollAnswers)
                    .HasForeignKey(d => d.AnswerPollId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Polls_PollAnswer_AnswerPollID_Polls_Poll");
            });

            modelBuilder.Entity<ReportingReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .IsClustered(false);

                entity.ToTable("Reporting_Report", "dbo");

                entity.HasIndex(e => e.ReportCategoryId, "IX_Reporting_Report_ReportCategoryID");

                entity.HasIndex(e => new { e.ReportDisplayName, e.ReportCategoryId }, "IX_Reporting_Report_ReportCategoryID_ReportDisplayName")
                    .IsClustered();

                entity.HasIndex(e => new { e.ReportGuid, e.ReportName }, "IX_Reporting_Report_ReportGUID_ReportName");

                entity.HasIndex(e => e.ReportName, "IX_Reporting_Report_ReportName")
                    .IsUnique();

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ReportAccess).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportCategoryId).HasColumnName("ReportCategoryID");

                entity.Property(e => e.ReportConnectionString).HasMaxLength(100);

                entity.Property(e => e.ReportDisplayName)
                    .HasMaxLength(440)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportEnableSubscription).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReportGuid).HasColumnName("ReportGUID");

                entity.Property(e => e.ReportName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.ReportCategory)
                    .WithMany(p => p.ReportingReports)
                    .HasForeignKey(d => d.ReportCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporting_Report_ReportCategoryID_Reporting_ReportCategory");
            });

            modelBuilder.Entity<ReportingReportCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .IsClustered(false);

                entity.ToTable("Reporting_ReportCategory", "dbo");

                entity.HasIndex(e => e.CategoryParentId, "IX_Reporting_ReportCategory_CategoryParentID");

                entity.HasIndex(e => e.CategoryPath, "IX_Reporting_ReportCategory_CategoryPath")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryCodeName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.CategoryParentId).HasColumnName("CategoryParentID");

                entity.Property(e => e.CategoryPath).HasDefaultValueSql("('')");

                entity.HasOne(d => d.CategoryParent)
                    .WithMany(p => p.InverseCategoryParent)
                    .HasForeignKey(d => d.CategoryParentId)
                    .HasConstraintName("FK_Reporting_ReportCategory_CategoryID_Reporting_ReportCategory_ParentCategoryID");
            });

            modelBuilder.Entity<ReportingReportGraph>(entity =>
            {
                entity.HasKey(e => e.GraphId);

                entity.ToTable("Reporting_ReportGraph", "dbo");

                entity.HasIndex(e => e.GraphGuid, "IX_Reporting_ReportGraph_GraphGUID")
                    .IsUnique();

                entity.HasIndex(e => new { e.GraphReportId, e.GraphName }, "IX_Reporting_ReportGraph_GraphReportID_GraphName")
                    .IsUnique();

                entity.Property(e => e.GraphId).HasColumnName("GraphID");

                entity.Property(e => e.GraphConnectionString).HasMaxLength(100);

                entity.Property(e => e.GraphDisplayName).HasMaxLength(450);

                entity.Property(e => e.GraphGuid).HasColumnName("GraphGUID");

                entity.Property(e => e.GraphName).HasMaxLength(100);

                entity.Property(e => e.GraphReportId).HasColumnName("GraphReportID");

                entity.Property(e => e.GraphTitle).HasMaxLength(200);

                entity.Property(e => e.GraphType).HasMaxLength(50);

                entity.Property(e => e.GraphXaxisTitle)
                    .HasMaxLength(200)
                    .HasColumnName("GraphXAxisTitle");

                entity.Property(e => e.GraphYaxisTitle)
                    .HasMaxLength(200)
                    .HasColumnName("GraphYAxisTitle");

                entity.HasOne(d => d.GraphReport)
                    .WithMany(p => p.ReportingReportGraphs)
                    .HasForeignKey(d => d.GraphReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporting_ReportGraph_GraphReportID_Reporting_Report");
            });

            modelBuilder.Entity<ReportingReportSubscription>(entity =>
            {
                entity.HasKey(e => e.ReportSubscriptionId);

                entity.ToTable("Reporting_ReportSubscription", "dbo");

                entity.HasIndex(e => e.ReportSubscriptionGraphId, "IX_Reporting_ReportSubscription_ReportSubscriptionGraphID");

                entity.HasIndex(e => e.ReportSubscriptionReportId, "IX_Reporting_ReportSubscription_ReportSubscriptionReportID");

                entity.HasIndex(e => e.ReportSubscriptionSiteId, "IX_Reporting_ReportSubscription_ReportSubscriptionSiteID");

                entity.HasIndex(e => e.ReportSubscriptionTableId, "IX_Reporting_ReportSubscription_ReportSubscriptionTableID");

                entity.HasIndex(e => e.ReportSubscriptionUserId, "IX_Reporting_ReportSubscription_ReportSubscriptionUserID");

                entity.HasIndex(e => e.ReportSubscriptionValueId, "IX_Reporting_ReportSubscription_ReportSubscriptionValueID");

                entity.Property(e => e.ReportSubscriptionId).HasColumnName("ReportSubscriptionID");

                entity.Property(e => e.ReportSubscriptionEmail).HasMaxLength(400);

                entity.Property(e => e.ReportSubscriptionEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportSubscriptionGraphId).HasColumnName("ReportSubscriptionGraphID");

                entity.Property(e => e.ReportSubscriptionGuid).HasColumnName("ReportSubscriptionGUID");

                entity.Property(e => e.ReportSubscriptionInterval)
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ReportSubscriptionLastModified).HasDefaultValueSql("('3/9/2012 11:17:19 AM')");

                entity.Property(e => e.ReportSubscriptionOnlyNonEmpty)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportSubscriptionReportId).HasColumnName("ReportSubscriptionReportID");

                entity.Property(e => e.ReportSubscriptionSiteId).HasColumnName("ReportSubscriptionSiteID");

                entity.Property(e => e.ReportSubscriptionSubject).HasMaxLength(200);

                entity.Property(e => e.ReportSubscriptionTableId).HasColumnName("ReportSubscriptionTableID");

                entity.Property(e => e.ReportSubscriptionUserId).HasColumnName("ReportSubscriptionUserID");

                entity.Property(e => e.ReportSubscriptionValueId).HasColumnName("ReportSubscriptionValueID");

                entity.HasOne(d => d.ReportSubscriptionGraph)
                    .WithMany(p => p.ReportingReportSubscriptions)
                    .HasForeignKey(d => d.ReportSubscriptionGraphId)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionGraphID_Reporting_ReportGraph");

                entity.HasOne(d => d.ReportSubscriptionReport)
                    .WithMany(p => p.ReportingReportSubscriptions)
                    .HasForeignKey(d => d.ReportSubscriptionReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionReportID_Reporting_Report");

                entity.HasOne(d => d.ReportSubscriptionSite)
                    .WithMany(p => p.ReportingReportSubscriptions)
                    .HasForeignKey(d => d.ReportSubscriptionSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionSiteID_CMS_Site");

                entity.HasOne(d => d.ReportSubscriptionTable)
                    .WithMany(p => p.ReportingReportSubscriptions)
                    .HasForeignKey(d => d.ReportSubscriptionTableId)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionTableID_Reporting_ReportTable");

                entity.HasOne(d => d.ReportSubscriptionUser)
                    .WithMany(p => p.ReportingReportSubscriptions)
                    .HasForeignKey(d => d.ReportSubscriptionUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionUserID_CMS_User");

                entity.HasOne(d => d.ReportSubscriptionValue)
                    .WithMany(p => p.ReportingReportSubscriptions)
                    .HasForeignKey(d => d.ReportSubscriptionValueId)
                    .HasConstraintName("FK_Reporting_ReportSubscription_ReportSubscriptionValueID_Reporting_ReportValue");
            });

            modelBuilder.Entity<ReportingReportTable>(entity =>
            {
                entity.HasKey(e => e.TableId);

                entity.ToTable("Reporting_ReportTable", "dbo");

                entity.HasIndex(e => e.TableReportId, "IX_Reporting_ReportTable_TableReportID");

                entity.HasIndex(e => new { e.TableName, e.TableReportId }, "IX_Reporting_ReportTable_TableReportID_TableName")
                    .IsUnique();

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.Property(e => e.TableConnectionString).HasMaxLength(100);

                entity.Property(e => e.TableDisplayName).HasMaxLength(450);

                entity.Property(e => e.TableGuid).HasColumnName("TableGUID");

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.Property(e => e.TableReportId).HasColumnName("TableReportID");

                entity.HasOne(d => d.TableReport)
                    .WithMany(p => p.ReportingReportTables)
                    .HasForeignKey(d => d.TableReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporting_ReportTable_TableReportID_Reporting_Report");
            });

            modelBuilder.Entity<ReportingReportValue>(entity =>
            {
                entity.HasKey(e => e.ValueId);

                entity.ToTable("Reporting_ReportValue", "dbo");

                entity.HasIndex(e => new { e.ValueName, e.ValueReportId }, "IX_Reporting_ReportValue_ValueName_ValueReportID");

                entity.HasIndex(e => e.ValueReportId, "IX_Reporting_ReportValue_ValueReportID");

                entity.Property(e => e.ValueId).HasColumnName("ValueID");

                entity.Property(e => e.ValueConnectionString).HasMaxLength(100);

                entity.Property(e => e.ValueDisplayName).HasMaxLength(450);

                entity.Property(e => e.ValueFormatString).HasMaxLength(200);

                entity.Property(e => e.ValueGuid).HasColumnName("ValueGUID");

                entity.Property(e => e.ValueName).HasMaxLength(100);

                entity.Property(e => e.ValueReportId).HasColumnName("ValueReportID");

                entity.HasOne(d => d.ValueReport)
                    .WithMany(p => p.ReportingReportValues)
                    .HasForeignKey(d => d.ValueReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporting_ReportValue_ValueReportID_Reporting_Report");
            });

            modelBuilder.Entity<ReportingSavedGraph>(entity =>
            {
                entity.HasKey(e => e.SavedGraphId);

                entity.ToTable("Reporting_SavedGraph", "dbo");

                entity.HasIndex(e => e.SavedGraphGuid, "IX_Reporting_SavedGraph_SavedGraphGUID");

                entity.HasIndex(e => e.SavedGraphSavedReportId, "IX_Reporting_SavedGraph_SavedGraphSavedReportID");

                entity.Property(e => e.SavedGraphId).HasColumnName("SavedGraphID");

                entity.Property(e => e.SavedGraphGuid).HasColumnName("SavedGraphGUID");

                entity.Property(e => e.SavedGraphMimeType).HasMaxLength(100);

                entity.Property(e => e.SavedGraphSavedReportId).HasColumnName("SavedGraphSavedReportID");

                entity.HasOne(d => d.SavedGraphSavedReport)
                    .WithMany(p => p.ReportingSavedGraphs)
                    .HasForeignKey(d => d.SavedGraphSavedReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporting_SavedGraph_SavedGraphSavedReportID_Reporting_SavedReport");
            });

            modelBuilder.Entity<ReportingSavedReport>(entity =>
            {
                entity.HasKey(e => e.SavedReportId)
                    .IsClustered(false);

                entity.ToTable("Reporting_SavedReport", "dbo");

                entity.HasIndex(e => e.SavedReportCreatedByUserId, "IX_Reporting_SavedReport_SavedReportCreatedByUserID");

                entity.HasIndex(e => new { e.SavedReportReportId, e.SavedReportDate }, "IX_Reporting_SavedReport_SavedReportReportID_SavedReportDate")
                    .IsClustered();

                entity.Property(e => e.SavedReportId).HasColumnName("SavedReportID");

                entity.Property(e => e.SavedReportCreatedByUserId).HasColumnName("SavedReportCreatedByUserID");

                entity.Property(e => e.SavedReportGuid).HasColumnName("SavedReportGUID");

                entity.Property(e => e.SavedReportHtml).HasColumnName("SavedReportHTML");

                entity.Property(e => e.SavedReportReportId).HasColumnName("SavedReportReportID");

                entity.Property(e => e.SavedReportTitle).HasMaxLength(200);

                entity.HasOne(d => d.SavedReportCreatedByUser)
                    .WithMany(p => p.ReportingSavedReports)
                    .HasForeignKey(d => d.SavedReportCreatedByUserId)
                    .HasConstraintName("FK_Reporting_SavedReport_SavedReportCreatedByUserID_CMS_User");

                entity.HasOne(d => d.SavedReportReport)
                    .WithMany(p => p.ReportingSavedReports)
                    .HasForeignKey(d => d.SavedReportReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reporting_SavedReport_SavedReportReportID_Reporting_Report");
            });

            modelBuilder.Entity<SharePointSharePointConnection>(entity =>
            {
                entity.HasKey(e => e.SharePointConnectionId);

                entity.ToTable("SharePoint_SharePointConnection", "dbo");

                entity.HasIndex(e => e.SharePointConnectionSiteId, "IX_SharePoint_SharePointConnection_SharePointConnectionSiteID");

                entity.Property(e => e.SharePointConnectionId).HasColumnName("SharePointConnectionID");

                entity.Property(e => e.SharePointConnectionAuthMode)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'default')");

                entity.Property(e => e.SharePointConnectionDisplayName).HasMaxLength(100);

                entity.Property(e => e.SharePointConnectionDomain).HasMaxLength(100);

                entity.Property(e => e.SharePointConnectionGuid).HasColumnName("SharePointConnectionGUID");

                entity.Property(e => e.SharePointConnectionName).HasMaxLength(100);

                entity.Property(e => e.SharePointConnectionPassword).HasMaxLength(100);

                entity.Property(e => e.SharePointConnectionSharePointVersion)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("(N'sp2010')");

                entity.Property(e => e.SharePointConnectionSiteId).HasColumnName("SharePointConnectionSiteID");

                entity.Property(e => e.SharePointConnectionSiteUrl).HasMaxLength(512);

                entity.Property(e => e.SharePointConnectionUserName).HasMaxLength(100);

                entity.HasOne(d => d.SharePointConnectionSite)
                    .WithMany(p => p.SharePointSharePointConnections)
                    .HasForeignKey(d => d.SharePointConnectionSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SharePoint_SharePointConnection_CMS_Site");
            });

            modelBuilder.Entity<SharePointSharePointFile>(entity =>
            {
                entity.HasKey(e => e.SharePointFileId);

                entity.ToTable("SharePoint_SharePointFile", "dbo");

                entity.HasIndex(e => e.SharePointFileSiteId, "IX_SharePoint_SharePointFile_SharePointFileSiteID");

                entity.HasIndex(e => new { e.SharePointFileSharePointLibraryId, e.SharePointFileServerRelativeUrl }, "UQ_SharePoint_SharePointFile_LibraryID_ServerRelativeURL")
                    .IsUnique();

                entity.Property(e => e.SharePointFileId).HasColumnName("SharePointFileID");

                entity.Property(e => e.SharePointFileEtag)
                    .HasMaxLength(255)
                    .HasColumnName("SharePointFileETag")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SharePointFileExtension)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SharePointFileGuid).HasColumnName("SharePointFileGUID");

                entity.Property(e => e.SharePointFileMimeType)
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SharePointFileName)
                    .HasMaxLength(150)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SharePointFileServerRelativeUrl)
                    .HasMaxLength(300)
                    .HasColumnName("SharePointFileServerRelativeURL")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SharePointFileSharePointLibraryId).HasColumnName("SharePointFileSharePointLibraryID");

                entity.Property(e => e.SharePointFileSiteId).HasColumnName("SharePointFileSiteID");

                entity.HasOne(d => d.SharePointFileSharePointLibrary)
                    .WithMany(p => p.SharePointSharePointFiles)
                    .HasForeignKey(d => d.SharePointFileSharePointLibraryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SharePoint_SharePointFile_SharePoint_SharePointLibrary");

                entity.HasOne(d => d.SharePointFileSite)
                    .WithMany(p => p.SharePointSharePointFiles)
                    .HasForeignKey(d => d.SharePointFileSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SharePoint_SharePointFile_CMS_Site");
            });

            modelBuilder.Entity<SharePointSharePointLibrary>(entity =>
            {
                entity.HasKey(e => e.SharePointLibraryId);

                entity.ToTable("SharePoint_SharePointLibrary", "dbo");

                entity.HasIndex(e => e.SharePointLibrarySharePointConnectionId, "IX_SharePoint_SharePointLibrary_SharePointLibrarySharepointConnectionID");

                entity.HasIndex(e => e.SharePointLibrarySiteId, "IX_SharePoint_SharePointLibrary_SharePointlibrarySiteID");

                entity.Property(e => e.SharePointLibraryId).HasColumnName("SharePointLibraryID");

                entity.Property(e => e.SharePointLibraryDisplayName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SharePointLibraryGuid).HasColumnName("SharePointLibraryGUID");

                entity.Property(e => e.SharePointLibraryLastModified).HasDefaultValueSql("('10/3/2014 2:45:04 PM')");

                entity.Property(e => e.SharePointLibraryListTitle)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SharePointLibraryName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.SharePointLibrarySharePointConnectionId)
                    .HasColumnName("SharePointLibrarySharePointConnectionID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SharePointLibrarySiteId).HasColumnName("SharePointLibrarySiteID");

                entity.Property(e => e.SharePointLibrarySynchronizationPeriod).HasDefaultValueSql("((720))");

                entity.HasOne(d => d.SharePointLibrarySharePointConnection)
                    .WithMany(p => p.SharePointSharePointLibraries)
                    .HasForeignKey(d => d.SharePointLibrarySharePointConnectionId)
                    .HasConstraintName("FK_SharePoint_SharePointLibrary_SharePoint_SharePointConnection");

                entity.HasOne(d => d.SharePointLibrarySite)
                    .WithMany(p => p.SharePointSharePointLibraries)
                    .HasForeignKey(d => d.SharePointLibrarySiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SharePoint_SharePointLibrary_CMS_Site");
            });

            modelBuilder.Entity<ShokouhBranchNode>(entity =>
            {
                entity.HasKey(e => e.BranchNodeId);

                entity.ToTable("Shokouh_BranchNode");

                entity.Property(e => e.BranchNodeId).HasColumnName("BranchNodeID");

                entity.Property(e => e.BranchAdd).HasMaxLength(1024);

                entity.Property(e => e.BranchManager).HasMaxLength(200);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BranchPicUrl)
                    .HasMaxLength(1024)
                    .HasColumnName("branchPicUrl");

                entity.Property(e => e.BranchTel).HasMaxLength(200);

                entity.Property(e => e.BranchType)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'شعبه')");

                entity.Property(e => e.Latitude).HasColumnType("decimal(19, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(19, 6)");
            });

            modelBuilder.Entity<ShokouhPardisAccountingCode>(entity =>
            {
                entity.HasKey(e => e.AccountingCodeId);

                entity.ToTable("ShokouhPardis_AccountingCode");

                entity.Property(e => e.AccountingCodeId).HasColumnName("AccountingCodeID");

                entity.Property(e => e.AccountingCodeLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.AccountingCodeParentId).HasColumnName("AccountingCodeParentID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.LastSq).HasColumnName("LastSQ");

                entity.Property(e => e.Title).HasMaxLength(512);
            });

            modelBuilder.Entity<ShokouhPardisAccountingTransaction>(entity =>
            {
                entity.HasKey(e => e.AccountingTransactionId);

                entity.ToTable("ShokouhPardis_AccountingTransaction");

                entity.Property(e => e.AccountingTransactionId).HasColumnName("AccountingTransactionID");

                entity.Property(e => e.AccountingTransactionLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.ShortTxKey).HasMaxLength(512);
            });

            modelBuilder.Entity<ShokouhPardisBookClass>(entity =>
            {
                entity.HasKey(e => e.BookClassId);

                entity.ToTable("ShokouhPardis_BookClass", "dbo");

                entity.Property(e => e.BookClassId).HasColumnName("BookClassID");

                entity.Property(e => e.BookClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.BookDes).HasMaxLength(200);

                entity.Property(e => e.BookName).HasMaxLength(200);

                entity.Property(e => e.BookPic).HasMaxLength(1024);
            });

            modelBuilder.Entity<ShokouhPardisClassRoom>(entity =>
            {
                entity.HasKey(e => e.ClassRoomId);

                entity.ToTable("ShokouhPardis_ClassRoom", "dbo");

                entity.Property(e => e.ClassRoomId).HasColumnName("ClassRoomID");

                entity.Property(e => e.ClassRoomLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.ClassRoomName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ShokouhPardisCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("ShokouhPardis_Course", "dbo");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.ClassRoomId).HasColumnName("ClassRoomID");

                entity.Property(e => e.CourseLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.CourseTitle).HasMaxLength(200);

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.TermId).HasColumnName("TermID");
            });

            modelBuilder.Entity<ShokouhPardisCourseStudent>(entity =>
            {
                entity.HasKey(e => e.CourseStudentId);

                entity.ToTable("ShokouhPardis_CourseStudent", "dbo");

                entity.Property(e => e.CourseStudentId).HasColumnName("CourseStudentID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseStudentLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<ShokouhPardisDailyJv>(entity =>
            {
                entity.HasKey(e => e.DailyJvid);

                entity.ToTable("ShokouhPardis_DailyJV");

                entity.Property(e => e.DailyJvid).HasColumnName("DailyJVID");

                entity.Property(e => e.CardPostfix).HasMaxLength(200);

                entity.Property(e => e.DailyJvguid).HasColumnName("DailyJVGuid");

                entity.Property(e => e.DailyJvlastModified)
                    .HasColumnName("DailyJVLastModified")
                    .HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.FeeFor).HasMaxLength(200);

                entity.Property(e => e.PaymentType).HasMaxLength(200);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.Property(e => e.Txcode)
                    .HasMaxLength(15)
                    .HasColumnName("TXCode");
            });

            modelBuilder.Entity<ShokouhPardisDaySession>(entity =>
            {
                entity.HasKey(e => e.DaySessionId);

                entity.ToTable("ShokouhPardis_DaySession", "dbo");

                entity.Property(e => e.DaySessionId).HasColumnName("DaySessionID");

                entity.Property(e => e.DaySessionLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.IntervalId).HasColumnName("IntervalID");

                entity.Property(e => e.WeekdayId).HasColumnName("WeekdayID");
            });

            modelBuilder.Entity<ShokouhPardisEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("ShokouhPardis_Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.EmployeeLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisFileAttachment>(entity =>
            {
                entity.ToTable("ShokouhPardis_FileAttachment");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName).HasMaxLength(512);

                entity.Property(e => e.FileTitle).HasMaxLength(512);

                entity.Property(e => e.Folder).HasMaxLength(512);

                entity.Property(e => e.LastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisFinanceFlat>(entity =>
            {
                entity.HasKey(e => e.FinanceFlatId);

                entity.ToTable("ShokouhPardis_Finance_Flat");

                entity.Property(e => e.FinanceFlatId).HasColumnName("Finance_FlatID");

                entity.Property(e => e.CreditCardPostFixNo).HasMaxLength(16);

                entity.Property(e => e.FinanceFlatGuid).HasColumnName("Finance_FlatGuid");

                entity.Property(e => e.FinanceFlatLastModified)
                    .HasColumnName("Finance_FlatLastModified")
                    .HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.PaymentCauseId)
                    .HasColumnName("PaymentCauseID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentForTermId).HasColumnName("PaymentForTermID");

                entity.Property(e => e.PaymentForYearId).HasColumnName("PaymentForYearID");

                entity.Property(e => e.PaymentTypeId)
                    .HasColumnName("PaymentTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StudentFamily).HasMaxLength(512);

                entity.Property(e => e.StudentId)
                    .HasMaxLength(200)
                    .HasColumnName("StudentID");

                entity.Property(e => e.StudentName).HasMaxLength(512);

                entity.Property(e => e.VerificationStatus).HasColumnName("Verification_Status");
            });

            modelBuilder.Entity<ShokouhPardisInterval>(entity =>
            {
                entity.HasKey(e => e.IntervalId);

                entity.ToTable("ShokouhPardis_Interval", "dbo");

                entity.Property(e => e.IntervalId).HasColumnName("IntervalID");

                entity.Property(e => e.IntervalLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.TermId).HasDefaultValueSql("((21))");

                entity.Property(e => e.TimeInterval).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisJvfromSite>(entity =>
            {
                entity.HasKey(e => e.DailyJvid);

                entity.ToTable("ShokouhPardis_JVFromSite");

                entity.Property(e => e.DailyJvid).HasColumnName("DailyJVID");

                entity.Property(e => e.ApprovedBy).HasMaxLength(200);

                entity.Property(e => e.CardPostfix).HasMaxLength(200);

                entity.Property(e => e.DailyJvguid).HasColumnName("DailyJVGuid");

                entity.Property(e => e.DailyJvlastModified)
                    .HasColumnName("DailyJVLastModified")
                    .HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Description).HasMaxLength(512);

                entity.Property(e => e.FeeFor).HasMaxLength(200);

                entity.Property(e => e.PhoneNumber).HasMaxLength(11);

                entity.Property(e => e.StudentFamil)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentIdNumber).HasMaxLength(10);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Txcode)
                    .HasMaxLength(15)
                    .HasColumnName("TXCode");
            });

            modelBuilder.Entity<ShokouhPardisLevelBookPrice>(entity =>
            {
                entity.HasKey(e => e.LevelBookPriceId);

                entity.ToTable("ShokouhPardis_LevelBookPrice");

                entity.Property(e => e.LevelBookPriceId).HasColumnName("LevelBookPriceID");

                entity.Property(e => e.LevelBookPriceLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.TermId).HasColumnName("TermID");
            });

            modelBuilder.Entity<ShokouhPardisLevelClass>(entity =>
            {
                entity.HasKey(e => e.LevelClassId);

                entity.ToTable("ShokouhPardis_LevelClass", "dbo");

                entity.Property(e => e.LevelClassId).HasColumnName("LevelClassID");

                entity.Property(e => e.BookId).HasColumnName("BookID");

                entity.Property(e => e.LevelClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.LevelDes).HasMaxLength(512);

                entity.Property(e => e.LevelName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.NextLevelFk).HasColumnName("NextLevelFK");
            });

            modelBuilder.Entity<ShokouhPardisProgram>(entity =>
            {
                entity.HasKey(e => e.ProgramId);

                entity.ToTable("ShokouhPardis_Program", "dbo");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.DaysessionId).HasColumnName("DaysessionID");

                entity.Property(e => e.ProgramLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("ScheduleID")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ShokouhPardisSchedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleId);

                entity.ToTable("ShokouhPardis_schedule", "dbo");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.ScheduleLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Title)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<ShokouhPardisStudentClass>(entity =>
            {
                entity.HasKey(e => e.StudentClassId);

                entity.ToTable("ShokouhPardis_StudentClass", "dbo");

                entity.Property(e => e.StudentClassId).HasColumnName("StudentClassID");

                entity.Property(e => e.FatherJob).HasMaxLength(200);

                entity.Property(e => e.FatherPhone).HasMaxLength(200);

                entity.Property(e => e.HomePhone).HasMaxLength(200);

                entity.Property(e => e.MotherJob).HasMaxLength(200);

                entity.Property(e => e.MotherPhone).HasMaxLength(200);

                entity.Property(e => e.StudentAddress).HasMaxLength(1024);

                entity.Property(e => e.StudentClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.StudentFamily)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentFatherName).HasMaxLength(512);

                entity.Property(e => e.StudentFrom).HasMaxLength(200);

                entity.Property(e => e.StudentIdno)
                    .HasMaxLength(10)
                    .HasColumnName("StudentIDNo")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.StudentMotherFullName).HasMaxLength(512);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentPhone).HasMaxLength(200);

                entity.Property(e => e.StudentShno).HasColumnName("StudentSHNo");

                entity.Property(e => e.WhatsAppPhone).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisStudentClassDto>(entity =>
            {
                entity.HasKey(e => e.StudentClassId);

                entity.ToTable("ShokouhPardis_StudentClass_Dto");

                entity.Property(e => e.StudentClassId).HasColumnName("StudentClassID");

                entity.Property(e => e.FatherJob).HasMaxLength(200);

                entity.Property(e => e.MotherJob).HasMaxLength(200);

                entity.Property(e => e.StudentAddress).HasMaxLength(1024);

                entity.Property(e => e.StudentClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.StudentFamily)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentFatherName).HasMaxLength(512);

                entity.Property(e => e.StudentFrom).HasMaxLength(200);

                entity.Property(e => e.StudentIdno).HasColumnName("StudentIDNo");

                entity.Property(e => e.StudentMotherFullName).HasMaxLength(512);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentShno).HasColumnName("StudentSHNo");
            });

            modelBuilder.Entity<ShokouhPardisStudentClassOnlineForm>(entity =>
            {
                entity.HasKey(e => e.StudentClassId);

                entity.ToTable("ShokouhPardis_StudentClass_OnlineForm");

                entity.Property(e => e.StudentClassId).HasColumnName("StudentClassID");

                entity.Property(e => e.FatherJob).HasMaxLength(200);

                entity.Property(e => e.FatherPhone).HasMaxLength(200);

                entity.Property(e => e.HomePhone).HasMaxLength(200);

                entity.Property(e => e.IsGirl)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MotherJob).HasMaxLength(200);

                entity.Property(e => e.MotherPhone).HasMaxLength(200);

                entity.Property(e => e.StudentAddress).HasMaxLength(1024);

                entity.Property(e => e.StudentClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.StudentFamily)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentFatherName).HasMaxLength(512);

                entity.Property(e => e.StudentFrom).HasMaxLength(200);

                entity.Property(e => e.StudentIdno)
                    .HasMaxLength(10)
                    .HasColumnName("StudentIDNo")
                    .HasDefaultValueSql("(N'0')");

                entity.Property(e => e.StudentMotherFullName).HasMaxLength(512);

                entity.Property(e => e.StudentName)
                    .HasMaxLength(512)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.StudentPhone).HasMaxLength(200);

                entity.Property(e => e.StudentShno).HasColumnName("StudentSHNo");

                entity.Property(e => e.WhatsAppPhone).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisTeacherClass>(entity =>
            {
                entity.HasKey(e => e.TeacherClassId);

                entity.ToTable("ShokouhPardis_TeacherClass", "dbo");

                entity.Property(e => e.TeacherClassId).HasColumnName("TeacherClassID");

                entity.Property(e => e.TeacherClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.TeacherFamily)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TeacherName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TeacherPic).HasMaxLength(1024);

                entity.Property(e => e.TeacherSex)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TermId).HasDefaultValueSql("((20))");
            });

            modelBuilder.Entity<ShokouhPardisTeacherLevel>(entity =>
            {
                entity.HasKey(e => e.TeacherLevelsId);

                entity.ToTable("ShokouhPardis_TeacherLevels");

                entity.Property(e => e.TeacherLevelsId).HasColumnName("TeacherLevelsID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.TeacherLevelsLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisTeacherTermClass>(entity =>
            {
                entity.ToTable("ShokouhPardis_TeacherTermClass");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisTeacherTimeSheet>(entity =>
            {
                entity.HasKey(e => e.TeacherTimeSheetId);

                entity.ToTable("ShokouhPardis_TeacherTimeSheet");

                entity.Property(e => e.TeacherTimeSheetId).HasColumnName("TeacherTimeSheetID");

                entity.Property(e => e.IntervalId).HasColumnName("IntervalID");

                entity.Property(e => e.TeacherId).HasColumnName("TeacherID");

                entity.Property(e => e.TeacherTimeSheetLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.TermId).HasColumnName("TermID");

                entity.Property(e => e.WeekDayId).HasColumnName("WeekDayID");
            });

            modelBuilder.Entity<ShokouhPardisTermClass>(entity =>
            {
                entity.HasKey(e => e.TermClassId);

                entity.ToTable("ShokouhPardis_TermClass", "dbo");

                entity.Property(e => e.TermClassId).HasColumnName("TermClassID");

                entity.Property(e => e.TermClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.TermName).HasMaxLength(200);

                entity.Property(e => e.YearId).HasColumnName("YearID");
            });

            modelBuilder.Entity<ShokouhPardisTimeTable>(entity =>
            {
                entity.HasKey(e => e.TimeTableId);

                entity.ToTable("ShokouhPardis_TimeTable");

                entity.Property(e => e.TimeTableId).HasColumnName("TimeTableID");

                entity.Property(e => e.LevelId).HasColumnName("LevelID");

                entity.Property(e => e.TimeTableLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<ShokouhPardisTimeTableStudent>(entity =>
            {
                entity.HasKey(e => e.TimeTableStudentsId);

                entity.ToTable("ShokouhPardis_TimeTableStudents");

                entity.Property(e => e.TimeTableStudentsId).HasColumnName("TimeTableStudentsID");

                entity.Property(e => e.TimeTableStudentsLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisWeekDay>(entity =>
            {
                entity.HasKey(e => e.WeekDayId);

                entity.ToTable("ShokouhPardis_WeekDay", "dbo");

                entity.Property(e => e.WeekDayId).HasColumnName("WeekDayID");

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.WeekDayLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ShokouhPardisYearClass>(entity =>
            {
                entity.HasKey(e => e.YearClassId);

                entity.ToTable("ShokouhPardis_YearClass", "dbo");

                entity.Property(e => e.YearClassId).HasColumnName("YearClassID");

                entity.Property(e => e.YearClassLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");

                entity.Property(e => e.YearName).HasMaxLength(200);
            });

            modelBuilder.Entity<SmFacebookAccount>(entity =>
            {
                entity.HasKey(e => e.FacebookAccountId);

                entity.ToTable("SM_FacebookAccount", "dbo");

                entity.HasIndex(e => e.FacebookAccountFacebookApplicationId, "IX_SM_FacebookAccount_FacebookAccountFacebookApplicationID");

                entity.HasIndex(e => e.FacebookAccountSiteId, "IX_SM_FacebookAccount_FacebookAccountSiteID");

                entity.Property(e => e.FacebookAccountId).HasColumnName("FacebookAccountID");

                entity.Property(e => e.FacebookAccountDisplayName).HasMaxLength(200);

                entity.Property(e => e.FacebookAccountFacebookApplicationId).HasColumnName("FacebookAccountFacebookApplicationID");

                entity.Property(e => e.FacebookAccountGuid).HasColumnName("FacebookAccountGUID");

                entity.Property(e => e.FacebookAccountName).HasMaxLength(200);

                entity.Property(e => e.FacebookAccountPageAccessToken).HasDefaultValueSql("('')");

                entity.Property(e => e.FacebookAccountPageId)
                    .HasMaxLength(500)
                    .HasColumnName("FacebookAccountPageID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FacebookAccountSiteId).HasColumnName("FacebookAccountSiteID");

                entity.HasOne(d => d.FacebookAccountFacebookApplication)
                    .WithMany(p => p.SmFacebookAccounts)
                    .HasForeignKey(d => d.FacebookAccountFacebookApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_FacebookAccount_SM_FacebookApplication");

                entity.HasOne(d => d.FacebookAccountSite)
                    .WithMany(p => p.SmFacebookAccounts)
                    .HasForeignKey(d => d.FacebookAccountSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_FacebookAccount_CMS_Site");
            });

            modelBuilder.Entity<SmFacebookApplication>(entity =>
            {
                entity.HasKey(e => e.FacebookApplicationId);

                entity.ToTable("SM_FacebookApplication", "dbo");

                entity.HasIndex(e => e.FacebookApplicationSiteId, "IX_SM_FacebookApplication_FacebookApplicationSiteID");

                entity.Property(e => e.FacebookApplicationId).HasColumnName("FacebookApplicationID");

                entity.Property(e => e.FacebookApplicationConsumerKey)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FacebookApplicationConsumerSecret)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FacebookApplicationDisplayName).HasMaxLength(200);

                entity.Property(e => e.FacebookApplicationGuid).HasColumnName("FacebookApplicationGUID");

                entity.Property(e => e.FacebookApplicationLastModified).HasDefaultValueSql("('5/28/2013 1:02:36 PM')");

                entity.Property(e => e.FacebookApplicationName).HasMaxLength(200);

                entity.Property(e => e.FacebookApplicationSiteId).HasColumnName("FacebookApplicationSiteID");

                entity.HasOne(d => d.FacebookApplicationSite)
                    .WithMany(p => p.SmFacebookApplications)
                    .HasForeignKey(d => d.FacebookApplicationSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_FacebookApplication_CMS_Site");
            });

            modelBuilder.Entity<SmFacebookPost>(entity =>
            {
                entity.HasKey(e => e.FacebookPostId);

                entity.ToTable("SM_FacebookPost", "dbo");

                entity.HasIndex(e => e.FacebookPostCampaignId, "IX_SM_FacebookPost_FacebookPostCampaignID");

                entity.HasIndex(e => e.FacebookPostFacebookAccountId, "IX_SM_FacebookPost_FacebookPostFacebookAccountID");

                entity.HasIndex(e => e.FacebookPostSiteId, "IX_SM_FacebookPost_FacebookPostSiteID");

                entity.Property(e => e.FacebookPostId).HasColumnName("FacebookPostID");

                entity.Property(e => e.FacebookPostCampaignId).HasColumnName("FacebookPostCampaignID");

                entity.Property(e => e.FacebookPostDocumentGuid).HasColumnName("FacebookPostDocumentGUID");

                entity.Property(e => e.FacebookPostExternalId).HasColumnName("FacebookPostExternalID");

                entity.Property(e => e.FacebookPostFacebookAccountId).HasColumnName("FacebookPostFacebookAccountID");

                entity.Property(e => e.FacebookPostGuid).HasColumnName("FacebookPostGUID");

                entity.Property(e => e.FacebookPostIsCreatedByUser).HasDefaultValueSql("((1))");

                entity.Property(e => e.FacebookPostSiteId).HasColumnName("FacebookPostSiteID");

                entity.Property(e => e.FacebookPostUrlshortenerType).HasColumnName("FacebookPostURLShortenerType");

                entity.HasOne(d => d.FacebookPostCampaign)
                    .WithMany(p => p.SmFacebookPosts)
                    .HasForeignKey(d => d.FacebookPostCampaignId);

                entity.HasOne(d => d.FacebookPostFacebookAccount)
                    .WithMany(p => p.SmFacebookPosts)
                    .HasForeignKey(d => d.FacebookPostFacebookAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_FacebookPost_SM_FacebookAccount");

                entity.HasOne(d => d.FacebookPostSite)
                    .WithMany(p => p.SmFacebookPosts)
                    .HasForeignKey(d => d.FacebookPostSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_FacebookPost_CMS_Site");
            });

            modelBuilder.Entity<SmInsight>(entity =>
            {
                entity.HasKey(e => e.InsightId);

                entity.ToTable("SM_Insight", "dbo");

                entity.HasIndex(e => new { e.InsightCodeName, e.InsightPeriodType }, "IX_SM_Insight_InsightCodeName_InsightPeriodType");

                entity.Property(e => e.InsightId).HasColumnName("InsightID");

                entity.Property(e => e.InsightCodeName).HasMaxLength(200);

                entity.Property(e => e.InsightExternalId)
                    .HasColumnName("InsightExternalID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InsightPeriodType).HasMaxLength(20);
            });

            modelBuilder.Entity<SmInsightHitDay>(entity =>
            {
                entity.HasKey(e => e.InsightHitId);

                entity.ToTable("SM_InsightHit_Day", "dbo");

                entity.HasIndex(e => new { e.InsightHitInsightId, e.InsightHitPeriodFrom, e.InsightHitPeriodTo }, "UQ_SM_InsightHit_Day_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo")
                    .IsUnique();

                entity.Property(e => e.InsightHitId).HasColumnName("InsightHitID");

                entity.Property(e => e.InsightHitInsightId).HasColumnName("InsightHitInsightID");

                entity.HasOne(d => d.InsightHitInsight)
                    .WithMany(p => p.SmInsightHitDays)
                    .HasForeignKey(d => d.InsightHitInsightId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SmInsightHitMonth>(entity =>
            {
                entity.HasKey(e => e.InsightHitId);

                entity.ToTable("SM_InsightHit_Month", "dbo");

                entity.HasIndex(e => new { e.InsightHitInsightId, e.InsightHitPeriodFrom, e.InsightHitPeriodTo }, "UQ_SM_InsightHit_Month_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo")
                    .IsUnique();

                entity.Property(e => e.InsightHitId).HasColumnName("InsightHitID");

                entity.Property(e => e.InsightHitInsightId).HasColumnName("InsightHitInsightID");

                entity.HasOne(d => d.InsightHitInsight)
                    .WithMany(p => p.SmInsightHitMonths)
                    .HasForeignKey(d => d.InsightHitInsightId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SmInsightHitWeek>(entity =>
            {
                entity.HasKey(e => e.InsightHitId);

                entity.ToTable("SM_InsightHit_Week", "dbo");

                entity.HasIndex(e => new { e.InsightHitInsightId, e.InsightHitPeriodFrom, e.InsightHitPeriodTo }, "UQ_SM_InsightHit_Week_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo")
                    .IsUnique();

                entity.Property(e => e.InsightHitId).HasColumnName("InsightHitID");

                entity.Property(e => e.InsightHitInsightId).HasColumnName("InsightHitInsightID");

                entity.HasOne(d => d.InsightHitInsight)
                    .WithMany(p => p.SmInsightHitWeeks)
                    .HasForeignKey(d => d.InsightHitInsightId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SmInsightHitYear>(entity =>
            {
                entity.HasKey(e => e.InsightHitId);

                entity.ToTable("SM_InsightHit_Year", "dbo");

                entity.HasIndex(e => new { e.InsightHitInsightId, e.InsightHitPeriodFrom, e.InsightHitPeriodTo }, "UQ_SM_InsightHit_Year_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo")
                    .IsUnique();

                entity.Property(e => e.InsightHitId).HasColumnName("InsightHitID");

                entity.Property(e => e.InsightHitInsightId).HasColumnName("InsightHitInsightID");

                entity.HasOne(d => d.InsightHitInsight)
                    .WithMany(p => p.SmInsightHitYears)
                    .HasForeignKey(d => d.InsightHitInsightId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SmLinkedInAccount>(entity =>
            {
                entity.HasKey(e => e.LinkedInAccountId);

                entity.ToTable("SM_LinkedInAccount", "dbo");

                entity.Property(e => e.LinkedInAccountId).HasColumnName("LinkedInAccountID");

                entity.Property(e => e.LinkedInAccountAccessToken)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInAccountDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInAccountGuid).HasColumnName("LinkedInAccountGUID");

                entity.Property(e => e.LinkedInAccountLinkedInApplicationId).HasColumnName("LinkedInAccountLinkedInApplicationID");

                entity.Property(e => e.LinkedInAccountName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInAccountProfileId)
                    .HasMaxLength(50)
                    .HasColumnName("LinkedInAccountProfileID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInAccountProfileName).HasMaxLength(200);

                entity.Property(e => e.LinkedInAccountSiteId).HasColumnName("LinkedInAccountSiteID");
            });

            modelBuilder.Entity<SmLinkedInApplication>(entity =>
            {
                entity.HasKey(e => e.LinkedInApplicationId);

                entity.ToTable("SM_LinkedInApplication", "dbo");

                entity.HasIndex(e => e.LinkedInApplicationSiteId, "IX_SM_LinkedInApplication_LinkedInApplicationSiteID");

                entity.Property(e => e.LinkedInApplicationId).HasColumnName("LinkedInApplicationID");

                entity.Property(e => e.LinkedInApplicationConsumerKey)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInApplicationConsumerSecret)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInApplicationDisplayName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInApplicationGuid).HasColumnName("LinkedInApplicationGUID");

                entity.Property(e => e.LinkedInApplicationName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInApplicationSiteId).HasColumnName("LinkedInApplicationSiteID");

                entity.HasOne(d => d.LinkedInApplicationSite)
                    .WithMany(p => p.SmLinkedInApplications)
                    .HasForeignKey(d => d.LinkedInApplicationSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_LinkedInApplication_CMS_Site");
            });

            modelBuilder.Entity<SmLinkedInPost>(entity =>
            {
                entity.HasKey(e => e.LinkedInPostId);

                entity.ToTable("SM_LinkedInPost", "dbo");

                entity.HasIndex(e => e.LinkedInPostCampaignId, "IX_SM_LinkedInPost_LinkedInPostCampaignID");

                entity.HasIndex(e => e.LinkedInPostLinkedInAccountId, "IX_SM_LinkedInPost_LinkedInPostLinkedInAccountID");

                entity.HasIndex(e => e.LinkedInPostSiteId, "IX_SM_LinkedInPost_LinkedInPostSiteID");

                entity.Property(e => e.LinkedInPostId).HasColumnName("LinkedInPostID");

                entity.Property(e => e.LinkedInPostCampaignId).HasColumnName("LinkedInPostCampaignID");

                entity.Property(e => e.LinkedInPostComment)
                    .HasMaxLength(700)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.LinkedInPostDocumentGuid).HasColumnName("LinkedInPostDocumentGUID");

                entity.Property(e => e.LinkedInPostGuid).HasColumnName("LinkedInPostGUID");

                entity.Property(e => e.LinkedInPostHttpstatusCode).HasColumnName("LinkedInPostHTTPStatusCode");

                entity.Property(e => e.LinkedInPostIsCreatedByUser).HasDefaultValueSql("((1))");

                entity.Property(e => e.LinkedInPostLinkedInAccountId).HasColumnName("LinkedInPostLinkedInAccountID");

                entity.Property(e => e.LinkedInPostSiteId).HasColumnName("LinkedInPostSiteID");

                entity.Property(e => e.LinkedInPostUpdateKey).HasMaxLength(200);

                entity.Property(e => e.LinkedInPostUrlshortenerType).HasColumnName("LinkedInPostURLShortenerType");

                entity.HasOne(d => d.LinkedInPostCampaign)
                    .WithMany(p => p.SmLinkedInPosts)
                    .HasForeignKey(d => d.LinkedInPostCampaignId);

                entity.HasOne(d => d.LinkedInPostLinkedInAccount)
                    .WithMany(p => p.SmLinkedInPosts)
                    .HasForeignKey(d => d.LinkedInPostLinkedInAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_LinkedInPost_SM_LinkedInAccount");

                entity.HasOne(d => d.LinkedInPostSite)
                    .WithMany(p => p.SmLinkedInPosts)
                    .HasForeignKey(d => d.LinkedInPostSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_LinkedInPost_CMS_Site");
            });

            modelBuilder.Entity<SmTwitterAccount>(entity =>
            {
                entity.HasKey(e => e.TwitterAccountId);

                entity.ToTable("SM_TwitterAccount", "dbo");

                entity.HasIndex(e => e.TwitterAccountSiteId, "IX_SM_TwitterAccount_TwitterAccountSiteID");

                entity.HasIndex(e => e.TwitterAccountTwitterApplicationId, "IX_SM_TwitterAccount_TwitterAccountTwitterApplicationID");

                entity.Property(e => e.TwitterAccountId).HasColumnName("TwitterAccountID");

                entity.Property(e => e.TwitterAccountAccessToken)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TwitterAccountAccessTokenSecret)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TwitterAccountDisplayName).HasMaxLength(200);

                entity.Property(e => e.TwitterAccountGuid).HasColumnName("TwitterAccountGUID");

                entity.Property(e => e.TwitterAccountMentionsRange).HasMaxLength(40);

                entity.Property(e => e.TwitterAccountName).HasMaxLength(200);

                entity.Property(e => e.TwitterAccountSiteId).HasColumnName("TwitterAccountSiteID");

                entity.Property(e => e.TwitterAccountTwitterApplicationId).HasColumnName("TwitterAccountTwitterApplicationID");

                entity.Property(e => e.TwitterAccountUserId)
                    .HasMaxLength(20)
                    .HasColumnName("TwitterAccountUserID");

                entity.HasOne(d => d.TwitterAccountSite)
                    .WithMany(p => p.SmTwitterAccounts)
                    .HasForeignKey(d => d.TwitterAccountSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_TwitterAccount_CMS_Site");

                entity.HasOne(d => d.TwitterAccountTwitterApplication)
                    .WithMany(p => p.SmTwitterAccounts)
                    .HasForeignKey(d => d.TwitterAccountTwitterApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_TwitterAccount_SM_TwitterApplication");
            });

            modelBuilder.Entity<SmTwitterApplication>(entity =>
            {
                entity.HasKey(e => e.TwitterApplicationId);

                entity.ToTable("SM_TwitterApplication", "dbo");

                entity.HasIndex(e => e.TwitterApplicationSiteId, "IX_SM_TwitterApplication_TwitterApplicationSiteID");

                entity.Property(e => e.TwitterApplicationId).HasColumnName("TwitterApplicationID");

                entity.Property(e => e.TwitterApplicationConsumerKey)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TwitterApplicationConsumerSecret)
                    .HasMaxLength(500)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TwitterApplicationDisplayName).HasMaxLength(200);

                entity.Property(e => e.TwitterApplicationGuid).HasColumnName("TwitterApplicationGUID");

                entity.Property(e => e.TwitterApplicationName).HasMaxLength(200);

                entity.Property(e => e.TwitterApplicationSiteId).HasColumnName("TwitterApplicationSiteID");

                entity.HasOne(d => d.TwitterApplicationSite)
                    .WithMany(p => p.SmTwitterApplications)
                    .HasForeignKey(d => d.TwitterApplicationSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_TwitterApplication_CMS_Site");
            });

            modelBuilder.Entity<SmTwitterPost>(entity =>
            {
                entity.HasKey(e => e.TwitterPostId);

                entity.ToTable("SM_TwitterPost", "dbo");

                entity.HasIndex(e => e.TwitterPostCampaignId, "IX_SM_TwitterPost_TwitterPostCampaignID");

                entity.HasIndex(e => e.TwitterPostSiteId, "IX_SM_TwitterPost_TwitterPostSiteID");

                entity.HasIndex(e => e.TwitterPostTwitterAccountId, "IX_SM_TwitterPost_TwitterPostTwitterAccountID");

                entity.Property(e => e.TwitterPostId).HasColumnName("TwitterPostID");

                entity.Property(e => e.TwitterPostCampaignId).HasColumnName("TwitterPostCampaignID");

                entity.Property(e => e.TwitterPostDocumentGuid).HasColumnName("TwitterPostDocumentGUID");

                entity.Property(e => e.TwitterPostExternalId).HasColumnName("TwitterPostExternalID");

                entity.Property(e => e.TwitterPostGuid).HasColumnName("TwitterPostGUID");

                entity.Property(e => e.TwitterPostIsCreatedByUser).HasDefaultValueSql("((1))");

                entity.Property(e => e.TwitterPostSiteId).HasColumnName("TwitterPostSiteID");

                entity.Property(e => e.TwitterPostText).HasDefaultValueSql("('')");

                entity.Property(e => e.TwitterPostTwitterAccountId).HasColumnName("TwitterPostTwitterAccountID");

                entity.Property(e => e.TwitterPostUrlshortenerType).HasColumnName("TwitterPostURLShortenerType");

                entity.HasOne(d => d.TwitterPostCampaign)
                    .WithMany(p => p.SmTwitterPosts)
                    .HasForeignKey(d => d.TwitterPostCampaignId);

                entity.HasOne(d => d.TwitterPostSite)
                    .WithMany(p => p.SmTwitterPosts)
                    .HasForeignKey(d => d.TwitterPostSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_TwitterPost_CMS_Site");

                entity.HasOne(d => d.TwitterPostTwitterAccount)
                    .WithMany(p => p.SmTwitterPosts)
                    .HasForeignKey(d => d.TwitterPostTwitterAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SM_TwitterPost_SM_TwitterAccount");
            });

            modelBuilder.Entity<SopBookFolderId>(entity =>
            {
                entity.HasKey(e => e.BookFolderIdid);

                entity.ToTable("SOP_BookFolderID");

                entity.Property(e => e.BookFolderIdid).HasColumnName("BookFolderIDID");

                entity.Property(e => e.BookFolderId)
                    .HasMaxLength(200)
                    .HasColumnName("BookFolderID")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.BookLevel)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Branch)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("(N'Pardis')");

                entity.Property(e => e.Url)
                    .HasMaxLength(1024)
                    .HasColumnName("URL")
                    .HasDefaultValueSql("(N'pardisTEST')");
            });

            modelBuilder.Entity<StagingServer>(entity =>
            {
                entity.HasKey(e => e.ServerId)
                    .IsClustered(false);

                entity.ToTable("Staging_Server", "dbo");

                entity.HasIndex(e => e.ServerEnabled, "IX_Staging_Server_ServerEnabled");

                entity.HasIndex(e => e.ServerSiteId, "IX_Staging_Server_ServerSiteID");

                entity.HasIndex(e => new { e.ServerSiteId, e.ServerDisplayName }, "IX_Staging_Server_ServerSiteID_ServerDisplayName")
                    .IsClustered();

                entity.Property(e => e.ServerId).HasColumnName("ServerID");

                entity.Property(e => e.ServerAuthentication)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('USERNAME')");

                entity.Property(e => e.ServerDisplayName)
                    .HasMaxLength(440)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServerEnabled)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ServerGuid).HasColumnName("ServerGUID");

                entity.Property(e => e.ServerName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ServerPassword).HasMaxLength(100);

                entity.Property(e => e.ServerSiteId).HasColumnName("ServerSiteID");

                entity.Property(e => e.ServerUrl)
                    .HasMaxLength(450)
                    .HasColumnName("ServerURL")
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.ServerUsername).HasMaxLength(100);

                entity.Property(e => e.ServerX509clientKeyId)
                    .HasMaxLength(200)
                    .HasColumnName("ServerX509ClientKeyID");

                entity.Property(e => e.ServerX509serverKeyId)
                    .HasMaxLength(200)
                    .HasColumnName("ServerX509ServerKeyID");

                entity.HasOne(d => d.ServerSite)
                    .WithMany(p => p.StagingServers)
                    .HasForeignKey(d => d.ServerSiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staging_Server_ServerSiteID_CMS_Site");
            });

            modelBuilder.Entity<StagingSynchronization>(entity =>
            {
                entity.HasKey(e => e.SynchronizationId);

                entity.ToTable("Staging_Synchronization", "dbo");

                entity.HasIndex(e => e.SynchronizationServerId, "IX_Staging_Synchronization_SynchronizationServerID");

                entity.HasIndex(e => e.SynchronizationTaskId, "IX_Staging_Synchronization_SynchronizationTaskID");

                entity.Property(e => e.SynchronizationId).HasColumnName("SynchronizationID");

                entity.Property(e => e.SynchronizationServerId).HasColumnName("SynchronizationServerID");

                entity.Property(e => e.SynchronizationTaskId).HasColumnName("SynchronizationTaskID");

                entity.HasOne(d => d.SynchronizationServer)
                    .WithMany(p => p.StagingSynchronizations)
                    .HasForeignKey(d => d.SynchronizationServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staging_Synchronization_SynchronizationServerID_Staging_Server");

                entity.HasOne(d => d.SynchronizationTask)
                    .WithMany(p => p.StagingSynchronizations)
                    .HasForeignKey(d => d.SynchronizationTaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staging_Synchronization_SynchronizationTaskID_Staging_Task");
            });

            modelBuilder.Entity<StagingTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.ToTable("Staging_Task", "dbo");

                entity.HasIndex(e => new { e.TaskDocumentId, e.TaskNodeId, e.TaskRunning }, "IX_Staging_Task_TaskDocumentID_TaskNodeID_TaskRunning");

                entity.HasIndex(e => new { e.TaskObjectType, e.TaskObjectId, e.TaskRunning }, "IX_Staging_Task_TaskObjectType_TaskObjectID_TaskRunning");

                entity.HasIndex(e => e.TaskSiteId, "IX_Staging_Task_TaskSiteID");

                entity.HasIndex(e => e.TaskType, "IX_Staging_Task_TaskType");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskDocumentId).HasColumnName("TaskDocumentID");

                entity.Property(e => e.TaskNodeAliasPath).HasMaxLength(450);

                entity.Property(e => e.TaskNodeId).HasColumnName("TaskNodeID");

                entity.Property(e => e.TaskObjectId).HasColumnName("TaskObjectID");

                entity.Property(e => e.TaskObjectType).HasMaxLength(100);

                entity.Property(e => e.TaskServers).HasDefaultValueSql("('null')");

                entity.Property(e => e.TaskSiteId).HasColumnName("TaskSiteID");

                entity.Property(e => e.TaskTitle).HasMaxLength(450);

                entity.Property(e => e.TaskType).HasMaxLength(50);

                entity.HasOne(d => d.TaskSite)
                    .WithMany(p => p.StagingTasks)
                    .HasForeignKey(d => d.TaskSiteId)
                    .HasConstraintName("FK_Staging_Task_TaskSiteID_CMS_Site");
            });

            modelBuilder.Entity<StagingTaskGroup>(entity =>
            {
                entity.HasKey(e => e.TaskGroupId);

                entity.ToTable("staging_TaskGroup", "dbo");

                entity.Property(e => e.TaskGroupId).HasColumnName("TaskGroupID");

                entity.Property(e => e.TaskGroupCodeName)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'')");
            });

            modelBuilder.Entity<StagingTaskGroupTask>(entity =>
            {
                entity.HasKey(e => e.TaskGroupTaskId);

                entity.ToTable("staging_TaskGroupTask", "dbo");

                entity.HasIndex(e => e.TaskGroupId, "IX_Staging_TaskGroupTask_TaskGroupID");

                entity.HasIndex(e => e.TaskId, "IX_Staging_TaskGroupTask_TaskID");

                entity.Property(e => e.TaskGroupTaskId).HasColumnName("TaskGroupTaskID");

                entity.Property(e => e.TaskGroupId).HasColumnName("TaskGroupID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.HasOne(d => d.TaskGroup)
                    .WithMany(p => p.StagingTaskGroupTasks)
                    .HasForeignKey(d => d.TaskGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staging_TaskGroupTask_Staging_TaskGroup");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.StagingTaskGroupTasks)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staging_TaskGroupTask_Staging_Task");
            });

            modelBuilder.Entity<StagingTaskGroupUser>(entity =>
            {
                entity.HasKey(e => e.TaskGroupUserId);

                entity.ToTable("staging_TaskGroupUser", "dbo");

                entity.HasIndex(e => e.TaskGroupId, "IX_Staging_TaskGroupUser_TaskGroup_ID");

                entity.HasIndex(e => e.UserId, "IX_Staging_TaskGroupUser_UserID")
                    .IsUnique();

                entity.Property(e => e.TaskGroupUserId).HasColumnName("TaskGroupUserID");

                entity.Property(e => e.TaskGroupId).HasColumnName("TaskGroupID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.TaskGroup)
                    .WithMany(p => p.StagingTaskGroupUsers)
                    .HasForeignKey(d => d.TaskGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staging_TaskGroupUser_Staging_TaskGroup");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.StagingTaskGroupUser)
                    .HasForeignKey<StagingTaskGroupUser>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staging_TaskGroupUser_CMS_User");
            });

            modelBuilder.Entity<StagingTaskUser>(entity =>
            {
                entity.HasKey(e => e.TaskUserId);

                entity.ToTable("Staging_TaskUser", "dbo");

                entity.HasIndex(e => e.TaskId, "IX_Staging_TaskUser_TaskID");

                entity.HasIndex(e => e.UserId, "IX_Staging_TaskUser_UserID");

                entity.Property(e => e.TaskUserId).HasColumnName("TaskUserID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Task)
                    .WithMany(p => p.StagingTaskUsers)
                    .HasForeignKey(d => d.TaskId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staging_TaskUser_StagingTask");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StagingTaskUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Staging_TaskUser_CMS_User");
            });

            modelBuilder.Entity<StatementMeliN>(entity =>
            {
                entity.ToTable("StatementMeliN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepositAmount)
                    .HasMaxLength(255)
                    .HasColumnName("Deposit_Amount");

                entity.Property(e => e.Description2).HasMaxLength(255);

                entity.Property(e => e.ItemGuid).HasColumnName("ItemGUID");

                entity.Property(e => e.TraceNo)
                    .HasMaxLength(255)
                    .HasColumnName("Trace_No");

                entity.Property(e => e.TranChannel)
                    .HasMaxLength(255)
                    .HasColumnName("Tran_Channel");

                entity.Property(e => e.TransactionDate).HasColumnName("Transaction_Date");

                entity.Property(e => e.TransactionTime).HasColumnName("Transaction_Time");

                entity.Property(e => e.VerificationStatus).HasColumnName("Verification_Status");
            });

            modelBuilder.Entity<StatementParsianM>(entity =>
            {
                entity.ToTable("StatementParsianM");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AgentBranch)
                    .HasMaxLength(255)
                    .HasColumnName("Agent_Branch");

                entity.Property(e => e.CustomerDescription)
                    .HasMaxLength(255)
                    .HasColumnName("Customer_Description");

                entity.Property(e => e.DepositAmount).HasColumnName("Deposit_Amount");

                entity.Property(e => e.ReferenceNumber)
                    .HasMaxLength(255)
                    .HasColumnName("Reference_Number");

                entity.Property(e => e.TransactionDate).HasColumnName("Transaction_Date");

                entity.Property(e => e.TransactionTime).HasColumnName("Transaction_Time");

                entity.Property(e => e.WithdrawalAmount)
                    .HasMaxLength(255)
                    .HasColumnName("Withdrawal_Amount");
            });

            modelBuilder.Entity<TempFile>(entity =>
            {
                entity.HasKey(e => e.FileId);

                entity.ToTable("Temp_File", "dbo");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FileDirectory)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileExtension)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileGuid).HasColumnName("FileGUID");

                entity.Property(e => e.FileLastModified).HasDefaultValueSql("('6/29/2010 1:57:54 PM')");

                entity.Property(e => e.FileMimeType)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileName)
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileParentGuid).HasColumnName("FileParentGUID");

                entity.Property(e => e.FileTitle).HasMaxLength(250);
            });

            modelBuilder.Entity<TempPageBuilderWidget>(entity =>
            {
                entity.HasKey(e => e.PageBuilderWidgetsId);

                entity.ToTable("Temp_PageBuilderWidgets", "dbo");

                entity.Property(e => e.PageBuilderWidgetsId).HasColumnName("PageBuilderWidgetsID");

                entity.Property(e => e.PageBuilderWidgetsLastModified).HasDefaultValueSql("('1/1/0001 12:00:00 AM')");
            });

            modelBuilder.Entity<ViewBoardsBoardMessageJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Boards_BoardMessage_Joined", "dbo");

                entity.Property(e => e.BoardBaseUrl)
                    .HasMaxLength(450)
                    .HasColumnName("BoardBaseURL");

                entity.Property(e => e.BoardDisplayName).HasMaxLength(250);

                entity.Property(e => e.BoardDocumentId).HasColumnName("BoardDocumentID");

                entity.Property(e => e.BoardGroupId).HasColumnName("BoardGroupID");

                entity.Property(e => e.BoardGuid).HasColumnName("BoardGUID");

                entity.Property(e => e.BoardId).HasColumnName("BoardID");

                entity.Property(e => e.BoardLastMessageUserName).HasMaxLength(250);

                entity.Property(e => e.BoardName).HasMaxLength(250);

                entity.Property(e => e.BoardSiteId).HasColumnName("BoardSiteID");

                entity.Property(e => e.BoardUnsubscriptionUrl)
                    .HasMaxLength(450)
                    .HasColumnName("BoardUnsubscriptionURL");

                entity.Property(e => e.BoardUserId).HasColumnName("BoardUserID");

                entity.Property(e => e.GroupApprovedByUserId).HasColumnName("GroupApprovedByUserID");

                entity.Property(e => e.GroupAvatarId).HasColumnName("GroupAvatarID");

                entity.Property(e => e.GroupCreatedByUserId).HasColumnName("GroupCreatedByUserID");

                entity.Property(e => e.GroupDisplayName).HasMaxLength(200);

                entity.Property(e => e.GroupGuid).HasColumnName("GroupGUID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.GroupNodeGuid).HasColumnName("GroupNodeGUID");

                entity.Property(e => e.GroupSiteId).HasColumnName("GroupSiteID");

                entity.Property(e => e.MessageApprovedByUserId).HasColumnName("MessageApprovedByUserID");

                entity.Property(e => e.MessageAvatarGuid).HasColumnName("MessageAvatarGUID");

                entity.Property(e => e.MessageBoardId).HasColumnName("MessageBoardID");

                entity.Property(e => e.MessageEmail).HasMaxLength(254);

                entity.Property(e => e.MessageGuid).HasColumnName("MessageGUID");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.MessageUrl)
                    .HasMaxLength(450)
                    .HasColumnName("MessageURL");

                entity.Property(e => e.MessageUserId).HasColumnName("MessageUserID");

                entity.Property(e => e.MessageUserName).HasMaxLength(250);
            });

            modelBuilder.Entity<ViewCmsAclitemItemsAndOperator>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_ACLItem_ItemsAndOperators", "dbo");

                entity.Property(e => e.Aclid).HasColumnName("ACLID");

                entity.Property(e => e.AclitemId).HasColumnName("ACLItemID");

                entity.Property(e => e.AclownerNodeId).HasColumnName("ACLOwnerNodeID");

                entity.Property(e => e.Operator).HasMaxLength(51);

                entity.Property(e => e.OperatorFullName).HasMaxLength(450);

                entity.Property(e => e.OperatorName).HasMaxLength(100);

                entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ViewCmsObjectVersionHistoryUserJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_ObjectVersionHistoryUser_Joined", "dbo");

                entity.Property(e => e.Email).HasMaxLength(254);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(450);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.PreferredCultureCode).HasMaxLength(10);

                entity.Property(e => e.PreferredUicultureCode)
                    .HasMaxLength(10)
                    .HasColumnName("PreferredUICultureCode");

                entity.Property(e => e.UserGuid).HasColumnName("UserGUID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserMfrequired).HasColumnName("UserMFRequired");

                entity.Property(e => e.UserMfsecret).HasColumnName("UserMFSecret");

                entity.Property(e => e.UserMftimestep).HasColumnName("UserMFTimestep");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasMaxLength(100);

                entity.Property(e => e.UserPasswordFormat).HasMaxLength(10);

                entity.Property(e => e.UserSecurityStamp).HasMaxLength(72);

                entity.Property(e => e.UserStartingAliasPath).HasMaxLength(200);

                entity.Property(e => e.VersionBinaryDataXml).HasColumnName("VersionBinaryDataXML");

                entity.Property(e => e.VersionDeletedByUserId).HasColumnName("VersionDeletedByUserID");

                entity.Property(e => e.VersionId).HasColumnName("VersionID");

                entity.Property(e => e.VersionModifiedByUserId).HasColumnName("VersionModifiedByUserID");

                entity.Property(e => e.VersionNumber).HasMaxLength(50);

                entity.Property(e => e.VersionObjectDisplayName).HasMaxLength(450);

                entity.Property(e => e.VersionObjectId).HasColumnName("VersionObjectID");

                entity.Property(e => e.VersionObjectSiteId).HasColumnName("VersionObjectSiteID");

                entity.Property(e => e.VersionObjectType).HasMaxLength(100);

                entity.Property(e => e.VersionSiteBindingIds).HasColumnName("VersionSiteBindingIDs");

                entity.Property(e => e.VersionXml).HasColumnName("VersionXML");
            });

            modelBuilder.Entity<ViewCmsPageTemplateCategoryPageTemplateJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_PageTemplateCategoryPageTemplate_Joined", "dbo");

                entity.Property(e => e.CategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.CodeName).HasMaxLength(200);

                entity.Property(e => e.DisplayName).HasMaxLength(200);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ObjectPath).HasMaxLength(551);

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PageTemplateIconClass).HasMaxLength(200);

                entity.Property(e => e.PageTemplateType).HasMaxLength(10);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<ViewCmsRelationshipJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_Relationship_Joined", "dbo");

                entity.Property(e => e.LeftClassId).HasColumnName("LeftClassID");

                entity.Property(e => e.LeftNodeGuid).HasColumnName("LeftNodeGUID");

                entity.Property(e => e.LeftNodeId).HasColumnName("LeftNodeID");

                entity.Property(e => e.LeftNodeName).HasMaxLength(100);

                entity.Property(e => e.LeftNodeSiteId).HasColumnName("LeftNodeSiteID");

                entity.Property(e => e.RelationshipDisplayName).HasMaxLength(200);

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.RelationshipName).HasMaxLength(200);

                entity.Property(e => e.RelationshipNameId).HasColumnName("RelationshipNameID");

                entity.Property(e => e.RightClassId).HasColumnName("RightClassID");

                entity.Property(e => e.RightNodeGuid).HasColumnName("RightNodeGUID");

                entity.Property(e => e.RightNodeId).HasColumnName("RightNodeID");

                entity.Property(e => e.RightNodeName).HasMaxLength(100);

                entity.Property(e => e.RightNodeSiteId).HasColumnName("RightNodeSiteID");
            });

            modelBuilder.Entity<ViewCmsResourceStringJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_ResourceString_Joined", "dbo");

                entity.Property(e => e.CultureCode).HasMaxLength(50);

                entity.Property(e => e.CultureGuid).HasColumnName("CultureGUID");

                entity.Property(e => e.CultureId).HasColumnName("CultureID");

                entity.Property(e => e.CultureName).HasMaxLength(200);

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.StringKey).HasMaxLength(200);

                entity.Property(e => e.TranslationCultureId).HasColumnName("TranslationCultureID");

                entity.Property(e => e.TranslationId).HasColumnName("TranslationID");

                entity.Property(e => e.TranslationStringId).HasColumnName("TranslationStringID");
            });

            modelBuilder.Entity<ViewCmsResourceTranslatedJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_ResourceTranslated_Joined", "dbo");

                entity.Property(e => e.CultureCode).HasMaxLength(50);

                entity.Property(e => e.CultureId).HasColumnName("CultureID");

                entity.Property(e => e.CultureName).HasMaxLength(200);

                entity.Property(e => e.StringId).HasColumnName("StringID");

                entity.Property(e => e.StringKey).HasMaxLength(200);
            });

            modelBuilder.Entity<ViewCmsRoleResourcePermissionJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_RoleResourcePermission_Joined", "dbo");

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.PermissionName).HasMaxLength(100);

                entity.Property(e => e.ResourceName).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<ViewCmsSiteDocumentCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_Site_DocumentCount", "dbo");

                entity.Property(e => e.SiteDefaultStylesheetId).HasColumnName("SiteDefaultStylesheetID");

                entity.Property(e => e.SiteDefaultVisitorCulture).HasMaxLength(50);

                entity.Property(e => e.SiteDisplayName).HasMaxLength(200);

                entity.Property(e => e.SiteDomainName).HasMaxLength(400);

                entity.Property(e => e.SiteGuid).HasColumnName("SiteGUID");

                entity.Property(e => e.SiteId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SiteID");

                entity.Property(e => e.SiteName).HasMaxLength(100);

                entity.Property(e => e.SiteStatus).HasMaxLength(20);
            });

            modelBuilder.Entity<ViewCmsSiteRoleResourceUielementJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_SiteRoleResourceUIElement_Joined", "dbo");

                entity.Property(e => e.ElementName).HasMaxLength(200);

                entity.Property(e => e.ResourceName).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(100);

                entity.Property(e => e.RoleSiteId).HasColumnName("RoleSiteID");

                entity.Property(e => e.SiteName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewCmsTreeJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_Tree_Joined", "dbo");

                entity.Property(e => e.ClassDisplayName).HasMaxLength(100);

                entity.Property(e => e.ClassName).HasMaxLength(100);

                entity.Property(e => e.DocumentAbtestConfiguration).HasColumnName("DocumentABTestConfiguration");

                entity.Property(e => e.DocumentCheckedOutByUserId).HasColumnName("DocumentCheckedOutByUserID");

                entity.Property(e => e.DocumentCheckedOutVersionHistoryId).HasColumnName("DocumentCheckedOutVersionHistoryID");

                entity.Property(e => e.DocumentConversionValue).HasMaxLength(100);

                entity.Property(e => e.DocumentCreatedByUserId).HasColumnName("DocumentCreatedByUserID");

                entity.Property(e => e.DocumentCulture).HasMaxLength(10);

                entity.Property(e => e.DocumentExtensions).HasMaxLength(100);

                entity.Property(e => e.DocumentGuid).HasColumnName("DocumentGUID");

                entity.Property(e => e.DocumentHash).HasMaxLength(32);

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.DocumentLastVersionNumber).HasMaxLength(50);

                entity.Property(e => e.DocumentMenuCaption).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuClass).HasMaxLength(100);

                entity.Property(e => e.DocumentMenuClassHighlighted).HasMaxLength(100);

                entity.Property(e => e.DocumentMenuItemImage).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemImageHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemLeftImage).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemLeftImageHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemRightImage).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuItemRightImageHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentMenuJavascript).HasMaxLength(450);

                entity.Property(e => e.DocumentMenuRedirectUrl).HasMaxLength(450);

                entity.Property(e => e.DocumentMenuStyle).HasMaxLength(100);

                entity.Property(e => e.DocumentMenuStyleHighlighted).HasMaxLength(200);

                entity.Property(e => e.DocumentModifiedByUserId).HasColumnName("DocumentModifiedByUserID");

                entity.Property(e => e.DocumentName).HasMaxLength(100);

                entity.Property(e => e.DocumentNamePath).HasMaxLength(1500);

                entity.Property(e => e.DocumentNodeId).HasColumnName("DocumentNodeID");

                entity.Property(e => e.DocumentPageTemplateId).HasColumnName("DocumentPageTemplateID");

                entity.Property(e => e.DocumentPublishedVersionHistoryId).HasColumnName("DocumentPublishedVersionHistoryID");

                entity.Property(e => e.DocumentSitemapSettings).HasMaxLength(100);

                entity.Property(e => e.DocumentSkudescription).HasColumnName("DocumentSKUDescription");

                entity.Property(e => e.DocumentSkuname)
                    .HasMaxLength(440)
                    .HasColumnName("DocumentSKUName");

                entity.Property(e => e.DocumentSkushortDescription).HasColumnName("DocumentSKUShortDescription");

                entity.Property(e => e.DocumentStylesheetId).HasColumnName("DocumentStylesheetID");

                entity.Property(e => e.DocumentTagGroupId).HasColumnName("DocumentTagGroupID");

                entity.Property(e => e.DocumentTrackConversionName).HasMaxLength(200);

                entity.Property(e => e.DocumentType).HasMaxLength(50);

                entity.Property(e => e.DocumentUrlPath).HasMaxLength(450);

                entity.Property(e => e.DocumentWildcardRule).HasMaxLength(440);

                entity.Property(e => e.DocumentWorkflowActionStatus).HasMaxLength(450);

                entity.Property(e => e.DocumentWorkflowCycleGuid).HasColumnName("DocumentWorkflowCycleGUID");

                entity.Property(e => e.DocumentWorkflowStepId).HasColumnName("DocumentWorkflowStepID");

                entity.Property(e => e.NodeAclid).HasColumnName("NodeACLID");

                entity.Property(e => e.NodeAlias).HasMaxLength(50);

                entity.Property(e => e.NodeAliasPath).HasMaxLength(450);

                entity.Property(e => e.NodeClassId).HasColumnName("NodeClassID");

                entity.Property(e => e.NodeGroupId).HasColumnName("NodeGroupID");

                entity.Property(e => e.NodeGuid).HasColumnName("NodeGUID");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.Property(e => e.NodeInheritPageLevels).HasMaxLength(200);

                entity.Property(e => e.NodeIsAclowner).HasColumnName("NodeIsACLOwner");

                entity.Property(e => e.NodeLinkedNodeId).HasColumnName("NodeLinkedNodeID");

                entity.Property(e => e.NodeLinkedNodeSiteId).HasColumnName("NodeLinkedNodeSiteID");

                entity.Property(e => e.NodeName).HasMaxLength(100);

                entity.Property(e => e.NodeOriginalNodeId).HasColumnName("NodeOriginalNodeID");

                entity.Property(e => e.NodeParentId).HasColumnName("NodeParentID");

                entity.Property(e => e.NodeSiteId).HasColumnName("NodeSiteID");

                entity.Property(e => e.NodeSkuid).HasColumnName("NodeSKUID");

                entity.Property(e => e.NodeTemplateId).HasColumnName("NodeTemplateID");

                entity.Property(e => e.RequiresSsl).HasColumnName("RequiresSSL");
            });

            modelBuilder.Entity<ViewCmsUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_User", "dbo");

                entity.Property(e => e.AvatarFileName).HasMaxLength(200);

                entity.Property(e => e.AvatarGuid).HasColumnName("AvatarGUID");

                entity.Property(e => e.AvatarId).HasColumnName("AvatarID");

                entity.Property(e => e.Email).HasMaxLength(254);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(450);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.PreferredCultureCode).HasMaxLength(10);

                entity.Property(e => e.PreferredUicultureCode)
                    .HasMaxLength(10)
                    .HasColumnName("PreferredUICultureCode");

                entity.Property(e => e.UserActivatedByUserId).HasColumnName("UserActivatedByUserID");

                entity.Property(e => e.UserAuthenticationGuid).HasColumnName("UserAuthenticationGUID");

                entity.Property(e => e.UserAvatarId).HasColumnName("UserAvatarID");

                entity.Property(e => e.UserAvatarType).HasMaxLength(200);

                entity.Property(e => e.UserBadgeId).HasColumnName("UserBadgeID");

                entity.Property(e => e.UserCampaign).HasMaxLength(200);

                entity.Property(e => e.UserFacebookId)
                    .HasMaxLength(100)
                    .HasColumnName("UserFacebookID");

                entity.Property(e => e.UserGuid).HasColumnName("UserGUID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIm)
                    .HasMaxLength(100)
                    .HasColumnName("UserIM");

                entity.Property(e => e.UserInvalidLogOnAttemptsHash).HasMaxLength(100);

                entity.Property(e => e.UserLinkedInId)
                    .HasMaxLength(100)
                    .HasColumnName("UserLinkedInID");

                entity.Property(e => e.UserMfrequired).HasColumnName("UserMFRequired");

                entity.Property(e => e.UserMfsecret).HasColumnName("UserMFSecret");

                entity.Property(e => e.UserMftimestep).HasColumnName("UserMFTimestep");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserNickName).HasMaxLength(200);

                entity.Property(e => e.UserPassword).HasMaxLength(100);

                entity.Property(e => e.UserPasswordFormat).HasMaxLength(10);

                entity.Property(e => e.UserPasswordRequestHash).HasMaxLength(100);

                entity.Property(e => e.UserPhone).HasMaxLength(26);

                entity.Property(e => e.UserPicture).HasMaxLength(200);

                entity.Property(e => e.UserPosition).HasMaxLength(200);

                entity.Property(e => e.UserSecurityStamp).HasMaxLength(72);

                entity.Property(e => e.UserSettingsId).HasColumnName("UserSettingsID");

                entity.Property(e => e.UserSettingsUserGuid).HasColumnName("UserSettingsUserGUID");

                entity.Property(e => e.UserSettingsUserId).HasColumnName("UserSettingsUserID");

                entity.Property(e => e.UserSkype).HasMaxLength(100);

                entity.Property(e => e.UserStartingAliasPath).HasMaxLength(200);

                entity.Property(e => e.UserTimeZoneId).HasColumnName("UserTimeZoneID");

                entity.Property(e => e.UserUrlreferrer)
                    .HasMaxLength(450)
                    .HasColumnName("UserURLReferrer");

                entity.Property(e => e.UserUsedWebParts).HasMaxLength(1000);

                entity.Property(e => e.UserUsedWidgets).HasMaxLength(1000);

                entity.Property(e => e.WindowsLiveId)
                    .HasMaxLength(50)
                    .HasColumnName("WindowsLiveID");
            });

            modelBuilder.Entity<ViewCmsUserDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_UserDocuments", "dbo");

                entity.Property(e => e.ClassDisplayName).HasMaxLength(100);

                entity.Property(e => e.ClassName).HasMaxLength(100);

                entity.Property(e => e.CultureName).HasMaxLength(200);

                entity.Property(e => e.DocumentCulture).HasMaxLength(10);

                entity.Property(e => e.DocumentName).HasMaxLength(450);

                entity.Property(e => e.DocumentNamePath).HasMaxLength(1500);

                entity.Property(e => e.DocumentWorkflowStepId).HasColumnName("DocumentWorkflowStepID");

                entity.Property(e => e.NodeAliasPath).HasMaxLength(450);

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.Property(e => e.NodeSiteId).HasColumnName("NodeSiteID");

                entity.Property(e => e.Type)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UserId1).HasColumnName("UserID1");

                entity.Property(e => e.UserId2).HasColumnName("UserID2");

                entity.Property(e => e.UserId3).HasColumnName("UserID3");
            });

            modelBuilder.Entity<ViewCmsUserRoleJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_UserRole_Joined", "dbo");

                entity.Property(e => e.FullName).HasMaxLength(450);

                entity.Property(e => e.RoleDisplayName).HasMaxLength(100);

                entity.Property(e => e.RoleGroupId).HasColumnName("RoleGroupID");

                entity.Property(e => e.RoleGuid).HasColumnName("RoleGUID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(100);

                entity.Property(e => e.SiteGuid).HasColumnName("SiteGUID");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SiteName).HasMaxLength(100);

                entity.Property(e => e.UserGuid).HasColumnName("UserGUID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewCmsUserRoleMembershipRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_UserRoleMembershipRole", "dbo");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(100);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ViewCmsUserRoleMembershipRoleValidOnlyJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_UserRole_MembershipRole_ValidOnly_Joined", "dbo");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ViewCmsUserSettingsRoleJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_UserSettingsRole_Joined", "dbo");

                entity.Property(e => e.Email).HasMaxLength(254);

                entity.Property(e => e.FullName).HasMaxLength(450);

                entity.Property(e => e.RoleDisplayName).HasMaxLength(100);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName).HasMaxLength(100);

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.SiteName).HasMaxLength(100);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewCmsWebPartCategoryWebpartJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_WebPartCategoryWebpart_Joined", "dbo");

                entity.Property(e => e.CategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.CodeName).HasMaxLength(100);

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.IconClass).HasMaxLength(200);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ObjectPath).HasMaxLength(551);

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ThumbnailGuid).HasColumnName("ThumbnailGUID");

                entity.Property(e => e.WebPartDescription).HasMaxLength(1000);

                entity.Property(e => e.WebPartFileName).HasMaxLength(100);

                entity.Property(e => e.WebPartGuid).HasColumnName("WebPartGUID");

                entity.Property(e => e.WebPartParentId).HasColumnName("WebPartParentID");
            });

            modelBuilder.Entity<ViewCmsWidgetCategoryWidgetJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_CMS_WidgetCategoryWidget_Joined", "dbo");

                entity.Property(e => e.CodeName).HasMaxLength(100);

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ObjectPath).HasMaxLength(551);

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.WidgetCategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.WidgetGuid).HasColumnName("WidgetGUID");

                entity.Property(e => e.WidgetWebPartId).HasColumnName("WidgetWebPartID");
            });

            modelBuilder.Entity<ViewComSkuoptionCategoryOptionCategoryJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_COM_SKUOptionCategory_OptionCategory_Joined", "dbo");

                entity.Property(e => e.CategoryDefaultOptions).HasMaxLength(200);

                entity.Property(e => e.CategoryDefaultRecord).HasMaxLength(200);

                entity.Property(e => e.CategoryDisplayName).HasMaxLength(200);

                entity.Property(e => e.CategoryGuid).HasColumnName("CategoryGUID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryLiveSiteDisplayName).HasMaxLength(200);

                entity.Property(e => e.CategoryName).HasMaxLength(200);

                entity.Property(e => e.CategorySelectionType).HasMaxLength(200);

                entity.Property(e => e.CategorySiteId).HasColumnName("CategorySiteID");

                entity.Property(e => e.CategoryType).HasMaxLength(20);

                entity.Property(e => e.SkucategoryId).HasColumnName("SKUCategoryID");

                entity.Property(e => e.SkucategoryOrder).HasColumnName("SKUCategoryOrder");

                entity.Property(e => e.Skuid).HasColumnName("SKUID");
            });

            modelBuilder.Entity<ViewCommunityGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Community_Group", "dbo");

                entity.Property(e => e.AvatarFileName).HasMaxLength(200);

                entity.Property(e => e.AvatarGuid).HasColumnName("AvatarGUID");

                entity.Property(e => e.AvatarId).HasColumnName("AvatarID");

                entity.Property(e => e.GroupApprovedByUserId).HasColumnName("GroupApprovedByUserID");

                entity.Property(e => e.GroupAvatarId).HasColumnName("GroupAvatarID");

                entity.Property(e => e.GroupCreatedByUserId).HasColumnName("GroupCreatedByUserID");

                entity.Property(e => e.GroupDisplayName).HasMaxLength(200);

                entity.Property(e => e.GroupGuid).HasColumnName("GroupGUID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.GroupNodeGuid).HasColumnName("GroupNodeGUID");

                entity.Property(e => e.GroupSiteId).HasColumnName("GroupSiteID");
            });

            modelBuilder.Entity<ViewCommunityMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Community_Member", "dbo");

                entity.Property(e => e.AvatarGuid).HasColumnName("AvatarGUID");

                entity.Property(e => e.AvatarId).HasColumnName("AvatarID");

                entity.Property(e => e.AvatarName).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(254);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(450);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MemberApprovedByUserId).HasColumnName("MemberApprovedByUserID");

                entity.Property(e => e.MemberGroupId).HasColumnName("MemberGroupID");

                entity.Property(e => e.MemberGuid).HasColumnName("MemberGUID");

                entity.Property(e => e.MemberId).HasColumnName("MemberID");

                entity.Property(e => e.MemberInvitedByUserId).HasColumnName("MemberInvitedByUserID");

                entity.Property(e => e.MemberUserId).HasColumnName("MemberUserID");

                entity.Property(e => e.MiddleName).HasMaxLength(100);

                entity.Property(e => e.PreferredCultureCode).HasMaxLength(10);

                entity.Property(e => e.PreferredUicultureCode)
                    .HasMaxLength(10)
                    .HasColumnName("PreferredUICultureCode");

                entity.Property(e => e.SiteId).HasColumnName("SiteID");

                entity.Property(e => e.UserActivatedByUserId).HasColumnName("UserActivatedByUserID");

                entity.Property(e => e.UserAuthenticationGuid).HasColumnName("UserAuthenticationGUID");

                entity.Property(e => e.UserAvatarId).HasColumnName("UserAvatarID");

                entity.Property(e => e.UserAvatarType).HasMaxLength(200);

                entity.Property(e => e.UserBadgeId).HasColumnName("UserBadgeID");

                entity.Property(e => e.UserCampaign).HasMaxLength(200);

                entity.Property(e => e.UserFacebookId)
                    .HasMaxLength(100)
                    .HasColumnName("UserFacebookID");

                entity.Property(e => e.UserGuid).HasColumnName("UserGUID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIm)
                    .HasMaxLength(100)
                    .HasColumnName("UserIM");

                entity.Property(e => e.UserInvalidLogOnAttemptsHash).HasMaxLength(100);

                entity.Property(e => e.UserLinkedInId)
                    .HasMaxLength(100)
                    .HasColumnName("UserLinkedInID");

                entity.Property(e => e.UserMfrequired).HasColumnName("UserMFRequired");

                entity.Property(e => e.UserMfsecret).HasColumnName("UserMFSecret");

                entity.Property(e => e.UserMftimestep).HasColumnName("UserMFTimestep");

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserNickName).HasMaxLength(200);

                entity.Property(e => e.UserPassword).HasMaxLength(100);

                entity.Property(e => e.UserPasswordFormat).HasMaxLength(10);

                entity.Property(e => e.UserPasswordRequestHash).HasMaxLength(100);

                entity.Property(e => e.UserPhone).HasMaxLength(26);

                entity.Property(e => e.UserPicture).HasMaxLength(200);

                entity.Property(e => e.UserPosition).HasMaxLength(200);

                entity.Property(e => e.UserSecurityStamp).HasMaxLength(72);

                entity.Property(e => e.UserSettingsId).HasColumnName("UserSettingsID");

                entity.Property(e => e.UserSettingsUserGuid).HasColumnName("UserSettingsUserGUID");

                entity.Property(e => e.UserSettingsUserId).HasColumnName("UserSettingsUserID");

                entity.Property(e => e.UserSkype).HasMaxLength(100);

                entity.Property(e => e.UserStartingAliasPath).HasMaxLength(200);

                entity.Property(e => e.UserTimeZoneId).HasColumnName("UserTimeZoneID");

                entity.Property(e => e.UserUrlreferrer)
                    .HasMaxLength(450)
                    .HasColumnName("UserURLReferrer");

                entity.Property(e => e.UserUsedWebParts).HasMaxLength(1000);

                entity.Property(e => e.UserUsedWidgets).HasMaxLength(1000);

                entity.Property(e => e.WindowsLiveId)
                    .HasMaxLength(50)
                    .HasColumnName("WindowsLiveID");
            });

            modelBuilder.Entity<ViewForumsGroupForumPostJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Forums_GroupForumPost_Joined", "dbo");

                entity.Property(e => e.ForumBaseUrl).HasMaxLength(200);

                entity.Property(e => e.ForumDisplayName).HasMaxLength(200);

                entity.Property(e => e.ForumDocumentId).HasColumnName("ForumDocumentID");

                entity.Property(e => e.ForumGroupId).HasColumnName("ForumGroupID");

                entity.Property(e => e.ForumGuid).HasColumnName("ForumGUID");

                entity.Property(e => e.ForumHtmleditor).HasColumnName("ForumHTMLEditor");

                entity.Property(e => e.ForumId).HasColumnName("ForumID");

                entity.Property(e => e.ForumLastPostUserName).HasMaxLength(200);

                entity.Property(e => e.ForumLastPostUserNameAbsolute).HasMaxLength(200);

                entity.Property(e => e.ForumName).HasMaxLength(200);

                entity.Property(e => e.ForumSiteId).HasColumnName("ForumSiteID");

                entity.Property(e => e.ForumUnsubscriptionUrl).HasMaxLength(200);

                entity.Property(e => e.ForumUseCaptcha).HasColumnName("ForumUseCAPTCHA");

                entity.Property(e => e.GroupBaseUrl).HasMaxLength(200);

                entity.Property(e => e.GroupDisplayName).HasMaxLength(200);

                entity.Property(e => e.GroupGroupId).HasColumnName("GroupGroupID");

                entity.Property(e => e.GroupGuid).HasColumnName("GroupGUID");

                entity.Property(e => e.GroupHtmleditor).HasColumnName("GroupHTMLEditor");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.GroupSiteId).HasColumnName("GroupSiteID");

                entity.Property(e => e.GroupUnsubscriptionUrl).HasMaxLength(200);

                entity.Property(e => e.GroupUseCaptcha).HasColumnName("GroupUseCAPTCHA");

                entity.Property(e => e.PostApprovedByUserId).HasColumnName("PostApprovedByUserID");

                entity.Property(e => e.PostForumId).HasColumnName("PostForumID");

                entity.Property(e => e.PostGuid).HasColumnName("PostGUID");

                entity.Property(e => e.PostIdpath)
                    .HasMaxLength(450)
                    .HasColumnName("PostIDPath");

                entity.Property(e => e.PostParentId).HasColumnName("PostParentID");

                entity.Property(e => e.PostSubject).HasMaxLength(450);

                entity.Property(e => e.PostThreadLastPostUserName).HasMaxLength(200);

                entity.Property(e => e.PostThreadLastPostUserNameAbsolute).HasMaxLength(200);

                entity.Property(e => e.PostUserId).HasColumnName("PostUserID");

                entity.Property(e => e.PostUserMail).HasMaxLength(254);

                entity.Property(e => e.PostUserName).HasMaxLength(200);
            });

            modelBuilder.Entity<ViewIntegrationTaskJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Integration_Task_Joined", "dbo");

                entity.Property(e => e.SynchronizationConnectorId).HasColumnName("SynchronizationConnectorID");

                entity.Property(e => e.SynchronizationId).HasColumnName("SynchronizationID");

                entity.Property(e => e.SynchronizationTaskId).HasColumnName("SynchronizationTaskID");

                entity.Property(e => e.TaskDataType).HasMaxLength(50);

                entity.Property(e => e.TaskDocumentId).HasColumnName("TaskDocumentID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.TaskNodeAliasPath).HasMaxLength(450);

                entity.Property(e => e.TaskNodeId).HasColumnName("TaskNodeID");

                entity.Property(e => e.TaskObjectId).HasColumnName("TaskObjectID");

                entity.Property(e => e.TaskObjectType).HasMaxLength(100);

                entity.Property(e => e.TaskProcessType).HasMaxLength(50);

                entity.Property(e => e.TaskSiteId).HasColumnName("TaskSiteID");

                entity.Property(e => e.TaskTitle).HasMaxLength(450);

                entity.Property(e => e.TaskType).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewMembershipMembershipUserJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Membership_MembershipUser_Joined", "dbo");

                entity.Property(e => e.FullName).HasMaxLength(450);

                entity.Property(e => e.MembershipDisplayName).HasMaxLength(200);

                entity.Property(e => e.MembershipId).HasColumnName("MembershipID");

                entity.Property(e => e.MembershipSiteId).HasColumnName("MembershipSiteID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewNewsletterSubscriptionsJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Newsletter_Subscriptions_Joined", "dbo");

                entity.Property(e => e.NewsletterDisplayName).HasMaxLength(250);

                entity.Property(e => e.NewsletterId).HasColumnName("NewsletterID");

                entity.Property(e => e.SubscriberEmail).HasMaxLength(254);

                entity.Property(e => e.SubscriberFullName).HasMaxLength(440);

                entity.Property(e => e.SubscriberId).HasColumnName("SubscriberID");

                entity.Property(e => e.SubscriberNewsletterId).HasColumnName("SubscriberNewsletterID");

                entity.Property(e => e.SubscriberRelatedId).HasColumnName("SubscriberRelatedID");

                entity.Property(e => e.SubscriberType).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewOmAccountContactAccountJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OM_AccountContact_AccountJoined", "dbo");

                entity.Property(e => e.AccountContactId).HasColumnName("AccountContactID");

                entity.Property(e => e.AccountCountryId).HasColumnName("AccountCountryID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName).HasMaxLength(200);

                entity.Property(e => e.AccountStatusId).HasColumnName("AccountStatusID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactRoleId).HasColumnName("ContactRoleID");
            });

            modelBuilder.Entity<ViewOmAccountContactContactJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OM_AccountContact_ContactJoined", "dbo");

                entity.Property(e => e.AccountContactId).HasColumnName("AccountContactID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.ContactCountryId).HasColumnName("ContactCountryID");

                entity.Property(e => e.ContactEmail).HasMaxLength(254);

                entity.Property(e => e.ContactFirstName).HasMaxLength(100);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ContactLastName).HasMaxLength(100);

                entity.Property(e => e.ContactMiddleName).HasMaxLength(100);

                entity.Property(e => e.ContactRoleId).HasColumnName("ContactRoleID");

                entity.Property(e => e.ContactStatusId).HasColumnName("ContactStatusID");
            });

            modelBuilder.Entity<ViewOmAccountJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OM_Account_Joined", "dbo");

                entity.Property(e => e.AccountAddress1).HasMaxLength(100);

                entity.Property(e => e.AccountAddress2).HasMaxLength(100);

                entity.Property(e => e.AccountCity).HasMaxLength(100);

                entity.Property(e => e.AccountCountryId).HasColumnName("AccountCountryID");

                entity.Property(e => e.AccountEmail).HasMaxLength(254);

                entity.Property(e => e.AccountFax).HasMaxLength(26);

                entity.Property(e => e.AccountFullAddress).HasMaxLength(201);

                entity.Property(e => e.AccountGuid).HasColumnName("AccountGUID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName).HasMaxLength(200);

                entity.Property(e => e.AccountOwnerUserId).HasColumnName("AccountOwnerUserID");

                entity.Property(e => e.AccountPhone).HasMaxLength(26);

                entity.Property(e => e.AccountPrimaryContactId).HasColumnName("AccountPrimaryContactID");

                entity.Property(e => e.AccountSecondaryContactId).HasColumnName("AccountSecondaryContactID");

                entity.Property(e => e.AccountStateId).HasColumnName("AccountStateID");

                entity.Property(e => e.AccountStatusId).HasColumnName("AccountStatusID");

                entity.Property(e => e.AccountSubsidiaryOfId).HasColumnName("AccountSubsidiaryOfID");

                entity.Property(e => e.AccountWebSite).HasMaxLength(200);

                entity.Property(e => e.AccountZip)
                    .HasMaxLength(20)
                    .HasColumnName("AccountZIP");

                entity.Property(e => e.PrimaryContactFirstName).HasMaxLength(100);

                entity.Property(e => e.PrimaryContactFullName).HasMaxLength(302);

                entity.Property(e => e.PrimaryContactLastName).HasMaxLength(100);

                entity.Property(e => e.PrimaryContactMiddleName).HasMaxLength(100);

                entity.Property(e => e.SecondaryContactFirstName).HasMaxLength(100);

                entity.Property(e => e.SecondaryContactFullName).HasMaxLength(302);

                entity.Property(e => e.SecondaryContactLastName).HasMaxLength(100);

                entity.Property(e => e.SecondaryContactMiddleName).HasMaxLength(100);

                entity.Property(e => e.SubsidiaryOfName).HasMaxLength(200);
            });

            modelBuilder.Entity<ViewOmContactGroupMemberAccountJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OM_ContactGroupMember_AccountJoined", "dbo");

                entity.Property(e => e.AccountAddress1).HasMaxLength(100);

                entity.Property(e => e.AccountAddress2).HasMaxLength(100);

                entity.Property(e => e.AccountCity).HasMaxLength(100);

                entity.Property(e => e.AccountCountryId).HasColumnName("AccountCountryID");

                entity.Property(e => e.AccountEmail).HasMaxLength(254);

                entity.Property(e => e.AccountFax).HasMaxLength(26);

                entity.Property(e => e.AccountGuid).HasColumnName("AccountGUID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName).HasMaxLength(200);

                entity.Property(e => e.AccountOwnerUserId).HasColumnName("AccountOwnerUserID");

                entity.Property(e => e.AccountPhone).HasMaxLength(26);

                entity.Property(e => e.AccountPrimaryContactId).HasColumnName("AccountPrimaryContactID");

                entity.Property(e => e.AccountSecondaryContactId).HasColumnName("AccountSecondaryContactID");

                entity.Property(e => e.AccountStateId).HasColumnName("AccountStateID");

                entity.Property(e => e.AccountStatusId).HasColumnName("AccountStatusID");

                entity.Property(e => e.AccountSubsidiaryOfId).HasColumnName("AccountSubsidiaryOfID");

                entity.Property(e => e.AccountWebSite).HasMaxLength(200);

                entity.Property(e => e.AccountZip)
                    .HasMaxLength(20)
                    .HasColumnName("AccountZIP");

                entity.Property(e => e.ContactGroupMemberContactGroupId).HasColumnName("ContactGroupMemberContactGroupID");

                entity.Property(e => e.ContactGroupMemberId).HasColumnName("ContactGroupMemberID");
            });

            modelBuilder.Entity<ViewPollAnswerCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Poll_AnswerCount", "dbo");

                entity.Property(e => e.PollCodeName).HasMaxLength(200);

                entity.Property(e => e.PollDisplayName).HasMaxLength(200);

                entity.Property(e => e.PollGroupId).HasColumnName("PollGroupID");

                entity.Property(e => e.PollGuid).HasColumnName("PollGUID");

                entity.Property(e => e.PollId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PollID");

                entity.Property(e => e.PollQuestion).HasMaxLength(450);

                entity.Property(e => e.PollResponseMessage).HasMaxLength(450);

                entity.Property(e => e.PollSiteId).HasColumnName("PollSiteID");

                entity.Property(e => e.PollTitle).HasMaxLength(100);
            });

            modelBuilder.Entity<ViewReportingCategoryReportJoined>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Reporting_CategoryReport_Joined", "dbo");

                entity.Property(e => e.CategoryImagePath).HasMaxLength(450);

                entity.Property(e => e.CodeName).HasMaxLength(200);

                entity.Property(e => e.DisplayName).HasMaxLength(440);

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ObjectPath).HasMaxLength(651);

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
