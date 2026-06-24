// فایل جدید: HaveshApp/Admin/Planning/LogEntityDialog.razor.cs
using Microsoft.AspNetCore.Components;
using Havesh.Application.Services;
using Havesh.Model.Model;
using MudBlazor;

namespace HaveshApp.Admin.Planning;

public partial class LogEntityDialog
{
	[CascadingParameter]
	public MudDialogInstance DialogInstance { get; set; }

	[Inject]
	public DataProviderService DataProvider { get; set; }

	[Parameter]
	public string EntityType { get; set; }

	[Parameter]
	public int EntityId { get; set; }

	public bool Loading { get; set; } = true;
	public ShokouhPardisDailyJv Jv { get; set; }
	public ShokouhPardisStudentClass Student { get; set; }

	protected override void OnInitialized()
	{
		switch (EntityType)
		{
			case "DailyJv":
			case "PreRegistration":
				Jv = DataProvider.GetDailyJv(EntityId);
				break;
			case "Student":
				Student = DataProvider.GetStudent(EntityId);
				break;
		}

		Loading = false;
	}

	private void CloseDialogClick()
	{
		DialogInstance.Close();
	}
}
