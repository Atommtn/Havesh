using System.ComponentModel.DataAnnotations.Schema;
using ShokouhApp.Admin.MemberShip.Model;
using ShokouhApp.Model;

namespace ShokouhApp.Model
{
    public partial class PreRegistration
    {
        [ForeignKey(nameof(StudentFk))]
        public ShokouhPardisStudentClass Student { get; set; }
        
        [ForeignKey(nameof(TermFk))]
        public ShokouhPardisTermClass Term { get; set; }

        [ForeignKey(nameof(DailyJVFk))]
        public ShokouhPardisDailyJv DailyJV { get; set; }  
        [ForeignKey(nameof(LevelFk))]
        public ShokouhPardisLevelClass Level { get; set; }

        public static PreRegistration CreatePreRegistration()
        {
            var prePegistration = new PreRegistration
            {
                PreRegistrationGuid = Guid.NewGuid(),
                PreRegistrationLastModified = DateTime.Today
                
            };
            return prePegistration;
        }

    }
}
