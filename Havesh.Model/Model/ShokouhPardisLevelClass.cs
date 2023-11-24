using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisLevelClass : BranchBaseModel
{
	[Id(0)]
	public Guid LevelClassGuid { get; set; }
	[Id(1)]
	public DateTime LevelClassLastModified { get; set; }
	[Id(2)]
	public string LevelName { get; set; } = null!;
	[Id(3)]
	public string? LevelDes { get; set; }
	[Id(4)]
	public string? Grouping { get; set; }
	[Id(5)]
	public int BookId { get; set; }
	[Id(6)]
	public int? NextLevelFk { get; set; }
}