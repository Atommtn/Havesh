using Havesh.Model.Data.Dashboard;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;

namespace Havesh.Domain.Services;

public class DashboardService
{
    public MyDbContext DbContext { get; }


    public DashboardService(MyDbContext dbContext)
    {
        DbContext = dbContext;
    }


    public Widget? GetWidgetById(int widgetId)
    {
        var widget = DbContext.Widgets.Find(widgetId);
        return widget;
    }

    public List<Widget> GetWidgets()
    {
        var widgets = DbContext.Widgets.ToList();
        return widgets;
    }

    public List<DashboardTemplate> GetDashboardTemplates()
    {
        var dashboardTemplates = DbContext
            .DashboardTemplates
            .Include(x => x.BelongsToRole)

            .Include(x => x.DashboardTemplateWidgets)
            .ThenInclude(x => x.Widget)
            .Include(x => x.DashboardTemplateWidgets)
            .ThenInclude(x => x.DashboardTemplate)
            .ToList();
        return dashboardTemplates;
    }

    public void UpdateDashboardTemplate(DashboardTemplate dashboardTemplate)
    {
        DbContext.DashboardTemplates.Update(dashboardTemplate);
        DbContext.SaveChanges();
    }

    public void DeleteDashboardTemplate(DashboardTemplate context)
    {
        DbContext.DashboardTemplates.Remove(context);
        DbContext.SaveChanges();
    }

    public void UpdateWidget(Widget widget)
    {
        DbContext.Widgets.Update(widget);
        DbContext.SaveChanges();
    }

    public void RemoveWidgetFromDashboardTemplate(DashboardTemplateWidget dashboardTemplate)
    {
        DbContext.DashboardTemplateWidgets.Remove(dashboardTemplate);
        DbContext.SaveChanges();
    }

    public Dashboard? GetUserDashboard(User? user)
    {
        if (user is null)
            return null;
        var dashboard = DbContext.Dashboards.FirstOrDefault(x => x.User == user);
        if (dashboard == null)
        {
            var _dt = GetDashboardTemplateByRole(user.Roles);
        }
        return dashboard;
    }

    private List<DashboardTemplate>? GetDashboardTemplateByRole(List<Role> userRoles)
    {

        foreach (var role in userRoles)
        {
            var dashboardTemplate = DbContext
                .DashboardTemplates
                .Where(x => x.BelongsToRole == role)
                .ToList();
        }
        // TODO 
        return null;
    }

    public Dictionary<string, List<DashboardTemplate>>? GetUserDashboardMenuItems(User? user)
    {

        if (user is null) return null;
        Dictionary<string, List<DashboardTemplate>> dic = new();
        foreach (var role in user.Roles)
        {
            var dashboardTemplate = DbContext
                .DashboardTemplates
                .Where(x => x.BelongsToRole == role)
                .ToList();

            if (dashboardTemplate.Any())
                dic.Add(role.Name, dashboardTemplate);

        }

        return dic;
    }

    public Dashboard? GetDashboardByUserTemplateId(int dashboardTemplateId, User? user)
    {
        if(user is null) 
            throw new  Exception("User Is NULLLLLLLLLLLLLLL");

        var dashboard = DbContext
            .Dashboards
            .Include(x => x.DashboardTemplate)
            .Include(x=>x.DashboardWidgets)
            .ThenInclude(x=>x.Widget)

            .FirstOrDefault(x => x.DashboardTemplate.Id == dashboardTemplateId && x.User == user);


        return dashboard;
    }

    public Dashboard GenerateUserDashboardByDashboardId(int dashboardTemplateId, User? user)
    {
        if (user is null) return null;
        var dashboardTemplate = DbContext
            .DashboardTemplates
            .Include(x => x.DashboardTemplateWidgets)
            .ThenInclude(x => x.Widget)
            .First(x => x.Id == dashboardTemplateId);

        var dashboard = new Dashboard
        {
            DashboardTemplate = dashboardTemplate,
            User = user,
        };

        var widgets = dashboardTemplate
            .DashboardTemplateWidgets?
            .Select(x => new DashboardWidgetSetting()
            {
                Dashboard = dashboard,
                Widget = x.Widget,
            })
        .ToList();

        DbContext.DashboardWidgetSettings.AddRange(widgets);
        DbContext.Dashboards.Add(dashboard);

        DbContext.SaveChanges();

        return dashboard;


    }
}