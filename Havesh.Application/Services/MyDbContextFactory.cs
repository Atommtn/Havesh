using Havesh.Model;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Havesh.Application.Services;

public class MyDbContextFactory
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IConfiguration _configuration;

    public MyDbContextFactory(IServiceProvider serviceProvider, IConfiguration configuration)
    {
        _serviceProvider = serviceProvider;
        _configuration = configuration;
    }

    /// <summary>
    /// Need to have :
    /// [BranchName]__DataSource
    /// [BranchName]__InitialCatalog
    /// [BranchName]__UserId
    /// [BranchName]__Password
    /// </summary>
    /// <param name="branchName"></param>
    /// <returns></returns>
    public MyDbContext CreateDbContextForBranch(string branchName)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MyDbContext>();
        var conStr = GetConStrByBranchName(branchName);

        // Set the options like in your DI registration
        optionsBuilder
            .UseSqlServer(conStr)
            .EnableSensitiveDataLogging()
            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
            .EnableSensitiveDataLogging();

        optionsBuilder.UseLoggerFactory(
            LoggerFactory.Create(builder => builder.AddConsole()));
        optionsBuilder.ConfigureWarnings(warnings =>
        {
            warnings.Ignore(CoreEventId.NavigationBaseIncludeIgnored);
        });

        return new MyDbContext(optionsBuilder.Options);
    }

    private string GetConStrByBranchName(string envDbSectionName)
    {
        var dbSettings = new DbSettings();
        _configuration.GetSection(envDbSectionName).Bind(dbSettings);
        var conStr = dbSettings.GetConnectionString();
        return conStr;
    }
}
