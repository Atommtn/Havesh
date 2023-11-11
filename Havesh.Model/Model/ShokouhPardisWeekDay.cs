using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisWeekDay : BranchBaseModel
{

	public Guid WeekDayGuid { get; set; }
	public DateTime WeekDayLastModified { get; set; }
	public string? Title { get; set; }
}