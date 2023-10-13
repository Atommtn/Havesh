using System;
using System.Collections.Generic;

namespace ShokouhApp.Model
{
    public partial class ShokouhPardisCourse
    {
        public int CourseId { get; set; }
        public Guid CourseGuid { get; set; }
        public DateTime CourseLastModified { get; set; }
        public int TermId { get; set; }
        public int ClassRoomId { get; set; }
        public int ScheduleId { get; set; }
        public int LevelId { get; set; }
        public int TeacherId { get; set; }
        public string? CourseTitle { get; set; }
    }
}
