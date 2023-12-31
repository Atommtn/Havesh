using Havesh.Model.Model;

namespace Havesh.Grains.GrainState;

[Serializable]
[GenerateSerializer]
public class TimeTableSessionGrainState
{
    [Id(0)]
    public List<StudentSessionActivity> StudentsActivities { get; set; } = new();

    [Id(1)]
    public TimeTableSession TimeTableSession { get; set; }
}
