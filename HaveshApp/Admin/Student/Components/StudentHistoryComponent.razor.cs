using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HaveshApp.Admin.Student.Components;

public partial class StudentHistoryComponent
{
	[Parameter]
	public bool ShowTutionPriceInDetailes { get; set; }

	[Parameter]
	public EventCallback<ShokouhPardisTermClass> OnTermChanged { get; set; }

	[Parameter]
	public ShokouhPardisStudentClass Student { get; set; }

	[Parameter]
	public ShokouhPardisTermClass CurrentTerm { get; set; }

	public List<ShokouhPardisTimeTable> studentHisory { get; set; }


	private MudTable<ShokouhPardisTimeTable> _studentTables;
	protected override void OnInitialized()
	{
		studentHisory = _dataProvider.GetStudentHistory(Student);
		base.OnInitialized();
	}

	private void RaiseOnTermChangedClick(ShokouhPardisTermClass term)
	{
		OnTermChanged.InvokeAsync(term);
	}

	private string RowClassFunc(ShokouhPardisTimeTable timeTable, int rowNumber)
	{
		return CurrentTerm.Id == timeTable.TermId ? "selected" : string.Empty;
	}

	private void RowDetaileClick(ShokouhPardisTimeTable timeTable)
	{
		timeTable.Selected = !timeTable.Selected;
	}

	[Parameter] public bool Detailed { get; set; } = true;

}