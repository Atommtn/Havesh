using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisInterval : BranchBaseModel
{

	public Guid IntervalGuid { get; set; }
	public DateTime IntervalLastModified { get; set; }
	public string? Title { get; set; }
	public string? TimeInterval { get; set; }
	public int TermId { get; set; }

	public TimeSpan? StartTime { get; set; }
	public TimeSpan? EndTime { get; set; }

}