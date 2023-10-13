using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class PageBookCalssRecord
    {
        public int BookCalssRecordId { get; set; }
        public string RecordUrl { get; set; } = null!;
        public string TeacherName { get; set; } = null!;
        public string? SessionNo { get; set; }
    }
}
