using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;

namespace Havesh.Model.Model;


public partial class StudentSessionActivity 
{
	[ForeignKey(nameof(StudentFk))]
	[Id(11)]
	public ShokouhPardisStudentClass Student { get; set; }

	[ForeignKey(nameof(TimeTableSessionFk))]
	[Id(12)]
	public TimeTableSession TimeTableSession { get; set; }

	[ForeignKey(nameof(ActivityFk))]
	[Id(13)]
	public SessionActivity Activity { get; set; }

	[Id(14)]
	public int ActivityValueOptionFk { get; set; }
	
	[Id(15)]
	[ForeignKey(nameof(ActivityValueOptionFk))]
	public SessionActivityValueOption ActivityValueOption { get; set; }

}


[Serializable]
[GenerateSerializer]
[Table("ShokouhPardis_StudentSessionActivity")]
public partial class StudentSessionActivity : BranchBaseModel
{
	[Id(0)]
	public int TimeTableSessionFk { get; set; }
	[Id(1)]
	public int StudentFk { get; set; }
	[Id(2)]
	public int ActivityFk { get; set; }
	[Id(3)]
	public string? ActivityValue { get; set; }

	[Id(4)]
	public string? Status { get; set; }
	[Id(5)]
	public string? Description { get; set; }
	[Id(6)]
	public int TimeTableFk { get; set; }
	[Id(7)]
	public DateTime? ActivityDateTime { get; set; }
	[Id(8)]
	public DateTime? ActivityDeletedDateTime { get; set; }

	[Id(9)]
	public Guid StudentSessionActivityGuid { get; set; }
	[Id(10)]
	public DateTime StudentSessionActivityLastModified { get; set; }
}