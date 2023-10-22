namespace Havesh.Model.Model;

public partial class ShokouhPardisTeacherTimeSheet
{
	public ShokouhPardisTeacherClass Teacher { get; set; }
	public ShokouhPardisTermClass Term { get; set; }
	public ShokouhPardisWeekDay WeekDay { get; set; }
	public ShokouhPardisInterval Interval { get; set; }

}