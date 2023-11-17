using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HaveshApp.Admin.Dashboard.Personal.Widgets
{
    public class WidgetBase : ComponentBase
    {
        [Parameter]
        public RenderFragment? ChildContent { get; set; }

        [Parameter]
        public string? BreakPoints { get; set; }

        [Parameter]
        public string Height { get; set; } = "100%";

        [Parameter]
        public string Icon { get; set; } = Icons.Material.Filled.Euro;

        [Parameter]
        public Color? IconColor { get; set; } = Color.Primary;

        [Parameter]
        public int? IconSize { get; set; } = 54;

        [Parameter]
        public string TitleClass { get; set; } = "mud-text-secondary";

        [Parameter]
        public string Title { get; set; } = "Title";

        [Parameter]
        public bool? IsInline { get; set; }

        [Parameter]
        public string? Value { get; set; }
    }
}
