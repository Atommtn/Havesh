using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Model
{
    public partial class TermSessionTemplate
    {
        [ForeignKey(nameof(TermFk))]
        public ShokouhPardisTermClass Term { get; set; }
    }
}
