using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;

namespace Havesh.Model.Model;

[Table("ShokouhPardis_TermSessionTemplate")]
public partial class TermSessionTemplate : BranchBaseModel
{
	public int TermFk { get; set; }
	public string TemplateName { get; set; }

	public string? Description { get; set; }

	public string WeekdayIds { get; set; } // Comma separated

}