using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsSite
    {
        public CmsSite()
        {
            AnalyticsCampaigns = new HashSet<AnalyticsCampaign>();
            AnalyticsConversions = new HashSet<AnalyticsConversion>();
            AnalyticsStatistics = new HashSet<AnalyticsStatistic>();
            BoardBoards = new HashSet<BoardBoard>();
            ChatNotifications = new HashSet<ChatNotification>();
            ChatOnlineSupports = new HashSet<ChatOnlineSupport>();
            ChatOnlineUsers = new HashSet<ChatOnlineUser>();
            ChatRooms = new HashSet<ChatRoom>();
            ChatSupportCannedResponses = new HashSet<ChatSupportCannedResponse>();
            CmsAbuseReports = new HashSet<CmsAbuseReport>();
            CmsAcls = new HashSet<CmsAcl>();
            CmsAlternativeUrls = new HashSet<CmsAlternativeUrl>();
            CmsAttachmentHistories = new HashSet<CmsAttachmentHistory>();
            CmsAttachments = new HashSet<CmsAttachment>();
            CmsAutomationStates = new HashSet<CmsAutomationState>();
            CmsBannedIps = new HashSet<CmsBannedIp>();
            CmsBannerCategories = new HashSet<CmsBannerCategory>();
            CmsBanners = new HashSet<CmsBanner>();
            CmsCategories = new HashSet<CmsCategory>();
            CmsDocumentAliases = new HashSet<CmsDocumentAlias>();
            CmsDocumentTypeScopes = new HashSet<CmsDocumentTypeScope>();
            CmsEmailTemplates = new HashSet<CmsEmailTemplate>();
            CmsForms = new HashSet<CmsForm>();
            CmsMemberships = new HashSet<CmsMembership>();
            CmsMetaFiles = new HashSet<CmsMetaFile>();
            CmsObjectVersionHistories = new HashSet<CmsObjectVersionHistory>();
            CmsPageTemplateConfigurations = new HashSet<CmsPageTemplateConfiguration>();
            CmsPageTemplateScopes = new HashSet<CmsPageTemplateScope>();
            CmsPageTemplates = new HashSet<CmsPageTemplate>();
            CmsPersonalizations = new HashSet<CmsPersonalization>();
            CmsRoles = new HashSet<CmsRole>();
            CmsScheduledTasks = new HashSet<CmsScheduledTask>();
            CmsSessions = new HashSet<CmsSession>();
            CmsSettingsKeys = new HashSet<CmsSettingsKey>();
            CmsSiteDomainAliases = new HashSet<CmsSiteDomainAlias>();
            CmsTagGroups = new HashSet<CmsTagGroup>();
            CmsTreeNodeLinkedNodeSites = new HashSet<CmsTree>();
            CmsTreeNodeSites = new HashSet<CmsTree>();
            CmsUserCultures = new HashSet<CmsUserCulture>();
            CmsUserSites = new HashSet<CmsUserSite>();
            CmsVersionHistories = new HashSet<CmsVersionHistory>();
            CmsWorkflowScopes = new HashSet<CmsWorkflowScope>();
            ComBrands = new HashSet<ComBrand>();
            ComCarriers = new HashSet<ComCarrier>();
            ComCollections = new HashSet<ComCollection>();
            ComCurrencies = new HashSet<ComCurrency>();
            ComCustomerCreditHistories = new HashSet<ComCustomerCreditHistory>();
            ComCustomers = new HashSet<ComCustomer>();
            ComDepartments = new HashSet<ComDepartment>();
            ComDiscounts = new HashSet<ComDiscount>();
            ComExchangeTables = new HashSet<ComExchangeTable>();
            ComGiftCards = new HashSet<ComGiftCard>();
            ComInternalStatuses = new HashSet<ComInternalStatus>();
            ComManufacturers = new HashSet<ComManufacturer>();
            ComMultiBuyDiscounts = new HashSet<ComMultiBuyDiscount>();
            ComOptionCategories = new HashSet<ComOptionCategory>();
            ComOrderStatuses = new HashSet<ComOrderStatus>();
            ComOrders = new HashSet<ComOrder>();
            ComPaymentOptions = new HashSet<ComPaymentOption>();
            ComPublicStatuses = new HashSet<ComPublicStatus>();
            ComShippingOptions = new HashSet<ComShippingOption>();
            ComShoppingCarts = new HashSet<ComShoppingCart>();
            ComSkus = new HashSet<ComSku>();
            ComSuppliers = new HashSet<ComSupplier>();
            ComTaxClasses = new HashSet<ComTaxClass>();
            ComWishlists = new HashSet<ComWishlist>();
            CommunityGroups = new HashSet<CommunityGroup>();
            ExportHistories = new HashSet<ExportHistory>();
            ExportTasks = new HashSet<ExportTask>();
            ForumsAttachments = new HashSet<ForumsAttachment>();
            ForumsForumGroups = new HashSet<ForumsForumGroup>();
            ForumsForums = new HashSet<ForumsForum>();
            ForumsUserFavorites = new HashSet<ForumsUserFavorite>();
            IntegrationTasks = new HashSet<IntegrationTask>();
            MediaFiles = new HashSet<MediaFile>();
            MediaLibraries = new HashSet<MediaLibrary>();
            NewsletterEmailTemplates = new HashSet<NewsletterEmailTemplate>();
            NewsletterEmailWidgets = new HashSet<NewsletterEmailWidget>();
            NewsletterEmails = new HashSet<NewsletterEmail>();
            NewsletterNewsletterIssues = new HashSet<NewsletterNewsletterIssue>();
            NewsletterNewsletters = new HashSet<NewsletterNewsletter>();
            NewsletterSubscribers = new HashSet<NewsletterSubscriber>();
            NotificationSubscriptions = new HashSet<NotificationSubscription>();
            NotificationTemplates = new HashSet<NotificationTemplate>();
            OmAbtests = new HashSet<OmAbtest>();
            OmAbvariants = new HashSet<OmAbvariant>();
            OmMvtests = new HashSet<OmMvtest>();
            PollsPolls = new HashSet<PollsPoll>();
            ReportingReportSubscriptions = new HashSet<ReportingReportSubscription>();
            SharePointSharePointConnections = new HashSet<SharePointSharePointConnection>();
            SharePointSharePointFiles = new HashSet<SharePointSharePointFile>();
            SharePointSharePointLibraries = new HashSet<SharePointSharePointLibrary>();
            SmFacebookAccounts = new HashSet<SmFacebookAccount>();
            SmFacebookApplications = new HashSet<SmFacebookApplication>();
            SmFacebookPosts = new HashSet<SmFacebookPost>();
            SmLinkedInApplications = new HashSet<SmLinkedInApplication>();
            SmLinkedInPosts = new HashSet<SmLinkedInPost>();
            SmTwitterAccounts = new HashSet<SmTwitterAccount>();
            SmTwitterApplications = new HashSet<SmTwitterApplication>();
            SmTwitterPosts = new HashSet<SmTwitterPost>();
            StagingServers = new HashSet<StagingServer>();
            StagingTasks = new HashSet<StagingTask>();
            Classes = new HashSet<CmsClass>();
            Containers = new HashSet<CmsWebPartContainer>();
            Cultures = new HashSet<CmsCulture>();
            Indices = new HashSet<CmsSearchIndex>();
            PageTemplates = new HashSet<CmsPageTemplate>();
            Polls = new HashSet<PollsPoll>();
            RelationshipNames = new HashSet<CmsRelationshipName>();
            Resources = new HashSet<CmsResource>();
            Servers = new HashSet<CmsSmtpserver>();
            Stylesheets = new HashSet<CmsCssStylesheet>();
        }

        public int SiteId { get; set; }
        public string SiteName { get; set; } = null!;
        public string SiteDisplayName { get; set; } = null!;
        public string? SiteDescription { get; set; }
        public string SiteStatus { get; set; } = null!;
        public string SiteDomainName { get; set; } = null!;
        public int? SiteDefaultStylesheetId { get; set; }
        public string? SiteDefaultVisitorCulture { get; set; }
        public int? SiteDefaultEditorStylesheet { get; set; }
        public Guid SiteGuid { get; set; }
        public DateTime SiteLastModified { get; set; }
        public bool? SiteIsOffline { get; set; }
        public string? SiteOfflineRedirectUrl { get; set; }
        public string? SiteOfflineMessage { get; set; }
        public string? SitePresentationUrl { get; set; }
        public bool? SiteIsContentOnly { get; set; }

        public virtual CmsCssStylesheet? SiteDefaultEditorStylesheetNavigation { get; set; }
        public virtual CmsCssStylesheet? SiteDefaultStylesheet { get; set; }
        public virtual ICollection<AnalyticsCampaign> AnalyticsCampaigns { get; set; }
        public virtual ICollection<AnalyticsConversion> AnalyticsConversions { get; set; }
        public virtual ICollection<AnalyticsStatistic> AnalyticsStatistics { get; set; }
        public virtual ICollection<BoardBoard> BoardBoards { get; set; }
        public virtual ICollection<ChatNotification> ChatNotifications { get; set; }
        public virtual ICollection<ChatOnlineSupport> ChatOnlineSupports { get; set; }
        public virtual ICollection<ChatOnlineUser> ChatOnlineUsers { get; set; }
        public virtual ICollection<ChatRoom> ChatRooms { get; set; }
        public virtual ICollection<ChatSupportCannedResponse> ChatSupportCannedResponses { get; set; }
        public virtual ICollection<CmsAbuseReport> CmsAbuseReports { get; set; }
        public virtual ICollection<CmsAcl> CmsAcls { get; set; }
        public virtual ICollection<CmsAlternativeUrl> CmsAlternativeUrls { get; set; }
        public virtual ICollection<CmsAttachmentHistory> CmsAttachmentHistories { get; set; }
        public virtual ICollection<CmsAttachment> CmsAttachments { get; set; }
        public virtual ICollection<CmsAutomationState> CmsAutomationStates { get; set; }
        public virtual ICollection<CmsBannedIp> CmsBannedIps { get; set; }
        public virtual ICollection<CmsBannerCategory> CmsBannerCategories { get; set; }
        public virtual ICollection<CmsBanner> CmsBanners { get; set; }
        public virtual ICollection<CmsCategory> CmsCategories { get; set; }
        public virtual ICollection<CmsDocumentAlias> CmsDocumentAliases { get; set; }
        public virtual ICollection<CmsDocumentTypeScope> CmsDocumentTypeScopes { get; set; }
        public virtual ICollection<CmsEmailTemplate> CmsEmailTemplates { get; set; }
        public virtual ICollection<CmsForm> CmsForms { get; set; }
        public virtual ICollection<CmsMembership> CmsMemberships { get; set; }
        public virtual ICollection<CmsMetaFile> CmsMetaFiles { get; set; }
        public virtual ICollection<CmsObjectVersionHistory> CmsObjectVersionHistories { get; set; }
        public virtual ICollection<CmsPageTemplateConfiguration> CmsPageTemplateConfigurations { get; set; }
        public virtual ICollection<CmsPageTemplateScope> CmsPageTemplateScopes { get; set; }
        public virtual ICollection<CmsPageTemplate> CmsPageTemplates { get; set; }
        public virtual ICollection<CmsPersonalization> CmsPersonalizations { get; set; }
        public virtual ICollection<CmsRole> CmsRoles { get; set; }
        public virtual ICollection<CmsScheduledTask> CmsScheduledTasks { get; set; }
        public virtual ICollection<CmsSession> CmsSessions { get; set; }
        public virtual ICollection<CmsSettingsKey> CmsSettingsKeys { get; set; }
        public virtual ICollection<CmsSiteDomainAlias> CmsSiteDomainAliases { get; set; }
        public virtual ICollection<CmsTagGroup> CmsTagGroups { get; set; }
        public virtual ICollection<CmsTree> CmsTreeNodeLinkedNodeSites { get; set; }
        public virtual ICollection<CmsTree> CmsTreeNodeSites { get; set; }
        public virtual ICollection<CmsUserCulture> CmsUserCultures { get; set; }
        public virtual ICollection<CmsUserSite> CmsUserSites { get; set; }
        public virtual ICollection<CmsVersionHistory> CmsVersionHistories { get; set; }
        public virtual ICollection<CmsWorkflowScope> CmsWorkflowScopes { get; set; }
        public virtual ICollection<ComBrand> ComBrands { get; set; }
        public virtual ICollection<ComCarrier> ComCarriers { get; set; }
        public virtual ICollection<ComCollection> ComCollections { get; set; }
        public virtual ICollection<ComCurrency> ComCurrencies { get; set; }
        public virtual ICollection<ComCustomerCreditHistory> ComCustomerCreditHistories { get; set; }
        public virtual ICollection<ComCustomer> ComCustomers { get; set; }
        public virtual ICollection<ComDepartment> ComDepartments { get; set; }
        public virtual ICollection<ComDiscount> ComDiscounts { get; set; }
        public virtual ICollection<ComExchangeTable> ComExchangeTables { get; set; }
        public virtual ICollection<ComGiftCard> ComGiftCards { get; set; }
        public virtual ICollection<ComInternalStatus> ComInternalStatuses { get; set; }
        public virtual ICollection<ComManufacturer> ComManufacturers { get; set; }
        public virtual ICollection<ComMultiBuyDiscount> ComMultiBuyDiscounts { get; set; }
        public virtual ICollection<ComOptionCategory> ComOptionCategories { get; set; }
        public virtual ICollection<ComOrderStatus> ComOrderStatuses { get; set; }
        public virtual ICollection<ComOrder> ComOrders { get; set; }
        public virtual ICollection<ComPaymentOption> ComPaymentOptions { get; set; }
        public virtual ICollection<ComPublicStatus> ComPublicStatuses { get; set; }
        public virtual ICollection<ComShippingOption> ComShippingOptions { get; set; }
        public virtual ICollection<ComShoppingCart> ComShoppingCarts { get; set; }
        public virtual ICollection<ComSku> ComSkus { get; set; }
        public virtual ICollection<ComSupplier> ComSuppliers { get; set; }
        public virtual ICollection<ComTaxClass> ComTaxClasses { get; set; }
        public virtual ICollection<ComWishlist> ComWishlists { get; set; }
        public virtual ICollection<CommunityGroup> CommunityGroups { get; set; }
        public virtual ICollection<ExportHistory> ExportHistories { get; set; }
        public virtual ICollection<ExportTask> ExportTasks { get; set; }
        public virtual ICollection<ForumsAttachment> ForumsAttachments { get; set; }
        public virtual ICollection<ForumsForumGroup> ForumsForumGroups { get; set; }
        public virtual ICollection<ForumsForum> ForumsForums { get; set; }
        public virtual ICollection<ForumsUserFavorite> ForumsUserFavorites { get; set; }
        public virtual ICollection<IntegrationTask> IntegrationTasks { get; set; }
        public virtual ICollection<MediaFile> MediaFiles { get; set; }
        public virtual ICollection<MediaLibrary> MediaLibraries { get; set; }
        public virtual ICollection<NewsletterEmailTemplate> NewsletterEmailTemplates { get; set; }
        public virtual ICollection<NewsletterEmailWidget> NewsletterEmailWidgets { get; set; }
        public virtual ICollection<NewsletterEmail> NewsletterEmails { get; set; }
        public virtual ICollection<NewsletterNewsletterIssue> NewsletterNewsletterIssues { get; set; }
        public virtual ICollection<NewsletterNewsletter> NewsletterNewsletters { get; set; }
        public virtual ICollection<NewsletterSubscriber> NewsletterSubscribers { get; set; }
        public virtual ICollection<NotificationSubscription> NotificationSubscriptions { get; set; }
        public virtual ICollection<NotificationTemplate> NotificationTemplates { get; set; }
        public virtual ICollection<OmAbtest> OmAbtests { get; set; }
        public virtual ICollection<OmAbvariant> OmAbvariants { get; set; }
        public virtual ICollection<OmMvtest> OmMvtests { get; set; }
        public virtual ICollection<PollsPoll> PollsPolls { get; set; }
        public virtual ICollection<ReportingReportSubscription> ReportingReportSubscriptions { get; set; }
        public virtual ICollection<SharePointSharePointConnection> SharePointSharePointConnections { get; set; }
        public virtual ICollection<SharePointSharePointFile> SharePointSharePointFiles { get; set; }
        public virtual ICollection<SharePointSharePointLibrary> SharePointSharePointLibraries { get; set; }
        public virtual ICollection<SmFacebookAccount> SmFacebookAccounts { get; set; }
        public virtual ICollection<SmFacebookApplication> SmFacebookApplications { get; set; }
        public virtual ICollection<SmFacebookPost> SmFacebookPosts { get; set; }
        public virtual ICollection<SmLinkedInApplication> SmLinkedInApplications { get; set; }
        public virtual ICollection<SmLinkedInPost> SmLinkedInPosts { get; set; }
        public virtual ICollection<SmTwitterAccount> SmTwitterAccounts { get; set; }
        public virtual ICollection<SmTwitterApplication> SmTwitterApplications { get; set; }
        public virtual ICollection<SmTwitterPost> SmTwitterPosts { get; set; }
        public virtual ICollection<StagingServer> StagingServers { get; set; }
        public virtual ICollection<StagingTask> StagingTasks { get; set; }

        public virtual ICollection<CmsClass> Classes { get; set; }
        public virtual ICollection<CmsWebPartContainer> Containers { get; set; }
        public virtual ICollection<CmsCulture> Cultures { get; set; }
        public virtual ICollection<CmsSearchIndex> Indices { get; set; }
        public virtual ICollection<CmsPageTemplate> PageTemplates { get; set; }
        public virtual ICollection<PollsPoll> Polls { get; set; }
        public virtual ICollection<CmsRelationshipName> RelationshipNames { get; set; }
        public virtual ICollection<CmsResource> Resources { get; set; }
        public virtual ICollection<CmsSmtpserver> Servers { get; set; }
        public virtual ICollection<CmsCssStylesheet> Stylesheets { get; set; }
    }
}
