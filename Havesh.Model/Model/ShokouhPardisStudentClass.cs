using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisStudentClass : BranchBaseModel
{

	public Guid StudentClassGuid { get; set; }
	public DateTime StudentClassLastModified { get; set; }
	public string StudentName { get; set; } = null!;
	public string StudentFamily { get; set; } = null!;
	public DateTime? StudentBirthDay { get; set; }
	public string? StudentFatherName { get; set; }
	public string? StudentMotherFullName { get; set; }
	public string StudentIdno { get; set; } = null!;
	public string? FatherJob { get; set; }
	public string? MotherJob { get; set; }
	public string? StudentAddress { get; set; }
	public string? StudentFrom { get; set; }
	public int? StudentShno { get; set; }
	public string? StudentPhone { get; set; }
	public string? FatherPhone { get; set; }
	public string? MotherPhone { get; set; }
	public string? HomePhone { get; set; }
	public string? WhatsAppPhone { get; set; }

	public bool? Gender { get; set; }
}