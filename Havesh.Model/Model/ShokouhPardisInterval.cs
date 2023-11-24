using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisInterval : BranchBaseModel
{
	[Id(0)]
	public Guid IntervalGuid { get; set; }
	[Id(1)]
	public DateTime IntervalLastModified { get; set; }
	[Id(2)]
	public string? Title { get; set; }
	[Id(3)]
	public string? TimeInterval { get; set; }
	[Id(4)]
	public int TermId { get; set; }

	[Id(5)]
	public TimeSpan? StartTime { get; set; }
	[Id(6)]
	public TimeSpan? EndTime { get; set; }

}