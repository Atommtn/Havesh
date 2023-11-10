using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisAccountingTransaction : BranchBaseModel
{
    [Key]
    public int Id { get; set; }
	public Guid AccountingTransactionGuid { get; set; }
	public DateTime AccountingTransactionLastModified { get; set; }
	public int? AccountingCodeFk { get; set; }
	public string? Code { get; set; }
	public int? SubjectRecFk { get; set; }
	public int? Debit { get; set; }
	public int? Credit { get; set; }
	public int? Balance { get; set; }
	public int? TermId { get; set; }
	public DateTime? TransactionDate { get; set; }
	public string? Description { get; set; }
	public string? ShortTxKey { get; set; }
}