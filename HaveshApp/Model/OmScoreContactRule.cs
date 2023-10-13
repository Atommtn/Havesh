using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class OmScoreContactRule
    {
        public int ScoreId { get; set; }
        public int ContactId { get; set; }
        public int RuleId { get; set; }
        public int Value { get; set; }
        public DateTime? Expiration { get; set; }
        public int ScoreContactRuleId { get; set; }

        public virtual OmContact Contact { get; set; } = null!;
        public virtual OmRule Rule { get; set; } = null!;
        public virtual OmScore Score { get; set; } = null!;
    }
}
