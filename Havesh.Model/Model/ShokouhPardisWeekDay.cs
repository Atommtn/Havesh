using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisWeekDay : BranchBaseModel
{
	public Guid WeekDayGuid { get; set; }
	public DateTime WeekDayLastModified { get; set; }
	[Id(0)]
	public string? Title { get; set; }
}