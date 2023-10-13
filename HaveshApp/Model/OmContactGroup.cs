using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class OmContactGroup
    {
        public OmContactGroup()
        {
            NewsletterIssueContactGroups = new HashSet<NewsletterIssueContactGroup>();
            OmContactGroupMembers = new HashSet<OmContactGroupMember>();
        }

        public int ContactGroupId { get; set; }
        public string ContactGroupName { get; set; } = null!;
        public string ContactGroupDisplayName { get; set; } = null!;
        public string? ContactGroupDescription { get; set; }
        public string? ContactGroupDynamicCondition { get; set; }
        public bool? ContactGroupEnabled { get; set; }
        public DateTime? ContactGroupLastModified { get; set; }
        public Guid? ContactGroupGuid { get; set; }
        public int? ContactGroupStatus { get; set; }

        public virtual ICollection<NewsletterIssueContactGroup> NewsletterIssueContactGroups { get; set; }
        public virtual ICollection<OmContactGroupMember> OmContactGroupMembers { get; set; }
    }
}
