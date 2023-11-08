namespace HaveshApp.Classes;

public class PaymentTypeStatuses
{
      
	public const string Cash = "نقد";
	public const string Pos = "پوز";
	public const string Debit = "واریز";
            
        
}

public class FeeForStatuses
{
	public const string TuitionAmount = "شهریه";
	public const string Book="کتاب";
	public const string PrivateClass="خصوصی";
	public const string Placement="تعیین سطح";
	public const string Final = "فاینال";
	public const string Refund = "عودت وجه";
        

}
public class PaymentSummary
{
	public DateTime? Day { get; set; }
	public string PaymentType { get; set; }
	public string FeeFor { get; set; }
	public double TotalFee { get; set; }
}