using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ShokouhApp.Model;

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

    [ForeignKey(nameof(StudentId))]
    public ShokouhPardisStudentClass Student { get; set; }

    [ForeignKey(nameof(TimeTableId))]
    public ShokouhPardisTimeTable TimeTable { get; set; }

    
    

}