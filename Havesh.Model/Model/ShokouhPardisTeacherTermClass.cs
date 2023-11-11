using Havesh.Model.Data;

namespace Havesh.Model.Model;

public partial class ShokouhPardisTeacherTermClass : BranchBaseModel
{

	public Guid Guid { get; set; }
	public DateTime LastModified { get; set; }
	public int TeacherFk { get; set; }
	public int TermFk { get; set; }
}