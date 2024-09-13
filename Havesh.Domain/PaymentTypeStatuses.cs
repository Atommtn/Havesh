namespace Havesh.Domain;
public static class SessionStatuses
{
	public const string Pending = "برگزار نشده";
	public const string Completed = "برگزار شده";
	public const string Canceled = "کنسل شده";
	public const string Replaced = "جایگزین شده";
	public const string Running = "درحال برگزاری";
}

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
public class StudentRegisterSummary
{
	public int StudentId { get; set; }
    public DateTime? Day { get; set; }
    public string LevelName { get; set; }
    public bool? Gender { get; set; }
    public int TotalStudents { get; set; }
    public int RegisteredStudents { get; set; }
    public int UnregisteredStudents { get; set; }
    public object LevelNames { get; set; }
}
