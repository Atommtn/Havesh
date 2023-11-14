
using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public  partial class ShokouhPardisDailyJv
{
	[ForeignKey(nameof(Model.ShokouhPardisDailyJv.StudentId))]
	public ShokouhPardisStudentClass? Student { get; set; }

	[ForeignKey(nameof(Model.ShokouhPardisDailyJv.TermId))] 
	public ShokouhPardisTermClass? Term { get; set; }

	[ForeignKey(nameof(Model.ShokouhPardisDailyJv.TimeTableFk))] 
	public ShokouhPardisTimeTable? TimeTable { get; set; }

	public static ShokouhPardisDailyJv CreateNewDailyJV()
	{
		var dailyJv= new ShokouhPardisDailyJv
		{
			DailyJvguid = Guid.NewGuid(),
			DailyJvlastModified = DateTime.Today,
			CurrentDate = DateTime.Today
		};
		return dailyJv;
	}

}