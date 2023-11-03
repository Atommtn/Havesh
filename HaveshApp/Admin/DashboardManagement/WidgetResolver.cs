using Havesh.Model.Data.Dashboard;
using Microsoft.AspNetCore.Components;

namespace HaveshApp.Admin.DashboardManagement;

public abstract class WidgetResolver : ComponentBase
{
    [Parameter]
    public Widget Widget { get; set; }

    public virtual string ResoleValue()
    {
        return string.Empty;
    }
}