using System.Globalization;
using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;
using HaveshApp.Services;

namespace HaveshApp.Admin.Student.Components;

public partial class StudentInfoComponent
{
	[Parameter]
	public bool? ShowRecordId { get; set; }

	[Parameter]
	public ShokouhPardisStudentClass? Student { get; set; }

	[Parameter]
	public RenderFragment NoContent { get; set; }

	[Parameter]
	public RenderFragment ChildContent { get; set; }

	[Inject]
	public IDialogService DialogService { get; set; }


	[Inject] public StudentService StudentService { get; set; }

	protected override void OnInitialized()
	{
		base.OnInitialized();
		var mt = new MudTextField<string>();
		mt.Disabled = true;
	}

	CultureInfo GetPersianCulture()
	{
		var culture = new CultureInfo("fa-IR");
		return culture;
	}


	private async Task EditStudentClick()
	{
		var dialogReference = await DialogService.ShowAsync<AddNewStudentDialog>(
			"ویرایش زبان آموز",
			new DialogParameters
			{
				["Student"] = Student
			},
			new DialogOptions()
			{
				CloseOnEscapeKey = false,
				CloseButton = false,
				DisableBackdropClick = true,
				MaxWidth = MaxWidth.Large
			});
		var dialogResult = await dialogReference.Result;
		if (dialogResult.Canceled == false)
		{
			var NewStudetent = (ShokouhPardisStudentClass)dialogResult.Data;
			StudentService.SaveStudent(NewStudetent);
			Log.Warning("User {UserName} Save Student {StudentId}", _userSession.Payload?.UserName, NewStudetent.StudentClassId);
			StateHasChanged();
		}
	}
}