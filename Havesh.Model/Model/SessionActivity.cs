using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;
using MudBlazor;

namespace Havesh.Model.Model;

[Table("ShokouhPardis_SessionActivity")]
public partial class SessionActivity : BranchBaseModel
{
	[Key]
	public int SessionActivityID { get; set; }
	public string ActivityTitle { get; set; }
	public string? Levels { get; set; }
	public string? LevelGroups { get; set; }
	public int? SessionNo { get; set; }

    public string? Description { get; set; }
    public Color? Color { get; set; } = MudBlazor.Color.Info;

    public string? IconName { get; set; } = "Person";
    public string? Icon { get; set; } = Icons.Material.Filled.Person;
    public Color? IconColor { get; set; } = MudBlazor.Color.Default;
    public int? IconSize { get; set; } = 54;

    public string ValueType { get; set; } = "string";
	//public string? ValueOptions { get; set; }
	public bool? ValueOptionsCanMultiple { get; set; }
	public string? ValueControl { get; set; }

	[ForeignKey("SessionActivityFk")]
	public List<SessionActivityValueOption> ValueOptions { get; set; }

	public Guid SessionActivityGuid { get; set; }
	public DateTime SessionActivityLastModified { get; set; }
}