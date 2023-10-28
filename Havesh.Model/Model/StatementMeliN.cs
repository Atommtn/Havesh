namespace Havesh.Model.Model;

public partial class StatementMeliN
{
	public DateTime? TransactionDate { get; set; }
	public DateTime? TransactionTime { get; set; }
	public string? TraceNo { get; set; }
	public string? TranChannel { get; set; }
	public string? Description2 { get; set; }
	public string? DepositAmount { get; set; }
	public string? Description { get; set; }
	public int Id { get; set; }
	public int? ItemModifiedBy { get; set; }
	public DateTime? ItemModifiedWhen { get; set; }
	public Guid ItemGuid { get; set; }
	public int? VerificationStatus { get; set; }
}