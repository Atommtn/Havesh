using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class SharePointSharePointLibrary
    {
        public SharePointSharePointLibrary()
        {
            SharePointSharePointFiles = new HashSet<SharePointSharePointFile>();
        }

        public int SharePointLibraryId { get; set; }
        public string SharePointLibraryName { get; set; } = null!;
        public int? SharePointLibrarySharePointConnectionId { get; set; }
        public string SharePointLibraryListTitle { get; set; } = null!;
        public int SharePointLibrarySynchronizationPeriod { get; set; }
        public Guid SharePointLibraryGuid { get; set; }
        public int SharePointLibrarySiteId { get; set; }
        public string SharePointLibraryDisplayName { get; set; } = null!;
        public DateTime SharePointLibraryLastModified { get; set; }
        public int SharePointLibraryListType { get; set; }

        public virtual SharePointSharePointConnection? SharePointLibrarySharePointConnection { get; set; }
        public virtual CmsSite SharePointLibrarySite { get; set; } = null!;
        public virtual ICollection<SharePointSharePointFile> SharePointSharePointFiles { get; set; }
    }
}
