using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisBookClass
    {
        public int BookClassId { get; set; }
        public Guid BookClassGuid { get; set; }
        public DateTime BookClassLastModified { get; set; }
        public string? BookName { get; set; }
        public string? BookPic { get; set; }
        public string? BookDes { get; set; }
    }
}
