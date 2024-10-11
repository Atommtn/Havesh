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
public class CardNumber
{
    public const string CN5642 = "6037991792585642 ملی محمد طایفه نفر";
    public const string CN4500 = "6221061216334500 پارسیان محمد طایفه نفر";
    public const string CN1368 = "6063731166881368 مهر ایران ندا طاهری";
    public const string CN5683 = "6037991792585683 جاری ملی محمد طایفه نفر";
    public const string CN8304 = "6037998113668304 ملی زهره حبیبی";
    public const string CN9335 = "6280231359459335 مسکن محمد طایفا نفر";
    public const string CN3586 = "5894631207073586 رفاه فرشید طایفه نفر";
    public const string CN1602 = "6221061224361602 پارسیان ندا طاهری";
    public const string CN4601 = "6037998228834601 ملی حسین طایفه نفر";
    public const string CN4421 = "6362141089084421 آینده علی اکبر طایفه نفر";
    public const string CN5307 = "5041721201075307 رسالت نرگس طایفه نفر";
    public const string CN2189 = "5892101506202189 سپه عباس طاهری";
    public const string CN1670 = "6280231358791670 مسکن ندا طاهری";
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
