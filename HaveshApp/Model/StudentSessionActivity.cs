using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Extensions.Primitives;

namespace ShokouhApp.Model
{
    public partial class StudentSessionActivity
    {
        [ForeignKey(nameof(StudentFk))]
        public ShokouhPardisStudentClass Student { get; set; }

        [ForeignKey(nameof(TimeTableSessionFk))]
        public TimeTableSession TimeTableSession { get; set; }

        [ForeignKey(nameof(ActivityFk))]
        public SessionActivity Activity { get; set; }

    }


    [Table("ShokouhPardis_StudentSessionActivity")]
    public partial class StudentSessionActivity
    {
        [Key]
        public int StudentSessionActivityID { get; set; }
        public int TimeTableSessionFk { get; set; }

        public int StudentFk { get; set; }
        public int ActivityFk { get; set; }
        public string? ActivityValue { get; set; }
        public string? Status { get; set; }
        public string? Description { get; set; }

        public DateTime? ActivityDateTime { get; set; }
        public DateTime? ActivityDeletedDateTime { get; set; }

        public Guid StudentSessionActivityGuid { get; set; }
        public DateTime StudentSessionActivityLastModified { get; set; }
    }
}
