using HaveshApp.Model;

namespace HaveshApp.Services;

public class TermPlanningService
{
    public MyDbContext DbContext { get; }

    public TermPlanningService(MyDbContext dbContext)
    {
        DbContext = dbContext;
    }

}