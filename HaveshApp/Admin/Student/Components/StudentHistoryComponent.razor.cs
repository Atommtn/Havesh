using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HaveshApp.Admin.Student.Components;

public partial class StudentHistoryComponent
{

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
}