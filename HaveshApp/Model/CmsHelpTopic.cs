using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsHelpTopic
    {
        public int HelpTopicId { get; set; }
        public int HelpTopicUielementId { get; set; }
        public string HelpTopicName { get; set; } = null!;
        public string HelpTopicLink { get; set; } = null!;
        public DateTime HelpTopicLastModified { get; set; }
        public Guid HelpTopicGuid { get; set; }
        public int? HelpTopicOrder { get; set; }
        public string? HelpTopicVisibilityCondition { get; set; }

        public virtual CmsUielement HelpTopicUielement { get; set; } = null!;
    }
}
