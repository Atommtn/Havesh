using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisTermClass : BranchBaseModel
{
	[Id(0)]
	public Guid TermClassGuid { get; set; }
	[Id(1)]
	public DateTime TermClassLastModified { get; set; }
	[Id(2)]
	public string? TermName { get; set; }
	[Id(3)]
	public int YearId { get; set; }
	[Id(4)]
	public DateTime? StartDate { get; set; }
	[Id(5)]
	public DateTime? EndDate { get; set; }
}