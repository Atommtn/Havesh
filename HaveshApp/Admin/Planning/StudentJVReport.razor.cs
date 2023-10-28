using Amazon.Runtime.Internal;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MudBlazor;
using HaveshApp.Admin.DailyJV.Components;
using HaveshApp.Services;
using System;
using System.Linq;
using System.Xml;
using Havesh.Model.Model;
using static MudBlazor.CategoryTypes;
using static MudBlazor.Colors;

namespace HaveshApp.Admin.Planning;

public partial class StudentJVReport
{
        
	[Inject]
	public DataProviderService DataProvider { get; set; }
	[Inject]
	public ISnackbar Snackbar { get; set; }
	public List<ShokouhPardisTimeTableStudent> Students{ get; set; }
	private MudTable<ShokouhPardisTimeTableStudent> _studentTables;
	ShokouhPardisTermClass _selectedTerm;
	ShokouhPardisSchedule _schedule;
	public IEnumerable<ShokouhPardisTimeTable> TimeTables { get; set; }
	public HashSet<ShokouhPardisTimeTable> SelectTimeTables { get; set; }
	public HashSet<ShokouhPardisTimeTableStudent> SelectStudent { get; set; }
	private List<ShokouhPardisSchedule> Schedules;
	private MudTable<ShokouhPardisTimeTable> _tables;
     
	public bool ShowTable = false;
	private Dictionary<int, List<ShokouhPardisDailyJv>> StudentJVS = new Dictionary<int, List<ShokouhPardisDailyJv>>();
	private Dictionary<int,int> StudentJVSFull ;
	private Dictionary<int, List<ShokouhPardisDailyJv>> StudentJVDicX;
	private List<ShokouhPardisDailyJv> _jvs;

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
      
	List<ShokouhPardisTimeTableStudent> GetReport(ShokouhPardisTimeTable SelectTimeTable)
	{
		var report = DataProvider.GetTimeTableStudent(SelectTimeTable);
		return report;
	}

	//private void ShowClick()
	//{
	//    StudentJVSFull = new Dictionary<int, int>();
	//    ShowTable = true;
	//    Students = GetReport();
	//    _jvs = DataProvider.GetDailyJvsByTerm(SelectedTerm.TermClassId);
	//    //StudentJVDic = GetStudentDailyJV(Students.Select(x=>x.Student).ToList());
	//}
	//private Dictionary<int, List<ShokouhPardisDailyJv>> GetStudentDailyJV(List<ShokouhPardisStudentClass> Students)
	//{

	//    foreach (ShokouhPardisStudentClass student in Students)
	//    {
             
	//        var list = DataProvider.GetDailyJvBy(SelectedTerm.TermClassId, student.StudentClassId);
	//        if (list.Count > 0)
	//            StudentJVS.Add(student.StudentClassId, list);

	//    }

	//    return StudentJVS;
	//}
     

	//private int GetStudentPaymentStatus(ShokouhPardisStudentClass student)
	//{
	//    var TTStdLevel = DataProvider.GetStudetnLevel(student, SelectedTerm);
	//    var shahriehDarInTerm = DataProvider.GetLevelBookPrice(SelectedTerm.TermClassId, TTStdLevel.Level.LevelClassId);
	//    //var list = DataProvider.GetDailyJvBy(SelectedTerm.TermClassId, student.StudentClassId);
	//    var list = _jvs.Where(x=>x.StudentId == student.StudentClassId);

	//    int jamPardakhtiShahrieh = list.Where(x => x.FeeFor.Equals("شهریه")).Sum(x => x.Fee);
	//    var jamPardakhtiKetab = list.Where(x => x.FeeFor.Equals("کتاب")).Sum(x => x.Fee);

	//    if (jamPardakhtiShahrieh < shahriehDarInTerm.TuitionAmount)
	//    {
	//        // Bedehkar
	//        return -1;
	//    }

	//    if (jamPardakhtiShahrieh > shahriehDarInTerm.TuitionAmount)
	//    {
	//        // Bestankar
	//        return 1;
	//    }
	//    if (jamPardakhtiShahrieh == shahriehDarInTerm.TuitionAmount)
	//    {
	//        // Tasvieh
	//        //if (!StudentJVSFull.Keys.Contains(student.StudentClassId))
	//        //{
	//        //    StudentJVSFull.Add(student.StudentClassId, jamPardakhtiShahrieh);
	//        //}
	//        return 0;
	//    }

	//    return -1;
	//}
	[Inject] IDialogService DialogService { get; set; }
	async void ShowClass(ShokouhPardisTimeTable selectedTimeTable)
	{
            
		Students = GetReport(selectedTimeTable);
		_jvs = DataProvider.GetDailyJvsByTerm(SelectedTerm.TermClassId);
		var dialogReference = await DialogService.ShowAsync<DjvShowDetailsDialog>(
			"نمایش", new DialogParameters()
			{
				["_jvs"] = _jvs,
				["SelectedTerm"] = SelectedTerm,
				["Students"] = Students,
			}, new DialogOptions()
			{
				CloseButton = true,
				MaxWidth = MaxWidth.ExtraLarge,
				FullWidth = true
			});
            
            

	}
}