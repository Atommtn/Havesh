using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class PageBookPageType
    {
        public int BookPageTypeId { get; set; }
        public string BookName { get; set; } = null!;
        public string? BookDes { get; set; }
        public Guid? BookPic { get; set; }
        public string? BookType { get; set; }
    }
}
