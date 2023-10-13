
using System.ComponentModel.DataAnnotations.Schema;

namespace ShokouhApp.Model
{
    public  partial class ShokouhPardisDailyJv
    {
        [ForeignKey("StudentId")]
        public ShokouhPardisStudentClass? Student { get; set; }

        [ForeignKey("TermId")] 
        public ShokouhPardisTermClass? Term { get; set; }

        [ForeignKey(nameof(TimeTableFk))] 
        public ShokouhPardisTimeTable? TimeTable { get; set; }

        public static ShokouhPardisDailyJv CreateNewDailyJV()
        {
            var dailyJv= new ShokouhPardisDailyJv
            {
                DailyJvguid = Guid.NewGuid(),
                DailyJvlastModified = DateTime.Today,
                CurrentDate = DateTime.Today
            };
            return dailyJv;
        }
        
    }
}
