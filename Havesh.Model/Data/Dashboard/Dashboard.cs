using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Havesh.Model.Model;
using Microsoft.EntityFrameworkCore;
using MudBlazor;

namespace Havesh.Model.Data.Dashboard
{
    public class DashboardTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role BelongsToRole { get; set; }

        public List<DashboardTemplateWidget>? DashboardTemplateWidgets { get; set; }
    }

    public class DashboardTemplateWidget
    {
        [Key,Column(Order = 1)]
        public int DashboardTemplateId { get; set; }
        [Key , Column(Order = 2)]
        public int WidgetId { get; set; }

        // Navigation properties to represent the relationship
        public DashboardTemplate DashboardTemplate { get; set; }
        public Widget Widget { get; set; }
    }

    public class Dashboard
    {
        public int Id { get; set; }
        public User User { get; set; }

        public DashboardTemplate DashboardTemplate { get; set; }

        public List<DashboardWidgetSetting>? DashboardWidgets { get; set; }
    }

    public class DashboardWidgetSetting
    {
        [Key, Column(Order = 1)]
        public int DashboardId { get; set; }
        [Key, Column(Order = 2)]
        public int WidgetId { get; set; }

        public Dashboard Dashboard { get; set; }
        public Widget Widget { get; set; }

        public int Order { get; set; }
        public string? Title { get; set; }
        public string? TitleClass { get; set; }
        public string? Height { get; set; }
        public string? Icon { get; set; }
        public int? IconSize { get; set; }
        public string? BreakPoints { get; set; }
        public bool? Hidden { get; set; }
    }

    public class Widget
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string? TitleClass { get; set; } = "mud-text-secondary";
        public string? Height { get; set; } = "100px";
        public string? IconName { get; set; } = "Person";
        public string? Icon { get; set; } = Icons.Material.Filled.Person;
        public Color IconColor { get; set; } = Color.Default;
        public int? IconSize { get; set; } = 54;
        public string? BreakPoints { get; set; } = "xs=12,sm=6,md=3";

        public bool AllowRemove { get; set; } = false;
        public bool AllowHidden { get; set; } = false;

        public List<DashboardTemplateWidget>? DashboardTemplateWidgets { get; set; }

        public List<DashboardWidgetSetting>? DashboardWidgets { get; set; }

    }
}
