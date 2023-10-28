using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Data;

[Table("AppBranch")]
public class Branch
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)] 
	public int Id { get; set; }

	public string Code { get; set; }
	public string Name { get; set; }
	public bool IsArchived { get; set; }
	
	public int? ParentBranchFk { get; set; }
	
	[ForeignKey(nameof(ParentBranchFk))]
	public Branch? ParentBranch { get; set; }
}

public class BranchBaseModel
{
	public string? BCode { get; set; }

	public int BranchFk { get; set; }

	[ForeignKey(nameof(BranchFk))]
	public Branch Branch { get; set; }
}