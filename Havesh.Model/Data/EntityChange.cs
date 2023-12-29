using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public class EntityChange
{
	public int Id { get; set; }
	public string EntityName { get; set; }
	public string? EntityKey { get; set; }
	public string Action { get; set; } // Added, Modified, Deleted
	public string? Field { get; set; }
	public string? OldValue { get; set; }
	public string? NewValue { get; set; }
	public int? ActionByFk { get; set; }

	[ForeignKey(nameof(ActionByFk))]
	public User? ActionBy { get; set; }
	public DateTime ActionWhen { get; set; } = DateTime.Now;
}