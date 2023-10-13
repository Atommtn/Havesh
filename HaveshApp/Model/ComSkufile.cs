using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ComSkufile
    {
        public ComSkufile()
        {
            ComOrderItemSkufiles = new HashSet<ComOrderItemSkufile>();
        }

        public int FileId { get; set; }
        public Guid FileGuid { get; set; }
        public int FileSkuid { get; set; }
        public string FilePath { get; set; } = null!;
        public string FileType { get; set; } = null!;
        public DateTime FileLastModified { get; set; }
        public string FileName { get; set; } = null!;
        public Guid? FileMetaFileGuid { get; set; }

        public virtual ComSku FileSku { get; set; } = null!;
        public virtual ICollection<ComOrderItemSkufile> ComOrderItemSkufiles { get; set; }
    }
}
