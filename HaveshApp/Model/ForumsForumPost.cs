using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ForumsForumPost
    {
        public ForumsForumPost()
        {
            ForumsAttachments = new HashSet<ForumsAttachment>();
            ForumsForumSubscriptions = new HashSet<ForumsForumSubscription>();
            ForumsUserFavorites = new HashSet<ForumsUserFavorite>();
            InversePostParent = new HashSet<ForumsForumPost>();
        }

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
        public int? PostSiteId { get; set; }

        public virtual CmsUser? PostApprovedByUser { get; set; }
        public virtual ForumsForum PostForum { get; set; } = null!;
        public virtual ForumsForumPost? PostParent { get; set; }
        public virtual CmsUser? PostUser { get; set; }
        public virtual ICollection<ForumsAttachment> ForumsAttachments { get; set; }
        public virtual ICollection<ForumsForumSubscription> ForumsForumSubscriptions { get; set; }
        public virtual ICollection<ForumsUserFavorite> ForumsUserFavorites { get; set; }
        public virtual ICollection<ForumsForumPost> InversePostParent { get; set; }
    }
}
