using Havesh.Model.Data;

namespace Havesh.Model.Model;

public partial class ShokouhPardisEmployee : BranchBaseModel
{
	public int EmployeeId { get; set; }
	public Guid EmployeeGuid { get; set; }
	public DateTime EmployeeLastModified { get; set; }
	public string? Title { get; set; }
}