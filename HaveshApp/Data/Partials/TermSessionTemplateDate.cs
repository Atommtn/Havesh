using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Model
{
    public partial class TermSessionTemplateDate
    {
        [ForeignKey(nameof(TermSessionTemplateFk))]
        public TermSessionTemplate TermSessionTemplate { get; set; }
    }
}
