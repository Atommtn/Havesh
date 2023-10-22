using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HaveshApp.Admin.Student.Components;

public partial class StudentHistoryComponent
{
	[Parameter]
	public ShokouhPardisStudentClass Student { get; set; }

	public List<ShokouhPardisTimeTable> studentHisory { get; set; }


	private MudTable<ShokouhPardisTimeTable> _studentTables;
	protected override void OnInitialized()
	{
		studentHisory = _dataProvider.GetStudentHistory(Student);
		base.OnInitialized();
	}
}