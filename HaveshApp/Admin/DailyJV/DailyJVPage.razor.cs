using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using ShokouhApp.Admin.Student;
using ShokouhApp.Model;
using ShokouhApp.Services;
using System.Globalization;
using System.Linq;
using ShokouhApp.Admin.Components;
using static MudBlazor.CategoryTypes;
using System.Collections.Generic;
using System.Xml;
using Amazon.Util;
using Serilog;
using ShokouhApp.Admin.Authentication;
using ShokouhApp.Admin.DailyJV.Components;
using ShokouhApp.Classes;

namespace ShokouhApp.Admin.DailyJV
{
    public partial class DailyJVPage
    {

        
        [Inject] IDialogService DialogService { get; set; }
        [Inject] ISnackbar Snackbar { get; set; }
        [Inject] NavigationManager NavigationManager { get; set; }
        
        ShokouhPardisStudentClass? _selectedStudent;
        public ShokouhPardisTermClass SelectedTerm { get; set; }
        
        MudTabs? tabs;
        
        public TimeSpan? ts { get; set; }
        ShokouhPardisTimeTable _timeTable;
        ShokouhPardisLevelBookPrice? _price;
        ShokouhPardisLevelClass? _selectedLevel;
        ShokouhPardisDailyJv _dailyJV;
        
        public bool[] TabDisabled { get; set; } = { false, true, true };

        public CultureInfo _ir = new CultureInfo("fa-Ir");
        bool initComplete = false;

        private bool IsOutOfIns
        {
            get { return _isOutOfIns; }
            set
            {
           
                _isOutOfIns = value;
                if (value)
                {
                    _selectedStudent.StudentName = OutOfInsFullName;
                }
            }
        }

        bool DataLoading;
        private bool _isOutOfIns;
        private DailyJvRecordListComponent _dailyJVListComponent;

        public string? OutOfInsFullName { get; set; }
        
        void Init()
        {
            if (initComplete)
                return;
            DataLoading = true;
            StateHasChanged();
            IsOutOfIns = false;
            initComplete = true;

            _ir.NumberFormat.CurrencyDecimalDigits = 0;
            _ir.NumberFormat.CurrencySymbol = "تومان";
            StateHasChanged();
            Reset();
        }

        void Reset()
        {
            _dailyJV = ShokouhPardisDailyJv.CreateNewDailyJV();
            _dailyJV.CurrentDate = _userSession.LastJvDate;
            _selectedStudent = null;
            Activate(0);
        }

        protected override void OnInitialized()
        {
             Init();
            base.OnInitialized();
        }

        async Task SelectStudentClick()
        {

            var dialogReference = await DialogService.ShowAsync<StudentListDialog>("Select Students",
                new DialogParameters()
                {
                    ["SelectSingle"] = true,
                },
                new DialogOptions()
                {
                    CloseButton = true,
                    MaxWidth = MaxWidth.ExtraLarge,
                    FullWidth = true
                });
            var dialogReferenceResult = await dialogReference.Result;
            if (dialogReferenceResult.Cancelled == false)
            {
                if (dialogReferenceResult.Data is List<ShokouhPardisStudentClass> { Count: > 0 } selectedStudents)
                {
                    _selectedStudent = selectedStudents.First();
                    _dailyJV.Student = _selectedStudent;
                    _dailyJV.StudentId = _selectedStudent.StudentClassId;
                    SelectedLevel = await GetStudentLevel(_selectedStudent, SelectedTerm);
                    if (SelectedLevel == null)
                        NavigationManager.NavigateTo("/dailyJv/", true);
                    StateHasChanged();
                    _dailyJV.FeeFor = FeeForStatuses.TuitionAmount;
                    _dailyJV.PaymentType = PaymentTypeStatuses.Pos;
                    if (_price is null)
                    {
                        _dailyJV.Fee = 0;
                        _snackBar.Add("برای این سطح قیمتی مشخص نشده", Severity.Warning);
                    }
                    else
                    {
                        _dailyJV.Fee = _price.TuitionAmount;
                    }
                }
            }
        }

        CultureInfo GetPersianCulture()
        {
            var culture = new CultureInfo("fa-IR");
            return culture;
        }

        async Task Activate(int index)
        {

            DiabledAllTab(index);
            StateHasChanged();
            await Task.Delay(5);
            await InvokeAsync(() =>
            {
                tabs?.ActivatePanel(index);

            });
            StateHasChanged();
        }

        void DiabledAllTab(int index)
        {
            for (int i = 0; i < 2; i++)
            {
                TabDisabled[i] = true;
            }
            TabDisabled[index] = false;

        }


        void SetDay(int i)
        {
            if (_dailyJV.CurrentDate == DateTime.Today && i == 1)
            {
                return;
            }
            else
            {
                _dailyJV.CurrentDate = _dailyJV.CurrentDate?.AddDays(i);
                StateHasChanged();

            }

        }


        async Task SaveClick()
        {
            _dailyJV.TermId = SelectedTerm.TermClassId;
            _dailyJV.TimeTableFk= _timeTable.TimeTableId;
            _dailyJV.DateOfSettle += ts;
            if (_dailyJV.CurrentDate == DateTime.Today)
            {
                _dailyJV.CurrentDate = DateTime.Today;
                _dailyJV.BillNo = _dailyJV.DailyJvid;
            }

            //if (IsOutOfIns)
            //{
                
            //    _dailyJV.Description = $"فروش آزاد غیر از زبان آموزان آموزشگاه --- {OutOfInsFullName}";
            //    _dailyJV.BillNo = 0;
            //}

            try
            {
                _dataProvider.SaveDailyJV(_dailyJV);
                _userSession.LastJvDate = _dailyJV.CurrentDate;
                Snackbar.Add("اطلاعات با موفقیت ذخیره شد", Severity.Success);
                Log.Warning("User {UserName} Create DailyJV '{DailyJvid}'.", _userSession.Payload?.UserName , _dailyJV.DailyJvid);
                await _dailyJVListComponent.FilterData();
                Reset();

            }
            catch (Exception e)
            {
                Snackbar.Add(e.Message, Severity.Error);
            }
            //NavigationManager.NavigateTo(NavigationManager.Uri);

        }


        async Task<ShokouhPardisLevelClass?> GetStudentLevel(ShokouhPardisStudentClass? student, ShokouhPardisTermClass term)
        {
            if (student != null)
            {
                _timeTable = _dataProvider.GetStudetnLevel(student, term)!;
                if (_timeTable == null)
                {

                    var parameters = new DialogParameters();
                    parameters.Add("ContentText", "این دانش آموز در این ترم در هیچ کلاسی ثبت نام نشده است. اول می بایست به یک کلاس اضافه شود.");
                    parameters.Add("ButtonText", "متوجه شدم");
                    parameters.Add("Color", Color.Error);

                    var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

                    var dialog = DialogService.Show<AlertDialog>("خطا", parameters, options);
                    var result = await dialog.Result;
                    return null;
                }
                return _timeTable.Level;
            }


            return null;
        }

        ShokouhPardisLevelClass? SelectedLevel
        {
            get => _selectedLevel;
            set
            {
                _selectedLevel = value;
                _dailyJV.PaymentType = null;
                FeeFor = null;
                _dailyJV.Fee = 0;
                if (_selectedLevel != null)
                    _price = _dataProvider.GetLevelBookPrice(SelectedTerm.TermClassId,_selectedLevel.LevelClassId);
            }
        }

        public string? FeeFor
        {
            get => _dailyJV.FeeFor;
            set
            {
                _dailyJV.FeeFor = value;
                if (_dailyJV.FeeFor == null)
                    return;

                int? x = 0;
                if (_dailyJV.FeeFor.Contains("شهریه"))
                {
                    x = _price.TuitionAmount;
                }

                if (_dailyJV.FeeFor.Contains("کتاب"))
                {

                    x += _price.BookPrice;
                }

                Console.WriteLine("*********");
                _dailyJV.Fee = (int)x;
            }
        }

        
    }


}
