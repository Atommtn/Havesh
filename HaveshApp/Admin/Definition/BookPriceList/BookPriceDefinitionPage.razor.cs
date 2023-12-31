using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;
using Havesh.Application.Services;

namespace HaveshApp.Admin.Definition.BookPriceList;

public partial class BookPriceDefinitionPage
{
	[Inject] DataProviderService DataProvider { get; set; }
	[Inject] IDialogService DialogService { get; set; }
	[Inject] ISnackbar Snackbar { get; set; }
	private ShokouhPardisLevelBookPrice levelPrice;
	List<ShokouhPardisLevelBookPrice>? levelBookPriceList = null;
	MudTable<ShokouhPardisLevelBookPrice>? table;
	private List<ShokouhPardisLevelClass>? _emptyBookPriceTustion;
	ShokouhPardisTermClass _selectedTerm;
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
            
		levelBookPriceList= DataProvider.GetAllLevelBookPriceByTerm(SelectedTerm);
		_emptyBookPriceTustion = _dataProvider.GetlevelBookNOPriceList(SelectedTerm);
	}

	async Task NewDaySessionClick()
	{
		levelPrice = ShokouhPardisLevelBookPrice.CreateLevelPrices();
		levelPrice.TermId = SelectedTerm.Id;
            
		await EditButtonClick(levelPrice);
	}

	async Task EditButtonClick(ShokouhPardisLevelBookPrice levelPrice, ShokouhPardisLevelClass level=null)
	{
		await OpenNewDaySessionDialog(levelPrice,level);
	}

	async Task OpenNewDaySessionDialog(ShokouhPardisLevelBookPrice levelPrice, ShokouhPardisLevelClass level = null)
	{
		var dialogReference = DialogService.Show<BookPriceDefinitionDialog>(
			(levelPrice.Id> 0 ? "ویرایش " : "جدید ") + "قیمت ",
			new DialogParameters
			{
				["LevelPrice"] = levelPrice,
				["SelectedTerm"] = SelectedTerm,
				["LevelParam"]= level
			},
			new DialogOptions()
			{
				CloseButton = true,
				MaxWidth = MaxWidth.Large
			});
		var dialogResult = await dialogReference.Result;
		if (dialogResult.Cancelled == false)
		{
			var retData = (ShokouhPardisLevelBookPrice)dialogResult.Data;
			if (levelPrice.Id == 0)
			{
				//New dialoge
				var result = DataProvider.SaveEditLevelBookPrice(retData, SelectedTerm);
				if (result)
				{
					var parameters = new DialogParameters();

					bool? result1 = await DialogService.ShowMessageBox(
						"خطا",
						(MarkupString)
						@$"برای این سطح قبلا قیمت ذخیره شده است!
                        <br/>{retData.Level.LevelName}",
						yesText: "متوجه شدم!");
				}
				else
				{
					Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
					Log.Warning("User {UserName} Save LevelBookPrice {LevelBookPriceId}", _userSession.Payload.UserName, retData.Id);
				}

			}
			else
			{
				//edit dialoge
				DataProvider.UpdateEditLevelBookPrice(retData, SelectedTerm);
				Log.Warning("User {UserName} Update LevelBookPrice {LevelBookPriceId}", _userSession.Payload.UserName, retData.Id);
				Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);

			}

			RefreshData();
			StateHasChanged();
		}
	}

	private async Task EditLevelPriceClick(ShokouhPardisLevelClass level)
	{
		levelPrice = ShokouhPardisLevelBookPrice.CreateLevelPrices();
		levelPrice.TermId = SelectedTerm.Id;
		levelPrice.LevelId = level.Id;
		await EditButtonClick(levelPrice,level);
	}

	private TableGroupDefinition<ShokouhPardisLevelBookPrice> _groupDefinition = new()
	{
		GroupName = "Group",
		Indentation = false,
		Expandable = true,
		IsInitiallyExpanded = false,
		Selector = (e) => e.Level.Grouping
	};
}