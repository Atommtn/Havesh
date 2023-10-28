using Amazon.Runtime.Internal;
using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using HaveshApp.Services;
using static MudBlazor.CategoryTypes;

namespace HaveshApp.Admin.Planning;

public partial class AdminSmsPanel
{
        
	[Inject]
	public DataProviderService DataProvider { get; set; }
	public List<ShokouhPardisTimeTableStudent> Students{ get; set; }
	ShokouhPardisTermClass _selectedTerm;
	ShokouhPardisSchedule _schedule;
	public IEnumerable<ShokouhPardisTimeTable> TimeTables { get; set; }
	public HashSet<ShokouhPardisTimeTable> SelectTimeTables { get; set; }
	public HashSet<ShokouhPardisTimeTableStudent> SelectStudent { get; set; }
	private List<ShokouhPardisSchedule> Schedules;
	private MudTable<ShokouhPardisTimeTable> _tables;
	private MudTable<ShokouhPardisTimeTableStudent> _studentTables;
	public bool ShowTable = false;
	private ShokouhPardisSchedule Schedule
	{
		get => _schedule;
		set
		{
			if(_schedule == value) return;
			_schedule = value;
			ShowTable = false;
			Students = null;
			RefreshTimeTable();
		}
	}

	private void RefreshTimeTable()
	{
		TimeTables=DataProvider.GetTimeTableByTermSchedule(SelectedTerm, Schedule);
	}

        


	ShokouhPardisTermClass SelectedTerm
	{
		get => _selectedTerm;
		set
		{
			if (_selectedTerm == value) return;
			_selectedTerm = value;
			RefreshData();
		}
	}

        


	void RefreshData()
	{
		Schedules = DataProvider.GetSchedules(SelectedTerm);

	}
      
	List<ShokouhPardisTimeTableStudent> GetReport()
	{
		var list = DataProvider.GetTimeTableStudents(SelectTimeTables);
		return list;
	}

	private void ShowClick()
	{
		ShowTable = true;
		Students = GetReport();
            
	}

        
}