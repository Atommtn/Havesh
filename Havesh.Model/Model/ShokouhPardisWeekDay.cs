namespace Havesh.Model.Model;

public partial class ShokouhPardisWeekDay
{
	public int WeekDayId { get; set; }
	public Guid WeekDayGuid { get; set; }
	public DateTime WeekDayLastModified { get; set; }
	public string? Title { get; set; }
}