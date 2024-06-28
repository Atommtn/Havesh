using Havesh.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Havesh.Model.Model
{
    internal class FollowUp : BranchBaseModel
    {

        public DateTime? FollowDate { get; set; }
        public int TermId { get; set; }
        public int StudentId { get; set; }
        public string? ReasonFollow { get; set; }
        public string? ResultFollow { get; set; }
        public int ReferralToUserId { get; set; }
        public int? LastFollowUpId { get; set; }
        public Guid FollowUpGuid { get; set; }
        public DateTime FollowUpLastModified { get; set; }
    }
}
