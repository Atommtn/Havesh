using Microsoft.AspNetCore.Components;
using MudBlazor;
using Olive;
using Havesh.Domain.Services;
using System.Xml;
using Havesh.Model.Model;
using HaveshApp.Managment.Session.Cancel;
using static MudBlazor.CategoryTypes;
using HaveshApp.Admin.Planning.Components;

namespace HaveshApp.Managment.Session;

public partial class ClassProgramPage : ICanChangeComponentState
{
	[Parameter]
	public string? Options
	{
		get => _options;
		set
		{
			_options = value;
			switch (_options)
			{
				case "SessionGenerator":
					IsSessionGenerator = true;
					break;
				case "SessionCancel":
					IsSessionCanceler = true;
					break;
			}
		}
	}

	private bool dense
	{
		get => _dense;
		set
		{
			if (_dense == value) return;

			_dense = value;
		}
	}

	public bool? IsSessionGenerator { get; set; }
	public bool? IsSessionCanceler { get; set; }

	[Inject] DataProviderService DataProvider { get; set; }

	List<ShokouhPardisTimeTable> _all;
	List<ShokouhPardisTimeTable> _tt;
	ShokouhPardisTermClass? _selectedTerm;
	Dictionary<int, int> _sessionsCountByTermId;

	List<ShokouhPardisClassRoom> _classRooms;
	List<ShokouhPardisInterval>? _intervals;
	List<ShokouhPardisWeekDay> _weekdays;

	Dictionary<int, int>? _timeTablestudentCount;
	bool? _oddEvenSwitch;

	protected override void OnInitialized()
	{
		_weekdays = DataProvider.GetWeekDays();
		_classRooms = DataProvider.GetClassRooms();

		OddEvenSwitch = !(DateTime.Now.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Monday or DayOfWeek.Wednesday);
		_isPm = DateTime.Now.Hour >= 12;
		base.OnInitialized();
	}

	ShokouhPardisTermClass? SelectedTerm
	{
		get => _selectedTerm;
		set
		{
			if (_selectedTerm == value) return;
			_selectedTerm = value;
			_initData = false;
			InitTimeTables();
		}
	}

	bool _initData = false;
	void InitTimeTables()
	{
		if (_initData)
		{
			FilterUi();
			return;
		}
            
		_all = _dataProvider.GetAllTimeTableSchedulesByTermId(_selectedTerm.Id).ToList();
		_timeTablestudentCount = DataProvider.GetTimeTableStudentsCount(_selectedTerm);
		_sessionsCountByTermId = _dataProvider.GetTimeTableSessionsCountByTermId(_selectedTerm.Id);
		_prices = DataProvider.GetTermLevelPrices(_selectedTerm);
		_initData = true;
		FilterUi();
	}


	private ShokouhPardisTimeTable GetTimeTable(ShokouhPardisInterval interval, ShokouhPardisClassRoom? classRoom, IEnumerable<ShokouhPardisWeekDay> wds)
	{
		if (_tt == null || wds == null || !wds.Any()) 
			return null;


		var timeTable = _tt.FirstOrDefault(x =>
			x.TermId == _selectedTerm.Id &&
			x.ClassRoomId == classRoom.Id &&
			x.Schedule.Programs.All(p => wds.Select(w => w.Id).Contains(p.DaySession.WeekdayId)) &&
			x.Schedule.Programs.Any(p => p.DaySession.IntervalId == interval.Id)
		);
		return timeTable;
	}

	IEnumerable<ShokouhPardisWeekDay> SelectedWeekdays { get; set; }

	readonly int[] _oddDayIds = { 2, 4 };
	readonly int[] _evenDayIds = { 1, 5 };
	bool _isPm = true;
	bool _showPrices = false;

	public bool? OddEvenSwitch
	{
		get => _oddEvenSwitch;
		set
		{
			if (_oddEvenSwitch == value) return;
			_oddEvenSwitch = value;
			SelectedWeekdays = _oddEvenSwitch is true ?
				_weekdays.Where(x => _oddDayIds.Contains(x.Id)) :
				_weekdays.Where(x => _evenDayIds.Contains(x.Id));
		}
	}

	public bool IsPm
	{
		get => _isPm;
		set
		{
			if (_isPm == value) return;
			_isPm = value;
			FilterUi();
		}
	}

	void FilterUi()
	{
		var filter1 = _all.Where(x => x.IsPrivate == _isPrivate);
		_tt = _isPm
			? filter1.Where(x => x.Schedule.Programs.Any(p =>
					p.DaySession.Interval.StartTime != null &&
					p.DaySession.Interval.StartTime.Value.Hours > 12))
				.ToList()
			: filter1.Where(x => x.Schedule.Programs.Any(p =>
					p.DaySession.Interval.StartTime != null &&
					p.DaySession.Interval.StartTime.Value.Hours < 12))
				.ToList();
		_tt.ForEach(t =>
		{
			if (_timeTablestudentCount.TryGetValue(t.Id, out var zz))
				t.StudentsCount = zz;
		});

		_intervals = _tt?.SelectMany(x => x.Schedule.Programs.Select(p => p.DaySession.Interval)
			)
			.DistinctBy(x => x.Id)
			.OrderBy(x => x.StartTime)
			.ToList();
	}

	public bool ShowPrices
	{
		get => _showPrices;
		set
		{
			if (_showPrices == value) return;

			_showPrices = value;

		}
	}



	public bool isPrivate
	{
		get => _isPrivate;
		set
		{
			_isPrivate = value;
			FilterUi();
		}
	}
	List<ShokouhPardisLevelBookPrice>? _prices;

	//ShokouhPardisTermClass? _pricesForTerm;
	private bool _isPrivate;
	string? _options;
	private bool _dense = true;

	[Inject] TimeTableSessionService TTSessionService { get; set; }


	[Inject] public IDialogService DialogService { get; set; }

	async Task OpenGenerateSessionsDialogbyInterval(ShokouhPardisInterval interval,
		IEnumerable<ShokouhPardisWeekDay> weekDays)
	{
		if (IsSessionGenerator is not true)
			return;

		var currentTemplateId = 0;

		var timeTables = GetTimeTables(interval, weekDays).Where(x => x != null).ToList();
		var sessionsTemplate = _dataProvider.GetTermTemplateByWeekdayIds(SelectedTerm, string.Join(',',
			weekDays.Select(x => x.Id).OrderBy(x => x)));
		if (sessionsTemplate is null)
		{
			_snackBar.Add("برای این ترم هیچ برنامه برگزاری / تمپلیت  هنوز تعریف نشده است.", Severity.Warning);
			return;
		}
		var sessionsCount = TTSessionService.GetTermTemplateSessionCount(sessionsTemplate);
		var dialogReference = await DialogService.ShowAsync<TermSessionGeneratorDilog>("تولید جلسات هر برنامه",
			new DialogParameters()
			{
				["TimeTables"] = timeTables,
				["SessionsTemplate"] = sessionsTemplate,
				["SessionsCount"] = sessionsCount
			},
			new DialogOptions()
			{
				CloseButton = false,
				MaxWidth = MaxWidth.Medium,
				FullWidth = true,
				CloseOnEscapeKey = false,
				DisableBackdropClick = true
			});
		var dialogReferenceResult = await dialogReference.Result;
		if (dialogReferenceResult.Canceled == false)
		{
			_snackBar.Add("جلسات این سانس با موفقیت ایجاد گردید", Severity.Success);
			_initData = false;
			InitTimeTables();
		}
		else
		{
			_snackBar.Add("ایجاد جلسات کنسل گردید.", Severity.Error);
		}
	}

	private IEnumerable<ShokouhPardisTimeTable> GetTimeTables(ShokouhPardisInterval interval,
		IEnumerable<ShokouhPardisWeekDay> wds)
	{
		return from classRoom
				in _classRooms
			where _tt != null && wds != null
			select _tt.FirstOrDefault(x =>
				x.ClassRoomId == classRoom.Id &&
				wds.Any() &&
				x.Schedule.Programs.All(p => wds.Select(w => w.Id).Contains(p.DaySession.WeekdayId)) &&
				x.Schedule.Programs.Any(p => p.DaySession.IntervalId == interval.Id)
			);
	}

	int GetTimeTableSessionsCount(ShokouhPardisTimeTable timeTable)
	{
		return !_sessionsCountByTermId.ContainsKey(timeTable.Id) ?
			0 :
			_sessionsCountByTermId[timeTable.Id];
	}

	async Task SessionCancelClick(ShokouhPardisTimeTable timeTable)
	{
		await DialogService.ShowAsync<TimeTableSessionManagementDialog>("Manage Sessions", new DialogParameters()
			{
				["TimeTable"] = timeTable
			},
			new DialogOptions()
			{
				MaxWidth = MaxWidth.Medium,
				FullWidth = true
			});
	}

	public TimeTableSessionService TableSessionService { get; set; }

	async Task CancellFulldayClick()
	{
		var timeTables = GetTimeTables(SelectedTerm! , SelectedWeekdays)
			.Where(x => x != null)
			.ToList();
		var res = await DialogService.ShowAsync<IntervalCancellationDialog>("Cancel Interval",
			new DialogParameters()
			{
				["TimeTablesToCancel"] = timeTables,
				["Interval"] = null
			},
			new DialogOptions()
			{
				MaxWidth = MaxWidth.Medium,
				FullWidth = true
			});
		var dialogResult = await res.Result;

	}

	IEnumerable<ShokouhPardisTimeTable?> GetTimeTables(ShokouhPardisTermClass selectedTerm, IEnumerable<ShokouhPardisWeekDay> wds)
	{
		return _tt.Where(x =>
			x.TermId == selectedTerm.Id &&
                    
			x.Schedule.Programs
				.All(p => wds.Select(w => w.Id).Contains(p.DaySession.WeekdayId))
		);
	}

	async Task IntervalCancelClick(ShokouhPardisInterval interval)
	{
		var timeTables = GetTimeTables(interval, SelectedWeekdays)
			.Where(x => x != null)
			.ToList();
		var res = await DialogService.ShowAsync<IntervalCancellationDialog>("Cancel Interval",
			new DialogParameters()
			{
				["TimeTablesToCancel"] = timeTables,
				["Interval"] = interval
			},
			new DialogOptions()
			{
				MaxWidth = MaxWidth.Medium,
				FullWidth = true
			});
		var dialogResult = await res.Result;
	}


	public void ChangeYourState()
	{
		InvokeAsync(() =>
		{
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxx");
			_initData = false;
			InitTimeTables();
			StateHasChanged();
		});
	}

 
}