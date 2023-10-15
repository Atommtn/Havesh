using Microsoft.AspNetCore.Components;
using MudBlazor;
using HaveshApp.Model;

namespace HaveshApp.Admin.Definition.LessonPlan
{
    public partial class SectionDefinitionDialog
    {


        [CascadingParameter]
        MudDialogInstance DialogInstance { get; set; }

        [Parameter]
        public Model.LessonPlan? LessonPlan { get; set; }

        public List<LessonPlanSection> Sections { get; set; }

        MudTable<LessonPlanSection>? table;

        protected override void OnInitialized()
        {
            RefreshData();
            base.OnInitialized();
        }

        private void RefreshData()
        {

            Sections = _dataProvider.GetLessonPlanSection(LessonPlan);

        }
        private void CloseDialogClick()
        {
            DialogInstance.Cancel();
        }

        private void SaveDialogClick()
        {
            DialogInstance.Close(LessonPlan);
        }

        private void NewSectionClick()
        {
            throw new NotImplementedException();
        }


        private Task EditButtonClick(LessonPlanSection section)
        {
            throw new NotImplementedException();
        }

        private Task AddSectionItemClick(LessonPlanSection section)
        {
            throw new NotImplementedException();
        }

    }
}
