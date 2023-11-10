using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisWeekDay
{
    [Key]
    public int Id { get; set; }
	public Guid WeekDayGuid { get; set; }
	public DateTime WeekDayLastModified { get; set; }
	public string? Title { get; set; }
}