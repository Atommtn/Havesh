using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class TempFile
    {
        public int FileId { get; set; }
        public Guid FileParentGuid { get; set; }
        public int FileNumber { get; set; }
        public string FileExtension { get; set; } = null!;
        public long FileSize { get; set; }
        public string FileMimeType { get; set; } = null!;
        public int? FileImageWidth { get; set; }
        public int? FileImageHeight { get; set; }
        public byte[]? FileBinary { get; set; }
        public Guid FileGuid { get; set; }
        public DateTime FileLastModified { get; set; }
        public string FileDirectory { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string? FileTitle { get; set; }
        public string? FileDescription { get; set; }
    }
}
