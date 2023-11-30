using Havesh.Model.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;

namespace HaveshApp.Admin.Definition.LessonPlan;

public partial class LessonPlanDefinitionPage
{

	[Inject] IDialogService DialogService { get; set; }

	[Inject] ISnackbar Snackbar { get; set; }

	MudTable<Havesh.Model.Model.LessonPlan>? table;

	public ShokouhPardisLevelClass SelectedLevel
	{
		get => _selectedLevel;
		set
		{
			if (_selectedLevel == value) return;
			_selectedLevel = value;
			RefreshData();
		}
	}

	private void RefreshData()
	{
		LessonPlans = _dataProvider.GetLessonPlan(SelectedLevel.Id);

	}

	public List<Havesh.Model.Model.LessonPlan> LessonPlans { get; set; }


	private ShokouhPardisLevelClass _selectedLevel;

	async Task EditButtonClick(Havesh.Model.Model.LessonPlan lessonPlan)
	{
		await OpenNewLessonPlanDialog(lessonPlan);
	}

	private async Task OpenNewLessonPlanDialog(Havesh.Model.Model.LessonPlan lessonPlan)
	{
		var dialogReference = DialogService.Show<LessonPlanDefinitionDialog>(
			(lessonPlan.Id > 0 ? "Edit " : "New ") + "LessonPlan ",
			new DialogParameters
			{
				["LessonPlan"] = lessonPlan
			},
			new DialogOptions()
			{
				CloseButton = true,
				MaxWidth = MaxWidth.ExtraLarge
			});

		var dialogResult = await dialogReference.Result;
		if (dialogResult.Canceled == false)
		{
			try
			{
				var retData = (Havesh.Model.Model.LessonPlan)dialogResult.Data;
				var result = _dataProvider.SaveEditlessonPlan(retData);

				if (result)
				{
					var parameters = new DialogParameters();

					bool? result1 = await DialogService.ShowMessageBox(
						"Error",
						(MarkupString)
						@$"For this session number save any LessopnPlan
                        <br/>{retData.Level.LevelName}
                        <br/>{retData.SessionNumber}",
						yesText: "Got it!");
				}
				else
				{
					Snackbar.Add("lesson plan save successfully.", Severity.Success);
					Log.Warning("User {UserName} Save-Update LessonPlan {lessonPlanID}",
						_userSession.Payload.UserName, retData.Id);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(" lesson plan save-edite fail" + ex.Message);

			}

			RefreshData();
			StateHasChanged();
		}

	}

	async Task NewLessonPlanClick()
	{
		Havesh.Model.Model.LessonPlan lessonPlan = Havesh.Model.Model.LessonPlan.CreateLessonPlan();
		lessonPlan.SessionNumber = _dataProvider.GetLessonPlanSessionNo(SelectedLevel);
		lessonPlan.LevelFk = SelectedLevel.Id;
		await EditButtonClick(lessonPlan);
	}

    private async Task SectionTypeClick()
    {
        var dialogReference = DialogService.Show<LessonPlanSectionTypeDialog>(
            "Section Type",
            new DialogOptions()
            {
                CloseButton = true,
                MaxWidth = MaxWidth.Medium
            });
       
    }
}