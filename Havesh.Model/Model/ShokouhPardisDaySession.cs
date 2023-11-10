using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisDaySession : BranchBaseModel
{
    [Key]
    public int Id { get; set; }
	public Guid DaySessionGuid { get; set; }
	public DateTime DaySessionLastModified { get; set; }
	public int WeekdayId { get; set; }
	public int IntervalId { get; set; }
	public int TermFk { get; set; }

	public static ShokouhPardisDaySession CreateDaySession(int termFk)
	{
		return new ShokouhPardisDaySession()
		{
			TermFk = termFk,

			DaySessionGuid = Guid.NewGuid(),
			DaySessionLastModified = DateTime.Now
		};
	}
}