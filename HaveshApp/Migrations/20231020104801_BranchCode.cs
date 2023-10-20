using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class BranchCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_TermClass",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_schedule",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_Interval",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_DaySession",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_BookClass",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Branch",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableStudents");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTableSession");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TimeTable");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplateDate");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TermSessionTemplate");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_TermClass");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTimeSheet");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherTermClass");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_TeacherLevels");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_TeacherClass");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentSessionActivity");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_OnlineForm");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_StudentClass_Dto");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_StudentClass");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_SessionActivity");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_schedule");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_PreRegistration");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_MediaAttachment");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_LevelClass");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LevelBookPrice");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSectionType");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlanSection");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_LessonPlan");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_JVFromSite");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_Interval");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Finance_Flat");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_FileAttachment");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_Employee");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_DaySession");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_DailyJV");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_ClassRoom");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "dbo",
                table: "ShokouhPardis_BookClass");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingTransaction");

            migrationBuilder.DropColumn(
                name: "BCode",
                schema: "ShoukouhPardis12DBAdmin",
                table: "ShokouhPardis_AccountingCode");

            migrationBuilder.DropColumn(
                name: "Code",
                schema: "ShoukouhPardis12DBAdmin",
                table: "Branch");
        }
    }
}
