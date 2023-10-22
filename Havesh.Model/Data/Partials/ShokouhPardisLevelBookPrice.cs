using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Havesh.Model.Model;

public partial class ShokouhPardisLevelBookPrice
{
    public static void Setup(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShokouhPardisLevelBookPrice>()
            .HasOne(x => x.Term)
            ;
        modelBuilder.Entity<ShokouhPardisLevelBookPrice>()
            .HasOne(x => x.Level)
            ;
    }

    [ForeignKey(nameof(Model.ShokouhPardisLevelBookPrice.TermId))]
    public ShokouhPardisTermClass Term { get; set; }

    [ForeignKey(nameof(Model.ShokouhPardisLevelBookPrice.LevelId))]
    public ShokouhPardisLevelClass Level { get; set; }

    public static ShokouhPardisLevelBookPrice CreateLevelPrices()
    {
        return new ShokouhPardisLevelBookPrice()
        {
            LevelBookPriceGuid = Guid.NewGuid(),
            LevelBookPriceLastModified = DateTime.Now
        };
    }
}