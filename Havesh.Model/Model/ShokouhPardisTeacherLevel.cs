using Havesh.Model.Data;

namespace Havesh.Model.Model;

public partial class ShokouhPardisTeacherLevel : BranchBaseModel
{
	public int TeacherLevelsId { get; set; }
	public Guid TeacherLevelsGuid { get; set; }
	public DateTime TeacherLevelsLastModified { get; set; }
	public int TeacherId { get; set; }
	public int LevelId { get; set; }
	public int? ProficiencyLevel { get; set; }
}