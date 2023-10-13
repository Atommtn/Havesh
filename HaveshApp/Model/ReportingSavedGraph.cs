using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ReportingSavedGraph
    {
        public int SavedGraphId { get; set; }
        public int SavedGraphSavedReportId { get; set; }
        public Guid SavedGraphGuid { get; set; }
        public byte[] SavedGraphBinary { get; set; } = null!;
        public string SavedGraphMimeType { get; set; } = null!;
        public DateTime SavedGraphLastModified { get; set; }

        public virtual ReportingSavedReport SavedGraphSavedReport { get; set; } = null!;
    }
}
