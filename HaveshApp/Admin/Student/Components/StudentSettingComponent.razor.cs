using System.Globalization;
using Havesh.Model.Model;
using Havesh.Application.Services;
using Havesh.Domain.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HaveshApp.Admin.Student.Components;

public partial class StudentSettingComponent
{
	private bool _showAmountValue;

	[Parameter]
	public ShokouhPardisTimeTableStudent? TimeTableStudent { get; set; }

	[Parameter]
	public RenderFragment NoContent { get; set; }

	[Parameter]
	public RenderFragment ChildContent { get; set; }

	[Inject]
	public IDialogService DialogService { get; set; }


	[Inject] public StudentService StudentService { get; set; }
	private ShokouhPardisLevelBookPrice? Price { get; set; }
	CultureInfo GetPersianCulture()
	{
		var culture = new CultureInfo("fa-IR");
		return culture;
	}

	private void SaveClick()
	{
           
	}

     

	public bool ShowAmountValue
	{
		get => _showAmountValue;
		set
		{
			_showAmountValue = value;
                
		}
	}

	private void SetPercent()
	{
		Price = _dataProvider.GetLevelBookPrice(TimeTableStudent.TimeTable.TermId,
			TimeTableStudent.TimeTable.LevelId);

		TimeTableStudent.StudentPercentDiscount = (TimeTableStudent.StudentAmountDiscount * 100) / Price.TuitionAmount;
		StateHasChanged();
	}
}