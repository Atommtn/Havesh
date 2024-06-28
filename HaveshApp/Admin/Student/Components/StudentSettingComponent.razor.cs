using System.Globalization;
using Havesh.Model.Model;
using Havesh.Application.Services;
using Havesh.Domain.Services;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using YamlDotNet.Core.Tokens;

namespace HaveshApp.Admin.Student.Components;

public partial class StudentSettingComponent
{
	private bool _showAmountValue;
    private ShokouhPardisTimeTableStudent? _timeTableStudent;

    [Parameter]
    public ShokouhPardisTimeTableStudent? TimeTableStudent
    {
        get => _timeTableStudent;
        set
        {
            _timeTableStudent = value;

            if (_timeTableStudent != null) Price = _dataProvider.GetLevelBookPrice(_timeTableStudent.TimeTable);
        }
    }

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

    
    private void SetAmount()
    {

        if (Price != null)
            TimeTableStudent.StudentAmountDiscount =
                (Price.TuitionAmount * TimeTableStudent.StudentPercentDiscount) / 100;
    }
    private void SetPercent()
    {
        Price = _dataProvider.GetLevelBookPrice(TimeTableStudent.TimeTable.TermId,
            TimeTableStudent.TimeTable.LevelId);

        TimeTableStudent.StudentPercentDiscount = (TimeTableStudent.StudentAmountDiscount * 100) / Price.TuitionAmount;
        StateHasChanged();
    }
}