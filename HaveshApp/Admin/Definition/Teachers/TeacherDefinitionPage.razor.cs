using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using HaveshApp.Admin.MemberShip;
using Havesh.Application.Services;
using Olive;
using Log = Serilog.Log;

namespace HaveshApp.Admin.Definition.Teachers;

public partial class TeacherDefinitionPage
{
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

	[Inject] DataProviderService DataProviderService { get; set; }
	[Inject] IDialogService DialogService { get; set; }
	[Inject] ISnackbar Snackbar { get; set; }
	[Inject] DataProviderService DataProvider { get; set; }

	HashSet<ShokouhPardisTeacherClass>? SelectedTeachers { get; set; }
	HashSet<ShokouhPardisTeacherClass>? SelectedTeachersFromDB { get; set; }

	List<ShokouhPardisTeacherClass> Teachers;
	ShokouhPardisTermClass _selectedTerm;

	void RefreshData()
	{
		Teachers = DataProviderService.GetTeachers();
		SelectedTeachers = DataProviderService.GetTeachersInTerm(SelectedTerm);
	}

	void SaveClick()
	{
		if (SelectedTeachers != null)
		{
			// مشابه اقلام موجود در دیتابیس
			//var intersect = Teachers.Intersect(SelectedTeachers);
			var orig = DataProviderService.GetTeachersInTerm(SelectedTerm);

			// حذف شده ها
			var removed = orig.Except(SelectedTeachers).ToList();
			if(removed.Any())
				DataProvider.RemoveTeacherFromTerm(removed, SelectedTerm);


			// اضافه شده ها
			var added = SelectedTeachers.Except(orig).ToList();
			if (added.Any())
				DataProvider.AddTeacherToTerm(added, SelectedTerm);
		}
	}

	async Task NewTeacherClick()
	{
		var Teacher = ShokouhPardisTeacherClass.CreateTeacher();
		Teacher.TermId = SelectedTerm.Id;

		await EditButtonClick(Teacher);
	}

	async Task EditButtonClick(ShokouhPardisTeacherClass teacher)
	{
		await OpenNewTeacherDialog(teacher);
	}

	async Task OpenNewTeacherDialog(ShokouhPardisTeacherClass teacher)
	{
		var dialogReference = DialogService.Show<TeacherDefinitionDialog>(
			(teacher.Id > 0 ? "Edit " : "New ") + "Teacher ",
			new DialogParameters
			{
				["Teacher"] = teacher
			},
			new DialogOptions()
			{
				CloseButton = true,
				MaxWidth = MaxWidth.Large
			});
		var dialogResult = await dialogReference.Result;
		if (dialogResult.Cancelled == false)
		{
			var retData = (ShokouhPardisTeacherClass)dialogResult.Data;
			var result = DataProvider.SaveEditTeacher(retData);
			//TODO: check if- if edit dont say teacher is duplicate
			if (result)
			{
				var parameters = new DialogParameters();

				bool? result1 = await DialogService.ShowMessageBox(
					"خطا",
					(MarkupString)
					@$"مدرسی با این مشخصات قبلا ذخیره شده است!
                        <br/>{retData.TeacherName}
                        <br/>{retData.TeacherFamily}",
					yesText: "متوجه شدم!");
			}
			else
			{
				Snackbar.Add("با موفقیت ذخیره شد.", Severity.Success);
				Log.ForContext("Activity", true).ForContext("EntityType", "TeacherClass").ForContext("EntityId", retData.Id)
					.Warning("User {UserName} Save TeacherClass {TeacherClassId}", _userSession.Payload.UserName, retData.Id);
			}

			RefreshData();
			StateHasChanged();
		}
	}
	private string RowStyleFunc(ShokouhPardisTeacherClass teacher, int index)
	{
		switch (teacher.TeacherSex)
		{
			case true:
				return "background-color:rgba(32, 156, 247, 0.2);";
			case false:
				return "background-color:rgba(243, 4, 4, 0.2);";
			default: return "background-color:white";

		}
	}

	[Inject] ISnackbar snackbar { get; set; }


	private async Task UserInfoClick(ShokouhPardisTeacherClass teacher)
	{
		if (teacher.TeacherNationalId.IsEmpty())
		{
			snackbar.Add("This teacher has not National Id so we can not assign or create User account.", Severity.Warning);
			return;
		}
            
		var teacherRole = GetTeacherRole();

		User? user = DataProvider.GetUserByUserName(teacher.TeacherNationalId);
		if (user == null)
		{
			snackbar.Add("This teacher does not have an account,So we create one.");
			user = new User()
			{
				FirstName = teacher.TeacherName,
				LastName = teacher.TeacherFamily,
				UserName = teacher.TeacherNationalId!,
				Password = teacher.TeacherNationalId + "000",
				Gender = teacher.TeacherSex,
				IsActive = true
			};
			user.Roles.Add(teacherRole);
			DataProvider.SaveUser(user);
			teacher.UserId = user.Id;
			DataProvider.SaveEditTeacher(teacher);
			Log.ForContext("Activity", true).ForContext("EntityType", "Teacher").ForContext("EntityId", teacher.Id)
				.Warning("User {UserName} Save-Update Teacher {TeacherId}", _userSession.Payload.UserName, teacher.Id);
		}

		await DialogService.ShowAsync<UserDialog>("Teacher Account", new DialogParameters()
		{
			["User"] = user
		});
	}

	private Role GetTeacherRole()
	{
		var teacherRole = DataProvider.GetRoleByName("Teacher");
		if (teacherRole == null)
		{
			teacherRole = new Role()
			{
				Name = "Teacher"
			};
			DataProvider.SaveRole(teacherRole);
		}

		return teacherRole;
	}
}