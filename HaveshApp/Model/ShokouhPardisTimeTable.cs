using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisTimeTable
    {
        public int TimeTableId { get; set; }
        public Guid TimeTableGuid { get; set; }
        public DateTime TimeTableLastModified { get; set; }
        public int TermId { get; set; }
        public int TeacherId { get; set; }
        public int ScheduleId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int LevelId { get; set; }
        public int ClassRoomId { get; set; }
        public bool IsPrivate { get; set; }
    }
}
