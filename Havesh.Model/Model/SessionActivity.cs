using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;
using MudBlazor;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
[Table("ShokouhPardis_SessionActivity")]
public partial class SessionActivity : BranchBaseModel
{
	[Id(0)]
	public string ActivityTitle { get; set; }
	[Id(1)]
	public string? Levels { get; set; }
	[Id(2)]
	public string? LevelGroups { get; set; }
	[Id(3)]
	public int? SessionNo { get; set; }

	[Id(4)]
	public string? Description { get; set; }
	[Id(5)]
	public Color? Color { get; set; } = MudBlazor.Color.Info;

	[Id(6)]
	public string? IconName { get; set; } = "Person";
	[Id(7)]
	public string? Icon { get; set; } = Icons.Material.Filled.Person;
	[Id(8)]
	public Color? IconColor { get; set; } = MudBlazor.Color.Default;
	[Id(9)]
	public int? IconSize { get; set; } = 54;

	[Id(10)]
	public string ValueType { get; set; } = "string";

	//public string? ValueOptions { get; set; }
	[Id(11)]
	public bool? ValueOptionsCanMultiple { get; set; }
	[Id(12)]
	public string? ValueControl { get; set; }

	[ForeignKey("SessionActivityFk")]
	[Id(13)]
	public List<SessionActivityValueOption> ValueOptions { get; set; }

	[Id(14)]
	public Guid SessionActivityGuid { get; set; }
	[Id(15)]
	public DateTime SessionActivityLastModified { get; set; }

	[Id(16)]
	public bool IsDefault { get; set; }
}
