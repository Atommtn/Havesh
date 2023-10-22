using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using HaveshApp.Admin.Student;
using HaveshApp.Services;
using System.Globalization;
using System.Linq;
using HaveshApp.Admin.Components;
using static MudBlazor.CategoryTypes;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;
using System.Xml;
using Amazon.Util;
using Havesh.Model.Model;
using Serilog;
using HaveshApp.Admin.Authentication;
using HaveshApp.Admin.DailyJV.Components;
using HaveshApp.Classes;
using MudBlazor.Charts.SVG.Models;

namespace HaveshApp.Admin.DailyJV;

public partial class PreRegistrationPage
{
	private ShokouhPardisStudentClass Student { get; set; } = new();
	private bool ShowStudent { get; set; } = false;
	public bool StudentsListComponentShow { get; set; } = true;
	public ShokouhPardisTimeTable? FindStudentLastTimeTable { get; set; }
	public bool PreRegisterShow { get; set; } = false;
	ShokouhPardisDailyJv _dailyJV;
	PreRegistration preRegistration;
	public TimeSpan? ts { get; set; }
	public ShokouhPardisTermClass? NextTerm { get; set; }
	public ShokouhPardisTermClass CurrentTerm { get; set; }
	private ShokouhPardisLevelClass _nextLevel;
	private ShokouhPardisLevelBookPrice? _price;
	ShokouhPardisLevelClass? NextLevel
	{
		get => _nextLevel;
		set
		{
			_nextLevel = value;
			//_dailyJV.PaymentType = null;

			if (_nextLevel != null)
				_price = _dataProvider.GetLevelBookPrice(NextTerm.TermClassId, _nextLevel.LevelClassId);
		}
	}

	public string? FeeFor
	{
		get => _dailyJV.FeeFor;
		set
		{
			_dailyJV.FeeFor = value;
			if (_dailyJV.FeeFor == null)
				return;

			int? x = 0;
			if (_dailyJV.FeeFor.Contains("شهریه"))
			{
				x = _price.TuitionAmount;
			}

			if (_dailyJV.FeeFor.Contains("کتاب"))
			{

				x += _price.BookPrice;
			}
			_dailyJV.Fee = (int)x;
		}
	}
	private async Task<Task> OnSelectStudentAction(List<ShokouhPardisStudentClass> arg)
	{

		ShowStudent = true;
		Student = arg.First();
		NextTerm = _dataProvider.GetTermsInRangeToday();
		FindStudentLastTimeTable = _dataProvider.FindStudentLastTimeTable(Student,30);
		if (FindStudentLastTimeTable == null)
		{
			CurrentTerm = _dataProvider.GetTermsbyTermId(30);
		}
		else
		{
			CurrentTerm = FindStudentLastTimeTable.Term;
		}
		_dailyJV = ShokouhPardisDailyJv.CreateNewDailyJV();
		_dailyJV.CurrentDate = _userSession.LastJvDate;
		if (FindStudentLastTimeTable is null)
		{
			_snackBar.Add(arg.First().FullName + "در هیچ کلاسی تا بحال شرکت نکرده سیستم قادر به تعیین سطح نمی باشد", severity: Severity.Error);

			var dialogref = await _dialogService.ShowAsync<PreRegistrationSelectLevelDialog>("انتخاب سطح مورد نظر پیش ثبت نام", new DialogParameters()
			{
				["SelectedLevel"] = NextLevel
                    
			}, new DialogOptions()
			{
				FullWidth = true,
				MaxWidth = MaxWidth.Large
			});
			var result = await dialogref.Result;
			if (!result.Canceled)
			{
				NextLevel = result.Data as ShokouhPardisLevelClass;

				_snackBar.Add("سطح مورد نظر با موفقیت انتخاب شد.", Severity.Success);
			}
			else
			{
				return Task.CompletedTask;
			}
                
		}
         
		if (NextLevel is null)
		{
			NextLevel = _dataProvider.FindNextLevel(FindStudentLastTimeTable);
		}
            
		//PreRegisterShow = false;
		StudentsListComponentShow = false;
		_dailyJV.FeeFor = FeeForStatuses.TuitionAmount;
            
		_dailyJV.PaymentType = PaymentTypeStatuses.Pos;
		if (_price is null)
		{
			_dailyJV.Fee = 0;
			_snackBar.Add("برای این سطح قیمتی مشخص نشده", Severity.Warning);
		}
		else
		{
			_dailyJV.Fee = _price.TuitionAmount;
		}
            
		StateHasChanged();

		return Task.CompletedTask;
	}

        


     
	private void PreRegister()
	{

		PreRegisterShow = true;
  
		StateHasChanged();
	}
	CultureInfo GetPersianCulture()
	{
		var culture = new CultureInfo("fa-IR");
		return culture;
	}




	void SetDay(int i)
	{
		if (_dailyJV.CurrentDate == DateTime.Today && i == 1)
		{
			return;
		}
		else
		{
			_dailyJV.CurrentDate = _dailyJV.CurrentDate?.AddDays(i);
			StateHasChanged();

		}

	}

	async Task SaveClick()
	{
         
          
          

		try
		{
			_dailyJV.TermId = NextTerm.TermClassId;
			_dailyJV.TimeTableFk = null;
			//_dailyJV.Student = Student;
			_dailyJV.BillNo = _dailyJV.DailyJvid;
			_dailyJV.StudentId = Student.StudentClassId;
			_dailyJV.DateOfSettle += ts;
			_dailyJV.IsPreRegister = true;
			_dataProvider.SaveDailyJV(_dailyJV);
			_userSession.LastJvDate = _dailyJV.CurrentDate;
			_snackBar.Add("اطلاعات با موفقیت ذخیره شد", MudBlazor.Severity.Success);
			Log.Warning("User {UserName} Create DailyJV For PreRegistration '{DailyJvid}'.", _userSession.Payload?.UserName, _dailyJV.DailyJvid);
			////// reset page
			///
			/// save preregistratin
			/// 
			preRegistration = PreRegistration.CreatePreRegistration();
			preRegistration.Level = NextLevel;
			preRegistration.Term = NextTerm;
			preRegistration.Student = Student;
			preRegistration.DailyJV = _dailyJV;
			_dataProvider.SavePreRegistration(preRegistration);
			_snackBar.Add("اطلاعات پیش ثبت نام با موفقیت ذخیره شد", MudBlazor.Severity.Success);
			Log.Warning("User {UserName} Create PreRegistration For student '{StudentID}' dailyJV '{DailyJvid}'  .", _userSession.Payload?.UserName, _dailyJV.DailyJvid , Student.StudentClassId);
			RestForm();
			StateHasChanged();
			await PrintDailyJvFishClick();
		}
		catch (Exception e)
		{
			_snackBar.Add(e.Message, Severity.Error);
		}
		// Navigation.NavigateTo("/prereg");
	}
	[Inject] Navigation Navigation { get; set; }
	private void RestForm()
	{
		ShowStudent = false;
		PreRegisterShow = false;
		StudentsListComponentShow = true;
		NextLevel = null;
		StateHasChanged();
	}

	[Inject]
	public BrowserService BrowserService { get; set; }

	async Task PrintDailyJvFishClick()
	{
		await BrowserService.OpenInNewTabAsync($"/BillPrint/{_dailyJV.DailyJvid}");
	}
}