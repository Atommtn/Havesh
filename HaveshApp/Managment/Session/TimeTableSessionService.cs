using DNTPersianUtils.Core;
using ShokouhApp.Classes;
using ShokouhApp.Model;
using ShokouhApp.Services;
using System.Xml;
using Microsoft.AspNetCore.Components;
using Olive;
using ShokouhApp.Admin.Authentication;
using Log = Serilog.Log;

namespace ShokouhApp.Managment.Session
{
    public class TimeTableSessionService
    {
        readonly DataProviderService _dataProviderService;
        readonly SmsService _smsService;
        private readonly UserSessionService _userSession;

        public Func<TimeTableSession, Task>? OnTimeTableSessionCreated;
        

        public TimeTableSessionService(DataProviderService dataProviderService, SmsService smsService , UserSessionService userSession)
        {
            _dataProviderService = dataProviderService;
            _smsService = smsService;
            _userSession = userSession;
        }

        public TermSessionTemplate? GetMatchedSessionTemplate(ShokouhPardisTimeTable? timeTable)
        {
            if (timeTable == null)
                throw new ArgumentNullException("TimeTable !!!");

            if (timeTable?.Schedule?.Programs == null || timeTable.Schedule.Programs.Count == 0)
            {
                if (timeTable != null)
                    timeTable = _dataProviderService.GetTimeTable(timeTable.TimeTableId);
            }

            var weekdayIds = string.Join(',', timeTable?.Schedule?.Programs.Select(x => x.DaySession.WeekdayId).Order()!);
            var termTemplate = _dataProviderService.GetTermTemplateByWeekdayIds(timeTable!.Term, weekdayIds);

            return termTemplate;

        }

        /// <exception cref="Exception">There is not any Template Assigned for the Term matched by Selected Interval/Days</exception>
        public async Task GenerateTimeTableSessions(ShokouhPardisTimeTable? timeTable)
        {
            if (timeTable is null || _dataProviderService.GetTimeTableSessionsCount(timeTable) > 0)
                return;

            var sessionsTemplate = GetMatchedSessionTemplate(timeTable);
            if (sessionsTemplate is null)
                throw new Exception("There is not any Template Assigned for the Term matched by Selected Interval/Days");

            var dates = _dataProviderService.GetTermSessionTemplateDates(sessionsTemplate);
            TimeSpan? sessionStartTime = null;
            foreach (var date in dates)
            {
                var lp = _dataProviderService.GetLessonPlan(date.SessionNumber, timeTable.LevelId);
                var wd = (int)date.Date?.GetPersianWeekDayNumber();
                var program = Enumerable.FirstOrDefault(timeTable.Schedule.Programs, x => x.DaySession.WeekdayId == wd);
                if (program != null)
                {
                    sessionStartTime = program.DaySession.Interval.StartTime;
                }
                var timeTableSession = new TimeTableSession()
                {
                    SessionNumber = date.SessionNumber,
                    SessionDate = (DateTime)date.Date,
                    SessionTime = (TimeSpan)sessionStartTime,


                    ClassRoomFk = timeTable.ClassRoomId,
                    TimeTableFk = timeTable.TimeTableId,
                    TeacherFk = timeTable.TeacherId,
                    SessionDescription = date.Description,
                    SessionStatus = SessionStatuses.Pending

                };

                _dataProviderService.SaveTimeTableSession(timeTableSession);
                Log.Warning("User {UserName} Save TimeTableSession {TimeTableSessionId}", 
                    _userSession.Payload.UserName, timeTableSession.ID);
                await OnTimeTableSessionCreated?.Invoke(timeTableSession);
            }

        }

        public int GetTermTemplateSessionCount(TermSessionTemplate sessionsTemplate)
        {
            var sessions = _dataProviderService.GetTermSessionTemplateDateCount(sessionsTemplate);
            return sessions;
        }


        public TimeTableSession CancelSession(TimeTableSession origTimeTableSession, DateTime? replDate, TimeSpan? replTime, string? causeItem, string? causeText)
        {
            var replTimeTableSession = new TimeTableSession
            {
                SessionDate = replDate,
                SessionTime = replTime,
                TimeTableFk = origTimeTableSession.TimeTableFk,
                ClassRoomFk = origTimeTableSession.ClassRoomFk,
                TeacherFk = origTimeTableSession.TeacherFk,
                SessionDescription = "جبرانی",
                SessionStatus = SessionStatuses.Pending
            };

            // Save Should run before to get new Time Table Session ID
            replTimeTableSession = _dataProviderService.SaveTimeTableSession(replTimeTableSession);
            Log.Warning("User {UserName} replace TimeTableSession from {TimeTableSessionId} to new {TimeTableSessionId}", 
                _userSession.Payload.UserName, replTimeTableSession.ID,origTimeTableSession.ID);

            origTimeTableSession.ReplacementTimeTableSessionFk = replTimeTableSession.ID;
            origTimeTableSession.SessionStatus = SessionStatuses.Canceled;
            string? x = null;
            if (causeItem.HasValue())
            {
                x = $"بعلت {causeItem}";
                if (causeText.HasValue())
                    x += $"({causeText})";
            }

            origTimeTableSession.SessionDescription += $"کنسل شده {x}";

            var allSessions = _dataProviderService.GetTimeTableSessions(origTimeTableSession.TimeTable).OrderBy(x => x.SessionDate);
            allSessions.Where(x => x.SessionDate > origTimeTableSession.SessionDate).ForEach(x => x.SessionNumber--);
            foreach (var session in allSessions)
            {
                if (replTimeTableSession.SessionDate < session.SessionDate)
                {
                    if (replTimeTableSession.SessionNumber <= 0)
                    {
                        replTimeTableSession.SessionNumber = session.SessionNumber;
                    }

                    session.SessionNumber++;
                }
            }

            _dataProviderService.UpdateTimeTableSessions(allSessions);
            origTimeTableSession.SessionNumber *= -1;
            _dataProviderService.SaveTimeTableSession(origTimeTableSession);
            Log.Warning("User {UserName} replace TimeTableSession from {TimeTableSessionId} to new {TimeTableSessionId}", 
                _userSession.Payload.UserName, replTimeTableSession.ID, origTimeTableSession.ID);
            return replTimeTableSession;
        }

        public void SendSmsForCancelledTimetable(ShokouhPardisTimeTable timeTable, string smsBody, bool? sendToTeacher = true, bool? sendToAdmins = true)
        {
            if (sendToAdmins is true)
            {
                _smsService.SendSms("+989366066252", smsBody);
            }

            if (sendToTeacher is true)
            {
                //timeTable.Teacher.Phone
                _smsService.SendSms("+989122192992", smsBody);
            }

            var students = _dataProviderService.GetTimeTableStudents(timeTable);
            SendSmsToStudents(smsBody, students);

        }
        public void SendSmsForCancelledTimetable(List<ShokouhPardisStudentClass>? students, IEnumerable<string> extPhones, string smsBody, bool? sendToAdmins = true)
        {
            if (sendToAdmins is true) 
                _smsService.SendSms("+989366066252", smsBody);

            foreach (var phone in extPhones)
            {
                _smsService.SendSms(phone, smsBody);
            }

            SendSmsToStudents(smsBody, students);
        }

        public void SendSmsToStudents(string smsBody, List<ShokouhPardisStudentClass>? students)
        {
            if (students != null)
                foreach (var student in students)
                {
                    if (student.WhatsAppPhone.IsNullOrEmpty())
                    {
                        student.Tag = "عدم ارسال بدلیل عدم تعیین شماره همراه";
                    }
                    else
                    {
                        var tag = _smsService.SendSms(student.WhatsAppPhone, smsBody);
                        student.Tag = tag.ToString();
                    }
                }
        }
    }
}
