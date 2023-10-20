using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class part3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.CreateIndex(
	name: "IX_ShokouhPardis_TimeTableStudents_BranchFk",
	schema: "ShoukouhPardis12DBAdmin",
	table: "ShokouhPardis_TimeTableStudents",
	column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_TimeTableSession_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TimeTableSession",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_TimeTable_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TimeTable",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_TermSessionTemplateDate_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TermSessionTemplateDate",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_TermSessionTemplate_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TermSessionTemplate",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_TermClass_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_TermClass",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_TeacherTimeSheet_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TeacherTimeSheet",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_TeacherTermClass_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TeacherTermClass",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_TeacherLevels_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TeacherLevels",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_TeacherClass_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_TeacherClass",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_StudentSessionActivity_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_StudentSessionActivity",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_StudentClass_OnlineForm_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_StudentClass_OnlineForm",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_StudentClass_Dto_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_StudentClass_Dto",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_StudentClass_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_StudentClass",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_SessionActivity_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_SessionActivity",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_schedule_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_schedule",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_PreRegistration_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_PreRegistration",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_MediaAttachment_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_MediaAttachment",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_LevelClass_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_LevelClass",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_LevelBookPrice_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LevelBookPrice",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_LessonPlanSectionType_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LessonPlanSectionType",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_LessonPlanSection_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LessonPlanSection",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_LessonPlan_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LessonPlan",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_JVFromSite_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_JVFromSite",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_Interval_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_Interval",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_Finance_Flat_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_Finance_Flat",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_FileAttachment_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_FileAttachment",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_Employee_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_Employee",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_DaySession_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_DaySession",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_DailyJV_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_DailyJV",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_ClassRoom_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_ClassRoom",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_BookClass_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_BookClass",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_AccountingTransaction_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_AccountingTransaction",
				column: "BranchFk");

			migrationBuilder.CreateIndex(
				name: "IX_ShokouhPardis_AccountingCode_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_AccountingCode",
				column: "BranchFk");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
