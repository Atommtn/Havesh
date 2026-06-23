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

	[Inject]
	public ISnackbar Snackbar { get; set; }

	[Inject]
	public PageStateCacheService PageState { get; set; }

	private const string CacheKey = "StudentChurnReport";

	private class ChurnReportState
	{
		public ShokouhPardisTermClass SelectedTerm { get; set; }
		public string ReportTitle { get; set; }
		public List<(ShokouhPardisStudentClass Student, ShokouhPardisTermClass Term)> Results { get; set; }
	}

	private ShokouhPardisTermClass _selectedTerm;
	public ShokouhPardisTermClass SelectedTerm
	{
		get => _selectedTerm;
		set
		{
			if (_selectedTerm == value) return;
			_selectedTerm = value;
			Results = null;
			SaveState();
		}
	}

	public string ReportTitle { get; set; }
	public List<(ShokouhPardisStudentClass Student, ShokouhPardisTermClass Term)> Results { get; set; }

	protected override void OnInitialized()
	{
		if (PageState.TryGet<ChurnReportState>(CacheKey, out var state))
		{
			// مستقیم فیلد پشتیبان رو ست می‌کنیم نه پراپرتی، چون ست‌کردن از طریق
			// پراپرتی SelectedTerm نتایج (Results) رو پاک می‌کرد.
			_selectedTerm = state.SelectedTerm;
			ReportTitle = state.ReportTitle;
			Results = state.Results;
		}
	}

	private void SaveState()
	{
		PageState.Set(CacheKey, new ChurnReportState
		{
			SelectedTerm = SelectedTerm,
			ReportTitle = ReportTitle,
			Results = Results
		});
	}

	void ShowDroppedStudents()
	{
		if (SelectedTerm == null) return;

		if (SelectedTerm.LastTermFk == null)
		{
			Snackbar.Add("این ترم به ترم قبلی لینک نشده (در تعریف ترم، فیلد «ترم قبلی» خالیه)", Severity.Warning);
			Results = null;
			SaveState();
			return;
		}

		ReportTitle = $"زبان‌آموزانی که در ترم قبل بودن ولی در «{SelectedTerm.TermName}» ثبت‌نام نشدن";
		Results = DataProvider.GetDroppedStudents(SelectedTerm);
		SaveState();
	}

	void ShowLevelWithoutClass()
	{
		ReportTitle = "زبان‌آموزانی که تعیین سطح شدن ولی هنوز در هیچ کلاسی ثبت‌نام نشدن";
		Results = DataProvider.GetLevelDeterminedWithoutClass();
		SaveState();
	}

	void StudentProfileClick(ShokouhPardisStudentClass student)
	{
		SaveState();
		Navigation.NavigateTo("/StudentInfo/" + student.StudentClassGuid.ToString("N"));
	}
}
