using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

public partial class ShokouhPardisJvfromSite : BranchBaseModel
{
    [Key]
    public int Id { get; set; }
	public string StudentName { get; set; } = null!;
	public string StudentFamil { get; set; } = null!;
	public DateTime? CreateDate { get; set; }
	public string? StudentIdNumber { get; set; }
	public string? FeeFor { get; set; }
	public int? Fee { get; set; }
	public string? PhoneNumber { get; set; }
	public DateTime? DateOfSettle { get; set; }
	public string? Txcode { get; set; }
	public string? Description { get; set; }
	public string? CardPostfix { get; set; }
	public Guid DailyJvguid { get; set; }
	public DateTime DailyJvlastModified { get; set; }
	public int? AttachmentFk { get; set; }
	public string? ApprovedBy { get; set; }
	public bool? IsApproved { get; set; }
	public bool? IsRequiredInvestigation { get; set; }
	public string? AdminDescription { get; set; }
}