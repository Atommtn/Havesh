using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HaveshApp;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
{
    public MyDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
        optionsBuilder.UseSqlServer(
            "Server=172.16.2.254\\sql2019;Database=HaveshAppDb;" +
            "User Id=ShoukouhPardis12DBAdmin2;Password=ShoukouhPardis12DB@pass;" +
            "TrustServerCertificate=True;");
        return new MyDbContext(optionsBuilder.Options);
    }
}