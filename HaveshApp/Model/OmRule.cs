using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OmRule
    {
        public OmRule()
        {
            OmScoreContactRules = new HashSet<OmScoreContactRule>();
        }

        public int RuleId { get; set; }
        public int RuleScoreId { get; set; }
        public string RuleDisplayName { get; set; } = null!;
        public string RuleName { get; set; } = null!;
        public int RuleValue { get; set; }
        public bool? RuleIsRecurring { get; set; }
        public int? RuleMaxPoints { get; set; }
        public DateTime? RuleValidUntil { get; set; }
        public string? RuleValidity { get; set; }
        public int? RuleValidFor { get; set; }
        public int RuleType { get; set; }
        public string? RuleParameter { get; set; }
        public string RuleCondition { get; set; } = null!;
        public DateTime RuleLastModified { get; set; }
        public Guid RuleGuid { get; set; }
        public bool RuleBelongsToPersona { get; set; }

        public virtual OmScore RuleScore { get; set; } = null!;
        public virtual ICollection<OmScoreContactRule> OmScoreContactRules { get; set; }
    }
}
