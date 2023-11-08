using Havesh.Model.Data.Dashboard;
using Microsoft.AspNetCore.Components;

namespace HaveshApp.Admin.Dashboard.Personal.Widgets
{
    public class WidgetContainerBase : ComponentBase
    {
        [Parameter]
        public DashboardWidgetSetting WidgetSetting { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

    }
}
