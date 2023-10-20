using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Data;

public class Branch
{
	public int Id { get; set; }
	public string Name { get; set; }
	public bool IsArchived { get; set; }
	public int? ParentBranch { get; set; }
}

public class BranchBaseModel
{

	public int BranchFk { get; set; }

	[ForeignKey(nameof(BranchFk))]
	public Branch Branch { get; set; }
}