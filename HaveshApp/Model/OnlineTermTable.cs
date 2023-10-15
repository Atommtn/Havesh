using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class OnlineTermTable
    {
        public int ItemId { get; set; }
        public int? ItemCreatedBy { get; set; }
        public DateTime? ItemCreatedWhen { get; set; }
        public int? ItemModifiedBy { get; set; }
        public DateTime? ItemModifiedWhen { get; set; }
        public int? ItemOrder { get; set; }
        public Guid ItemGuid { get; set; }
        public string DayOf { get; set; } = null!;
        public string TimOf { get; set; } = null!;
        public string Level { get; set; } = null!;
        public string TeacherName { get; set; } = null!;
        public string? NewProgram { get; set; }
    }
}
