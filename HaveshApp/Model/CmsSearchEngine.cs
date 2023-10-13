using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsSearchEngine
    {
        public int SearchEngineId { get; set; }
        public string SearchEngineDisplayName { get; set; } = null!;
        public string SearchEngineName { get; set; } = null!;
        public string SearchEngineDomainRule { get; set; } = null!;
        public string? SearchEngineKeywordParameter { get; set; }
        public Guid SearchEngineGuid { get; set; }
        public DateTime SearchEngineLastModified { get; set; }
        public string? SearchEngineCrawler { get; set; }
    }
}
