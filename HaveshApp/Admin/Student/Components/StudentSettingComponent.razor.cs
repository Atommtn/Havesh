using System.Globalization;
using Havesh.Model.Model;
using Havesh.Application.Services;
using Havesh.Domain.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HaveshApp.Admin.Student.Components;

public partial class StudentSettingComponent
{
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

     

	public bool ShowAmountValue { get; set; }

	private void SetPercent()
	{
		if (TimeTableStudent == null)
		{
			_snackBar.Add("این زبان آموز در این ترم در تایم تیبل رکوردی ندارد"  ,  Severity.Error);
			return;
		}

		Price = _dataProvider.GetLevelBookPrice(TimeTableStudent.TimeTable.TermId,
			TimeTableStudent.TimeTable.LevelId);

        if (Price != null)
            TimeTableStudent.StudentPercentDiscount =
                (TimeTableStudent.StudentAmountDiscount * 100) / Price.TuitionAmount;
        StateHasChanged();
	}

    private void SetAmount()
    {

        if (Price != null)
            TimeTableStudent.StudentAmountDiscount =
                (Price.TuitionAmount * TimeTableStudent.StudentPercentDiscount)/100 ;
    }
}