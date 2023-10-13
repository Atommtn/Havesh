using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ViewBoardsBoardMessageJoined
    {
        public int BoardId { get; set; }
        public string BoardName { get; set; } = null!;
        public string BoardDisplayName { get; set; } = null!;
        public string BoardDescription { get; set; } = null!;
        public DateTime? BoardOpenedFrom { get; set; }
        public bool BoardOpened { get; set; }
        public DateTime? BoardOpenedTo { get; set; }
        public bool BoardEnabled { get; set; }
        public bool BoardModerated { get; set; }
        public int BoardAccess { get; set; }
        public bool BoardUseCaptcha { get; set; }
        public DateTime BoardLastModified { get; set; }
        public int BoardMessages { get; set; }
        public int BoardDocumentId { get; set; }
        public Guid BoardGuid { get; set; }
        public int? BoardUserId { get; set; }
        public int? BoardGroupId { get; set; }
        public DateTime? BoardLastMessageTime { get; set; }
        public string? BoardLastMessageUserName { get; set; }
        public string? BoardUnsubscriptionUrl { get; set; }
        public bool? BoardRequireEmails { get; set; }
        public int BoardSiteId { get; set; }
        public bool BoardEnableSubscriptions { get; set; }
        public string? BoardBaseUrl { get; set; }
        public int MessageId { get; set; }
        public string MessageUserName { get; set; } = null!;
        public string MessageText { get; set; } = null!;
        public string MessageEmail { get; set; } = null!;
        public string MessageUrl { get; set; } = null!;
        public bool MessageIsSpam { get; set; }
        public int MessageBoardId { get; set; }
        public bool MessageApproved { get; set; }
        public int? MessageUserId { get; set; }
        public int? MessageApprovedByUserId { get; set; }
        public string MessageUserInfo { get; set; } = null!;
        public Guid? MessageAvatarGuid { get; set; }
        public DateTime MessageInserted { get; set; }
        public DateTime MessageLastModified { get; set; }
        public Guid MessageGuid { get; set; }
        public double? MessageRatingValue { get; set; }
        public int? GroupId { get; set; }
        public Guid? GroupGuid { get; set; }
        public DateTime? GroupLastModified { get; set; }
        public int? GroupSiteId { get; set; }
        public string? GroupDisplayName { get; set; }
        public string? GroupName { get; set; }
        public string? GroupDescription { get; set; }
        public Guid? GroupNodeGuid { get; set; }
        public int? GroupApproveMembers { get; set; }
        public int? GroupAccess { get; set; }
        public int? GroupCreatedByUserId { get; set; }
        public int? GroupApprovedByUserId { get; set; }
        public int? GroupAvatarId { get; set; }
        public bool? GroupApproved { get; set; }
        public DateTime? GroupCreatedWhen { get; set; }
        public bool? GroupSendJoinLeaveNotification { get; set; }
        public bool? GroupSendWaitingForApprovalNotification { get; set; }
        public int? GroupSecurity { get; set; }
    }
}
