using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Rendering;
using MudBlazor;
using MudBlazor.Extensions;
using HaveshApp.Admin.Definition.Teachers;
using HaveshApp.Admin.Student;
using Havesh.Application.Services;
using System.ComponentModel;
using Havesh.GrainInterfaces.Common;
using Havesh.Model.Model;
using Serilog;
using static MudBlazor.CategoryTypes;
using HaveshApp.Admin.Authentication;
using HaveshApp.Classes;
//using Ins.Havesh.ReactiveUI.Blazor.Financial;
using Microsoft.Extensions.Caching.Memory;
using ReactiveUI;

namespace HaveshApp.Admin.DailyJV.Components;

public partial class DailyJvRecordListComponent
{
	//[Inject] public DailyJsRecordListViewModel ViewModel { get; set; }

	[Parameter]
	public ShokouhPardisStudentClass? Student { get; set; }
	[Parameter]
	public bool SearchTextDiasabled { get; set; }
    [Parameter]
    public bool ShowRecordId { get; set; }

    private ShokouhPardisTermClass _term;
	
    [Parameter]
	public ShokouhPardisTermClass? SelectedTerm
	{
		get => _term;
		set
		{
			if(_term == value) return;
			_term = value;
			table?.ReloadServerData();
			StateHasChanged();
		}
	}

	[Parameter]
	public DateTime? SelectedDate
	{
		get => _selectedDate;
		set
		{
			_selectedDate = value;
			table?.ReloadServerData();
			StateHasChanged();
		}
	}

    [Parameter]
    public EventCallback<DateTime?> SelectedDateChanged { get; set; }

    [Inject] IDialogService DialogService { get; set; }
	[Inject] ISnackbar Snackbar { get; set; }
        

	[Inject] DataProviderService DataProvider { get; set; }

	//ShokouhPardisDailyJv DailyJV;
	MudTable<ShokouhPardisDailyJv>? table;
	DateTime? _selectedDate;

	string? SearchText { get; set; } = null;
	public ShokouhPardisDailyJv dJvTemp { get; private set; }

	private CacheManager _cacheManager = new(new MemoryCache(new MemoryCacheOptions()));
	async Task<TableData<ShokouhPardisDailyJv>> ServerReload(TableState state)
	{
		int total;
		List<ShokouhPardisDailyJv> pagedJvs;

		return _cacheManager.GetOrSet($"jv-{Student?.Id}-{SelectedDate?.ToString("M/d/yy")}-{SearchText}-{SelectedTerm?.Id}" , () =>
			{
				if (Student is null)
				{
					total = DataProvider.GetTotalDailyJv(SelectedDate);
					pagedJvs = DataProvider
						.GetPagedJvs(state.Page, state.PageSize, SelectedDate, SearchText);
				}
				else
				{
					total = DataProvider.GetTotalDailyJv(Student.Id, SelectedTerm.Id);
					pagedJvs = DataProvider
						.GetPagedJvs(state.Page, state.PageSize, Student.Id, SelectedTerm.Id, SearchText);
				}


				return new TableData<ShokouhPardisDailyJv>()
				{
					TotalItems = total,
					Items = pagedJvs
				};

			}
			, TimeSpan.FromMinutes(2));


	}
	private TableGroupDefinition<ShokouhPardisDailyJv> _groupDefinition = new()
	{
		GroupName = "نحوه پرداخت",
		Indentation = false,
		Expandable = true,
		IsInitiallyExpanded = true,
		Selector = (e) => e.PaymentType
	};
	public async Task FilterData()
	{
		await table?.ReloadServerData();
	}

	private async Task EditDailyJVClick(ShokouhPardisDailyJv dailyJv)
	{

		//await OpenEditDJVDialog(dailyJv);
		await EditDailyJvDialog(dailyJv);
	}


	private void BackupItem(object dJv)
	{
		dJvTemp = new ShokouhPardisDailyJv()
		{
			Student = ((ShokouhPardisDailyJv)dJv).Student,
			CurrentDate = ((ShokouhPardisDailyJv)dJv).CurrentDate,
			Term= ((ShokouhPardisDailyJv)dJv).Term,
			DailyJvguid= ((ShokouhPardisDailyJv)dJv).DailyJvguid,
			Fee= ((ShokouhPardisDailyJv)dJv).Fee,
			PaymentType= ((ShokouhPardisDailyJv)dJv).PaymentType,
			JvFromSiteFk = ((ShokouhPardisDailyJv)dJv).JvFromSiteFk,
			BillNo= ((ShokouhPardisDailyJv)dJv).BillNo,
			CardPostfix= ((ShokouhPardisDailyJv)dJv).CardPostfix,
			Id= ((ShokouhPardisDailyJv)dJv).Id,
			DailyJvlastModified= ((ShokouhPardisDailyJv)dJv).DailyJvlastModified,
			DateOfSettle= ((ShokouhPardisDailyJv)dJv).DateOfSettle,
			Description= ((ShokouhPardisDailyJv)dJv).Description,
			FeeFor= ((ShokouhPardisDailyJv)dJv).FeeFor,
			PosCode= ((ShokouhPardisDailyJv)dJv).PosCode,
			StudentId= ((ShokouhPardisDailyJv)dJv).StudentId,
			TermId= ((ShokouhPardisDailyJv)dJv).TermId,
			Txcode= ((ShokouhPardisDailyJv)dJv).Txcode

		};
         
	}
	private void ResetItemToOriginalValues(object dJv)
	{
		((ShokouhPardisDailyJv)dJv).Student = dJvTemp.Student;
		((ShokouhPardisDailyJv)dJv).CurrentDate= dJvTemp.CurrentDate;
		((ShokouhPardisDailyJv)dJv).Term= dJvTemp.Term;
		((ShokouhPardisDailyJv)dJv).DailyJvguid= dJvTemp.DailyJvguid;
		((ShokouhPardisDailyJv)dJv).Fee= dJvTemp.Fee;
		((ShokouhPardisDailyJv)dJv).PaymentType= dJvTemp.PaymentType;
		((ShokouhPardisDailyJv)dJv).JvFromSiteFk= dJvTemp.JvFromSiteFk;
		((ShokouhPardisDailyJv)dJv).BillNo= dJvTemp.BillNo;
		((ShokouhPardisDailyJv)dJv).CardPostfix= dJvTemp.CardPostfix;
		((ShokouhPardisDailyJv)dJv).Id= dJvTemp.Id;
		((ShokouhPardisDailyJv)dJv).DailyJvlastModified= dJvTemp.DailyJvlastModified;
		((ShokouhPardisDailyJv)dJv).DateOfSettle = dJvTemp.DateOfSettle;
		((ShokouhPardisDailyJv)dJv).Description= dJvTemp.Description;
		((ShokouhPardisDailyJv)dJv).FeeFor= dJvTemp.FeeFor;
		((ShokouhPardisDailyJv)dJv).PosCode= dJvTemp.PosCode;
		((ShokouhPardisDailyJv)dJv).StudentId= dJvTemp.StudentId;
		((ShokouhPardisDailyJv)dJv).TermId= dJvTemp.TermId;
		((ShokouhPardisDailyJv)dJv).Txcode= dJvTemp.Txcode;
	}

	async Task EditDailyJvDialog(ShokouhPardisDailyJv dailyJv)
	{
                
		var dialogReference = await DialogService.ShowAsync<DailyJVEditDialog>(
			"ویرایش", new DialogParameters()
			{
				["DailyJv"] = dailyJv,
			} , new DialogOptions()
			{
				CloseButton = true,
				MaxWidth = MaxWidth.ExtraLarge,
				FullWidth = true
			});
		//dialog.DailyJv = dailyJv;
		var dialogResult = await dialogReference.Result;
		if (!dialogResult.Canceled)
		{
			var retData = (ShokouhPardisDailyJv)dialogResult.Data;
			try
			{
				DataProvider.SaveEditDailyJV(retData);
				Log.Warning("User {UserName} Update DailyJv {DailyJv}", _userSession.Payload.UserName,retData.Id);
				Snackbar.Add("با موفقیت بروزرسانی گردید.", Severity.Success);

			}
			catch (Exception e)
			{
				Snackbar.Add(e.Message, Severity.Warning);

			}
		}
            
		StateHasChanged();
		table?.ReloadServerData();
            
	}

	private async Task DeleteDailyJVClick(ShokouhPardisDailyJv dJv)
	{
		var result = await DialogService.ShowMessageBox("حذف رسید پرداخت", "آیا از حذف این اطلاعات مطمئن هستید؟", "بله", "خیر");


		if (result is true)
		{
			var ispreRegister = DataProvider.DeleteDailyJV(dJv);
			if (ispreRegister)
			{
				Snackbar.Add("پیش ثبت نام با این حذف این ثبت حذف شد", Severity.Warning);
			}

			Snackbar.Add("با موفقیت حذف گردید.", Severity.Success);
			Log.Warning("User {UserName} Delete DailyJv {DailyJvid}", _userSession.Payload.UserName,dJv.Id);
			await FilterData();

		}
	}

	[Inject]
	BrowserService BrowserService { get; set; }

	async Task PrintDailyJvPrintClick(ShokouhPardisDailyJv shokouhPardisDailyJv)
	{
		await BrowserService.OpenInNewTabAsync($"/BillPrint/{shokouhPardisDailyJv.Id}");
	}
}