using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;


[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisSchedule : BranchBaseModel
{
	[Id(0)]
	public int TermFk { get; set; }
	[Id(1)]
	public Guid ScheduleGuid { get; set; }
	[Id(2)]
	public DateTime ScheduleLastModified { get; set; }
	[Id(3)]
	public string Title { get; set; } = null!;

	[Id(4)]
	//[ForeignKey(nameof(ScheduleId))]
	public List<ShokouhPardisProgram> Programs { get; set; }
}