using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsScheduledTask
    {
        public CmsScheduledTask()
        {
            AnalyticsCampaigns = new HashSet<AnalyticsCampaign>();
            NewsletterAbtests = new HashSet<NewsletterAbtest>();
            NewsletterNewsletters = new HashSet<NewsletterNewsletter>();
        }

        public int TaskId { get; set; }
        public string TaskName { get; set; } = null!;
        public string TaskDisplayName { get; set; } = null!;
        public string TaskAssemblyName { get; set; } = null!;
        public string? TaskClass { get; set; }
        public string TaskInterval { get; set; } = null!;
        public string TaskData { get; set; } = null!;
        public DateTime? TaskLastRunTime { get; set; }
        public DateTime? TaskNextRunTime { get; set; }
        public string? TaskLastResult { get; set; }
        public int? TaskSiteId { get; set; }
        public bool? TaskDeleteAfterLastRun { get; set; }
        public string? TaskServerName { get; set; }
        public Guid TaskGuid { get; set; }
        public DateTime TaskLastModified { get; set; }
        public int? TaskExecutions { get; set; }
        public int? TaskResourceId { get; set; }
        public bool? TaskRunInSeparateThread { get; set; }
        public bool? TaskUseExternalService { get; set; }
        public bool? TaskAllowExternalService { get; set; }
        public DateTime? TaskLastExecutionReset { get; set; }
        public string? TaskCondition { get; set; }
        public bool? TaskRunIndividually { get; set; }
        public int? TaskUserId { get; set; }
        public int? TaskType { get; set; }
        public string? TaskObjectType { get; set; }
        public int? TaskObjectId { get; set; }
        public string? TaskExecutingServerName { get; set; }
        public bool TaskEnabled { get; set; }
        public bool TaskIsRunning { get; set; }

        public virtual CmsResource? TaskResource { get; set; }
        public virtual CmsSite? TaskSite { get; set; }
        public virtual CmsUser? TaskUser { get; set; }
        public virtual ICollection<AnalyticsCampaign> AnalyticsCampaigns { get; set; }
        public virtual ICollection<NewsletterAbtest> NewsletterAbtests { get; set; }
        public virtual ICollection<NewsletterNewsletter> NewsletterNewsletters { get; set; }
    }
}
