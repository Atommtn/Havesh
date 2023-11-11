using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisTermClass : BranchBaseModel
{

	public Guid TermClassGuid { get; set; }
	public DateTime TermClassLastModified { get; set; }
	public string? TermName { get; set; }
	public int YearId { get; set; }
	public DateTime? StartDate { get; set; }
	public DateTime? EndDate { get; set; }
}