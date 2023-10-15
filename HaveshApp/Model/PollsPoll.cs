using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class PollsPoll
    {
        public PollsPoll()
        {
            PollsPollAnswers = new HashSet<PollsPollAnswer>();
            Roles = new HashSet<CmsRole>();
            Sites = new HashSet<CmsSite>();
        }

        public int PollId { get; set; }
        public string PollCodeName { get; set; } = null!;
        public string PollDisplayName { get; set; } = null!;
        public string? PollTitle { get; set; }
        public DateTime? PollOpenFrom { get; set; }
        public DateTime? PollOpenTo { get; set; }
        public bool PollAllowMultipleAnswers { get; set; }
        public string PollQuestion { get; set; } = null!;
        public int PollAccess { get; set; }
        public string? PollResponseMessage { get; set; }
        public Guid PollGuid { get; set; }
        public DateTime PollLastModified { get; set; }
        public int? PollGroupId { get; set; }
        public int? PollSiteId { get; set; }
        public bool? PollLogActivity { get; set; }

        public virtual CommunityGroup? PollGroup { get; set; }
        public virtual CmsSite? PollSite { get; set; }
        public virtual ICollection<PollsPollAnswer> PollsPollAnswers { get; set; }

        public virtual ICollection<CmsRole> Roles { get; set; }
        public virtual ICollection<CmsSite> Sites { get; set; }
    }
}
