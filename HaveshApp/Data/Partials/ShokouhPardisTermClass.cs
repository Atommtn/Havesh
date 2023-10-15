using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HaveshApp.Model;

public partial class ShokouhPardisTermClass
{
    public static void Setup(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShokouhPardisTermClass>()
            .HasOne(x=>x.Year)
            .WithMany(x=>x.Terms)
            ;
    }

    [ForeignKey(nameof(YearId))]
    public ShokouhPardisYearClass Year { get; set; }

    public static ShokouhPardisTermClass CreateTerm()
    {
        return new ShokouhPardisTermClass();
    }
}