using Havesh.Model.Data;

namespace Havesh.Model.Model;

public partial class ShokouhPardisClassRoom : BranchBaseModel
{
	public int ClassRoomId { get; set; }
	public Guid ClassRoomGuid { get; set; }
	public DateTime ClassRoomLastModified { get; set; }
	public string ClassRoomName { get; set; } = null!;
	public int? Capacity { get; set; }
	public int? MinCapacity { get; set; }
	public int? MaxCapacity { get; set; }
	public string? Describtion { get; set; }
}