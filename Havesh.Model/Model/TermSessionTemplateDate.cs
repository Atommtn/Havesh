using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
[Table("ShokouhPardis_TermSessionTemplateDate")]
public partial class TermSessionTemplateDate : BranchBaseModel
{
	[Id(0)]
	public int TermSessionTemplateFk { get; set; }
	
	[Id(1)]
	public int SessionNumber { get; set; }

	[Id(2)]
	public DateTime? Date { get; set; }

	[Id(3)]
	public string? Description { get; set; }
}