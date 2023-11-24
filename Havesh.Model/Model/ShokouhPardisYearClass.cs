using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisYearClass : BranchBaseModel
{
	[Id(0)]
	public Guid YearClassGuid { get; set; }
	[Id(1)]
	public DateTime YearClassLastModified { get; set; }
	[Id(2)]
	public string? YearName { get; set; }
}