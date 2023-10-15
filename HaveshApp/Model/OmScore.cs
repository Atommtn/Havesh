using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OmScore
    {
        public OmScore()
        {
            OmRules = new HashSet<OmRule>();
            OmScoreContactRules = new HashSet<OmScoreContactRule>();
        }

        public int ScoreId { get; set; }
        public string ScoreName { get; set; } = null!;
        public string ScoreDisplayName { get; set; } = null!;
        public string? ScoreDescription { get; set; }
        public bool ScoreEnabled { get; set; }
        public int? ScoreEmailAtScore { get; set; }
        public string? ScoreNotificationEmail { get; set; }
        public DateTime ScoreLastModified { get; set; }
        public Guid ScoreGuid { get; set; }
        public int? ScoreStatus { get; set; }
        public int? ScoreScheduledTaskId { get; set; }
        public bool ScoreBelongsToPersona { get; set; }

        public virtual ICollection<OmRule> OmRules { get; set; }
        public virtual ICollection<OmScoreContactRule> OmScoreContactRules { get; set; }
    }
}
