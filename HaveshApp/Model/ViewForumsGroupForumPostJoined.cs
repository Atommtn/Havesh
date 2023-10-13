using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewForumsGroupForumPostJoined
    {
        public int? ForumId { get; set; }
        public int? ForumGroupId { get; set; }
        public string? ForumName { get; set; }
        public string? ForumDisplayName { get; set; }
        public string? ForumDescription { get; set; }
        public int? ForumOrder { get; set; }
        public int? ForumDocumentId { get; set; }
        public bool? ForumOpen { get; set; }
        public bool? ForumModerated { get; set; }
        public bool? ForumDisplayEmails { get; set; }
        public bool? ForumRequireEmail { get; set; }
        public int? ForumAccess { get; set; }
        public int? ForumThreads { get; set; }
        public int? ForumPosts { get; set; }
        public DateTime? ForumLastPostTime { get; set; }
        public string? ForumLastPostUserName { get; set; }
        public string? ForumBaseUrl { get; set; }
        public bool? ForumAllowChangeName { get; set; }
        public bool? ForumHtmleditor { get; set; }
        public bool? ForumUseCaptcha { get; set; }
        public Guid? ForumGuid { get; set; }
        public DateTime? ForumLastModified { get; set; }
        public string? ForumUnsubscriptionUrl { get; set; }
        public bool? ForumIsLocked { get; set; }
        public string? ForumSettings { get; set; }
        public bool? ForumAuthorEdit { get; set; }
        public bool? ForumAuthorDelete { get; set; }
        public int? ForumType { get; set; }
        public int? ForumIsAnswerLimit { get; set; }
        public int? ForumImageMaxSideSize { get; set; }
        public DateTime? ForumLastPostTimeAbsolute { get; set; }
        public string? ForumLastPostUserNameAbsolute { get; set; }
        public int? ForumPostsAbsolute { get; set; }
        public int? ForumThreadsAbsolute { get; set; }
        public int? ForumAttachmentMaxFileSize { get; set; }
        public int? ForumDiscussionActions { get; set; }
        public int? ForumSiteId { get; set; }
        public int? GroupId { get; set; }
        public int? GroupSiteId { get; set; }
        public string? GroupName { get; set; }
        public string? GroupDisplayName { get; set; }
        public int? GroupOrder { get; set; }
        public string? GroupDescription { get; set; }
        public Guid? GroupGuid { get; set; }
        public DateTime? GroupLastModified { get; set; }
        public string? GroupBaseUrl { get; set; }
        public string? GroupUnsubscriptionUrl { get; set; }
        public int? GroupGroupId { get; set; }
        public bool? GroupAuthorEdit { get; set; }
        public bool? GroupAuthorDelete { get; set; }
        public int? GroupType { get; set; }
        public int? GroupIsAnswerLimit { get; set; }
        public int? GroupImageMaxSideSize { get; set; }
        public bool? GroupDisplayEmails { get; set; }
        public bool? GroupRequireEmail { get; set; }
        public bool? GroupHtmleditor { get; set; }
        public bool? GroupUseCaptcha { get; set; }
        public int? GroupAttachmentMaxFileSize { get; set; }
        public int? GroupDiscussionActions { get; set; }
        public int PostId { get; set; }
        public int PostForumId { get; set; }
        public int? PostParentId { get; set; }
        public string PostIdpath { get; set; } = null!;
        public int PostLevel { get; set; }
        public string PostSubject { get; set; } = null!;
        public int? PostUserId { get; set; }
        public string PostUserName { get; set; } = null!;
        public string? PostUserMail { get; set; }
        public string? PostText { get; set; }
        public DateTime PostTime { get; set; }
        public int? PostApprovedByUserId { get; set; }
        public int? PostThreadPosts { get; set; }
        public string? PostThreadLastPostUserName { get; set; }
        public DateTime? PostThreadLastPostTime { get; set; }
        public string? PostUserSignature { get; set; }
        public Guid PostGuid { get; set; }
        public DateTime PostLastModified { get; set; }
        public bool? PostApproved { get; set; }
        public bool? PostIsLocked { get; set; }
        public int? PostIsAnswer { get; set; }
        public int PostStickOrder { get; set; }
        public int? PostViews { get; set; }
        public DateTime? PostLastEdit { get; set; }
        public string? PostInfo { get; set; }
        public int? PostAttachmentCount { get; set; }
        public int? PostType { get; set; }
        public int? PostThreadPostsAbsolute { get; set; }
        public string? PostThreadLastPostUserNameAbsolute { get; set; }
        public DateTime? PostThreadLastPostTimeAbsolute { get; set; }
        public bool? PostQuestionSolved { get; set; }
        public int? PostIsNotAnswer { get; set; }
    }
}
