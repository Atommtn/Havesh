using System.ComponentModel.DataAnnotations.Schema;

namespace ShokouhApp.Model
{
    public partial class ShokouhPardisLevelClass
    {
        [ForeignKey(nameof(NextLevelFk))]
        public ShokouhPardisLevelClass LevelClass { get; set; }
    }
}
