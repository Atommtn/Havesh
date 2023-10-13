using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ShokouhApp.Model;

namespace ShokouhApp.Model;

[Table("ShokouhPardis_SessionActivityValueOption")]
public partial class SessionActivityValueOption
{
    [Key]
    public int Id { get; set; }

    public int SessionActivityFk { get; set; }

    public string? Title { get; set; }
    public string? Color { get; set; }
    public string? Value { get; set; }

    public string? ShowByValue { get; set; }

}