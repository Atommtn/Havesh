using System.ComponentModel.DataAnnotations.Schema;

namespace Havesh.Model.Model;

public partial class ShokouhPardisStudentClass
{
    public static ShokouhPardisStudentClass CreatenewStudent()
    {
        var shokouhPardisStudentClass = new ShokouhPardisStudentClass()
        {
            StudentClassGuid = Guid.NewGuid()
        };
        return shokouhPardisStudentClass;
    }

    [NotMapped]
    public bool IsSelect { get; set; }

    [NotMapped]
    public bool ShowDetail { get; set; }

    [NotMapped]
    public string Tag { get; set; }
    [NotMapped] public string FullName => StudentName + " " + StudentFamily;
    [NotMapped] public int OrderNumber { get; set; }

    public override string ToString()
    {
        return FullName;
    }
}

