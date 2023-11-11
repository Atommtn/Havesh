using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisLevelBookPrice : BranchBaseModel
{

	public Guid LevelBookPriceGuid { get; set; }
	public DateTime LevelBookPriceLastModified { get; set; }
	public int TermId { get; set; }
	public int LevelId { get; set; }
	public int TuitionAmount { get; set; }
	public int BookPrice { get; set; }
}