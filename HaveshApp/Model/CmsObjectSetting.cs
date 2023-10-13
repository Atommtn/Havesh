using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsObjectSetting
    {
        public int ObjectSettingsId { get; set; }
        public string? ObjectTags { get; set; }
        public int? ObjectCheckedOutByUserId { get; set; }
        public DateTime? ObjectCheckedOutWhen { get; set; }
        public int? ObjectCheckedOutVersionHistoryId { get; set; }
        public int? ObjectWorkflowStepId { get; set; }
        public int? ObjectPublishedVersionHistoryId { get; set; }
        public int ObjectSettingsObjectId { get; set; }
        public string ObjectSettingsObjectType { get; set; } = null!;
        public string? ObjectComments { get; set; }
        public bool? ObjectWorkflowSendEmails { get; set; }

        public virtual CmsUser? ObjectCheckedOutByUser { get; set; }
        public virtual CmsObjectVersionHistory? ObjectCheckedOutVersionHistory { get; set; }
        public virtual CmsObjectVersionHistory? ObjectPublishedVersionHistory { get; set; }
        public virtual CmsWorkflowStep? ObjectWorkflowStep { get; set; }
    }
}
