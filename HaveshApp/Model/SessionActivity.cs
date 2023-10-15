using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Model
{
    [Table("ShokouhPardis_SessionActivity")]
    public partial class SessionActivity
    {
        [Key]
        public int SessionActivityID { get; set; }
        public string ActivityTitle { get; set; }
        public string? Levels { get; set; }
        public string? LevelGroups { get; set; }
        public int? SessionNo { get; set; }

        public string ValueType { get; set; } = "string";
        //public string? ValueOptions { get; set; }
        public bool? ValueOptionsCanMultiple { get; set; }
        public string? ValueControl { get; set; }

        [ForeignKey("SessionActivityFk")]
        public List<SessionActivityValueOption> ValueOptions { get; set; }

        public Guid SessionActivityGuid { get; set; }
        public DateTime SessionActivityLastModified { get; set; }

    }
}
