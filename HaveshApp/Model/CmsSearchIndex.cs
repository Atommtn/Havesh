using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CmsSearchIndex
    {
        public CmsSearchIndex()
        {
            IndexCultures = new HashSet<CmsCulture>();
            IndexSites = new HashSet<CmsSite>();
        }

        public int IndexId { get; set; }
        public string IndexName { get; set; } = null!;
        public string IndexDisplayName { get; set; } = null!;
        public string? IndexAnalyzerType { get; set; }
        public bool IndexIsCommunityGroup { get; set; }
        public string? IndexSettings { get; set; }
        public Guid IndexGuid { get; set; }
        public DateTime IndexLastModified { get; set; }
        public DateTime? IndexLastRebuildTime { get; set; }
        public string IndexType { get; set; } = null!;
        public string? IndexStopWordsFile { get; set; }
        public string? IndexCustomAnalyzerAssemblyName { get; set; }
        public string? IndexCustomAnalyzerClassName { get; set; }
        public int? IndexBatchSize { get; set; }
        public string? IndexStatus { get; set; }
        public DateTime? IndexLastUpdate { get; set; }
        public string? IndexCrawlerUserName { get; set; }
        public string? IndexCrawlerFormsUserName { get; set; }
        public string? IndexCrawlerUserPassword { get; set; }
        public string? IndexCrawlerDomain { get; set; }
        public bool? IndexIsOutdated { get; set; }
        public string IndexProvider { get; set; } = null!;
        public string? IndexSearchServiceName { get; set; }
        public string? IndexAdminKey { get; set; }
        public string? IndexQueryKey { get; set; }

        public virtual ICollection<CmsCulture> IndexCultures { get; set; }
        public virtual ICollection<CmsSite> IndexSites { get; set; }
    }
}
