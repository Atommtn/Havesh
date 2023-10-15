using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisProgram
    {
        public int ProgramId { get; set; }
        public Guid ProgramGuid { get; set; }
        public DateTime ProgramLastModified { get; set; }
        public int ScheduleId { get; set; }
        public int DaysessionId { get; set; }
    }
}
