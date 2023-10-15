using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ViewCmsSiteDocumentCount
    {
        public int SiteId { get; set; }
        public string SiteName { get; set; } = null!;
        public string SiteDisplayName { get; set; } = null!;
        public string? SiteDescription { get; set; }
        public string SiteStatus { get; set; } = null!;
        public string SiteDomainName { get; set; } = null!;
        public int? SiteDefaultStylesheetId { get; set; }
        public string? SiteDefaultVisitorCulture { get; set; }
        public int? SiteDefaultEditorStylesheet { get; set; }
        public Guid SiteGuid { get; set; }
        public DateTime SiteLastModified { get; set; }
        public bool? SiteIsContentOnly { get; set; }
        public int? Documents { get; set; }
        public bool? SiteIsOffline { get; set; }
    }
}
