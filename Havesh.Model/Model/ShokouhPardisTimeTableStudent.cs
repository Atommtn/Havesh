using Havesh.Model.Data;

namespace Havesh.Model.Model;

public partial class ShokouhPardisTimeTableStudent : BranchBaseModel
{
	public int TimeTableStudentsId { get; set; }
	public int TimeTableId { get; set; }
	public int? StudentId { get; set; }
	public int? StudentPercentDiscount { get; set; }
	public int? StudentAmountDiscount { get; set; }
	public bool? IsBookPaymentComplete { get; set; }
	public bool? IsPaymentComplete { get; set; }
	public string? Description { get; set; }
	public Guid TimeTableStudentsGuid { get; set; }
	public DateTime TimeTableStudentsLastModified { get; set; }
}