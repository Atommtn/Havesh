using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisStudentClass : BranchBaseModel
{
	[Id(0)]
	public Guid StudentClassGuid { get; set; }
	[Id(1)]
	public DateTime StudentClassLastModified { get; set; }
	[Id(2)]
	public string StudentName { get; set; } = null!;
	[Id(3)]
	public string StudentFamily { get; set; } = null!;
	[Id(4)]
	public DateTime? StudentBirthDay { get; set; }
	[Id(5)]
	public string? StudentFatherName { get; set; }
	[Id(6)]
	public string? StudentMotherFullName { get; set; }
	[Id(7)]
	public string StudentIdno { get; set; } = null!;
	[Id(8)]
	public string? FatherJob { get; set; }
	[Id(9)]
	public string? MotherJob { get; set; }
	[Id(10)]
	public string? StudentAddress { get; set; }
	[Id(11)]
	public string? StudentFrom { get; set; }
	[Id(12)]
	public int? StudentShno { get; set; }
	[Id(13)]
	public string? StudentPhone { get; set; }
	[Id(14)]
	public string? FatherPhone { get; set; }
	[Id(15)]
	public string? MotherPhone { get; set; }
	[Id(16)]
	public string? HomePhone { get; set; }
	[Id(17)]
	public string? WhatsAppPhone { get; set; }

	[Id(18)]
	public bool? Gender { get; set; }
}