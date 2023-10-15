using Microsoft.AspNetCore.Components;
using MudBlazor;
using Serilog;
using HaveshApp.Model;

namespace HaveshApp.Admin.Definition.LessonPlan
{
    public partial class LessonPlanDefinitionPage
    {

        [Inject] IDialogService DialogService { get; set; }

        [Inject] ISnackbar Snackbar { get; set; }

        MudTable<Model.LessonPlan>? table;

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
            LessonPlans = _dataProvider.GetLessonPlan(SelectedLevel.LevelClassId);

        }

        public List<Model.LessonPlan> LessonPlans { get; set; }


        private ShokouhPardisLevelClass _selectedLevel;

        async Task EditButtonClick(Model.LessonPlan lessonPlan)
        {
            await OpenNewLessonPlanDialog(lessonPlan);
        }

        private async Task OpenNewLessonPlanDialog(Model.LessonPlan lessonPlan)
        {
            var dialogReference = DialogService.Show<LessonPlanDefinitionDialog>(
                (lessonPlan.LessonPlanId > 0 ? "ویرایش " : "جدید ") + "لسن پلن ",
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
                    var retData = (Model.LessonPlan)dialogResult.Data;
                    var result = _dataProvider.SaveEditlessonPlan(retData);

                    if (result)
                    {
                        var parameters = new DialogParameters();

                        bool? result1 = await DialogService.ShowMessageBox(
                            "خطا",
                            (MarkupString)
                            @$"برای این سطح و این شماره سیشن قبلا لسن پلن نوشته شده است
                        <br/>{retData.Level.LevelName}
                        <br/>{retData.SessionNumber}",
                            yesText: "متوجه شدم!");
                    }
                    else
                    {
                        Snackbar.Add("لسن پلن با موفقیت ذخیره شد.", Severity.Success);
                        Log.Warning("User {UserName} Save-Update LessonPlan {lessonPlanID}",
                            _userSession.Payload.UserName, retData.LessonPlanId);
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
            Model.LessonPlan lessonPlan = Model.LessonPlan.CreateLessonPlan();
            lessonPlan.SessionNumber = _dataProvider.GetLessonPlanSessionNo(SelectedLevel);
            lessonPlan.LevelFk = SelectedLevel.LevelClassId;
            await EditButtonClick(lessonPlan);
        }

        private async Task AddSectionClick(Model.LessonPlan lessonPlan)
        {
            var dialogReference = DialogService.Show<SectionDefinitionDialog>(
                (lessonPlan.LessonPlanId > 0 ? "Edit " : "New ") + "Section ",
                new DialogParameters
                {
                    ["LessonPlan"] = lessonPlan
                },
                new DialogOptions()
                {
                    CloseButton = true,
                    MaxWidth = MaxWidth.Large
                });
            var dialogResult = await dialogReference.Result;
            if (dialogResult.Canceled == false)
            {
            }
            RefreshData();
            StateHasChanged();
        }
    }
}
