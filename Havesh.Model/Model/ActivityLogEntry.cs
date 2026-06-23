namespace Havesh.Model.Model;

public class ActivityLogEntry
{
    public int Id { get; set; }
    public string Message { get; set; }
    public string Level { get; set; }
    public DateTime TimeStamp { get; set; }
    public string UserName { get; set; }
    public string Role { get; set; }
    public string EntityType { get; set; }
}