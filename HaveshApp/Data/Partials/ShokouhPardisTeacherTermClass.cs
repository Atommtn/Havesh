using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Model
{
    public partial class ShokouhPardisTeacherTermClass
    {
        [ForeignKey(nameof(TeacherFk))]
        public ShokouhPardisTeacherClass Teacher { get; set; }

        [ForeignKey(nameof(TermFk))]
        public ShokouhPardisTermClass Term { get; set; }
    }

}
