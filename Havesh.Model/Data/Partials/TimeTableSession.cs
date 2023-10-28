using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Model;

namespace Havesh.Model.Model;

public partial class TimeTableSession
{
	public ShokouhPardisTimeTable TimeTable { get; set; }

	[ForeignKey(nameof(Model.TimeTableSession.TeacherFk))]
	public ShokouhPardisTeacherClass Teacher { get; set; }

	[ForeignKey(nameof(Model.TimeTableSession.ReplacementTimeTableSessionFk))]
	public TimeTableSession ReplacementSession { get; set; }

	[ForeignKey(nameof(Model.TimeTableSession.ClassRoomFk))]
	public ShokouhPardisClassRoom ClassRoom { get; set; }

}