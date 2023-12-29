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
    public List<Widget> GetRoleWidgets(Role role)
    {
        var widgets = DbContext.Widgets
            .Where(x=> string.IsNullOrEmpty(x.BelongToRoles)   || x.BelongToRoles.Contains(role.Name) )
            .ToList();
        return widgets;
    }

    public List<DashboardTemplate>? GetDashboardTemplates()
    {
        var dashboardTemplates = DbContext
            .DashboardTemplates

            .Include(x=>x.WidgetGroups)

            .Include(x => x.BelongsToRole)

            .Include(x => x.DashboardTemplateWidgets!)
            .ThenInclude(x => x.Widget)

            .Include(x => x.DashboardTemplateWidgets!)
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

    public List<Dashboard?> GetUserDashboards(User? user)
    {
        if (user is null)
            return null;
        var dashboards = DbContext.Dashboards
            .Include(x=>x.DashboardTemplate)
            .Include(x=>x.DashboardWidgets)
            .Where(x => x.User == user).ToList();
        if (dashboards.Any()) return dashboards;

        var _dts = GetDashboardTemplatesByRole(user.Roles);
        foreach (var dashboardTemplate in _dts)
        {
            var dashboard = GenerateUserDashboardByDashboardTemplateId(dashboardTemplate.Id , user.Id);
            dashboards.Add(dashboard);
        }
        return dashboards;
    }

    public Dashboard? GetUserDashboardByTemplateId(User? user , int dtId)
    {
        if (user is null)
            return null;
        var dashboard = DbContext.Dashboards
            .Include(x=>x.DashboardTemplate)
            .ThenInclude(x=>x.DashboardTemplateWidgets)
            .Include(x=>x.DashboardTemplate)
            .ThenInclude(x=>x.BelongsToRole)
            .Include(x=>x.DashboardTemplate)
            .ThenInclude(x=>x.WidgetGroups)

            .Include(x=>x.DashboardWidgets)
            .FirstOrDefault(x => x.User == user && x.DashboardTemplate.Id == dtId);

        return dashboard;
    }


    private List<DashboardTemplate>? GetDashboardTemplatesByRole(List<Role> userRoles)
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

    public List<(string, List<DashboardTemplate>)>? GetUserDashboardMenuItems(User? user)
    {

        if (user is null) return null;
        List<(string, List<DashboardTemplate>)> dic = new();
        foreach (var role in user.Roles)
        {
            var dashboardTemplate = DbContext
                .DashboardTemplates
                .Where(x => x.BelongsToRole == role)
                .ToList();

            if (dashboardTemplate.Any())
                dic.Add((role.Name, dashboardTemplate));
        }

        return dic;
    }

    public Dashboard? GetDashboardByUserTemplateId(int dashboardTemplateId, int userId)
    {
        var dashboard = DbContext.Dashboards
            .Include(x => x.DashboardTemplate)
            .Include(x=>x.DashboardWidgets!)
            .ThenInclude(x=>x.Widget)

            .FirstOrDefault(x => x.DashboardTemplate.Id == dashboardTemplateId && x.User.Id == userId);


        return dashboard;
    }

    public Dashboard GenerateUserDashboardByDashboardTemplateId(int dashboardTemplateId, int userId)
    {
        var dashboardTemplate = DbContext.DashboardTemplates
            .Include(x => x.DashboardTemplateWidgets!)
            .ThenInclude(x => x.Widget)
            .First(x => x.Id == dashboardTemplateId);

        var dashboard = new Dashboard
        {
            DashboardTemplate = dashboardTemplate,
            UserFk = userId,
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
    public Dashboard GenerateUserEmptyDashboardByDashboardTemplateId(int dashboardTemplateId, User? user)
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

        DbContext.Dashboards.Add(dashboard);

        DbContext.SaveChanges();

        return dashboard;


    }

    public void UpdateDashboardWidgetSetting(DashboardWidgetSetting context)
    {
        DbContext.DashboardWidgetSettings.Update(context);
        DbContext.SaveChanges();
    }

    public void RemoveWidgetFromDashboard(Dashboard dashboard, DashboardTemplateWidget dtw)
    {
        var first = dashboard.DashboardWidgets.First(x=>x.DashboardId == dashboard.Id && x.WidgetId == dtw.WidgetId);
        DbContext.DashboardWidgetSettings.Remove(first);
        DbContext.SaveChanges();

    }

    public void UpdateDashboard(Dashboard dashboard)
    {
        DbContext.Dashboards.Update(dashboard);
        DbContext.SaveChanges();
    }

}