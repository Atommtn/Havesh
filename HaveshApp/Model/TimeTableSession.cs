using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Model
{
    [Table("ShokouhPardis_TimeTableSession")]
    public partial class TimeTableSession
    {
        [Key]
        public int ID { get; set; }
        public int SessionNumber { get; set; }
        public int TimeTableFk { get; set; }
        public int TeacherFk { get; set; }
        public int? ReplacementTimeTableSessionFk { get; set; }
        public int ClassRoomFk { get; set; }
        public string SessionStatus { get; set; }
        public string? SessionDescription { get; set; }
        public DateTime? SessionDate { get; set; }
        public TimeSpan? SessionTime { get; set; }

    }

   

 


 

  
   
 


}
