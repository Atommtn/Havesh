using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public partial class PreRegistration
{
	[ForeignKey(nameof(Model.PreRegistration.StudentFk))]
	public ShokouhPardisStudentClass Student { get; set; }
        
	[ForeignKey(nameof(Model.PreRegistration.TermFk))]
	public ShokouhPardisTermClass Term { get; set; }

	[ForeignKey(nameof(Model.PreRegistration.DailyJVFk))]
	public ShokouhPardisDailyJv DailyJV { get; set; }  
	[ForeignKey(nameof(Model.PreRegistration.LevelFk))]
	public ShokouhPardisLevelClass Level { get; set; }

	public static PreRegistration CreatePreRegistration()
	{
		var prePegistration = new PreRegistration
		{
			PreRegistrationGuid = Guid.NewGuid(),
			PreRegistrationLastModified = DateTime.Today
                
		};
		return prePegistration;
	}

}