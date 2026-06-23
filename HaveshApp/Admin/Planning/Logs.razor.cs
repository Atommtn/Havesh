using Microsoft.AspNetCore.Components;
using Havesh.Application.Services;
using System;
using System.Collections.Generic;

namespace HaveshApp.Admin.Planning;

public partial class Logs
{
	[Inject]
	public DataProviderService DataProvider { get; set; }

	[Inject]
	public PageStateCacheService PageState { get; set; }

	private const string CacheKey = "Logs";

	private class LogsPageState
	{
		public DateTime? From { get; set; }
		public DateTime? To { get; set; }
		public string UserNameFilter { get; set; }
		public string RoleFilter { get; set; }
		public string EntityTypeFilter { get; set; }
		public List<ActivityLogEntry> Results { get; set; }
	}

	public DateTime? From { get; set; }
	public DateTime? To { get; set; }
	public string UserNameFilter { get; set; }
	public string RoleFilter { get; set; }
	public string EntityTypeFilter { get; set; }
	public List<ActivityLogEntry> Results { get; set; }

	protected override void OnInitialized()
	{
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
}
