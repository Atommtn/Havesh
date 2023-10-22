using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Havesh.Model.Data;

namespace Havesh.Model.Model;

[Table("ShokouhPardis_PreRegistration")]
public partial class PreRegistration : BranchBaseModel
{

	[Key]
	public int Id { get; set; }
        
	public int DailyJVFk { get; set; }
        
	public int StudentFk { get; set; }
        
	public int TermFk { get; set; }
	public int LevelFk { get; set; }
	public bool? IsArchive { get; set; }
	public Guid PreRegistrationGuid { get; set; }
	public DateTime PreRegistrationLastModified { get; set; }
}