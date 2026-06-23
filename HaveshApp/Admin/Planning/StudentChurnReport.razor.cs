using Microsoft.AspNetCore.Components;
using MudBlazor;
using Havesh.Application.Services;
using Havesh.Model.Model;
using System.Linq;
using System.Collections.Generic;

namespace HaveshApp.Admin.Planning;

public partial class StudentChurnReport
{
	[Inject]
	public DataProviderService DataProvider { get; set; }

	[Inject]
	public NavigationManager Navigation { get; set; }

	private ShokouhPardisTermClass _selectedTerm;
	public ShokouhPardisTermClass SelectedTerm
	{
		get => _selectedTerm;
		set
		{
			if (_selectedTerm == value) return;
			_selectedTerm = value;
			Results = null;
		}
	}

	public string ReportTitle { get; set; }
	public List<(ShokouhPardisStudentClass Student, ShokouhPardisTermClass Term)> Results { get; set; }

	void ShowDroppedStudents()
	{
		if (SelectedTerm == null) return;
		ReportTitle = $"زبان‌آموزانی که در ترم‌های قبل بودن ولی در «{SelectedTerm.TermName}» ثبت‌نام نشدن";
		Results = DataProvider.GetDroppedStudents(SelectedTerm);
	}

	void ShowLevelWithoutClass()
	{
		ReportTitle = "زبان‌آموزانی که تعیین سطح شدن ولی هنوز در هیچ کلاسی ثبت‌نام نشدن";
		Results = DataProvider.GetLevelDeterminedWithoutClass();
	}

	void StudentProfileClick(ShokouhPardisStudentClass student)
	{
		Navigation.NavigateTo("/StudentInfo/" + student.StudentClassGuid.ToString("N"));
	}
}
