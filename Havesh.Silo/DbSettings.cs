namespace Havesh.Silo;

public class DbSettings
{
    public string DataSource { get; set; }
    public string InitialCatalog { get; set; }
    public string UserId { get; set; }
    public string Password { get; set; }

    public string GetConnectionString()
    {
        var conStr = $"Data Source={DataSource.Replace(@"\\",@"\")};Initial Catalog={InitialCatalog};User ID={UserId};Password={Password};Integrated Security=False;Persist Security Info=False;Connect Timeout=60;Encrypt=False;Current Language=English;";
        return conStr;
    }
}