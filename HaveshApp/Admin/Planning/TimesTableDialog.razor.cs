using Microsoft.AspNetCore.Components;
using MudBlazor;
using HaveshApp.Model;
using HaveshApp.Services;

namespace HaveshApp.Admin.Planning
{
    public partial class TimesTableDialog
    {

        [CascadingParameter]
        MudDialogInstance DialogInstance { get; set; }

        [Parameter]
        public ShokouhPardisTimeTable? TimeTableItem { get; set; }

        [Inject] DataProviderService DataProvider { get; set; }
        [Parameter]
        public ShokouhPardisTermClass TermPram { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }
        [Parameter]
        public EventCallback<ShokouhPardisTermClass> TermPramChanged { get; set; }

        List<ShokouhPardisTeacherTimeSheet>? _teacherTimeSheet;

        ShokouhPardisLevelBookPrice? _bookPrice;
        private ShokouhPardisClassRoom _classRoom;
        private List<ShokouhPardisSchedule> _scheduleList;


        protected override void OnAfterRender(bool firstRender)
        {

            if (firstRender)
            {
                TimeTableItem.Term = TermPram;
                _teacherTimeSheet = GetTimeSheet(TimeTableItem);
                _bookPrice = GetBookPrice(TimeTableItem);

                StateHasChanged();
            }
            base.OnAfterRender(firstRender);
        }

        private void CloseDialogClick()
        {
            DialogInstance.Cancel();
        }



        private async Task SaveDialogClick()
        {
            await _form.Validate();
            if (!_form.IsValid)
            {
                // if (TimeTableItem?.ClassRoom == null)
                // {
                //     _form.Errors.ForEach(x => Snackbar.Add(x , Severity.Info));
                //     //Snackbar.Add("کلاس باید انتخاب شود.", Severity.Error);
                // }

                return;
            }

            DialogInstance.Close(DialogResult.Ok(TimeTableItem));
        }


        /*
        ShokouhPardisTeacherClass Teacher
        {
            get
            {
                return TimeTableItem.Teacher;
            }
            set
            {
                TimeTableItem.Teacher = value;
                _teacherTimeSheet = GetTimeSheet(TimeTableItem);
            }
        }*/


        ShokouhPardisClassRoom ClassRoom
        {
            get => _classRoom;
            set
            {
                _classRoom = value;
            }
        }

        ShokouhPardisLevelClass Level
        {
            get
            {
                return TimeTableItem.Level;

            }
            set
            {
                TimeTableItem.Level = value;
                _bookPrice = GetBookPrice(TimeTableItem);
            }
        }

        public List<ShokouhPardisSchedule> ScheduleList
        {
            get
            {
                _scheduleList = DataProvider.GetSchedules(TermPram);
                return _scheduleList;
            }
            set => _scheduleList = value;
        }


        List<ShokouhPardisTeacherTimeSheet>? GetTimeSheet(ShokouhPardisTimeTable? timeTable)
        {
            if (timeTable is { Term: { }, Teacher: { } })
            {
                return DataProvider.GetTermTeacherTimeSheets(
                    timeTable.Term.TermClassId,
                    timeTable.Teacher.TeacherClassId);
            }
            return null;
        }

        private ShokouhPardisLevelBookPrice? GetBookPrice(ShokouhPardisTimeTable? timeTable)
        {
            if (timeTable.Level is { })
            {
                return DataProvider.GetLevelBookPrice(timeTable);

            }
            return null;
        }

        private MudForm _form;

    }
}
