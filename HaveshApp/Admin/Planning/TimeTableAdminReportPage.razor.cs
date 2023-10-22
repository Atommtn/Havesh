using Amazon.Runtime.Internal;
using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using HaveshApp.Services;
using static MudBlazor.CategoryTypes;

namespace HaveshApp.Admin.Planning;

public partial class TimeTableAdminReportPage
{

	[Inject] ISnackbar Snackbar { get; set; }
	[Inject] DataProviderService DataProvider { get; set; }
	[Inject] DataProviderAsyncService DataProviderAsync { get; set; }
	[Inject] IDialogService DialogService { get; set; }

	List<ShokouhPardisTimeTable>? Timetable = null;
	MudTable<ShokouhPardisTimeTable>? table;
	private ChartOptions ChartOP = new ChartOptions();
	private ChartOptions ChartLineOP = new ChartOptions();

	public IEnumerable<ShokouhPardisTimeTable> DataGridTimeTables = new List<ShokouhPardisTimeTable>();
	private Dictionary<int, int> _timeTableStudentsCount;
	ShokouhPardisTermClass? _selectedTerm;
	ShokouhPardisTermClass? SelectedTerm
	{
		get => _selectedTerm;
		set
		{
			if (value == null || _selectedTerm == value) return;
			_selectedTerm = value;
			//if (table == null) return;
			Series = new List<ChartSeries>();
			RefreshData();
		}
	}

	public string? LevelSearch { get; set; }
	private HashSet<string> _SelectedLevelGroups;
	HashSet<string> SelectedLevelGroups
	{
		get => _SelectedLevelGroups;
		set
		{
			_SelectedLevelGroups = value;
			LevelSearch = null;
			SearchBySelection();
			Index = 0;
		}
	}

	public List<ChartSeries> Series = new List<ChartSeries>();
	public string[] XAxisLabels = new string[50];
	private List<ShokouhPardisLevelClass> Levels { get; set; }

	//        private int Index = -1; //default value cannot be 0 -> first selectedindex is 0.
	private int _index;
	public int Index
	{
		get { return _index; }
		set
		{
			_index = value;
		}
            
	}

	private Dictionary<ShokouhPardisLevelClass, int>? chartData1;
	private Dictionary<ShokouhPardisLevelClass, int>? chartData2;
        
	private List<string>? GroupingLevel = new List<string>();
	private List<string> LevelGroupingDistinct = new List<string>();
	private EventCallback<string> ShokouhPardis_DailyJVLevelSelectedValuesChanged;
        


	void RefreshData()
	{
		Levels = DataProvider.GetTimeTableLevelChartData(_selectedTerm).Keys.ToList();
		Levels.ForEach(level =>
		{
			GroupingLevel.Add( level.Grouping);
		});
		LevelGroupingDistinct = GroupingLevel.Distinct().ToList();
		chartData1 =chartData2 = DataProvider.GetTimeTableLevelChartData(_selectedTerm);
		Series.Add(new ChartSeries()
		{
			Name = "level",
			Data = chartData1.Values.Select(Convert.ToDouble).ToArray()
		});

		XAxisLabels = chartData1.Keys.Select(x => x.LevelName.ToString()).ToArray();
		ChartLineOP.YAxisTicks = 0;
            
		SearchChange();
	}


	private void SearchChange()
	{
		if (!string.IsNullOrEmpty(LevelSearch))
		{
			chartData2 = chartData1.Where(x =>
					x.Key.LevelName.Contains(LevelSearch, StringComparison.OrdinalIgnoreCase))
				.ToDictionary(x => x.Key, y => y.Value);
		}
		else
		{
			chartData2 = chartData1;
		}
		SelectedLevelGroups = null;
	}
	private void SearchBySelection()
	{
		if (SelectedLevelGroups != null && SelectedLevelGroups.Any())
		{
			chartData2 = chartData1
				.Where(x => SelectedLevelGroups.Any(z=>x.Key.LevelName.Contains(z, StringComparison.OrdinalIgnoreCase)))
				.ToDictionary(x => x.Key, y => y.Value);
		}
		else
		{
			chartData2 = chartData1;
		}
	}

	private void IndexchangeClick(int index)
	{
            
	}

	private string GetInfo(int index)
	{
            
		var level = chartData2.Select(x => x.Key).ToArray()[index];
		var count = chartData2.Select(x => x.Value).ToArray()[index];
            
		return $"{level.LevelName} -  STD Count:{count}";
	}
	private string GetChartColor(int index)
	{
		int ind=0;
		string color;
		if (index >= 20)
		{
			ind = index - 20;
		}
		else
		{
			ind=index;
		}
		if (ChartOP.ChartPalette[ind] is { })
		{
			color = ChartOP.ChartPalette[ind];

		}
		else
		{
			color = "000000";
		}
		return color;
	}
}