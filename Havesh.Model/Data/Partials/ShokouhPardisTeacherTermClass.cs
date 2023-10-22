using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public partial class ShokouhPardisTeacherTermClass
{
	[ForeignKey(nameof(Model.ShokouhPardisTeacherTermClass.TeacherFk))]
	public ShokouhPardisTeacherClass Teacher { get; set; }

	[ForeignKey(nameof(Model.ShokouhPardisTeacherTermClass.TermFk))]
	public ShokouhPardisTermClass Term { get; set; }
}