using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class MediaFile
    {
        public int FileId { get; set; }
        public string FileName { get; set; } = null!;
        public string FileTitle { get; set; } = null!;
        public string FileDescription { get; set; } = null!;
        public string FileExtension { get; set; } = null!;
        public string FileMimeType { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public long FileSize { get; set; }
        public int? FileImageWidth { get; set; }
        public int? FileImageHeight { get; set; }
        public Guid FileGuid { get; set; }
        public int FileLibraryId { get; set; }
        public int FileSiteId { get; set; }
        public int? FileCreatedByUserId { get; set; }
        public DateTime FileCreatedWhen { get; set; }
        public int? FileModifiedByUserId { get; set; }
        public DateTime FileModifiedWhen { get; set; }
        public string? FileCustomData { get; set; }

        public virtual CmsUser? FileCreatedByUser { get; set; }
        public virtual MediaLibrary FileLibrary { get; set; } = null!;
        public virtual CmsUser? FileModifiedByUser { get; set; }
        public virtual CmsSite FileSite { get; set; } = null!;
    }
}
