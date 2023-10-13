using ShokouhApp.Model;

namespace ShokouhApp.Admin.Student;

public class StudentActionArgs
{
    public ShokouhPardisStudentClass Student { get; set; }
    public ShokouhPardisTimeTable? TimeTable { get; set; }
}