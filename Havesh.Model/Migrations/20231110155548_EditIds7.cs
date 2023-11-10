using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Havesh.Model.Migrations
{
    /// <inheritdoc />
    public partial class EditIds7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "StatementParsianM",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "StatementMeliN",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "YearClassID",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "WeekDayID",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TimeTableStudentsID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TimeTableID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TermClassID",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeacherTimeSheetID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeacherLevelsID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TeacherClassID",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentClassID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentClassID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "StudentClassID",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ScheduleID",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProgramID",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LevelClassID",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LevelBookPriceID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DailyJVID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IntervalID",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Finance_FlatID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DaySessionID",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClassRoomID",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BookClassID",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AccountingTransactionID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AccountingCodeID",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "StatementParsianM",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "StatementMeliN",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_YearClass",
                newName: "YearClassID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_WeekDay",
                newName: "WeekDayID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                newName: "TimeTableStudentsID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                newName: "TimeTableID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                newName: "TermClassID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                newName: "TeacherTimeSheetID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                newName: "TeacherLevelsID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                newName: "TeacherClassID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                newName: "StudentClassID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                newName: "StudentClassID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                newName: "StudentClassID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                newName: "ScheduleID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_Program",
                newName: "ProgramID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                newName: "LevelClassID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                newName: "LevelBookPriceID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                newName: "DailyJVID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                newName: "IntervalID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                newName: "Finance_FlatID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                newName: "EmployeeID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                newName: "DaySessionID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                newName: "ClassRoomID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                newName: "BookClassID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                newName: "AccountingTransactionID");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                newName: "AccountingCodeID");
        }
    }
}
