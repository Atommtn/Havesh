using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
[Table("ShokouhPardis_TimeTableSession")]
public partial class TimeTableSession : BranchBaseModel
{
	[Id(0)]
	public int SessionNumber { get; set; }

	[Id(1)]
	public int TimeTableFk { get; set; }

	[Id(2)]
	public int TeacherFk { get; set; }

	[Id(3)]
	public int? ReplacementTimeTableSessionFk { get; set; }

	[Id(4)]
	public int ClassRoomFk { get; set; }

	[Id(5)]
	public string SessionStatus { get; set; }

	[Id(6)]
	public string? SessionDescription { get; set; }
	
	[Id(7)]
	public DateTime? SessionDate { get; set; }
	
	[Id(8)]
	public TimeSpan? SessionTime { get; set; }

}