using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisTeacherLevel : BranchBaseModel
{

	public Guid TeacherLevelsGuid { get; set; }
	public DateTime TeacherLevelsLastModified { get; set; }
	public int TeacherId { get; set; }
	public int LevelId { get; set; }
	public int? ProficiencyLevel { get; set; }
}