using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class SharePointSharePointFile
    {
        public int SharePointFileId { get; set; }
        public Guid SharePointFileGuid { get; set; }
        public int SharePointFileSiteId { get; set; }
        public string SharePointFileName { get; set; } = null!;
        public string? SharePointFileExtension { get; set; }
        public string? SharePointFileMimeType { get; set; }
        public string? SharePointFileEtag { get; set; }
        public long SharePointFileSize { get; set; }
        public DateTime SharePointFileServerLastModified { get; set; }
        public string SharePointFileServerRelativeUrl { get; set; } = null!;
        public int SharePointFileSharePointLibraryId { get; set; }
        public byte[]? SharePointFileBinary { get; set; }

        public virtual SharePointSharePointLibrary SharePointFileSharePointLibrary { get; set; } = null!;
        public virtual CmsSite SharePointFileSite { get; set; } = null!;
    }
}
