using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class RemoveKenticoModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder){}
        protected void UpX(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analytics_CampaignAssetUrl",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_CampaignConversionHits",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_CampaignObjective",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_Conversion",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_DayHits",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_ExitPages",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_HourHits",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_MonthHits",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_WeekHits",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_YearHits",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BadWords_WordCulture",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Blog_Comment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Blog_PostSubscription",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Board_Message",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Board_Moderator",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Board_Role",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Board_Subscription",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_InitiatedChatRequest",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_Message",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_Notification",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_OnlineSupport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_OnlineUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_PopupWindowSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_RoomUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_SupportCannedResponse",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_SupportTakenRoom",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CI_FileMetadata",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CI_Migration",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_AbuseReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ACLItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_AllowedChildClasses",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_AlternativeForm",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_AlternativeUrl",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Attachment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_AttachmentForEmail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_AutomationHistory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_BannedIP",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Banner",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ClassSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ConsentAgreement",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ConsentArchive",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_CssStylesheetSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_DeviceProfileLayout",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_DocumentAlias",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_DocumentCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_DocumentTag",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_DocumentTypeScopeClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_EmailTemplate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_EmailUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_EventLog",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ExternalLogin",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_FormRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_FormUserControl",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_HelpTopic",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_LicenseKey",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_MacroRule",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_MembershipRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_MembershipUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_MetaFile",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ModuleLicenseKey",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ModuleUsageCounter",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ObjectSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ObjectWorkflowTrigger",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_OpenIDUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_PageTemplateConfiguration",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_PageTemplateScope",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_PageTemplateSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Personalization",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Query",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Relationship",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_RelationshipNameSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ResourceLibrary",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ResourceSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ResourceTranslation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_RoleApplication",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_RolePermission",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_RoleUIElement",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SearchEngine",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SearchIndexCulture",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SearchIndexSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SearchTask",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SearchTaskAzure",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Session",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SettingsKey",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SiteCulture",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SiteDomainAlias",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SMTPServerSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_TemplateDeviceLayout",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Transformation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_TranslationSubmissionItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_UserCulture",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_UserMacroIdentity",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_UserRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_UserSettings",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_UserSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_VersionAttachment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebFarmServerLog",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebFarmServerMonitoring",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebFarmServerTask",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebPartContainerSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebTemplate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WidgetRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WorkflowHistory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WorkflowScope",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WorkflowStepRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WorkflowStepUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WorkflowTransition",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WorkflowUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Bundle",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_CouponCode",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_CurrencyExchangeRate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_CustomerCreditHistory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_GiftCardCouponCode",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_MultiBuyCouponCode",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_MultiBuyDiscountBrand",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_MultiBuyDiscountCollection",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_MultiBuyDiscountDepartment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_MultiBuyDiscountSKU",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_MultiBuyDiscountTree",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_OrderAddress",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_OrderItemSKUFile",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_OrderStatusUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_ShippingCost",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_ShoppingCartCouponCode",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_ShoppingCartSKU",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_SKUAllowedOption",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_SKUOptionCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_TaxClassCountry",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_TaxClassState",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_VariantOption",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_VolumeDiscount",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Wishlist",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Community_GroupMember",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Community_GroupRolePermission",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Community_Invitation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_Article",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_Blog",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_BlogMonth",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_BlogPost",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_BookingEvent",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_Event",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_FAQ",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_File",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_ImageGallery",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_Job",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_KBArticle",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_MenuItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_News",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_Office",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_PressRelease",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_Product",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CONTENT_SimpleArticle",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "customtable_SampleTable",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Events_Attendee",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Export_History",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Export_Task",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Form_abbasarabzadeh_ArabzadehContact",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhCenter_BranchRequest",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhCenter_ContactUs",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhCenter_Hiring",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhOnlinePortal_Contact",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhOnlinePortal_Hiring",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhOnlinePortal_StudentName",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhOnlinePortal_StudentName_Tel",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhOnlinePortal_StudentName_Tel_backup",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhOnlinePortal_Writing",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Form_ShokouhOnlinePortal_Writing_backup",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Forums_Attachment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Forums_ForumModerators",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Forums_ForumRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Forums_ForumSubscription",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Forums_UserFavorites",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Integration_SyncLog",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "IntranetPortal_Department",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "IntranetPortal_WorkingEnvironment",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Media_File",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Media_LibraryRolePermission",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_ABTest",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_ClickedLink",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_Emails",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_EmailTemplateNewsletter",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_EmailWidgetTemplate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_IssueContactGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_OpenedEmail",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_SubscriberNewsletter",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_Unsubscription",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Notification_Subscription",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Notification_TemplateText",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ntmtn_social",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "OM_ABVariant",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ABVariantData",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_AccountContact",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_Activity",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ActivityRecalculationQueue",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ActivityType",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ContactChangeRecalculationQueue",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ContactGroupMember",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_Membership",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_MVTCombinationVariation",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_MVTest",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_PersonalizationVariant",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ScoreContactRule",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_VisitorToContact",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Personas_PersonaContactHistory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Personas_PersonaNode",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Polls_PollAnswer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Polls_PollRoles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Polls_PollSite",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Reporting_ReportSubscription",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Reporting_SavedGraph",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SharePoint_SharePointFile",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_FacebookPost",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_InsightHit_Day",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_InsightHit_Month",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_InsightHit_Week",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_InsightHit_Year",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_LinkedInApplication",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_LinkedInPost",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_TwitterPost",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SOP_BookFolderID",
                schema: "ShoukouhPardis12DBAdmin");

            migrationBuilder.DropTable(
                name: "Staging_Synchronization",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "staging_TaskGroupTask",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "staging_TaskGroupUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Staging_TaskUser",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Temp_File",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Temp_PageBuilderWidgets",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_CampaignAsset",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_CampaignConversion",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_Statistics",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "BadWords_Word",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Board_Board",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_Room",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_EmailAttachment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_AutomationState",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_BannerCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Consent",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Category",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Tag",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_DocumentTypeScope",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Email",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Form",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Membership",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ObjectVersionHistory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_RelationshipName",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ResourceString",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_UIElement",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SearchIndex",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SettingsCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_SMTPServer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_DeviceProfile",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_TranslationSubmission",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_MacroIdentity",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Badge",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_TimeZone",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_AttachmentHistory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebFarmServer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebFarmTask",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebPartContainer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Widget",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Culture",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Discount",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_ExchangeTable",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_GiftCard",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_MultiBuyDiscount",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_OrderItem",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_SKUFile",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_ShoppingCart",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Forums_ForumPost",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Integration_Synchronization",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Media_Library",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Permission",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_Link",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_EmailWidget",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_Subscriber",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Notification_Gateway",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Notification_Template",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ABTest",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_Account",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ContactRole",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ContactGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_MVTCombination",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_MVTVariant",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_Rule",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Personas_Persona",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Role",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Polls_Poll",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Reporting_ReportGraph",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Reporting_ReportTable",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Reporting_ReportValue",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Reporting_SavedReport",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SharePoint_SharePointLibrary",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_FacebookAccount",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_Insight",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_LinkedInAccount",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_TwitterAccount",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Staging_Server",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "staging_TaskGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Staging_Task",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Analytics_Campaign",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Chat_User",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_TranslationService",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WidgetCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebPartLayout",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Order",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Address",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Forums_Forum",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Integration_Connector",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Integration_Task",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_NewsletterIssue",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_AccountStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_Contact",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_Score",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Reporting_Report",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SharePoint_SharePointConnection",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_FacebookApplication",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "SM_TwitterApplication",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebPart",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Currency",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_PaymentOption",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_ShippingOption",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Customer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Document",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Forums_ForumGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_Newsletter",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_State",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "OM_ContactStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Reporting_ReportCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WebPartCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_OrderStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Carrier",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_VersionHistory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Tree",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_TagGroup",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ScheduledTask",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Newsletter_EmailTemplate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Country",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WorkflowStep",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_ACL",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Class",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Community_Group",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_SKU",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_WorkflowAction",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Workflow",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_PageTemplate",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_User",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Avatar",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Brand",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Collection",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Department",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_InternalStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Manufacturer",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_OptionCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_PublicStatus",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_Supplier",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Resource",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_PageTemplateCategory",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Layout",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "COM_TaxClass",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_Site",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CMS_CssStylesheet",
                schema: "dbo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder){}
        protected void DownX(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Analytics_ExitPages",
                schema: "dbo",
                columns: table => new
                {
                    SessionIdentificator = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ExitPageCulture = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExitPageLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExitPageNodeID = table.Column<int>(type: "int", nullable: false),
                    ExitPageSiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_ExitPages", x => x.SessionIdentificator);
                });

            migrationBuilder.CreateTable(
                name: "BadWords_Word",
                schema: "dbo",
                columns: table => new
                {
                    WordID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordAction = table.Column<int>(type: "int", nullable: true),
                    WordExpression = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    WordGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WordIsGlobal = table.Column<bool>(type: "bit", nullable: false),
                    WordIsRegularExpression = table.Column<bool>(type: "bit", nullable: false),
                    WordLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WordMatchWholeWord = table.Column<bool>(type: "bit", nullable: true),
                    WordReplacement = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BadWords_Word", x => x.WordID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "Chat_PopupWindowSettings",
                schema: "dbo",
                columns: table => new
                {
                    ChatPopupWindowSettingsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatPopupWindowSettingsHashCode = table.Column<int>(type: "int", nullable: false),
                    ErrorClearTransformationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ErrorTransformationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MessageTransformationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserTransformationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_PopupWindowSettings", x => x.ChatPopupWindowSettingsID);
                });

            migrationBuilder.CreateTable(
                name: "CI_FileMetadata",
                schema: "dbo",
                columns: table => new
                {
                    FileMetadataID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileHash = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false, defaultValueSql: "(N'')"),
                    FileLocation = table.Column<string>(type: "nvarchar(260)", maxLength: 260, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CI_FileMetadata", x => x.FileMetadataID);
                });

            migrationBuilder.CreateTable(
                name: "CI_Migration",
                schema: "dbo",
                columns: table => new
                {
                    MigrationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateApplied = table.Column<DateTime>(type: "datetime2(3)", precision: 3, nullable: false, defaultValueSql: "(sysdatetime())"),
                    MigrationName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RowsAffected = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CI_Migration", x => x.MigrationID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_Avatar",
                schema: "dbo",
                columns: table => new
                {
                    AvatarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvatarBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AvatarFileExtension = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AvatarFileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AvatarFileSize = table.Column<int>(type: "int", nullable: false),
                    AvatarGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AvatarImageHeight = table.Column<int>(type: "int", nullable: true),
                    AvatarImageWidth = table.Column<int>(type: "int", nullable: true),
                    AvatarIsCustom = table.Column<bool>(type: "bit", nullable: false),
                    AvatarLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvatarMimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AvatarName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AvatarType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DefaultFemaleUserAvatar = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DefaultGroupAvatar = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DefaultMaleUserAvatar = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DefaultUserAvatar = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Avatar", x => x.AvatarID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_Badge",
                schema: "dbo",
                columns: table => new
                {
                    BadgeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BadgeDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    BadgeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BadgeImageURL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    BadgeIsAutomatic = table.Column<bool>(type: "bit", nullable: false),
                    BadgeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/25/2008 5:07:55 PM')"),
                    BadgeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    BadgeTopLimit = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Badge", x => x.BadgeID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_Consent",
                schema: "dbo",
                columns: table => new
                {
                    ConsentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsentContent = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    ConsentDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    ConsentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsentHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    ConsentLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    ConsentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Consent", x => x.ConsentID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_Country",
                schema: "dbo",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    CountryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('11/14/2013 1:43:04 PM')"),
                    CountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    CountryThreeLetterCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    CountryTwoLetterCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Country", x => x.CountryID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_CssStylesheet",
                schema: "dbo",
                columns: table => new
                {
                    StylesheetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StylesheetDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    StylesheetDynamicCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StylesheetDynamicLanguage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "('plaincss')"),
                    StylesheetGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StylesheetLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StylesheetName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    StylesheetText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StylesheetVersionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_CssStylesheet", x => x.StylesheetID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_Culture",
                schema: "dbo",
                columns: table => new
                {
                    CultureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CultureAlias = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CultureCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CultureGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CultureIsUICulture = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CultureLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CultureName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CultureShortName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Culture", x => x.CultureID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_DeviceProfile",
                schema: "dbo",
                columns: table => new
                {
                    ProfileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ProfileEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ProfileGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProfileLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProfileMacro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ProfileOrder = table.Column<int>(type: "int", nullable: true),
                    ProfilePreviewHeight = table.Column<int>(type: "int", nullable: true),
                    ProfilePreviewWidth = table.Column<int>(type: "int", nullable: true),
                    ProfileUserAgents = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_DeviceProfile", x => x.ProfileID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_Email",
                schema: "dbo",
                columns: table => new
                {
                    EmailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailBcc = table.Column<string>(type: "nvarchar(998)", maxLength: 998, nullable: true),
                    EmailBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCc = table.Column<string>(type: "nvarchar(998)", maxLength: 998, nullable: true),
                    EmailCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailFormat = table.Column<int>(type: "int", nullable: false),
                    EmailFrom = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false, defaultValueSql: "(N'')"),
                    EmailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailHeaders = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailIsMass = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    EmailLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('6/17/2016 10:11:21 AM')"),
                    EmailLastSendAttempt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailLastSendResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailPlainTextBody = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailPriority = table.Column<int>(type: "int", nullable: false),
                    EmailReplyTo = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    EmailSiteID = table.Column<int>(type: "int", nullable: true),
                    EmailStatus = table.Column<int>(type: "int", nullable: true),
                    EmailSubject = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "('')"),
                    EmailTo = table.Column<string>(type: "nvarchar(998)", maxLength: 998, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Email", x => x.EmailID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_EmailAttachment",
                schema: "dbo",
                columns: table => new
                {
                    AttachmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AttachmentContentID = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AttachmentExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttachmentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttachmentLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttachmentMimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AttachmentSiteID = table.Column<int>(type: "int", nullable: true),
                    AttachmentSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_EmailAttachment", x => x.AttachmentID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_EventLog",
                schema: "dbo",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(N'')"),
                    EventCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    EventDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventMachineName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(N'')"),
                    EventTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('4/21/2015 8:21:43 AM')"),
                    EventType = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValueSql: "(N'')"),
                    EventUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(N'')"),
                    EventUrlReferrer = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(N'')"),
                    EventUserAgent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(N'')"),
                    NodeID = table.Column<int>(type: "int", nullable: true),
                    SiteID = table.Column<int>(type: "int", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_EventLog", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_Layout",
                schema: "dbo",
                columns: table => new
                {
                    LayoutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LayoutCode = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('<cms:CMSWebPartZone ZoneID=\"zoneA\" runat=\"server\" />')"),
                    LayoutCodeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    LayoutCSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LayoutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LayoutDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    LayoutGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LayoutIconClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "(N'icon-layout')"),
                    LayoutIsConvertible = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    LayoutLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LayoutThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LayoutType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LayoutVersionGUID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LayoutZoneCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Layout", x => x.LayoutID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_LicenseKey",
                schema: "dbo",
                columns: table => new
                {
                    LicenseKeyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicenseDomain = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LicenseEdition = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LicenseExpiration = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LicenseKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicenseServers = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_LicenseKey", x => x.LicenseKeyID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_MacroRule",
                schema: "dbo",
                columns: table => new
                {
                    MacroRuleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MacroRuleAvailability = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    MacroRuleCondition = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    MacroRuleDescription = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    MacroRuleDisplayName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    MacroRuleEnabled = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    MacroRuleGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MacroRuleIsCustom = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    MacroRuleLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('5/1/2012 8:46:33 AM')"),
                    MacroRuleName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MacroRuleParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MacroRuleRequiredData = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: true),
                    MacroRuleRequiresContext = table.Column<bool>(type: "bit", nullable: false),
                    MacroRuleResourceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MacroRuleText = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_MacroRule", x => x.MacroRuleID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_ModuleUsageCounter",
                schema: "dbo",
                columns: table => new
                {
                    ModuleUsageCounterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleUsageCounterName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    ModuleUsageCounterValue = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CMS_PageTemplateCategory",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryParentID = table.Column<int>(type: "int", nullable: true),
                    CategoryChildCount = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    CategoryDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    CategoryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryImagePath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CategoryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryLevel = table.Column<int>(type: "int", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CategoryPath = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CategoryTemplateChildCount = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_PageTemplateCategory", x => x.CategoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplateCategory_CategoryParentID_CMS_PageTemplateCategory",
                        column: x => x.CategoryParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplateCategory",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_RelationshipName",
                schema: "dbo",
                columns: table => new
                {
                    RelationshipNameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelationshipAllowedObjects = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RelationshipDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    RelationshipGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelationshipLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RelationshipName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    RelationshipNameIsAdHoc = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_RelationshipName", x => x.RelationshipNameID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_Resource",
                schema: "dbo",
                columns: table => new
                {
                    ResourceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceAuthor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ResourceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourceDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResourceGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ResourceHasFiles = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ResourceInstallationState = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(N'')"),
                    ResourceInstalledVersion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(N'')"),
                    ResourceIsInDevelopment = table.Column<bool>(type: "bit", nullable: true),
                    ResourceLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResourceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ResourceURL = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ResourceVersion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShowInDevelopment = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Resource", x => x.ResourceID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_ResourceString",
                schema: "dbo",
                columns: table => new
                {
                    StringID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StringGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StringIsCustom = table.Column<bool>(type: "bit", nullable: false),
                    StringKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ResourceString", x => x.StringID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_SearchEngine",
                schema: "dbo",
                columns: table => new
                {
                    SearchEngineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchEngineCrawler = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SearchEngineDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SearchEngineDomainRule = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    SearchEngineGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SearchEngineKeywordParameter = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SearchEngineLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SearchEngineName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SearchEngine", x => x.SearchEngineID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_SearchIndex",
                schema: "dbo",
                columns: table => new
                {
                    IndexID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndexAdminKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexAnalyzerType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexBatchSize = table.Column<int>(type: "int", nullable: true),
                    IndexCrawlerDomain = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexCrawlerFormsUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexCrawlerUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexCrawlerUserPassword = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexCustomAnalyzerAssemblyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexCustomAnalyzerClassName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IndexGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IndexIsCommunityGroup = table.Column<bool>(type: "bit", nullable: false),
                    IndexIsOutdated = table.Column<bool>(type: "bit", nullable: true),
                    IndexLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IndexLastRebuildTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IndexLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IndexName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IndexProvider = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    IndexQueryKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexSearchServiceName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndexStatus = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    IndexStopWordsFile = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IndexType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SearchIndex", x => x.IndexID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_SearchTask",
                schema: "dbo",
                columns: table => new
                {
                    SearchTaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchTaskCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('4/15/2009 11:23:52 AM')"),
                    SearchTaskErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SearchTaskField = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SearchTaskObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SearchTaskPriority = table.Column<int>(type: "int", nullable: false),
                    SearchTaskRelatedObjectID = table.Column<int>(type: "int", nullable: true),
                    SearchTaskServerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SearchTaskStatus = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    SearchTaskType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    SearchTaskValue = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SearchTask", x => x.SearchTaskID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_SearchTaskAzure",
                schema: "dbo",
                columns: table => new
                {
                    SearchTaskAzureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SearchTaskAzureAdditionalData = table.Column<string>(type: "nvarchar(600)", maxLength: 600, nullable: false, defaultValueSql: "(N'')"),
                    SearchTaskAzureCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    SearchTaskAzureErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SearchTaskAzureInitiatorObjectID = table.Column<int>(type: "int", nullable: true),
                    SearchTaskAzureMetadata = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SearchTaskAzureObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SearchTaskAzurePriority = table.Column<int>(type: "int", nullable: false),
                    SearchTaskAzureType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SearchTaskAzure", x => x.SearchTaskAzureID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_SMTPServer",
                schema: "dbo",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerDeliveryMethod = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ServerEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ServerGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServerIsGlobal = table.Column<bool>(type: "bit", nullable: false),
                    ServerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ServerPassword = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ServerPickupDirectory = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ServerPriority = table.Column<int>(type: "int", nullable: true),
                    ServerUseSSL = table.Column<bool>(type: "bit", nullable: false),
                    ServerUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SMTPServer", x => x.ServerID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_TimeZone",
                schema: "dbo",
                columns: table => new
                {
                    TimeZoneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeZoneDaylight = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TimeZoneDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TimeZoneGMT = table.Column<double>(type: "float", nullable: false),
                    TimeZoneGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimeZoneLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeZoneName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TimeZoneRuleEndIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeZoneRuleEndRule = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TimeZoneRuleStartIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeZoneRuleStartRule = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_TimeZone", x => x.TimeZoneID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_TranslationService",
                schema: "dbo",
                columns: table => new
                {
                    TranslationServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranslationServiceAssemblyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TranslationServiceClassName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TranslationServiceDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TranslationServiceEnabled = table.Column<bool>(type: "bit", nullable: false),
                    TranslationServiceGenerateTargetTag = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TranslationServiceGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TranslationServiceIsMachine = table.Column<bool>(type: "bit", nullable: false),
                    TranslationServiceLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TranslationServiceName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TranslationServiceParameter = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TranslationServiceSupportsCancel = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TranslationServiceSupportsDeadline = table.Column<bool>(type: "bit", nullable: true),
                    TranslationServiceSupportsInstructions = table.Column<bool>(type: "bit", nullable: true),
                    TranslationServiceSupportsPriority = table.Column<bool>(type: "bit", nullable: true),
                    TranslationServiceSupportsStatusUpdate = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_TranslationService", x => x.TranslationServiceID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_User",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    LastLogon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PreferredCultureCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    PreferredUICultureCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UserCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserHasAllowedCultures = table.Column<bool>(type: "bit", nullable: true),
                    UserIsDomain = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    UserIsExternal = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    UserIsHidden = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    UserLastLogonInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserMFRequired = table.Column<bool>(type: "bit", nullable: true),
                    UserMFSecret = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    UserMFTimestep = table.Column<long>(type: "bigint", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    UserPassword = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    UserPasswordFormat = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UserPrivilegeLevel = table.Column<int>(type: "int", nullable: false),
                    UserSecurityStamp = table.Column<string>(type: "nvarchar(72)", maxLength: 72, nullable: true),
                    UserStartingAliasPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserVisibility = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_User", x => x.UserID);
                    table.UniqueConstraint("AK_CMS_User_UserGUID", x => x.UserGUID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebFarmServer",
                schema: "dbo",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsExternalWebAppServer = table.Column<bool>(type: "bit", nullable: false),
                    ServerDisplayName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, defaultValueSql: "(N'')"),
                    ServerEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ServerGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ServerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/17/2013 12:18:06 PM')"),
                    ServerName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebFarmServer", x => x.ServerID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebFarmServerLog",
                schema: "dbo",
                columns: table => new
                {
                    WebFarmServerLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    LogTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebFarmServerLog", x => x.WebFarmServerLogID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebFarmServerMonitoring",
                schema: "dbo",
                columns: table => new
                {
                    WebFarmServerMonitoringID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerID = table.Column<int>(type: "int", nullable: false),
                    ServerPing = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebFarmServerMonitoring", x => x.WebFarmServerMonitoringID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebFarmTask",
                schema: "dbo",
                columns: table => new
                {
                    TaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskBinaryData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    TaskCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValueSql: "('00000000-0000-0000-0000-000000000000')"),
                    TaskIsAnonymous = table.Column<bool>(type: "bit", nullable: true),
                    TaskIsMemory = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TaskMachineName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    TaskTarget = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskTextData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebFarmTask", x => x.TaskID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebPartCategory",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryParentID = table.Column<int>(type: "int", nullable: true),
                    CategoryChildCount = table.Column<int>(type: "int", nullable: true),
                    CategoryDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryImagePath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CategoryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryLevel = table.Column<int>(type: "int", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryPath = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "('')"),
                    CategoryWebPartChildCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebPartCategory", x => x.CategoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_WebPartCategory_CategoryParentID_CMS_WebPartCategory",
                        column: x => x.CategoryParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WebPartCategory",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebPartContainer",
                schema: "dbo",
                columns: table => new
                {
                    ContainerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContainerCSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContainerDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    ContainerGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContainerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContainerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    ContainerTextAfter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContainerTextBefore = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebPartContainer", x => x.ContainerID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebTemplate",
                schema: "dbo",
                columns: table => new
                {
                    WebTemplateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebTemplateDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebTemplateDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    WebTemplateFileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    WebTemplateGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WebTemplateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WebTemplateLicenses = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    WebTemplateName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    WebTemplateOrder = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((99999))"),
                    WebTemplateShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebTemplateThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebTemplate", x => x.WebTemplateID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CMS_WidgetCategory",
                schema: "dbo",
                columns: table => new
                {
                    WidgetCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WidgetCategoryParentID = table.Column<int>(type: "int", nullable: true),
                    WidgetCategoryChildCount = table.Column<int>(type: "int", nullable: true),
                    WidgetCategoryDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WidgetCategoryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WidgetCategoryImagePath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    WidgetCategoryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WidgetCategoryLevel = table.Column<int>(type: "int", nullable: false),
                    WidgetCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WidgetCategoryPath = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WidgetCategoryWidgetChildCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WidgetCategory", x => x.WidgetCategoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_WidgetCategory_WidgetCategoryParentID_CMS_WidgetCategory",
                        column: x => x.WidgetCategoryParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WidgetCategory",
                        principalColumn: "WidgetCategoryID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Workflow",
                schema: "dbo",
                columns: table => new
                {
                    WorkflowID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkflowAllowedObjects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkflowApprovedTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkflowArchivedTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkflowAutoPublishChanges = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    WorkflowDisplayName = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "('')"),
                    WorkflowEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    WorkflowGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkflowLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkflowName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "('')"),
                    WorkflowNotificationTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkflowPublishedTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkflowReadyForApprovalTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkflowRecurrenceType = table.Column<int>(type: "int", nullable: true),
                    WorkflowRejectedTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WorkflowSendApproveEmails = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    WorkflowSendArchiveEmails = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    WorkflowSendEmails = table.Column<bool>(type: "bit", nullable: true),
                    WorkflowSendPublishEmails = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    WorkflowSendReadyForApprovalEmails = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    WorkflowSendRejectEmails = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    WorkflowType = table.Column<int>(type: "int", nullable: true),
                    WorkflowUseCheckinCheckout = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Workflow", x => x.WorkflowID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_Article",
                schema: "dbo",
                columns: table => new
                {
                    ArticleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "(N'')"),
                    ArticleTeaserImage = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ArticleTeaserText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArticleText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageLink = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'Article-Published')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_Article", x => x.ArticleID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_Blog",
                schema: "dbo",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogAllowAnonymousComments = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    BlogDescription = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    BlogEnableOptIn = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((-1))"),
                    BlogEnableSubscriptions = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    BlogModerateComments = table.Column<bool>(type: "bit", nullable: false),
                    BlogModerators = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    BlogName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    BlogOpenCommentsFor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "(N'')"),
                    BlogOptInApprovalURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    BlogRequireEmails = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    BlogSendCommentsToEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    BlogSendOptInConfirmation = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((-1))"),
                    BlogSideColumnText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogTeaser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BlogUnsubscriptionUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BlogUseCAPTCHAForComments = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_Blog", x => x.BlogID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_BlogMonth",
                schema: "dbo",
                columns: table => new
                {
                    BlogMonthID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogMonthName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    BlogMonthStartingDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_BlogMonth", x => x.BlogMonthID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_BlogPost",
                schema: "dbo",
                columns: table => new
                {
                    BlogPostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogLogActivity = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    BlogPostAllowComments = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    BlogPostBody = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    BlogPostDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    BlogPostSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogPostTeaser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BlogPostTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    FacebookAutoPost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedInAutoPost = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TwitterAutoPost = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_BlogPost", x => x.BlogPostID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_BookingEvent",
                schema: "dbo",
                columns: table => new
                {
                    BookingEventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventAllDay = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    EventAllowRegistrationOverCapacity = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    EventCapacity = table.Column<int>(type: "int", nullable: true),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EventDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EventLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventLogActivity = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    EventName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    EventOpenFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EventOpenTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EventSummary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_BookingEvent", x => x.BookingEventID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_Event",
                schema: "dbo",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EventDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    EventSummary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_Event", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_FAQ",
                schema: "dbo",
                columns: table => new
                {
                    FAQID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FAQAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    FAQQuestion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_FAQ", x => x.FAQID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_File",
                schema: "dbo",
                columns: table => new
                {
                    FileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileAttachment = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FileDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_File", x => x.FileID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_ImageGallery",
                schema: "dbo",
                columns: table => new
                {
                    ImageGalleryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GalleryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GalleryName = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, defaultValueSql: "(N'')"),
                    GalleryTeaserImage = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_ImageGallery", x => x.ImageGalleryID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_Job",
                schema: "dbo",
                columns: table => new
                {
                    JobID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobAttachment = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobCompensation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    JobSummary = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_Job", x => x.JobID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_KBArticle",
                schema: "dbo",
                columns: table => new
                {
                    KBArticleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleAppliesTo = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    ArticleIdentifier = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ArticleName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, defaultValueSql: "(N'')"),
                    ArticleSeeAlso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArticleSummary = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    ArticleText = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_KBArticle", x => x.KBArticleID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_MenuItem",
                schema: "dbo",
                columns: table => new
                {
                    MenuItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuItemGroup = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MenuItemName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "(N'')"),
                    MenuItemTeaserImage = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_MenuItem", x => x.MenuItemID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_News",
                schema: "dbo",
                columns: table => new
                {
                    NewsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    NewsSummary = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    NewsTeaser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NewsText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewsTitle = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_News", x => x.NewsID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_Office",
                schema: "dbo",
                columns: table => new
                {
                    OfficeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OfficeAddress1 = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    OfficeAddress2 = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    OfficeCity = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    OfficeCompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OfficeCountry = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OfficeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeDirections = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OfficeEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    OfficeIconURL = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OfficeIsHeadquarters = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    OfficeLatitude = table.Column<double>(type: "float", nullable: true),
                    OfficeLongitude = table.Column<double>(type: "float", nullable: true),
                    OfficeName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, defaultValueSql: "(N'')"),
                    OfficePhone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    OfficePhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OfficeState = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OfficeZIP = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_Office", x => x.OfficeID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_PressRelease",
                schema: "dbo",
                columns: table => new
                {
                    PressReleaseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PressReleaseAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PressReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    PressReleaseSummary = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    PressReleaseText = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    PressReleaseTitle = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, defaultValueSql: "(N'')"),
                    PressReleaseTrademarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_PressRelease", x => x.PressReleaseID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_Product",
                schema: "dbo",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_Product", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "CONTENT_SimpleArticle",
                schema: "dbo",
                columns: table => new
                {
                    ArticleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleText = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    ArticleTitle = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTENT_SimpleArticle", x => x.ArticleID);
                });

            migrationBuilder.CreateTable(
                name: "customtable_SampleTable",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemCreatedBy = table.Column<int>(type: "int", nullable: true),
                    ItemCreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ItemModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ItemOrder = table.Column<int>(type: "int", nullable: true),
                    ItemText = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customtable_SampleTable", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "Form_abbasarabzadeh_ArabzadehContact",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    ArabzadehContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Message = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false, defaultValueSql: "(N'')"),
                    Subject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    YourEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    YourName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_abbasarabzadeh_ArabzadehContact", x => x.ArabzadehContactID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhCenter_BranchRequest",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    BranchRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarControl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CalendarControl_1 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DropDownListControl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    emailinput = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    MultipleChoiceControl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'مرد')"),
                    TextAreaControl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TextAreaControl_1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TextAreaControl_2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TextAreaControl_3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TextBoxControl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    TextBoxControl_1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    TextBoxControl_2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TextBoxControl_3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TextBoxControl_4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TextBoxControl_5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TextBoxControl_6 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TextBoxControl_7 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhCenter_BranchRequest", x => x.BranchRequestID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhCenter_ContactUs",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    ContactUsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emailinput = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    HtmlAreaControl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextAreaControl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    TextBoxControl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    TextBoxControl_1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhCenter_ContactUs", x => x.ContactUsID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhCenter_Hiring",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    HiringCenterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivitiesList = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    CRETIFICATION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DateOfB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EDUCATION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    EXPERIENCE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Family = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    MaritalStatus = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Phone = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    PresentAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Sex = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhCenter_Hiring", x => x.HiringCenterID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhOnlinePortal_Contact",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    emailinput = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'پست الکترونیک')"),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Subje = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true, defaultValueSql: "(N'موضوع')"),
                    YourName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'نام و نام خانوادگی')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhOnlinePortal_Contact", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhOnlinePortal_Hiring",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    HiringID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivitiesList = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    CRETIFICATION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DateOfB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EDUCATION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    EXPERIENCE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Family = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    MaritalStatus = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Phone = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    PresentAddress = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Sex = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhOnlinePortal_Hiring", x => x.HiringID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhOnlinePortal_StudentName",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    StudentNameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CalendarControl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Day = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Hour = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Level = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'No Level Selected')"),
                    StdName1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName10 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName11 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName12 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName13 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName14 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName15 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName16 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName17 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName18 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName19 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName20 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName6 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName7 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName8 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName9 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TeacherName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Tel1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel10 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel11 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel12 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel13 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel14 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel15 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel16 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel17 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel18 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel19 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tel2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel20 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tel3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel6 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel7 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel8 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel9 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Term = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'اول تابستان')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhOnlinePortal_StudentName", x => x.StudentNameID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhOnlinePortal_StudentName_Tel",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    StudentName_TelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookCost = table.Column<long>(type: "bigint", nullable: false),
                    CalendarControl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Day = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Hour = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Level = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'No Level Selected')"),
                    StdName1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName10 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName11 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName12 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName13 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName14 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName15 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName16 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName17 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName18 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName19 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName20 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName6 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName7 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName8 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName9 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TeacherName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Tel1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel10 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel11 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel12 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel13 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel14 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel15 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel16 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel17 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel18 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel19 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tel2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel20 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tel3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel6 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel7 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel8 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel9 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Term = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'اول تابستان')"),
                    Tuition = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((3500000))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhOnlinePortal_StudentName_Tel", x => x.StudentName_TelID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhOnlinePortal_StudentName_Tel_backup",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    StudentName_Tel_backupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookCost = table.Column<long>(type: "bigint", nullable: false),
                    CalendarControl = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Day = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Hour = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Level = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'No Level Selected')"),
                    StdName1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName10 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName11 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName12 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName13 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName14 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName15 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName16 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName17 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName18 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName19 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName20 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName6 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName7 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName8 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    StdName9 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TeacherName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Tel1 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel10 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel11 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel12 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel13 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel14 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel15 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel16 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel17 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel18 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel19 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tel2 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel20 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Tel3 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel4 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel5 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel6 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel7 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel8 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    tel9 = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Term = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'اول تابستان')"),
                    Tuition = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "((3500000))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhOnlinePortal_StudentName_Tel_backup", x => x.StudentName_Tel_backupID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhOnlinePortal_Writing",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    WritingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DropDownListControl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Student = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Teacher = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    YourLevel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    YourWriting = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhOnlinePortal_Writing", x => x.WritingID);
                });

            migrationBuilder.CreateTable(
                name: "Form_ShokouhOnlinePortal_Writing_backup",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    Writing_backupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DropDownListControl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    Student = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    Teacher = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    YourLevel = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    YourWriting = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Form_ShokouhOnlinePortal_Writing_backup", x => x.Writing_backupID);
                });

            migrationBuilder.CreateTable(
                name: "Integration_Connector",
                schema: "dbo",
                columns: table => new
                {
                    ConnectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConnectorAssemblyName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ConnectorClassName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ConnectorDisplayName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: false),
                    ConnectorEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ConnectorLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConnectorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integration_Connector", x => x.ConnectorID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "IntranetPortal_Department",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentAvatar = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentDescription = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    DepartmentRoles = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DepartmentSections = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntranetPortal_Department", x => x.DepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "IntranetPortal_WorkingEnvironment",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    workingenvironmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    FormUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    OfficeSatisfaction = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'Neutral')"),
                    Suggestions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YourName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntranetPortal_WorkingEnvironment", x => x.workingenvironmentID);
                });

            migrationBuilder.CreateTable(
                name: "Notification_Gateway",
                schema: "dbo",
                columns: table => new
                {
                    GatewayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GatewayAssemblyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    GatewayClassName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    GatewayDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GatewayDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    GatewayEnabled = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    GatewayGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GatewayLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GatewayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    GatewaySupportsEmail = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    GatewaySupportsHTMLText = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    GatewaySupportsPlainText = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_Gateway", x => x.GatewayID)
                        .Annotation("SqlServer:Clustered", false);
                });

            migrationBuilder.CreateTable(
                name: "ntmtn_social",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    SocialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @class = table.Column<string>(name: "class", type: "nvarchar(200)", maxLength: 200, nullable: true),
                    socialLink = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    socialName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ntmtn_social", x => x.SocialID);
                });

            migrationBuilder.CreateTable(
                name: "OM_AccountStatus",
                schema: "dbo",
                columns: table => new
                {
                    AccountStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountStatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountStatusDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AccountStatusName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_AccountStatus", x => x.AccountStatusID);
                });

            migrationBuilder.CreateTable(
                name: "OM_Activity",
                schema: "dbo",
                columns: table => new
                {
                    ActivityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityABVariantName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActivityCampaign = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActivityComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityContactID = table.Column<int>(type: "int", nullable: false),
                    ActivityCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActivityCulture = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ActivityItemDetailID = table.Column<int>(type: "int", nullable: true),
                    ActivityItemID = table.Column<int>(type: "int", nullable: true),
                    ActivityMVTCombinationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActivityNodeID = table.Column<int>(type: "int", nullable: true),
                    ActivitySiteID = table.Column<int>(type: "int", nullable: false),
                    ActivityTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ActivityType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ActivityURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityURLHash = table.Column<long>(type: "bigint", nullable: false),
                    ActivityURLReferrer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityUTMContent = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActivityUTMSource = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActivityValue = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_Activity", x => x.ActivityID);
                });

            migrationBuilder.CreateTable(
                name: "OM_ActivityRecalculationQueue",
                schema: "dbo",
                columns: table => new
                {
                    ActivityRecalculationQueueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityRecalculationQueueActivityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ActivityRecalculationQueue", x => x.ActivityRecalculationQueueID);
                });

            migrationBuilder.CreateTable(
                name: "OM_ActivityType",
                schema: "dbo",
                columns: table => new
                {
                    ActivityTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityTypeColor = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    ActivityTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityTypeDetailFormControl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActivityTypeDisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ActivityTypeEnabled = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    ActivityTypeIsCustom = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    ActivityTypeIsHiddenInContentOnly = table.Column<bool>(type: "bit", nullable: false),
                    ActivityTypeMainFormControl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActivityTypeManualCreationAllowed = table.Column<bool>(type: "bit", nullable: true),
                    ActivityTypeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ActivityType", x => x.ActivityTypeID);
                });

            migrationBuilder.CreateTable(
                name: "OM_ContactChangeRecalculationQueue",
                schema: "dbo",
                columns: table => new
                {
                    ContactChangeRecalculationQueueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactChangeRecalculationQueueChangedColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactChangeRecalculationQueueContactID = table.Column<int>(type: "int", nullable: false),
                    ContactChangeRecalculationQueueContactIsNew = table.Column<bool>(type: "bit", nullable: false),
                    ContactChangeRecalculationQueueContactWasMerged = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ContactChangeRecalculationQueue", x => x.ContactChangeRecalculationQueueID);
                });

            migrationBuilder.CreateTable(
                name: "OM_ContactGroup",
                schema: "dbo",
                columns: table => new
                {
                    ContactGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactGroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactGroupDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ContactGroupDynamicCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactGroupEnabled = table.Column<bool>(type: "bit", nullable: true),
                    ContactGroupGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContactGroupLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactGroupName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    ContactGroupStatus = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ContactGroup", x => x.ContactGroupID);
                });

            migrationBuilder.CreateTable(
                name: "OM_ContactRole",
                schema: "dbo",
                columns: table => new
                {
                    ContactRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactRoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactRoleDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    ContactRoleName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ContactRole", x => x.ContactRoleID);
                });

            migrationBuilder.CreateTable(
                name: "OM_ContactStatus",
                schema: "dbo",
                columns: table => new
                {
                    ContactStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactStatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactStatusDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    ContactStatusName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ContactStatus", x => x.ContactStatusID);
                });

            migrationBuilder.CreateTable(
                name: "OM_MVTCombination",
                schema: "dbo",
                columns: table => new
                {
                    MVTCombinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MVTCombinationConversions = table.Column<int>(type: "int", nullable: true),
                    MVTCombinationCustomName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MVTCombinationDocumentID = table.Column<int>(type: "int", nullable: true),
                    MVTCombinationEnabled = table.Column<bool>(type: "bit", nullable: false),
                    MVTCombinationGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MVTCombinationIsDefault = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    MVTCombinationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MVTCombinationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MVTCombinationPageTemplateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_MVTCombination", x => x.MVTCombinationID);
                });

            migrationBuilder.CreateTable(
                name: "OM_Score",
                schema: "dbo",
                columns: table => new
                {
                    ScoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScoreBelongsToPersona = table.Column<bool>(type: "bit", nullable: false),
                    ScoreDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScoreDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ScoreEmailAtScore = table.Column<int>(type: "int", nullable: true),
                    ScoreEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ScoreGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScoreLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScoreName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ScoreNotificationEmail = table.Column<string>(type: "nvarchar(998)", maxLength: 998, nullable: true),
                    ScoreScheduledTaskID = table.Column<int>(type: "int", nullable: true),
                    ScoreStatus = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_Score", x => x.ScoreID);
                });

            migrationBuilder.CreateTable(
                name: "Personas_Persona",
                schema: "dbo",
                columns: table => new
                {
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonaDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    PersonaEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    PersonaGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonaName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'[_][_]AUTO[_][_]')"),
                    PersonaPictureMetafileGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PersonaPointsThreshold = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((100))"),
                    PersonaScoreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas_Persona", x => x.PersonaID);
                });

            migrationBuilder.CreateTable(
                name: "Reporting_ReportCategory",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryParentID = table.Column<int>(type: "int", nullable: true),
                    CategoryChildCount = table.Column<int>(type: "int", nullable: true),
                    CategoryCodeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    CategoryDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    CategoryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryImagePath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CategoryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryLevel = table.Column<int>(type: "int", nullable: true),
                    CategoryPath = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "('')"),
                    CategoryReportChildCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporting_ReportCategory", x => x.CategoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Reporting_ReportCategory_CategoryID_Reporting_ReportCategory_ParentCategoryID",
                        column: x => x.CategoryParentID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_ReportCategory",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "SM_Insight",
                schema: "dbo",
                columns: table => new
                {
                    InsightID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsightCodeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    InsightExternalID = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')"),
                    InsightPeriodType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    InsightValueName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_Insight", x => x.InsightID);
                });

            migrationBuilder.CreateTable(
                name: "SM_LinkedInAccount",
                schema: "dbo",
                columns: table => new
                {
                    LinkedInAccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkedInAccountAccessToken = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    LinkedInAccountAccessTokenExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LinkedInAccountDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    LinkedInAccountGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LinkedInAccountIsDefault = table.Column<bool>(type: "bit", nullable: true),
                    LinkedInAccountLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinkedInAccountLinkedInApplicationID = table.Column<int>(type: "int", nullable: false),
                    LinkedInAccountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    LinkedInAccountProfileID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    LinkedInAccountProfileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LinkedInAccountSiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_LinkedInAccount", x => x.LinkedInAccountID);
                });

            migrationBuilder.CreateTable(
                name: "SOP_BookFolderID",
                schema: "ShoukouhPardis12DBAdmin",
                columns: table => new
                {
                    BookFolderIDID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookFolderID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    BookLevel = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    Branch = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'Pardis')"),
                    URL = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false, defaultValueSql: "(N'pardisTEST')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOP_BookFolderID", x => x.BookFolderIDID);
                });

            migrationBuilder.CreateTable(
                name: "staging_TaskGroup",
                schema: "dbo",
                columns: table => new
                {
                    TaskGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskGroupCodeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    TaskGroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskGroupGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staging_TaskGroup", x => x.TaskGroupID);
                });

            migrationBuilder.CreateTable(
                name: "Temp_File",
                schema: "dbo",
                columns: table => new
                {
                    FileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileDirectory = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    FileExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    FileGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileImageHeight = table.Column<int>(type: "int", nullable: true),
                    FileImageWidth = table.Column<int>(type: "int", nullable: true),
                    FileLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('6/29/2010 1:57:54 PM')"),
                    FileMimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    FileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    FileNumber = table.Column<int>(type: "int", nullable: false),
                    FileParentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    FileTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temp_File", x => x.FileID);
                });

            migrationBuilder.CreateTable(
                name: "Temp_PageBuilderWidgets",
                schema: "dbo",
                columns: table => new
                {
                    PageBuilderWidgetsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageBuilderTemplateConfiguration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageBuilderWidgetsConfiguration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageBuilderWidgetsGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageBuilderWidgetsLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temp_PageBuilderWidgets", x => x.PageBuilderWidgetsID);
                });

            migrationBuilder.CreateTable(
                name: "CMS_ConsentArchive",
                schema: "dbo",
                columns: table => new
                {
                    ConsentArchiveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsentArchiveConsentID = table.Column<int>(type: "int", nullable: false),
                    ConsentArchiveContent = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    ConsentArchiveGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsentArchiveHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    ConsentArchiveLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ConsentArchive", x => x.ConsentArchiveID);
                    table.ForeignKey(
                        name: "FK_CMS_ConsentArchive_ConsentArchiveConsentID_CMS_Consent",
                        column: x => x.ConsentArchiveConsentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Consent",
                        principalColumn: "ConsentID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_State",
                schema: "dbo",
                columns: table => new
                {
                    StateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StateDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    StateGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_State", x => x.StateID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_State_CountryID_CMS_Country",
                        column: x => x.CountryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Country",
                        principalColumn: "CountryID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Site",
                schema: "dbo",
                columns: table => new
                {
                    SiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteDefaultEditorStylesheet = table.Column<int>(type: "int", nullable: true),
                    SiteDefaultStylesheetID = table.Column<int>(type: "int", nullable: true),
                    SiteDefaultVisitorCulture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SiteDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    SiteDomainName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, defaultValueSql: "('')"),
                    SiteGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SiteIsContentOnly = table.Column<bool>(type: "bit", nullable: true),
                    SiteIsOffline = table.Column<bool>(type: "bit", nullable: true),
                    SiteLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SiteName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    SiteOfflineMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteOfflineRedirectURL = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    SitePresentationURL = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    SiteStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Site", x => x.SiteID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Site_SiteDefaultEditorStylesheet_CMS_CssStylesheet",
                        column: x => x.SiteDefaultEditorStylesheet,
                        principalSchema: "dbo",
                        principalTable: "CMS_CssStylesheet",
                        principalColumn: "StylesheetID");
                    table.ForeignKey(
                        name: "FK_CMS_Site_SiteDefaultStylesheetID_CMS_CssStylesheet",
                        column: x => x.SiteDefaultStylesheetID,
                        principalSchema: "dbo",
                        principalTable: "CMS_CssStylesheet",
                        principalColumn: "StylesheetID");
                });

            migrationBuilder.CreateTable(
                name: "BadWords_WordCulture",
                schema: "dbo",
                columns: table => new
                {
                    WordID = table.Column<int>(type: "int", nullable: false),
                    CultureID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BadWords_WordCulture", x => new { x.WordID, x.CultureID });
                    table.ForeignKey(
                        name: "FK_BadWords_WordCulture_CultureID_CMS_Culture",
                        column: x => x.CultureID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Culture",
                        principalColumn: "CultureID");
                    table.ForeignKey(
                        name: "FK_BadWords_WordCulture_WordID_BadWords_Word",
                        column: x => x.WordID,
                        principalSchema: "dbo",
                        principalTable: "BadWords_Word",
                        principalColumn: "WordID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_AttachmentForEmail",
                schema: "dbo",
                columns: table => new
                {
                    EmailID = table.Column<int>(type: "int", nullable: false),
                    AttachmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_AttachmentForEmail", x => new { x.EmailID, x.AttachmentID });
                    table.ForeignKey(
                        name: "FK_CMS_AttachmentForEmail_AttachmentID_CMS_EmailAttachment",
                        column: x => x.AttachmentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_EmailAttachment",
                        principalColumn: "AttachmentID");
                    table.ForeignKey(
                        name: "FK_CMS_AttachmentForEmail_EmailID_CMS_Email",
                        column: x => x.EmailID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Email",
                        principalColumn: "EmailID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_DeviceProfileLayout",
                schema: "dbo",
                columns: table => new
                {
                    DeviceProfileLayoutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeviceProfileID = table.Column<int>(type: "int", nullable: false),
                    SourceLayoutID = table.Column<int>(type: "int", nullable: false),
                    TargetLayoutID = table.Column<int>(type: "int", nullable: false),
                    DeviceProfileLayoutGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeviceProfileLayoutLastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_DeviceProfileLayout", x => x.DeviceProfileLayoutID);
                    table.ForeignKey(
                        name: "FK_CMS_DeviceProfileLayout_DeviceProfileID_CMS_DeviceProfile",
                        column: x => x.DeviceProfileID,
                        principalSchema: "dbo",
                        principalTable: "CMS_DeviceProfile",
                        principalColumn: "ProfileID");
                    table.ForeignKey(
                        name: "FK_CMS_DeviceProfileLayout_SourceLayoutID_CMS_Layout",
                        column: x => x.SourceLayoutID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Layout",
                        principalColumn: "LayoutID");
                    table.ForeignKey(
                        name: "FK_CMS_DeviceProfileLayout_TargetLayoutID_CMS_Layout",
                        column: x => x.TargetLayoutID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Layout",
                        principalColumn: "LayoutID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_FormUserControl",
                schema: "dbo",
                columns: table => new
                {
                    UserControlID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserControlParentID = table.Column<int>(type: "int", nullable: true),
                    UserControlResourceID = table.Column<int>(type: "int", nullable: true),
                    UserControlAssemblyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserControlClassName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserControlCodeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserControlDefaultDataType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserControlDefaultDataTypeSize = table.Column<int>(type: "int", nullable: true),
                    UserControlDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserControlDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserControlFileName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    UserControlForBinary = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForBoolean = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForDateTime = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForDecimal = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForDocAttachments = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForDocRelationships = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForFile = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForGuid = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForInteger = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForLongText = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForText = table.Column<bool>(type: "bit", nullable: false),
                    UserControlForVisibility = table.Column<bool>(type: "bit", nullable: false),
                    UserControlGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserControlIsSystem = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    UserControlLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserControlParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserControlPriority = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    UserControlShowInBizForms = table.Column<bool>(type: "bit", nullable: false),
                    UserControlShowInCustomTables = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    UserControlShowInDocumentTypes = table.Column<bool>(type: "bit", nullable: true),
                    UserControlShowInReports = table.Column<bool>(type: "bit", nullable: true),
                    UserControlShowInSystemTables = table.Column<bool>(type: "bit", nullable: true),
                    UserControlShowInWebParts = table.Column<bool>(type: "bit", nullable: true),
                    UserControlThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserControlType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_FormUserControl", x => x.UserControlID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_FormUserControl_UserControlParentID_CMS_FormUserControl",
                        column: x => x.UserControlParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_FormUserControl",
                        principalColumn: "UserControlID");
                    table.ForeignKey(
                        name: "FK_CMS_FormUserControl_UserControlResourceID_CMS_Resource",
                        column: x => x.UserControlResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ModuleLicenseKey",
                schema: "dbo",
                columns: table => new
                {
                    ModuleLicenseKeyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleLicenseKeyResourceID = table.Column<int>(type: "int", nullable: false),
                    ModuleLicenseKeyGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuleLicenseKeyLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    ModuleLicenseKeyLicense = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ModuleLicenseKey", x => x.ModuleLicenseKeyID);
                    table.ForeignKey(
                        name: "FK_CMS_ModuleLicenseKey_ModuleLicenseKeyResourceID_CMS_Resource",
                        column: x => x.ModuleLicenseKeyResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ResourceLibrary",
                schema: "dbo",
                columns: table => new
                {
                    ResourceLibraryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceLibraryResourceID = table.Column<int>(type: "int", nullable: false),
                    ResourceLibraryPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ResourceLibrary", x => x.ResourceLibraryID);
                    table.ForeignKey(
                        name: "FK_CMS_ResourceLibrary_CMS_Resource",
                        column: x => x.ResourceLibraryResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_SettingsCategory",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryParentID = table.Column<int>(type: "int", nullable: true),
                    CategoryResourceID = table.Column<int>(type: "int", nullable: true),
                    CategoryChildCount = table.Column<int>(type: "int", nullable: true),
                    CategoryDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    CategoryIconPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CategoryIDPath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CategoryIsCustom = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CategoryIsGroup = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CategoryLevel = table.Column<int>(type: "int", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CategoryOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SettingsCategory", x => x.CategoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_SettingsCategory_CMS_SettingsCategory1",
                        column: x => x.CategoryParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_SettingsCategory",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_CMS_SettingsCategory_CategoryResourceID_CMS_Resource",
                        column: x => x.CategoryResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WorkflowAction",
                schema: "dbo",
                columns: table => new
                {
                    ActionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActionResourceID = table.Column<int>(type: "int", nullable: true),
                    ActionAllowedObjects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionAssemblyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ActionClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ActionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ActionEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ActionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionIconClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActionIconGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ActionParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionThumbnailClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ActionThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActionWorkflowType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WorkflowAction", x => x.ActionID);
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowAction_ActionResourceID",
                        column: x => x.ActionResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ResourceTranslation",
                schema: "dbo",
                columns: table => new
                {
                    TranslationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TranslationCultureID = table.Column<int>(type: "int", nullable: false),
                    TranslationStringID = table.Column<int>(type: "int", nullable: false),
                    TranslationText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ResourceTranslation", x => x.TranslationID);
                    table.ForeignKey(
                        name: "FK_CMS_ResourceTranslation_TranslationCultureID_CMS_Culture",
                        column: x => x.TranslationCultureID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Culture",
                        principalColumn: "CultureID");
                    table.ForeignKey(
                        name: "FK_CMS_ResourceTranslation_TranslationStringID_CMS_ResourceString",
                        column: x => x.TranslationStringID,
                        principalSchema: "dbo",
                        principalTable: "CMS_ResourceString",
                        principalColumn: "StringID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_SearchIndexCulture",
                schema: "dbo",
                columns: table => new
                {
                    IndexID = table.Column<int>(type: "int", nullable: false),
                    IndexCultureID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SearchIndexCulture", x => new { x.IndexID, x.IndexCultureID });
                    table.ForeignKey(
                        name: "FK_CMS_SearchIndexCulture_IndexCultureID_CMS_Culture",
                        column: x => x.IndexCultureID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Culture",
                        principalColumn: "CultureID");
                    table.ForeignKey(
                        name: "FK_CMS_SearchIndexCulture_IndexID_CMS_SearchIndex",
                        column: x => x.IndexID,
                        principalSchema: "dbo",
                        principalTable: "CMS_SearchIndex",
                        principalColumn: "IndexID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_User",
                schema: "dbo",
                columns: table => new
                {
                    ChatUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatUserUserID = table.Column<int>(type: "int", nullable: true),
                    ChatUserLastModification = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('2/20/2012 2:02:00 PM')"),
                    ChatUserNickname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_User", x => x.ChatUserID);
                    table.ForeignKey(
                        name: "FK_Chat_User_CMS_User",
                        column: x => x.ChatUserUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_EmailUser",
                schema: "dbo",
                columns: table => new
                {
                    EmailID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    LastSendAttempt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastSendResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_EmailUser", x => new { x.EmailID, x.UserID });
                    table.ForeignKey(
                        name: "FK_CMS_EmailUser_EmailID_CMS_Email",
                        column: x => x.EmailID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Email",
                        principalColumn: "EmailID");
                    table.ForeignKey(
                        name: "FK_CMS_EmailUser_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ExternalLogin",
                schema: "dbo",
                columns: table => new
                {
                    ExternalLoginID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    IdentityKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LoginProvider = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ExternalLogin", x => x.ExternalLoginID);
                    table.ForeignKey(
                        name: "FK_CMS_ExternalLogin_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_MacroIdentity",
                schema: "dbo",
                columns: table => new
                {
                    MacroIdentityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MacroIdentityEffectiveUserID = table.Column<int>(type: "int", nullable: true),
                    MacroIdentityGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MacroIdentityLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    MacroIdentityName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_MacroIdentity", x => x.MacroIdentityID);
                    table.ForeignKey(
                        name: "FK_CMS_MacroIdentity_MacroIdentityEffectiveUserID_CMS_User",
                        column: x => x.MacroIdentityEffectiveUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_OpenIDUser",
                schema: "dbo",
                columns: table => new
                {
                    OpenIDUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    OpenID = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "('')"),
                    OpenIDProviderURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_OpenIDUser", x => x.OpenIDUserID);
                    table.ForeignKey(
                        name: "FK_CMS_OpenIDUser_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_TranslationSubmission",
                schema: "dbo",
                columns: table => new
                {
                    SubmissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmissionServiceID = table.Column<int>(type: "int", nullable: false),
                    SubmissionSubmittedByUserID = table.Column<int>(type: "int", nullable: true),
                    SubmissionCharCount = table.Column<int>(type: "int", nullable: true),
                    SubmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubmissionDeadline = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmissionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubmissionInstructions = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SubmissionItemCount = table.Column<int>(type: "int", nullable: false),
                    SubmissionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubmissionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubmissionPrice = table.Column<double>(type: "float", nullable: true),
                    SubmissionPriority = table.Column<int>(type: "int", nullable: false),
                    SubmissionSiteID = table.Column<int>(type: "int", nullable: true),
                    SubmissionSourceCulture = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SubmissionStatus = table.Column<int>(type: "int", nullable: false),
                    SubmissionStatusMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionTargetCulture = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    SubmissionTicket = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SubmissionTranslateAttachments = table.Column<bool>(type: "bit", nullable: true),
                    SubmissionWordCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_TranslationSubmission", x => x.SubmissionID);
                    table.ForeignKey(
                        name: "FK_CMS_TranslationSubmission_CMS_TranslationService",
                        column: x => x.SubmissionServiceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_TranslationService",
                        principalColumn: "TranslationServiceID");
                    table.ForeignKey(
                        name: "FK_CMS_TranslationSubmission_CMS_User",
                        column: x => x.SubmissionSubmittedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_UserSettings",
                schema: "dbo",
                columns: table => new
                {
                    UserSettingsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserActivatedByUserID = table.Column<int>(type: "int", nullable: true),
                    UserAvatarID = table.Column<int>(type: "int", nullable: true),
                    UserBadgeID = table.Column<int>(type: "int", nullable: true),
                    UserSettingsUserGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserSettingsUserID = table.Column<int>(type: "int", nullable: false),
                    UserTimeZoneID = table.Column<int>(type: "int", nullable: true),
                    UserAccountLockReason = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    UserActivationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserActivityPoints = table.Column<int>(type: "int", nullable: true),
                    UserAuthenticationGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserAvatarType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserBlogComments = table.Column<int>(type: "int", nullable: true),
                    UserBlogPosts = table.Column<int>(type: "int", nullable: true),
                    UserCampaign = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDashboardApplications = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDialogsConfiguration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDismissedSmartTips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserFacebookID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserForumPosts = table.Column<int>(type: "int", nullable: true),
                    UserGender = table.Column<int>(type: "int", nullable: true),
                    UserIM = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserInvalidLogOnAttempts = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    UserInvalidLogOnAttemptsHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserLinkedInID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserLogActivities = table.Column<bool>(type: "bit", nullable: true),
                    UserMessageBoardPosts = table.Column<int>(type: "int", nullable: true),
                    UserNickName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserPasswordLastChanged = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserPasswordRequestHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserPhone = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    UserPicture = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserPosition = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    UserPreferences = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserRegistrationInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserShowIntroductionTile = table.Column<bool>(type: "bit", nullable: true),
                    UserSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserSkype = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UserURLReferrer = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    UserUsedWebParts = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    UserUsedWidgets = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    UserWaitingForApproval = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    WindowsLiveID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_UserSettings", x => x.UserSettingsID);
                    table.ForeignKey(
                        name: "FK_CMS_UserSettings_UserActivatedByUserID_CMS_User",
                        column: x => x.UserActivatedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_UserSettings_UserAvatarID_CMS_Avatar",
                        column: x => x.UserAvatarID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Avatar",
                        principalColumn: "AvatarID");
                    table.ForeignKey(
                        name: "FK_CMS_UserSettings_UserBadgeID_CMS_Badge",
                        column: x => x.UserBadgeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Badge",
                        principalColumn: "BadgeID");
                    table.ForeignKey(
                        name: "FK_CMS_UserSettings_UserSettingsUserGUID_CMS_User",
                        column: x => x.UserSettingsUserGUID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserGUID");
                    table.ForeignKey(
                        name: "FK_CMS_UserSettings_UserSettingsUserID_CMS_User",
                        column: x => x.UserSettingsUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_UserSettings_UserTimeZoneID_CMS_TimeZone",
                        column: x => x.UserTimeZoneID,
                        principalSchema: "dbo",
                        principalTable: "CMS_TimeZone",
                        principalColumn: "TimeZoneID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebFarmServerTask",
                schema: "dbo",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false),
                    TaskID = table.Column<int>(type: "int", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebFarmServerTask", x => new { x.ServerID, x.TaskID });
                    table.ForeignKey(
                        name: "FK_CMS_WebFarmServerTask_ServerID_CMS_WebFarmServer",
                        column: x => x.ServerID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WebFarmServer",
                        principalColumn: "ServerID");
                    table.ForeignKey(
                        name: "FK_CMS_WebFarmServerTask_TaskID_CMS_WebFarmTask",
                        column: x => x.TaskID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WebFarmTask",
                        principalColumn: "TaskID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebPart",
                schema: "dbo",
                columns: table => new
                {
                    WebPartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebPartCategoryID = table.Column<int>(type: "int", nullable: false),
                    WebPartParentID = table.Column<int>(type: "int", nullable: true),
                    WebPartResourceID = table.Column<int>(type: "int", nullable: true),
                    WebPartCSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPartDefaultConfiguration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPartDefaultValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPartDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPartDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    WebPartDocumentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPartFileName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    WebPartGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WebPartIconClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WebPartLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    WebPartName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    WebPartProperties = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    WebPartSkipInsertProperties = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    WebPartThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    WebPartType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebPart", x => x.WebPartID);
                    table.ForeignKey(
                        name: "FK_CMS_WebPart_WebPartCategoryID_CMS_WebPartCategory",
                        column: x => x.WebPartCategoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WebPartCategory",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_CMS_WebPart_WebPartParentID_CMS_WebPart",
                        column: x => x.WebPartParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WebPart",
                        principalColumn: "WebPartID");
                    table.ForeignKey(
                        name: "FK_CMS_WebPart_WebPartResourceID_CMS_Resource",
                        column: x => x.WebPartResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ObjectWorkflowTrigger",
                schema: "dbo",
                columns: table => new
                {
                    TriggerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TriggerWorkflowID = table.Column<int>(type: "int", nullable: false),
                    TriggerDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "('')"),
                    TriggerGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TriggerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TriggerMacroCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TriggerObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    TriggerParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TriggerTargetObjectID = table.Column<int>(type: "int", nullable: true),
                    TriggerTargetObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TriggerType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ObjectWorkflowTrigger", x => x.TriggerID);
                    table.ForeignKey(
                        name: "FK_CMS_ObjectWorkflowTrigger_TriggerWorkflowID",
                        column: x => x.TriggerWorkflowID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Workflow",
                        principalColumn: "WorkflowID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WorkflowUser",
                schema: "dbo",
                columns: table => new
                {
                    WorkflowID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WorkflowUser_1", x => new { x.WorkflowID, x.UserID });
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowUser_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowUser_WorkflowID_CMS_Workflow",
                        column: x => x.WorkflowID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Workflow",
                        principalColumn: "WorkflowID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_IssueContactGroup",
                schema: "dbo",
                columns: table => new
                {
                    IssueContactGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactGroupID = table.Column<int>(type: "int", nullable: false),
                    IssueID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_IssueContactGroup", x => x.IssueContactGroupID);
                    table.ForeignKey(
                        name: "FK_Newsletter_IssueContactGroup_ContactGroupID",
                        column: x => x.ContactGroupID,
                        principalSchema: "dbo",
                        principalTable: "OM_ContactGroup",
                        principalColumn: "ContactGroupID");
                });

            migrationBuilder.CreateTable(
                name: "OM_ContactGroupMember",
                schema: "dbo",
                columns: table => new
                {
                    ContactGroupMemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactGroupMemberContactGroupID = table.Column<int>(type: "int", nullable: false),
                    ContactGroupMemberFromAccount = table.Column<bool>(type: "bit", nullable: true),
                    ContactGroupMemberFromCondition = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ContactGroupMemberFromManual = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ContactGroupMemberRelatedID = table.Column<int>(type: "int", nullable: false),
                    ContactGroupMemberType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ContactGroupMember", x => x.ContactGroupMemberID);
                    table.ForeignKey(
                        name: "FK_OM_ContactGroupMembers_OM_ContactGroup",
                        column: x => x.ContactGroupMemberContactGroupID,
                        principalSchema: "dbo",
                        principalTable: "OM_ContactGroup",
                        principalColumn: "ContactGroupID");
                });

            migrationBuilder.CreateTable(
                name: "OM_Rule",
                schema: "dbo",
                columns: table => new
                {
                    RuleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RuleScoreID = table.Column<int>(type: "int", nullable: false),
                    RuleBelongsToPersona = table.Column<bool>(type: "bit", nullable: false),
                    RuleCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RuleDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    RuleGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RuleIsRecurring = table.Column<bool>(type: "bit", nullable: true),
                    RuleLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RuleMaxPoints = table.Column<int>(type: "int", nullable: true),
                    RuleName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'[_][_]AUTO[_][_]')"),
                    RuleParameter = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    RuleType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    RuleValidFor = table.Column<int>(type: "int", nullable: true),
                    RuleValidUntil = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RuleValidity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RuleValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_Rule", x => x.RuleID);
                    table.ForeignKey(
                        name: "FK_OM_Rule_OM_Score",
                        column: x => x.RuleScoreID,
                        principalSchema: "dbo",
                        principalTable: "OM_Score",
                        principalColumn: "ScoreID");
                });

            migrationBuilder.CreateTable(
                name: "Personas_PersonaContactHistory",
                schema: "dbo",
                columns: table => new
                {
                    PersonaContactHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaContactHistoryPersonaID = table.Column<int>(type: "int", nullable: true),
                    PersonaContactHistoryContacts = table.Column<int>(type: "int", nullable: false),
                    PersonaContactHistoryDate = table.Column<DateTime>(type: "date", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas_PersonaContactHistory", x => x.PersonaContactHistoryID);
                    table.ForeignKey(
                        name: "FK_Personas_PersonaContactHistory_Personas_Persona",
                        column: x => x.PersonaContactHistoryPersonaID,
                        principalSchema: "dbo",
                        principalTable: "Personas_Persona",
                        principalColumn: "PersonaID");
                });

            migrationBuilder.CreateTable(
                name: "Reporting_Report",
                schema: "dbo",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportCategoryID = table.Column<int>(type: "int", nullable: false),
                    ReportAccess = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    ReportConnectionString = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReportDisplayName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: false, defaultValueSql: "('')"),
                    ReportEnableSubscription = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ReportGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReportLayout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    ReportParameters = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporting_Report", x => x.ReportID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Reporting_Report_ReportCategoryID_Reporting_ReportCategory",
                        column: x => x.ReportCategoryID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_ReportCategory",
                        principalColumn: "CategoryID");
                });

            migrationBuilder.CreateTable(
                name: "SM_InsightHit_Day",
                schema: "dbo",
                columns: table => new
                {
                    InsightHitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsightHitInsightID = table.Column<int>(type: "int", nullable: false),
                    InsightHitPeriodFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsightHitPeriodTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsightHitValue = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_InsightHit_Day", x => x.InsightHitID);
                    table.ForeignKey(
                        name: "FK_SM_InsightHit_Day_SM_Insight_InsightHitInsightID",
                        column: x => x.InsightHitInsightID,
                        principalSchema: "dbo",
                        principalTable: "SM_Insight",
                        principalColumn: "InsightID");
                });

            migrationBuilder.CreateTable(
                name: "SM_InsightHit_Month",
                schema: "dbo",
                columns: table => new
                {
                    InsightHitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsightHitInsightID = table.Column<int>(type: "int", nullable: false),
                    InsightHitPeriodFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsightHitPeriodTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsightHitValue = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_InsightHit_Month", x => x.InsightHitID);
                    table.ForeignKey(
                        name: "FK_SM_InsightHit_Month_SM_Insight_InsightHitInsightID",
                        column: x => x.InsightHitInsightID,
                        principalSchema: "dbo",
                        principalTable: "SM_Insight",
                        principalColumn: "InsightID");
                });

            migrationBuilder.CreateTable(
                name: "SM_InsightHit_Week",
                schema: "dbo",
                columns: table => new
                {
                    InsightHitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsightHitInsightID = table.Column<int>(type: "int", nullable: false),
                    InsightHitPeriodFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsightHitPeriodTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsightHitValue = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_InsightHit_Week", x => x.InsightHitID);
                    table.ForeignKey(
                        name: "FK_SM_InsightHit_Week_SM_Insight_InsightHitInsightID",
                        column: x => x.InsightHitInsightID,
                        principalSchema: "dbo",
                        principalTable: "SM_Insight",
                        principalColumn: "InsightID");
                });

            migrationBuilder.CreateTable(
                name: "SM_InsightHit_Year",
                schema: "dbo",
                columns: table => new
                {
                    InsightHitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsightHitInsightID = table.Column<int>(type: "int", nullable: false),
                    InsightHitPeriodFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsightHitPeriodTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsightHitValue = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_InsightHit_Year", x => x.InsightHitID);
                    table.ForeignKey(
                        name: "FK_SM_InsightHit_Year_SM_Insight_InsightHitInsightID",
                        column: x => x.InsightHitInsightID,
                        principalSchema: "dbo",
                        principalTable: "SM_Insight",
                        principalColumn: "InsightID");
                });

            migrationBuilder.CreateTable(
                name: "staging_TaskGroupUser",
                schema: "dbo",
                columns: table => new
                {
                    TaskGroupUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskGroupID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staging_TaskGroupUser", x => x.TaskGroupUserID);
                    table.ForeignKey(
                        name: "FK_Staging_TaskGroupUser_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Staging_TaskGroupUser_Staging_TaskGroup",
                        column: x => x.TaskGroupID,
                        principalSchema: "dbo",
                        principalTable: "staging_TaskGroup",
                        principalColumn: "TaskGroupID");
                });

            migrationBuilder.CreateTable(
                name: "OM_Contact",
                schema: "dbo",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactCountryID = table.Column<int>(type: "int", nullable: true),
                    ContactOwnerUserID = table.Column<int>(type: "int", nullable: true),
                    ContactStateID = table.Column<int>(type: "int", nullable: true),
                    ContactStatusID = table.Column<int>(type: "int", nullable: true),
                    ContactAddress1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactBirthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactBounces = table.Column<int>(type: "int", nullable: true),
                    ContactBusinessPhone = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    ContactCampaign = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ContactCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactCompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactCreated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('5/3/2011 10:51:13 AM')"),
                    ContactEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    ContactFirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactGender = table.Column<int>(type: "int", nullable: true),
                    ContactGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactJobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactLastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactMiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactMobilePhone = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    ContactMonitored = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ContactNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersonaID = table.Column<int>(type: "int", nullable: true),
                    ContactSalesForceLeadID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    ContactSalesForceLeadReplicationDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactSalesForceLeadReplicationDisabled = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ContactSalesForceLeadReplicationRequired = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ContactSalesForceLeadReplicationSuspensionDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactZIP = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_Contact", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_OM_Contact_CMS_Country",
                        column: x => x.ContactCountryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Country",
                        principalColumn: "CountryID");
                    table.ForeignKey(
                        name: "FK_OM_Contact_CMS_State",
                        column: x => x.ContactStateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_State",
                        principalColumn: "StateID");
                    table.ForeignKey(
                        name: "FK_OM_Contact_CMS_User",
                        column: x => x.ContactOwnerUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_OM_Contact_OM_ContactStatus",
                        column: x => x.ContactStatusID,
                        principalSchema: "dbo",
                        principalTable: "OM_ContactStatus",
                        principalColumn: "ContactStatusID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_Conversion",
                schema: "dbo",
                columns: table => new
                {
                    ConversionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConversionSiteID = table.Column<int>(type: "int", nullable: false),
                    ConversionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConversionDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ConversionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConversionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConversionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Conversion", x => x.ConversionID);
                    table.ForeignKey(
                        name: "FK_Analytics_Conversion_ConversionSiteID_CMS_Site",
                        column: x => x.ConversionSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_Statistics",
                schema: "dbo",
                columns: table => new
                {
                    StatisticsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatisticsSiteID = table.Column<int>(type: "int", nullable: true),
                    StatisticsCode = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, defaultValueSql: "('')"),
                    StatisticsObjectCulture = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true, defaultValueSql: "(N'')"),
                    StatisticsObjectID = table.Column<int>(type: "int", nullable: true),
                    StatisticsObjectName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_Statistics", x => x.StatisticsID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Analytics_Statistics_StatisticsSiteID_CMS_Site",
                        column: x => x.StatisticsSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_AbuseReport",
                schema: "dbo",
                columns: table => new
                {
                    ReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportSiteID = table.Column<int>(type: "int", nullable: false),
                    ReportUserID = table.Column<int>(type: "int", nullable: true),
                    ReportComment = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')"),
                    ReportCulture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ReportGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportObjectID = table.Column<int>(type: "int", nullable: true),
                    ReportObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReportStatus = table.Column<int>(type: "int", nullable: false),
                    ReportTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('')"),
                    ReportURL = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, defaultValueSql: "('')"),
                    ReportWhen = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/11/2008 4:32:15 PM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_AbuseReport", x => x.ReportID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_AbuseReport_ReportSiteID_CMS_Site",
                        column: x => x.ReportSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_AbuseReport_ReportUserID_CMS_User",
                        column: x => x.ReportUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ACL",
                schema: "dbo",
                columns: table => new
                {
                    ACLID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACLSiteID = table.Column<int>(type: "int", nullable: true),
                    ACLGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ACLInheritedACLs = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "('')"),
                    ACLLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('10/30/2008 9:17:31 AM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ACL", x => x.ACLID);
                    table.ForeignKey(
                        name: "FK_CMS_ACL_ACLSiteID_CMS_Site",
                        column: x => x.ACLSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_AttachmentHistory",
                schema: "dbo",
                columns: table => new
                {
                    AttachmentHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentSiteID = table.Column<int>(type: "int", nullable: false),
                    AttachmentVariantParentID = table.Column<int>(type: "int", nullable: true),
                    AttachmentBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AttachmentCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentDocumentID = table.Column<int>(type: "int", nullable: false),
                    AttachmentExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttachmentGroupGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttachmentHash = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    AttachmentHistoryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttachmentImageHeight = table.Column<int>(type: "int", nullable: true),
                    AttachmentImageWidth = table.Column<int>(type: "int", nullable: true),
                    AttachmentIsUnsorted = table.Column<bool>(type: "bit", nullable: true),
                    AttachmentLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttachmentMimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AttachmentOrder = table.Column<int>(type: "int", nullable: true),
                    AttachmentSearchContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentSize = table.Column<int>(type: "int", nullable: false),
                    AttachmentTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AttachmentVariantDefinitionIdentifier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_AttachmentHistory", x => x.AttachmentHistoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_AttachmentHistory_AttachmentSiteID_CMS_Site",
                        column: x => x.AttachmentSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_AttachmentHistory_AttachmentVariantParentID_CMS_AttachmentHistory",
                        column: x => x.AttachmentVariantParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_AttachmentHistory",
                        principalColumn: "AttachmentHistoryID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_BannedIP",
                schema: "dbo",
                columns: table => new
                {
                    IPAddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IPAddressSiteID = table.Column<int>(type: "int", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IPAddressAllowOverride = table.Column<bool>(type: "bit", nullable: false),
                    IPAddressAllowed = table.Column<bool>(type: "bit", nullable: false),
                    IPAddressBanEnabled = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    IPAddressBanReason = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    IPAddressBanType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IPAddressGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IPAddressLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IPAddressRegular = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_BannedIP", x => x.IPAddressID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_BannedIP_IPAddressSiteID_CMS_Site",
                        column: x => x.IPAddressSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_BannerCategory",
                schema: "dbo",
                columns: table => new
                {
                    BannerCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BannerCategorySiteID = table.Column<int>(type: "int", nullable: true),
                    BannerCategoryDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    BannerCategoryEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    BannerCategoryGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BannerCategoryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/1970 12:00:00 AM')"),
                    BannerCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CMS_BannerCategory", x => x.BannerCategoryID);
                    table.ForeignKey(
                        name: "FK_CMS_BannerCategory_CMS_Site",
                        column: x => x.BannerCategorySiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Category",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorySiteID = table.Column<int>(type: "int", nullable: true),
                    CategoryUserID = table.Column<int>(type: "int", nullable: true),
                    CategoryCount = table.Column<int>(type: "int", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    CategoryEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    CategoryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryIDPath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CategoryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryLevel = table.Column<int>(type: "int", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    CategoryNamePath = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    CategoryOrder = table.Column<int>(type: "int", nullable: true),
                    CategoryParentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Category", x => x.CategoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Category_CategorySiteID_CMS_Site",
                        column: x => x.CategorySiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_Category_CategoryUserID_CMS_User",
                        column: x => x.CategoryUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_CssStylesheetSite",
                schema: "dbo",
                columns: table => new
                {
                    StylesheetID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_CssStylesheetSite", x => new { x.StylesheetID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_CMS_CssStylesheetSite_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_CssStylesheetSite_StylesheetID_CMS_CssStylesheet",
                        column: x => x.StylesheetID,
                        principalSchema: "dbo",
                        principalTable: "CMS_CssStylesheet",
                        principalColumn: "StylesheetID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_DocumentTypeScope",
                schema: "dbo",
                columns: table => new
                {
                    ScopeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScopeSiteID = table.Column<int>(type: "int", nullable: true),
                    ScopeAllowABVariant = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ScopeAllowAllTypes = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ScopeAllowLinks = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ScopeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ScopeIncludeChildren = table.Column<bool>(type: "bit", nullable: true),
                    ScopeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('4/30/2013 2:47:21 PM')"),
                    ScopeMacroCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScopePath = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_DocumentTypeScope", x => x.ScopeID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_DocumentTypeScope_ScopeSiteID_CMS_Site",
                        column: x => x.ScopeSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_EmailTemplate",
                schema: "dbo",
                columns: table => new
                {
                    EmailTemplateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailTemplateSiteID = table.Column<int>(type: "int", nullable: true),
                    EmailTemplateBcc = table.Column<string>(type: "nvarchar(998)", maxLength: 998, nullable: true),
                    EmailTemplateCc = table.Column<string>(type: "nvarchar(998)", maxLength: 998, nullable: true),
                    EmailTemplateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailTemplateDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    EmailTemplateFrom = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    EmailTemplateGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailTemplateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    EmailTemplatePlainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailTemplateReplyTo = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    EmailTemplateSubject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    EmailTemplateText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailTemplateType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_EmailTemplate", x => x.EmailTemplateID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Email_EmailTemplateSiteID_CMS_Site",
                        column: x => x.EmailTemplateSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Membership",
                schema: "dbo",
                columns: table => new
                {
                    MembershipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipSiteID = table.Column<int>(type: "int", nullable: true),
                    MembershipDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MembershipDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MembershipGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MembershipLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MembershipName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Membership", x => x.MembershipID);
                    table.ForeignKey(
                        name: "FK_CMS_Membership_MembershipSiteID_CMS_Site",
                        column: x => x.MembershipSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_MetaFile",
                schema: "dbo",
                columns: table => new
                {
                    MetaFileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetaFileSiteID = table.Column<int>(type: "int", nullable: true),
                    MetaFileBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MetaFileCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaFileDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetaFileExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MetaFileGroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MetaFileGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MetaFileImageHeight = table.Column<int>(type: "int", nullable: true),
                    MetaFileImageWidth = table.Column<int>(type: "int", nullable: true),
                    MetaFileLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MetaFileMimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MetaFileName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MetaFileObjectID = table.Column<int>(type: "int", nullable: false),
                    MetaFileObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MetaFileSize = table.Column<int>(type: "int", nullable: false),
                    MetaFileTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_MetaFile", x => x.MetaFileID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_MetaFile_MetaFileSiteID_CMS_Site",
                        column: x => x.MetaFileSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ObjectVersionHistory",
                schema: "dbo",
                columns: table => new
                {
                    VersionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VersionDeletedByUserID = table.Column<int>(type: "int", nullable: true),
                    VersionModifiedByUserID = table.Column<int>(type: "int", nullable: true),
                    VersionObjectSiteID = table.Column<int>(type: "int", nullable: true),
                    VersionBinaryDataXML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionDeletedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VersionModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VersionNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    VersionObjectDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    VersionObjectID = table.Column<int>(type: "int", nullable: true),
                    VersionObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    VersionSiteBindingIDs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionXML = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ObjectVersionHistory_VersionID", x => x.VersionID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_ObjectVersionHistory_VersionDeletedByUserID_CMS_User",
                        column: x => x.VersionDeletedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_ObjectVersionHistory_VersionModifiedByUserID_CMS_User",
                        column: x => x.VersionModifiedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_ObjectVersionHistory_VersionObjectSiteID_CMS_Site",
                        column: x => x.VersionObjectSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_PageTemplate",
                schema: "dbo",
                columns: table => new
                {
                    PageTemplateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageTemplateCategoryID = table.Column<int>(type: "int", nullable: true),
                    PageTemplateLayoutID = table.Column<int>(type: "int", nullable: true),
                    PageTemplateSiteID = table.Column<int>(type: "int", nullable: true),
                    PageTemplateAllowInheritHeader = table.Column<bool>(type: "bit", nullable: true),
                    PageTemplateCloneAsAdHoc = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PageTemplateCodeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    PageTemplateCSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTemplateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTemplateDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    PageTemplateFile = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    PageTemplateForAllPages = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    PageTemplateGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageTemplateHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTemplateIconClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "(N'icon-layout')"),
                    PageTemplateInheritPageLevels = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PageTemplateInheritParentHeader = table.Column<bool>(type: "bit", nullable: true),
                    PageTemplateIsAllowedForProductSection = table.Column<bool>(type: "bit", nullable: true),
                    PageTemplateIsLayout = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PageTemplateIsReusable = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PageTemplateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PageTemplateLayout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTemplateLayoutType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PageTemplateMasterPageTemplateID = table.Column<int>(type: "int", nullable: true),
                    PageTemplateNodeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PageTemplateProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTemplateShowAsMasterTemplate = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PageTemplateThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PageTemplateType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false, defaultValueSql: "(N'portal')"),
                    PageTemplateVersionGUID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PageTemplateWebParts = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_PageTemplate", x => x.PageTemplateID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplate_PageTemplateCategoryID_CMS_PageTemplateCategory",
                        column: x => x.PageTemplateCategoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplateCategory",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplate_PageTemplateLayoutID_CMS_Layout",
                        column: x => x.PageTemplateLayoutID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Layout",
                        principalColumn: "LayoutID");
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplate_PageTemplateSiteID_CMS_Site",
                        column: x => x.PageTemplateSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_PageTemplateConfiguration",
                schema: "dbo",
                columns: table => new
                {
                    PageTemplateConfigurationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageTemplateConfigurationSiteID = table.Column<int>(type: "int", nullable: false),
                    PageTemplateConfigurationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTemplateConfigurationGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageTemplateConfigurationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    PageTemplateConfigurationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    PageTemplateConfigurationTemplate = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    PageTemplateConfigurationThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PageTemplateConfigurationWidgets = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_PageTemplateConfiguration", x => x.PageTemplateConfigurationID);
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplateConfiguration_PageTemplateConfigurationSiteID_CMS_Site",
                        column: x => x.PageTemplateConfigurationSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_RelationshipNameSite",
                schema: "dbo",
                columns: table => new
                {
                    RelationshipNameID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_RelationshipNameSite", x => new { x.RelationshipNameID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_CMS_RelationshipNameSite_RelationshipNameID_CMS_RelationshipName",
                        column: x => x.RelationshipNameID,
                        principalSchema: "dbo",
                        principalTable: "CMS_RelationshipName",
                        principalColumn: "RelationshipNameID");
                    table.ForeignKey(
                        name: "FK_CMS_RelationshipNameSite_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ResourceSite",
                schema: "dbo",
                columns: table => new
                {
                    ResourceID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ResourceSite", x => new { x.ResourceID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_CMS_ResourceSite_ResourceID_CMS_Resource",
                        column: x => x.ResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                    table.ForeignKey(
                        name: "FK_CMS_ResourceSite_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ScheduledTask",
                schema: "dbo",
                columns: table => new
                {
                    TaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskResourceID = table.Column<int>(type: "int", nullable: true),
                    TaskSiteID = table.Column<int>(type: "int", nullable: true),
                    TaskUserID = table.Column<int>(type: "int", nullable: true),
                    TaskAllowExternalService = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TaskAssemblyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TaskClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TaskCondition = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    TaskData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskDeleteAfterLastRun = table.Column<bool>(type: "bit", nullable: true),
                    TaskDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TaskEnabled = table.Column<bool>(type: "bit", nullable: false),
                    TaskExecutingServerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "(N'')"),
                    TaskExecutions = table.Column<int>(type: "int", nullable: true),
                    TaskGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaskInterval = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TaskIsRunning = table.Column<bool>(type: "bit", nullable: false),
                    TaskLastExecutionReset = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskLastResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskLastRunTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TaskNextRunTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskObjectID = table.Column<int>(type: "int", nullable: true),
                    TaskObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaskRunInSeparateThread = table.Column<bool>(type: "bit", nullable: true),
                    TaskRunIndividually = table.Column<bool>(type: "bit", nullable: true),
                    TaskServerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaskType = table.Column<int>(type: "int", nullable: true),
                    TaskUseExternalService = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ScheduledTask", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_CMS_ScheduledTask_TaskResourceID_CMS_Resource",
                        column: x => x.TaskResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                    table.ForeignKey(
                        name: "FK_CMS_ScheduledTask_TaskSiteID_CMS_Site",
                        column: x => x.TaskSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_ScheduledTask_TaskUserID_CMS_User",
                        column: x => x.TaskUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_SearchIndexSite",
                schema: "dbo",
                columns: table => new
                {
                    IndexID = table.Column<int>(type: "int", nullable: false),
                    IndexSiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SearchIndexSite", x => new { x.IndexID, x.IndexSiteID });
                    table.ForeignKey(
                        name: "FK_CMS_SearchIndexSite_IndexID_CMS_SearchIndex",
                        column: x => x.IndexID,
                        principalSchema: "dbo",
                        principalTable: "CMS_SearchIndex",
                        principalColumn: "IndexID");
                    table.ForeignKey(
                        name: "FK_CMS_SearchIndexSite_IndexSiteID_CMS_Site",
                        column: x => x.IndexSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Session",
                schema: "dbo",
                columns: table => new
                {
                    SessionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionSiteID = table.Column<int>(type: "int", nullable: true),
                    SessionUserID = table.Column<int>(type: "int", nullable: true),
                    SessionContactID = table.Column<int>(type: "int", nullable: true),
                    SessionEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    SessionExpired = table.Column<bool>(type: "bit", nullable: false),
                    SessionExpires = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/9/2008 3:45:44 PM')"),
                    SessionFullName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    SessionIdentificator = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    SessionLastActive = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/9/2008 3:44:26 PM')"),
                    SessionLastLogon = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SessionLocation = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    SessionNickName = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    SessionUserCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SessionUserIsHidden = table.Column<bool>(type: "bit", nullable: false),
                    SessionUserName = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Session", x => x.SessionID);
                    table.ForeignKey(
                        name: "FK_CMS_Session_SessionSiteID_CMS_Site",
                        column: x => x.SessionSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_Session_SessionUserID_CMS_User",
                        column: x => x.SessionUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_SiteCulture",
                schema: "dbo",
                columns: table => new
                {
                    SiteID = table.Column<int>(type: "int", nullable: false),
                    CultureID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SiteCulture", x => new { x.SiteID, x.CultureID });
                    table.ForeignKey(
                        name: "FK_CMS_SiteCulture_CultureID_CMS_Culture",
                        column: x => x.CultureID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Culture",
                        principalColumn: "CultureID");
                    table.ForeignKey(
                        name: "FK_CMS_SiteCulture_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_SiteDomainAlias",
                schema: "dbo",
                columns: table => new
                {
                    SiteDomainAliasID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteID = table.Column<int>(type: "int", nullable: false),
                    SiteDefaultVisitorCulture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SiteDomainAliasName = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, defaultValueSql: "('')"),
                    SiteDomainDefaultAliasPath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    SiteDomainGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SiteDomainLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SiteDomainRedirectUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SiteDomainAlias", x => x.SiteDomainAliasID);
                    table.ForeignKey(
                        name: "FK_CMS_SiteDomainAlias_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_SMTPServerSite",
                schema: "dbo",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SMTPServerSite", x => new { x.ServerID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_CMS_SMTPServerSite_CMS_SMTPServer",
                        column: x => x.ServerID,
                        principalSchema: "dbo",
                        principalTable: "CMS_SMTPServer",
                        principalColumn: "ServerID");
                    table.ForeignKey(
                        name: "FK_CMS_SMTPServerSite_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_TagGroup",
                schema: "dbo",
                columns: table => new
                {
                    TagGroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagGroupSiteID = table.Column<int>(type: "int", nullable: false),
                    TagGroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TagGroupDisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    TagGroupGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagGroupIsAdHoc = table.Column<bool>(type: "bit", nullable: false),
                    TagGroupLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TagGroupName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_TagGroup", x => x.TagGroupID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_TagGroup_TagGroupSiteID_CMS_Site",
                        column: x => x.TagGroupSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_UserCulture",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CultureID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_UserCulture", x => new { x.UserID, x.CultureID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_CMS_UserCulture_CultureID_CMS_Culture",
                        column: x => x.CultureID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Culture",
                        principalColumn: "CultureID");
                    table.ForeignKey(
                        name: "FK_CMS_UserCulture_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_UserCulture_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_UserSite",
                schema: "dbo",
                columns: table => new
                {
                    UserSiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_UserSite", x => x.UserSiteID);
                    table.ForeignKey(
                        name: "FK_CMS_UserSite_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_UserSite_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebPartContainerSite",
                schema: "dbo",
                columns: table => new
                {
                    ContainerID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebPartContainerSite", x => new { x.ContainerID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_CMS_WebPartContainerSite_ContainerID_CMS_WebPartContainer",
                        column: x => x.ContainerID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WebPartContainer",
                        principalColumn: "ContainerID");
                    table.ForeignKey(
                        name: "FK_CMS_WebPartContainerSite_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Brand",
                schema: "dbo",
                columns: table => new
                {
                    BrandID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandSiteID = table.Column<int>(type: "int", nullable: false),
                    BrandDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrandDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    BrandEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    BrandGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandHomepage = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    BrandLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    BrandName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    BrandThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Brand", x => x.BrandID);
                    table.ForeignKey(
                        name: "FK_COM_Brand_BrandSiteID_CMS_Site",
                        column: x => x.BrandSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Carrier",
                schema: "dbo",
                columns: table => new
                {
                    CarrierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrierSiteID = table.Column<int>(type: "int", nullable: false),
                    CarrierAssemblyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CarrierClassName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CarrierDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CarrierGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarrierLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/22/2014 3:00:14 PM')"),
                    CarrierName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Carrier", x => x.CarrierID);
                    table.ForeignKey(
                        name: "FK_COM_Carrier_CarrierSiteID_CMS_Site",
                        column: x => x.CarrierSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Collection",
                schema: "dbo",
                columns: table => new
                {
                    CollectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollectionSiteID = table.Column<int>(type: "int", nullable: false),
                    CollectionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CollectionEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    CollectionGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CollectionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    CollectionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Collection", x => x.CollectionID);
                    table.ForeignKey(
                        name: "FK_COM_Collection_CollectionSiteID_CMS_Site",
                        column: x => x.CollectionSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Currency",
                schema: "dbo",
                columns: table => new
                {
                    CurrencyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrencySiteID = table.Column<int>(type: "int", nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CurrencyDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CurrencyEnabled = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyFormatString = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CurrencyGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrencyIsMain = table.Column<bool>(type: "bit", nullable: false),
                    CurrencyLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrencyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CurrencyRoundTo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Currency", x => x.CurrencyID);
                    table.ForeignKey(
                        name: "FK_COM_Currency_CurrencySiteID_CMS_Site",
                        column: x => x.CurrencySiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Customer",
                schema: "dbo",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerSiteID = table.Column<int>(type: "int", nullable: true),
                    CustomerUserID = table.Column<int>(type: "int", nullable: true),
                    CustomerCompany = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CustomerCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    CustomerFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CustomerGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerLastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CustomerOrganizationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CustomerPhone = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    CustomerTaxRegistrationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Customer", x => x.CustomerID);
                    table.ForeignKey(
                        name: "FK_COM_Customer_CustomerSiteID_CMS_Site",
                        column: x => x.CustomerSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_COM_Customer_CustomerUserID_CMS_User",
                        column: x => x.CustomerUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Discount",
                schema: "dbo",
                columns: table => new
                {
                    DiscountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountSiteID = table.Column<int>(type: "int", nullable: false),
                    DiscountApplyFurtherDiscounts = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    DiscountApplyTo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('Order')"),
                    DiscountCartCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountCustomerRestriction = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DiscountDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    DiscountEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    DiscountGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiscountIsFlat = table.Column<bool>(type: "bit", nullable: false),
                    DiscountLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DiscountOrder = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((1))"),
                    DiscountOrderAmount = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    DiscountProductCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountRoles = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    DiscountUsesCoupons = table.Column<bool>(type: "bit", nullable: false),
                    DiscountValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiscountValue = table.Column<decimal>(type: "decimal(18,9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Discount", x => x.DiscountID);
                    table.ForeignKey(
                        name: "FK_COM_Discount_DiscountSiteID_CMS_Site",
                        column: x => x.DiscountSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_ExchangeTable",
                schema: "dbo",
                columns: table => new
                {
                    ExchangeTableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExchangeTableSiteID = table.Column<int>(type: "int", nullable: true),
                    ExchangeTableDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    ExchangeTableGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeTableLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExchangeTableRateFromGlobalCurrency = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    ExchangeTableValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExchangeTableValidTo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_ExchangeTable", x => x.ExchangeTableID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COM_ExchangeTable_ExchangeTableSiteID_CMS_Site",
                        column: x => x.ExchangeTableSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_GiftCard",
                schema: "dbo",
                columns: table => new
                {
                    GiftCardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiftCardSiteID = table.Column<int>(type: "int", nullable: false),
                    GiftCardCartCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiftCardCustomerRestriction = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "(N'enum1')"),
                    GiftCardDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiftCardDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    GiftCardEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    GiftCardGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiftCardLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    GiftCardMinimumOrderPrice = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    GiftCardName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    GiftCardRoles = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    GiftCardValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiftCardValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GiftCardValue = table.Column<decimal>(type: "decimal(18,9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_GiftCard", x => x.GiftCardID);
                    table.ForeignKey(
                        name: "FK_COM_GiftCard_GiftCardSiteID_CMS_Site",
                        column: x => x.GiftCardSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_InternalStatus",
                schema: "dbo",
                columns: table => new
                {
                    InternalStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternalStatusSiteID = table.Column<int>(type: "int", nullable: true),
                    InternalStatusDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    InternalStatusEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    InternalStatusGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InternalStatusLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/20/2012 2:45:44 PM')"),
                    InternalStatusName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_InternalStatus", x => x.InternalStatusID);
                    table.ForeignKey(
                        name: "FK_COM_InternalStatus_InternalStatusSiteID_CMS_Site",
                        column: x => x.InternalStatusSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Manufacturer",
                schema: "dbo",
                columns: table => new
                {
                    ManufacturerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufacturerSiteID = table.Column<int>(type: "int", nullable: true),
                    ManufactureHomepage = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ManufacturerDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    ManufacturerEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ManufacturerGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ManufacturerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    ManufacturerName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ManufacturerThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Manufacturer", x => x.ManufacturerID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COM_Manufacturer_ManufacturerSiteID_CMS_Site",
                        column: x => x.ManufacturerSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_OptionCategory",
                schema: "dbo",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategorySiteID = table.Column<int>(type: "int", nullable: true),
                    CategoryDefaultOptions = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CategoryDefaultRecord = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CategoryDisplayPrice = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    CategoryEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    CategoryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryLiveSiteDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CategorySelectionType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CategoryTextMaxLength = table.Column<int>(type: "int", nullable: true),
                    CategoryTextMinLength = table.Column<int>(type: "int", nullable: true),
                    CategoryType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_OptionCategory", x => x.CategoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COM_OptionCategory_CategorySiteID_CMS_Site",
                        column: x => x.CategorySiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_OrderStatus",
                schema: "dbo",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusSiteID = table.Column<int>(type: "int", nullable: true),
                    StatusColor = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    StatusDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    StatusEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    StatusGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    StatusOrder = table.Column<int>(type: "int", nullable: true),
                    StatusOrderIsPaid = table.Column<bool>(type: "bit", nullable: true),
                    StatusSendNotification = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_OrderStatus", x => x.StatusID);
                    table.ForeignKey(
                        name: "FK_COM_OrderStatus_StatusSiteID_CMS_Site",
                        column: x => x.StatusSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_PublicStatus",
                schema: "dbo",
                columns: table => new
                {
                    PublicStatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublicStatusSiteID = table.Column<int>(type: "int", nullable: true),
                    PublicStatusDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    PublicStatusEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    PublicStatusGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PublicStatusLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublicStatusName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_PublicStatus", x => x.PublicStatusID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COM_PublicStatus_PublicStatusSiteID_CMS_Site",
                        column: x => x.PublicStatusSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Supplier",
                schema: "dbo",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierSiteID = table.Column<int>(type: "int", nullable: true),
                    SupplierDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    SupplierEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    SupplierEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    SupplierFax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupplierGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/21/2012 12:34:09 PM')"),
                    SupplierName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SupplierPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Supplier", x => x.SupplierID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COM_Supplier_SupplierSiteID_CMS_Site",
                        column: x => x.SupplierSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_TaxClass",
                schema: "dbo",
                columns: table => new
                {
                    TaxClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaxClassSiteID = table.Column<int>(type: "int", nullable: true),
                    TaxClassDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    TaxClassGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TaxClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/20/2012 1:31:27 PM')"),
                    TaxClassName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    TaxClassZeroIfIDSupplied = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_TaxClass", x => x.TaxClassID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COM_TaxClass_TaxClassSiteID_CMS_Site",
                        column: x => x.TaxClassSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Community_Group",
                schema: "dbo",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupApprovedByUserID = table.Column<int>(type: "int", nullable: true),
                    GroupAvatarID = table.Column<int>(type: "int", nullable: true),
                    GroupCreatedByUserID = table.Column<int>(type: "int", nullable: true),
                    GroupSiteID = table.Column<int>(type: "int", nullable: false),
                    GroupAccess = table.Column<int>(type: "int", nullable: false),
                    GroupApproveMembers = table.Column<int>(type: "int", nullable: false),
                    GroupApproved = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    GroupCreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('10/21/2008 10:17:56 AM')"),
                    GroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GroupGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GroupLogActivity = table.Column<bool>(type: "bit", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GroupNodeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GroupSecurity = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((444))"),
                    GroupSendJoinLeaveNotification = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    GroupSendWaitingForApprovalNotification = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community_Group", x => x.GroupID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Community_Group_GroupApprovedByUserID_CMS_User",
                        column: x => x.GroupApprovedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Community_Group_GroupAvatarID_CMS_Avatar",
                        column: x => x.GroupAvatarID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Avatar",
                        principalColumn: "AvatarID");
                    table.ForeignKey(
                        name: "FK_Community_Group_GroupCreatedByUserID_CMS_User",
                        column: x => x.GroupCreatedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Community_Group_GroupSiteID_CMS_Site",
                        column: x => x.GroupSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Export_History",
                schema: "dbo",
                columns: table => new
                {
                    ExportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExportSiteID = table.Column<int>(type: "int", nullable: true),
                    ExportUserID = table.Column<int>(type: "int", nullable: true),
                    ExportDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExportFileName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "(N'')"),
                    ExportSettings = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Export_History", x => x.ExportID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Export_History_ExportSiteID_CMS_Site",
                        column: x => x.ExportSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Export_History_ExportUserID_CMS_User",
                        column: x => x.ExportUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Export_Task",
                schema: "dbo",
                columns: table => new
                {
                    TaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskSiteID = table.Column<int>(type: "int", nullable: true),
                    TaskData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskObjectID = table.Column<int>(type: "int", nullable: true),
                    TaskObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaskTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskTitle = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    TaskType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Export_Task", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_Export_Task_TaskSiteID_CMS_Site",
                        column: x => x.TaskSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Integration_Task",
                schema: "dbo",
                columns: table => new
                {
                    TaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskSiteID = table.Column<int>(type: "int", nullable: true),
                    TaskData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskDataType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaskDocumentID = table.Column<int>(type: "int", nullable: true),
                    TaskIsInbound = table.Column<bool>(type: "bit", nullable: false),
                    TaskNodeAliasPath = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskNodeID = table.Column<int>(type: "int", nullable: true),
                    TaskObjectID = table.Column<int>(type: "int", nullable: true),
                    TaskObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaskProcessType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TaskTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskTitle = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    TaskType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integration_Task", x => x.TaskID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_IntegrationTask_TaskSiteID_CMS_Site",
                        column: x => x.TaskSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_EmailTemplate",
                schema: "dbo",
                columns: table => new
                {
                    TemplateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateSiteID = table.Column<int>(type: "int", nullable: false),
                    TemplateCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateDisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    TemplateGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateIconClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "(N'icon-accordion')"),
                    TemplateInlineCSS = table.Column<bool>(type: "bit", nullable: false),
                    TemplateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    TemplateSubject = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    TemplateThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TemplateType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_EmailTemplate", x => x.TemplateID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Newsletter_EmailTemplate_TemplateSiteID_CMS_Site",
                        column: x => x.TemplateSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_EmailWidget",
                schema: "dbo",
                columns: table => new
                {
                    EmailWidgetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailWidgetSiteID = table.Column<int>(type: "int", nullable: false),
                    EmailWidgetCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailWidgetDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailWidgetDisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "(N'')"),
                    EmailWidgetGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailWidgetIconCssClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "(N'icon-cogwheel-square')"),
                    EmailWidgetLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    EmailWidgetName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "(N'')"),
                    EmailWidgetProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailWidgetThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_EmailWidget", x => x.EmailWidgetID);
                    table.ForeignKey(
                        name: "FK_Newsletter_EmailWidget_EmailWidgetSiteID_CMS_Site",
                        column: x => x.EmailWidgetSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_Subscriber",
                schema: "dbo",
                columns: table => new
                {
                    SubscriberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriberSiteID = table.Column<int>(type: "int", nullable: false),
                    SubscriberBounces = table.Column<int>(type: "int", nullable: true),
                    SubscriberCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriberEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    SubscriberFirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SubscriberFullName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true),
                    SubscriberGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriberLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriberLastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SubscriberRelatedID = table.Column<int>(type: "int", nullable: false),
                    SubscriberType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_Subscriber", x => x.SubscriberID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Newsletter_Subscriber_SubscriberSiteID_CMS_Site",
                        column: x => x.SubscriberSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Notification_Template",
                schema: "dbo",
                columns: table => new
                {
                    TemplateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateSiteID = table.Column<int>(type: "int", nullable: true),
                    TemplateDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    TemplateGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_Template", x => x.TemplateID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Notification_Template_TemplateSiteID_CMS_Site",
                        column: x => x.TemplateSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "OM_ABTest",
                schema: "dbo",
                columns: table => new
                {
                    ABTestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABTestSiteID = table.Column<int>(type: "int", nullable: false),
                    ABTestConversions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABTestCulture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ABTestDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABTestDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ABTestGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ABTestIncludedTraffic = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((100))"),
                    ABTestLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ABTestName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    ABTestOpenFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ABTestOpenTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ABTestOriginalPage = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "(N'')"),
                    ABTestVisitorTargeting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ABTestWinnerGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ABTest", x => x.ABTestID);
                    table.ForeignKey(
                        name: "FK_OM_ABTest_SiteID_CMS_Site",
                        column: x => x.ABTestSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "OM_MVTest",
                schema: "dbo",
                columns: table => new
                {
                    MVTestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MVTestSiteID = table.Column<int>(type: "int", nullable: false),
                    MVTestConversions = table.Column<int>(type: "int", nullable: true),
                    MVTestCulture = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MVTestDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVTestDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    MVTestEnabled = table.Column<bool>(type: "bit", nullable: false),
                    MVTestGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MVTestLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MVTestMaxConversions = table.Column<int>(type: "int", nullable: true),
                    MVTestName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    MVTestOpenFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MVTestOpenTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MVTestPage = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "('')"),
                    MVTestTargetConversionType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "('TOTAL')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_MVTest", x => x.MVTestID);
                    table.ForeignKey(
                        name: "FK_OM_MVTest_MVTestSiteID_CMS_Site",
                        column: x => x.MVTestSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "SharePoint_SharePointConnection",
                schema: "dbo",
                columns: table => new
                {
                    SharePointConnectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharePointConnectionSiteID = table.Column<int>(type: "int", nullable: false),
                    SharePointConnectionAuthMode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValueSql: "(N'default')"),
                    SharePointConnectionDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SharePointConnectionDomain = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SharePointConnectionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SharePointConnectionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SharePointConnectionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SharePointConnectionPassword = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SharePointConnectionSharePointVersion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, defaultValueSql: "(N'sp2010')"),
                    SharePointConnectionSiteUrl = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    SharePointConnectionUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharePoint_SharePointConnection", x => x.SharePointConnectionID);
                    table.ForeignKey(
                        name: "FK_SharePoint_SharePointConnection_CMS_Site",
                        column: x => x.SharePointConnectionSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "SM_FacebookApplication",
                schema: "dbo",
                columns: table => new
                {
                    FacebookApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookApplicationSiteID = table.Column<int>(type: "int", nullable: false),
                    FacebookApplicationConsumerKey = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    FacebookApplicationConsumerSecret = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    FacebookApplicationDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FacebookApplicationGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacebookApplicationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('5/28/2013 1:02:36 PM')"),
                    FacebookApplicationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_FacebookApplication", x => x.FacebookApplicationID);
                    table.ForeignKey(
                        name: "FK_SM_FacebookApplication_CMS_Site",
                        column: x => x.FacebookApplicationSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "SM_LinkedInApplication",
                schema: "dbo",
                columns: table => new
                {
                    LinkedInApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkedInApplicationSiteID = table.Column<int>(type: "int", nullable: false),
                    LinkedInApplicationConsumerKey = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    LinkedInApplicationConsumerSecret = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "(N'')"),
                    LinkedInApplicationDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    LinkedInApplicationGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LinkedInApplicationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LinkedInApplicationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_LinkedInApplication", x => x.LinkedInApplicationID);
                    table.ForeignKey(
                        name: "FK_SM_LinkedInApplication_CMS_Site",
                        column: x => x.LinkedInApplicationSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "SM_TwitterApplication",
                schema: "dbo",
                columns: table => new
                {
                    TwitterApplicationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TwitterApplicationSiteID = table.Column<int>(type: "int", nullable: false),
                    TwitterApplicationConsumerKey = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    TwitterApplicationConsumerSecret = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    TwitterApplicationDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TwitterApplicationGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TwitterApplicationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TwitterApplicationName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_TwitterApplication", x => x.TwitterApplicationID);
                    table.ForeignKey(
                        name: "FK_SM_TwitterApplication_CMS_Site",
                        column: x => x.TwitterApplicationSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Staging_Server",
                schema: "dbo",
                columns: table => new
                {
                    ServerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServerSiteID = table.Column<int>(type: "int", nullable: false),
                    ServerAuthentication = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "('USERNAME')"),
                    ServerDisplayName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: false, defaultValueSql: "('')"),
                    ServerEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ServerGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ServerPassword = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ServerURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "(N'')"),
                    ServerUsername = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ServerX509ClientKeyID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ServerX509ServerKeyID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staging_Server", x => x.ServerID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Staging_Server_ServerSiteID_CMS_Site",
                        column: x => x.ServerSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Staging_Task",
                schema: "dbo",
                columns: table => new
                {
                    TaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskSiteID = table.Column<int>(type: "int", nullable: true),
                    TaskData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskDocumentID = table.Column<int>(type: "int", nullable: true),
                    TaskNodeAliasPath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    TaskNodeID = table.Column<int>(type: "int", nullable: true),
                    TaskObjectID = table.Column<int>(type: "int", nullable: true),
                    TaskObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TaskRunning = table.Column<bool>(type: "bit", nullable: true),
                    TaskServers = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "('null')"),
                    TaskTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskTitle = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    TaskType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staging_Task", x => x.TaskID);
                    table.ForeignKey(
                        name: "FK_Staging_Task_TaskSiteID_CMS_Site",
                        column: x => x.TaskSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_SettingsKey",
                schema: "dbo",
                columns: table => new
                {
                    KeyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyCategoryID = table.Column<int>(type: "int", nullable: true),
                    SiteID = table.Column<int>(type: "int", nullable: true),
                    KeyDefaultValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    KeyEditingControlPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    KeyExplanationText = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "(N'')"),
                    KeyFormControlSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KeyIsCustom = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    KeyIsGlobal = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    KeyIsHidden = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    KeyLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KeyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    KeyOrder = table.Column<int>(type: "int", nullable: true),
                    KeyType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    KeyValidation = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    KeyValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_SettingsKey", x => x.KeyID);
                    table.ForeignKey(
                        name: "FK_CMS_SettingsKey_KeyCategoryID_CMS_SettingsCategory",
                        column: x => x.KeyCategoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_SettingsCategory",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_CMS_SettingsKey_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WorkflowStep",
                schema: "dbo",
                columns: table => new
                {
                    StepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepActionID = table.Column<int>(type: "int", nullable: true),
                    StepWorkflowID = table.Column<int>(type: "int", nullable: false),
                    StepActionParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StepAllowPublish = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    StepAllowReject = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    StepApprovedTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StepDefinition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StepDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    StepGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StepLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StepName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true),
                    StepOrder = table.Column<int>(type: "int", nullable: true),
                    StepReadyforApprovalTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StepRejectedTemplateName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    StepRolesSecurity = table.Column<int>(type: "int", nullable: true),
                    StepSendApproveEmails = table.Column<bool>(type: "bit", nullable: true),
                    StepSendEmails = table.Column<bool>(type: "bit", nullable: true),
                    StepSendReadyForApprovalEmails = table.Column<bool>(type: "bit", nullable: true),
                    StepSendRejectEmails = table.Column<bool>(type: "bit", nullable: true),
                    StepType = table.Column<int>(type: "int", nullable: true),
                    StepUsersSecurity = table.Column<int>(type: "int", nullable: true),
                    StepWorkflowType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WorkflowStep", x => x.StepID);
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowStep_StepActionID",
                        column: x => x.StepActionID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowAction",
                        principalColumn: "ActionID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowStep_StepWorkflowID",
                        column: x => x.StepWorkflowID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Workflow",
                        principalColumn: "WorkflowID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_OnlineSupport",
                schema: "dbo",
                columns: table => new
                {
                    ChatOnlineSupportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatOnlineSupportChatUserID = table.Column<int>(type: "int", nullable: false),
                    ChatOnlineSupportSiteID = table.Column<int>(type: "int", nullable: false),
                    ChatOnlineSupportLastChecking = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChatOnlineSupportToken = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_OnlineSupport", x => x.ChatOnlineSupportID);
                    table.ForeignKey(
                        name: "FK_Chat_OnlineSupport_CMS_Site",
                        column: x => x.ChatOnlineSupportSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Chat_OnlineSupport_Chat_User",
                        column: x => x.ChatOnlineSupportChatUserID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_OnlineUser",
                schema: "dbo",
                columns: table => new
                {
                    ChatOnlineUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatOnlineUserChatUserID = table.Column<int>(type: "int", nullable: false),
                    ChatOnlineUserSiteID = table.Column<int>(type: "int", nullable: false),
                    ChatOnlineUserIsHidden = table.Column<bool>(type: "bit", nullable: false),
                    ChatOnlineUserJoinTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChatOnlineUserLastChecking = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChatOnlineUserLeaveTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChatOnlineUserToken = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_OnlineUser", x => x.ChatOnlineUserID);
                    table.ForeignKey(
                        name: "FK_Chat_OnlineUser_CMS_Site",
                        column: x => x.ChatOnlineUserSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Chat_OnlineUser_Chat_User",
                        column: x => x.ChatOnlineUserChatUserID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_Room",
                schema: "dbo",
                columns: table => new
                {
                    ChatRoomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatRoomCreatedByChatUserID = table.Column<int>(type: "int", nullable: true),
                    ChatRoomSiteID = table.Column<int>(type: "int", nullable: true),
                    ChatRoomAllowAnonym = table.Column<bool>(type: "bit", nullable: false),
                    ChatRoomCreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChatRoomDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ChatRoomDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ChatRoomEnabled = table.Column<bool>(type: "bit", nullable: false),
                    ChatRoomGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChatRoomIsOneToOne = table.Column<bool>(type: "bit", nullable: false),
                    ChatRoomIsSupport = table.Column<bool>(type: "bit", nullable: false),
                    ChatRoomLastModification = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('10/19/2011 12:16:33 PM')"),
                    ChatRoomName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChatRoomPassword = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ChatRoomPrivate = table.Column<bool>(type: "bit", nullable: false),
                    ChatRoomPrivateStateLastModification = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/30/2012 4:36:47 PM')"),
                    ChatRoomScheduledToDelete = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_Room", x => x.ChatRoomID);
                    table.ForeignKey(
                        name: "FK_Chat_Room_CMS_Site",
                        column: x => x.ChatRoomSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Chat_Room_Chat_User",
                        column: x => x.ChatRoomCreatedByChatUserID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_SupportCannedResponse",
                schema: "dbo",
                columns: table => new
                {
                    ChatSupportCannedResponseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatSupportCannedResponseChatUserID = table.Column<int>(type: "int", nullable: true),
                    ChatSupportCannedResponseSiteID = table.Column<int>(type: "int", nullable: true),
                    ChatSupportCannedResponseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ChatSupportCannedResponseTagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    ChatSupportCannedResponseText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_SupportCannedResponse", x => x.ChatSupportCannedResponseID);
                    table.ForeignKey(
                        name: "FK_Chat_SupportCannedResponse_CMS_Site",
                        column: x => x.ChatSupportCannedResponseSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Chat_SupportCannedResponse_Chat_User",
                        column: x => x.ChatSupportCannedResponseChatUserID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_UserMacroIdentity",
                schema: "dbo",
                columns: table => new
                {
                    UserMacroIdentityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserMacroIdentityMacroIdentityID = table.Column<int>(type: "int", nullable: true),
                    UserMacroIdentityUserID = table.Column<int>(type: "int", nullable: false),
                    UserMacroIdentityLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    UserMacroIdentityUserGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_UserMacroIdentity", x => x.UserMacroIdentityID);
                    table.ForeignKey(
                        name: "FK_CMS_UserMacroIdentity_UserMacroIdentityMacroIdentityID_CMS_MacroIdentity",
                        column: x => x.UserMacroIdentityMacroIdentityID,
                        principalSchema: "dbo",
                        principalTable: "CMS_MacroIdentity",
                        principalColumn: "MacroIdentityID");
                    table.ForeignKey(
                        name: "FK_CMS_UserMacroIdentity_UserMacroIdentityUserID_CMS_User",
                        column: x => x.UserMacroIdentityUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_TranslationSubmissionItem",
                schema: "dbo",
                columns: table => new
                {
                    SubmissionItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubmissionItemSubmissionID = table.Column<int>(type: "int", nullable: false),
                    SubmissionItemCharCount = table.Column<int>(type: "int", nullable: true),
                    SubmissionItemCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionItemGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubmissionItemLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubmissionItemName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubmissionItemObjectID = table.Column<int>(type: "int", nullable: false),
                    SubmissionItemObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubmissionItemSourceXLIFF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionItemTargetCulture = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SubmissionItemTargetObjectID = table.Column<int>(type: "int", nullable: false),
                    SubmissionItemTargetXLIFF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmissionItemType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SubmissionItemWordCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_TranslationSubmissionItem", x => x.SubmissionItemID);
                    table.ForeignKey(
                        name: "FK_CMS_TranslationSubmissionItem_CMS_TranslationSubmission",
                        column: x => x.SubmissionItemSubmissionID,
                        principalSchema: "dbo",
                        principalTable: "CMS_TranslationSubmission",
                        principalColumn: "SubmissionID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WebPartLayout",
                schema: "dbo",
                columns: table => new
                {
                    WebPartLayoutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WebPartLayoutWebPartID = table.Column<int>(type: "int", nullable: false),
                    WebPartLayoutCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPartLayoutCodeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    WebPartLayoutCSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPartLayoutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebPartLayoutDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    WebPartLayoutGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WebPartLayoutIsDefault = table.Column<bool>(type: "bit", nullable: true),
                    WebPartLayoutLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WebPartLayoutVersionGUID = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WebPartLayout", x => x.WebPartLayoutID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_WebPartLayout_WebPartLayoutWebPartID_CMS_WebPart",
                        column: x => x.WebPartLayoutWebPartID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WebPart",
                        principalColumn: "WebPartID");
                });

            migrationBuilder.CreateTable(
                name: "Reporting_ReportGraph",
                schema: "dbo",
                columns: table => new
                {
                    GraphID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GraphReportID = table.Column<int>(type: "int", nullable: false),
                    GraphConnectionString = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GraphDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    GraphGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GraphHeight = table.Column<int>(type: "int", nullable: true),
                    GraphIsHtml = table.Column<bool>(type: "bit", nullable: true),
                    GraphLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GraphLegendPosition = table.Column<int>(type: "int", nullable: true),
                    GraphName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GraphQuery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraphQueryIsStoredProcedure = table.Column<bool>(type: "bit", nullable: false),
                    GraphSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GraphType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GraphWidth = table.Column<int>(type: "int", nullable: true),
                    GraphXAxisTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GraphYAxisTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporting_ReportGraph", x => x.GraphID);
                    table.ForeignKey(
                        name: "FK_Reporting_ReportGraph_GraphReportID_Reporting_Report",
                        column: x => x.GraphReportID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_Report",
                        principalColumn: "ReportID");
                });

            migrationBuilder.CreateTable(
                name: "Reporting_ReportTable",
                schema: "dbo",
                columns: table => new
                {
                    TableID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableReportID = table.Column<int>(type: "int", nullable: false),
                    TableConnectionString = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TableDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    TableGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TableLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TableName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TableQuery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TableQueryIsStoredProcedure = table.Column<bool>(type: "bit", nullable: false),
                    TableSettings = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporting_ReportTable", x => x.TableID);
                    table.ForeignKey(
                        name: "FK_Reporting_ReportTable_TableReportID_Reporting_Report",
                        column: x => x.TableReportID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_Report",
                        principalColumn: "ReportID");
                });

            migrationBuilder.CreateTable(
                name: "Reporting_ReportValue",
                schema: "dbo",
                columns: table => new
                {
                    ValueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValueReportID = table.Column<int>(type: "int", nullable: false),
                    ValueConnectionString = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ValueDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ValueFormatString = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ValueGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValueLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValueName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ValueQuery = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValueQueryIsStoredProcedure = table.Column<bool>(type: "bit", nullable: false),
                    ValueSettings = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporting_ReportValue", x => x.ValueID);
                    table.ForeignKey(
                        name: "FK_Reporting_ReportValue_ValueReportID_Reporting_Report",
                        column: x => x.ValueReportID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_Report",
                        principalColumn: "ReportID");
                });

            migrationBuilder.CreateTable(
                name: "Reporting_SavedReport",
                schema: "dbo",
                columns: table => new
                {
                    SavedReportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SavedReportCreatedByUserID = table.Column<int>(type: "int", nullable: true),
                    SavedReportReportID = table.Column<int>(type: "int", nullable: false),
                    SavedReportDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SavedReportGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SavedReportHTML = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SavedReportLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SavedReportParameters = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SavedReportTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporting_SavedReport", x => x.SavedReportID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Reporting_SavedReport_SavedReportCreatedByUserID_CMS_User",
                        column: x => x.SavedReportCreatedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Reporting_SavedReport_SavedReportReportID_Reporting_Report",
                        column: x => x.SavedReportReportID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_Report",
                        principalColumn: "ReportID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ConsentAgreement",
                schema: "dbo",
                columns: table => new
                {
                    ConsentAgreementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConsentAgreementConsentID = table.Column<int>(type: "int", nullable: false),
                    ConsentAgreementContactID = table.Column<int>(type: "int", nullable: false),
                    ConsentAgreementConsentHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ConsentAgreementGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConsentAgreementRevoked = table.Column<bool>(type: "bit", nullable: false),
                    ConsentAgreementTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ConsentAgreement", x => x.ConsentAgreementID);
                    table.ForeignKey(
                        name: "FK_CMS_ConsentAgreement_ConsentAgreementConsentID_CMS_Consent",
                        column: x => x.ConsentAgreementConsentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Consent",
                        principalColumn: "ConsentID");
                    table.ForeignKey(
                        name: "FK_CMS_ConsentAgreement_ConsentAgreementContactID_OM_Contact",
                        column: x => x.ConsentAgreementContactID,
                        principalSchema: "dbo",
                        principalTable: "OM_Contact",
                        principalColumn: "ContactID");
                });

            migrationBuilder.CreateTable(
                name: "OM_Account",
                schema: "dbo",
                columns: table => new
                {
                    AccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountCountryID = table.Column<int>(type: "int", nullable: true),
                    AccountOwnerUserID = table.Column<int>(type: "int", nullable: true),
                    AccountPrimaryContactID = table.Column<int>(type: "int", nullable: true),
                    AccountSecondaryContactID = table.Column<int>(type: "int", nullable: true),
                    AccountStateID = table.Column<int>(type: "int", nullable: true),
                    AccountStatusID = table.Column<int>(type: "int", nullable: true),
                    AccountSubsidiaryOfID = table.Column<int>(type: "int", nullable: true),
                    AccountAddress1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AccountAddress2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AccountCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AccountCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    AccountFax = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    AccountGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccountLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AccountNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountPhone = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    AccountWebSite = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AccountZIP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_Account", x => x.AccountID);
                    table.ForeignKey(
                        name: "FK_OM_Account_CMS_Country",
                        column: x => x.AccountCountryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Country",
                        principalColumn: "CountryID");
                    table.ForeignKey(
                        name: "FK_OM_Account_CMS_State",
                        column: x => x.AccountStateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_State",
                        principalColumn: "StateID");
                    table.ForeignKey(
                        name: "FK_OM_Account_CMS_User",
                        column: x => x.AccountOwnerUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_OM_Account_OM_AccountStatus",
                        column: x => x.AccountStatusID,
                        principalSchema: "dbo",
                        principalTable: "OM_AccountStatus",
                        principalColumn: "AccountStatusID");
                    table.ForeignKey(
                        name: "FK_OM_Account_OM_Account_SubsidiaryOf",
                        column: x => x.AccountSubsidiaryOfID,
                        principalSchema: "dbo",
                        principalTable: "OM_Account",
                        principalColumn: "AccountID");
                    table.ForeignKey(
                        name: "FK_OM_Account_OM_Contact_PrimaryContact",
                        column: x => x.AccountPrimaryContactID,
                        principalSchema: "dbo",
                        principalTable: "OM_Contact",
                        principalColumn: "ContactID");
                    table.ForeignKey(
                        name: "FK_OM_Account_OM_Contact_SecondaryContact",
                        column: x => x.AccountSecondaryContactID,
                        principalSchema: "dbo",
                        principalTable: "OM_Contact",
                        principalColumn: "ContactID");
                });

            migrationBuilder.CreateTable(
                name: "OM_Membership",
                schema: "dbo",
                columns: table => new
                {
                    MembershipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    MemberType = table.Column<int>(type: "int", nullable: false),
                    MembershipCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MembershipGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelatedID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_Membership", x => x.MembershipID);
                    table.ForeignKey(
                        name: "FK_OM_Membership_OM_Contact",
                        column: x => x.ContactID,
                        principalSchema: "dbo",
                        principalTable: "OM_Contact",
                        principalColumn: "ContactID");
                });

            migrationBuilder.CreateTable(
                name: "OM_ScoreContactRule",
                schema: "dbo",
                columns: table => new
                {
                    ScoreContactRuleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    RuleID = table.Column<int>(type: "int", nullable: false),
                    ScoreID = table.Column<int>(type: "int", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ScoreContactRule", x => x.ScoreContactRuleID);
                    table.ForeignKey(
                        name: "FK_OM_ScoreContactRule_OM_Contact",
                        column: x => x.ContactID,
                        principalSchema: "dbo",
                        principalTable: "OM_Contact",
                        principalColumn: "ContactID");
                    table.ForeignKey(
                        name: "FK_OM_ScoreContactRule_OM_Rule",
                        column: x => x.RuleID,
                        principalSchema: "dbo",
                        principalTable: "OM_Rule",
                        principalColumn: "RuleID");
                    table.ForeignKey(
                        name: "FK_OM_ScoreContactRule_OM_Score",
                        column: x => x.ScoreID,
                        principalSchema: "dbo",
                        principalTable: "OM_Score",
                        principalColumn: "ScoreID");
                });

            migrationBuilder.CreateTable(
                name: "OM_VisitorToContact",
                schema: "dbo",
                columns: table => new
                {
                    VisitorToContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorToContactContactID = table.Column<int>(type: "int", nullable: false),
                    VisitorToContactVisitorGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_VisitorToContact", x => x.VisitorToContactID);
                    table.ForeignKey(
                        name: "FK_OM_VisitorToContact_OM_Contact_Cascade",
                        column: x => x.VisitorToContactContactID,
                        principalSchema: "dbo",
                        principalTable: "OM_Contact",
                        principalColumn: "ContactID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_DayHits",
                schema: "dbo",
                columns: table => new
                {
                    HitsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HitsStatisticsID = table.Column<int>(type: "int", nullable: false),
                    HitsCount = table.Column<int>(type: "int", nullable: false),
                    HitsEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsValue = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_DayHits", x => x.HitsID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Analytics_DayHits_HitsStatisticsID_Analytics_Statistics",
                        column: x => x.HitsStatisticsID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Statistics",
                        principalColumn: "StatisticsID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_HourHits",
                schema: "dbo",
                columns: table => new
                {
                    HitsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HitsStatisticsID = table.Column<int>(type: "int", nullable: false),
                    HitsCount = table.Column<int>(type: "int", nullable: false),
                    HitsEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsValue = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_HourHits", x => x.HitsID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Analytics_HourHits_HitsStatisticsID_Analytics_Statistics",
                        column: x => x.HitsStatisticsID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Statistics",
                        principalColumn: "StatisticsID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_MonthHits",
                schema: "dbo",
                columns: table => new
                {
                    HitsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HitsStatisticsID = table.Column<int>(type: "int", nullable: false),
                    HitsCount = table.Column<int>(type: "int", nullable: false),
                    HitsEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsValue = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_MonthHits", x => x.HitsID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Analytics_MonthHits_HitsStatisticsID_Analytics_Statistics",
                        column: x => x.HitsStatisticsID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Statistics",
                        principalColumn: "StatisticsID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_WeekHits",
                schema: "dbo",
                columns: table => new
                {
                    HitsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HitsStatisticsID = table.Column<int>(type: "int", nullable: false),
                    HitsCount = table.Column<int>(type: "int", nullable: false),
                    HitsEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsValue = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_WeekHits", x => x.HitsID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Analytics_WeekHits_HitsStatisticsID_Analytics_Statistics",
                        column: x => x.HitsStatisticsID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Statistics",
                        principalColumn: "StatisticsID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_YearHits",
                schema: "dbo",
                columns: table => new
                {
                    HitsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HitsStatisticsID = table.Column<int>(type: "int", nullable: false),
                    HitsCount = table.Column<int>(type: "int", nullable: false),
                    HitsEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HitsValue = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_YearHits", x => x.HitsID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Analytics_YearHits_HitsStatisticsID_Analytics_Statistics",
                        column: x => x.HitsStatisticsID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Statistics",
                        principalColumn: "StatisticsID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Banner",
                schema: "dbo",
                columns: table => new
                {
                    BannerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BannerCategoryID = table.Column<int>(type: "int", nullable: false),
                    BannerSiteID = table.Column<int>(type: "int", nullable: true),
                    BannerBlank = table.Column<bool>(type: "bit", nullable: false),
                    BannerClicksLeft = table.Column<int>(type: "int", nullable: true),
                    BannerContent = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    BannerDisplayName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "('')"),
                    BannerEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    BannerFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BannerGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BannerHitsLeft = table.Column<int>(type: "int", nullable: true),
                    BannerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/1970 12:00:00 AM')"),
                    BannerName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false, defaultValueSql: "('')"),
                    BannerTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BannerType = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((2))"),
                    BannerURL = table.Column<string>(type: "nvarchar(2083)", maxLength: 2083, nullable: false),
                    BannerWeight = table.Column<double>(type: "float", nullable: false, defaultValueSql: "((5))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Banner", x => x.BannerID);
                    table.ForeignKey(
                        name: "FK_CMS_Banner_CMS_BannerCategory",
                        column: x => x.BannerCategoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_BannerCategory",
                        principalColumn: "BannerCategoryID");
                    table.ForeignKey(
                        name: "FK_CMS_Banner_CMS_Site",
                        column: x => x.BannerSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_MembershipUser",
                schema: "dbo",
                columns: table => new
                {
                    MembershipUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MembershipID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    SendNotification = table.Column<bool>(type: "bit", nullable: true),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_MembershipUser", x => x.MembershipUserID);
                    table.ForeignKey(
                        name: "FK_CMS_MembershipUser_MembershipID_CMS_Membership",
                        column: x => x.MembershipID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Membership",
                        principalColumn: "MembershipID");
                    table.ForeignKey(
                        name: "FK_CMS_MembershipUser_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Class",
                schema: "dbo",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassDefaultPageTemplateID = table.Column<int>(type: "int", nullable: true),
                    ClassPageTemplateCategoryID = table.Column<int>(type: "int", nullable: true),
                    ClassResourceID = table.Column<int>(type: "int", nullable: true),
                    ClassCodeGenerationSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassConnectionString = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClassContactMapping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassContactOverwriteEnabled = table.Column<bool>(type: "bit", nullable: true),
                    ClassCreateSKU = table.Column<bool>(type: "bit", nullable: true),
                    ClassCustomizedColumns = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    ClassDefaultObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClassDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClassEditingPageUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ClassFormDefinition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassFormLayout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassFormLayoutType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClassGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClassIconClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassInheritsFromClassID = table.Column<int>(type: "int", nullable: true),
                    ClassIsContentOnly = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ClassIsCoupledClass = table.Column<bool>(type: "bit", nullable: false),
                    ClassIsCustomTable = table.Column<bool>(type: "bit", nullable: false),
                    ClassIsDocumentType = table.Column<bool>(type: "bit", nullable: false),
                    ClassIsForm = table.Column<bool>(type: "bit", nullable: true),
                    ClassIsMenuItemType = table.Column<bool>(type: "bit", nullable: true),
                    ClassIsProduct = table.Column<bool>(type: "bit", nullable: true),
                    ClassIsProductSection = table.Column<bool>(type: "bit", nullable: true),
                    ClassLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClassListPageUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ClassName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClassNewPageUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ClassNodeAliasSource = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClassNodeNameSource = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ClassPreviewPageUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ClassSearchContentColumn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassSearchCreationDateColumn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassSearchEnabled = table.Column<bool>(type: "bit", nullable: true),
                    ClassSearchImageColumn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassSearchSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassSearchTitleColumn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassShowAsSystemTable = table.Column<bool>(type: "bit", nullable: true),
                    ClassShowColumns = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ClassShowTemplateSelection = table.Column<bool>(type: "bit", nullable: true),
                    ClassSKUDefaultDepartmentID = table.Column<int>(type: "int", nullable: true),
                    ClassSKUDefaultDepartmentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassSKUDefaultProductType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClassSKUMappings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassTableName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClassURLPattern = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ClassUsePublishFromTo = table.Column<bool>(type: "bit", nullable: true),
                    ClassUsesVersioning = table.Column<bool>(type: "bit", nullable: false),
                    ClassVersionGUID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ClassViewPageUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ClassXmlSchema = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Class", x => x.ClassID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Class_ClassDefaultPageTemplateID_CMS_PageTemplate",
                        column: x => x.ClassDefaultPageTemplateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplate",
                        principalColumn: "PageTemplateID");
                    table.ForeignKey(
                        name: "FK_CMS_Class_ClassPageTemplateCategoryID_CMS_PageTemplateCategory",
                        column: x => x.ClassPageTemplateCategoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplateCategory",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_CMS_Class_ClassResourceID_CMS_Resource",
                        column: x => x.ClassResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_PageTemplateSite",
                schema: "dbo",
                columns: table => new
                {
                    PageTemplateID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_PageTemplateSite", x => new { x.PageTemplateID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplateSite_PageTemplateID_CMS_PageTemplate",
                        column: x => x.PageTemplateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplate",
                        principalColumn: "PageTemplateID");
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplateSite_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_TemplateDeviceLayout",
                schema: "dbo",
                columns: table => new
                {
                    TemplateDeviceLayoutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LayoutID = table.Column<int>(type: "int", nullable: true),
                    PageTemplateID = table.Column<int>(type: "int", nullable: false),
                    ProfileID = table.Column<int>(type: "int", nullable: false),
                    LayoutCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LayoutCSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LayoutGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LayoutLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('7/31/2012 12:10:49 PM')"),
                    LayoutType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LayoutVersionGUID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_TemplateDeviceLayout", x => x.TemplateDeviceLayoutID);
                    table.ForeignKey(
                        name: "FK_CMS_TemplateDeviceLayout_LayoutID_CMS_Layout",
                        column: x => x.LayoutID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Layout",
                        principalColumn: "LayoutID");
                    table.ForeignKey(
                        name: "FK_CMS_TemplateDeviceLayout_PageTemplateID_CMS_PageTemplate",
                        column: x => x.PageTemplateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplate",
                        principalColumn: "PageTemplateID");
                    table.ForeignKey(
                        name: "FK_CMS_TemplateDeviceLayout_ProfileID_CMS_DeviceProfile",
                        column: x => x.ProfileID,
                        principalSchema: "dbo",
                        principalTable: "CMS_DeviceProfile",
                        principalColumn: "ProfileID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_UIElement",
                schema: "dbo",
                columns: table => new
                {
                    ElementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ElementPageTemplateID = table.Column<int>(type: "int", nullable: true),
                    ElementParentID = table.Column<int>(type: "int", nullable: true),
                    ElementResourceID = table.Column<int>(type: "int", nullable: false),
                    ElementAccessCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElementCaption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ElementCheckModuleReadPermission = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    ElementChildCount = table.Column<int>(type: "int", nullable: false),
                    ElementDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElementDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ElementFeature = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ElementFromVersion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ElementGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ElementIconClass = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ElementIconPath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ElementIDPath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ElementIsCustom = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ElementIsGlobalApplication = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ElementIsMenu = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ElementLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ElementLevel = table.Column<int>(type: "int", nullable: false),
                    ElementName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    ElementOrder = table.Column<int>(type: "int", nullable: true),
                    ElementProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElementRequiresGlobalAdminPriviligeLevel = table.Column<bool>(type: "bit", nullable: false),
                    ElementSize = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    ElementTargetURL = table.Column<string>(type: "nvarchar(650)", maxLength: 650, nullable: true),
                    ElementType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ElementVisibilityCondition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_UIElement", x => x.ElementID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_UIElement_ElementPageTemplateID_CMS_PageTemplate",
                        column: x => x.ElementPageTemplateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplate",
                        principalColumn: "PageTemplateID");
                    table.ForeignKey(
                        name: "FK_CMS_UIElement_ElementParentID_CMS_UIElement",
                        column: x => x.ElementParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_UIElement",
                        principalColumn: "ElementID");
                    table.ForeignKey(
                        name: "FK_CMS_UIElement_ElementResourceID_CMS_Resource",
                        column: x => x.ElementResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                });

            migrationBuilder.CreateTable(
                name: "OM_MVTVariant",
                schema: "dbo",
                columns: table => new
                {
                    MVTVariantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MVTVariantPageTemplateID = table.Column<int>(type: "int", nullable: false),
                    MVTVariantDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVTVariantDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MVTVariantDocumentID = table.Column<int>(type: "int", nullable: true),
                    MVTVariantEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    MVTVariantGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MVTVariantInstanceGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MVTVariantLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MVTVariantName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    MVTVariantWebParts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MVTVariantZoneID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_MVTVariant", x => x.MVTVariantID);
                    table.ForeignKey(
                        name: "FK_OM_MVTVariant_MVTVariantPageTemplateID_CMS_PageTemplate",
                        column: x => x.MVTVariantPageTemplateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplate",
                        principalColumn: "PageTemplateID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_Campaign",
                schema: "dbo",
                columns: table => new
                {
                    CampaignID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignScheduledTaskID = table.Column<int>(type: "int", nullable: true),
                    CampaignSiteID = table.Column<int>(type: "int", nullable: false),
                    CampaignCalculatedTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CampaignDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    CampaignGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampaignLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CampaignName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    CampaignOpenFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CampaignOpenTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CampaignUTMCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CampaignVisitors = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_Campaign", x => x.CampaignID);
                    table.ForeignKey(
                        name: "FK_Analytics_Campaign_CampaignScheduledTaskID_ScheduledTask",
                        column: x => x.CampaignScheduledTaskID,
                        principalSchema: "dbo",
                        principalTable: "CMS_ScheduledTask",
                        principalColumn: "TaskID");
                    table.ForeignKey(
                        name: "FK_Analytics_Campaign_StatisticsSiteID_CMS_Site",
                        column: x => x.CampaignSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Tag",
                schema: "dbo",
                columns: table => new
                {
                    TagID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagGroupID = table.Column<int>(type: "int", nullable: false),
                    TagCount = table.Column<int>(type: "int", nullable: false),
                    TagGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Tag", x => x.TagID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Tag_TagGroupID_CMS_TagGroup",
                        column: x => x.TagGroupID,
                        principalSchema: "dbo",
                        principalTable: "CMS_TagGroup",
                        principalColumn: "TagGroupID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Address",
                schema: "dbo",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressCountryID = table.Column<int>(type: "int", nullable: false),
                    AddressCustomerID = table.Column<int>(type: "int", nullable: false),
                    AddressStateID = table.Column<int>(type: "int", nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    AddressGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddressLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('10/18/2012 3:39:07 PM')"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AddressName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    AddressPersonalName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    AddressPhone = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    AddressZip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_CustomerAdress", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_COM_Address_AddressCountryID_CMS_Country",
                        column: x => x.AddressCountryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Country",
                        principalColumn: "CountryID");
                    table.ForeignKey(
                        name: "FK_COM_Address_AddressCustomerID_COM_Customer",
                        column: x => x.AddressCustomerID,
                        principalSchema: "dbo",
                        principalTable: "COM_Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_COM_Address_AddressStateID_CMS_State",
                        column: x => x.AddressStateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_State",
                        principalColumn: "StateID");
                });

            migrationBuilder.CreateTable(
                name: "COM_CustomerCreditHistory",
                schema: "dbo",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventCustomerID = table.Column<int>(type: "int", nullable: false),
                    EventSiteID = table.Column<int>(type: "int", nullable: true),
                    EventCreditChange = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
                    EventCreditGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EventCreditLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/26/2012 12:21:38 PM')"),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/27/2012 2:48:56 PM')"),
                    EventDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EventName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_CustomerCreditHistory", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_COM_CustomerCreditHistory_EventCustomerID_COM_Customer",
                        column: x => x.EventCustomerID,
                        principalSchema: "dbo",
                        principalTable: "COM_Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_COM_CustomerCreditHistory_EventSiteID_CMS_Site",
                        column: x => x.EventSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_CouponCode",
                schema: "dbo",
                columns: table => new
                {
                    CouponCodeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouponCodeDiscountID = table.Column<int>(type: "int", nullable: false),
                    CouponCodeCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    CouponCodeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CouponCodeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CouponCodeUseCount = table.Column<int>(type: "int", nullable: true),
                    CouponCodeUseLimit = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_CouponCode", x => x.CouponCodeID);
                    table.ForeignKey(
                        name: "FK_COM_CouponCode_CouponCodeDiscountID_COM_Discount",
                        column: x => x.CouponCodeDiscountID,
                        principalSchema: "dbo",
                        principalTable: "COM_Discount",
                        principalColumn: "DiscountID");
                });

            migrationBuilder.CreateTable(
                name: "COM_CurrencyExchangeRate",
                schema: "dbo",
                columns: table => new
                {
                    ExchagneRateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExchangeRateToCurrencyID = table.Column<int>(type: "int", nullable: false),
                    ExchangeTableID = table.Column<int>(type: "int", nullable: false),
                    ExchangeRateGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExchangeRateLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExchangeRateValue = table.Column<decimal>(type: "decimal(18,9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_CurrencyExchangeRate", x => x.ExchagneRateID);
                    table.ForeignKey(
                        name: "FK_COM_CurrencyExchangeRate_ExchangeRateToCurrencyID_COM_Currency",
                        column: x => x.ExchangeRateToCurrencyID,
                        principalSchema: "dbo",
                        principalTable: "COM_Currency",
                        principalColumn: "CurrencyID");
                    table.ForeignKey(
                        name: "FK_COM_CurrencyExchangeRate_ExchangeTableID_COM_ExchangeTable",
                        column: x => x.ExchangeTableID,
                        principalSchema: "dbo",
                        principalTable: "COM_ExchangeTable",
                        principalColumn: "ExchangeTableID");
                });

            migrationBuilder.CreateTable(
                name: "COM_GiftCardCouponCode",
                schema: "dbo",
                columns: table => new
                {
                    GiftCardCouponCodeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiftCardCouponCodeGiftCardID = table.Column<int>(type: "int", nullable: false),
                    GiftCardCouponCodeCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    GiftCardCouponCodeGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiftCardCouponCodeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    GiftCardCouponCodeRemainingValue = table.Column<decimal>(type: "decimal(18,9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_GiftCardCouponCode", x => x.GiftCardCouponCodeID);
                    table.ForeignKey(
                        name: "FK_COM_GiftCardCouponCode_GiftCardCouponCodeGiftCardID_COM_GiftCard",
                        column: x => x.GiftCardCouponCodeGiftCardID,
                        principalSchema: "dbo",
                        principalTable: "COM_GiftCard",
                        principalColumn: "GiftCardID");
                });

            migrationBuilder.CreateTable(
                name: "COM_PaymentOption",
                schema: "dbo",
                columns: table => new
                {
                    PaymentOptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentOptionAuthorizedOrderStatusID = table.Column<int>(type: "int", nullable: true),
                    PaymentOptionFailedOrderStatusID = table.Column<int>(type: "int", nullable: true),
                    PaymentOptionSiteID = table.Column<int>(type: "int", nullable: true),
                    PaymentOptionSucceededOrderStatusID = table.Column<int>(type: "int", nullable: true),
                    PaymentOptionAllowIfNoShipping = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PaymentOptionAssemblyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PaymentOptionClassName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PaymentOptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentOptionDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    PaymentOptionEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    PaymentOptionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentOptionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/27/2012 4:18:26 PM')"),
                    PaymentOptionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    PaymentOptionPaymentGateUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PaymentOptionThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_PaymentOption", x => x.PaymentOptionID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COM_PaymentOption_PaymentOptionAuthorizedOrderStatusID_COM_OrderStatus",
                        column: x => x.PaymentOptionAuthorizedOrderStatusID,
                        principalSchema: "dbo",
                        principalTable: "COM_OrderStatus",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "FK_COM_PaymentOption_PaymentOptionFailedOrderStatusID_COM_OrderStatus",
                        column: x => x.PaymentOptionFailedOrderStatusID,
                        principalSchema: "dbo",
                        principalTable: "COM_OrderStatus",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "FK_COM_PaymentOption_PaymentOptionSiteID_CMS_Site",
                        column: x => x.PaymentOptionSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_COM_PaymentOption_PaymentOptionSucceededOrderStatusID_COM_OrderStatus",
                        column: x => x.PaymentOptionSucceededOrderStatusID,
                        principalSchema: "dbo",
                        principalTable: "COM_OrderStatus",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Department",
                schema: "dbo",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentDefaultTaxClassID = table.Column<int>(type: "int", nullable: true),
                    DepartmentSiteID = table.Column<int>(type: "int", nullable: true),
                    DepartmentDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    DepartmentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Department", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_COM_Department_DepartmentDefaultTaxClassID_COM_TaxClass",
                        column: x => x.DepartmentDefaultTaxClassID,
                        principalSchema: "dbo",
                        principalTable: "COM_TaxClass",
                        principalColumn: "TaxClassID");
                    table.ForeignKey(
                        name: "FK_COM_Department_DepartmentSiteID_CMS_Site",
                        column: x => x.DepartmentSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_ShippingOption",
                schema: "dbo",
                columns: table => new
                {
                    ShippingOptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingOptionCarrierID = table.Column<int>(type: "int", nullable: true),
                    ShippingOptionSiteID = table.Column<int>(type: "int", nullable: true),
                    ShippingOptionTaxClassID = table.Column<int>(type: "int", nullable: true),
                    ShippingOptionCarrierServiceName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ShippingOptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingOptionDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    ShippingOptionEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ShippingOptionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShippingOptionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/26/2012 12:44:18 PM')"),
                    ShippingOptionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    ShippingOptionThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_ShippingOption", x => x.ShippingOptionID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_COM_ShippingOption_ShippingOptionCarrierID_COM_Carrier",
                        column: x => x.ShippingOptionCarrierID,
                        principalSchema: "dbo",
                        principalTable: "COM_Carrier",
                        principalColumn: "CarrierID");
                    table.ForeignKey(
                        name: "FK_COM_ShippingOption_ShippingOptionSiteID_CMS_Site",
                        column: x => x.ShippingOptionSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_COM_ShippingOption_ShippingOptionTaxClassID_COM_TaxClass",
                        column: x => x.ShippingOptionTaxClassID,
                        principalSchema: "dbo",
                        principalTable: "COM_TaxClass",
                        principalColumn: "TaxClassID");
                });

            migrationBuilder.CreateTable(
                name: "COM_TaxClassCountry",
                schema: "dbo",
                columns: table => new
                {
                    TaxClassCountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryID = table.Column<int>(type: "int", nullable: false),
                    TaxClassID = table.Column<int>(type: "int", nullable: false),
                    TaxValue = table.Column<decimal>(type: "decimal(18,9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_TaxClassCountry", x => x.TaxClassCountryID);
                    table.ForeignKey(
                        name: "FK_COM_TaxCategoryCountry_CountryID_CMS_Country",
                        column: x => x.CountryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Country",
                        principalColumn: "CountryID");
                    table.ForeignKey(
                        name: "FK_COM_TaxCategoryCountry_TaxClassID_COM_TaxClass",
                        column: x => x.TaxClassID,
                        principalSchema: "dbo",
                        principalTable: "COM_TaxClass",
                        principalColumn: "TaxClassID");
                });

            migrationBuilder.CreateTable(
                name: "COM_TaxClassState",
                schema: "dbo",
                columns: table => new
                {
                    TaxClassStateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateID = table.Column<int>(type: "int", nullable: false),
                    TaxClassID = table.Column<int>(type: "int", nullable: false),
                    TaxValue = table.Column<decimal>(type: "decimal(18,9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_TaxClassState", x => x.TaxClassStateID);
                    table.ForeignKey(
                        name: "FK_COM_TaxClassState_StateID_CMS_State",
                        column: x => x.StateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_State",
                        principalColumn: "StateID");
                    table.ForeignKey(
                        name: "FK_COM_TaxClassState_TaxClassID_COM_TaxClass",
                        column: x => x.TaxClassID,
                        principalSchema: "dbo",
                        principalTable: "COM_TaxClass",
                        principalColumn: "TaxClassID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Role",
                schema: "dbo",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleGroupID = table.Column<int>(type: "int", nullable: true),
                    SiteID = table.Column<int>(type: "int", nullable: true),
                    RoleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleIsDomain = table.Column<bool>(type: "bit", nullable: true),
                    RoleIsGroupAdministrator = table.Column<bool>(type: "bit", nullable: true),
                    RoleLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Role", x => x.RoleID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Role_RoleGroupID_Community_Group",
                        column: x => x.RoleGroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_CMS_Role_SiteID_CMS_SiteID",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Community_GroupMember",
                schema: "dbo",
                columns: table => new
                {
                    MemberID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberApprovedByUserID = table.Column<int>(type: "int", nullable: true),
                    MemberGroupID = table.Column<int>(type: "int", nullable: false),
                    MemberInvitedByUserID = table.Column<int>(type: "int", nullable: true),
                    MemberUserID = table.Column<int>(type: "int", nullable: false),
                    MemberApprovedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MemberComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MemberJoined = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberRejectedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MemberStatus = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community_GroupMember", x => x.MemberID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Community_GroupMember_MemberApprovedByUserID_CMS_User",
                        column: x => x.MemberApprovedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Community_GroupMember_MemberGroupID_Community_Group",
                        column: x => x.MemberGroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_Community_GroupMember_MemberInvitedByUserID_CMS_User",
                        column: x => x.MemberInvitedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Community_GroupMember_MemberUserID_CMS_User",
                        column: x => x.MemberUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Community_Invitation",
                schema: "dbo",
                columns: table => new
                {
                    InvitationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvitationGroupID = table.Column<int>(type: "int", nullable: true),
                    InvitedByUserID = table.Column<int>(type: "int", nullable: false),
                    InvitedUserID = table.Column<int>(type: "int", nullable: true),
                    InvitationComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvitationCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InvitationGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvitationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvitationUserEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    InvitationValidTo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community_GroupInvitation", x => x.InvitationID);
                    table.ForeignKey(
                        name: "FK_Community_GroupInvitation_InvitationGroupID_Community_Group",
                        column: x => x.InvitationGroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_Community_GroupInvitation_InvitedByUserID_CMS_User",
                        column: x => x.InvitedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Community_GroupInvitation_InvitedUserID_CMS_User",
                        column: x => x.InvitedUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Forums_ForumGroup",
                schema: "dbo",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupGroupID = table.Column<int>(type: "int", nullable: true),
                    GroupSiteID = table.Column<int>(type: "int", nullable: false),
                    GroupAttachmentMaxFileSize = table.Column<int>(type: "int", nullable: true),
                    GroupAuthorDelete = table.Column<bool>(type: "bit", nullable: true),
                    GroupAuthorEdit = table.Column<bool>(type: "bit", nullable: true),
                    GroupBaseUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GroupDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupDiscussionActions = table.Column<int>(type: "int", nullable: true),
                    GroupDisplayEmails = table.Column<bool>(type: "bit", nullable: true),
                    GroupDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    GroupEnableOptIn = table.Column<bool>(type: "bit", nullable: true),
                    GroupGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GroupHTMLEditor = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    GroupImageMaxSideSize = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((400))"),
                    GroupIsAnswerLimit = table.Column<int>(type: "int", nullable: true),
                    GroupLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('11/6/2013 2:43:02 PM')"),
                    GroupLogActivity = table.Column<bool>(type: "bit", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    GroupOptInApprovalURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    GroupOrder = table.Column<int>(type: "int", nullable: true),
                    GroupRequireEmail = table.Column<bool>(type: "bit", nullable: true),
                    GroupSendOptInConfirmation = table.Column<bool>(type: "bit", nullable: true),
                    GroupType = table.Column<int>(type: "int", nullable: true),
                    GroupUnsubscriptionUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    GroupUseCAPTCHA = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums_ForumGroup", x => x.GroupID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Forums_ForumGroup_GroupGroupID_Community_Group",
                        column: x => x.GroupGroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_Forums_ForumGroup_GroupSiteID_CMS_Site",
                        column: x => x.GroupSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Media_Library",
                schema: "dbo",
                columns: table => new
                {
                    LibraryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LibraryGroupID = table.Column<int>(type: "int", nullable: true),
                    LibrarySiteID = table.Column<int>(type: "int", nullable: false),
                    LibraryAccess = table.Column<int>(type: "int", nullable: true),
                    LibraryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LibraryDisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LibraryFolder = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    LibraryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LibraryLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LibraryName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "(N'')"),
                    LibraryTeaserGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LibraryTeaserPath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media_Library", x => x.LibraryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Media_Library_LibraryGroupID_Community_Group",
                        column: x => x.LibraryGroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_Media_Library_LibrarySiteID_CMS_Site",
                        column: x => x.LibrarySiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Polls_Poll",
                schema: "dbo",
                columns: table => new
                {
                    PollID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PollGroupID = table.Column<int>(type: "int", nullable: true),
                    PollSiteID = table.Column<int>(type: "int", nullable: true),
                    PollAccess = table.Column<int>(type: "int", nullable: false),
                    PollAllowMultipleAnswers = table.Column<bool>(type: "bit", nullable: false),
                    PollCodeName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    PollDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    PollGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PollLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PollLogActivity = table.Column<bool>(type: "bit", nullable: true),
                    PollOpenFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PollOpenTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PollQuestion = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "(N'')"),
                    PollResponseMessage = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true, defaultValueSql: "(N'')"),
                    PollTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls_Poll", x => x.PollID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Polls_Poll_PollGroupID_Community_Group",
                        column: x => x.PollGroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_Polls_Poll_PollSiteID_CMS_Site",
                        column: x => x.PollSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Integration_Synchronization",
                schema: "dbo",
                columns: table => new
                {
                    SynchronizationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SynchronizationConnectorID = table.Column<int>(type: "int", nullable: false),
                    SynchronizationTaskID = table.Column<int>(type: "int", nullable: false),
                    SynchronizationErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SynchronizationIsRunning = table.Column<bool>(type: "bit", nullable: true),
                    SynchronizationLastRun = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integration_Synchronization", x => x.SynchronizationID);
                    table.ForeignKey(
                        name: "FK_Integration_Synchronization_SynchronizationConnectorID_Integration_Connector",
                        column: x => x.SynchronizationConnectorID,
                        principalSchema: "dbo",
                        principalTable: "Integration_Connector",
                        principalColumn: "ConnectorID");
                    table.ForeignKey(
                        name: "FK_Integration_Synchronization_SynchronizationTaskID_Integration_Task",
                        column: x => x.SynchronizationTaskID,
                        principalSchema: "dbo",
                        principalTable: "Integration_Task",
                        principalColumn: "TaskID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_Newsletter",
                schema: "dbo",
                columns: table => new
                {
                    NewsletterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsletterDynamicScheduledTaskID = table.Column<int>(type: "int", nullable: true),
                    NewsletterOptInTemplateID = table.Column<int>(type: "int", nullable: true),
                    NewsletterSiteID = table.Column<int>(type: "int", nullable: false),
                    NewsletterUnsubscriptionTemplateID = table.Column<int>(type: "int", nullable: false),
                    NewsletterBaseUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NewsletterDisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    NewsletterDraftEmails = table.Column<string>(type: "nvarchar(998)", maxLength: 998, nullable: true),
                    NewsletterDynamicSubject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NewsletterDynamicURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    NewsletterEnableOptIn = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NewsletterGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NewsletterLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('3/13/2015 2:53:28 PM')"),
                    NewsletterLogActivity = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    NewsletterName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    NewsletterOptInApprovalURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    NewsletterSendOptInConfirmation = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NewsletterSenderEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false, defaultValueSql: "(N'')"),
                    NewsletterSenderName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    NewsletterSource = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false, defaultValueSql: "(N'T')"),
                    NewsletterSubscriptionTemplateID = table.Column<int>(type: "int", nullable: true),
                    NewsletterTrackClickedLinks = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    NewsletterTrackOpenEmails = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    NewsletterType = table.Column<int>(type: "int", nullable: false),
                    NewsletterUnsubscribeUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_Newsletter", x => x.NewsletterID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Newsletter_Newsletter_NewsletterDynamicScheduledTaskID_CMS_ScheduledTask",
                        column: x => x.NewsletterDynamicScheduledTaskID,
                        principalSchema: "dbo",
                        principalTable: "CMS_ScheduledTask",
                        principalColumn: "TaskID");
                    table.ForeignKey(
                        name: "FK_Newsletter_Newsletter_NewsletterOptInTemplateID_EmailTemplate",
                        column: x => x.NewsletterOptInTemplateID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_EmailTemplate",
                        principalColumn: "TemplateID");
                    table.ForeignKey(
                        name: "FK_Newsletter_Newsletter_NewsletterSiteID_CMS_Site",
                        column: x => x.NewsletterSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Newsletter_Newsletter_NewsletterUnsubscriptionTemplateID_Newsletter_EmailTemplate",
                        column: x => x.NewsletterUnsubscriptionTemplateID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_EmailTemplate",
                        principalColumn: "TemplateID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_EmailWidgetTemplate",
                schema: "dbo",
                columns: table => new
                {
                    EmailWidgetTemplateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailWidgetID = table.Column<int>(type: "int", nullable: false),
                    TemplateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_EmailWidgetTemplate", x => x.EmailWidgetTemplateID);
                    table.ForeignKey(
                        name: "FK_Newsletter_EmailWidgetTemplate_EmailWidgetID_Newsletter_EmailWidget",
                        column: x => x.EmailWidgetID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_EmailWidget",
                        principalColumn: "EmailWidgetID");
                    table.ForeignKey(
                        name: "FK_Newsletter_EmailWidgetTemplate_TemplateID_Newsletter_EmailTemplate",
                        column: x => x.TemplateID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_EmailTemplate",
                        principalColumn: "TemplateID");
                });

            migrationBuilder.CreateTable(
                name: "Notification_Subscription",
                schema: "dbo",
                columns: table => new
                {
                    SubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionGatewayID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionSiteID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SubscriptionTemplateID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionUserID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionEventCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubscriptionEventData1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriptionEventData2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriptionEventDisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    SubscriptionEventObjectID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionEventSource = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubscriptionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriptionTarget = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SubscriptionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriptionUseHTML = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_Subscription", x => x.SubscriptionID);
                    table.ForeignKey(
                        name: "FK_Notification_Subscription_SubscriptionGatewayID_Notification_Gateway",
                        column: x => x.SubscriptionGatewayID,
                        principalSchema: "dbo",
                        principalTable: "Notification_Gateway",
                        principalColumn: "GatewayID");
                    table.ForeignKey(
                        name: "FK_Notification_Subscription_SubscriptionSiteID_CMS_Site",
                        column: x => x.SubscriptionSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Notification_Subscription_SubscriptionTemplateID_Notification_Template",
                        column: x => x.SubscriptionTemplateID,
                        principalSchema: "dbo",
                        principalTable: "Notification_Template",
                        principalColumn: "TemplateID");
                    table.ForeignKey(
                        name: "FK_Notification_Subscription_SubscriptionUserID_CMS_User",
                        column: x => x.SubscriptionUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Notification_TemplateText",
                schema: "dbo",
                columns: table => new
                {
                    TemplateTextID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GatewayID = table.Column<int>(type: "int", nullable: false),
                    TemplateID = table.Column<int>(type: "int", nullable: false),
                    TemplateHTMLText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplatePlainText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateSubject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TemplateTextGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TemplateTextLastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification_TemplateText", x => x.TemplateTextID);
                    table.ForeignKey(
                        name: "FK_Notification_TemplateText_GatewayID_Notification_Gateway",
                        column: x => x.GatewayID,
                        principalSchema: "dbo",
                        principalTable: "Notification_Gateway",
                        principalColumn: "GatewayID");
                    table.ForeignKey(
                        name: "FK_Notification_TemplateText_TemplateID_Notification_Template",
                        column: x => x.TemplateID,
                        principalSchema: "dbo",
                        principalTable: "Notification_Template",
                        principalColumn: "TemplateID");
                });

            migrationBuilder.CreateTable(
                name: "OM_ABVariant",
                schema: "dbo",
                columns: table => new
                {
                    ABVariantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABVariantSiteID = table.Column<int>(type: "int", nullable: false),
                    ABVariantTestID = table.Column<int>(type: "int", nullable: false),
                    ABVariantDisplayName = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false, defaultValueSql: "('')"),
                    ABVariantGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ABVariantLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ABVariantName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    ABVariantPath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ABVariant", x => x.ABVariantID);
                    table.ForeignKey(
                        name: "FK_OM_ABVariant_ABVariantTestID_OM_ABTest",
                        column: x => x.ABVariantTestID,
                        principalSchema: "dbo",
                        principalTable: "OM_ABTest",
                        principalColumn: "ABTestID");
                    table.ForeignKey(
                        name: "FK_OM_ABVariant_CMS_Site",
                        column: x => x.ABVariantSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "OM_ABVariantData",
                schema: "dbo",
                columns: table => new
                {
                    ABVariantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ABVariantTestID = table.Column<int>(type: "int", nullable: false),
                    ABVariantDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    ABVariantGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ABVariantIsOriginal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_ABVariantData", x => x.ABVariantID);
                    table.ForeignKey(
                        name: "FK_OM_ABVariantData_ABVariantTestID_OM_ABTest",
                        column: x => x.ABVariantTestID,
                        principalSchema: "dbo",
                        principalTable: "OM_ABTest",
                        principalColumn: "ABTestID");
                });

            migrationBuilder.CreateTable(
                name: "SharePoint_SharePointLibrary",
                schema: "dbo",
                columns: table => new
                {
                    SharePointLibraryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharePointLibrarySharePointConnectionID = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    SharePointLibrarySiteID = table.Column<int>(type: "int", nullable: false),
                    SharePointLibraryDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    SharePointLibraryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SharePointLibraryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('10/3/2014 2:45:04 PM')"),
                    SharePointLibraryListTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    SharePointLibraryListType = table.Column<int>(type: "int", nullable: false),
                    SharePointLibraryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    SharePointLibrarySynchronizationPeriod = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((720))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharePoint_SharePointLibrary", x => x.SharePointLibraryID);
                    table.ForeignKey(
                        name: "FK_SharePoint_SharePointLibrary_CMS_Site",
                        column: x => x.SharePointLibrarySiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_SharePoint_SharePointLibrary_SharePoint_SharePointConnection",
                        column: x => x.SharePointLibrarySharePointConnectionID,
                        principalSchema: "dbo",
                        principalTable: "SharePoint_SharePointConnection",
                        principalColumn: "SharePointConnectionID");
                });

            migrationBuilder.CreateTable(
                name: "SM_FacebookAccount",
                schema: "dbo",
                columns: table => new
                {
                    FacebookAccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookAccountFacebookApplicationID = table.Column<int>(type: "int", nullable: false),
                    FacebookAccountSiteID = table.Column<int>(type: "int", nullable: false),
                    FacebookAccountDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FacebookAccountGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacebookAccountIsDefault = table.Column<bool>(type: "bit", nullable: true),
                    FacebookAccountLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FacebookAccountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FacebookAccountPageAccessToken = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')"),
                    FacebookAccountPageAccessTokenExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FacebookAccountPageID = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_FacebookAccount", x => x.FacebookAccountID);
                    table.ForeignKey(
                        name: "FK_SM_FacebookAccount_CMS_Site",
                        column: x => x.FacebookAccountSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_SM_FacebookAccount_SM_FacebookApplication",
                        column: x => x.FacebookAccountFacebookApplicationID,
                        principalSchema: "dbo",
                        principalTable: "SM_FacebookApplication",
                        principalColumn: "FacebookApplicationID");
                });

            migrationBuilder.CreateTable(
                name: "SM_TwitterAccount",
                schema: "dbo",
                columns: table => new
                {
                    TwitterAccountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TwitterAccountSiteID = table.Column<int>(type: "int", nullable: false),
                    TwitterAccountTwitterApplicationID = table.Column<int>(type: "int", nullable: false),
                    TwitterAccountAccessToken = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    TwitterAccountAccessTokenSecret = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false, defaultValueSql: "('')"),
                    TwitterAccountDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TwitterAccountFollowers = table.Column<int>(type: "int", nullable: true),
                    TwitterAccountGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TwitterAccountIsDefault = table.Column<bool>(type: "bit", nullable: true),
                    TwitterAccountLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TwitterAccountMentions = table.Column<int>(type: "int", nullable: true),
                    TwitterAccountMentionsRange = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    TwitterAccountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TwitterAccountUserID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_TwitterAccount", x => x.TwitterAccountID);
                    table.ForeignKey(
                        name: "FK_SM_TwitterAccount_CMS_Site",
                        column: x => x.TwitterAccountSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_SM_TwitterAccount_SM_TwitterApplication",
                        column: x => x.TwitterAccountTwitterApplicationID,
                        principalSchema: "dbo",
                        principalTable: "SM_TwitterApplication",
                        principalColumn: "TwitterApplicationID");
                });

            migrationBuilder.CreateTable(
                name: "Staging_Synchronization",
                schema: "dbo",
                columns: table => new
                {
                    SynchronizationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SynchronizationServerID = table.Column<int>(type: "int", nullable: false),
                    SynchronizationTaskID = table.Column<int>(type: "int", nullable: false),
                    SynchronizationErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SynchronizationLastRun = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staging_Synchronization", x => x.SynchronizationID);
                    table.ForeignKey(
                        name: "FK_Staging_Synchronization_SynchronizationServerID_Staging_Server",
                        column: x => x.SynchronizationServerID,
                        principalSchema: "dbo",
                        principalTable: "Staging_Server",
                        principalColumn: "ServerID");
                    table.ForeignKey(
                        name: "FK_Staging_Synchronization_SynchronizationTaskID_Staging_Task",
                        column: x => x.SynchronizationTaskID,
                        principalSchema: "dbo",
                        principalTable: "Staging_Task",
                        principalColumn: "TaskID");
                });

            migrationBuilder.CreateTable(
                name: "staging_TaskGroupTask",
                schema: "dbo",
                columns: table => new
                {
                    TaskGroupTaskID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskGroupID = table.Column<int>(type: "int", nullable: false),
                    TaskID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staging_TaskGroupTask", x => x.TaskGroupTaskID);
                    table.ForeignKey(
                        name: "FK_Staging_TaskGroupTask_Staging_Task",
                        column: x => x.TaskID,
                        principalSchema: "dbo",
                        principalTable: "Staging_Task",
                        principalColumn: "TaskID");
                    table.ForeignKey(
                        name: "FK_Staging_TaskGroupTask_Staging_TaskGroup",
                        column: x => x.TaskGroupID,
                        principalSchema: "dbo",
                        principalTable: "staging_TaskGroup",
                        principalColumn: "TaskGroupID");
                });

            migrationBuilder.CreateTable(
                name: "Staging_TaskUser",
                schema: "dbo",
                columns: table => new
                {
                    TaskUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staging_TaskUser", x => x.TaskUserID);
                    table.ForeignKey(
                        name: "FK_Staging_TaskUser_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Staging_TaskUser_StagingTask",
                        column: x => x.TaskID,
                        principalSchema: "dbo",
                        principalTable: "Staging_Task",
                        principalColumn: "TaskID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_AutomationState",
                schema: "dbo",
                columns: table => new
                {
                    StateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateSiteID = table.Column<int>(type: "int", nullable: true),
                    StateStepID = table.Column<int>(type: "int", nullable: false),
                    StateUserID = table.Column<int>(type: "int", nullable: true),
                    StateWorkflowID = table.Column<int>(type: "int", nullable: false),
                    StateActionStatus = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    StateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StateCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StateObjectID = table.Column<int>(type: "int", nullable: false),
                    StateObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StateStatus = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_AutomationState", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_CMS_AutomationState_StateSiteID_CMS_Site",
                        column: x => x.StateSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_AutomationState_StateStepID",
                        column: x => x.StateStepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                    table.ForeignKey(
                        name: "FK_CMS_AutomationState_StateUserID_CMS_User",
                        column: x => x.StateUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_AutomationState_StateWorkflowID",
                        column: x => x.StateWorkflowID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Workflow",
                        principalColumn: "WorkflowID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ObjectSettings",
                schema: "dbo",
                columns: table => new
                {
                    ObjectSettingsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectCheckedOutByUserID = table.Column<int>(type: "int", nullable: true),
                    ObjectCheckedOutVersionHistoryID = table.Column<int>(type: "int", nullable: true),
                    ObjectPublishedVersionHistoryID = table.Column<int>(type: "int", nullable: true),
                    ObjectWorkflowStepID = table.Column<int>(type: "int", nullable: true),
                    ObjectCheckedOutWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ObjectComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjectSettingsObjectID = table.Column<int>(type: "int", nullable: false),
                    ObjectSettingsObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    ObjectTags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjectWorkflowSendEmails = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ObjectSettings", x => x.ObjectSettingsID);
                    table.ForeignKey(
                        name: "FK_CMS_ObjectSettings_ObjectCheckedOutByUserID_CMS_User",
                        column: x => x.ObjectCheckedOutByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_ObjectSettings_ObjectCheckedOutVersionHistoryID_CMS_ObjectVersionHistory",
                        column: x => x.ObjectCheckedOutVersionHistoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_ObjectVersionHistory",
                        principalColumn: "VersionID");
                    table.ForeignKey(
                        name: "FK_CMS_ObjectSettings_ObjectPublishedVersionHistoryID_CMS_ObjectVersionHistory",
                        column: x => x.ObjectPublishedVersionHistoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_ObjectVersionHistory",
                        principalColumn: "VersionID");
                    table.ForeignKey(
                        name: "FK_CMS_ObjectSettings_ObjectWorkflowStepID_CMS_WorkflowStep",
                        column: x => x.ObjectWorkflowStepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WorkflowStepUser",
                schema: "dbo",
                columns: table => new
                {
                    WorkflowStepUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    StepSourcePointGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WorkflowStepUser", x => x.WorkflowStepUserID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowStepUser_StepID_CMS_WorkflowStep",
                        column: x => x.StepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowStepUser_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WorkflowTransition",
                schema: "dbo",
                columns: table => new
                {
                    TransitionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransitionEndStepID = table.Column<int>(type: "int", nullable: false),
                    TransitionStartStepID = table.Column<int>(type: "int", nullable: false),
                    TransitionWorkflowID = table.Column<int>(type: "int", nullable: false),
                    TransitionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransitionSourcePointGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransitionType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WorkflowTransition", x => x.TransitionID);
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowTransition_TransitionEndStepID_CMS_WorkflowStep",
                        column: x => x.TransitionEndStepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowTransition_TransitionStartStepID_CMS_WorkflowStep",
                        column: x => x.TransitionStartStepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowTransition_TransitionWorkflowID_CMS_Workflow",
                        column: x => x.TransitionWorkflowID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Workflow",
                        principalColumn: "WorkflowID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_InitiatedChatRequest",
                schema: "dbo",
                columns: table => new
                {
                    InitiatedChatRequestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InitiatedChatRequestInitiatorChatUserID = table.Column<int>(type: "int", nullable: false),
                    InitiatedChatRequestRoomID = table.Column<int>(type: "int", nullable: false),
                    InitiatedChatRequestUserID = table.Column<int>(type: "int", nullable: true),
                    InitiatedChatRequestContactID = table.Column<int>(type: "int", nullable: true),
                    InitiatedChatRequestInitiatorName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InitiatedChatRequestLastModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InitiatedChatRequestState = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_InitiatedChatRequest", x => x.InitiatedChatRequestID);
                    table.ForeignKey(
                        name: "FK_Chat_InitiatedChatRequest_CMS_User",
                        column: x => x.InitiatedChatRequestUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Chat_InitiatedChatRequest_Chat_Room",
                        column: x => x.InitiatedChatRequestRoomID,
                        principalSchema: "dbo",
                        principalTable: "Chat_Room",
                        principalColumn: "ChatRoomID");
                    table.ForeignKey(
                        name: "FK_Chat_InitiatedChatRequest_Chat_User",
                        column: x => x.InitiatedChatRequestInitiatorChatUserID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_Message",
                schema: "dbo",
                columns: table => new
                {
                    ChatMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatMessageRecipientID = table.Column<int>(type: "int", nullable: true),
                    ChatMessageRoomID = table.Column<int>(type: "int", nullable: false),
                    ChatMessageUserID = table.Column<int>(type: "int", nullable: true),
                    ChatMessageCreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('7/25/2011 2:47:18 PM')"),
                    ChatMessageIPAddress = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')"),
                    ChatMessageLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('8/3/2011 11:24:54 AM')"),
                    ChatMessageRejected = table.Column<bool>(type: "bit", nullable: false),
                    ChatMessageSystemMessageType = table.Column<int>(type: "int", nullable: false),
                    ChatMessageText = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_Message", x => x.ChatMessageID);
                    table.ForeignKey(
                        name: "FK_Chat_Message_Chat_Room",
                        column: x => x.ChatMessageRoomID,
                        principalSchema: "dbo",
                        principalTable: "Chat_Room",
                        principalColumn: "ChatRoomID");
                    table.ForeignKey(
                        name: "FK_Chat_Message_Chat_User_Recipient",
                        column: x => x.ChatMessageRecipientID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                    table.ForeignKey(
                        name: "FK_Chat_Message_Chat_User_Sender",
                        column: x => x.ChatMessageUserID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_Notification",
                schema: "dbo",
                columns: table => new
                {
                    ChatNotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatNotificationReceiverID = table.Column<int>(type: "int", nullable: false),
                    ChatNotificationRoomID = table.Column<int>(type: "int", nullable: true),
                    ChatNotificationSenderID = table.Column<int>(type: "int", nullable: false),
                    ChatNotificationSiteID = table.Column<int>(type: "int", nullable: true),
                    ChatNotificationIsRead = table.Column<bool>(type: "bit", nullable: false),
                    ChatNotificationReadDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChatNotificationSendDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChatNotificationType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_Notification", x => x.ChatNotificationID);
                    table.ForeignKey(
                        name: "FK_Chat_Notification_CMS_Site",
                        column: x => x.ChatNotificationSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Chat_Notification_Chat_Room",
                        column: x => x.ChatNotificationRoomID,
                        principalSchema: "dbo",
                        principalTable: "Chat_Room",
                        principalColumn: "ChatRoomID");
                    table.ForeignKey(
                        name: "FK_Chat_Notification_Chat_User_Receiver",
                        column: x => x.ChatNotificationReceiverID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                    table.ForeignKey(
                        name: "FK_Chat_Notification_Chat_User_Sender",
                        column: x => x.ChatNotificationSenderID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_RoomUser",
                schema: "dbo",
                columns: table => new
                {
                    ChatRoomUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatRoomUserChatUserID = table.Column<int>(type: "int", nullable: false),
                    ChatRoomUserRoomID = table.Column<int>(type: "int", nullable: false),
                    ChatRoomUserAdminLevel = table.Column<int>(type: "int", nullable: false),
                    ChatRoomUserJoinTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChatRoomUserKickExpiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChatRoomUserLastChecking = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ChatRoomUserLastModification = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('11/10/2011 3:29:00 PM')"),
                    ChatRoomUserLeaveTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_RoomUser", x => x.ChatRoomUserID);
                    table.ForeignKey(
                        name: "FK_Chat_RoomUser_Chat_Room",
                        column: x => x.ChatRoomUserRoomID,
                        principalSchema: "dbo",
                        principalTable: "Chat_Room",
                        principalColumn: "ChatRoomID");
                    table.ForeignKey(
                        name: "FK_Chat_RoomUser_Chat_User",
                        column: x => x.ChatRoomUserChatUserID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                });

            migrationBuilder.CreateTable(
                name: "Chat_SupportTakenRoom",
                schema: "dbo",
                columns: table => new
                {
                    ChatSupportTakenRoomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatSupportTakenRoomChatUserID = table.Column<int>(type: "int", nullable: true),
                    ChatSupportTakenRoomRoomID = table.Column<int>(type: "int", nullable: false),
                    ChatSupportTakenRoomLastModification = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('4/16/2012 5:11:30 PM')"),
                    ChatSupportTakenRoomResolvedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat_SupportTakenRoom", x => x.ChatSupportTakenRoomID);
                    table.ForeignKey(
                        name: "FK_Chat_SupportTakenRoom_Chat_Room",
                        column: x => x.ChatSupportTakenRoomRoomID,
                        principalSchema: "dbo",
                        principalTable: "Chat_Room",
                        principalColumn: "ChatRoomID");
                    table.ForeignKey(
                        name: "FK_Chat_SupportTakenRoom_Chat_User",
                        column: x => x.ChatSupportTakenRoomChatUserID,
                        principalSchema: "dbo",
                        principalTable: "Chat_User",
                        principalColumn: "ChatUserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Widget",
                schema: "dbo",
                columns: table => new
                {
                    WidgetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WidgetCategoryID = table.Column<int>(type: "int", nullable: false),
                    WidgetLayoutID = table.Column<int>(type: "int", nullable: true),
                    WidgetWebPartID = table.Column<int>(type: "int", nullable: false),
                    WidgetDefaultValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidgetDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidgetDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WidgetDocumentation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidgetForDashboard = table.Column<bool>(type: "bit", nullable: false),
                    WidgetForEditor = table.Column<bool>(type: "bit", nullable: false),
                    WidgetForGroup = table.Column<bool>(type: "bit", nullable: false),
                    WidgetForInline = table.Column<bool>(type: "bit", nullable: false),
                    WidgetForUser = table.Column<bool>(type: "bit", nullable: false),
                    WidgetGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WidgetIconClass = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    WidgetIsEnabled = table.Column<bool>(type: "bit", nullable: false),
                    WidgetLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WidgetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WidgetProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WidgetSecurity = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((2))"),
                    WidgetSkipInsertProperties = table.Column<bool>(type: "bit", nullable: true),
                    WidgetThumbnailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Widget", x => x.WidgetID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Widget_WidgetCategoryID_CMS_WidgetCategory",
                        column: x => x.WidgetCategoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WidgetCategory",
                        principalColumn: "WidgetCategoryID");
                    table.ForeignKey(
                        name: "FK_CMS_Widget_WidgetLayoutID_CMS_WebPartLayout",
                        column: x => x.WidgetLayoutID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WebPartLayout",
                        principalColumn: "WebPartLayoutID");
                    table.ForeignKey(
                        name: "FK_CMS_Widget_WidgetWebPartID_CMS_WebPart",
                        column: x => x.WidgetWebPartID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WebPart",
                        principalColumn: "WebPartID");
                });

            migrationBuilder.CreateTable(
                name: "Reporting_ReportSubscription",
                schema: "dbo",
                columns: table => new
                {
                    ReportSubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportSubscriptionGraphID = table.Column<int>(type: "int", nullable: true),
                    ReportSubscriptionReportID = table.Column<int>(type: "int", nullable: false),
                    ReportSubscriptionSiteID = table.Column<int>(type: "int", nullable: false),
                    ReportSubscriptionTableID = table.Column<int>(type: "int", nullable: true),
                    ReportSubscriptionUserID = table.Column<int>(type: "int", nullable: false),
                    ReportSubscriptionValueID = table.Column<int>(type: "int", nullable: true),
                    ReportSubscriptionCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportSubscriptionEmail = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    ReportSubscriptionEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ReportSubscriptionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportSubscriptionInterval = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, defaultValueSql: "('')"),
                    ReportSubscriptionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('3/9/2012 11:17:19 AM')"),
                    ReportSubscriptionLastPostDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportSubscriptionNextPostDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportSubscriptionOnlyNonEmpty = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    ReportSubscriptionParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportSubscriptionSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportSubscriptionSubject = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporting_ReportSubscription", x => x.ReportSubscriptionID);
                    table.ForeignKey(
                        name: "FK_Reporting_ReportSubscription_ReportSubscriptionGraphID_Reporting_ReportGraph",
                        column: x => x.ReportSubscriptionGraphID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_ReportGraph",
                        principalColumn: "GraphID");
                    table.ForeignKey(
                        name: "FK_Reporting_ReportSubscription_ReportSubscriptionReportID_Reporting_Report",
                        column: x => x.ReportSubscriptionReportID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_Report",
                        principalColumn: "ReportID");
                    table.ForeignKey(
                        name: "FK_Reporting_ReportSubscription_ReportSubscriptionSiteID_CMS_Site",
                        column: x => x.ReportSubscriptionSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Reporting_ReportSubscription_ReportSubscriptionTableID_Reporting_ReportTable",
                        column: x => x.ReportSubscriptionTableID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_ReportTable",
                        principalColumn: "TableID");
                    table.ForeignKey(
                        name: "FK_Reporting_ReportSubscription_ReportSubscriptionUserID_CMS_User",
                        column: x => x.ReportSubscriptionUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Reporting_ReportSubscription_ReportSubscriptionValueID_Reporting_ReportValue",
                        column: x => x.ReportSubscriptionValueID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_ReportValue",
                        principalColumn: "ValueID");
                });

            migrationBuilder.CreateTable(
                name: "Reporting_SavedGraph",
                schema: "dbo",
                columns: table => new
                {
                    SavedGraphID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SavedGraphSavedReportID = table.Column<int>(type: "int", nullable: false),
                    SavedGraphBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    SavedGraphGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SavedGraphLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SavedGraphMimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reporting_SavedGraph", x => x.SavedGraphID);
                    table.ForeignKey(
                        name: "FK_Reporting_SavedGraph_SavedGraphSavedReportID_Reporting_SavedReport",
                        column: x => x.SavedGraphSavedReportID,
                        principalSchema: "dbo",
                        principalTable: "Reporting_SavedReport",
                        principalColumn: "SavedReportID");
                });

            migrationBuilder.CreateTable(
                name: "OM_AccountContact",
                schema: "dbo",
                columns: table => new
                {
                    AccountContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    ContactRoleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_AccountContact", x => x.AccountContactID);
                    table.ForeignKey(
                        name: "FK_OM_AccountContact_OM_Account",
                        column: x => x.AccountID,
                        principalSchema: "dbo",
                        principalTable: "OM_Account",
                        principalColumn: "AccountID");
                    table.ForeignKey(
                        name: "FK_OM_AccountContact_OM_Contact",
                        column: x => x.ContactID,
                        principalSchema: "dbo",
                        principalTable: "OM_Contact",
                        principalColumn: "ContactID");
                    table.ForeignKey(
                        name: "FK_OM_AccountContact_OM_ContactRole",
                        column: x => x.ContactRoleID,
                        principalSchema: "dbo",
                        principalTable: "OM_ContactRole",
                        principalColumn: "ContactRoleID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_AllowedChildClasses",
                schema: "dbo",
                columns: table => new
                {
                    ParentClassID = table.Column<int>(type: "int", nullable: false),
                    ChildClassID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_AllowedChildClasses", x => new { x.ParentClassID, x.ChildClassID });
                    table.ForeignKey(
                        name: "FK_CMS_AllowedChildClasses_ChildClassID_CMS_Class",
                        column: x => x.ChildClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_AllowedChildClasses_ParentClassID_CMS_Class",
                        column: x => x.ParentClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_AlternativeForm",
                schema: "dbo",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormClassID = table.Column<int>(type: "int", nullable: false),
                    FormCoupledClassID = table.Column<int>(type: "int", nullable: true),
                    FormCustomizedColumns = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    FormDefinition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    FormGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormHideNewParentFields = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    FormIsCustom = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    FormLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormLayout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormLayoutType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FormName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "('')"),
                    FormVersionGUID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_AlternativeForm", x => x.FormID);
                    table.ForeignKey(
                        name: "FK_CMS_AlternativeForm_FormClassID_CMS_Class",
                        column: x => x.FormClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_AlternativeForm_FormCoupledClassID_CMS_Class",
                        column: x => x.FormCoupledClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ClassSite",
                schema: "dbo",
                columns: table => new
                {
                    ClassID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ClassSite", x => new { x.ClassID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_CMS_Class_ClassID_CMS_Class",
                        column: x => x.ClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_Class_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_DocumentTypeScopeClass",
                schema: "dbo",
                columns: table => new
                {
                    ScopeID = table.Column<int>(type: "int", nullable: false),
                    ClassID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_DocumentTypeScopeClass", x => new { x.ScopeID, x.ClassID });
                    table.ForeignKey(
                        name: "FK_CMS_DocumentTypeScopeClass_ClassID_CMS_Class",
                        column: x => x.ClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_DocumentTypeScopeClass_ScopeID_CMS_DocumentTypeScope",
                        column: x => x.ScopeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_DocumentTypeScope",
                        principalColumn: "ScopeID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Form",
                schema: "dbo",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormClassID = table.Column<int>(type: "int", nullable: false),
                    FormSiteID = table.Column<int>(type: "int", nullable: false),
                    FormAccess = table.Column<int>(type: "int", nullable: true),
                    FormBuilderLayout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormClearAfterSave = table.Column<bool>(type: "bit", nullable: false),
                    FormConfirmationEmailField = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    FormConfirmationEmailSubject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true, defaultValueSql: "(N'')"),
                    FormConfirmationSendFromEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    FormConfirmationTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormDevelopmentModel = table.Column<int>(type: "int", nullable: false),
                    FormDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    FormDisplayText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormEmailAttachUploadedDocs = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    FormEmailSubject = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    FormEmailTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormItems = table.Column<int>(type: "int", nullable: false),
                    FormLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/17/2012 1:37:08 PM')"),
                    FormLogActivity = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FormName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "('')"),
                    FormRedirectToUrl = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    FormReportFields = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormSendFromEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    FormSendToEmail = table.Column<string>(type: "nvarchar(998)", maxLength: 998, nullable: true),
                    FormSubmitButtonImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FormSubmitButtonText = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Form", x => x.FormID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Form_FormClassID_CMS_Class",
                        column: x => x.FormClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_Form_FormSiteID_CMS_Site",
                        column: x => x.FormSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_PageTemplateScope",
                schema: "dbo",
                columns: table => new
                {
                    PageTemplateScopeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageTemplateScopeClassID = table.Column<int>(type: "int", nullable: true),
                    PageTemplateScopeCultureID = table.Column<int>(type: "int", nullable: true),
                    PageTemplateScopeSiteID = table.Column<int>(type: "int", nullable: true),
                    PageTemplateScopeTemplateID = table.Column<int>(type: "int", nullable: false),
                    PageTemplateScopeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PageTemplateScopeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('2/22/2010 9:30:07 AM')"),
                    PageTemplateScopeLevels = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PageTemplateScopePath = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_PageTemplateScope", x => x.PageTemplateScopeID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplateScope_PageTemplateScopeClassID_CMS_Class",
                        column: x => x.PageTemplateScopeClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplateScope_PageTemplateScopeCultureID_CMS_Culture",
                        column: x => x.PageTemplateScopeCultureID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Culture",
                        principalColumn: "CultureID");
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplateScope_PageTemplateScopeSiteID_CMS_Site",
                        column: x => x.PageTemplateScopeSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_PageTemplateScope_PageTemplateScopeTemplateID_CMS_PageTemplate",
                        column: x => x.PageTemplateScopeTemplateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplate",
                        principalColumn: "PageTemplateID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Permission",
                schema: "dbo",
                columns: table => new
                {
                    PermissionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: true),
                    ResourceID = table.Column<int>(type: "int", nullable: true),
                    PermissionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermissionDisplayInMatrix = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PermissionDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PermissionEditableByGlobalAdmin = table.Column<bool>(type: "bit", nullable: true),
                    PermissionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PermissionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PermissionOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Permission", x => x.PermissionID);
                    table.ForeignKey(
                        name: "FK_CMS_Permission_ClassID_CMS_Class",
                        column: x => x.ClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_Permission_ResourceID_CMS_Resource",
                        column: x => x.ResourceID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Resource",
                        principalColumn: "ResourceID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Query",
                schema: "dbo",
                columns: table => new
                {
                    QueryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassID = table.Column<int>(type: "int", nullable: true),
                    QueryConnectionString = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    QueryGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QueryIsCustom = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    QueryIsLocked = table.Column<bool>(type: "bit", nullable: false),
                    QueryLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QueryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    QueryRequiresTransaction = table.Column<bool>(type: "bit", nullable: false),
                    QueryText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QueryTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Query", x => x.QueryID);
                    table.ForeignKey(
                        name: "FK_CMS_Query_ClassID_CMS_Class",
                        column: x => x.ClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Transformation",
                schema: "dbo",
                columns: table => new
                {
                    TransformationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransformationClassID = table.Column<int>(type: "int", nullable: false),
                    TransformationCode = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')"),
                    TransformationCSS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransformationGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransformationHierarchicalXML = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransformationIsHierarchical = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    TransformationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransformationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    TransformationPreferredDocument = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: true),
                    TransformationType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValueSql: "(N'')"),
                    TransformationVersionGUID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Transformation", x => x.TransformationID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Transformation_TransformationClassID_CMS_Class",
                        column: x => x.TransformationClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_VersionHistory",
                schema: "dbo",
                columns: table => new
                {
                    VersionHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModifiedByUserID = table.Column<int>(type: "int", nullable: true),
                    NodeSiteID = table.Column<int>(type: "int", nullable: false),
                    VersionClassID = table.Column<int>(type: "int", nullable: true),
                    VersionDeletedByUserID = table.Column<int>(type: "int", nullable: true),
                    VersionWorkflowID = table.Column<int>(type: "int", nullable: true),
                    VersionWorkflowStepID = table.Column<int>(type: "int", nullable: true),
                    DocumentID = table.Column<int>(type: "int", nullable: true),
                    DocumentNamePath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "(N'')"),
                    ModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NodeXML = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PublishTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ToBePublished = table.Column<bool>(type: "bit", nullable: false),
                    VersionComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VersionDeletedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VersionDocumentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    VersionDocumentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    VersionMenuRedirectUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    VersionNodeAliasPath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    VersionNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    WasPublishedFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WasPublishedTo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_VersionHistory", x => x.VersionHistoryID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_VersionHistory_DeletedByUserID_CMS_User",
                        column: x => x.VersionDeletedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_VersionHistory_ModifiedByUserID_CMS_User",
                        column: x => x.ModifiedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_VersionHistory_NodeSiteID_CMS_Site",
                        column: x => x.NodeSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_VersionHistory_VersionClassID_CMS_Class",
                        column: x => x.VersionClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_VersionHistory_VersionWorkflowID_CMS_Workflow",
                        column: x => x.VersionWorkflowID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Workflow",
                        principalColumn: "WorkflowID");
                    table.ForeignKey(
                        name: "FK_CMS_VersionHistory_VersionWorkflowStepID_CMS_WorkflowStep",
                        column: x => x.VersionWorkflowStepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WorkflowScope",
                schema: "dbo",
                columns: table => new
                {
                    ScopeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScopeClassID = table.Column<int>(type: "int", nullable: true),
                    ScopeCultureID = table.Column<int>(type: "int", nullable: true),
                    ScopeSiteID = table.Column<int>(type: "int", nullable: false),
                    ScopeWorkflowID = table.Column<int>(type: "int", nullable: false),
                    ScopeExcludeChildren = table.Column<bool>(type: "bit", nullable: true),
                    ScopeExcluded = table.Column<bool>(type: "bit", nullable: false),
                    ScopeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScopeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScopeMacroCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScopeStartingPath = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WorkflowScope", x => x.ScopeID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowScope_ScopeClassID_CMS_Class",
                        column: x => x.ScopeClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowScope_ScopeCultureID_CMS_Culture",
                        column: x => x.ScopeCultureID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Culture",
                        principalColumn: "CultureID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowScope_ScopeSiteID_CMS_Site",
                        column: x => x.ScopeSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowScope_ScopeWorkflowID_CMS_WorkflowID",
                        column: x => x.ScopeWorkflowID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Workflow",
                        principalColumn: "WorkflowID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_HelpTopic",
                schema: "dbo",
                columns: table => new
                {
                    HelpTopicID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HelpTopicUIElementID = table.Column<int>(type: "int", nullable: false),
                    HelpTopicGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HelpTopicLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HelpTopicLink = table.Column<string>(type: "nvarchar(1023)", maxLength: 1023, nullable: false, defaultValueSql: "(N'')"),
                    HelpTopicName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    HelpTopicOrder = table.Column<int>(type: "int", nullable: true),
                    HelpTopicVisibilityCondition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_HelpTopic", x => x.HelpTopicID);
                    table.ForeignKey(
                        name: "FK_CMS_HelpTopic_HelpTopicUIElementID_CMS_UIElement",
                        column: x => x.HelpTopicUIElementID,
                        principalSchema: "dbo",
                        principalTable: "CMS_UIElement",
                        principalColumn: "ElementID");
                });

            migrationBuilder.CreateTable(
                name: "OM_MVTCombinationVariation",
                schema: "dbo",
                columns: table => new
                {
                    MVTCombinationID = table.Column<int>(type: "int", nullable: false),
                    MVTVariantID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_MVTCombinationVariation", x => new { x.MVTCombinationID, x.MVTVariantID });
                    table.ForeignKey(
                        name: "FK_OM_MVTCombinationVariation_OM_MVTCombination",
                        column: x => x.MVTCombinationID,
                        principalSchema: "dbo",
                        principalTable: "OM_MVTCombination",
                        principalColumn: "MVTCombinationID");
                    table.ForeignKey(
                        name: "FK_OM_MVTCombinationVariation_OM_MVTVariant",
                        column: x => x.MVTVariantID,
                        principalSchema: "dbo",
                        principalTable: "OM_MVTVariant",
                        principalColumn: "MVTVariantID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_CampaignAsset",
                schema: "dbo",
                columns: table => new
                {
                    CampaignAssetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignAssetCampaignID = table.Column<int>(type: "int", nullable: false),
                    CampaignAssetAssetGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampaignAssetGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampaignAssetLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    CampaignAssetType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_CampaignAsset", x => x.CampaignAssetID);
                    table.ForeignKey(
                        name: "FK_Analytics_CampaignAsset_CampaignAssetCampaignID_Analytics_Campaign",
                        column: x => x.CampaignAssetCampaignID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Campaign",
                        principalColumn: "CampaignID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_CampaignConversion",
                schema: "dbo",
                columns: table => new
                {
                    CampaignConversionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignConversionCampaignID = table.Column<int>(type: "int", nullable: false),
                    CampaignConversionActivityType = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "(N'')"),
                    CampaignConversionDisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    CampaignConversionGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampaignConversionHits = table.Column<int>(type: "int", nullable: false),
                    CampaignConversionIsFunnelStep = table.Column<bool>(type: "bit", nullable: false),
                    CampaignConversionItemID = table.Column<int>(type: "int", nullable: true),
                    CampaignConversionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    CampaignConversionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, defaultValueSql: "(N'')"),
                    CampaignConversionOrder = table.Column<int>(type: "int", nullable: false),
                    CampaignConversionURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CampaignConversionValue = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_CampaignConversion", x => x.CampaignConversionID);
                    table.ForeignKey(
                        name: "FK_Analytics_CampaignConversion_CampaignConversionCampaignID_Analytics_Campaign",
                        column: x => x.CampaignConversionCampaignID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Campaign",
                        principalColumn: "CampaignID");
                });

            migrationBuilder.CreateTable(
                name: "SM_LinkedInPost",
                schema: "dbo",
                columns: table => new
                {
                    LinkedInPostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkedInPostCampaignID = table.Column<int>(type: "int", nullable: true),
                    LinkedInPostLinkedInAccountID = table.Column<int>(type: "int", nullable: false),
                    LinkedInPostSiteID = table.Column<int>(type: "int", nullable: false),
                    LinkedInPostClickCount = table.Column<int>(type: "int", nullable: true),
                    LinkedInPostComment = table.Column<string>(type: "nvarchar(700)", maxLength: 700, nullable: false, defaultValueSql: "(N'')"),
                    LinkedInPostCommentCount = table.Column<int>(type: "int", nullable: true),
                    LinkedInPostDocumentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LinkedInPostEngagement = table.Column<double>(type: "float", nullable: true),
                    LinkedInPostErrorCode = table.Column<int>(type: "int", nullable: true),
                    LinkedInPostErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedInPostGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LinkedInPostHTTPStatusCode = table.Column<int>(type: "int", nullable: true),
                    LinkedInPostImpressionCount = table.Column<int>(type: "int", nullable: true),
                    LinkedInPostInsightsLastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LinkedInPostIsCreatedByUser = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    LinkedInPostLastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LinkedInPostLikeCount = table.Column<int>(type: "int", nullable: true),
                    LinkedInPostPostAfterDocumentPublish = table.Column<bool>(type: "bit", nullable: true),
                    LinkedInPostPublishedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LinkedInPostScheduledPublishDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LinkedInPostShareCount = table.Column<int>(type: "int", nullable: true),
                    LinkedInPostUpdateKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LinkedInPostURLShortenerType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_LinkedInPost", x => x.LinkedInPostID);
                    table.ForeignKey(
                        name: "FK_SM_LinkedInPost_Analytics_Campaign_LinkedInPostCampaignID",
                        column: x => x.LinkedInPostCampaignID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Campaign",
                        principalColumn: "CampaignID");
                    table.ForeignKey(
                        name: "FK_SM_LinkedInPost_CMS_Site",
                        column: x => x.LinkedInPostSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_SM_LinkedInPost_SM_LinkedInAccount",
                        column: x => x.LinkedInPostLinkedInAccountID,
                        principalSchema: "dbo",
                        principalTable: "SM_LinkedInAccount",
                        principalColumn: "LinkedInAccountID");
                });

            migrationBuilder.CreateTable(
                name: "COM_SKU",
                schema: "dbo",
                columns: table => new
                {
                    SKUID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SKUBrandID = table.Column<int>(type: "int", nullable: true),
                    SKUCollectionID = table.Column<int>(type: "int", nullable: true),
                    SKUDepartmentID = table.Column<int>(type: "int", nullable: true),
                    SKUInternalStatusID = table.Column<int>(type: "int", nullable: true),
                    SKUManufacturerID = table.Column<int>(type: "int", nullable: true),
                    SKUOptionCategoryID = table.Column<int>(type: "int", nullable: true),
                    SKUParentSKUID = table.Column<int>(type: "int", nullable: true),
                    SKUPublicStatusID = table.Column<int>(type: "int", nullable: true),
                    SKUSiteID = table.Column<int>(type: "int", nullable: true),
                    SKUSupplierID = table.Column<int>(type: "int", nullable: true),
                    SKUTaxClassID = table.Column<int>(type: "int", nullable: true),
                    SKUAvailableInDays = table.Column<int>(type: "int", nullable: true),
                    SKUAvailableItems = table.Column<int>(type: "int", nullable: true),
                    SKUBundleInventoryType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "('REMOVEBUNDLE')"),
                    SKUBundleItemsCount = table.Column<int>(type: "int", nullable: true),
                    SKUConversionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SKUConversionValue = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true, defaultValueSql: "('0')"),
                    SKUCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SKUCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKUDepth = table.Column<double>(type: "float", nullable: true),
                    SKUDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKUEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    SKUEproductFilesCount = table.Column<int>(type: "int", nullable: true),
                    SKUGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SKUHeight = table.Column<double>(type: "float", nullable: true),
                    SKUImagePath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    SKUInStoreFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SKULastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SKUMaxItemsInOrder = table.Column<int>(type: "int", nullable: true),
                    SKUMembershipGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SKUMinItemsInOrder = table.Column<int>(type: "int", nullable: true),
                    SKUName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: false, defaultValueSql: "('')"),
                    SKUNeedsShipping = table.Column<bool>(type: "bit", nullable: true),
                    SKUNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SKUOrder = table.Column<int>(type: "int", nullable: true),
                    SKUPrice = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
                    SKUProductType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SKUReorderAt = table.Column<int>(type: "int", nullable: true),
                    SKURetailPrice = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    SKUSellOnlyAvailable = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    SKUShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SKUTrackInventory = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(N'ByProduct')"),
                    SKUValidFor = table.Column<int>(type: "int", nullable: true),
                    SKUValidUntil = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SKUValidity = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SKUWeight = table.Column<double>(type: "float", nullable: true),
                    SKUWidth = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_SKU", x => x.SKUID);
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUBrandID_COM_Brand",
                        column: x => x.SKUBrandID,
                        principalSchema: "dbo",
                        principalTable: "COM_Brand",
                        principalColumn: "BrandID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUCollectionID_COM_Collection",
                        column: x => x.SKUCollectionID,
                        principalSchema: "dbo",
                        principalTable: "COM_Collection",
                        principalColumn: "CollectionID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUDepartmentID_COM_Department",
                        column: x => x.SKUDepartmentID,
                        principalSchema: "dbo",
                        principalTable: "COM_Department",
                        principalColumn: "DepartmentID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUInternalStatusID_COM_InternalStatus",
                        column: x => x.SKUInternalStatusID,
                        principalSchema: "dbo",
                        principalTable: "COM_InternalStatus",
                        principalColumn: "InternalStatusID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUManufacturerID_COM_Manifacturer",
                        column: x => x.SKUManufacturerID,
                        principalSchema: "dbo",
                        principalTable: "COM_Manufacturer",
                        principalColumn: "ManufacturerID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUOptionCategoryID_COM_OptionCategory",
                        column: x => x.SKUOptionCategoryID,
                        principalSchema: "dbo",
                        principalTable: "COM_OptionCategory",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUParentSKUID_COM_SKU",
                        column: x => x.SKUParentSKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUPublicStatusID_COM_PublicStatus",
                        column: x => x.SKUPublicStatusID,
                        principalSchema: "dbo",
                        principalTable: "COM_PublicStatus",
                        principalColumn: "PublicStatusID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUSiteID_CMS_Site",
                        column: x => x.SKUSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUSupplierID_COM_Supplier",
                        column: x => x.SKUSupplierID,
                        principalSchema: "dbo",
                        principalTable: "COM_Supplier",
                        principalColumn: "SupplierID");
                    table.ForeignKey(
                        name: "FK_COM_SKU_SKUTaxClass_COM_TaxClass",
                        column: x => x.SKUTaxClassID,
                        principalSchema: "dbo",
                        principalTable: "COM_TaxClass",
                        principalColumn: "TaxClassID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Order",
                schema: "dbo",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderCreatedByUserID = table.Column<int>(type: "int", nullable: true),
                    OrderCurrencyID = table.Column<int>(type: "int", nullable: true),
                    OrderCustomerID = table.Column<int>(type: "int", nullable: false),
                    OrderPaymentOptionID = table.Column<int>(type: "int", nullable: true),
                    OrderShippingOptionID = table.Column<int>(type: "int", nullable: true),
                    OrderSiteID = table.Column<int>(type: "int", nullable: false),
                    OrderStatusID = table.Column<int>(type: "int", nullable: true),
                    OrderCouponCodes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderCulture = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    OrderCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderDiscounts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderGrandTotal = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
                    OrderGrandTotalInMainCurrency = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    OrderGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderInvoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderInvoiceNumber = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    OrderIsPaid = table.Column<bool>(type: "bit", nullable: true),
                    OrderLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderOtherPayments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderPaymentResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTaxSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderTotalPrice = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
                    OrderTotalPriceInMainCurrency = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    OrderTotalShipping = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    OrderTotalTax = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
                    OrderTrackingNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_COM_Order_OrderCreatedByUserID_CMS_User",
                        column: x => x.OrderCreatedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_COM_Order_OrderCurrencyID_COM_Currency",
                        column: x => x.OrderCurrencyID,
                        principalSchema: "dbo",
                        principalTable: "COM_Currency",
                        principalColumn: "CurrencyID");
                    table.ForeignKey(
                        name: "FK_COM_Order_OrderCustomerID_COM_Customer",
                        column: x => x.OrderCustomerID,
                        principalSchema: "dbo",
                        principalTable: "COM_Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_COM_Order_OrderPaymentOptionID_COM_PaymentOption",
                        column: x => x.OrderPaymentOptionID,
                        principalSchema: "dbo",
                        principalTable: "COM_PaymentOption",
                        principalColumn: "PaymentOptionID");
                    table.ForeignKey(
                        name: "FK_COM_Order_OrderShippingOptionID_COM_ShippingOption",
                        column: x => x.OrderShippingOptionID,
                        principalSchema: "dbo",
                        principalTable: "COM_ShippingOption",
                        principalColumn: "ShippingOptionID");
                    table.ForeignKey(
                        name: "FK_COM_Order_OrderSiteID_CMS_Site",
                        column: x => x.OrderSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_COM_Order_OrderStatusID_COM_Status",
                        column: x => x.OrderStatusID,
                        principalSchema: "dbo",
                        principalTable: "COM_OrderStatus",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "COM_ShippingCost",
                schema: "dbo",
                columns: table => new
                {
                    ShippingCostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingCostShippingOptionID = table.Column<int>(type: "int", nullable: false),
                    ShippingCostGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShippingCostLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingCostMinWeight = table.Column<double>(type: "float", nullable: false),
                    ShippingCostValue = table.Column<decimal>(type: "decimal(18,9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__COM_ShippingCost", x => x.ShippingCostID);
                    table.ForeignKey(
                        name: "FK_COM_ShippingCost_ShippingCostShippingOptionID_COM_ShippingOption",
                        column: x => x.ShippingCostShippingOptionID,
                        principalSchema: "dbo",
                        principalTable: "COM_ShippingOption",
                        principalColumn: "ShippingOptionID");
                });

            migrationBuilder.CreateTable(
                name: "COM_ShoppingCart",
                schema: "dbo",
                columns: table => new
                {
                    ShoppingCartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartBillingAddressID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartCompanyAddressID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartCurrencyID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartCustomerID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartPaymentOptionID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartShippingAddressID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartShippingOptionID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartSiteID = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartUserID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartContactID = table.Column<int>(type: "int", nullable: true),
                    ShoppingCartCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShoppingCartGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShoppingCartLastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShoppingCartNote = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_ShoppingCart", x => x.ShoppingCartID);
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCart_ShoppingCartBillingAddressID_COM_Address",
                        column: x => x.ShoppingCartBillingAddressID,
                        principalSchema: "dbo",
                        principalTable: "COM_Address",
                        principalColumn: "AddressID");
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCart_ShoppingCartCompanyAddressID_COM_Address",
                        column: x => x.ShoppingCartCompanyAddressID,
                        principalSchema: "dbo",
                        principalTable: "COM_Address",
                        principalColumn: "AddressID");
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCart_ShoppingCartCurrencyID_COM_Currency",
                        column: x => x.ShoppingCartCurrencyID,
                        principalSchema: "dbo",
                        principalTable: "COM_Currency",
                        principalColumn: "CurrencyID");
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCart_ShoppingCartCustomerID_COM_Customer",
                        column: x => x.ShoppingCartCustomerID,
                        principalSchema: "dbo",
                        principalTable: "COM_Customer",
                        principalColumn: "CustomerID");
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCart_ShoppingCartPaymentOptionID_COM_PaymentOption",
                        column: x => x.ShoppingCartPaymentOptionID,
                        principalSchema: "dbo",
                        principalTable: "COM_PaymentOption",
                        principalColumn: "PaymentOptionID");
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCart_ShoppingCartShippingAddressID_COM_Address",
                        column: x => x.ShoppingCartShippingAddressID,
                        principalSchema: "dbo",
                        principalTable: "COM_Address",
                        principalColumn: "AddressID");
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCart_ShoppingCartShippingOptionID_COM_ShippingOption",
                        column: x => x.ShoppingCartShippingOptionID,
                        principalSchema: "dbo",
                        principalTable: "COM_ShippingOption",
                        principalColumn: "ShippingOptionID");
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCart_ShoppingCartSiteID_CMS_Site",
                        column: x => x.ShoppingCartSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCart_ShoppingCartUserID_CMS_User",
                        column: x => x.ShoppingCartUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_ACLItem",
                schema: "dbo",
                columns: table => new
                {
                    ACLItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACLID = table.Column<int>(type: "int", nullable: false),
                    LastModifiedByUserID = table.Column<int>(type: "int", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    ACLItemGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Allowed = table.Column<int>(type: "int", nullable: false),
                    Denied = table.Column<int>(type: "int", nullable: false),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_ACLItem", x => x.ACLItemID);
                    table.ForeignKey(
                        name: "FK_CMS_ACLItem_ACLID_CMS_ACL",
                        column: x => x.ACLID,
                        principalSchema: "dbo",
                        principalTable: "CMS_ACL",
                        principalColumn: "ACLID");
                    table.ForeignKey(
                        name: "FK_CMS_ACLItem_LastModifiedByUserID_CMS_User",
                        column: x => x.LastModifiedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_ACLItem_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK_CMS_ACLItem_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_MembershipRole",
                schema: "dbo",
                columns: table => new
                {
                    MembershipID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_MembershipRole", x => new { x.MembershipID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_CMS_MembershipRole_MembershipID_CMS_Membership",
                        column: x => x.MembershipID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Membership",
                        principalColumn: "MembershipID");
                    table.ForeignKey(
                        name: "FK_CMS_MembershipRole_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_RoleApplication",
                schema: "dbo",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    ElementID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_RoleApplication", x => new { x.RoleID, x.ElementID });
                    table.ForeignKey(
                        name: "FK_CMS_RoleApplication_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK_CMS_RoleApplication_CMS_UIElement",
                        column: x => x.ElementID,
                        principalSchema: "dbo",
                        principalTable: "CMS_UIElement",
                        principalColumn: "ElementID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_RoleUIElement",
                schema: "dbo",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    ElementID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_RoleUIElement", x => new { x.RoleID, x.ElementID });
                    table.ForeignKey(
                        name: "FK_CMS_RoleUIElement_ElementID_CMS_UIElement",
                        column: x => x.ElementID,
                        principalSchema: "dbo",
                        principalTable: "CMS_UIElement",
                        principalColumn: "ElementID");
                    table.ForeignKey(
                        name: "FK_CMS_RoleUIElement_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_UserRole",
                schema: "dbo",
                columns: table => new
                {
                    UserRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_UserRole", x => x.UserRoleID);
                    table.ForeignKey(
                        name: "FK_CMS_UserRole_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK_CMS_UserRole_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WorkflowStepRoles",
                schema: "dbo",
                columns: table => new
                {
                    WorkflowStepRoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    StepID = table.Column<int>(type: "int", nullable: false),
                    StepSourcePointGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WorkflowStepRoles", x => x.WorkflowStepRoleID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowStepRoles_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowStepRoles_StepID_CMS_WorkflowStep",
                        column: x => x.StepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                });

            migrationBuilder.CreateTable(
                name: "Media_File",
                schema: "dbo",
                columns: table => new
                {
                    FileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileCreatedByUserID = table.Column<int>(type: "int", nullable: true),
                    FileLibraryID = table.Column<int>(type: "int", nullable: false),
                    FileModifiedByUserID = table.Column<int>(type: "int", nullable: true),
                    FileSiteID = table.Column<int>(type: "int", nullable: false),
                    FileCreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('11/11/2008 4:10:00 PM')"),
                    FileCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FileGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileImageHeight = table.Column<int>(type: "int", nullable: true),
                    FileImageWidth = table.Column<int>(type: "int", nullable: true),
                    FileMimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FileModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('11/11/2008 4:11:15 PM')"),
                    FileName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false),
                    FileTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media_File", x => x.FileID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Media_File_FileCreatedByUserID_CMS_User",
                        column: x => x.FileCreatedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Media_File_FileLibraryID_Media_Library",
                        column: x => x.FileLibraryID,
                        principalSchema: "dbo",
                        principalTable: "Media_Library",
                        principalColumn: "LibraryID");
                    table.ForeignKey(
                        name: "FK_Media_File_FileModifiedByUserID_CMS_User",
                        column: x => x.FileModifiedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Media_File_FileSiteID_CMS_Site",
                        column: x => x.FileSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Polls_PollAnswer",
                schema: "dbo",
                columns: table => new
                {
                    AnswerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerPollID = table.Column<int>(type: "int", nullable: false),
                    AnswerAlternativeForm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AnswerCount = table.Column<int>(type: "int", nullable: true),
                    AnswerEnabled = table.Column<bool>(type: "bit", nullable: true),
                    AnswerForm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AnswerGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnswerHideForm = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    AnswerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnswerOrder = table.Column<int>(type: "int", nullable: true),
                    AnswerText = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls_PollAnswer", x => x.AnswerID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Polls_PollAnswer_AnswerPollID_Polls_Poll",
                        column: x => x.AnswerPollID,
                        principalSchema: "dbo",
                        principalTable: "Polls_Poll",
                        principalColumn: "PollID");
                });

            migrationBuilder.CreateTable(
                name: "Polls_PollRoles",
                schema: "dbo",
                columns: table => new
                {
                    PollID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls_PollRoles", x => new { x.PollID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_Polls_PollRoles_PollID_Polls_Poll",
                        column: x => x.PollID,
                        principalSchema: "dbo",
                        principalTable: "Polls_Poll",
                        principalColumn: "PollID");
                    table.ForeignKey(
                        name: "FK_Polls_PollRoles_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "Polls_PollSite",
                schema: "dbo",
                columns: table => new
                {
                    PollID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polls_PollSite", x => new { x.PollID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_Polls_PollSite_PollID_Polls_Poll",
                        column: x => x.PollID,
                        principalSchema: "dbo",
                        principalTable: "Polls_Poll",
                        principalColumn: "PollID");
                    table.ForeignKey(
                        name: "FK_Polls_PollSite_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Integration_SyncLog",
                schema: "dbo",
                columns: table => new
                {
                    SyncLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SyncLogSynchronizationID = table.Column<int>(type: "int", nullable: false),
                    SyncLogErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SyncLogTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Integration_SyncLog", x => x.SyncLogID);
                    table.ForeignKey(
                        name: "FK_Integration_SyncLog_SyncLogSynchronizationID_Integration_Synchronization",
                        column: x => x.SyncLogSynchronizationID,
                        principalSchema: "dbo",
                        principalTable: "Integration_Synchronization",
                        principalColumn: "SynchronizationID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_EmailTemplateNewsletter",
                schema: "dbo",
                columns: table => new
                {
                    TemplateID = table.Column<int>(type: "int", nullable: false),
                    NewsletterID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_EmailTemplateNewsletter", x => new { x.TemplateID, x.NewsletterID });
                    table.ForeignKey(
                        name: "FK_Newsletter_EmailTemplateNewsletter_Newsletter_EmailTemplate",
                        column: x => x.TemplateID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_EmailTemplate",
                        principalColumn: "TemplateID");
                    table.ForeignKey(
                        name: "FK_Newsletter_EmailTemplateNewsletter_Newsletter_Newsletter",
                        column: x => x.NewsletterID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_Newsletter",
                        principalColumn: "NewsletterID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_NewsletterIssue",
                schema: "dbo",
                columns: table => new
                {
                    IssueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueNewsletterID = table.Column<int>(type: "int", nullable: false),
                    IssueSiteID = table.Column<int>(type: "int", nullable: false),
                    IssueTemplateID = table.Column<int>(type: "int", nullable: true),
                    IssueVariantOfIssueID = table.Column<int>(type: "int", nullable: true),
                    IssueBounces = table.Column<int>(type: "int", nullable: true),
                    IssueDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    IssueGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueIsABTest = table.Column<bool>(type: "bit", nullable: true),
                    IssueLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IssueMailoutTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueOpenedEmails = table.Column<int>(type: "int", nullable: true),
                    IssuePlainText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssuePreheader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueScheduledTaskID = table.Column<int>(type: "int", nullable: true),
                    IssueSenderEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    IssueSenderName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IssueSentEmails = table.Column<int>(type: "int", nullable: false),
                    IssueStatus = table.Column<int>(type: "int", nullable: true),
                    IssueSubject = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "('')"),
                    IssueText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssueUnsubscribed = table.Column<int>(type: "int", nullable: false),
                    IssueUseUTM = table.Column<bool>(type: "bit", nullable: false),
                    IssueUTMCampaign = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IssueUTMSource = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IssueVariantName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IssueWidgets = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_NewsletterIssue", x => x.IssueID);
                    table.ForeignKey(
                        name: "FK_Newsletter_NewsletterIssue_IssueNewsletterID_Newsletter_Newsletter",
                        column: x => x.IssueNewsletterID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_Newsletter",
                        principalColumn: "NewsletterID");
                    table.ForeignKey(
                        name: "FK_Newsletter_NewsletterIssue_IssueSiteID_CMS_Site",
                        column: x => x.IssueSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Newsletter_NewsletterIssue_IssueTemplateID_Newsletter_EmailTemplate",
                        column: x => x.IssueTemplateID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_EmailTemplate",
                        principalColumn: "TemplateID");
                    table.ForeignKey(
                        name: "FK_Newsletter_NewsletterIssue_IssueVariantOfIssue_NewsletterIssue",
                        column: x => x.IssueVariantOfIssueID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_NewsletterIssue",
                        principalColumn: "IssueID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_SubscriberNewsletter",
                schema: "dbo",
                columns: table => new
                {
                    SubscriberNewsletterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsletterID = table.Column<int>(type: "int", nullable: false),
                    SubscriberID = table.Column<int>(type: "int", nullable: false),
                    SubscribedWhen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubscriptionApprovalHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubscriptionApproved = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    SubscriptionApprovedWhen = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_SubscriberNewsletter", x => x.SubscriberNewsletterID);
                    table.ForeignKey(
                        name: "FK_Newsletter_SubscriberNewsletter_NewsletterID_Newsletter_Newsletter",
                        column: x => x.NewsletterID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_Newsletter",
                        principalColumn: "NewsletterID");
                    table.ForeignKey(
                        name: "FK_Newsletter_SubscriberNewsletter_SubscriberID_Newsletter_Subscriber",
                        column: x => x.SubscriberID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_Subscriber",
                        principalColumn: "SubscriberID");
                });

            migrationBuilder.CreateTable(
                name: "SharePoint_SharePointFile",
                schema: "dbo",
                columns: table => new
                {
                    SharePointFileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharePointFileSharePointLibraryID = table.Column<int>(type: "int", nullable: false),
                    SharePointFileSiteID = table.Column<int>(type: "int", nullable: false),
                    SharePointFileBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    SharePointFileETag = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(N'')"),
                    SharePointFileExtension = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true, defaultValueSql: "(N'')"),
                    SharePointFileGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SharePointFileMimeType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "(N'')"),
                    SharePointFileName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false, defaultValueSql: "(N'')"),
                    SharePointFileServerLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SharePointFileServerRelativeURL = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false, defaultValueSql: "(N'')"),
                    SharePointFileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharePoint_SharePointFile", x => x.SharePointFileID);
                    table.ForeignKey(
                        name: "FK_SharePoint_SharePointFile_CMS_Site",
                        column: x => x.SharePointFileSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_SharePoint_SharePointFile_SharePoint_SharePointLibrary",
                        column: x => x.SharePointFileSharePointLibraryID,
                        principalSchema: "dbo",
                        principalTable: "SharePoint_SharePointLibrary",
                        principalColumn: "SharePointLibraryID");
                });

            migrationBuilder.CreateTable(
                name: "SM_FacebookPost",
                schema: "dbo",
                columns: table => new
                {
                    FacebookPostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacebookPostCampaignID = table.Column<int>(type: "int", nullable: true),
                    FacebookPostFacebookAccountID = table.Column<int>(type: "int", nullable: false),
                    FacebookPostSiteID = table.Column<int>(type: "int", nullable: false),
                    FacebookPostDocumentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FacebookPostErrorCode = table.Column<int>(type: "int", nullable: true),
                    FacebookPostErrorSubcode = table.Column<int>(type: "int", nullable: true),
                    FacebookPostExternalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookPostGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FacebookPostInsightCommentsFromPage = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightCommentsTotal = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightLikesFromPage = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightLikesTotal = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightNegativeHideAllPosts = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightNegativeHidePost = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightNegativeReportSpam = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightNegativeUnlikePage = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightPeopleReached = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightSharesFromPage = table.Column<int>(type: "int", nullable: true),
                    FacebookPostInsightsLastUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FacebookPostIsCreatedByUser = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    FacebookPostLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FacebookPostPostAfterDocumentPublish = table.Column<bool>(type: "bit", nullable: true),
                    FacebookPostPublishedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FacebookPostScheduledPublishDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FacebookPostText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacebookPostURLShortenerType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_FacebookPost", x => x.FacebookPostID);
                    table.ForeignKey(
                        name: "FK_SM_FacebookPost_Analytics_Campaign_FacebookPostCampaignID",
                        column: x => x.FacebookPostCampaignID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Campaign",
                        principalColumn: "CampaignID");
                    table.ForeignKey(
                        name: "FK_SM_FacebookPost_CMS_Site",
                        column: x => x.FacebookPostSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_SM_FacebookPost_SM_FacebookAccount",
                        column: x => x.FacebookPostFacebookAccountID,
                        principalSchema: "dbo",
                        principalTable: "SM_FacebookAccount",
                        principalColumn: "FacebookAccountID");
                });

            migrationBuilder.CreateTable(
                name: "SM_TwitterPost",
                schema: "dbo",
                columns: table => new
                {
                    TwitterPostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TwitterPostCampaignID = table.Column<int>(type: "int", nullable: true),
                    TwitterPostSiteID = table.Column<int>(type: "int", nullable: false),
                    TwitterPostTwitterAccountID = table.Column<int>(type: "int", nullable: false),
                    TwitterPostDocumentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TwitterPostErrorCode = table.Column<int>(type: "int", nullable: true),
                    TwitterPostExternalID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterPostFavorites = table.Column<int>(type: "int", nullable: true),
                    TwitterPostGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TwitterPostInsightsUpdateDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TwitterPostIsCreatedByUser = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    TwitterPostLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TwitterPostPostAfterDocumentPublish = table.Column<bool>(type: "bit", nullable: true),
                    TwitterPostPublishedDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TwitterPostRetweets = table.Column<int>(type: "int", nullable: true),
                    TwitterPostScheduledPublishDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TwitterPostText = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')"),
                    TwitterPostURLShortenerType = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SM_TwitterPost", x => x.TwitterPostID);
                    table.ForeignKey(
                        name: "FK_SM_TwitterPost_Analytics_Campaign_TwitterPostCampaignID",
                        column: x => x.TwitterPostCampaignID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Campaign",
                        principalColumn: "CampaignID");
                    table.ForeignKey(
                        name: "FK_SM_TwitterPost_CMS_Site",
                        column: x => x.TwitterPostSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_SM_TwitterPost_SM_TwitterAccount",
                        column: x => x.TwitterPostTwitterAccountID,
                        principalSchema: "dbo",
                        principalTable: "SM_TwitterAccount",
                        principalColumn: "TwitterAccountID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_AutomationHistory",
                schema: "dbo",
                columns: table => new
                {
                    HistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistoryApprovedByUserID = table.Column<int>(type: "int", nullable: true),
                    HistoryStateID = table.Column<int>(type: "int", nullable: false),
                    HistoryStepID = table.Column<int>(type: "int", nullable: true),
                    HistoryTargetStepID = table.Column<int>(type: "int", nullable: true),
                    HistoryWorkflowID = table.Column<int>(type: "int", nullable: false),
                    HistoryApprovedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HistoryComment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoryRejected = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    HistoryStepDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "('')"),
                    HistoryStepName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true),
                    HistoryStepType = table.Column<int>(type: "int", nullable: true),
                    HistoryTargetStepDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    HistoryTargetStepName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true),
                    HistoryTargetStepType = table.Column<int>(type: "int", nullable: true),
                    HistoryTransitionType = table.Column<int>(type: "int", nullable: true),
                    HistoryWasRejected = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_AutomationHistory", x => x.HistoryID);
                    table.ForeignKey(
                        name: "FK_CMS_AutomationHistory_HistoryApprovedByUserID",
                        column: x => x.HistoryApprovedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_AutomationHistory_HistoryStateID",
                        column: x => x.HistoryStateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_AutomationState",
                        principalColumn: "StateID");
                    table.ForeignKey(
                        name: "FK_CMS_AutomationHistory_HistoryStepID",
                        column: x => x.HistoryStepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                    table.ForeignKey(
                        name: "FK_CMS_AutomationHistory_HistoryTargetStepID",
                        column: x => x.HistoryTargetStepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                    table.ForeignKey(
                        name: "FK_CMS_AutomationHistory_HistoryWorkflowID",
                        column: x => x.HistoryWorkflowID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Workflow",
                        principalColumn: "WorkflowID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_FormRole",
                schema: "dbo",
                columns: table => new
                {
                    FormID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_FormRole", x => new { x.FormID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_CMS_FormRole_FormID_CMS_Form",
                        column: x => x.FormID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Form",
                        principalColumn: "FormID");
                    table.ForeignKey(
                        name: "FK_CMS_FormRole_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_RolePermission",
                schema: "dbo",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    PermissionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_RolePermission", x => new { x.RoleID, x.PermissionID });
                    table.ForeignKey(
                        name: "FK_CMS_RolePermission_PermissionID_CMS_Permission",
                        column: x => x.PermissionID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Permission",
                        principalColumn: "PermissionID");
                    table.ForeignKey(
                        name: "FK_CMS_RolePermission_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WidgetRole",
                schema: "dbo",
                columns: table => new
                {
                    WidgetID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    PermissionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WidgetRole", x => new { x.WidgetID, x.RoleID, x.PermissionID });
                    table.ForeignKey(
                        name: "FK_CMS_WidgetRole_PermissionID_CMS_Permission",
                        column: x => x.PermissionID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Permission",
                        principalColumn: "PermissionID");
                    table.ForeignKey(
                        name: "FK_CMS_WidgetRole_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                    table.ForeignKey(
                        name: "FK_CMS_WidgetRole_WidgetID_CMS_Widget",
                        column: x => x.WidgetID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Widget",
                        principalColumn: "WidgetID");
                });

            migrationBuilder.CreateTable(
                name: "Community_GroupRolePermission",
                schema: "dbo",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    PermissionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Community_GroupRolePermission", x => new { x.GroupID, x.RoleID, x.PermissionID });
                    table.ForeignKey(
                        name: "FK_community_GroupRolePermission_GroupID_Community_Group",
                        column: x => x.GroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_community_GroupRolePermission_PermissionID_CMS_Permission",
                        column: x => x.PermissionID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Permission",
                        principalColumn: "PermissionID");
                    table.ForeignKey(
                        name: "FK_community_GroupRolePermission_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "Media_LibraryRolePermission",
                schema: "dbo",
                columns: table => new
                {
                    LibraryID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    PermissionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media_LibraryRolePermission", x => new { x.LibraryID, x.RoleID, x.PermissionID });
                    table.ForeignKey(
                        name: "FK_Media_LibraryRolePermission_LibraryID_Media_Library",
                        column: x => x.LibraryID,
                        principalSchema: "dbo",
                        principalTable: "Media_Library",
                        principalColumn: "LibraryID");
                    table.ForeignKey(
                        name: "FK_Media_LibraryRolePermission_PermissionID_CMS_Permission",
                        column: x => x.PermissionID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Permission",
                        principalColumn: "PermissionID");
                    table.ForeignKey(
                        name: "FK_Media_LibraryRolePermission_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_VersionAttachment",
                schema: "dbo",
                columns: table => new
                {
                    VersionHistoryID = table.Column<int>(type: "int", nullable: false),
                    AttachmentHistoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_VersionAttachment", x => new { x.VersionHistoryID, x.AttachmentHistoryID });
                    table.ForeignKey(
                        name: "FK_CMS_VersionAttachment_AttachmentHistoryID_CMS_AttachmentHistory",
                        column: x => x.AttachmentHistoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_AttachmentHistory",
                        principalColumn: "AttachmentHistoryID");
                    table.ForeignKey(
                        name: "FK_CMS_VersionAttachment_VersionHistoryID_CMS_VersionHistory",
                        column: x => x.VersionHistoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_VersionHistory",
                        principalColumn: "VersionHistoryID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_WorkflowHistory",
                schema: "dbo",
                columns: table => new
                {
                    WorkflowHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApprovedByUserID = table.Column<int>(type: "int", nullable: true),
                    HistoryWorkflowID = table.Column<int>(type: "int", nullable: true),
                    StepID = table.Column<int>(type: "int", nullable: true),
                    TargetStepID = table.Column<int>(type: "int", nullable: true),
                    VersionHistoryID = table.Column<int>(type: "int", nullable: false),
                    ApprovedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoryObjectID = table.Column<int>(type: "int", nullable: true),
                    HistoryObjectType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HistoryRejected = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    HistoryTransitionType = table.Column<int>(type: "int", nullable: true),
                    StepDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    StepName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true),
                    StepType = table.Column<int>(type: "int", nullable: true),
                    TargetStepDisplayName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    TargetStepName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true),
                    TargetStepType = table.Column<int>(type: "int", nullable: true),
                    WasRejected = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_WorkflowHistory", x => x.WorkflowHistoryID);
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowHistory_ApprovedByUserID_CMS_User",
                        column: x => x.ApprovedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowHistory_HistoryWorkflowID_CMS_Workflow",
                        column: x => x.HistoryWorkflowID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Workflow",
                        principalColumn: "WorkflowID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowHistory_StepID_CMS_WorkflowStep",
                        column: x => x.StepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowHistory_TargetStepID_CMS_WorkflowStep",
                        column: x => x.TargetStepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                    table.ForeignKey(
                        name: "FK_CMS_WorkflowHistory_VersionHistoryID_CMS_VersionHistory",
                        column: x => x.VersionHistoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_VersionHistory",
                        principalColumn: "VersionHistoryID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_CampaignAssetUrl",
                schema: "dbo",
                columns: table => new
                {
                    CampaignAssetUrlID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignAssetUrlCampaignAssetID = table.Column<int>(type: "int", nullable: false),
                    CampaignAssetUrlGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampaignAssetUrlPageTitle = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    CampaignAssetUrlTarget = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_CampaignAssetUrl", x => x.CampaignAssetUrlID);
                    table.ForeignKey(
                        name: "FK_Analytics_CampaignAssetUrl_CampaignAssetUrlCampaignAssetID_Analytics_CampaignAsset",
                        column: x => x.CampaignAssetUrlCampaignAssetID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_CampaignAsset",
                        principalColumn: "CampaignAssetID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_CampaignConversionHits",
                schema: "dbo",
                columns: table => new
                {
                    CampaignConversionHitsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignConversionHitsConversionID = table.Column<int>(type: "int", nullable: false),
                    CampaignConversionHitsContentName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CampaignConversionHitsCount = table.Column<int>(type: "int", nullable: false),
                    CampaignConversionHitsSourceName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_CampaignConversionHits", x => x.CampaignConversionHitsID);
                    table.ForeignKey(
                        name: "FK_Analytics_CampaignConversionHits_CampaignConversionHitsConversionID_Analytics_CampaignConversion",
                        column: x => x.CampaignConversionHitsConversionID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_CampaignConversion",
                        principalColumn: "CampaignConversionID");
                });

            migrationBuilder.CreateTable(
                name: "Analytics_CampaignObjective",
                schema: "dbo",
                columns: table => new
                {
                    CampaignObjectiveID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampaignObjectiveCampaignConversionID = table.Column<int>(type: "int", nullable: false),
                    CampaignObjectiveCampaignID = table.Column<int>(type: "int", nullable: false),
                    CampaignObjectiveGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CampaignObjectiveLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    CampaignObjectiveValue = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analytics_CampaignObjective", x => x.CampaignObjectiveID);
                    table.ForeignKey(
                        name: "FK_Analytics_CampaignObjective_CampaignObjectiveCampaignConversionID_Analytics_CampaignConversion",
                        column: x => x.CampaignObjectiveCampaignConversionID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_CampaignConversion",
                        principalColumn: "CampaignConversionID");
                    table.ForeignKey(
                        name: "FK_Analytics_CampaignObjective_CampaignObjectiveCampaignID_Analytics_Campaign",
                        column: x => x.CampaignObjectiveCampaignID,
                        principalSchema: "dbo",
                        principalTable: "Analytics_Campaign",
                        principalColumn: "CampaignID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Tree",
                schema: "dbo",
                columns: table => new
                {
                    NodeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NodeACLID = table.Column<int>(type: "int", nullable: true),
                    NodeClassID = table.Column<int>(type: "int", nullable: false),
                    NodeGroupID = table.Column<int>(type: "int", nullable: true),
                    NodeLinkedNodeID = table.Column<int>(type: "int", nullable: true),
                    NodeLinkedNodeSiteID = table.Column<int>(type: "int", nullable: true),
                    NodeOriginalNodeID = table.Column<int>(type: "int", nullable: true),
                    NodeOwner = table.Column<int>(type: "int", nullable: true),
                    NodeParentID = table.Column<int>(type: "int", nullable: true),
                    NodeSiteID = table.Column<int>(type: "int", nullable: false),
                    NodeSKUID = table.Column<int>(type: "int", nullable: true),
                    NodeTemplateID = table.Column<int>(type: "int", nullable: true),
                    IsSecuredNode = table.Column<bool>(type: "bit", nullable: true),
                    NodeAlias = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NodeAliasPath = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NodeAllowCacheInFileSystem = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NodeBodyElementAttributes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NodeBodyScripts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NodeCacheMinutes = table.Column<int>(type: "int", nullable: true),
                    NodeCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NodeDocType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NodeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NodeHasChildren = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NodeHasLinks = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NodeHeadTags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NodeInheritPageLevels = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NodeInheritPageTemplate = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    NodeIsACLOwner = table.Column<bool>(type: "bit", nullable: false),
                    NodeIsContentOnly = table.Column<bool>(type: "bit", nullable: false),
                    NodeLevel = table.Column<int>(type: "int", nullable: false),
                    NodeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NodeOrder = table.Column<int>(type: "int", nullable: true),
                    NodeTemplateForAllCultures = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    RequiresSSL = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Tree", x => x.NodeID);
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeACLID_CMS_ACL",
                        column: x => x.NodeACLID,
                        principalSchema: "dbo",
                        principalTable: "CMS_ACL",
                        principalColumn: "ACLID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeClassID_CMS_Class",
                        column: x => x.NodeClassID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Class",
                        principalColumn: "ClassID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeGroupID_Community_Group",
                        column: x => x.NodeGroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeLinkedNodeID_CMS_Tree",
                        column: x => x.NodeLinkedNodeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeLinkedNodeSiteID_CMS_Site",
                        column: x => x.NodeLinkedNodeSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeOriginalNodeID_CMS_Tree",
                        column: x => x.NodeOriginalNodeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeOwner_CMS_User",
                        column: x => x.NodeOwner,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeParentID_CMS_Tree",
                        column: x => x.NodeParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeSKUID_COM_SKU",
                        column: x => x.NodeSKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeSiteID_CMS_Site",
                        column: x => x.NodeSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_Tree_NodeTemplateID_CMS_PageTemplate",
                        column: x => x.NodeTemplateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplate",
                        principalColumn: "PageTemplateID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Bundle",
                schema: "dbo",
                columns: table => new
                {
                    BundleID = table.Column<int>(type: "int", nullable: false),
                    SKUID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Bundle", x => new { x.BundleID, x.SKUID });
                    table.ForeignKey(
                        name: "FK_COM_Bundle_BundleID_COM_SKU",
                        column: x => x.BundleID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                    table.ForeignKey(
                        name: "FK_COM_Bundle_SKUID_COM_SKU",
                        column: x => x.SKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                });

            migrationBuilder.CreateTable(
                name: "COM_MultiBuyDiscount",
                schema: "dbo",
                columns: table => new
                {
                    MultiBuyDiscountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MultiBuyDiscountApplyToSKUID = table.Column<int>(type: "int", nullable: true),
                    MultiBuyDiscountSiteID = table.Column<int>(type: "int", nullable: false),
                    MultiBuyDiscountApplyFurtherDiscounts = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    MultiBuyDiscountAutoAddEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    MultiBuyDiscountCustomerRestriction = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'All')"),
                    MultiBuyDiscountDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MultiBuyDiscountDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MultiBuyDiscountEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    MultiBuyDiscountGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MultiBuyDiscountIsFlat = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((1))"),
                    MultiBuyDiscountIsProductCoupon = table.Column<bool>(type: "bit", nullable: false),
                    MultiBuyDiscountLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MultiBuyDiscountLimitPerOrder = table.Column<int>(type: "int", nullable: true),
                    MultiBuyDiscountMinimumBuyCount = table.Column<int>(type: "int", nullable: false, defaultValueSql: "((1))"),
                    MultiBuyDiscountName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    MultiBuyDiscountPriority = table.Column<int>(type: "int", nullable: true),
                    MultiBuyDiscountRoles = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    MultiBuyDiscountUsesCoupons = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    MultiBuyDiscountValidFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MultiBuyDiscountValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MultiBuyDiscountValue = table.Column<decimal>(type: "decimal(18,9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_MultiBuyDiscount", x => x.MultiBuyDiscountID);
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscount_MultiBuyDiscountApplyToSKUID_COM_SKU",
                        column: x => x.MultiBuyDiscountApplyToSKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscount_MultiBuyDiscountSiteID_CMS_Site",
                        column: x => x.MultiBuyDiscountSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "COM_SKUAllowedOption",
                schema: "dbo",
                columns: table => new
                {
                    OptionSKUID = table.Column<int>(type: "int", nullable: false),
                    SKUID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_SKUOption", x => new { x.OptionSKUID, x.SKUID });
                    table.ForeignKey(
                        name: "FK_COM_SKUOption_OptionSKUID_COM_SKU",
                        column: x => x.OptionSKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                    table.ForeignKey(
                        name: "FK_COM_SKUOption_SKUID_COM_SKU",
                        column: x => x.SKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                });

            migrationBuilder.CreateTable(
                name: "COM_SKUFile",
                schema: "dbo",
                columns: table => new
                {
                    FileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileSKUID = table.Column<int>(type: "int", nullable: false),
                    FileGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FileMetaFileGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FileName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_SKUFile", x => x.FileID);
                    table.ForeignKey(
                        name: "FK_COM_SKUFile_COM_SKU",
                        column: x => x.FileSKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                });

            migrationBuilder.CreateTable(
                name: "COM_SKUOptionCategory",
                schema: "dbo",
                columns: table => new
                {
                    SKUCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    SKUID = table.Column<int>(type: "int", nullable: false),
                    AllowAllOptions = table.Column<bool>(type: "bit", nullable: true),
                    SKUCategoryOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_SKUOptionCategory", x => x.SKUCategoryID);
                    table.ForeignKey(
                        name: "FK_COM_SKUOptionCategory_CategoryID_COM_OptionCategory",
                        column: x => x.CategoryID,
                        principalSchema: "dbo",
                        principalTable: "COM_OptionCategory",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_COM_SKUOptionCategory_SKUID_COM_SKU",
                        column: x => x.SKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                });

            migrationBuilder.CreateTable(
                name: "COM_VariantOption",
                schema: "dbo",
                columns: table => new
                {
                    VariantSKUID = table.Column<int>(type: "int", nullable: false),
                    OptionSKUID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_VariantOption", x => new { x.VariantSKUID, x.OptionSKUID });
                    table.ForeignKey(
                        name: "FK_COM_VariantOption_OptionSKUID_COM_SKU",
                        column: x => x.OptionSKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                    table.ForeignKey(
                        name: "FK_COM_VariantOption_VariantSKUID_COM_SKU",
                        column: x => x.VariantSKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                });

            migrationBuilder.CreateTable(
                name: "COM_VolumeDiscount",
                schema: "dbo",
                columns: table => new
                {
                    VolumeDiscountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VolumeDiscountSKUID = table.Column<int>(type: "int", nullable: false),
                    VolumeDiscountGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VolumeDiscountIsFlatValue = table.Column<bool>(type: "bit", nullable: false),
                    VolumeDiscountLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VolumeDiscountMinCount = table.Column<int>(type: "int", nullable: false),
                    VolumeDiscountValue = table.Column<decimal>(type: "decimal(18,9)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_VolumeDiscount", x => x.VolumeDiscountID);
                    table.ForeignKey(
                        name: "FK_COM_VolumeDiscount_VolumeDiscountSKUID_COM_SKU",
                        column: x => x.VolumeDiscountSKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                });

            migrationBuilder.CreateTable(
                name: "COM_Wishlist",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    SKUID = table.Column<int>(type: "int", nullable: false),
                    SiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_Wishlist", x => new { x.UserID, x.SKUID, x.SiteID });
                    table.ForeignKey(
                        name: "FK_COM_Wishlist_SKUID_COM_SKU",
                        column: x => x.SKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                    table.ForeignKey(
                        name: "FK_COM_Wishlist_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_COM_Wishlist_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "COM_OrderAddress",
                schema: "dbo",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressCountryID = table.Column<int>(type: "int", nullable: false),
                    AddressOrderID = table.Column<int>(type: "int", nullable: false),
                    AddressStateID = table.Column<int>(type: "int", nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AddressLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AddressPersonalName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AddressPhone = table.Column<string>(type: "nvarchar(26)", maxLength: 26, nullable: true),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    AddressZip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_OrderAddress", x => x.AddressID);
                    table.ForeignKey(
                        name: "FK_COM_OrderAddress_AddressCountryID_CMS_Country",
                        column: x => x.AddressCountryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Country",
                        principalColumn: "CountryID");
                    table.ForeignKey(
                        name: "FK_COM_OrderAddress_AddressOrderID_COM_Order",
                        column: x => x.AddressOrderID,
                        principalSchema: "dbo",
                        principalTable: "COM_Order",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_COM_OrderAddress_AddressStateID_CMS_State",
                        column: x => x.AddressStateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_State",
                        principalColumn: "StateID");
                });

            migrationBuilder.CreateTable(
                name: "COM_OrderItem",
                schema: "dbo",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderItemOrderID = table.Column<int>(type: "int", nullable: false),
                    OrderItemSKUID = table.Column<int>(type: "int", nullable: false),
                    OrderItemBundleGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderItemCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderItemDiscountSummary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderItemGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderItemLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderItemParentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderItemProductDiscounts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderItemSendNotification = table.Column<bool>(type: "bit", nullable: true),
                    OrderItemSKUName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    OrderItemText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderItemTotalPrice = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
                    OrderItemTotalPriceInMainCurrency = table.Column<decimal>(type: "decimal(18,9)", nullable: true),
                    OrderItemUnitCount = table.Column<int>(type: "int", nullable: false),
                    OrderItemUnitPrice = table.Column<decimal>(type: "decimal(18,9)", nullable: false),
                    OrderItemValidTo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_OrderItem", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_COM_OrderItem_OrderItemOrderID_COM_Order",
                        column: x => x.OrderItemOrderID,
                        principalSchema: "dbo",
                        principalTable: "COM_Order",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_COM_OrderItem_OrderItemSKUID_COM_SKU",
                        column: x => x.OrderItemSKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                });

            migrationBuilder.CreateTable(
                name: "COM_OrderStatusUser",
                schema: "dbo",
                columns: table => new
                {
                    OrderStatusUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangedByUserID = table.Column<int>(type: "int", nullable: true),
                    FromStatusID = table.Column<int>(type: "int", nullable: true),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ToStatusID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_OrderStatusUser", x => x.OrderStatusUserID);
                    table.ForeignKey(
                        name: "FK_COM_OrderStatusUser_ChangedByUserID_CMS_User",
                        column: x => x.ChangedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_COM_OrderStatusUser_FromStatusID_COM_Status",
                        column: x => x.FromStatusID,
                        principalSchema: "dbo",
                        principalTable: "COM_OrderStatus",
                        principalColumn: "StatusID");
                    table.ForeignKey(
                        name: "FK_COM_OrderStatusUser_OrderID_COM_Order",
                        column: x => x.OrderID,
                        principalSchema: "dbo",
                        principalTable: "COM_Order",
                        principalColumn: "OrderID");
                    table.ForeignKey(
                        name: "FK_COM_OrderStatusUser_ToStatusID_COM_Status",
                        column: x => x.ToStatusID,
                        principalSchema: "dbo",
                        principalTable: "COM_OrderStatus",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateTable(
                name: "COM_ShoppingCartCouponCode",
                schema: "dbo",
                columns: table => new
                {
                    ShoppingCartCouponCodeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartID = table.Column<int>(type: "int", nullable: false),
                    CouponCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_ShoppingCartCouponCode", x => x.ShoppingCartCouponCodeID);
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCartCouponCode_ShoppingCartID_COM_ShoppingCart",
                        column: x => x.ShoppingCartID,
                        principalSchema: "dbo",
                        principalTable: "COM_ShoppingCart",
                        principalColumn: "ShoppingCartID");
                });

            migrationBuilder.CreateTable(
                name: "COM_ShoppingCartSKU",
                schema: "dbo",
                columns: table => new
                {
                    CartItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartID = table.Column<int>(type: "int", nullable: false),
                    SKUID = table.Column<int>(type: "int", nullable: false),
                    CartItemAutoAddedUnits = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    CartItemBundleGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CartItemCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartItemGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CartItemParentGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CartItemText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CartItemValidTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SKUUnits = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_ShoppingCartSKU", x => x.CartItemID);
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCartSKU_SKUID_COM_SKU",
                        column: x => x.SKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                    table.ForeignKey(
                        name: "FK_COM_ShoppingCartSKU_ShoppingCartID_COM_ShoppingCart",
                        column: x => x.ShoppingCartID,
                        principalSchema: "dbo",
                        principalTable: "COM_ShoppingCart",
                        principalColumn: "ShoppingCartID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_ABTest",
                schema: "dbo",
                columns: table => new
                {
                    TestID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestIssueID = table.Column<int>(type: "int", nullable: false),
                    TestWinnerIssueID = table.Column<int>(type: "int", nullable: true),
                    TestWinnerScheduledTaskID = table.Column<int>(type: "int", nullable: true),
                    TestGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TestLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('12/5/2011 4:56:38 PM')"),
                    TestNumberPerVariantEmails = table.Column<int>(type: "int", nullable: true),
                    TestSelectWinnerAfter = table.Column<int>(type: "int", nullable: true),
                    TestSizePercentage = table.Column<int>(type: "int", nullable: false),
                    TestWinnerOption = table.Column<int>(type: "int", nullable: false),
                    TestWinnerSelected = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_ABTest", x => x.TestID);
                    table.ForeignKey(
                        name: "FK_Newsletter_ABTest_Newsletter_NewsletterIssue",
                        column: x => x.TestIssueID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_NewsletterIssue",
                        principalColumn: "IssueID");
                    table.ForeignKey(
                        name: "FK_Newsletter_ABTest_TestWinnerIssueID_Newsletter_NewsletterIssue",
                        column: x => x.TestWinnerIssueID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_NewsletterIssue",
                        principalColumn: "IssueID");
                    table.ForeignKey(
                        name: "FK_Newsletter_ABTest_TestWinnerScheduledTaskID_CMS_ScheduledTask",
                        column: x => x.TestWinnerScheduledTaskID,
                        principalSchema: "dbo",
                        principalTable: "CMS_ScheduledTask",
                        principalColumn: "TaskID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_Emails",
                schema: "dbo",
                columns: table => new
                {
                    EmailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailNewsletterIssueID = table.Column<int>(type: "int", nullable: false),
                    EmailSiteID = table.Column<int>(type: "int", nullable: false),
                    EmailSubscriberID = table.Column<int>(type: "int", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    EmailContactID = table.Column<int>(type: "int", nullable: true),
                    EmailGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailLastSendAttempt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailLastSendResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailSending = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_Emails", x => x.EmailID);
                    table.ForeignKey(
                        name: "FK_Newsletter_Emails_EmailNewsletterIssueID_Newsletter_NewsletterIssue",
                        column: x => x.EmailNewsletterIssueID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_NewsletterIssue",
                        principalColumn: "IssueID");
                    table.ForeignKey(
                        name: "FK_Newsletter_Emails_EmailSiteID_CMS_Site",
                        column: x => x.EmailSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Newsletter_Emails_EmailSubscriberID_Newsletter_Subscriber",
                        column: x => x.EmailSubscriberID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_Subscriber",
                        principalColumn: "SubscriberID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_Link",
                schema: "dbo",
                columns: table => new
                {
                    LinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkIssueID = table.Column<int>(type: "int", nullable: false),
                    LinkDescription = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    LinkGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LinkTarget = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_Link", x => x.LinkID);
                    table.ForeignKey(
                        name: "FK_Newsletter_Link_Newsletter_NewsletterIssue",
                        column: x => x.LinkIssueID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_NewsletterIssue",
                        principalColumn: "IssueID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_OpenedEmail",
                schema: "dbo",
                columns: table => new
                {
                    OpenedEmailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpenedEmailIssueID = table.Column<int>(type: "int", nullable: false),
                    OpenedEmailEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false, defaultValueSql: "(N'')"),
                    OpenedEmailGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpenedEmailTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_OpenedEmail", x => x.OpenedEmailID);
                    table.ForeignKey(
                        name: "FK_Newsletter_OpenedEmail_OpenedEmailIssueID_Newsletter_NewsletterIssue",
                        column: x => x.OpenedEmailIssueID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_NewsletterIssue",
                        principalColumn: "IssueID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_Unsubscription",
                schema: "dbo",
                columns: table => new
                {
                    UnsubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnsubscriptionFromIssueID = table.Column<int>(type: "int", nullable: true),
                    UnsubscriptionNewsletterID = table.Column<int>(type: "int", nullable: true),
                    UnsubscriptionCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UnsubscriptionEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false, defaultValueSql: "(N'')"),
                    UnsubscriptionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_Unsubscription", x => x.UnsubscriptionID);
                    table.ForeignKey(
                        name: "FK_Newsletter_Unsubscription_UnsubscriptionFromIssueID_Newsletter_NewsletterIssue",
                        column: x => x.UnsubscriptionFromIssueID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_NewsletterIssue",
                        principalColumn: "IssueID");
                    table.ForeignKey(
                        name: "FK_Newsletter_Unsubscription_UnsubscriptionNewsletterID_Newsletter_Newsletter",
                        column: x => x.UnsubscriptionNewsletterID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_Newsletter",
                        principalColumn: "NewsletterID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Document",
                schema: "dbo",
                columns: table => new
                {
                    DocumentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentCheckedOutByUserID = table.Column<int>(type: "int", nullable: true),
                    DocumentCheckedOutVersionHistoryID = table.Column<int>(type: "int", nullable: true),
                    DocumentCreatedByUserID = table.Column<int>(type: "int", nullable: true),
                    DocumentModifiedByUserID = table.Column<int>(type: "int", nullable: true),
                    DocumentNodeID = table.Column<int>(type: "int", nullable: false),
                    DocumentPageTemplateID = table.Column<int>(type: "int", nullable: true),
                    DocumentPublishedVersionHistoryID = table.Column<int>(type: "int", nullable: true),
                    DocumentStylesheetID = table.Column<int>(type: "int", nullable: true),
                    DocumentTagGroupID = table.Column<int>(type: "int", nullable: true),
                    DocumentWorkflowStepID = table.Column<int>(type: "int", nullable: true),
                    DocumentABTestConfiguration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentCanBePublished = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    DocumentCheckedOutAutomatically = table.Column<bool>(type: "bit", nullable: true),
                    DocumentCheckedOutWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentConversionValue = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocumentCreatedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentCulture = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DocumentCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentExtensions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocumentForeignKeyValue = table.Column<int>(type: "int", nullable: true),
                    DocumentGroupWebParts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DocumentHash = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    DocumentInheritsStylesheet = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    DocumentIsArchived = table.Column<bool>(type: "bit", nullable: true),
                    DocumentIsWaitingForTranslation = table.Column<bool>(type: "bit", nullable: true),
                    DocumentLastPublished = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentLastVersionNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentLogVisitActivity = table.Column<bool>(type: "bit", nullable: true),
                    DocumentMenuCaption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DocumentMenuClass = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocumentMenuClassHighlighted = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocumentMenuItemHideInNavigation = table.Column<bool>(type: "bit", nullable: false),
                    DocumentMenuItemImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DocumentMenuItemImageHighlighted = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DocumentMenuItemInactive = table.Column<bool>(type: "bit", nullable: true),
                    DocumentMenuItemLeftImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DocumentMenuItemLeftImageHighlighted = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DocumentMenuItemRightImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DocumentMenuItemRightImageHighlighted = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DocumentMenuJavascript = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DocumentMenuRedirectToFirstChild = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DocumentMenuRedirectUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DocumentMenuStyle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocumentMenuStyleHighlighted = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DocumentModifiedWhen = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DocumentNamePath = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: true),
                    DocumentPageBuilderWidgets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentPageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentPageKeyWords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentPageTemplateConfiguration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentPageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentPriority = table.Column<int>(type: "int", nullable: true),
                    DocumentPublishFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentPublishTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentRatingValue = table.Column<double>(type: "float", nullable: true),
                    DocumentRatings = table.Column<int>(type: "int", nullable: true),
                    DocumentSearchExcluded = table.Column<bool>(type: "bit", nullable: true),
                    DocumentShowInSiteMap = table.Column<bool>(type: "bit", nullable: false),
                    DocumentSitemapSettings = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DocumentSKUDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentSKUName = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true),
                    DocumentSKUShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTrackConversionName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentUrlPath = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DocumentUseCustomExtensions = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    DocumentUseNamePathForUrlPath = table.Column<bool>(type: "bit", nullable: true),
                    DocumentWebParts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentWildcardRule = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true),
                    DocumentWorkflowActionStatus = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    DocumentWorkflowCycleGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Document", x => x.DocumentID);
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentCheckedOutByUserID_CMS_User",
                        column: x => x.DocumentCheckedOutByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentCheckedOutVersionHistoryID_CMS_VersionHistory",
                        column: x => x.DocumentCheckedOutVersionHistoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_VersionHistory",
                        principalColumn: "VersionHistoryID");
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentCreatedByUserID_CMS_User",
                        column: x => x.DocumentCreatedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentModifiedByUserID_CMS_User",
                        column: x => x.DocumentModifiedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentNodeID_CMS_Tree",
                        column: x => x.DocumentNodeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentPageTemplateID_CMS_Template",
                        column: x => x.DocumentPageTemplateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplate",
                        principalColumn: "PageTemplateID");
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentPublishedVersionHistoryID_CMS_VersionHistory",
                        column: x => x.DocumentPublishedVersionHistoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_VersionHistory",
                        principalColumn: "VersionHistoryID");
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentStylesheetID_CMS_CssStylesheet",
                        column: x => x.DocumentStylesheetID,
                        principalSchema: "dbo",
                        principalTable: "CMS_CssStylesheet",
                        principalColumn: "StylesheetID");
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentTagGroupID_CMS_TagGroup",
                        column: x => x.DocumentTagGroupID,
                        principalSchema: "dbo",
                        principalTable: "CMS_TagGroup",
                        principalColumn: "TagGroupID");
                    table.ForeignKey(
                        name: "FK_CMS_Document_DocumentWorkflowStepID_CMS_WorkflowStep",
                        column: x => x.DocumentWorkflowStepID,
                        principalSchema: "dbo",
                        principalTable: "CMS_WorkflowStep",
                        principalColumn: "StepID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_DocumentAlias",
                schema: "dbo",
                columns: table => new
                {
                    AliasID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AliasNodeID = table.Column<int>(type: "int", nullable: false),
                    AliasSiteID = table.Column<int>(type: "int", nullable: false),
                    AliasActionMode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AliasCulture = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true, defaultValueSql: "(N'')"),
                    AliasExtensions = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(N'')"),
                    AliasGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AliasLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('10/22/2008 12:55:43 PM')"),
                    AliasPriority = table.Column<int>(type: "int", nullable: true),
                    AliasURLPath = table.Column<string>(type: "nvarchar(450)", nullable: true, defaultValueSql: "(N'')"),
                    AliasWildcardRule = table.Column<string>(type: "nvarchar(440)", maxLength: 440, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_DocumentAlias", x => x.AliasID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_DocumentAlias_AliasNodeID_CMS_Tree",
                        column: x => x.AliasNodeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                    table.ForeignKey(
                        name: "FK_CMS_DocumentAlias_AliasSiteID_CMS_Site",
                        column: x => x.AliasSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Relationship",
                schema: "dbo",
                columns: table => new
                {
                    RelationshipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeftNodeID = table.Column<int>(type: "int", nullable: false),
                    RelationshipNameID = table.Column<int>(type: "int", nullable: false),
                    RightNodeID = table.Column<int>(type: "int", nullable: false),
                    RelationshipCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelationshipIsAdHoc = table.Column<bool>(type: "bit", nullable: true),
                    RelationshipOrder = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Relationship", x => x.RelationshipID);
                    table.ForeignKey(
                        name: "FK_CMS_Relationship_LeftNodeID_CMS_Tree",
                        column: x => x.LeftNodeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                    table.ForeignKey(
                        name: "FK_CMS_Relationship_RelationshipNameID_CMS_RelationshipName",
                        column: x => x.RelationshipNameID,
                        principalSchema: "dbo",
                        principalTable: "CMS_RelationshipName",
                        principalColumn: "RelationshipNameID");
                    table.ForeignKey(
                        name: "FK_CMS_Relationship_RightNodeID_CMS_Tree",
                        column: x => x.RightNodeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                });

            migrationBuilder.CreateTable(
                name: "Events_Attendee",
                schema: "dbo",
                columns: table => new
                {
                    AttendeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttendeeEventNodeID = table.Column<int>(type: "int", nullable: false),
                    AttendeeEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false, defaultValueSql: "(N'')"),
                    AttendeeFirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(N'')"),
                    AttendeeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttendeeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/20/2015 8:52:25 AM')"),
                    AttendeeLastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true, defaultValueSql: "(N'')"),
                    AttendeePhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events_Attendee", x => x.AttendeeID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Events_Attendee_AttendeeEventNodeID_CMS_Tree",
                        column: x => x.AttendeeEventNodeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                });

            migrationBuilder.CreateTable(
                name: "Personas_PersonaNode",
                schema: "dbo",
                columns: table => new
                {
                    PersonaID = table.Column<int>(type: "int", nullable: false),
                    NodeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas_PersonaNode", x => new { x.PersonaID, x.NodeID });
                    table.ForeignKey(
                        name: "FK_Personas_PersonaNode_CMS_Tree",
                        column: x => x.NodeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                });

            migrationBuilder.CreateTable(
                name: "COM_MultiBuyCouponCode",
                schema: "dbo",
                columns: table => new
                {
                    MultiBuyCouponCodeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MultiBuyCouponCodeMultiBuyDiscountID = table.Column<int>(type: "int", nullable: false),
                    MultiBuyCouponCodeCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "(N'')"),
                    MultiBuyCouponCodeGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MultiBuyCouponCodeLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MultiBuyCouponCodeUseCount = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    MultiBuyCouponCodeUseLimit = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_MultiBuyCouponCode", x => x.MultiBuyCouponCodeID);
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyCouponCode_MultiBuyCouponCodeMultiBuyDiscountID_COM_MultiBuyDiscount",
                        column: x => x.MultiBuyCouponCodeMultiBuyDiscountID,
                        principalSchema: "dbo",
                        principalTable: "COM_MultiBuyDiscount",
                        principalColumn: "MultiBuyDiscountID");
                });

            migrationBuilder.CreateTable(
                name: "COM_MultiBuyDiscountBrand",
                schema: "dbo",
                columns: table => new
                {
                    MultiBuyDiscountID = table.Column<int>(type: "int", nullable: false),
                    BrandID = table.Column<int>(type: "int", nullable: false),
                    BrandIncluded = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_MultiBuyDiscountBrand", x => new { x.MultiBuyDiscountID, x.BrandID });
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountBrand_BrandID_COM_Brand",
                        column: x => x.BrandID,
                        principalSchema: "dbo",
                        principalTable: "COM_Brand",
                        principalColumn: "BrandID");
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountBrand_MultiBuyDiscountID_COM_MultiBuyDiscount",
                        column: x => x.MultiBuyDiscountID,
                        principalSchema: "dbo",
                        principalTable: "COM_MultiBuyDiscount",
                        principalColumn: "MultiBuyDiscountID");
                });

            migrationBuilder.CreateTable(
                name: "COM_MultiBuyDiscountCollection",
                schema: "dbo",
                columns: table => new
                {
                    MultibuyDiscountID = table.Column<int>(type: "int", nullable: false),
                    CollectionID = table.Column<int>(type: "int", nullable: false),
                    CollectionIncluded = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_MultiBuyDiscountCollection", x => new { x.MultibuyDiscountID, x.CollectionID });
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountCollection_CollectionID_COM_Collection",
                        column: x => x.CollectionID,
                        principalSchema: "dbo",
                        principalTable: "COM_Collection",
                        principalColumn: "CollectionID");
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountCollection_MultiBuyDiscountID_COM_MultiBuyDiscount",
                        column: x => x.MultibuyDiscountID,
                        principalSchema: "dbo",
                        principalTable: "COM_MultiBuyDiscount",
                        principalColumn: "MultiBuyDiscountID");
                });

            migrationBuilder.CreateTable(
                name: "COM_MultiBuyDiscountDepartment",
                schema: "dbo",
                columns: table => new
                {
                    MultiBuyDiscountID = table.Column<int>(type: "int", nullable: false),
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_MultiBuyDiscountDepartment", x => new { x.MultiBuyDiscountID, x.DepartmentID });
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountDepartment_DepartmentID_COM_Department",
                        column: x => x.DepartmentID,
                        principalSchema: "dbo",
                        principalTable: "COM_Department",
                        principalColumn: "DepartmentID");
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountDepartment_MultiBuyDiscountID_COM_MultiBuyDiscount",
                        column: x => x.MultiBuyDiscountID,
                        principalSchema: "dbo",
                        principalTable: "COM_MultiBuyDiscount",
                        principalColumn: "MultiBuyDiscountID");
                });

            migrationBuilder.CreateTable(
                name: "COM_MultiBuyDiscountSKU",
                schema: "dbo",
                columns: table => new
                {
                    MultiBuyDiscountID = table.Column<int>(type: "int", nullable: false),
                    SKUID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_MultiBuyDiscountSKU", x => new { x.MultiBuyDiscountID, x.SKUID });
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountSKU_MultiBuyDiscountID_COM_MultiBuyDiscount",
                        column: x => x.MultiBuyDiscountID,
                        principalSchema: "dbo",
                        principalTable: "COM_MultiBuyDiscount",
                        principalColumn: "MultiBuyDiscountID");
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountSKU_SKUID_COM_SKU",
                        column: x => x.SKUID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKU",
                        principalColumn: "SKUID");
                });

            migrationBuilder.CreateTable(
                name: "COM_MultiBuyDiscountTree",
                schema: "dbo",
                columns: table => new
                {
                    MultiBuyDiscountID = table.Column<int>(type: "int", nullable: false),
                    NodeID = table.Column<int>(type: "int", nullable: false),
                    NodeIncluded = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_MultiBuyDiscountTree", x => new { x.MultiBuyDiscountID, x.NodeID });
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountTree_MultiBuyDiscountID_COM_MultiBuyDiscount",
                        column: x => x.MultiBuyDiscountID,
                        principalSchema: "dbo",
                        principalTable: "COM_MultiBuyDiscount",
                        principalColumn: "MultiBuyDiscountID");
                    table.ForeignKey(
                        name: "FK_COM_MultiBuyDiscountTree_NodeID_CMS_Tree",
                        column: x => x.NodeID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tree",
                        principalColumn: "NodeID");
                });

            migrationBuilder.CreateTable(
                name: "COM_OrderItemSKUFile",
                schema: "dbo",
                columns: table => new
                {
                    OrderItemSKUFileID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileID = table.Column<int>(type: "int", nullable: false),
                    OrderItemID = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COM_OrderItemSKUFile", x => x.OrderItemSKUFileID);
                    table.ForeignKey(
                        name: "FK_COM_OrderItemSKUFile_COM_OrderItem",
                        column: x => x.OrderItemID,
                        principalSchema: "dbo",
                        principalTable: "COM_OrderItem",
                        principalColumn: "OrderItemID");
                    table.ForeignKey(
                        name: "FK_COM_OrderItemSKUFile_COM_SKUFile",
                        column: x => x.FileID,
                        principalSchema: "dbo",
                        principalTable: "COM_SKUFile",
                        principalColumn: "FileID");
                });

            migrationBuilder.CreateTable(
                name: "Newsletter_ClickedLink",
                schema: "dbo",
                columns: table => new
                {
                    ClickedLinkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClickedLinkNewsletterLinkID = table.Column<int>(type: "int", nullable: false),
                    ClickedLinkEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false, defaultValueSql: "(N'')"),
                    ClickedLinkGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClickedLinkTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newsletter_ClickedLink", x => x.ClickedLinkID);
                    table.ForeignKey(
                        name: "FK_Newsletter_ClickedLink_Newsletter_Link",
                        column: x => x.ClickedLinkNewsletterLinkID,
                        principalSchema: "dbo",
                        principalTable: "Newsletter_Link",
                        principalColumn: "LinkID");
                });

            migrationBuilder.CreateTable(
                name: "Blog_Comment",
                schema: "dbo",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentApprovedByUserID = table.Column<int>(type: "int", nullable: true),
                    CommentPostDocumentID = table.Column<int>(type: "int", nullable: false),
                    CommentUserID = table.Column<int>(type: "int", nullable: true),
                    CommentApproved = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    CommentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentIsSpam = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    CommentText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentUrl = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    CommentUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog_Comment", x => x.CommentID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Blog_Comment_CommentApprovedByUserID_CMS_User",
                        column: x => x.CommentApprovedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Blog_Comment_CommentPostDocumentID_CMS_Document",
                        column: x => x.CommentPostDocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                    table.ForeignKey(
                        name: "FK_Blog_Comment_CommentUserID_CMS_User",
                        column: x => x.CommentUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Blog_PostSubscription",
                schema: "dbo",
                columns: table => new
                {
                    SubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionPostDocumentID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionUserID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionApprovalHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubscriptionApproved = table.Column<bool>(type: "bit", nullable: true),
                    SubscriptionEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    SubscriptionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog_PostSubscription", x => x.SubscriptionID);
                    table.ForeignKey(
                        name: "FK_Blog_PostSubscription_SubscriptionPostDocumentID_CMS_Document",
                        column: x => x.SubscriptionPostDocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                    table.ForeignKey(
                        name: "FK_Blog_PostSubscription_SubscriptionUserID_CMS_User",
                        column: x => x.SubscriptionUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Board_Board",
                schema: "dbo",
                columns: table => new
                {
                    BoardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoardDocumentID = table.Column<int>(type: "int", nullable: false),
                    BoardGroupID = table.Column<int>(type: "int", nullable: true),
                    BoardSiteID = table.Column<int>(type: "int", nullable: false),
                    BoardUserID = table.Column<int>(type: "int", nullable: true),
                    BoardAccess = table.Column<int>(type: "int", nullable: false),
                    BoardBaseURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    BoardDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BoardDisplayName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BoardEnableOptIn = table.Column<bool>(type: "bit", nullable: true),
                    BoardEnableSubscriptions = table.Column<bool>(type: "bit", nullable: false),
                    BoardEnabled = table.Column<bool>(type: "bit", nullable: false),
                    BoardGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BoardLastMessageTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BoardLastMessageUserName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BoardLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BoardLogActivity = table.Column<bool>(type: "bit", nullable: true),
                    BoardMessages = table.Column<int>(type: "int", nullable: false),
                    BoardModerated = table.Column<bool>(type: "bit", nullable: false),
                    BoardName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')"),
                    BoardOpened = table.Column<bool>(type: "bit", nullable: false),
                    BoardOpenedFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BoardOpenedTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BoardOptInApprovalURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    BoardRequireEmails = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    BoardSendOptInConfirmation = table.Column<bool>(type: "bit", nullable: true),
                    BoardUnsubscriptionURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    BoardUseCaptcha = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board_Board", x => x.BoardID);
                    table.ForeignKey(
                        name: "FK_Board_Board_BoardDocumentID_CMS_Document",
                        column: x => x.BoardDocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                    table.ForeignKey(
                        name: "FK_Board_Board_BoardGroupID_Community_Group",
                        column: x => x.BoardGroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_Board_Board_BoardSiteID_CMS_Site",
                        column: x => x.BoardSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Board_Board_BoardUserID_CMS_User",
                        column: x => x.BoardUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_AlternativeUrl",
                schema: "dbo",
                columns: table => new
                {
                    AlternativeUrlID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlternativeUrlDocumentID = table.Column<int>(type: "int", nullable: false),
                    AlternativeUrlSiteID = table.Column<int>(type: "int", nullable: false),
                    AlternativeUrlGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AlternativeUrlLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('1/1/0001 12:00:00 AM')"),
                    AlternativeUrlUrl = table.Column<string>(type: "nvarchar(450)", nullable: false, defaultValueSql: "(N'')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_AlternativeUrl", x => x.AlternativeUrlID);
                    table.ForeignKey(
                        name: "FK_CMS_AlternativeUrl_CMS_Document",
                        column: x => x.AlternativeUrlDocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                    table.ForeignKey(
                        name: "FK_CMS_AlternativeUrl_CMS_Site",
                        column: x => x.AlternativeUrlSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Attachment",
                schema: "dbo",
                columns: table => new
                {
                    AttachmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentDocumentID = table.Column<int>(type: "int", nullable: true),
                    AttachmentSiteID = table.Column<int>(type: "int", nullable: false),
                    AttachmentVariantParentID = table.Column<int>(type: "int", nullable: true),
                    AttachmentBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AttachmentCustomData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentExtension = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttachmentFormGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentGroupGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AttachmentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttachmentHash = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    AttachmentImageHeight = table.Column<int>(type: "int", nullable: true),
                    AttachmentImageWidth = table.Column<int>(type: "int", nullable: true),
                    AttachmentIsUnsorted = table.Column<bool>(type: "bit", nullable: true),
                    AttachmentLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttachmentMimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AttachmentOrder = table.Column<int>(type: "int", nullable: true),
                    AttachmentSearchContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentSize = table.Column<int>(type: "int", nullable: false),
                    AttachmentTitle = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    AttachmentVariantDefinitionIdentifier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Attachment", x => x.AttachmentID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Attachment_AttachmentDocumentID_CMS_Document",
                        column: x => x.AttachmentDocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                    table.ForeignKey(
                        name: "FK_CMS_Attachment_AttachmentSiteID_CMS_Site",
                        column: x => x.AttachmentSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_Attachment_AttachmentVariantParentID_CMS_Attachment",
                        column: x => x.AttachmentVariantParentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Attachment",
                        principalColumn: "AttachmentID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_DocumentCategory",
                schema: "dbo",
                columns: table => new
                {
                    DocumentID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_DocumentCategory", x => new { x.DocumentID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_CMS_DocumentCategory_CategoryID_CMS_Category",
                        column: x => x.CategoryID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Category",
                        principalColumn: "CategoryID");
                    table.ForeignKey(
                        name: "FK_CMS_DocumentCategory_DocumentID_CMS_Document",
                        column: x => x.DocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_DocumentTag",
                schema: "dbo",
                columns: table => new
                {
                    DocumentID = table.Column<int>(type: "int", nullable: false),
                    TagID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_DocumentTag", x => new { x.DocumentID, x.TagID });
                    table.ForeignKey(
                        name: "FK_CMS_DocumentTag_DocumentID_CMS_Document",
                        column: x => x.DocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                    table.ForeignKey(
                        name: "FK_CMS_DocumentTag_TagID_CMS_Tag",
                        column: x => x.TagID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Tag",
                        principalColumn: "TagID");
                });

            migrationBuilder.CreateTable(
                name: "CMS_Personalization",
                schema: "dbo",
                columns: table => new
                {
                    PersonalizationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonalizationDocumentID = table.Column<int>(type: "int", nullable: true),
                    PersonalizationSiteID = table.Column<int>(type: "int", nullable: true),
                    PersonalizationUserID = table.Column<int>(type: "int", nullable: true),
                    PersonalizationDashboardName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PersonalizationGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonalizationLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('9/2/2008 5:36:59 PM')"),
                    PersonalizationWebParts = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMS_Personalization", x => x.PersonalizationID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_CMS_Personalization_PersonalizationDocumentID_CMS_Document",
                        column: x => x.PersonalizationDocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                    table.ForeignKey(
                        name: "FK_CMS_Personalization_PersonalizationSiteID_CMS_Site",
                        column: x => x.PersonalizationSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_CMS_Personalization_PersonalizationUserID_CMS_User",
                        column: x => x.PersonalizationUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Forums_Forum",
                schema: "dbo",
                columns: table => new
                {
                    ForumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumCommunityGroupID = table.Column<int>(type: "int", nullable: true),
                    ForumDocumentID = table.Column<int>(type: "int", nullable: true),
                    ForumGroupID = table.Column<int>(type: "int", nullable: false),
                    ForumSiteID = table.Column<int>(type: "int", nullable: false),
                    ForumAccess = table.Column<int>(type: "int", nullable: false),
                    ForumAllowChangeName = table.Column<bool>(type: "bit", nullable: true),
                    ForumAttachmentMaxFileSize = table.Column<int>(type: "int", nullable: true),
                    ForumAuthorDelete = table.Column<bool>(type: "bit", nullable: true),
                    ForumAuthorEdit = table.Column<bool>(type: "bit", nullable: true),
                    ForumBaseUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ForumDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForumDiscussionActions = table.Column<int>(type: "int", nullable: true),
                    ForumDisplayEmails = table.Column<bool>(type: "bit", nullable: true),
                    ForumDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ForumEnableOptIn = table.Column<bool>(type: "bit", nullable: true),
                    ForumGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ForumHTMLEditor = table.Column<bool>(type: "bit", nullable: true),
                    ForumImageMaxSideSize = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((400))"),
                    ForumIsAnswerLimit = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((5))"),
                    ForumIsLocked = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    ForumLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ForumLastPostTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ForumLastPostTimeAbsolute = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ForumLastPostUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ForumLastPostUserNameAbsolute = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ForumLogActivity = table.Column<bool>(type: "bit", nullable: true),
                    ForumModerated = table.Column<bool>(type: "bit", nullable: false),
                    ForumName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ForumOpen = table.Column<bool>(type: "bit", nullable: false),
                    ForumOptInApprovalURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    ForumOrder = table.Column<int>(type: "int", nullable: true),
                    ForumPosts = table.Column<int>(type: "int", nullable: false),
                    ForumPostsAbsolute = table.Column<int>(type: "int", nullable: true),
                    ForumRequireEmail = table.Column<bool>(type: "bit", nullable: true),
                    ForumSendOptInConfirmation = table.Column<bool>(type: "bit", nullable: true),
                    ForumSettings = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForumThreads = table.Column<int>(type: "int", nullable: false),
                    ForumThreadsAbsolute = table.Column<int>(type: "int", nullable: true),
                    ForumType = table.Column<int>(type: "int", nullable: true),
                    ForumUnsubscriptionUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ForumUseCAPTCHA = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums_Forum", x => x.ForumID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Forums_Forum_ForumCommunityGroupID_Community_Group",
                        column: x => x.ForumCommunityGroupID,
                        principalSchema: "dbo",
                        principalTable: "Community_Group",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_Forums_Forum_ForumDocumentID_CMS_Document",
                        column: x => x.ForumDocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                    table.ForeignKey(
                        name: "FK_Forums_Forum_ForumGroupID_Forums_ForumGroup",
                        column: x => x.ForumGroupID,
                        principalSchema: "dbo",
                        principalTable: "Forums_ForumGroup",
                        principalColumn: "GroupID");
                    table.ForeignKey(
                        name: "FK_Forums_Forum_ForumSiteID_CMS_Site",
                        column: x => x.ForumSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "OM_PersonalizationVariant",
                schema: "dbo",
                columns: table => new
                {
                    VariantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VariantDocumentID = table.Column<int>(type: "int", nullable: true),
                    VariantPageTemplateID = table.Column<int>(type: "int", nullable: false),
                    VariantDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VariantDisplayCondition = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')"),
                    VariantDisplayName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    VariantEnabled = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "((1))"),
                    VariantGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VariantInstanceGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VariantLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VariantName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    VariantPosition = table.Column<int>(type: "int", nullable: true),
                    VariantWebParts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariantZoneID = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OM_PersonalizationVariant", x => x.VariantID);
                    table.ForeignKey(
                        name: "FK_OM_PersonalizationVariant_VariantDocumentID_CMS_Document",
                        column: x => x.VariantDocumentID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Document",
                        principalColumn: "DocumentID");
                    table.ForeignKey(
                        name: "FK_OM_PersonalizationVariant_VariantPageTemplateID_CMS_PageTemplate",
                        column: x => x.VariantPageTemplateID,
                        principalSchema: "dbo",
                        principalTable: "CMS_PageTemplate",
                        principalColumn: "PageTemplateID");
                });

            migrationBuilder.CreateTable(
                name: "Board_Message",
                schema: "dbo",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageApprovedByUserID = table.Column<int>(type: "int", nullable: true),
                    MessageBoardID = table.Column<int>(type: "int", nullable: false),
                    MessageUserID = table.Column<int>(type: "int", nullable: true),
                    MessageApproved = table.Column<bool>(type: "bit", nullable: false),
                    MessageAvatarGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MessageEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false, defaultValueSql: "(N'')"),
                    MessageGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessageInserted = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('8/26/2008 12:14:50 PM')"),
                    MessageIsSpam = table.Column<bool>(type: "bit", nullable: false),
                    MessageLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('8/26/2008 12:15:04 PM')"),
                    MessageRatingValue = table.Column<double>(type: "float", nullable: true),
                    MessageText = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')"),
                    MessageURL = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false, defaultValueSql: "('')"),
                    MessageUserInfo = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "('')"),
                    MessageUserName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false, defaultValueSql: "('')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board_Message", x => x.MessageID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Board_Message_MessageApprovedByUserID_CMS_User",
                        column: x => x.MessageApprovedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Board_Message_MessageBoardID_Board_Board",
                        column: x => x.MessageBoardID,
                        principalSchema: "dbo",
                        principalTable: "Board_Board",
                        principalColumn: "BoardID");
                    table.ForeignKey(
                        name: "FK_Board_Message_MessageUserID_CMS_User",
                        column: x => x.MessageUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Board_Moderator",
                schema: "dbo",
                columns: table => new
                {
                    BoardID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board_Moderator", x => new { x.BoardID, x.UserID });
                    table.ForeignKey(
                        name: "FK_Board_Moderator_BoardID_Board_Board",
                        column: x => x.BoardID,
                        principalSchema: "dbo",
                        principalTable: "Board_Board",
                        principalColumn: "BoardID");
                    table.ForeignKey(
                        name: "FK_Board_Moderator_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Board_Role",
                schema: "dbo",
                columns: table => new
                {
                    BoardID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board_Role", x => new { x.BoardID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_Board_Role_BoardID_Board_Board",
                        column: x => x.BoardID,
                        principalSchema: "dbo",
                        principalTable: "Board_Board",
                        principalColumn: "BoardID");
                    table.ForeignKey(
                        name: "FK_Board_Role_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "Board_Subscription",
                schema: "dbo",
                columns: table => new
                {
                    SubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionBoardID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionUserID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionApprovalHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubscriptionApproved = table.Column<bool>(type: "bit", nullable: true),
                    SubscriptionEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: false, defaultValueSql: "(N'')"),
                    SubscriptionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board_Subscription", x => x.SubscriptionID);
                    table.ForeignKey(
                        name: "FK_Board_Subscription_SubscriptionBoardID_Board_Board",
                        column: x => x.SubscriptionBoardID,
                        principalSchema: "dbo",
                        principalTable: "Board_Board",
                        principalColumn: "BoardID");
                    table.ForeignKey(
                        name: "FK_Board_Subscription_SubscriptionUserID_CMS_User",
                        column: x => x.SubscriptionUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Forums_ForumModerators",
                schema: "dbo",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ForumID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums_ForumModerators", x => new { x.UserID, x.ForumID });
                    table.ForeignKey(
                        name: "FK_Forums_ForumModerators_ForumID_Forums_Forum",
                        column: x => x.ForumID,
                        principalSchema: "dbo",
                        principalTable: "Forums_Forum",
                        principalColumn: "ForumID");
                    table.ForeignKey(
                        name: "FK_Forums_ForumModerators_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Forums_ForumPost",
                schema: "dbo",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostApprovedByUserID = table.Column<int>(type: "int", nullable: true),
                    PostForumID = table.Column<int>(type: "int", nullable: false),
                    PostParentID = table.Column<int>(type: "int", nullable: true),
                    PostUserID = table.Column<int>(type: "int", nullable: true),
                    PostApproved = table.Column<bool>(type: "bit", nullable: true),
                    PostAttachmentCount = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    PostGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PostIDPath = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostIsAnswer = table.Column<int>(type: "int", nullable: true),
                    PostIsLocked = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PostIsNotAnswer = table.Column<int>(type: "int", nullable: true),
                    PostLastEdit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PostLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostLevel = table.Column<int>(type: "int", nullable: false),
                    PostQuestionSolved = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PostSiteID = table.Column<int>(type: "int", nullable: true),
                    PostStickOrder = table.Column<int>(type: "int", nullable: false),
                    PostSubject = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    PostText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostThreadLastPostTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PostThreadLastPostTimeAbsolute = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PostThreadLastPostUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PostThreadLastPostUserNameAbsolute = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PostThreadPosts = table.Column<int>(type: "int", nullable: true),
                    PostThreadPostsAbsolute = table.Column<int>(type: "int", nullable: true),
                    PostTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PostType = table.Column<int>(type: "int", nullable: true),
                    PostUserMail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    PostUserName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, defaultValueSql: "('')"),
                    PostUserSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostViews = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums_ForumPost", x => x.PostId)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Forums_ForumPost_PostApprovedByUserID_CMS_User",
                        column: x => x.PostApprovedByUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                    table.ForeignKey(
                        name: "FK_Forums_ForumPost_PostForumID_Forums_Forum",
                        column: x => x.PostForumID,
                        principalSchema: "dbo",
                        principalTable: "Forums_Forum",
                        principalColumn: "ForumID");
                    table.ForeignKey(
                        name: "FK_Forums_ForumPost_PostParentID_Forums_ForumPost",
                        column: x => x.PostParentID,
                        principalSchema: "dbo",
                        principalTable: "Forums_ForumPost",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "FK_Forums_ForumPost_PostUserID_CMS_User",
                        column: x => x.PostUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Forums_ForumRoles",
                schema: "dbo",
                columns: table => new
                {
                    ForumID = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    PermissionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums_ForumRoles", x => new { x.ForumID, x.RoleID, x.PermissionID });
                    table.ForeignKey(
                        name: "FK_Forums_ForumRoles_ForumID_Forums_Forum",
                        column: x => x.ForumID,
                        principalSchema: "dbo",
                        principalTable: "Forums_Forum",
                        principalColumn: "ForumID");
                    table.ForeignKey(
                        name: "FK_Forums_ForumRoles_PermissionID_CMS_Permission",
                        column: x => x.PermissionID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Permission",
                        principalColumn: "PermissionID");
                    table.ForeignKey(
                        name: "FK_Forums_ForumRoles_RoleID_CMS_Role",
                        column: x => x.RoleID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Role",
                        principalColumn: "RoleID");
                });

            migrationBuilder.CreateTable(
                name: "Forums_Attachment",
                schema: "dbo",
                columns: table => new
                {
                    AttachmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentPostID = table.Column<int>(type: "int", nullable: false),
                    AttachmentSiteID = table.Column<int>(type: "int", nullable: false),
                    AttachmentBinary = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AttachmentFileExtension = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AttachmentFileName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AttachmentFileSize = table.Column<int>(type: "int", nullable: false),
                    AttachmentGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttachmentImageHeight = table.Column<int>(type: "int", nullable: true),
                    AttachmentImageWidth = table.Column<int>(type: "int", nullable: true),
                    AttachmentLastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttachmentMimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums_Attachment", x => x.AttachmentID);
                    table.ForeignKey(
                        name: "FK_Forums_Attachment_AttachmentPostID_Forums_ForumPost",
                        column: x => x.AttachmentPostID,
                        principalSchema: "dbo",
                        principalTable: "Forums_ForumPost",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "FK_Forums_Attachment_AttachmentSiteID_CMS_Site",
                        column: x => x.AttachmentSiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                });

            migrationBuilder.CreateTable(
                name: "Forums_ForumSubscription",
                schema: "dbo",
                columns: table => new
                {
                    SubscriptionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionForumID = table.Column<int>(type: "int", nullable: false),
                    SubscriptionPostID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionUserID = table.Column<int>(type: "int", nullable: true),
                    SubscriptionApprovalHash = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SubscriptionApproved = table.Column<bool>(type: "bit", nullable: true),
                    SubscriptionEmail = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true),
                    SubscriptionGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubscriptionLastModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums_ForumSubscription", x => x.SubscriptionID)
                        .Annotation("SqlServer:Clustered", false);
                    table.ForeignKey(
                        name: "FK_Forums_ForumSubscription_SubscriptionForumID_Forums_Forum",
                        column: x => x.SubscriptionForumID,
                        principalSchema: "dbo",
                        principalTable: "Forums_Forum",
                        principalColumn: "ForumID");
                    table.ForeignKey(
                        name: "FK_Forums_ForumSubscription_SubscriptionPostID_Forums_ForumPost",
                        column: x => x.SubscriptionPostID,
                        principalSchema: "dbo",
                        principalTable: "Forums_ForumPost",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "FK_Forums_ForumSubscription_SubscriptionUserID_CMS_User",
                        column: x => x.SubscriptionUserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateTable(
                name: "Forums_UserFavorites",
                schema: "dbo",
                columns: table => new
                {
                    FavoriteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ForumID = table.Column<int>(type: "int", nullable: true),
                    PostID = table.Column<int>(type: "int", nullable: true),
                    SiteID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FavoriteGUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FavoriteLastModified = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "('12/4/2008 3:23:57 PM')"),
                    FavoriteName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forums_UserFavorites", x => x.FavoriteID);
                    table.ForeignKey(
                        name: "FK_Forums_UserFavorites_ForumID_Forums_Forum",
                        column: x => x.ForumID,
                        principalSchema: "dbo",
                        principalTable: "Forums_Forum",
                        principalColumn: "ForumID");
                    table.ForeignKey(
                        name: "FK_Forums_UserFavorites_PostID_Forums_ForumPost",
                        column: x => x.PostID,
                        principalSchema: "dbo",
                        principalTable: "Forums_ForumPost",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "FK_Forums_UserFavorites_SiteID_CMS_Site",
                        column: x => x.SiteID,
                        principalSchema: "dbo",
                        principalTable: "CMS_Site",
                        principalColumn: "SiteID");
                    table.ForeignKey(
                        name: "FK_Forums_UserFavorites_UserID_CMS_User",
                        column: x => x.UserID,
                        principalSchema: "dbo",
                        principalTable: "CMS_User",
                        principalColumn: "UserID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_Campaign_CampaignScheduledTaskID",
                schema: "dbo",
                table: "Analytics_Campaign",
                column: "CampaignScheduledTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_Campaign_CampaignSiteID",
                schema: "dbo",
                table: "Analytics_Campaign",
                column: "CampaignSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_CampaignAsset_CampaignAssetCampaignID",
                schema: "dbo",
                table: "Analytics_CampaignAsset",
                column: "CampaignAssetCampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_CampaignAssetUrl_CampaignAssetUrlCampaignAssetID",
                schema: "dbo",
                table: "Analytics_CampaignAssetUrl",
                column: "CampaignAssetUrlCampaignAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_CampaignConversion_CampaignConversionCampaignID",
                schema: "dbo",
                table: "Analytics_CampaignConversion",
                column: "CampaignConversionCampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_CampaignConversionHits_CampaignConversionHitsConversionID",
                schema: "dbo",
                table: "Analytics_CampaignConversionHits",
                column: "CampaignConversionHitsConversionID");

            migrationBuilder.CreateIndex(
                name: "CK_Analytics_CampaignObjective_CampaignObjectiveCampaignID",
                schema: "dbo",
                table: "Analytics_CampaignObjective",
                column: "CampaignObjectiveCampaignID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_CampaignObjective_CampaignObjectiveCampaignConversionID",
                schema: "dbo",
                table: "Analytics_CampaignObjective",
                column: "CampaignObjectiveCampaignConversionID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_Conversion_ConversionSiteID",
                schema: "dbo",
                table: "Analytics_Conversion",
                column: "ConversionSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_DayHits_HitsStartTime_HitsEndTime",
                schema: "dbo",
                table: "Analytics_DayHits",
                columns: new[] { "HitsStartTime", "HitsEndTime" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_DayHits_HitsStatisticsID",
                schema: "dbo",
                table: "Analytics_DayHits",
                column: "HitsStatisticsID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_ExitPages_ExitPageLastModified",
                schema: "dbo",
                table: "Analytics_ExitPages",
                column: "ExitPageLastModified");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_HourHits_HitsStartTime_HitsEndTime",
                schema: "dbo",
                table: "Analytics_HourHits",
                columns: new[] { "HitsStartTime", "HitsEndTime" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_HourHits_HitsStatisticsID",
                schema: "dbo",
                table: "Analytics_HourHits",
                column: "HitsStatisticsID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_MonthHits_HitsStartTime_HitsEndTime",
                schema: "dbo",
                table: "Analytics_MonthHits",
                columns: new[] { "HitsStartTime", "HitsEndTime" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_MonthHits_HitsStatisticsID",
                schema: "dbo",
                table: "Analytics_MonthHits",
                column: "HitsStatisticsID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_Statistics_StatisticsCode_StatisticsSiteID_StatisticsObjectID_StatisticsObjectCulture",
                schema: "dbo",
                table: "Analytics_Statistics",
                column: "StatisticsCode")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_Statistics_StatisticsSiteID",
                schema: "dbo",
                table: "Analytics_Statistics",
                column: "StatisticsSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_WeekHits_HitsStartTime_HitsEndTime",
                schema: "dbo",
                table: "Analytics_WeekHits",
                columns: new[] { "HitsStartTime", "HitsEndTime" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_WeekHits_HitsStatisticsID",
                schema: "dbo",
                table: "Analytics_WeekHits",
                column: "HitsStatisticsID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_WeekYearHits_HitsStatisticsID",
                schema: "dbo",
                table: "Analytics_YearHits",
                column: "HitsStatisticsID");

            migrationBuilder.CreateIndex(
                name: "IX_Analytics_YearHits_HitsStartTime_HitsEndTime",
                schema: "dbo",
                table: "Analytics_YearHits",
                columns: new[] { "HitsStartTime", "HitsEndTime" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_BadWords_Word_WordExpression",
                schema: "dbo",
                table: "BadWords_Word",
                column: "WordExpression")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_BadWords_Word_WordIsGlobal",
                schema: "dbo",
                table: "BadWords_Word",
                column: "WordIsGlobal");

            migrationBuilder.CreateIndex(
                name: "IX_BadWords_WordCulture_CultureID",
                schema: "dbo",
                table: "BadWords_WordCulture",
                column: "CultureID");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_Comment_CommentApprovedByUserID",
                schema: "dbo",
                table: "Blog_Comment",
                column: "CommentApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_Comment_CommentDate",
                schema: "dbo",
                table: "Blog_Comment",
                column: "CommentDate")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Blog_Comment_CommentPostDocumentID",
                schema: "dbo",
                table: "Blog_Comment",
                column: "CommentPostDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_Comment_CommentUserID",
                schema: "dbo",
                table: "Blog_Comment",
                column: "CommentUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_PostSubscription_SubscriptionPostDocumentID",
                schema: "dbo",
                table: "Blog_PostSubscription",
                column: "SubscriptionPostDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_PostSubscription_SubscriptionUserID",
                schema: "dbo",
                table: "Blog_PostSubscription",
                column: "SubscriptionUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Board_BoardDocumentID_BoardName",
                schema: "dbo",
                table: "Board_Board",
                columns: new[] { "BoardDocumentID", "BoardName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Board_Board_BoardGroupID_BoardName",
                schema: "dbo",
                table: "Board_Board",
                columns: new[] { "BoardGroupID", "BoardName" });

            migrationBuilder.CreateIndex(
                name: "IX_Board_Board_BoardSiteID",
                schema: "dbo",
                table: "Board_Board",
                column: "BoardSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Board_BoardUserID_BoardName",
                schema: "dbo",
                table: "Board_Board",
                columns: new[] { "BoardUserID", "BoardName" });

            migrationBuilder.CreateIndex(
                name: "IX_Board_Message_MessageApproved_MessageIsSpam",
                schema: "dbo",
                table: "Board_Message",
                columns: new[] { "MessageApproved", "MessageIsSpam" });

            migrationBuilder.CreateIndex(
                name: "IX_Board_Message_MessageApprovedByUserID",
                schema: "dbo",
                table: "Board_Message",
                column: "MessageApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Message_MessageBoardID_MessageGUID",
                schema: "dbo",
                table: "Board_Message",
                columns: new[] { "MessageBoardID", "MessageGUID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Board_Message_MessageInserted",
                schema: "dbo",
                table: "Board_Message",
                column: "MessageInserted")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Board_Message_MessageUserID",
                schema: "dbo",
                table: "Board_Message",
                column: "MessageUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Moderator_UserID",
                schema: "dbo",
                table: "Board_Moderator",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Role_RoleID",
                schema: "dbo",
                table: "Board_Role",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Subscription_SubscriptionBoardID",
                schema: "dbo",
                table: "Board_Subscription",
                column: "SubscriptionBoardID");

            migrationBuilder.CreateIndex(
                name: "IX_Board_Subscription_SubscriptionUserID",
                schema: "dbo",
                table: "Board_Subscription",
                column: "SubscriptionUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_InitiatedChatRequest_InitiatedChatRequestInitiatorChatUserID",
                schema: "dbo",
                table: "Chat_InitiatedChatRequest",
                column: "InitiatedChatRequestInitiatorChatUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_InitiatedChatRequest_InitiatedChatRequestUserID",
                schema: "dbo",
                table: "Chat_InitiatedChatRequest",
                column: "InitiatedChatRequestUserID");

            migrationBuilder.CreateIndex(
                name: "UQ_Chat_InitiatedChatRequest_RoomID",
                schema: "dbo",
                table: "Chat_InitiatedChatRequest",
                column: "InitiatedChatRequestRoomID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_Chat_InitiatedChatRequest_UserIDContactID",
                schema: "dbo",
                table: "Chat_InitiatedChatRequest",
                columns: new[] { "InitiatedChatRequestUserID", "InitiatedChatRequestContactID" },
                unique: true,
                filter: "[InitiatedChatRequestUserID] IS NOT NULL AND [InitiatedChatRequestContactID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Message_ChatMessageLastModified",
                schema: "dbo",
                table: "Chat_Message",
                column: "ChatMessageLastModified");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Message_ChatMessageRecipientID",
                schema: "dbo",
                table: "Chat_Message",
                column: "ChatMessageRecipientID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Message_ChatMessageRoomID",
                schema: "dbo",
                table: "Chat_Message",
                column: "ChatMessageRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Message_ChatMessageSystemMessageType",
                schema: "dbo",
                table: "Chat_Message",
                column: "ChatMessageSystemMessageType");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Message_ChatMessageUserID",
                schema: "dbo",
                table: "Chat_Message",
                column: "ChatMessageUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Notification_ChatNotificationReceiverID",
                schema: "dbo",
                table: "Chat_Notification",
                column: "ChatNotificationReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Notification_ChatNotificationRoomID",
                schema: "dbo",
                table: "Chat_Notification",
                column: "ChatNotificationRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Notification_ChatNotificationSenderID",
                schema: "dbo",
                table: "Chat_Notification",
                column: "ChatNotificationSenderID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Notification_ChatNotificationSiteID",
                schema: "dbo",
                table: "Chat_Notification",
                column: "ChatNotificationSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_OnlineSupport_ChatOnlineSupportChatUserID",
                schema: "dbo",
                table: "Chat_OnlineSupport",
                column: "ChatOnlineSupportChatUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_OnlineSupport_SiteID",
                schema: "dbo",
                table: "Chat_OnlineSupport",
                column: "ChatOnlineSupportSiteID");

            migrationBuilder.CreateIndex(
                name: "UQ_Chat_OnlineSupport_ChatUserID-SiteID",
                schema: "dbo",
                table: "Chat_OnlineSupport",
                columns: new[] { "ChatOnlineSupportChatUserID", "ChatOnlineSupportSiteID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chat_OnlineUser_ChatOnlineUserChatUserID",
                schema: "dbo",
                table: "Chat_OnlineUser",
                column: "ChatOnlineUserChatUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_OnlineUser_SiteID",
                schema: "dbo",
                table: "Chat_OnlineUser",
                column: "ChatOnlineUserSiteID");

            migrationBuilder.CreateIndex(
                name: "UQ_Chat_OnlineUser_SiteID-ChatUserID",
                schema: "dbo",
                table: "Chat_OnlineUser",
                columns: new[] { "ChatOnlineUserChatUserID", "ChatOnlineUserSiteID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Room_ChatRoomCreatedByChatUserID",
                schema: "dbo",
                table: "Chat_Room",
                column: "ChatRoomCreatedByChatUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Room_Enabled",
                schema: "dbo",
                table: "Chat_Room",
                column: "ChatRoomEnabled");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Room_IsSupport",
                schema: "dbo",
                table: "Chat_Room",
                column: "ChatRoomIsSupport");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Room_SiteID",
                schema: "dbo",
                table: "Chat_Room",
                column: "ChatRoomSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_RoomUser_ChatRoomUserChatUserID",
                schema: "dbo",
                table: "Chat_RoomUser",
                column: "ChatRoomUserChatUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_RoomUser_ChatRoomUserRoomID",
                schema: "dbo",
                table: "Chat_RoomUser",
                column: "ChatRoomUserRoomID");

            migrationBuilder.CreateIndex(
                name: "UQ_Chat_RoomUser_RoomID-ChatUserID",
                schema: "dbo",
                table: "Chat_RoomUser",
                columns: new[] { "ChatRoomUserRoomID", "ChatRoomUserChatUserID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chat_SupportCannedResponse_ChatSupportCannedResponseChatUserID",
                schema: "dbo",
                table: "Chat_SupportCannedResponse",
                column: "ChatSupportCannedResponseChatUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_SupportCannedResponse_ChatSupportCannedResponseSiteID",
                schema: "dbo",
                table: "Chat_SupportCannedResponse",
                column: "ChatSupportCannedResponseSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_SupportTakenRoom_ChatSupportTakenRoomChatUserID",
                schema: "dbo",
                table: "Chat_SupportTakenRoom",
                column: "ChatSupportTakenRoomChatUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_SupportTakenRoom_ChatSupportTakenRoomRoomID",
                schema: "dbo",
                table: "Chat_SupportTakenRoom",
                column: "ChatSupportTakenRoomRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_User_UserID",
                schema: "dbo",
                table: "Chat_User",
                column: "ChatUserUserID");

            migrationBuilder.CreateIndex(
                name: "UQ_CI_FileMetadata_FileLocation",
                schema: "dbo",
                table: "CI_FileMetadata",
                column: "FileLocation",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CI_Migration_MigrationName",
                schema: "dbo",
                table: "CI_Migration",
                column: "MigrationName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AbuseReport_ReportSiteID",
                schema: "dbo",
                table: "CMS_AbuseReport",
                column: "ReportSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AbuseReport_ReportStatus",
                schema: "dbo",
                table: "CMS_AbuseReport",
                column: "ReportStatus");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AbuseReport_ReportUserID",
                schema: "dbo",
                table: "CMS_AbuseReport",
                column: "ReportUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AbuseReport_ReportWhen",
                schema: "dbo",
                table: "CMS_AbuseReport",
                column: "ReportWhen")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ACL_ACLInheritedACLs",
                schema: "dbo",
                table: "CMS_ACL",
                column: "ACLInheritedACLs");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ACL_ACLSiteID",
                schema: "dbo",
                table: "CMS_ACL",
                column: "ACLSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ACLItem_ACLID",
                schema: "dbo",
                table: "CMS_ACLItem",
                column: "ACLID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ACLItem_LastModifiedByUserID",
                schema: "dbo",
                table: "CMS_ACLItem",
                column: "LastModifiedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ACLItem_RoleID",
                schema: "dbo",
                table: "CMS_ACLItem",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ACLItem_UserID",
                schema: "dbo",
                table: "CMS_ACLItem",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AllowedChildClasses_ChildClassID",
                schema: "dbo",
                table: "CMS_AllowedChildClasses",
                column: "ChildClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AlternativeForm_FormClassID_FormName",
                schema: "dbo",
                table: "CMS_AlternativeForm",
                columns: new[] { "FormClassID", "FormName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AlternativeForm_FormCoupledClassID",
                schema: "dbo",
                table: "CMS_AlternativeForm",
                column: "FormCoupledClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AlternativeUrl_AlternativeUrlDocumentID",
                schema: "dbo",
                table: "CMS_AlternativeUrl",
                column: "AlternativeUrlDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AlternativeUrl_AlternativeUrlSiteID_AlternativeUrlUrl",
                schema: "dbo",
                table: "CMS_AlternativeUrl",
                columns: new[] { "AlternativeUrlSiteID", "AlternativeUrlUrl" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Attachment_AttachmentDocumentID",
                schema: "dbo",
                table: "CMS_Attachment",
                column: "AttachmentDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Attachment_AttachmentDocumentID_AttachmentIsUnsorted_AttachmentName_AttachmentOrder",
                schema: "dbo",
                table: "CMS_Attachment",
                columns: new[] { "AttachmentDocumentID", "AttachmentName", "AttachmentIsUnsorted", "AttachmentOrder" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Attachment_AttachmentGUID_AttachmentSiteID",
                schema: "dbo",
                table: "CMS_Attachment",
                columns: new[] { "AttachmentGUID", "AttachmentSiteID" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Attachment_AttachmentIsUnsorted_AttachmentGroupGUID_AttachmentFormGUID_AttachmentOrder",
                schema: "dbo",
                table: "CMS_Attachment",
                columns: new[] { "AttachmentIsUnsorted", "AttachmentGroupGUID", "AttachmentFormGUID", "AttachmentOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Attachment_AttachmentSiteID",
                schema: "dbo",
                table: "CMS_Attachment",
                column: "AttachmentSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Attachment_AttachmentVariantParentID",
                schema: "dbo",
                table: "CMS_Attachment",
                column: "AttachmentVariantParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Attachment_AttachmentVariantParentID_AttachmentVariantDefinitionIdentifier",
                schema: "dbo",
                table: "CMS_Attachment",
                columns: new[] { "AttachmentVariantDefinitionIdentifier", "AttachmentVariantParentID" },
                unique: true,
                filter: "([AttachmentVariantDefinitionIdentifier] IS NOT NULL AND [AttachmentVariantParentID] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AttachmentForEmail_AttachmentID",
                schema: "dbo",
                table: "CMS_AttachmentForEmail",
                column: "AttachmentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AttachmentHistory_AttachmentDocumentID_AttachmentName",
                schema: "dbo",
                table: "CMS_AttachmentHistory",
                columns: new[] { "AttachmentDocumentID", "AttachmentName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AttachmentHistory_AttachmentGUID",
                schema: "dbo",
                table: "CMS_AttachmentHistory",
                column: "AttachmentGUID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AttachmentHistory_AttachmentIsUnsorted_AttachmentGroupGUID_AttachmentOrder",
                schema: "dbo",
                table: "CMS_AttachmentHistory",
                columns: new[] { "AttachmentIsUnsorted", "AttachmentGroupGUID", "AttachmentOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AttachmentHistory_AttachmentSiteID",
                schema: "dbo",
                table: "CMS_AttachmentHistory",
                column: "AttachmentSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AttachmentHistory_AttachmentVariantParentID",
                schema: "dbo",
                table: "CMS_AttachmentHistory",
                column: "AttachmentVariantParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AttachmentHistory_AttachmentVariantParentID_AttachmentVariantDefinitionIdentifier",
                schema: "dbo",
                table: "CMS_AttachmentHistory",
                columns: new[] { "AttachmentVariantDefinitionIdentifier", "AttachmentVariantParentID" },
                unique: true,
                filter: "([AttachmentVariantDefinitionIdentifier] IS NOT NULL AND [AttachmentVariantParentID] IS NOT NULL)");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationHistory_HistoryApprovedByUserID",
                schema: "dbo",
                table: "CMS_AutomationHistory",
                column: "HistoryApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationHistory_HistoryApprovedWhen",
                schema: "dbo",
                table: "CMS_AutomationHistory",
                column: "HistoryApprovedWhen");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationHistory_HistoryStateID",
                schema: "dbo",
                table: "CMS_AutomationHistory",
                column: "HistoryStateID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationHistory_HistoryStepID",
                schema: "dbo",
                table: "CMS_AutomationHistory",
                column: "HistoryStepID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationHistory_HistoryTargetStepID",
                schema: "dbo",
                table: "CMS_AutomationHistory",
                column: "HistoryTargetStepID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationHistory_HistoryWorkflowID",
                schema: "dbo",
                table: "CMS_AutomationHistory",
                column: "HistoryWorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationState_StateObjectID_StateObjectType",
                schema: "dbo",
                table: "CMS_AutomationState",
                columns: new[] { "StateObjectID", "StateObjectType" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationState_StateSiteID",
                schema: "dbo",
                table: "CMS_AutomationState",
                column: "StateSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationState_StateStepID",
                schema: "dbo",
                table: "CMS_AutomationState",
                column: "StateStepID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationState_StateUserID",
                schema: "dbo",
                table: "CMS_AutomationState",
                column: "StateUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_AutomationState_StateWorkflowID",
                schema: "dbo",
                table: "CMS_AutomationState",
                column: "StateWorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Avatar_AvatarGUID",
                schema: "dbo",
                table: "CMS_Avatar",
                column: "AvatarGUID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Avatar_AvatarName",
                schema: "dbo",
                table: "CMS_Avatar",
                column: "AvatarName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Avatar_AvatarType_AvatarIsCustom",
                schema: "dbo",
                table: "CMS_Avatar",
                columns: new[] { "AvatarType", "AvatarIsCustom" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Badge_BadgeTopLimit",
                schema: "dbo",
                table: "CMS_Badge",
                column: "BadgeTopLimit")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_BannedIP_IPAddressSiteID",
                schema: "dbo",
                table: "CMS_BannedIP",
                column: "IPAddressSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_BannedIP_IPAddressSiteID_IPAddress",
                schema: "dbo",
                table: "CMS_BannedIP",
                columns: new[] { "IPAddress", "IPAddressSiteID" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Banner_BannerCategoryID",
                schema: "dbo",
                table: "CMS_Banner",
                column: "BannerCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Banner_BannerSiteID",
                schema: "dbo",
                table: "CMS_Banner",
                column: "BannerSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_BannerCategory_BannerCategoryName_BannerCategorySiteID",
                schema: "dbo",
                table: "CMS_BannerCategory",
                columns: new[] { "BannerCategoryName", "BannerCategorySiteID" },
                unique: true,
                filter: "[BannerCategorySiteID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_BannerCategory_BannerCategorySiteID",
                schema: "dbo",
                table: "CMS_BannerCategory",
                column: "BannerCategorySiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Category_CategoryDisplayName_CategoryEnabled",
                schema: "dbo",
                table: "CMS_Category",
                columns: new[] { "CategoryDisplayName", "CategoryEnabled" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Category_CategorySiteID",
                schema: "dbo",
                table: "CMS_Category",
                column: "CategorySiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Category_CategoryUserID",
                schema: "dbo",
                table: "CMS_Category",
                column: "CategoryUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Class_ClassDefaultPageTemplateID",
                schema: "dbo",
                table: "CMS_Class",
                column: "ClassDefaultPageTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Class_ClassID_ClassName_ClassDisplayName",
                schema: "dbo",
                table: "CMS_Class",
                columns: new[] { "ClassID", "ClassName", "ClassDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Class_ClassName",
                schema: "dbo",
                table: "CMS_Class",
                column: "ClassName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Class_ClassName_ClassGUID",
                schema: "dbo",
                table: "CMS_Class",
                columns: new[] { "ClassName", "ClassGUID" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Class_ClassPageTemplateCategoryID",
                schema: "dbo",
                table: "CMS_Class",
                column: "ClassPageTemplateCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Class_ClassResourceID",
                schema: "dbo",
                table: "CMS_Class",
                column: "ClassResourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Class_ClassShowAsSystemTable_ClassIsCustomTable_ClassIsCoupledClass_ClassIsDocumentType",
                schema: "dbo",
                table: "CMS_Class",
                columns: new[] { "ClassShowAsSystemTable", "ClassIsCustomTable", "ClassIsCoupledClass", "ClassIsDocumentType" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ClassSite_SiteID",
                schema: "dbo",
                table: "CMS_ClassSite",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ConsentAgreement_ConsentAgreementConsentID",
                schema: "dbo",
                table: "CMS_ConsentAgreement",
                column: "ConsentAgreementConsentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ConsentAgreement_ConsentAgreementContactID_ConsentAgreementConsentID",
                schema: "dbo",
                table: "CMS_ConsentAgreement",
                columns: new[] { "ConsentAgreementContactID", "ConsentAgreementConsentID" });

            migrationBuilder.CreateIndex(
                name: "IX_ConsentArchive_ConsentArchiveConsentID",
                schema: "dbo",
                table: "CMS_ConsentArchive",
                column: "ConsentArchiveConsentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Country_CountryDisplayName",
                schema: "dbo",
                table: "CMS_Country",
                column: "CountryDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_CssStylesheet_StylesheetDisplayName",
                schema: "dbo",
                table: "CMS_CssStylesheet",
                column: "StylesheetDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_CssStylesheet_StylesheetName",
                schema: "dbo",
                table: "CMS_CssStylesheet",
                column: "StylesheetName");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_CssStylesheetSite_SiteID",
                schema: "dbo",
                table: "CMS_CssStylesheetSite",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_CulturAlias",
                schema: "dbo",
                table: "CMS_Culture",
                column: "CultureAlias");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Culture_CultureCode",
                schema: "dbo",
                table: "CMS_Culture",
                column: "CultureCode");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Culture_CultureName",
                schema: "dbo",
                table: "CMS_Culture",
                column: "CultureName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DeviceProfileLayout_DeviceProfileID",
                schema: "dbo",
                table: "CMS_DeviceProfileLayout",
                column: "DeviceProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DeviceProfileLayout_SourceLayoutID",
                schema: "dbo",
                table: "CMS_DeviceProfileLayout",
                column: "SourceLayoutID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DeviceProfileLayout_TargetLayoutID",
                schema: "dbo",
                table: "CMS_DeviceProfileLayout",
                column: "TargetLayoutID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentCheckedOutByUserID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentCheckedOutByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentCheckedOutVersionHistoryID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentCheckedOutVersionHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentCreatedByUserID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentCreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentCulture",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentCulture");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentForeignKeyValue_DocumentID_DocumentNodeID",
                schema: "dbo",
                table: "CMS_Document",
                columns: new[] { "DocumentForeignKeyValue", "DocumentID", "DocumentNodeID" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentModifiedByUserID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentModifiedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentNodeID_DocumentID_DocumentCulture",
                schema: "dbo",
                table: "CMS_Document",
                columns: new[] { "DocumentNodeID", "DocumentID", "DocumentCulture" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentPageTemplateID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentPageTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentPublishedVersionHistoryID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentPublishedVersionHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentStylesheetID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentStylesheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentTagGroupID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentTagGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentUrlPath_DocumentID_DocumentNodeID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentUrlPath");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentWildcardRule_DocumentPriority",
                schema: "dbo",
                table: "CMS_Document",
                columns: new[] { "DocumentWildcardRule", "DocumentPriority" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_DocumentWorkflowStepID",
                schema: "dbo",
                table: "CMS_Document",
                column: "DocumentWorkflowStepID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Document_AliasCulture",
                schema: "dbo",
                table: "CMS_DocumentAlias",
                column: "AliasCulture");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DocumentAlias_AliasNodeID",
                schema: "dbo",
                table: "CMS_DocumentAlias",
                column: "AliasNodeID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DocumentAlias_AliasSiteID",
                schema: "dbo",
                table: "CMS_DocumentAlias",
                column: "AliasSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DocumentAlias_AliasURLPath",
                schema: "dbo",
                table: "CMS_DocumentAlias",
                column: "AliasURLPath")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DocumentAlias_AliasWildcardRule_AliasPriority",
                schema: "dbo",
                table: "CMS_DocumentAlias",
                columns: new[] { "AliasWildcardRule", "AliasPriority" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DocumentCategory_CategoryID",
                schema: "dbo",
                table: "CMS_DocumentCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DocumentTag_TagID",
                schema: "dbo",
                table: "CMS_DocumentTag",
                column: "TagID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DocumentTypeScope_ScopePath",
                schema: "dbo",
                table: "CMS_DocumentTypeScope",
                column: "ScopePath")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DocumentTypeScope_ScopeSiteID",
                schema: "dbo",
                table: "CMS_DocumentTypeScope",
                column: "ScopeSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_DocumentTypeScopeClass_ClassID",
                schema: "dbo",
                table: "CMS_DocumentTypeScopeClass",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Email_EmailPriority_EmailID",
                schema: "dbo",
                table: "CMS_Email",
                columns: new[] { "EmailPriority", "EmailID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_EmailTemplate_EmailTemplateDisplayName",
                schema: "dbo",
                table: "CMS_EmailTemplate",
                column: "EmailTemplateDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_EmailTemplate_EmailTemplateName_EmailTemplateSiteID",
                schema: "dbo",
                table: "CMS_EmailTemplate",
                columns: new[] { "EmailTemplateName", "EmailTemplateSiteID" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_EmailTemplate_EmailTemplateSiteID",
                schema: "dbo",
                table: "CMS_EmailTemplate",
                column: "EmailTemplateSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_EmailUser_Status",
                schema: "dbo",
                table: "CMS_EmailUser",
                column: "Status");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_EmailUser_UserID",
                schema: "dbo",
                table: "CMS_EmailUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_EventLog_SiteID",
                schema: "dbo",
                table: "CMS_EventLog",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ExternalLogin_UserID",
                schema: "dbo",
                table: "CMS_ExternalLogin",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Form_FormClassID",
                schema: "dbo",
                table: "CMS_Form",
                column: "FormClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Form_FormDisplayName",
                schema: "dbo",
                table: "CMS_Form",
                column: "FormDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Form_FormSiteID",
                schema: "dbo",
                table: "CMS_Form",
                column: "FormSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_FormRole_RoleID",
                schema: "dbo",
                table: "CMS_FormRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_FormUserControl_UserControlCodeName",
                schema: "dbo",
                table: "CMS_FormUserControl",
                column: "UserControlCodeName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_FormUserControl_UserControlDisplayName",
                schema: "dbo",
                table: "CMS_FormUserControl",
                column: "UserControlDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_FormUserControl_UserControlParentID",
                schema: "dbo",
                table: "CMS_FormUserControl",
                column: "UserControlParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_FormUserControl_UserControlResourceID",
                schema: "dbo",
                table: "CMS_FormUserControl",
                column: "UserControlResourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_HelpTopic_HelpTopicUIElementID",
                schema: "dbo",
                table: "CMS_HelpTopic",
                column: "HelpTopicUIElementID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Layout_LayoutDisplayName",
                schema: "dbo",
                table: "CMS_Layout",
                column: "LayoutDisplayName");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_LicenseKey_LicenseDomain",
                schema: "dbo",
                table: "CMS_LicenseKey",
                column: "LicenseDomain")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_MacroIdentity_MacroIdentityEffectiveUserID",
                schema: "dbo",
                table: "CMS_MacroIdentity",
                column: "MacroIdentityEffectiveUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Membership_MembershipSiteID",
                schema: "dbo",
                table: "CMS_Membership",
                column: "MembershipSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_MembershipRole_RoleID",
                schema: "dbo",
                table: "CMS_MembershipRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_MembershipUser_MembershipID_UserID",
                schema: "dbo",
                table: "CMS_MembershipUser",
                columns: new[] { "MembershipID", "UserID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_MembershipUser_UserID",
                schema: "dbo",
                table: "CMS_MembershipUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_MetaFile_MetaFileGUID_MetaFileSiteID_MetaFileObjectType_MetaFileObjectID_MetaFileGroupName",
                schema: "dbo",
                table: "CMS_MetaFile",
                columns: new[] { "MetaFileGUID", "MetaFileSiteID", "MetaFileObjectType", "MetaFileObjectID", "MetaFileGroupName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Metafile_MetaFileObjectType_MetaFileObjectID_MetaFileGroupName",
                schema: "dbo",
                table: "CMS_MetaFile",
                columns: new[] { "MetaFileObjectType", "MetaFileObjectID", "MetaFileGroupName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_MetaFile_MetaFileSiteID",
                schema: "dbo",
                table: "CMS_MetaFile",
                column: "MetaFileSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ModuleLicenseKey_ModuleLicenseKeyResourceID",
                schema: "dbo",
                table: "CMS_ModuleLicenseKey",
                column: "ModuleLicenseKeyResourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ModuleUsageCounter_ModuleUsageCounterName",
                schema: "dbo",
                table: "CMS_ModuleUsageCounter",
                column: "ModuleUsageCounterName",
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectSettings_ObjectCheckedOutByUserID",
                schema: "dbo",
                table: "CMS_ObjectSettings",
                column: "ObjectCheckedOutByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectSettings_ObjectCheckedOutVersionHistoryID",
                schema: "dbo",
                table: "CMS_ObjectSettings",
                column: "ObjectCheckedOutVersionHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectSettings_ObjectPublishedVersionHistoryID",
                schema: "dbo",
                table: "CMS_ObjectSettings",
                column: "ObjectPublishedVersionHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectSettings_ObjectSettingsObjectType_ObjectSettingsObjectID",
                schema: "dbo",
                table: "CMS_ObjectSettings",
                columns: new[] { "ObjectSettingsObjectID", "ObjectSettingsObjectType" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectSettings_ObjectWorkflowStepID",
                schema: "dbo",
                table: "CMS_ObjectSettings",
                column: "ObjectWorkflowStepID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectVersionHistory_VersionDeletedByUserID_VersionDeletedWhen",
                schema: "dbo",
                table: "CMS_ObjectVersionHistory",
                columns: new[] { "VersionDeletedByUserID", "VersionDeletedWhen" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectVersionHistory_VersionModifiedByUserID",
                schema: "dbo",
                table: "CMS_ObjectVersionHistory",
                column: "VersionModifiedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectVersionHistory_VersionObjectSiteID_VersionDeletedWhen",
                schema: "dbo",
                table: "CMS_ObjectVersionHistory",
                columns: new[] { "VersionObjectSiteID", "VersionDeletedWhen" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectVersionHistory_VersionObjectType_VersionObjectID_VersionModifiedWhen",
                schema: "dbo",
                table: "CMS_ObjectVersionHistory",
                columns: new[] { "VersionObjectType", "VersionObjectID", "VersionModifiedWhen" });

            migrationBuilder.CreateIndex(
                name: "PK_CMS_ObjectVersionHistory",
                schema: "dbo",
                table: "CMS_ObjectVersionHistory",
                columns: new[] { "VersionObjectType", "VersionObjectID", "VersionID" },
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ObjectWorkflowTrigger_TriggerWorkflowID",
                schema: "dbo",
                table: "CMS_ObjectWorkflowTrigger",
                column: "TriggerWorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_OpenIDUser_OpenID",
                schema: "dbo",
                table: "CMS_OpenIDUser",
                column: "OpenID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_OpenIDUser_UserID",
                schema: "dbo",
                table: "CMS_OpenIDUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplate_PageTemplateCategoryID",
                schema: "dbo",
                table: "CMS_PageTemplate",
                column: "PageTemplateCategoryID")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplate_PageTemplateCodeName_PageTemplateDisplayName",
                schema: "dbo",
                table: "CMS_PageTemplate",
                columns: new[] { "PageTemplateCodeName", "PageTemplateDisplayName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplate_PageTemplateIsReusable_PageTemplateForAllPages_PageTemplateShowAsMasterTemplate",
                schema: "dbo",
                table: "CMS_PageTemplate",
                columns: new[] { "PageTemplateIsReusable", "PageTemplateForAllPages", "PageTemplateShowAsMasterTemplate" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplate_PageTemplateLayoutID",
                schema: "dbo",
                table: "CMS_PageTemplate",
                column: "PageTemplateLayoutID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplate_PageTemplateSiteID_PageTemplateCodeName_PageTemplateGUID",
                schema: "dbo",
                table: "CMS_PageTemplate",
                columns: new[] { "PageTemplateSiteID", "PageTemplateCodeName", "PageTemplateGUID" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateCategory_CategoryLevel",
                schema: "dbo",
                table: "CMS_PageTemplateCategory",
                column: "CategoryLevel");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateCategory_CategoryParentID",
                schema: "dbo",
                table: "CMS_PageTemplateCategory",
                column: "CategoryParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateCategory_CategoryPath",
                schema: "dbo",
                table: "CMS_PageTemplateCategory",
                column: "CategoryPath",
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateConfiguration_PageTemplateConfigurationSiteID",
                schema: "dbo",
                table: "CMS_PageTemplateConfiguration",
                column: "PageTemplateConfigurationSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateScope_PageTemplateScopeClassID",
                schema: "dbo",
                table: "CMS_PageTemplateScope",
                column: "PageTemplateScopeClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateScope_PageTemplateScopeCultureID",
                schema: "dbo",
                table: "CMS_PageTemplateScope",
                column: "PageTemplateScopeCultureID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateScope_PageTemplateScopeLevels",
                schema: "dbo",
                table: "CMS_PageTemplateScope",
                column: "PageTemplateScopeLevels");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateScope_PageTemplateScopePath",
                schema: "dbo",
                table: "CMS_PageTemplateScope",
                column: "PageTemplateScopePath")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateScope_PageTemplateScopeSiteID",
                schema: "dbo",
                table: "CMS_PageTemplateScope",
                column: "PageTemplateScopeSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateScope_PageTemplateScopeTemplateID",
                schema: "dbo",
                table: "CMS_PageTemplateScope",
                column: "PageTemplateScopeTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_PageTemplateSite_SiteID",
                schema: "dbo",
                table: "CMS_PageTemplateSite",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Permission_ClassID_PermissionName",
                schema: "dbo",
                table: "CMS_Permission",
                columns: new[] { "ClassID", "PermissionName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Permission_ResourceID_PermissionName",
                schema: "dbo",
                table: "CMS_Permission",
                columns: new[] { "ResourceID", "PermissionName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Personalization_PersonalizationID_PersonalizationUserID_PersonalizationDocumentID_PersonalizationDashboardName",
                schema: "dbo",
                table: "CMS_Personalization",
                columns: new[] { "PersonalizationID", "PersonalizationUserID", "PersonalizationDocumentID", "PersonalizationDashboardName" },
                unique: true,
                filter: "[PersonalizationUserID] IS NOT NULL AND [PersonalizationDocumentID] IS NOT NULL AND [PersonalizationDashboardName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Personalization_PersonalizationSiteID_SiteID",
                schema: "dbo",
                table: "CMS_Personalization",
                column: "PersonalizationSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Personalization_PersonalizationUserID",
                schema: "dbo",
                table: "CMS_Personalization",
                column: "PersonalizationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Personalization_PersonalizationUserID_PersonalizationDocumentID",
                schema: "dbo",
                table: "CMS_Personalization",
                column: "PersonalizationDocumentID")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Query_QueryClassID_QueryName",
                schema: "dbo",
                table: "CMS_Query",
                columns: new[] { "ClassID", "QueryName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Relationship_LeftNodeID",
                schema: "dbo",
                table: "CMS_Relationship",
                column: "LeftNodeID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Relationship_RelationshipNameID",
                schema: "dbo",
                table: "CMS_Relationship",
                column: "RelationshipNameID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Relationship_RightNodeID",
                schema: "dbo",
                table: "CMS_Relationship",
                column: "RightNodeID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_RelationshipName_RelationshipAllowedObjects",
                schema: "dbo",
                table: "CMS_RelationshipName",
                column: "RelationshipAllowedObjects");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_RelationshipName_RelationshipName_RelationshipDisplayName",
                schema: "dbo",
                table: "CMS_RelationshipName",
                columns: new[] { "RelationshipName", "RelationshipDisplayName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_RelationshipNameSite_SiteID",
                schema: "dbo",
                table: "CMS_RelationshipNameSite",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Resource_ResourceDisplayName",
                schema: "dbo",
                table: "CMS_Resource",
                column: "ResourceDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Resource_ResourceName",
                schema: "dbo",
                table: "CMS_Resource",
                column: "ResourceName");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ResourceLibrary",
                schema: "dbo",
                table: "CMS_ResourceLibrary",
                column: "ResourceLibraryResourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ResourceSite_SiteID",
                schema: "dbo",
                table: "CMS_ResourceSite",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ResourceString_StringKey",
                schema: "dbo",
                table: "CMS_ResourceString",
                column: "StringKey");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ResourceTranslation_TranslationCultureID",
                schema: "dbo",
                table: "CMS_ResourceTranslation",
                column: "TranslationCultureID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ResourceTranslation_TranslationStringID",
                schema: "dbo",
                table: "CMS_ResourceTranslation",
                column: "TranslationStringID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Role_RoleGroupID",
                schema: "dbo",
                table: "CMS_Role",
                column: "RoleGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Role_SiteID_RoleID",
                schema: "dbo",
                table: "CMS_Role",
                columns: new[] { "SiteID", "RoleID" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Role_SiteID_RoleName_RoleDisplayName",
                schema: "dbo",
                table: "CMS_Role",
                columns: new[] { "SiteID", "RoleName", "RoleDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Role_SiteID_RoleName_RoleGroupID",
                schema: "dbo",
                table: "CMS_Role",
                columns: new[] { "SiteID", "RoleName", "RoleGroupID" },
                unique: true,
                filter: "[SiteID] IS NOT NULL AND [RoleGroupID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_RoleApplication",
                schema: "dbo",
                table: "CMS_RoleApplication",
                column: "ElementID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_RolePermission_PermissionID",
                schema: "dbo",
                table: "CMS_RolePermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_RoleUIElement_ElementID",
                schema: "dbo",
                table: "CMS_RoleUIElement",
                column: "ElementID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ScheduledTask_TaskNextRunTime_TaskEnabled_TaskServerName",
                schema: "dbo",
                table: "CMS_ScheduledTask",
                columns: new[] { "TaskNextRunTime", "TaskEnabled", "TaskServerName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ScheduledTask_TaskResourceID",
                schema: "dbo",
                table: "CMS_ScheduledTask",
                column: "TaskResourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ScheduledTask_TaskSiteID_TaskDisplayName",
                schema: "dbo",
                table: "CMS_ScheduledTask",
                columns: new[] { "TaskSiteID", "TaskDisplayName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_ScheduledTask_TaskUserID",
                schema: "dbo",
                table: "CMS_ScheduledTask",
                column: "TaskUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SearchIndex_IndexDisplayName",
                schema: "dbo",
                table: "CMS_SearchIndex",
                column: "IndexDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SearchIndexCulture_IndexCultureID",
                schema: "dbo",
                table: "CMS_SearchIndexCulture",
                column: "IndexCultureID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SearchIndexSite_IndexSiteID",
                schema: "dbo",
                table: "CMS_SearchIndexSite",
                column: "IndexSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SearchTask_SearchTaskPriority_SearchTaskStatus_SearchTaskServerName",
                schema: "dbo",
                table: "CMS_SearchTask",
                columns: new[] { "SearchTaskPriority", "SearchTaskStatus", "SearchTaskServerName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SearchTaskAzure_SearchTaskAzurePriority",
                schema: "dbo",
                table: "CMS_SearchTaskAzure",
                column: "SearchTaskAzurePriority");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Session_SessionIdentificator",
                schema: "dbo",
                table: "CMS_Session",
                column: "SessionIdentificator",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Session_SessionSiteID",
                schema: "dbo",
                table: "CMS_Session",
                column: "SessionSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Session_SessionUserID",
                schema: "dbo",
                table: "CMS_Session",
                column: "SessionUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Session_SessionUserIsHidden",
                schema: "dbo",
                table: "CMS_Session",
                column: "SessionUserIsHidden");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SettingsCategory_CategoryOrder",
                schema: "dbo",
                table: "CMS_SettingsCategory",
                column: "CategoryOrder")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SettingsCategory_CategoryParentID",
                schema: "dbo",
                table: "CMS_SettingsCategory",
                column: "CategoryParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SettingsCategory_CategoryResourceID",
                schema: "dbo",
                table: "CMS_SettingsCategory",
                column: "CategoryResourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SettingsKey_KeyCategoryID",
                schema: "dbo",
                table: "CMS_SettingsKey",
                column: "KeyCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SettingsKey_SiteID_KeyName",
                schema: "dbo",
                table: "CMS_SettingsKey",
                columns: new[] { "SiteID", "KeyName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Site_SiteDefaultEditorStylesheet",
                schema: "dbo",
                table: "CMS_Site",
                column: "SiteDefaultEditorStylesheet");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Site_SiteDefaultStylesheetID",
                schema: "dbo",
                table: "CMS_Site",
                column: "SiteDefaultStylesheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Site_SiteDisplayName",
                schema: "dbo",
                table: "CMS_Site",
                column: "SiteDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Site_SiteDomainName_SiteStatus",
                schema: "dbo",
                table: "CMS_Site",
                columns: new[] { "SiteDomainName", "SiteStatus" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Site_SiteName",
                schema: "dbo",
                table: "CMS_Site",
                column: "SiteName");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SiteCulture_CultureID",
                schema: "dbo",
                table: "CMS_SiteCulture",
                column: "CultureID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SiteDomainAlias_SiteDomainAliasName",
                schema: "dbo",
                table: "CMS_SiteDomainAlias",
                column: "SiteDomainAliasName");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SiteDomainAlias_SiteID",
                schema: "dbo",
                table: "CMS_SiteDomainAlias",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_SMTPServerSite_SiteID",
                schema: "dbo",
                table: "CMS_SMTPServerSite",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_State_CountryID",
                schema: "dbo",
                table: "CMS_State",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_State_CountryID_StateDisplayName",
                schema: "dbo",
                table: "CMS_State",
                column: "StateDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_State_StateCode",
                schema: "dbo",
                table: "CMS_State",
                column: "StateCode");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tag_TagGroupID",
                schema: "dbo",
                table: "CMS_Tag",
                column: "TagGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tag_TagName",
                schema: "dbo",
                table: "CMS_Tag",
                column: "TagName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_TagGroup_TagGroupDisplayName",
                schema: "dbo",
                table: "CMS_TagGroup",
                column: "TagGroupDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_TagGroup_TagGroupSiteID",
                schema: "dbo",
                table: "CMS_TagGroup",
                column: "TagGroupSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_TemplateDeviceLayout_LayoutID",
                schema: "dbo",
                table: "CMS_TemplateDeviceLayout",
                column: "LayoutID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_TemplateDeviceLayout_PageTemplateID_ProfileID",
                schema: "dbo",
                table: "CMS_TemplateDeviceLayout",
                columns: new[] { "PageTemplateID", "ProfileID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_TemplateDeviceLayout_ProfileID",
                schema: "dbo",
                table: "CMS_TemplateDeviceLayout",
                column: "ProfileID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_TimeZone_TimeZoneDisplayName",
                schema: "dbo",
                table: "CMS_TimeZone",
                column: "TimeZoneDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Transformation_TransformationClassID",
                schema: "dbo",
                table: "CMS_Transformation",
                column: "TransformationClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Transformation_TransformationClassID_TransformationName",
                schema: "dbo",
                table: "CMS_Transformation",
                columns: new[] { "TransformationClassID", "TransformationName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_TranslationSubmission_SubmissionServiceID",
                schema: "dbo",
                table: "CMS_TranslationSubmission",
                column: "SubmissionServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_TranslationSubmission_SubmissionSubmittedByUserID",
                schema: "dbo",
                table: "CMS_TranslationSubmission",
                column: "SubmissionSubmittedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_TranslationSubmissionItem_SubmissionItemSubmissionID",
                schema: "dbo",
                table: "CMS_TranslationSubmissionItem",
                column: "SubmissionItemSubmissionID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeACLID",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeACLID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeAliasPath",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeAliasPath");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeClassID",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeGroupID",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeLevel",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeLevel");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeLinkedNodeID",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeLinkedNodeID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeLinkedNodeSiteID",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeLinkedNodeSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeOriginalNodeID",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeOriginalNodeID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeOwner",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeOwner");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeParentID_NodeAlias_NodeName",
                schema: "dbo",
                table: "CMS_Tree",
                columns: new[] { "NodeParentID", "NodeAlias", "NodeName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeSiteID_NodeGUID",
                schema: "dbo",
                table: "CMS_Tree",
                columns: new[] { "NodeSiteID", "NodeGUID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeSKUID",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeSKUID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Tree_NodeTemplateID",
                schema: "dbo",
                table: "CMS_Tree",
                column: "NodeTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UIElement_ElementGUID",
                schema: "dbo",
                table: "CMS_UIElement",
                column: "ElementGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UIElement_ElementPageTemplateID",
                schema: "dbo",
                table: "CMS_UIElement",
                column: "ElementPageTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UIElement_ElementParentID",
                schema: "dbo",
                table: "CMS_UIElement",
                column: "ElementParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UIElement_ElementResourceID_ElementLevel_ElementParentID_ElementOrder_ElementCaption",
                schema: "dbo",
                table: "CMS_UIElement",
                columns: new[] { "ElementResourceID", "ElementLevel", "ElementParentID", "ElementOrder", "ElementCaption" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_User_Email",
                schema: "dbo",
                table: "CMS_User",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_User_FullName",
                schema: "dbo",
                table: "CMS_User",
                column: "FullName");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_User_UserEnabled_UserIsHidden",
                schema: "dbo",
                table: "CMS_User",
                columns: new[] { "UserEnabled", "UserIsHidden" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_User_UserGUID",
                schema: "dbo",
                table: "CMS_User",
                column: "UserGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_User_UserName",
                schema: "dbo",
                table: "CMS_User",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_User_UserPrivilegeLevel",
                schema: "dbo",
                table: "CMS_User",
                column: "UserPrivilegeLevel");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserCulture_CultureID",
                schema: "dbo",
                table: "CMS_UserCulture",
                column: "CultureID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserCulture_SiteID",
                schema: "dbo",
                table: "CMS_UserCulture",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserMacroIdentity_UserMacroIdentityMacroIdentityID",
                schema: "dbo",
                table: "CMS_UserMacroIdentity",
                column: "UserMacroIdentityMacroIdentityID");

            migrationBuilder.CreateIndex(
                name: "UQ_CMS_UserMacroIdentity_UserMacroIdentityUserID",
                schema: "dbo",
                table: "CMS_UserMacroIdentity",
                column: "UserMacroIdentityUserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserRole_RoleID",
                schema: "dbo",
                table: "CMS_UserRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserRole_UserID",
                schema: "dbo",
                table: "CMS_UserRole",
                columns: new[] { "RoleID", "ValidTo", "UserID" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserRole_UserID_RoleID",
                schema: "dbo",
                table: "CMS_UserRole",
                columns: new[] { "UserID", "RoleID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserActivatedByUserID",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserActivatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserAuthenticationGUID",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserAuthenticationGUID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserAvatarID",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserAvatarID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserBadgeID",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserBadgeID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserFacebookID",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserFacebookID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserGender",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserGender");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserNickName",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserNickName");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserPasswordRequestHash",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserPasswordRequestHash");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserSettingsUserGUID",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserSettingsUserGUID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserSettingsUserID",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserSettingsUserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserTimeZoneID",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserTimeZoneID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_UserWaitingForApproval",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "UserWaitingForApproval");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSettings_WindowsLiveID",
                schema: "dbo",
                table: "CMS_UserSettings",
                column: "WindowsLiveID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSite_SiteID",
                schema: "dbo",
                table: "CMS_UserSite",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_UserSite_UserID_SiteID",
                schema: "dbo",
                table: "CMS_UserSite",
                columns: new[] { "UserID", "SiteID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_VersionAttachment_AttachmentHistoryID",
                schema: "dbo",
                table: "CMS_VersionAttachment",
                column: "AttachmentHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_VersionHistory_DocumentID",
                schema: "dbo",
                table: "CMS_VersionHistory",
                column: "DocumentID")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_VersionHistory_ModifiedByUserID",
                schema: "dbo",
                table: "CMS_VersionHistory",
                column: "ModifiedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_VersionHistory_NodeSiteID",
                schema: "dbo",
                table: "CMS_VersionHistory",
                column: "NodeSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_VersionHistory_ToBePublished_PublishFrom_PublishTo",
                schema: "dbo",
                table: "CMS_VersionHistory",
                columns: new[] { "ToBePublished", "PublishFrom", "PublishTo" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_VersionHistory_VersionClassID",
                schema: "dbo",
                table: "CMS_VersionHistory",
                column: "VersionClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_VersionHistory_VersionDeletedByUserID_VersionDeletedWhen",
                schema: "dbo",
                table: "CMS_VersionHistory",
                columns: new[] { "VersionDeletedByUserID", "VersionDeletedWhen" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_VersionHistory_VersionWorkflowID",
                schema: "dbo",
                table: "CMS_VersionHistory",
                column: "VersionWorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_VersionHistory_VersionWorkflowStepID",
                schema: "dbo",
                table: "CMS_VersionHistory",
                column: "VersionWorkflowStepID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebFarmServer_ServerDisplayName",
                schema: "dbo",
                table: "CMS_WebFarmServer",
                column: "ServerDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebFarmServer_ServerName",
                schema: "dbo",
                table: "CMS_WebFarmServer",
                column: "ServerName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebFarmServerTask_TaskID",
                schema: "dbo",
                table: "CMS_WebFarmServerTask",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebFarmTask_TaskIsMemory_TaskCreated",
                schema: "dbo",
                table: "CMS_WebFarmTask",
                columns: new[] { "TaskIsMemory", "TaskCreated" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPart_WebPartCategoryID",
                schema: "dbo",
                table: "CMS_WebPart",
                column: "WebPartCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPart_WebPartName",
                schema: "dbo",
                table: "CMS_WebPart",
                column: "WebPartName");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPart_WebPartParentID",
                schema: "dbo",
                table: "CMS_WebPart",
                column: "WebPartParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPart_WebPartResourceID",
                schema: "dbo",
                table: "CMS_WebPart",
                column: "WebPartResourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPartCategory_CategoryParentID",
                schema: "dbo",
                table: "CMS_WebPartCategory",
                column: "CategoryParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPartCategory_CategoryPath",
                schema: "dbo",
                table: "CMS_WebPartCategory",
                column: "CategoryPath",
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPartContainer_ContainerDisplayName",
                schema: "dbo",
                table: "CMS_WebPartContainer",
                column: "ContainerDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPartContainer_ContainerName",
                schema: "dbo",
                table: "CMS_WebPartContainer",
                column: "ContainerName");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPartContainerSite_SiteID",
                schema: "dbo",
                table: "CMS_WebPartContainerSite",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPartLayout_WebPartLayoutWebPartID",
                schema: "dbo",
                table: "CMS_WebPartLayout",
                column: "WebPartLayoutWebPartID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebPartLayout_WebPartLayoutWebPartID_WebPartLayoutCodeName",
                schema: "dbo",
                table: "CMS_WebPartLayout",
                columns: new[] { "WebPartLayoutWebPartID", "WebPartLayoutCodeName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WebTemplate_WebTemplateOrder",
                schema: "dbo",
                table: "CMS_WebTemplate",
                column: "WebTemplateOrder")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Widget_WidgetCategoryID",
                schema: "dbo",
                table: "CMS_Widget",
                column: "WidgetCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Widget_WidgetCategoryID_WidgetDisplayName",
                schema: "dbo",
                table: "CMS_Widget",
                columns: new[] { "WidgetCategoryID", "WidgetDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Widget_WidgetIsEnabled_WidgetForGroup_WidgetForEditor_WidgetForUser",
                schema: "dbo",
                table: "CMS_Widget",
                columns: new[] { "WidgetIsEnabled", "WidgetForGroup", "WidgetForEditor", "WidgetForUser" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Widget_WidgetLayoutID",
                schema: "dbo",
                table: "CMS_Widget",
                column: "WidgetLayoutID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Widget_WidgetWebPartID",
                schema: "dbo",
                table: "CMS_Widget",
                column: "WidgetWebPartID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WidgetCategory_CategoryPath",
                schema: "dbo",
                table: "CMS_WidgetCategory",
                column: "WidgetCategoryPath",
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WidgetCategory_WidgetCategoryParentID",
                schema: "dbo",
                table: "CMS_WidgetCategory",
                column: "WidgetCategoryParentID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WidgetRole_PermissionID",
                schema: "dbo",
                table: "CMS_WidgetRole",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WidgetRole_RoleID",
                schema: "dbo",
                table: "CMS_WidgetRole",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_Workflow_WorkflowDisplayName",
                schema: "dbo",
                table: "CMS_Workflow",
                column: "WorkflowDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowAction_ActionResourceID",
                schema: "dbo",
                table: "CMS_WorkflowAction",
                column: "ActionResourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowHistory_ApprovedByUserID",
                schema: "dbo",
                table: "CMS_WorkflowHistory",
                column: "ApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowHistory_ApprovedWhen",
                schema: "dbo",
                table: "CMS_WorkflowHistory",
                column: "ApprovedWhen");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowHistory_HistoryWorkflowID",
                schema: "dbo",
                table: "CMS_WorkflowHistory",
                column: "HistoryWorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowHistory_StepID",
                schema: "dbo",
                table: "CMS_WorkflowHistory",
                column: "StepID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowHistory_TargetStepID",
                schema: "dbo",
                table: "CMS_WorkflowHistory",
                column: "TargetStepID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowHistory_VersionHistoryID",
                schema: "dbo",
                table: "CMS_WorkflowHistory",
                column: "VersionHistoryID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowScope_ScopeClassID",
                schema: "dbo",
                table: "CMS_WorkflowScope",
                column: "ScopeClassID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowScope_ScopeCultureID",
                schema: "dbo",
                table: "CMS_WorkflowScope",
                column: "ScopeCultureID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowScope_ScopeSiteID",
                schema: "dbo",
                table: "CMS_WorkflowScope",
                column: "ScopeSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowScope_ScopeStartingPath",
                schema: "dbo",
                table: "CMS_WorkflowScope",
                column: "ScopeStartingPath")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowScope_ScopeWorkflowID",
                schema: "dbo",
                table: "CMS_WorkflowScope",
                column: "ScopeWorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowStep_StepActionID",
                schema: "dbo",
                table: "CMS_WorkflowStep",
                column: "StepActionID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowStep_StepID_StepName",
                schema: "dbo",
                table: "CMS_WorkflowStep",
                columns: new[] { "StepID", "StepName" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowStep_StepWorkflowID_StepName",
                schema: "dbo",
                table: "CMS_WorkflowStep",
                columns: new[] { "StepWorkflowID", "StepName" },
                unique: true,
                filter: "[StepName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowStep_StepWorkflowID_StepOrder",
                schema: "dbo",
                table: "CMS_WorkflowStep",
                columns: new[] { "StepWorkflowID", "StepOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowStepRoles_RoleID",
                schema: "dbo",
                table: "CMS_WorkflowStepRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowStepRoles_StepID_StepSourcePointGUID_RoleID",
                schema: "dbo",
                table: "CMS_WorkflowStepRoles",
                columns: new[] { "StepID", "StepSourcePointGUID", "RoleID" },
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowStepUser_StepID_StepSourcePointGUID_UserID",
                schema: "dbo",
                table: "CMS_WorkflowStepUser",
                columns: new[] { "StepID", "StepSourcePointGUID", "UserID" },
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowStepUser_UserID",
                schema: "dbo",
                table: "CMS_WorkflowStepUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowTransition_TransitionEndStepID",
                schema: "dbo",
                table: "CMS_WorkflowTransition",
                column: "TransitionEndStepID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowTransition_TransitionStartStepID_TransitionSourcePointGUID_TransitionEndStepID",
                schema: "dbo",
                table: "CMS_WorkflowTransition",
                columns: new[] { "TransitionStartStepID", "TransitionSourcePointGUID", "TransitionEndStepID" },
                unique: true,
                filter: "[TransitionSourcePointGUID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowTransition_TransitionWorkflowID",
                schema: "dbo",
                table: "CMS_WorkflowTransition",
                column: "TransitionWorkflowID");

            migrationBuilder.CreateIndex(
                name: "IX_CMS_WorkflowUser_UserID",
                schema: "dbo",
                table: "CMS_WorkflowUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Address_AddressCountryID",
                schema: "dbo",
                table: "COM_Address",
                column: "AddressCountryID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Address_AddressCustomerID",
                schema: "dbo",
                table: "COM_Address",
                column: "AddressCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Address_AddressStateID",
                schema: "dbo",
                table: "COM_Address",
                column: "AddressStateID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Brand_BrandDisplayName",
                schema: "dbo",
                table: "COM_Brand",
                column: "BrandDisplayName");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Brand_BrandSiteID_BrandEnabled",
                schema: "dbo",
                table: "COM_Brand",
                columns: new[] { "BrandSiteID", "BrandEnabled" });

            migrationBuilder.CreateIndex(
                name: "IX_COM_Bundle_SKUID",
                schema: "dbo",
                table: "COM_Bundle",
                column: "SKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Carrier_CarrierSiteID",
                schema: "dbo",
                table: "COM_Carrier",
                column: "CarrierSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Collection_CollectionDisplayName",
                schema: "dbo",
                table: "COM_Collection",
                column: "CollectionDisplayName");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Collection_CollectionSiteID_CollectionEnabled",
                schema: "dbo",
                table: "COM_Collection",
                columns: new[] { "CollectionSiteID", "CollectionEnabled" });

            migrationBuilder.CreateIndex(
                name: "IX_COM_CouponCode_CouponCodeDiscountID",
                schema: "dbo",
                table: "COM_CouponCode",
                column: "CouponCodeDiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Currency_CurrencyDisplayName",
                schema: "dbo",
                table: "COM_Currency",
                column: "CurrencyDisplayName");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Currency_CurrencySiteID",
                schema: "dbo",
                table: "COM_Currency",
                column: "CurrencySiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_CurrencyExchangeRate_ExchangeRateToCurrencyID",
                schema: "dbo",
                table: "COM_CurrencyExchangeRate",
                column: "ExchangeRateToCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_CurrencyExchangeRate_ExchangeTableID",
                schema: "dbo",
                table: "COM_CurrencyExchangeRate",
                column: "ExchangeTableID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Customer_CustomerCompany",
                schema: "dbo",
                table: "COM_Customer",
                column: "CustomerCompany",
                filter: "([CustomerCompany] IS NOT NULL)")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_COM_Customer_CustomerEmail",
                schema: "dbo",
                table: "COM_Customer",
                column: "CustomerEmail");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Customer_CustomerFirstName",
                schema: "dbo",
                table: "COM_Customer",
                column: "CustomerFirstName");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Customer_CustomerLastName",
                schema: "dbo",
                table: "COM_Customer",
                column: "CustomerLastName");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Customer_CustomerSiteID",
                schema: "dbo",
                table: "COM_Customer",
                column: "CustomerSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Customer_CustomerUserID",
                schema: "dbo",
                table: "COM_Customer",
                column: "CustomerUserID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_CustomerCreditHistory_EventCustomerID_EventDate",
                schema: "dbo",
                table: "COM_CustomerCreditHistory",
                columns: new[] { "EventCustomerID", "EventDate" });

            migrationBuilder.CreateIndex(
                name: "IX_COM_CustomerCreditHistory_EventSiteID",
                schema: "dbo",
                table: "COM_CustomerCreditHistory",
                column: "EventSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Department_DepartmentDefaultTaxClassID",
                schema: "dbo",
                table: "COM_Department",
                column: "DepartmentDefaultTaxClassID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Department_DepartmentDisplayName",
                schema: "dbo",
                table: "COM_Department",
                column: "DepartmentDisplayName");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Department_DepartmentName_DepartmentSiteID",
                schema: "dbo",
                table: "COM_Department",
                columns: new[] { "DepartmentName", "DepartmentSiteID" },
                unique: true,
                filter: "[DepartmentSiteID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Department_DepartmentSiteID",
                schema: "dbo",
                table: "COM_Department",
                column: "DepartmentSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Discount_DiscountSiteID",
                schema: "dbo",
                table: "COM_Discount",
                column: "DiscountSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ExchangeTable_ExchangeTableSiteID",
                schema: "dbo",
                table: "COM_ExchangeTable",
                column: "ExchangeTableSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ExchangeTable_ExchangeTableValidFrom_ExchangeTableValidTo",
                schema: "dbo",
                table: "COM_ExchangeTable",
                columns: new[] { "ExchangeTableValidFrom", "ExchangeTableValidTo" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_GiftCard_GiftCardSiteID",
                schema: "dbo",
                table: "COM_GiftCard",
                column: "GiftCardSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_GiftCardCouponCodeGiftCardID",
                schema: "dbo",
                table: "COM_GiftCardCouponCode",
                column: "GiftCardCouponCodeGiftCardID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_InternalStatus_InternalStatusSiteID_InternalStatusDisplayName_InternalStatusEnabled",
                schema: "dbo",
                table: "COM_InternalStatus",
                columns: new[] { "InternalStatusSiteID", "InternalStatusDisplayName", "InternalStatusEnabled" });

            migrationBuilder.CreateIndex(
                name: "IX_COM_Manufacturer_ManufacturerDisplayName_ManufacturerEnabled",
                schema: "dbo",
                table: "COM_Manufacturer",
                columns: new[] { "ManufacturerDisplayName", "ManufacturerEnabled" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_Manufacturer_ManufacturerSiteID",
                schema: "dbo",
                table: "COM_Manufacturer",
                column: "ManufacturerSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_MultiBuyCouponCode_MultiBuyCouponCodeMultiBuyDiscountID",
                schema: "dbo",
                table: "COM_MultiBuyCouponCode",
                column: "MultiBuyCouponCodeMultiBuyDiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_MultiBuyDiscount_MultiBuyDiscountApplyToSKUID",
                schema: "dbo",
                table: "COM_MultiBuyDiscount",
                column: "MultiBuyDiscountApplyToSKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_MultiBuyDiscount_MultiBuyDiscountSiteID",
                schema: "dbo",
                table: "COM_MultiBuyDiscount",
                column: "MultiBuyDiscountSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_MultiBuyDiscountBrand_BrandID",
                schema: "dbo",
                table: "COM_MultiBuyDiscountBrand",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_MultiBuyDiscountCollection_CollectionID",
                schema: "dbo",
                table: "COM_MultiBuyDiscountCollection",
                column: "CollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_MultiBuyDiscountDepartment_DepartmentID",
                schema: "dbo",
                table: "COM_MultiBuyDiscountDepartment",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_MultiBuyDiscountSKU_SKUID",
                schema: "dbo",
                table: "COM_MultiBuyDiscountSKU",
                column: "SKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_MultiBuyDiscountTree_NodeID",
                schema: "dbo",
                table: "COM_MultiBuyDiscountTree",
                column: "NodeID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OptionCategory_CategoryDisplayName_CategoryEnabled",
                schema: "dbo",
                table: "COM_OptionCategory",
                columns: new[] { "CategoryDisplayName", "CategoryEnabled" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_OptionCategory_CategorySiteID",
                schema: "dbo",
                table: "COM_OptionCategory",
                column: "CategorySiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Order_OrderCreatedByUserID",
                schema: "dbo",
                table: "COM_Order",
                column: "OrderCreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Order_OrderCurrencyID",
                schema: "dbo",
                table: "COM_Order",
                column: "OrderCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Order_OrderCustomerID",
                schema: "dbo",
                table: "COM_Order",
                column: "OrderCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Order_OrderPaymentOptionID",
                schema: "dbo",
                table: "COM_Order",
                column: "OrderPaymentOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Order_OrderShippingOptionID",
                schema: "dbo",
                table: "COM_Order",
                column: "OrderShippingOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Order_OrderSiteID_OrderDate",
                schema: "dbo",
                table: "COM_Order",
                columns: new[] { "OrderSiteID", "OrderDate" });

            migrationBuilder.CreateIndex(
                name: "IX_COM_Order_OrderStatusID",
                schema: "dbo",
                table: "COM_Order",
                column: "OrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderAddress_AddressCountryID",
                schema: "dbo",
                table: "COM_OrderAddress",
                column: "AddressCountryID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderAddress_AddressOrderID_AddressType",
                schema: "dbo",
                table: "COM_OrderAddress",
                columns: new[] { "AddressOrderID", "AddressType" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderAddress_AddressStateID",
                schema: "dbo",
                table: "COM_OrderAddress",
                column: "AddressStateID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderItem_OrderItemOrderID",
                schema: "dbo",
                table: "COM_OrderItem",
                column: "OrderItemOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderItem_OrderItemSKUID",
                schema: "dbo",
                table: "COM_OrderItem",
                column: "OrderItemSKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderItemSKUFile_FileID",
                schema: "dbo",
                table: "COM_OrderItemSKUFile",
                column: "FileID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderItemSKUFile_OrderItemID",
                schema: "dbo",
                table: "COM_OrderItemSKUFile",
                column: "OrderItemID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderStatus_StatusSiteID_StatusOrder",
                schema: "dbo",
                table: "COM_OrderStatus",
                columns: new[] { "StatusSiteID", "StatusOrder" });

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderStatusUser_ChangedByUserID",
                schema: "dbo",
                table: "COM_OrderStatusUser",
                column: "ChangedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderStatusUser_FromStatusID",
                schema: "dbo",
                table: "COM_OrderStatusUser",
                column: "FromStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderStatusUser_OrderID_Date",
                schema: "dbo",
                table: "COM_OrderStatusUser",
                columns: new[] { "OrderID", "Date" });

            migrationBuilder.CreateIndex(
                name: "IX_COM_OrderStatusUser_ToStatusID",
                schema: "dbo",
                table: "COM_OrderStatusUser",
                column: "ToStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_PaymentOption_PaymentOptionAuthorizedOrderStatusID",
                schema: "dbo",
                table: "COM_PaymentOption",
                column: "PaymentOptionAuthorizedOrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_PaymentOption_PaymentOptionFailedOrderStatusID",
                schema: "dbo",
                table: "COM_PaymentOption",
                column: "PaymentOptionFailedOrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_PaymentOption_PaymentOptionSiteID",
                schema: "dbo",
                table: "COM_PaymentOption",
                column: "PaymentOptionSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_PaymentOption_PaymentOptionSiteID_PaymentOptionDisplayName_PaymentOptionEnabled",
                schema: "dbo",
                table: "COM_PaymentOption",
                columns: new[] { "PaymentOptionSiteID", "PaymentOptionDisplayName", "PaymentOptionEnabled" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_PaymentOption_PaymentOptionSucceededOrderStatusID",
                schema: "dbo",
                table: "COM_PaymentOption",
                column: "PaymentOptionSucceededOrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_PublicStatus_PublicStatusDisplayName_PublicStatusEnabled",
                schema: "dbo",
                table: "COM_PublicStatus",
                columns: new[] { "PublicStatusDisplayName", "PublicStatusEnabled" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_PublicStatus_PublicStatusSiteID",
                schema: "dbo",
                table: "COM_PublicStatus",
                column: "PublicStatusSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShippingCost_ShippingCostShippingOptionID",
                schema: "dbo",
                table: "COM_ShippingCost",
                column: "ShippingCostShippingOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShippingOption_ShippingOptionCarrierID",
                schema: "dbo",
                table: "COM_ShippingOption",
                column: "ShippingOptionCarrierID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShippingOption_ShippingOptionSiteID_ShippingOptionDisplayName_ShippingOptionEnabled",
                schema: "dbo",
                table: "COM_ShippingOption",
                column: "ShippingOptionSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShippingOption_ShippingOptionTaxClassID",
                schema: "dbo",
                table: "COM_ShippingOption",
                column: "ShippingOptionTaxClassID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShippingOptionDisplayName",
                schema: "dbo",
                table: "COM_ShippingOption",
                column: "ShippingOptionDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartBillingAddressID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartBillingAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartCompanyAddressID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartCompanyAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartCurrencyID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartCurrencyID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartCustomerID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartCustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartLastUpdate",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartLastUpdate");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartPaymentOptionID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartPaymentOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartShippingAddressID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartShippingAddressID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartShippingOptionID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartShippingOptionID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartSiteID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartSiteID_ShoppingCartGUID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartGUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCart_ShoppingCartUserID",
                schema: "dbo",
                table: "COM_ShoppingCart",
                column: "ShoppingCartUserID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCartCouponCode_ShoppingCartID",
                schema: "dbo",
                table: "COM_ShoppingCartCouponCode",
                column: "ShoppingCartID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCartSKU_ShoppingCartID",
                schema: "dbo",
                table: "COM_ShoppingCartSKU",
                column: "ShoppingCartID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_ShoppingCartSKU_SKUID",
                schema: "dbo",
                table: "COM_ShoppingCartSKU",
                column: "SKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUBrandID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUBrandID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUCollectionID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUCollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUDepartmentID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUInternalStatusID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUInternalStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUManufacturerID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUManufacturerID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUName",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUName");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUNumber",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUNumber",
                filter: "([SKUNumber] IS NOT NULL)")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUOptionCategoryID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUOptionCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUParentSKUID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUParentSKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUPrice",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUPrice");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUPublicStatusID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUPublicStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUSiteID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUSupplierID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUSupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKU_SKUTaxClassID",
                schema: "dbo",
                table: "COM_SKU",
                column: "SKUTaxClassID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKUAllowedOption_SKUID",
                schema: "dbo",
                table: "COM_SKUAllowedOption",
                column: "SKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKUFile_FileSKUID",
                schema: "dbo",
                table: "COM_SKUFile",
                column: "FileSKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKUOptionCategory_CategoryID",
                schema: "dbo",
                table: "COM_SKUOptionCategory",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_SKUOptionCategory_SKUID",
                schema: "dbo",
                table: "COM_SKUOptionCategory",
                column: "SKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Supplier_SupplierDisplayName_SupplierEnabled",
                schema: "dbo",
                table: "COM_Supplier",
                columns: new[] { "SupplierDisplayName", "SupplierEnabled" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_Supplier_SupplierSiteID",
                schema: "dbo",
                table: "COM_Supplier",
                column: "SupplierSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_TaxClass_TaxClassDisplayName",
                schema: "dbo",
                table: "COM_TaxClass",
                column: "TaxClassDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_TaxClass_TaxClassSiteID",
                schema: "dbo",
                table: "COM_TaxClass",
                column: "TaxClassSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_TaxClassCountry_CountryID",
                schema: "dbo",
                table: "COM_TaxClassCountry",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_TaxClassCountry_TaxClassID_CountryID",
                schema: "dbo",
                table: "COM_TaxClassCountry",
                columns: new[] { "TaxClassID", "CountryID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_TaxClassState_StateID",
                schema: "dbo",
                table: "COM_TaxClassState",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_TaxClassState_TaxClassID_StateID",
                schema: "dbo",
                table: "COM_TaxClassState",
                columns: new[] { "TaxClassID", "StateID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_COM_VariantOption_OptionSKUID",
                schema: "dbo",
                table: "COM_VariantOption",
                column: "OptionSKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_VolumeDiscount_VolumeDiscountSKUID",
                schema: "dbo",
                table: "COM_VolumeDiscount",
                column: "VolumeDiscountSKUID");

            migrationBuilder.CreateIndex(
                name: "IX_COM_Wishlist_SiteID_UserID",
                schema: "dbo",
                table: "COM_Wishlist",
                columns: new[] { "SiteID", "UserID" });

            migrationBuilder.CreateIndex(
                name: "IX_COM_Wishlist_SKUID",
                schema: "dbo",
                table: "COM_Wishlist",
                column: "SKUID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_Group_GroupApproved",
                schema: "dbo",
                table: "Community_Group",
                column: "GroupApproved");

            migrationBuilder.CreateIndex(
                name: "IX_Community_Group_GroupApprovedByUserID",
                schema: "dbo",
                table: "Community_Group",
                column: "GroupApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_Group_GroupAvatarID",
                schema: "dbo",
                table: "Community_Group",
                column: "GroupAvatarID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_Group_GroupCreatedByUserID",
                schema: "dbo",
                table: "Community_Group",
                column: "GroupCreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_Group_GroupDisplayName",
                schema: "dbo",
                table: "Community_Group",
                columns: new[] { "GroupSiteID", "GroupDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Community_Group_GroupSiteID_GroupName",
                schema: "dbo",
                table: "Community_Group",
                columns: new[] { "GroupSiteID", "GroupName" });

            migrationBuilder.CreateIndex(
                name: "IX_Community_GroupMember_MemberApprovedByUserID",
                schema: "dbo",
                table: "Community_GroupMember",
                column: "MemberApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_GroupMember_MemberGroupID",
                schema: "dbo",
                table: "Community_GroupMember",
                column: "MemberGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_GroupMember_MemberInvitedByUserID",
                schema: "dbo",
                table: "Community_GroupMember",
                column: "MemberInvitedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_GroupMember_MemberJoined",
                schema: "dbo",
                table: "Community_GroupMember",
                column: "MemberJoined")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Community_GroupMember_MemberStatus",
                schema: "dbo",
                table: "Community_GroupMember",
                column: "MemberStatus");

            migrationBuilder.CreateIndex(
                name: "IX_Community_GroupMember_MemberUserID",
                schema: "dbo",
                table: "Community_GroupMember",
                column: "MemberUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_GroupRolePermission_PermissionID",
                schema: "dbo",
                table: "Community_GroupRolePermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_GroupRolePermission_RoleID",
                schema: "dbo",
                table: "Community_GroupRolePermission",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_Invitation_InvitationGroupID",
                schema: "dbo",
                table: "Community_Invitation",
                column: "InvitationGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_Invitation_InvitedByUserID",
                schema: "dbo",
                table: "Community_Invitation",
                column: "InvitedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Community_Invitation_InvitedUserID",
                schema: "dbo",
                table: "Community_Invitation",
                column: "InvitedUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Events_Attendee_AttendeeEmail_AttendeeFirstName_AttendeeLastName",
                schema: "dbo",
                table: "Events_Attendee",
                columns: new[] { "AttendeeEmail", "AttendeeFirstName", "AttendeeLastName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_Attendee_AttendeeEventNodeID",
                schema: "dbo",
                table: "Events_Attendee",
                column: "AttendeeEventNodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Export_History_ExportDateTime",
                schema: "dbo",
                table: "Export_History",
                column: "ExportDateTime")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Export_History_ExportSiteID",
                schema: "dbo",
                table: "Export_History",
                column: "ExportSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Export_History_ExportUserID",
                schema: "dbo",
                table: "Export_History",
                column: "ExportUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Export_Task_TaskSiteID_TaskObjectType",
                schema: "dbo",
                table: "Export_Task",
                columns: new[] { "TaskSiteID", "TaskObjectType" });

            migrationBuilder.CreateIndex(
                name: "IX_Forums_Attachment_AttachmentGUID",
                schema: "dbo",
                table: "Forums_Attachment",
                columns: new[] { "AttachmentSiteID", "AttachmentGUID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Forums_Attachment_AttachmentPostID",
                schema: "dbo",
                table: "Forums_Attachment",
                column: "AttachmentPostID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_Forum_ForumCommunityGroupID",
                schema: "dbo",
                table: "Forums_Forum",
                column: "ForumCommunityGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_Forum_ForumDocumentID",
                schema: "dbo",
                table: "Forums_Forum",
                column: "ForumDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_Forum_ForumGroupID_ForumOrder",
                schema: "dbo",
                table: "Forums_Forum",
                columns: new[] { "ForumGroupID", "ForumOrder" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Forums_Forum_ForumSiteID_ForumName",
                schema: "dbo",
                table: "Forums_Forum",
                columns: new[] { "ForumSiteID", "ForumName" });

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumGroup_GroupGroupID",
                schema: "dbo",
                table: "Forums_ForumGroup",
                column: "GroupGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumGroup_GroupSiteID_GroupName",
                schema: "dbo",
                table: "Forums_ForumGroup",
                columns: new[] { "GroupSiteID", "GroupName" });

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumGroup_GroupSiteID_GroupOrder",
                schema: "dbo",
                table: "Forums_ForumGroup",
                columns: new[] { "GroupSiteID", "GroupOrder" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumModerators_ForumID",
                schema: "dbo",
                table: "Forums_ForumModerators",
                column: "ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumPost_PostApproved",
                schema: "dbo",
                table: "Forums_ForumPost",
                column: "PostApproved");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumPost_PostApprovedByUserID",
                schema: "dbo",
                table: "Forums_ForumPost",
                column: "PostApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumPost_PostForumID",
                schema: "dbo",
                table: "Forums_ForumPost",
                column: "PostForumID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumPost_PostIDPath",
                schema: "dbo",
                table: "Forums_ForumPost",
                column: "PostIDPath",
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumPost_PostLevel",
                schema: "dbo",
                table: "Forums_ForumPost",
                column: "PostLevel");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumPost_PostParentID",
                schema: "dbo",
                table: "Forums_ForumPost",
                column: "PostParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumPost_PostUserID",
                schema: "dbo",
                table: "Forums_ForumPost",
                column: "PostUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumRoles_PermissionID",
                schema: "dbo",
                table: "Forums_ForumRoles",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumRoles_RoleID",
                schema: "dbo",
                table: "Forums_ForumRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumSubscription_SubscriptionForumID",
                schema: "dbo",
                table: "Forums_ForumSubscription",
                column: "SubscriptionForumID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumSubscription_SubscriptionForumID_SubscriptionEmail",
                schema: "dbo",
                table: "Forums_ForumSubscription",
                columns: new[] { "SubscriptionEmail", "SubscriptionForumID" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumSubscription_SubscriptionPostID",
                schema: "dbo",
                table: "Forums_ForumSubscription",
                column: "SubscriptionPostID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumSubscription_SubscriptionUserID",
                schema: "dbo",
                table: "Forums_ForumSubscription",
                column: "SubscriptionUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_UserFavorites_ForumID",
                schema: "dbo",
                table: "Forums_UserFavorites",
                column: "ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_UserFavorites_PostID",
                schema: "dbo",
                table: "Forums_UserFavorites",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_UserFavorites_SiteID",
                schema: "dbo",
                table: "Forums_UserFavorites",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_UserFavorites_UserID",
                schema: "dbo",
                table: "Forums_UserFavorites",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Forums_UserFavorites_UserID_PostID_ForumID",
                schema: "dbo",
                table: "Forums_UserFavorites",
                columns: new[] { "UserID", "PostID", "ForumID" },
                unique: true,
                filter: "[PostID] IS NOT NULL AND [ForumID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Integration_Connector_ConnectorDisplayName",
                schema: "dbo",
                table: "Integration_Connector",
                column: "ConnectorDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Integration_Connector_ConnectorEnabled",
                schema: "dbo",
                table: "Integration_Connector",
                column: "ConnectorEnabled");

            migrationBuilder.CreateIndex(
                name: "IX_Integration_Synchronization_SynchronizationConnectorID",
                schema: "dbo",
                table: "Integration_Synchronization",
                column: "SynchronizationConnectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Integration_Synchronization_SynchronizationTaskID",
                schema: "dbo",
                table: "Integration_Synchronization",
                column: "SynchronizationTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Integration_SyncLog_SyncLogTaskID",
                schema: "dbo",
                table: "Integration_SyncLog",
                column: "SyncLogSynchronizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Integration_Task_TaskIsInbound",
                schema: "dbo",
                table: "Integration_Task",
                column: "TaskIsInbound");

            migrationBuilder.CreateIndex(
                name: "IX_Integration_Task_TaskNodeAliasPath",
                schema: "dbo",
                table: "Integration_Task",
                column: "TaskNodeAliasPath")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Integration_Task_TaskSiteID",
                schema: "dbo",
                table: "Integration_Task",
                column: "TaskSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Integration_Task_TaskType",
                schema: "dbo",
                table: "Integration_Task",
                column: "TaskType");

            migrationBuilder.CreateIndex(
                name: "IX_Media_File_FileCreatedByUserID",
                schema: "dbo",
                table: "Media_File",
                column: "FileCreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_File_FileLibraryID",
                schema: "dbo",
                table: "Media_File",
                column: "FileLibraryID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_File_FileModifiedByUserID",
                schema: "dbo",
                table: "Media_File",
                column: "FileModifiedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_File_FilePath",
                schema: "dbo",
                table: "Media_File",
                column: "FilePath")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Media_File_FileSiteID_FileGUID",
                schema: "dbo",
                table: "Media_File",
                columns: new[] { "FileSiteID", "FileGUID" });

            migrationBuilder.CreateIndex(
                name: "IX_Media_Library_LibraryDisplayName",
                schema: "dbo",
                table: "Media_Library",
                columns: new[] { "LibrarySiteID", "LibraryDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Media_Library_LibraryGroupID",
                schema: "dbo",
                table: "Media_Library",
                column: "LibraryGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_Library_LibrarySiteID_LibraryName_LibraryGUID",
                schema: "dbo",
                table: "Media_Library",
                columns: new[] { "LibrarySiteID", "LibraryName", "LibraryGUID" },
                unique: true,
                filter: "[LibraryGUID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Media_LibraryRolePermission_PermissionID",
                schema: "dbo",
                table: "Media_LibraryRolePermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_Media_LibraryRolePermission_RoleID",
                schema: "dbo",
                table: "Media_LibraryRolePermission",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_ABTest_TestIssueID",
                schema: "dbo",
                table: "Newsletter_ABTest",
                column: "TestIssueID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_ABTest_TestWinnerIssueID",
                schema: "dbo",
                table: "Newsletter_ABTest",
                column: "TestWinnerIssueID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_ABTest_TestWinnerScheduledTaskID",
                schema: "dbo",
                table: "Newsletter_ABTest",
                column: "TestWinnerScheduledTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_ClickedLink_ClickedLinkNewsletterLinkID",
                schema: "dbo",
                table: "Newsletter_ClickedLink",
                column: "ClickedLinkNewsletterLinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Emails_EmailGUID",
                schema: "dbo",
                table: "Newsletter_Emails",
                column: "EmailGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Emails_EmailNewsletterIssueID",
                schema: "dbo",
                table: "Newsletter_Emails",
                column: "EmailNewsletterIssueID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Emails_EmailSending",
                schema: "dbo",
                table: "Newsletter_Emails",
                column: "EmailSending");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Emails_EmailSiteID",
                schema: "dbo",
                table: "Newsletter_Emails",
                column: "EmailSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Emails_EmailSubscriberID",
                schema: "dbo",
                table: "Newsletter_Emails",
                column: "EmailSubscriberID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_EmailTemplate_TemplateSiteID_TemplateDisplayName",
                schema: "dbo",
                table: "Newsletter_EmailTemplate",
                columns: new[] { "TemplateSiteID", "TemplateDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_EmailTemplate_TemplateSiteID_TemplateName",
                schema: "dbo",
                table: "Newsletter_EmailTemplate",
                columns: new[] { "TemplateSiteID", "TemplateName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_EmailTemplateNewsletter_NewsletterID",
                schema: "dbo",
                table: "Newsletter_EmailTemplateNewsletter",
                column: "NewsletterID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_EmailWidget_EmailWidgetSiteID",
                schema: "dbo",
                table: "Newsletter_EmailWidget",
                column: "EmailWidgetSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_EmailWidgetTemplate_EmailWidgetID",
                schema: "dbo",
                table: "Newsletter_EmailWidgetTemplate",
                column: "EmailWidgetID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_EmailWidgetTemplate_TemplateID",
                schema: "dbo",
                table: "Newsletter_EmailWidgetTemplate",
                column: "TemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_IssueContactGroup_ContactGroupID",
                schema: "dbo",
                table: "Newsletter_IssueContactGroup",
                column: "ContactGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Link_LinkIssueID",
                schema: "dbo",
                table: "Newsletter_Link",
                column: "LinkIssueID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Newsletter_NewsletterDynamicScheduledTaskID",
                schema: "dbo",
                table: "Newsletter_Newsletter",
                column: "NewsletterDynamicScheduledTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Newsletter_NewsletterOptInTemplateID",
                schema: "dbo",
                table: "Newsletter_Newsletter",
                column: "NewsletterOptInTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Newsletter_NewsletterSiteID_NewsletterDisplayName",
                schema: "dbo",
                table: "Newsletter_Newsletter",
                columns: new[] { "NewsletterSiteID", "NewsletterDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Newsletter_NewsletterSiteID_NewsletterName",
                schema: "dbo",
                table: "Newsletter_Newsletter",
                columns: new[] { "NewsletterSiteID", "NewsletterName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Newsletter_NewsletterSubscriptionTemplateID",
                schema: "dbo",
                table: "Newsletter_Newsletter",
                column: "NewsletterSubscriptionTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Newsletter_NewsletterUnsubscriptionTemplateID",
                schema: "dbo",
                table: "Newsletter_Newsletter",
                column: "NewsletterUnsubscriptionTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_NewsletterIssue_IssueNewsletterID",
                schema: "dbo",
                table: "Newsletter_NewsletterIssue",
                column: "IssueNewsletterID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_NewsletterIssue_IssueScheduledTaskID",
                schema: "dbo",
                table: "Newsletter_NewsletterIssue",
                column: "IssueScheduledTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_NewsletterIssue_IssueSiteID",
                schema: "dbo",
                table: "Newsletter_NewsletterIssue",
                column: "IssueSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_NewsletterIssue_IssueTemplateID",
                schema: "dbo",
                table: "Newsletter_NewsletterIssue",
                column: "IssueTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_NewsletterIssue_IssueVariantOfIssueID",
                schema: "dbo",
                table: "Newsletter_NewsletterIssue",
                column: "IssueVariantOfIssueID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_OpenedEmail_OpenedEmailIssueID",
                schema: "dbo",
                table: "Newsletter_OpenedEmail",
                column: "OpenedEmailIssueID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Subscriber_SubscriberEmail",
                schema: "dbo",
                table: "Newsletter_Subscriber",
                column: "SubscriberEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Subscriber_SubscriberSiteID_SubscriberFullName",
                schema: "dbo",
                table: "Newsletter_Subscriber",
                columns: new[] { "SubscriberSiteID", "SubscriberFullName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Subscriber_SubscriberType_SubscriberRelatedID",
                schema: "dbo",
                table: "Newsletter_Subscriber",
                columns: new[] { "SubscriberType", "SubscriberRelatedID" });

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_SubscriberNewsletter_NewsletterID_SubscriptionApproved",
                schema: "dbo",
                table: "Newsletter_SubscriberNewsletter",
                columns: new[] { "NewsletterID", "SubscriptionApproved" });

            migrationBuilder.CreateIndex(
                name: "UQ_Newsletter_SubscriberNewsletter",
                schema: "dbo",
                table: "Newsletter_SubscriberNewsletter",
                columns: new[] { "SubscriberID", "NewsletterID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Unsubscription_Email_NewsletterID",
                schema: "dbo",
                table: "Newsletter_Unsubscription",
                columns: new[] { "UnsubscriptionEmail", "UnsubscriptionNewsletterID" });

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Unsubscription_NewsletterID",
                schema: "dbo",
                table: "Newsletter_Unsubscription",
                column: "UnsubscriptionNewsletterID");

            migrationBuilder.CreateIndex(
                name: "IX_Newsletter_Unsubscription_UnsubscriptionFromIssueID",
                schema: "dbo",
                table: "Newsletter_Unsubscription",
                column: "UnsubscriptionFromIssueID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Gateway_GatewayDisplayName",
                schema: "dbo",
                table: "Notification_Gateway",
                column: "GatewayDisplayName")
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Subscription_SubscriptionEventSource_SubscriptionEventCode_SubscriptionEventObjectID",
                schema: "dbo",
                table: "Notification_Subscription",
                columns: new[] { "SubscriptionEventSource", "SubscriptionEventCode", "SubscriptionEventObjectID" });

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Subscription_SubscriptionGatewayID",
                schema: "dbo",
                table: "Notification_Subscription",
                column: "SubscriptionGatewayID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Subscription_SubscriptionSiteID",
                schema: "dbo",
                table: "Notification_Subscription",
                column: "SubscriptionSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Subscription_SubscriptionTemplateID",
                schema: "dbo",
                table: "Notification_Subscription",
                column: "SubscriptionTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Subscription_SubscriptionUserID",
                schema: "dbo",
                table: "Notification_Subscription",
                column: "SubscriptionUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Template_TemplateSiteID",
                schema: "dbo",
                table: "Notification_Template",
                column: "TemplateSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_Template_TemplateSiteID_TemplateDisplayName",
                schema: "dbo",
                table: "Notification_Template",
                columns: new[] { "TemplateSiteID", "TemplateDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Notification_TemplateText_GatewayID",
                schema: "dbo",
                table: "Notification_TemplateText",
                column: "GatewayID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_TemplateText_TemplateID",
                schema: "dbo",
                table: "Notification_TemplateText",
                column: "TemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_ABTest_SiteID",
                schema: "dbo",
                table: "OM_ABTest",
                column: "ABTestSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_ABVariant_ABVariantSiteID",
                schema: "dbo",
                table: "OM_ABVariant",
                column: "ABVariantSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_ABVariant_ABVariantTestID",
                schema: "dbo",
                table: "OM_ABVariant",
                column: "ABVariantTestID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_ABVariantData_ABVariantTestID_ABVariantGUID",
                schema: "dbo",
                table: "OM_ABVariantData",
                columns: new[] { "ABVariantTestID", "ABVariantGUID" });

            migrationBuilder.CreateIndex(
                name: "IX_OM_Account_AccountCountryID",
                schema: "dbo",
                table: "OM_Account",
                column: "AccountCountryID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Account_AccountOwnerUserID",
                schema: "dbo",
                table: "OM_Account",
                column: "AccountOwnerUserID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Account_AccountPrimaryContactID",
                schema: "dbo",
                table: "OM_Account",
                column: "AccountPrimaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Account_AccountSecondaryContactID",
                schema: "dbo",
                table: "OM_Account",
                column: "AccountSecondaryContactID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Account_AccountStateID",
                schema: "dbo",
                table: "OM_Account",
                column: "AccountStateID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Account_AccountStatusID",
                schema: "dbo",
                table: "OM_Account",
                column: "AccountStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Account_AccountSubsidiaryOfID",
                schema: "dbo",
                table: "OM_Account",
                column: "AccountSubsidiaryOfID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_AccountContact_AccountID",
                schema: "dbo",
                table: "OM_AccountContact",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_AccountContact_ContactID",
                schema: "dbo",
                table: "OM_AccountContact",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_AccountContact_ContactRoleID",
                schema: "dbo",
                table: "OM_AccountContact",
                column: "ContactRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Activity_ActivityCampaign",
                schema: "dbo",
                table: "OM_Activity",
                column: "ActivityCampaign",
                filter: "([ActivityCampaign] IS NOT NULL)")
                .Annotation("SqlServer:FillFactor", 90);

            migrationBuilder.CreateIndex(
                name: "IX_OM_Activity_ActivityContactID",
                schema: "dbo",
                table: "OM_Activity",
                column: "ActivityContactID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Activity_ActivityCreated",
                schema: "dbo",
                table: "OM_Activity",
                column: "ActivityCreated");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Activity_ActivityItemDetailID",
                schema: "dbo",
                table: "OM_Activity",
                column: "ActivityItemDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Activity_ActivitySiteID",
                schema: "dbo",
                table: "OM_Activity",
                column: "ActivitySiteID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Activity_ActivityType_ActivityItemID_ActivityNodeID_ActivityUTMSource_ActivityUTMContent_ActivityCampaign",
                schema: "dbo",
                table: "OM_Activity",
                columns: new[] { "ActivityType", "ActivityItemID", "ActivityNodeID" });

            migrationBuilder.CreateIndex(
                name: "IX_OM_Contact_ContactCountryID",
                schema: "dbo",
                table: "OM_Contact",
                column: "ContactCountryID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Contact_ContactEmail",
                schema: "dbo",
                table: "OM_Contact",
                column: "ContactEmail");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Contact_ContactGUID",
                schema: "dbo",
                table: "OM_Contact",
                column: "ContactGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OM_Contact_ContactLastName",
                schema: "dbo",
                table: "OM_Contact",
                column: "ContactLastName");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Contact_ContactOwnerUserID",
                schema: "dbo",
                table: "OM_Contact",
                column: "ContactOwnerUserID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Contact_ContactPersonaID_ContactLastName",
                schema: "dbo",
                table: "OM_Contact",
                columns: new[] { "ContactPersonaID", "ContactLastName" });

            migrationBuilder.CreateIndex(
                name: "IX_OM_Contact_ContactStateID",
                schema: "dbo",
                table: "OM_Contact",
                column: "ContactStateID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Contact_ContactStatusID",
                schema: "dbo",
                table: "OM_Contact",
                column: "ContactStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_ContactGroupMember_ContactGroupID_Type_MemberID_RelatedID_FromCondition_FromAccount_FromManual",
                schema: "dbo",
                table: "OM_ContactGroupMember",
                columns: new[] { "ContactGroupMemberContactGroupID", "ContactGroupMemberType" });

            migrationBuilder.CreateIndex(
                name: "IX_OM_ContactGroupMember_ContactGroupID_Type_RelatedID",
                schema: "dbo",
                table: "OM_ContactGroupMember",
                columns: new[] { "ContactGroupMemberContactGroupID", "ContactGroupMemberType", "ContactGroupMemberRelatedID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OM_ContactGroupMember_ContactGroupMemberRelatedID",
                schema: "dbo",
                table: "OM_ContactGroupMember",
                column: "ContactGroupMemberRelatedID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Membership_ContactID",
                schema: "dbo",
                table: "OM_Membership",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Membership_RelatedID",
                schema: "dbo",
                table: "OM_Membership",
                column: "RelatedID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_MVTCombination_MVTCombinationPageTemplateID",
                schema: "dbo",
                table: "OM_MVTCombination",
                column: "MVTCombinationPageTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_MVTCombinationVariation_MVTVariantID",
                schema: "dbo",
                table: "OM_MVTCombinationVariation",
                column: "MVTVariantID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_MVTest_MVTestSiteID",
                schema: "dbo",
                table: "OM_MVTest",
                column: "MVTestSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_MVTVariant_MVTVariantPageTemplateID",
                schema: "dbo",
                table: "OM_MVTVariant",
                column: "MVTVariantPageTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_PersonalizationVariant_VariantDocumentID",
                schema: "dbo",
                table: "OM_PersonalizationVariant",
                column: "VariantPageTemplateID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_PersonalizationVariant_VariantPageTemplateID",
                schema: "dbo",
                table: "OM_PersonalizationVariant",
                column: "VariantDocumentID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_Rule_RuleScoreID",
                schema: "dbo",
                table: "OM_Rule",
                column: "RuleScoreID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_ScoreContactRule_ContactID",
                schema: "dbo",
                table: "OM_ScoreContactRule",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_ScoreContactRule_RuleID",
                schema: "dbo",
                table: "OM_ScoreContactRule",
                column: "RuleID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_ScoreContactRule_ScoreID_ContactID_Value_Expiration",
                schema: "dbo",
                table: "OM_ScoreContactRule",
                column: "ScoreID");

            migrationBuilder.CreateIndex(
                name: "UQ_OM_ScoreContactRule",
                schema: "dbo",
                table: "OM_ScoreContactRule",
                columns: new[] { "ScoreID", "ContactID", "RuleID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OM_VisitorToContact_VisitorToContactContactID",
                schema: "dbo",
                table: "OM_VisitorToContact",
                column: "VisitorToContactContactID");

            migrationBuilder.CreateIndex(
                name: "IX_OM_VisitorToContact_VisitorToContactVisitorGUID",
                schema: "dbo",
                table: "OM_VisitorToContact",
                column: "VisitorToContactVisitorGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_Persona_PersonaScoreID",
                schema: "dbo",
                table: "Personas_Persona",
                column: "PersonaScoreID");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_PersonaContactHistoryPersonaID",
                schema: "dbo",
                table: "Personas_PersonaContactHistory",
                column: "PersonaContactHistoryPersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_PersonaNode_NodeID",
                schema: "dbo",
                table: "Personas_PersonaNode",
                column: "NodeID");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_PersonaNode_PersonaID",
                schema: "dbo",
                table: "Personas_PersonaNode",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_Polls_Poll_PollGroupID",
                schema: "dbo",
                table: "Polls_Poll",
                column: "PollGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Polls_Poll_PollSiteID_PollCodeName",
                schema: "dbo",
                table: "Polls_Poll",
                columns: new[] { "PollSiteID", "PollCodeName" });

            migrationBuilder.CreateIndex(
                name: "IX_Polls_Poll_PollSiteID_PollDisplayName",
                schema: "dbo",
                table: "Polls_Poll",
                columns: new[] { "PollSiteID", "PollDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Polls_PollAnswer_AnswerPollID",
                schema: "dbo",
                table: "Polls_PollAnswer",
                column: "AnswerPollID");

            migrationBuilder.CreateIndex(
                name: "IX_Polls_PollAnswer_AnswerPollID_AnswerOrder_AnswerEnabled",
                schema: "dbo",
                table: "Polls_PollAnswer",
                columns: new[] { "AnswerOrder", "AnswerPollID", "AnswerEnabled" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Polls_PollRoles_RoleID",
                schema: "dbo",
                table: "Polls_PollRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Polls_PollSite_SiteID",
                schema: "dbo",
                table: "Polls_PollSite",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_Report_ReportCategoryID",
                schema: "dbo",
                table: "Reporting_Report",
                column: "ReportCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_Report_ReportCategoryID_ReportDisplayName",
                schema: "dbo",
                table: "Reporting_Report",
                columns: new[] { "ReportDisplayName", "ReportCategoryID" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_Report_ReportGUID_ReportName",
                schema: "dbo",
                table: "Reporting_Report",
                columns: new[] { "ReportGUID", "ReportName" });

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_Report_ReportName",
                schema: "dbo",
                table: "Reporting_Report",
                column: "ReportName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportCategory_CategoryParentID",
                schema: "dbo",
                table: "Reporting_ReportCategory",
                column: "CategoryParentID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportCategory_CategoryPath",
                schema: "dbo",
                table: "Reporting_ReportCategory",
                column: "CategoryPath",
                unique: true)
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportGraph_GraphGUID",
                schema: "dbo",
                table: "Reporting_ReportGraph",
                column: "GraphGUID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportGraph_GraphReportID_GraphName",
                schema: "dbo",
                table: "Reporting_ReportGraph",
                columns: new[] { "GraphReportID", "GraphName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportSubscription_ReportSubscriptionGraphID",
                schema: "dbo",
                table: "Reporting_ReportSubscription",
                column: "ReportSubscriptionGraphID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportSubscription_ReportSubscriptionReportID",
                schema: "dbo",
                table: "Reporting_ReportSubscription",
                column: "ReportSubscriptionReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportSubscription_ReportSubscriptionSiteID",
                schema: "dbo",
                table: "Reporting_ReportSubscription",
                column: "ReportSubscriptionSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportSubscription_ReportSubscriptionTableID",
                schema: "dbo",
                table: "Reporting_ReportSubscription",
                column: "ReportSubscriptionTableID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportSubscription_ReportSubscriptionUserID",
                schema: "dbo",
                table: "Reporting_ReportSubscription",
                column: "ReportSubscriptionUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportSubscription_ReportSubscriptionValueID",
                schema: "dbo",
                table: "Reporting_ReportSubscription",
                column: "ReportSubscriptionValueID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportTable_TableReportID",
                schema: "dbo",
                table: "Reporting_ReportTable",
                column: "TableReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportTable_TableReportID_TableName",
                schema: "dbo",
                table: "Reporting_ReportTable",
                columns: new[] { "TableName", "TableReportID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportValue_ValueName_ValueReportID",
                schema: "dbo",
                table: "Reporting_ReportValue",
                columns: new[] { "ValueName", "ValueReportID" });

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_ReportValue_ValueReportID",
                schema: "dbo",
                table: "Reporting_ReportValue",
                column: "ValueReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_SavedGraph_SavedGraphGUID",
                schema: "dbo",
                table: "Reporting_SavedGraph",
                column: "SavedGraphGUID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_SavedGraph_SavedGraphSavedReportID",
                schema: "dbo",
                table: "Reporting_SavedGraph",
                column: "SavedGraphSavedReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_SavedReport_SavedReportCreatedByUserID",
                schema: "dbo",
                table: "Reporting_SavedReport",
                column: "SavedReportCreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Reporting_SavedReport_SavedReportReportID_SavedReportDate",
                schema: "dbo",
                table: "Reporting_SavedReport",
                columns: new[] { "SavedReportReportID", "SavedReportDate" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_SharePoint_SharePointConnection_SharePointConnectionSiteID",
                schema: "dbo",
                table: "SharePoint_SharePointConnection",
                column: "SharePointConnectionSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SharePoint_SharePointFile_SharePointFileSiteID",
                schema: "dbo",
                table: "SharePoint_SharePointFile",
                column: "SharePointFileSiteID");

            migrationBuilder.CreateIndex(
                name: "UQ_SharePoint_SharePointFile_LibraryID_ServerRelativeURL",
                schema: "dbo",
                table: "SharePoint_SharePointFile",
                columns: new[] { "SharePointFileSharePointLibraryID", "SharePointFileServerRelativeURL" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SharePoint_SharePointLibrary_SharePointLibrarySharepointConnectionID",
                schema: "dbo",
                table: "SharePoint_SharePointLibrary",
                column: "SharePointLibrarySharePointConnectionID");

            migrationBuilder.CreateIndex(
                name: "IX_SharePoint_SharePointLibrary_SharePointlibrarySiteID",
                schema: "dbo",
                table: "SharePoint_SharePointLibrary",
                column: "SharePointLibrarySiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_FacebookAccount_FacebookAccountFacebookApplicationID",
                schema: "dbo",
                table: "SM_FacebookAccount",
                column: "FacebookAccountFacebookApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_FacebookAccount_FacebookAccountSiteID",
                schema: "dbo",
                table: "SM_FacebookAccount",
                column: "FacebookAccountSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_FacebookApplication_FacebookApplicationSiteID",
                schema: "dbo",
                table: "SM_FacebookApplication",
                column: "FacebookApplicationSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_FacebookPost_FacebookPostCampaignID",
                schema: "dbo",
                table: "SM_FacebookPost",
                column: "FacebookPostCampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_FacebookPost_FacebookPostFacebookAccountID",
                schema: "dbo",
                table: "SM_FacebookPost",
                column: "FacebookPostFacebookAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_FacebookPost_FacebookPostSiteID",
                schema: "dbo",
                table: "SM_FacebookPost",
                column: "FacebookPostSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_Insight_InsightCodeName_InsightPeriodType",
                schema: "dbo",
                table: "SM_Insight",
                columns: new[] { "InsightCodeName", "InsightPeriodType" });

            migrationBuilder.CreateIndex(
                name: "UQ_SM_InsightHit_Day_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo",
                schema: "dbo",
                table: "SM_InsightHit_Day",
                columns: new[] { "InsightHitInsightID", "InsightHitPeriodFrom", "InsightHitPeriodTo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_SM_InsightHit_Month_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo",
                schema: "dbo",
                table: "SM_InsightHit_Month",
                columns: new[] { "InsightHitInsightID", "InsightHitPeriodFrom", "InsightHitPeriodTo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_SM_InsightHit_Week_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo",
                schema: "dbo",
                table: "SM_InsightHit_Week",
                columns: new[] { "InsightHitInsightID", "InsightHitPeriodFrom", "InsightHitPeriodTo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_SM_InsightHit_Year_InsightHitInsightID_InsightHitPeriodFrom_InsightHitPeriodTo",
                schema: "dbo",
                table: "SM_InsightHit_Year",
                columns: new[] { "InsightHitInsightID", "InsightHitPeriodFrom", "InsightHitPeriodTo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SM_LinkedInApplication_LinkedInApplicationSiteID",
                schema: "dbo",
                table: "SM_LinkedInApplication",
                column: "LinkedInApplicationSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_LinkedInPost_LinkedInPostCampaignID",
                schema: "dbo",
                table: "SM_LinkedInPost",
                column: "LinkedInPostCampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_LinkedInPost_LinkedInPostLinkedInAccountID",
                schema: "dbo",
                table: "SM_LinkedInPost",
                column: "LinkedInPostLinkedInAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_LinkedInPost_LinkedInPostSiteID",
                schema: "dbo",
                table: "SM_LinkedInPost",
                column: "LinkedInPostSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_TwitterAccount_TwitterAccountSiteID",
                schema: "dbo",
                table: "SM_TwitterAccount",
                column: "TwitterAccountSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_TwitterAccount_TwitterAccountTwitterApplicationID",
                schema: "dbo",
                table: "SM_TwitterAccount",
                column: "TwitterAccountTwitterApplicationID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_TwitterApplication_TwitterApplicationSiteID",
                schema: "dbo",
                table: "SM_TwitterApplication",
                column: "TwitterApplicationSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_TwitterPost_TwitterPostCampaignID",
                schema: "dbo",
                table: "SM_TwitterPost",
                column: "TwitterPostCampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_TwitterPost_TwitterPostSiteID",
                schema: "dbo",
                table: "SM_TwitterPost",
                column: "TwitterPostSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_SM_TwitterPost_TwitterPostTwitterAccountID",
                schema: "dbo",
                table: "SM_TwitterPost",
                column: "TwitterPostTwitterAccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_Server_ServerEnabled",
                schema: "dbo",
                table: "Staging_Server",
                column: "ServerEnabled");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_Server_ServerSiteID",
                schema: "dbo",
                table: "Staging_Server",
                column: "ServerSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_Server_ServerSiteID_ServerDisplayName",
                schema: "dbo",
                table: "Staging_Server",
                columns: new[] { "ServerSiteID", "ServerDisplayName" })
                .Annotation("SqlServer:Clustered", true);

            migrationBuilder.CreateIndex(
                name: "IX_Staging_Synchronization_SynchronizationServerID",
                schema: "dbo",
                table: "Staging_Synchronization",
                column: "SynchronizationServerID");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_Synchronization_SynchronizationTaskID",
                schema: "dbo",
                table: "Staging_Synchronization",
                column: "SynchronizationTaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_Task_TaskDocumentID_TaskNodeID_TaskRunning",
                schema: "dbo",
                table: "Staging_Task",
                columns: new[] { "TaskDocumentID", "TaskNodeID", "TaskRunning" });

            migrationBuilder.CreateIndex(
                name: "IX_Staging_Task_TaskObjectType_TaskObjectID_TaskRunning",
                schema: "dbo",
                table: "Staging_Task",
                columns: new[] { "TaskObjectType", "TaskObjectID", "TaskRunning" });

            migrationBuilder.CreateIndex(
                name: "IX_Staging_Task_TaskSiteID",
                schema: "dbo",
                table: "Staging_Task",
                column: "TaskSiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_Task_TaskType",
                schema: "dbo",
                table: "Staging_Task",
                column: "TaskType");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_TaskGroupTask_TaskGroupID",
                schema: "dbo",
                table: "staging_TaskGroupTask",
                column: "TaskGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_TaskGroupTask_TaskID",
                schema: "dbo",
                table: "staging_TaskGroupTask",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_TaskGroupUser_TaskGroup_ID",
                schema: "dbo",
                table: "staging_TaskGroupUser",
                column: "TaskGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_TaskGroupUser_UserID",
                schema: "dbo",
                table: "staging_TaskGroupUser",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Staging_TaskUser_TaskID",
                schema: "dbo",
                table: "Staging_TaskUser",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_Staging_TaskUser_UserID",
                schema: "dbo",
                table: "Staging_TaskUser",
                column: "UserID");
        }
    }
}
