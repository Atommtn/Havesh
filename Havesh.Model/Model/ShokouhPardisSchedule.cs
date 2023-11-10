using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisSchedule : BranchBaseModel
{
    [Key]
    public int TermFk { get; set; }
	public int Id { get; set; }
	public Guid ScheduleGuid { get; set; }
	public DateTime ScheduleLastModified { get; set; }
	public string Title { get; set; } = null!;
       
}