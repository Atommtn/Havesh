using System;
using System.Collections;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisSchedule 
    {
        public int TermFk { get; set; }
        public int ScheduleId { get; set; }
        public Guid ScheduleGuid { get; set; }
        public DateTime ScheduleLastModified { get; set; }
        public string Title { get; set; } = null!;
       
    }
}
