using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class CmsMetaFile
    {
        public int MetaFileId { get; set; }
        public int MetaFileObjectId { get; set; }
        public string MetaFileObjectType { get; set; } = null!;
        public string? MetaFileGroupName { get; set; }
        public string MetaFileName { get; set; } = null!;
        public string MetaFileExtension { get; set; } = null!;
        public int MetaFileSize { get; set; }
        public string MetaFileMimeType { get; set; } = null!;
        public byte[]? MetaFileBinary { get; set; }
        public int? MetaFileImageWidth { get; set; }
        public int? MetaFileImageHeight { get; set; }
        public Guid MetaFileGuid { get; set; }
        public DateTime MetaFileLastModified { get; set; }
        public int? MetaFileSiteId { get; set; }
        public string? MetaFileTitle { get; set; }
        public string? MetaFileDescription { get; set; }
        public string? MetaFileCustomData { get; set; }

        public virtual CmsSite? MetaFileSite { get; set; }
    }
}
