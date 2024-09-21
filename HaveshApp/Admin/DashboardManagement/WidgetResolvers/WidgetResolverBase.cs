using Havesh.Model.Data.Dashboard;
using Microsoft.AspNetCore.Components;

namespace HaveshApp.Admin.DashboardManagement.WidgetResolvers;

public abstract class WidgetResolverBase : ComponentBase
{
    [Parameter]
    public DashboardWidgetSetting WidgetSetting { get; set; }

    protected static string BranchName => Environment.GetEnvironmentVariable("BranchName")!;


    public virtual string ResoleValue()
    {
        return string.Empty;
    }
}