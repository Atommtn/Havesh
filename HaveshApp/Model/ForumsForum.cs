using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ForumsForum
    {
        public ForumsForum()
        {
            ForumsForumPosts = new HashSet<ForumsForumPost>();
            ForumsForumRoles = new HashSet<ForumsForumRole>();
            ForumsForumSubscriptions = new HashSet<ForumsForumSubscription>();
            ForumsUserFavorites = new HashSet<ForumsUserFavorite>();
            Users = new HashSet<CmsUser>();
        }

        public int ForumId { get; set; }
        public int ForumGroupId { get; set; }
        public string ForumName { get; set; } = null!;
        public string ForumDisplayName { get; set; } = null!;
        public string? ForumDescription { get; set; }
        public int? ForumOrder { get; set; }
        public int? ForumDocumentId { get; set; }
        public bool ForumOpen { get; set; }
        public bool ForumModerated { get; set; }
        public bool? ForumDisplayEmails { get; set; }
        public bool? ForumRequireEmail { get; set; }
        public int ForumAccess { get; set; }
        public int ForumThreads { get; set; }
        public int ForumPosts { get; set; }
        public DateTime? ForumLastPostTime { get; set; }
        public string? ForumLastPostUserName { get; set; }
        public string? ForumBaseUrl { get; set; }
        public bool? ForumAllowChangeName { get; set; }
        public bool? ForumHtmleditor { get; set; }
        public bool? ForumUseCaptcha { get; set; }
        public Guid ForumGuid { get; set; }
        public DateTime ForumLastModified { get; set; }
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
        public int ForumSiteId { get; set; }
        public bool? ForumLogActivity { get; set; }
        public int? ForumCommunityGroupId { get; set; }
        public bool? ForumEnableOptIn { get; set; }
        public bool? ForumSendOptInConfirmation { get; set; }
        public string? ForumOptInApprovalUrl { get; set; }

        public virtual CommunityGroup? ForumCommunityGroup { get; set; }
        public virtual CmsDocument? ForumDocument { get; set; }
        public virtual ForumsForumGroup ForumGroup { get; set; } = null!;
        public virtual CmsSite ForumSite { get; set; } = null!;
        public virtual ICollection<ForumsForumPost> ForumsForumPosts { get; set; }
        public virtual ICollection<ForumsForumRole> ForumsForumRoles { get; set; }
        public virtual ICollection<ForumsForumSubscription> ForumsForumSubscriptions { get; set; }
        public virtual ICollection<ForumsUserFavorite> ForumsUserFavorites { get; set; }

        public virtual ICollection<CmsUser> Users { get; set; }
    }
}
