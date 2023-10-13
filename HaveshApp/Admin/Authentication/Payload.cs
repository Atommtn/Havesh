namespace ShokouhApp.Admin.Authentication;

public class Payload
{
    public string? UserName { get; set; }
    public string? Gender { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public List<string>? Roles { get; set; }
    public string? Email { get; set; }
    public string? Mobile { get; set; }
    public override string ToString()
    {
        return $"[{UserName}] ({Gender} {FirstName} {LastName})";
    }
}