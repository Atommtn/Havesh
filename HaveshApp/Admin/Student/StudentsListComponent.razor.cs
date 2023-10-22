using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using HaveshApp.Services;
using Serilog;
using HaveshApp.Admin.Authentication;


namespace HaveshApp.Admin.Student;

public partial class StudentsListComponent
{
	[Inject] public StudentService StudentService { get; set; }
	MudTable<ShokouhPardisStudentClass>? table;
	string? SearchText { get; set; } = null;

	[Parameter]
	public ShokouhPardisTermClass? Term
	{
		get => _term;
		set
		{
			_term = value;
			ReloadData().Wait();
		}
	}

	[Parameter] public ShokouhPardisTimeTable? TimeTable { get; set; }
	[Parameter] public ShokouhPardisTimeTable? PreTT { get; set; }

	[Parameter] public int Height { get; set; } 
	[Parameter] public bool StudentDetail { get; set; } = true;
	[Parameter] public bool AddNewStudent { get; set; } = true;
	[Parameter] public bool? ShowPreRigester { get; set; } = false;

	public bool ShowPreRigesterItem
	{
		get => _showPreRigesterItem;
		set
		{
			_showPreRigesterItem = value;
			FilterData();
		}
	}

	[Parameter]
	public RenderFragment<ShokouhPardisStudentClass>? ChildContent { get; set; }
	[Parameter] public bool FullHeight { get; set; } = true;
	[Parameter] public bool AllowEdit { get; set; }
	[Parameter] public bool AllowDelete { get; set; }
	[Parameter] public bool SingleSelect { get; set; }
	[Parameter] public bool MultiSelect { get; set; }
	[Parameter] public bool RowStyle { get; set; }
	[Parameter] public int RowPage { get; set; } = 60;
	[Parameter] public Func<StudentActionArgs, Task>? OnEditStudentAction { get; set; }
	[Parameter] public Func<StudentActionArgs, Task<bool>>? OnDeleteStudentAction { get; set; }
	[Parameter] public Func<List<ShokouhPardisStudentClass>, Task>? OnSelectStudentAction { get; set; }
	[Inject] IDialogService DialogService { get; set; }
	[Inject] DataProviderService DataProvider { get; set; }
	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object> AdditionalAttributes { get; set; }

	public bool HasnotIdNo
	{
		get => _hasnotIdNo;
		set
		{
			_hasnotIdNo = value;
			FilterData();
		}
	}

	MudTextField<string?>? SearchTextField { get; set; }

	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		await SearchTextField.FocusAsync();
		await base.OnAfterRenderAsync(firstRender);
	}

	async Task<TableData<ShokouhPardisStudentClass>> ServerReload(TableState state)
	{
		List<int?>? studentIds = null;
		var total = 0;
		List<ShokouhPardisStudentClass> pagedStudents = null;
		if (ShowPreRigesterItem is true && PreTT is not null)
		{
			if (PreTT is null)
			{
				throw new Exception("تایم تیبل را مشخص نکردید");
			}
			total = StudentService.GetTotalPreRegisterStudentCount(PreTT);
			pagedStudents = StudentService.GetPreRegisterStudentPaged(state.Page, state.PageSize, SearchText, PreTT);
		}
		else if (TimeTable is not null)
		{
			total = StudentService.GetStudentsInTimeTableCount(TimeTable);
			pagedStudents = StudentService.GetStudentsInTimeTablePaged(TimeTable, state.Page, state.PageSize, SearchText);
		}
		else if (Term is not null)
		{
			total = StudentService.GetStudentsInTermCount(Term,SearchText, HasnotIdNo);
			pagedStudents = StudentService.GetStudentsInTermPaged(Term, state.Page, state.PageSize, SearchText, HasnotIdNo);
		}
            
		else
		{
			total = StudentService.GetTotalStudentCount(studentIds);
			pagedStudents = StudentService.GetStudentPaged(state.Page, state.PageSize, SearchText,studentIds);
		}

            
		return new TableData<ShokouhPardisStudentClass>()
		{
			TotalItems = total,
			Items = pagedStudents

		};
	}

	void CommitEdit(object obj)
	{
		var student = (ShokouhPardisStudentClass)obj;
		StudentService.SaveStudent(student);
	}

	async Task FilterData()
	{
		await ReloadData();
	}

	public async Task ReloadTableServerData()
	{
		await FilterData();

	}

	void EditStudentClick(ShokouhPardisStudentClass context)
	{
		var arg = new StudentActionArgs()
		{
			Student = context
		};
		OnEditStudentAction?.Invoke(arg);
	}

	async Task DeleteStudentClick(ShokouhPardisStudentClass student)
	{

		if (OnDeleteStudentAction is { })
		{
			var arg = new StudentActionArgs()
			{
				Student = student,
				TimeTable = TimeTable
			};

			var deleted = await OnDeleteStudentAction(arg);
			if (deleted)
				await ReloadData();
		}
	}

	void SelectStudentClick(ShokouhPardisStudentClass student)
	{
		OnSelectStudentAction?.Invoke(new List<ShokouhPardisStudentClass>() { student });
	}

	void SelectCompleteMultiClick()
	{
		selectedStudents.ForEach(x => x.IsSelect = false);
		OnSelectStudentAction?.Invoke(selectedStudents);
	}

	public async Task ReloadData()
	{
		if(table != null)
			await table.ReloadServerData();

	}


	async Task AddStudent()
	{
		var newStudent = ShokouhPardisStudentClass.CreatenewStudent();

		await StudentDialogButton(newStudent);
	}

	async Task StudentDialogButton(ShokouhPardisStudentClass context)
	{
		var dialogReference = DialogService.Show<AddNewStudentDialog>(
			" زبان آموز - " + (context.StudentClassId > 0 ? "ویرایش" : "جدید") ,
			new DialogParameters
			{
				["Student"] = context
			},
			new DialogOptions()
			{
				CloseButton = true,
				MaxWidth = MaxWidth.Large
			});
		var dialogResult = await dialogReference.Result;
		if (dialogResult.Cancelled == false)
		{
			var NewStudetent = (ShokouhPardisStudentClass)dialogResult.Data;
			StudentService.SaveStudent(NewStudetent);
			Log.Warning("User {UserName} Save Student {StudentId}", _userSession.Payload.UserName, NewStudetent.StudentClassId);
			await ReloadTableServerData();
			StateHasChanged();
		}
	}

	List<ShokouhPardisStudentClass> selectedStudents = new List<ShokouhPardisStudentClass>();
	ShokouhPardisTermClass? _term;
	private bool _showPreRigesterItem = true;
	private bool _hasnotIdNo = false;

	void ItemChanged()
	{
            
	}

	void SelectStudentToListClick(ShokouhPardisStudentClass student)
	{
		if (student.IsSelect)
		{
			selectedStudents.Remove(student);
			student.IsSelect = false;
		}
		else
		{
			selectedStudents.Add(student);
			student.IsSelect = true;
		}
	}

	[Inject] Navigation Navigation { get; set; }
        


	void StudentProfileClick(ShokouhPardisStudentClass student)
	{
		Navigation.NavigateTo("/StudentInfo/" + student.StudentClassGuid.ToString("N"));
	}
	private string RowStyleFunc(ShokouhPardisStudentClass student, int index)
	{
		if (!RowStyle)
		{return "background-color:rgba(79, 79, 79, 0.5);"; }
		var TTStdLevel = DataProvider.GetStudetnLevel(student, TimeTable.Term);
		var shahriehDarInTerm = DataProvider.GetLevelBookPrice(TimeTable.TermId, TTStdLevel.Level.LevelClassId);
		//var list = DataProvider.GetDailyJvBy(SelectedTerm.TermClassId, student.StudentClassId);
		var list = DataProvider.GetDailyJvsByTimeTable(TimeTable,student);


		int jamPardakhtiShahrieh = list.Where(x => x.FeeFor.Equals("شهریه")).Sum(x => x.Fee);
		int tedadjamPardakhtiShahrieh = list.Count(x => x.FeeFor.Equals("شهریه"));
		var jamPardakhtiKetab = list.Where(x => x.FeeFor.Equals("کتاب")).Sum(x => x.Fee);

		if (tedadjamPardakhtiShahrieh == 0)
		{
			// عدم پرداخت قرمز
			return "background-color:rgba(255, 0, 4, 0.5);";
		}

		if (jamPardakhtiShahrieh < shahriehDarInTerm.TuitionAmount)
		{
			// Bedehkar نارنجی
			return "background-color:rgba(243, 143, 12, 0.5);";
		}

		if (jamPardakhtiShahrieh > shahriehDarInTerm.TuitionAmount)
		{
			// Bestankar سفید
			return "background-color:rgba(255, 255, 255, 0.5);";
		}
		if (jamPardakhtiShahrieh == shahriehDarInTerm.TuitionAmount)
		{
			// Tasvieh سبز
			//if (!StudentJVSFull.Keys.Contains(student.StudentClassId))
			//{
			//    StudentJVSFull.Add(student.StudentClassId, jamPardakhtiShahrieh);
			//}
			return "background-color:rgba(0, 255, 21, 0.5);";
		}
		//طوسی
		return "background-color:rgba(79, 79, 79, 0.5);";
		//switch (_jvs.Any(x=>x.StudentId == TTstudents.Student.StudentClassId && x.TermId == SelectedTerm.TermClassId))
		//{
		//    case true:
		//        return "background-color:rgba(34, 177, 76, 0.2);";
		//    case false:
		//        return "background-color:rgba(247, 32, 32, 0.2);";
		//    default: return "background-color:white";

		//}
	}
}