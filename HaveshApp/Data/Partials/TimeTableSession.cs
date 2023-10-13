using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShokouhApp.Model
{
    public partial class TimeTableSession
    {
        public ShokouhPardisTimeTable TimeTable { get; set; }

        [ForeignKey(nameof(TeacherFk))]
        public ShokouhPardisTeacherClass Teacher { get; set; }

        [ForeignKey(nameof(ReplacementTimeTableSessionFk))]
        public Model.TimeTableSession ReplacementSession { get; set; }

        [ForeignKey(nameof(ClassRoomFk))]
        public ShokouhPardisClassRoom ClassRoom { get; set; }

    }
}
