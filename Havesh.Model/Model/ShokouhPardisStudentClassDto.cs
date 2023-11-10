using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisStudentClassDto : BranchBaseModel
{
    [Key]
    public int Id { get; set; }
	public long StudentIdno { get; set; }
	public string StudentName { get; set; } = null!;
	public string StudentFamily { get; set; } = null!;
	public int? StudentShno { get; set; }
	public DateTime? StudentBirthDay { get; set; }
	public string? StudentFatherName { get; set; }
	public string? FatherJob { get; set; }
	public string? StudentMotherFullName { get; set; }
	public string? MotherJob { get; set; }
	public string? StudentAddress { get; set; }
	public string? StudentFrom { get; set; }
	public Guid StudentClassGuid { get; set; }
	public DateTime StudentClassLastModified { get; set; }
}