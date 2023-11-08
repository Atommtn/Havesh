using Havesh.Model.Data;
using Havesh.Model.Model;

namespace Havesh.Domain.Services;

public class TermPlanningService
{
    public MyDbContext DbContext { get; }

    public TermPlanningService(MyDbContext dbContext)
    {
        DbContext = dbContext;
    }

}