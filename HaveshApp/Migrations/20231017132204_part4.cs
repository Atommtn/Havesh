using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
	/// <inheritdoc />
	public partial class part4 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AddForeignKey(
	name: "FK_ShokouhPardis_AccountingCode_Branch_BranchFk",
	schema: "ShoukouhPardis12DBAdmin",
	table: "ShokouhPardis_AccountingCode",
	column: "BranchFk",
	principalSchema: "ShoukouhPardis12DBAdmin",
	principalTable: "Branch",
	principalColumn: "Id",
	onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_AccountingTransaction_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_AccountingTransaction",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_BookClass_Branch_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_BookClass",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_ClassRoom_Branch_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_ClassRoom",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_DailyJV_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_DailyJV",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_DaySession_Branch_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_DaySession",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_Employee_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_Employee",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_FileAttachment_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_FileAttachment",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_Finance_Flat_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_Finance_Flat",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_Interval_Branch_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_Interval",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_JVFromSite_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_JVFromSite",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_LessonPlan_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LessonPlan",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_LessonPlanSection_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LessonPlanSection",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_LessonPlanSectionType_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LessonPlanSectionType",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_LevelBookPrice_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LevelBookPrice",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_LevelClass_Branch_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_LevelClass",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_MediaAttachment_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_MediaAttachment",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_PreRegistration_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_PreRegistration",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_schedule_Branch_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_schedule",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_SessionActivity_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_SessionActivity",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_StudentClass_Branch_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_StudentClass",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_StudentClass_Dto_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_StudentClass_Dto",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_StudentClass_OnlineForm_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_StudentClass_OnlineForm",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_StudentSessionActivity_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_StudentSessionActivity",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TeacherClass_Branch_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_TeacherClass",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TeacherLevels_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TeacherLevels",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TeacherTermClass_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TeacherTermClass",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TeacherTimeSheet_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TeacherTimeSheet",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TermClass_Branch_BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_TermClass",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TermSessionTemplate_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TermSessionTemplate",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TermSessionTemplateDate_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TermSessionTemplateDate",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TimeTable_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TimeTable",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TimeTableSession_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TimeTableSession",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);

			migrationBuilder.AddForeignKey(
				name: "FK_ShokouhPardis_TimeTableStudents_Branch_BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TimeTableStudents",
				column: "BranchFk",
				principalSchema: "ShoukouhPardis12DBAdmin",
				principalTable: "Branch",
				principalColumn: "Id",
				onDelete: ReferentialAction.NoAction);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{

		}
	}
}
