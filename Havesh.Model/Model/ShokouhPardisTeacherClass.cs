using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisTeacherClass : BranchBaseModel
{
    [Key]
    public int Id { get; set; }
	public string? TeacherNationalId { get; set; }
	public Guid TeacherClassGuid { get; set; }
	public DateTime TeacherClassLastModified { get; set; }
	public string TeacherName { get; set; } = null!;
	public string TeacherFamily { get; set; } = null!;
	public bool? TeacherSex { get; set; }
	public DateTime? TeacherBirthDay { get; set; }
	public string? TeacherPic { get; set; }
	public int TermId { get; set; }
	public int? UserId { get; set; }

}