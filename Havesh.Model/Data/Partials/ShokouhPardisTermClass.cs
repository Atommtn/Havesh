using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Havesh.Model.Model;

public partial class ShokouhPardisTermClass
{
    public static void Setup(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShokouhPardisTermClass>()
            .HasOne(x=>x.Year)
            .WithMany(x=>x.Terms)
            ;
    }

    [Id(6)]
	[ForeignKey(nameof(Model.ShokouhPardisTermClass.YearId))]
	public ShokouhPardisYearClass Year { get; set; }

    public static ShokouhPardisTermClass CreateTerm()
    {
        return new ShokouhPardisTermClass();
    }

    public static ShokouhPardisTermClass CreateClassRoom()
    {

        return new ShokouhPardisTermClass()
        {
            TermClassGuid = Guid.NewGuid(),
            TermClassLastModified = DateTime.Now
        };
    }
}