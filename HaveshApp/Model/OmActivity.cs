using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OmActivity
    {
        public int ActivityId { get; set; }
        public int ActivityContactId { get; set; }
        public DateTime? ActivityCreated { get; set; }
        public string ActivityType { get; set; } = null!;
        public int? ActivityItemId { get; set; }
        public int? ActivityItemDetailId { get; set; }
        public string? ActivityValue { get; set; }
        public string? ActivityUrl { get; set; }
        public string? ActivityTitle { get; set; }
        public int ActivitySiteId { get; set; }
        public string? ActivityComment { get; set; }
        public string? ActivityCampaign { get; set; }
        public string? ActivityUrlreferrer { get; set; }
        public string? ActivityCulture { get; set; }
        public int? ActivityNodeId { get; set; }
        public string? ActivityUtmsource { get; set; }
        public string? ActivityAbvariantName { get; set; }
        public string? ActivityMvtcombinationName { get; set; }
        public long ActivityUrlhash { get; set; }
        public string? ActivityUtmcontent { get; set; }
    }
}
