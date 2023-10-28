using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Havesh.Model.Model;

public partial class ShokouhPardisTimeTableStudent
{
    public static void Setup(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShokouhPardisTimeTableStudent>()
            .HasOne(x => x.Student)
            ;

        modelBuilder.Entity<ShokouhPardisTimeTableStudent>()
            .HasOne(x => x.TimeTable)
            ;
    }

    [ForeignKey(nameof(Model.ShokouhPardisTimeTableStudent.StudentId))]
    public ShokouhPardisStudentClass Student { get; set; }

    [ForeignKey(nameof(Model.ShokouhPardisTimeTableStudent.TimeTableId))]
    public ShokouhPardisTimeTable TimeTable { get; set; }

    
    

}