using System;
using System.Collections.Generic;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisTeacherLevel
    {
        public int TeacherLevelsId { get; set; }
        public Guid TeacherLevelsGuid { get; set; }
        public DateTime TeacherLevelsLastModified { get; set; }
        public int TeacherId { get; set; }
        public int LevelId { get; set; }
        public int? ProficiencyLevel { get; set; }
    }
}
