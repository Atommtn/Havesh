using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShokouhApp.Model
{
    [Table("ShokouhPardis_TermSessionTemplate")]
    public partial class TermSessionTemplate
    {
        [Key]
        public int TermSessionTemplateID { get; set; }
        public int TermFk { get; set; }
        public string TemplateName { get; set; }

        public string? Description { get; set; }

        public string WeekdayIds { get; set; } // Comma separated

    }
}
