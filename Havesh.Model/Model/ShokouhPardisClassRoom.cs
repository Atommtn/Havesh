using Havesh.Model.Data;
using System.ComponentModel.DataAnnotations;

namespace Havesh.Model.Model;

[Serializable]
[GenerateSerializer]
public partial class ShokouhPardisClassRoom : BranchBaseModel
{
	[Id(0)]
	public Guid ClassRoomGuid { get; set; }
	[Id(1)]
	public DateTime ClassRoomLastModified { get; set; }
	[Id(2)]
	public string ClassRoomName { get; set; } = null!;
	[Id(3)]
	public int? Capacity { get; set; }
	[Id(4)]
	public int? MinCapacity { get; set; }
	[Id(5)]
	public int? MaxCapacity { get; set; }
	[Id(6)]
	public string? Describtion { get; set; }

    public static ShokouhPardisClassRoom CreateClassRoom()
    {
        return new ShokouhPardisClassRoom()
        {
            ClassRoomGuid = Guid.NewGuid(),
            ClassRoomLastModified = DateTime.Now
        };
    }
}