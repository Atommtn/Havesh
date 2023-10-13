using Microsoft.AspNetCore.Components;
using ShokouhApp.Model;
using ShokouhApp.Services;

namespace ShokouhApp.Admin.Planning
{
    public partial class ClassProgramPage 
    {
      

        [Inject] DataProviderService DataProvider { get; set; }

        List<ShokouhPardisTimeTable>? _tt;
        private ShokouhPardisTermClass? _selectedTerm;

        List<ShokouhPardisClassRoom> _classRooms;
        List<ShokouhPardisInterval>? _intervals;
        List<ShokouhPardisWeekDay> _weekdays;
        Dictionary<int, int>? _timeTablestudentCount;
        bool? _oddEvenSwitch;

        protected override void OnInitialized()
        {
            _weekdays = DataProvider.GetWeekDays();
            _classRooms = DataProvider.GetClassRooms();

            OddEvenSwitch = !(DateTime.Now.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Monday or DayOfWeek.Wednesday);
            _isPm = DateTime.Now.Hour >= 12;
            base.OnInitialized();
        }

        ShokouhPardisTermClass? SelectedTerm
        {
            get => _selectedTerm;
            set
            {
                if (_selectedTerm == value) return;
                _selectedTerm = value;
                InitTimeTables();
            }
        }

        void InitTimeTables()
        {
            _tt = DataProvider.GetTimeTableSchedule(_selectedTerm.TermClassId, IsPm , isPrivate);
            _timeTablestudentCount = DataProvider.GetTimeTableStudentsCount(_selectedTerm);
            _tt.ForEach(t =>
            {
                if (_timeTablestudentCount.TryGetValue(t.TimeTableId, out var zz))
                    t.StudentsCount = zz;
            });
            _intervals = _tt?.SelectMany(x => x.Schedule.Programs.Select(p => p.DaySession.Interval)
                )
                .DistinctBy(x => x.IntervalId)
                .OrderBy(x => x.StartTime)
                .ToList();
            UpdatePrices(_selectedTerm);
        }

        private ShokouhPardisTimeTable GetTimeTable(ShokouhPardisInterval interval, ShokouhPardisClassRoom classRoom, IEnumerable<ShokouhPardisWeekDay> wds)
        {
            if (_tt != null && wds != null)
            {
                var timeTable = _tt.FirstOrDefault(x =>
                    x.ClassRoomId == classRoom.ClassRoomId &&
                    wds.Any() && 
                    x.Schedule.Programs.All(p => wds.Select(w => w.WeekDayId).Contains(p.DaySession.WeekdayId)) &&
                    x.Schedule.Programs.Any(p => p.DaySession.IntervalId == interval.IntervalId)
                    );
                return timeTable;
            }
            return null;
        }

        IEnumerable<ShokouhPardisWeekDay> SelectedWeekdays { get; set; }

        readonly int[] _oddDayIds = { 2, 4 };
        readonly int[] _evenDayIds = { 1, 5 };
        bool _isPm = true;
        bool _showPrices = false;

        public bool? OddEvenSwitch
        {
            get => _oddEvenSwitch;
            set
            {
                if (_oddEvenSwitch == value) return;
                _oddEvenSwitch = value;
                SelectedWeekdays = _oddEvenSwitch is true ?
                    _weekdays.Where(x => _oddDayIds.Contains(x.WeekDayId)) :
                    _weekdays.Where(x => _evenDayIds.Contains(x.WeekDayId));
            }
        }

        public bool IsPm
        {
            get => _isPm;
            set
            {
                if (_isPm == value) return;
                _isPm = value;
                InitTimeTables();
            }
        }
        public bool isPrivate
        {
            get => _isPrivate;
            set
            {
                _isPrivate = value;
                InitTimeTables();
            }
        }
        List<ShokouhPardisLevelBookPrice>? _prices;

        ShokouhPardisTermClass? _pricesForTerm;
        private bool _isPrivate;

        public bool ShowPrices
        {
            get => _showPrices;
            set
            {
                if (_showPrices == value) return;

                _showPrices = value;
                UpdatePrices(SelectedTerm);
            }
        }



        void UpdatePrices(ShokouhPardisTermClass? _term)
        {
            if (!_showPrices || (_prices != null && _pricesForTerm == _term))
                return;

            _prices = DataProvider.GetTermLevelPrices(_term);
            _pricesForTerm = _term;
        }
    }
}
