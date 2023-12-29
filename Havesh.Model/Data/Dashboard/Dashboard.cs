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
        public List<WidgetGroup>? WidgetGroups { get; set; }
    }

    public class DashboardTemplateWidget
    {
        [Key, Column(Order = 1)]
        public int DashboardTemplateId { get; set; }
        [Key, Column(Order = 2)]
        public int WidgetId { get; set; }

        // Navigation properties to represent the relationship
        public DashboardTemplate DashboardTemplate { get; set; }
        public WidgetGroup? WidgetGroup { get; set; }
        public Widget Widget { get; set; }

        [NotMapped]
        public bool CanAdd { get; set; }
    }

    public class Dashboard
    {
        public int Id { get; set; }

        public int UserFk { get; set; }
        
        [ForeignKey(nameof(UserFk))]
        public User User { get; set; }

        public DashboardTemplate DashboardTemplate { get; set; }

        public List<DashboardWidgetSetting>? DashboardWidgets { get; set; }
    }

    public class DashboardWidgetSetting
    {
        private string? _title;
        private string? _titleClass;
        private string? _height;
        private string? _iconName;
        private string? _icon;
        private int? _iconSize;
        private string? _breakPoints;
        private Color? _iconColor;

        [Key, Column(Order = 1)]
        public int DashboardId { get; set; }
        [Key, Column(Order = 2)]
        public int WidgetId { get; set; }

        public Dashboard Dashboard { get; set; }
        public WidgetGroup? WidgetGroup { get; set; }
        public Widget Widget { get; set; }

        public int Order { get; set; }

        public string? Title
        {
            get => _title ?? Widget.Title;
            set => _title = value;
        }

        public string? TitleClass
        {
            get => _titleClass ?? Widget.TitleClass;
            set => _titleClass = value;
        }

        public string? Height
        {
            get => _height ?? Widget.Height;
            set => _height = value;
        }

        public string? IconName
        {
            get => _iconName ?? Widget.IconName;
            set => _iconName = value;
        }

        public Color? IconColor
        {
            get => _iconColor ?? Widget.IconColor;
            set => _iconColor = value;
        }

        public string? Icon
        {
            get => _icon ?? Widget.Icon;
            set => _icon = value;
        }

        public int? IconSize
        {
            get => _iconSize ?? Widget.IconSize;
            set => _iconSize = value;
        }

        public string? BreakPoints
        {
            get => _breakPoints ?? Widget.BreakPoints;
            set => _breakPoints = value;
        }

        public bool? Hidden { get; set; }
        public bool? IsInline { get; set; }
        
        public Func<MessageDto, Task>? MessageReceived;
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

        public bool? IsInline { get; set; }

		public bool AllowRemove { get; set; } = false;
        public bool AllowHidden { get; set; } = false;

        public List<DashboardTemplateWidget>? DashboardTemplateWidgets { get; set; }

        public List<DashboardWidgetSetting>? DashboardWidgets { get; set; }
        public string? BelongToRoles { get; set; }

    }


    public class WidgetGroup
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Title { get; set; }

        public Role BelongToRole { get; set; }

        public string? IconName { get; set; }
        public string? Icon { get; set; }
        public Color? IconColor { get; set; } = Color.Default;
        public int? IconSize { get; set; } = 54;

        public GroupTypeEnum GroupType { get; set; }
    }

    public enum GroupTypeEnum
    {
        None,
        HeaderLine,
        Border
    }
}
