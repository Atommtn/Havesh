using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ContentFile
    {
        public int FileId { get; set; }
        public string? FileDescription { get; set; }
        public string FileName { get; set; } = null!;
        public Guid? FileAttachment { get; set; }
    }
}
