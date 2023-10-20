using HaveshApp.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Model
{
    [Table("ShokouhPardis_TermSessionTemplateDate")]
    public partial class TermSessionTemplateDate : BranchBaseModel
	{
        [Key]
        public int TermSessionTemplateDateID { get; set; }
        public int TermSessionTemplateFk { get; set; }
        public int SessionNumber { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
    }

}
