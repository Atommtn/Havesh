using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Havesh.Model.Model;

public partial class ShokouhPardisSchedule
{
    public static void Setup(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShokouhPardisSchedule>()
            .HasMany(x => x.Programs)
            .WithOne(x => x.Schedule);

    }

    //[ForeignKey(nameof(ScheduleId))]
    public List<ShokouhPardisProgram> Programs { get; set; }

    [NotMapped]
    public int SourceId { get; set; }

  

    public static ShokouhPardisSchedule CreateSchedule()
    {
        return new ShokouhPardisSchedule()
        {
            ScheduleGuid = Guid.NewGuid(),
            ScheduleLastModified = DateTime.Now
        };
    }
}