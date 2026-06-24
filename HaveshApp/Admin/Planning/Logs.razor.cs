using Microsoft.AspNetCore.Components;
using Havesh.Application.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using MudBlazor;

namespace HaveshApp.Admin.Planning;
using Havesh.Model.Model;

public partial class Logs
{
	[Inject]
	public DataProviderService DataProvider { get; set; }

	[Inject]
	public PageStateCacheService PageState { get; set; }

	[Inject]
	public IDialogService DialogService { get; set; }

	private const string CacheKey = "Logs";

	private readonly CultureInfo _persianCulture = new CultureInfo("fa-IR");

	// نوع‌هایی که واقعاً یک رکورد قابل‌نمایش دارن (بقیه مثل Login چیزی برای باز کردن ندارن)
	private static readonly HashSet<string> ViewableEntityTypes = new() { "DailyJv", "PreRegistration", "Student" };

	private static readonly Dictionary<string, (string Icon, Color Color)> EntityVisuals = new()
	{
		["Student"] = (Icons.Material.Filled.School, Color.Primary),
		["DailyJv"] = (Icons.Material.Filled.Payments, Color.Success),
		["PreRegistration"] = (Icons.Material.Filled.HowToReg, Color.Info),
		["Login"] = (Icons.Material.Filled.Login, Color.Dark),
		["TimeTable"] = (Icons.Material.Filled.CalendarMonth, Color.Tertiary),
		["TimeTableSession"] = (Icons.Material.Filled.CalendarMonth, Color.Tertiary),
		["Term"] = (Icons.Material.Filled.DateRange, Color.Warning),
		["TermSessionTemplate"] = (Icons.Material.Filled.DateRange, Color.Warning),
		["Teacher"] = (Icons.Material.Filled.Person, Color.Secondary),
		["TeacherClass"] = (Icons.Material.Filled.Person, Color.Secondary),
		["Schedule"] = (Icons.Material.Filled.Schedule, Color.Info),
		["ClassRoom"] = (Icons.Material.Filled.MeetingRoom, Color.Secondary),
		["LevelBookPrice"] = (Icons.Material.Filled.MenuBook, Color.Warning),
		["LessonPlan"] = (Icons.Material.Filled.Book, Color.Tertiary),
		["DaySession"] = (Icons.Material.Filled.AccessTime, Color.Default),
		["TimeInterval"] = (Icons.Material.Filled.AccessTime, Color.Default),
	};

	private class LogsPageState
	{
		public DateTime? From { get; set; }
		public DateTime? To { get; set; }
		public string UserNameFilter { get; set; }
		public string RoleFilter { get; set; }
		public string EntityTypeFilter { get; set; }
		public List<ActivityLogEntry> Results { get; set; }
	}
	CultureInfo GetPersianCulture()
	{
		var culture = new CultureInfo("fa-IR");
		return culture;
	}
	public DateTime? From { get; set; }
	public DateTime? To { get; set; }
	public string UserNameFilter { get; set; }
	public string RoleFilter { get; set; }
	public string EntityTypeFilter { get; set; }
	public List<ActivityLogEntry> Results { get; set; }
	public List<User> Users { get; set; } = new();

	protected override void OnInitialized()
	{
		Users = DataProvider.GetUsers();

		if (PageState.TryGet<LogsPageState>(CacheKey, out var state))
		{
			From = state.From;
			To = state.To;
			UserNameFilter = state.UserNameFilter;
			RoleFilter = state.RoleFilter;
			EntityTypeFilter = state.EntityTypeFilter;
			Results = state.Results;
		}
		else
		{
			// پیش‌فرض: ۷ روز گذشته
			From = DateTime.Today.AddDays(-7);
			To = DateTime.Today.AddDays(1);
		}
	}

	void Search()
	{
		Results = DataProvider.GetActivityLogs(From, To, UserNameFilter, RoleFilter, EntityTypeFilter);
		SaveState();
	}

	private void SaveState()
	{
		PageState.Set(CacheKey, new LogsPageState
		{
			From = From,
			To = To,
			UserNameFilter = UserNameFilter,
			RoleFilter = RoleFilter,
			EntityTypeFilter = EntityTypeFilter,
			Results = Results
		});
	}

	private string GetEntityIcon(string entityType) =>
		EntityVisuals.TryGetValue(entityType ?? string.Empty, out var v) ? v.Icon : Icons.Material.Filled.Info;

	private Color GetEntityColor(string entityType) =>
		EntityVisuals.TryGetValue(entityType ?? string.Empty, out var v) ? v.Color : Color.Default;

	private bool IsViewable(ActivityLogEntry entry) =>
		entry.EntityId.HasValue && ViewableEntityTypes.Contains(entry.EntityType ?? string.Empty);

	private async Task OpenEntityDialog(ActivityLogEntry entry)
	{
		if (!IsViewable(entry)) return;

		await DialogService.ShowAsync<LogEntityDialog>("جزئیات", new DialogParameters
		{
			["EntityType"] = entry.EntityType,
			["EntityId"] = entry.EntityId.Value
		}, new DialogOptions
		{
			MaxWidth = MaxWidth.Medium,
			FullWidth = true
		});
	}
}
