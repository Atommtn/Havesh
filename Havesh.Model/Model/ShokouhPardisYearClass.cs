using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisYearClass : BranchBaseModel
{

	public Guid YearClassGuid { get; set; }
	public DateTime YearClassLastModified { get; set; }
	public string? YearName { get; set; }
}