using Havesh.Model.Data;

namespace Havesh.Model.Model;

public partial class ShokouhPardisInterval : BranchBaseModel
{
	public int IntervalId { get; set; }
	public Guid IntervalGuid { get; set; }
	public DateTime IntervalLastModified { get; set; }
	public string? Title { get; set; }
	public string? TimeInterval { get; set; }
	public int TermId { get; set; }

	public TimeSpan? StartTime { get; set; }
	public TimeSpan? EndTime { get; set; }

}