using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
[Table("ShokouhPardis_SessionActivityValueOption")]
public partial class SessionActivityValueOption : BranchBaseModel
{
	[Id(0)]
	public int SessionActivityFk { get; set; }

	[Id(1)]
	public string? Title { get; set; }
	[Id(2)]
	public string? Color { get; set; }
	[Id(3)]
	public string? Value { get; set; }

	[Id(4)]
	public string? ShowByValue { get; set; }

	[Id(5)]
	public string? BroadcastToRoles { get; set; }

}