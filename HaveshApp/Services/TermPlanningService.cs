using Havesh.Model.Data;
using Havesh.Model.Model;

namespace HaveshApp.Services;

public class TermPlanningService
{
    public MyDbContext DbContext { get; }

    public TermPlanningService(MyDbContext dbContext)
    {
        DbContext = dbContext;
    }

}