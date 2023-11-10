using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisEmployee : BranchBaseModel
{
    [Key]
    public int Id { get; set; }
	public Guid EmployeeGuid { get; set; }
	public DateTime EmployeeLastModified { get; set; }
	public string? Title { get; set; }
}