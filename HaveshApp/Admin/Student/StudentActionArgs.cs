using HaveshApp.Model;

namespace HaveshApp.Admin.Student;

public class StudentActionArgs
{
    public ShokouhPardisStudentClass Student { get; set; }
    public ShokouhPardisTimeTable? TimeTable { get; set; }
}