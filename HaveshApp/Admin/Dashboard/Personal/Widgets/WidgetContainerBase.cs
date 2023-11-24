using Havesh.Model.Data.Dashboard;
using Microsoft.AspNetCore.Components;

namespace HaveshApp.Admin.Dashboard.Personal.Widgets
{
    public class WidgetContainerBase : ComponentBase
    {
	    private string _addToRole;

	    [Parameter]
        public DashboardWidgetSetting WidgetSetting { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter] public object? ViewRequired { get; set; } = false;

        private const string DefaultRoles = "Admin";

        [Parameter]
        public string ToRoles
        {
	        get => _addToRole;
	        set
	        {
		        _addToRole = value;
		        if (_addToRole.StartsWith("..."))
			        _addToRole = string.Join(",", DefaultRoles, _addToRole.Replace("...", null));
	        }
        }
    }
}
