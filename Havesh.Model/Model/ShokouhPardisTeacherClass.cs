using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisTeacherClass : BranchBaseModel
{
	[Id(0)]
	public string? TeacherNationalId { get; set; }
	[Id(1)]
	public Guid TeacherClassGuid { get; set; }
	[Id(2)]
	public DateTime TeacherClassLastModified { get; set; }
	[Id(3)]
	public string TeacherName { get; set; } = null!;
	[Id(4)]
	public string TeacherFamily { get; set; } = null!;
	[Id(5)]
	public bool? TeacherSex { get; set; }
	[Id(6)]
	public DateTime? TeacherBirthDay { get; set; }
	[Id(7)]
	public string? TeacherPic { get; set; }
	[Id(8)]
	public int TermId { get; set; }
	[Id(9)]
	public int? UserId { get; set; }

}