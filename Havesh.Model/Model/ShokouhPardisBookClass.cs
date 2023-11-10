using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisBookClass : BranchBaseModel
{
    [Key]
    public int Id { get; set; }
	public Guid BookClassGuid { get; set; }
	public DateTime BookClassLastModified { get; set; }
	public string? BookName { get; set; }
	public string? BookPic { get; set; }
	public string? BookDes { get; set; }
}