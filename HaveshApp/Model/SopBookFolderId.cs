using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class SopBookFolderId
    {
        public int BookFolderIdid { get; set; }
        public string BookLevel { get; set; } = null!;
        public string BookFolderId { get; set; } = null!;
        public string Branch { get; set; } = null!;
        public string Url { get; set; } = null!;
    }
}
