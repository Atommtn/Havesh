using Havesh.Application.Services;
using Havesh.Model.Data;
using Havesh.Model.Model;

namespace Havesh.Domain.Services;

public class TermPlanningService
{
    public MyDbContext DbContext { get; }

    public TermPlanningService(MyDbContextFactory dbContextFactory)
    {
        var branchName = Environment.GetEnvironmentVariable("BranchName")!;
        DbContext = dbContextFactory.CreateDbContextForBranch(branchName);
    }

}