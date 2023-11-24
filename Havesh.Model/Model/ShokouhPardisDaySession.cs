using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisDaySession : BranchBaseModel
{
	[Id(0)]
	public Guid DaySessionGuid { get; set; }
	[Id(1)]
	public DateTime DaySessionLastModified { get; set; }
	[Id(2)]
	public int WeekdayId { get; set; }
	[Id(3)]
	public int IntervalId { get; set; }
	[Id(4)]
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