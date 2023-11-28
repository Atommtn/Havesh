using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Model;

namespace Havesh.Model.Model;

public partial class TimeTableSession
{
	[Id(9)]
	public ShokouhPardisTimeTable TimeTable { get; set; }

	[Id(10)]
	[ForeignKey(nameof(Model.TimeTableSession.TeacherFk))]
	public ShokouhPardisTeacherClass Teacher { get; set; }

	[Id(11)]
	[ForeignKey(nameof(Model.TimeTableSession.ReplacementTimeTableSessionFk))]
	public TimeTableSession ReplacementSession { get; set; }

	[Id(12)]
	[ForeignKey(nameof(Model.TimeTableSession.ClassRoomFk))]
	public ShokouhPardisClassRoom ClassRoom { get; set; }

	[NotMapped]
	public object? Tag { get; set; }
}