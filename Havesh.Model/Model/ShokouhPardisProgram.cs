using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisProgram : BranchBaseModel
{
	public Guid ProgramGuid { get; set; }
	public DateTime ProgramLastModified { get; set; }
	public int ScheduleId { get; set; }
	public int DaysessionId { get; set; }
}