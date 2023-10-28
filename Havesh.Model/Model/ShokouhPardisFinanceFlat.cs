using Havesh.Model.Data;

namespace Havesh.Model.Model;

public partial class ShokouhPardisFinanceFlat : BranchBaseModel
{
	public int FinanceFlatId { get; set; }
	public Guid FinanceFlatGuid { get; set; }
	public DateTime FinanceFlatLastModified { get; set; }
	public string? StudentId { get; set; }
	public string? StudentName { get; set; }
	public string? StudentFamily { get; set; }
	public string? CreditCardPostFixNo { get; set; }
	public DateTime? PaymentDateTime { get; set; }
	public int? PaymentForTermId { get; set; }
	public int? PaymentForYearId { get; set; }
	public int PaymentTypeId { get; set; }
	public int PaymentCauseId { get; set; }
	public long PaymentAmount { get; set; }
	public int? VerificationStatus { get; set; }
}