using Havesh.Model.Data;

namespace Havesh.Model.Model;

public partial class ShokouhPardisDaySession : BranchBaseModel
{
	public int DaySessionId { get; set; }
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