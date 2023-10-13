using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShokouhApp.Model
{
    [Table("ShokouhPardis_PreRegistration")]
    public partial class PreRegistration
    {

        [Key]
        public int Id { get; set; }
        
        public int DailyJVFk { get; set; }
        
        public int StudentFk { get; set; }
        
        public int TermFk { get; set; }
        public int LevelFk { get; set; }
        public bool? IsArchive { get; set; }
        public Guid PreRegistrationGuid { get; set; }
        public DateTime PreRegistrationLastModified { get; set; }
    }
}
