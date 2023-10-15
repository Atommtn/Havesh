using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class CiFileMetadatum
    {
        public int FileMetadataId { get; set; }
        public string FileLocation { get; set; } = null!;
        public string FileHash { get; set; } = null!;
    }
}
