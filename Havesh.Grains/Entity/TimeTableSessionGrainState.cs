using Havesh.Model.Model;

namespace Havesh.Grains.Entity;

[Serializable]
[GenerateSerializer]
public class TimeTableSessionGrainState
{
	[Id(0)]
	public List<StudentSessionActivity> Activities { get; set; } = new();

	[Id(1)]
	public TimeTableSession TimeTableSession { get; set; }
}
