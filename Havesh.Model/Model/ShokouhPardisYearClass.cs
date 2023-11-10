using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisYearClass
{
    [Key]
    public int Id { get; set; }
	public Guid YearClassGuid { get; set; }
	public DateTime YearClassLastModified { get; set; }
	public string? YearName { get; set; }
}