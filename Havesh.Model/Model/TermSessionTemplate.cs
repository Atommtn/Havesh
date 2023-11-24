using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;

namespace Havesh.Model.Model;


[Serializable]
[GenerateSerializer]
[Table("ShokouhPardis_TermSessionTemplate")]
public partial class TermSessionTemplate : BranchBaseModel
{
	[Id(0)]
	public int TermFk { get; set; }

	[Id(1)]
	public string TemplateName { get; set; }

	[Id(2)]
	public string? Description { get; set; }

	[Id(3)]
	public string WeekdayIds { get; set; } // Comma separated

}