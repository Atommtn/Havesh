using System.ComponentModel.DataAnnotations.Schema;

namespace HaveshApp.Model;

public partial class ShokouhPardisTeacherClass
{

    public static ShokouhPardisTeacherClass CreateTeacher()
    {
        return new ShokouhPardisTeacherClass()
        {
            TeacherClassGuid = Guid.NewGuid(),
            TeacherClassLastModified = DateTime.Now
        };
    }

    public override string ToString()
    {
        return $"{TeacherName} {TeacherFamily}";
    }

    [NotMapped] public string FullName => TeacherName + " " + TeacherFamily;
}
