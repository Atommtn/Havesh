using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisTeacherTimeSheet
    {
        public int TeacherTimeSheetId { get; set; }
        public Guid TeacherTimeSheetGuid { get; set; }
        public DateTime TeacherTimeSheetLastModified { get; set; }
        public int TeacherId { get; set; }
        public int TermId { get; set; }
        public int WeekDayId { get; set; }
        public int IntervalId { get; set; }
        public bool? IsAvailable { get; set; }
    }
}
