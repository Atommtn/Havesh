using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public partial class TermSessionTemplate
{
	[ForeignKey(nameof(Model.TermSessionTemplate.TermFk))]
	public ShokouhPardisTermClass Term { get; set; }
}