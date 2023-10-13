using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ContentBlogMonth
    {
        public int BlogMonthId { get; set; }
        public string BlogMonthName { get; set; } = null!;
        public DateTime BlogMonthStartingDate { get; set; }
    }
}
