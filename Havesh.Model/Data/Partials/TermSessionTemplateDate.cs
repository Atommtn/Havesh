using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public partial class TermSessionTemplateDate
{
	[ForeignKey(nameof(Model.TermSessionTemplateDate.TermSessionTemplateFk))]
	public TermSessionTemplate TermSessionTemplate { get; set; }
}