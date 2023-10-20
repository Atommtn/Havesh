using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HaveshApp.Migrations
{
    /// <inheritdoc />
    public partial class part1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.AddColumn<int>(
	name: "BranchFk",
	schema: "ShoukouhPardis12DBAdmin",
	table: "ShokouhPardis_TimeTableStudents",
	type: "int",
	nullable: false,
	defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TimeTableSession",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TimeTable",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TermSessionTemplateDate",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TermSessionTemplate",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_TermClass",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TeacherTimeSheet",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TeacherTermClass",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_TeacherLevels",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_TeacherClass",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_StudentSessionActivity",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_StudentClass_OnlineForm",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_StudentClass_Dto",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_StudentClass",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_SessionActivity",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_schedule",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_PreRegistration",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_MediaAttachment",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_LevelClass",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LevelBookPrice",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LessonPlanSectionType",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LessonPlanSection",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_LessonPlan",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_JVFromSite",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_Interval",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_Finance_Flat",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_FileAttachment",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_Employee",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_DaySession",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_DailyJV",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_ClassRoom",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "dbo",
				table: "ShokouhPardis_BookClass",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_AccountingTransaction",
				type: "int",
				nullable: false,
				defaultValue: 0);

			migrationBuilder.AddColumn<int>(
				name: "BranchFk",
				schema: "ShoukouhPardis12DBAdmin",
				table: "ShokouhPardis_AccountingCode",
				type: "int",
				nullable: false,
				defaultValue: 0);
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
