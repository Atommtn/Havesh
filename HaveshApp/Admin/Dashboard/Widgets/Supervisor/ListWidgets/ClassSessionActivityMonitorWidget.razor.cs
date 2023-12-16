using DNTPersianUtils.Core;
using Havesh.Common;
using Havesh.Domain.Services;
using Havesh.GrainInterfaces.Entity;
using Havesh.Grains.Manager;
using Havesh.Model.Model;
using Havesh.OrleansClient;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MudBlazor;
using Orleans.Runtime;
using Orleans.Streams;

namespace HaveshApp.Admin.Dashboard.Widgets.Supervisor.ListWidgets
{
	public partial class ClassSessionActivityMonitorWidget
	{

		string? SearchText = null;
		//RenderFragment<TimeTableSession> teacherFragment = bulder => ;

		[Inject] SupervisorWidgetsService SupervisorWidgetsService { get; set; } = null!;
		[Inject] IClusterClient ClusterCLient { get; set; }
		List<TimeTableSession>? _timeTableSessions;
		SessionActivity? _activitiey;
		private StreamSubscriptionHandle<StudentSessionActivity>? _streamSubscriptionHandle;

		private async Task InitSubscribeToStudentActivityPerformAsync()
		{
			if (_streamSubscriptionHandle != null)
				await _streamSubscriptionHandle.UnsubscribeAsync();

			var streamProvider = ClusterCLient.GetStreamProvider(HaveshConstants.OrleansSimpleMessageProviderName);
			var stream1 = streamProvider.GetStream<StudentSessionActivity>(
				StreamId.Create(HaveshConstants.StudentSessionActivityStreamNamespace, HaveshConstants.GeneralKey));
			var consumer = new HaveshStreamConsumer<StudentSessionActivity>(OnStudentActivityPerformedEvent);
			_streamSubscriptionHandle = await stream1.SubscribeAsync(consumer);
		}

		protected override async Task OnInitializedAsync()
		{
			await InitSubscribeToStudentActivityPerformAsync();
			await Init();
			await Task.Delay(100);
			await InvokeAsync(StateHasChanged);
			await base.OnInitializedAsync();
		}

		protected override async Task OnParametersSetAsync()
		{
			await base.OnParametersSetAsync();
		}

		protected override async Task OnAfterRenderAsync(bool firstRender)
		{
			await base.OnAfterRenderAsync(firstRender);
			if (firstRender)
			{
			}
		}

		private async Task Init()
		{
			var managerGrain = ClusterCLient.GetGrain<IStudentSessionActivityManagerGrain>(Guid.Empty);
			_activitiey = await managerGrain.GetDefaultSesionActivity();

			await ClearSearchClick();
		}

		private async Task ClearSearchClick()
		{
			_timeTableSessions = await Search(null);
		}

		private async Task SearchList(string? text)
		{
			_timeTableSessions = await Search(text);
		}

		private async Task<List<TimeTableSession>?> Search(string? search = null)
		{
			var timeTableSessions = ((await SupervisorWidgetsService.GetTimeTableSessions())!).ToList();
			timeTableSessions = await InitUIObjects(timeTableSessions);
			if (!string.IsNullOrEmpty(search))
			{
				timeTableSessions = timeTableSessions
					.Where(x =>
						x.SessionStatus.Contains(search) ||
						x.Teacher.FullName.Contains(search) ||
						(x.TimeTable.Title?.Contains(search) ?? false) ||
						x.TimeTable.Level.LevelName.Contains(search) ||
						x.ClassRoom.ClassRoomName.Equals(search) ||
						(x.TimeTable.Students?.Any(s => s.FullName.Contains(search)) ?? false))
					.ToList();
			}

			await Task.Delay(100);
			return timeTableSessions;
		}

		private async Task<List<TimeTableSession>> InitUIObjects(List<TimeTableSession> ttsArg)
		{
			var sessionManagerGrain = ClusterCLient.GetGrain<ITimeTableSessionManagerGrain>(Guid.Empty);
			foreach (var tts in ttsArg)
			{
				var sessionActivityValueOptions =
					await sessionManagerGrain.GetSessionStudentActivitiesPerformed(tts.Id);
				var sessionActivities =
					(sessionActivityValueOptions ?? Array.Empty<StudentSessionActivity>())
						.ToList();
				tts.Tag = sessionActivities;

				var timeTableGrain = ClusterCLient.GetGrain<ITimeTableGrain>(tts.TimeTableFk);
				tts.TimeTable.Students = await timeTableGrain.GetStudents();
			}

			StateHasChanged();
			return ttsArg;
		}

		readonly object objLock = new();

		private async Task OnStudentActivityPerformedEvent(StudentSessionActivity arg)
		{
			if (_activitiey != null &&
				//_activitiey.Id == arg.ActivityFk &&
				_timeTableSessions != null)
			{
				var timeTableSession = _timeTableSessions.FirstOrDefault(x => x.Id == arg.TimeTableSessionFk);
				if (timeTableSession == null)
					return;

				await InvokeAsync(async () =>
				{
					var sessionManagerGrain = ClusterCLient.GetGrain<ITimeTableSessionManagerGrain>(Guid.Empty);
					var sessionStudentActivitiesPerformed = await sessionManagerGrain.GetSessionStudentActivitiesPerformed(timeTableSession.Id);
					var studentSessionActivities = sessionStudentActivitiesPerformed.ToList();
					timeTableSession.Tag = studentSessionActivities;
					lock (objLock)
					{

						if (studentSessionActivities.Count > 0)
							if (timeTableSession.SessionStatus != SessionStatuses.Running)
							{
								timeTableSession.SessionStatus = SessionStatuses.Running;
								_dataProvider.UpdateTimeTableSession(timeTableSession);
							}

					}
					StateHasChanged();
				});
			}

		}


		private IEnumerable<IGrouping<StudentSessionActivity, StudentSessionActivity>>? GetOptions(object? tag)
		{
			IEnumerable<IGrouping<StudentSessionActivity, StudentSessionActivity>>? ls = null;
			if (tag is List<StudentSessionActivity> { Count: > 0 } lst &&
				_activitiey != null)
			{
				ls = lst
					.Where(x => x.ActivityFk == _activitiey.Id)
					.GroupBy(x => x,
						new ValueComparer<StudentSessionActivity>(
							(x, y) =>
								(x != null && y != null) && x.ActivityValueOptionFk == y.ActivityValueOptionFk,
							option => option.ActivityValueOptionFk.GetHashCode()))
					;
			}
			return ls;
		}

		private Color GetButtonColor(StudentSessionActivity ssa)
		{
			if (ssa.ActivityValueOption?.Color == null)
				return Color.Default;

			return ssa.ActivityValueOption.Color.ToLower() switch
			{
				"green" => Color.Success,
				"yellow" => Color.Warning,
				"red" => Color.Error,
				"blue" => Color.Primary,
				_ => Color.Default
			};
		}


		public async ValueTask DisposeAsync()
		{
			if (_streamSubscriptionHandle != null) await
				_streamSubscriptionHandle.UnsubscribeAsync();
		}

		private async Task ActivityChipClick(TimeTableSession context, SessionActivity? sa = null)
		{
			sa ??= _activitiey;
			await _dialogService.ShowAsync<ClassSessionActivityMonitorWidgetDialog>(
				$" {sa.ActivityTitle} کلاس {context.ClassRoom.ClassRoomName} جلسه {context.SessionNumber} ({context.SessionDate?.ToPersianDateTextify()} ساعت {context.SessionTime} ) دوره {context.TimeTable.Level.LevelName} مدرس {context.Teacher.FullName} ",
				new DialogParameters<ClassSessionActivityMonitorWidgetDialog>
						{
				{ dialog => dialog.TimeTableSession, context },
				{ dialog => dialog.SessionActivity , sa}
						},
				new DialogOptions()
				{
					CloseButton = true,
					CloseOnEscapeKey = true,
					DisableBackdropClick = false,
					MaxWidth = MaxWidth.Large,
					FullWidth = true
				});
		}





	}
}
