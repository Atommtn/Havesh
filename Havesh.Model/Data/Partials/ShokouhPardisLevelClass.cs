using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public partial class ShokouhPardisLevelClass
{
	[ForeignKey(nameof(Model.ShokouhPardisLevelClass.NextLevelFk))]
	public ShokouhPardisLevelClass LevelClass { get; set; }
}