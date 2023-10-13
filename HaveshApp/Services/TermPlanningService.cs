using ShokouhApp.Model;

namespace ShokouhApp.Services;

public class TermPlanningService
{
    public MyDbContext DbContext { get; }

    public TermPlanningService(MyDbContext dbContext)
    {
        DbContext = dbContext;
    }

}